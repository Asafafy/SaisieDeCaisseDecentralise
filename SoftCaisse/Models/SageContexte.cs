using Objets100cLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SoftCaisse.Models
{
    public class SageContexte
    {
        private static BSCIALApplication100c baseCial = null;
        private static string userPwdGESCO = null;

        private static BSCPTAApplication100c baseCpt = null;
        private static string userPwdCPT = null;
        public AppDbContext _context;

        public SageContexte()
        {
            _context = new AppDbContext();
        }

        public Parameter RetrieveAttribute()
        {
            string serveurFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurCfg.txt");
            string sageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurSage.txt");
            string sageFileObj = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ObjSage.txt");

            string compta = File.ReadAllText(sageFileObj);

            string[] attr = compta.Split('\n');
            Parameter paramters = new Parameter()
            {
                GestionCommercial = attr[0],
                GestionComptabilite = attr[1],
                utilisateur = attr[2],
                password = attr[3]
            };
            return paramters;
        }
        public void openCpt()
        {
            baseCpt = new BSCPTAApplication100c();
            Parameter prt = RetrieveAttribute();
            baseCpt.Name = prt.GestionComptabilite;
            baseCpt.Loggable.UserName = prt.utilisateur;
            baseCpt.Loggable.UserPwd = prt.password;

            try
            {
                baseCpt.Open();

                if (baseCpt.IsOpen)
                {
                    baseCial = new BSCIALApplication100c();
                    baseCial.Name = prt.GestionCommercial;
                    baseCial.Loggable.UserName = prt.utilisateur;
                    baseCial.Loggable.UserPwd = prt.password;
                    baseCial.CptaApplication = baseCpt;
                    try
                    {
                        baseCial.Open();
                    }
                    catch (Exception)
                    {
                        closeCial();
                        MessageBox.Show("Erreur de la connexion à la base de données SAGE GESCOM", "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                closeCpt();
                MessageBox.Show("Erreur de la connexion à la base de données SAGE COMPTA", "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool closeCial()
        {
            try
            {
                baseCial.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool closeCpt()
        {
            try
            {
                baseCpt.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //CREATION FACTURES//
        public List<string> errorsOM = new List<string>();

        public string get_current_piece(string souche)
        {
            openCpt();
            try
            {
                if (baseCial.IsOpen)
                {
                    string piece = baseCial.FactoryParamDocVente.ReadIntitule("Facture").ReadCurrentPiece(baseCial.FactorySoucheVente.ReadIntitule(souche));
                    return piece;
                }

            }
            catch (Exception ex)
            {
                closeCial();
            }
            return null;
        }
        public IBODocument3 createTicket(string devise, string souche, string nAnalytique, string tier, string depot, string nom_vendeur, string prenom_vendeur, string clients, string payeurs, List<Fligne> ligne)
        {
            openCpt();
            try
            {
                if (baseCial.IsOpen)
                {
                    IPMDocument CreeFACTURE = baseCial.CreateProcess_Document(DocumentType.DocumentTypeVenteFacture);
                    IBODocumentVente3 mDoc = (IBODocumentVente3)CreeFACTURE.Document;
                    mDoc.SetDefault();
                    mDoc.Souche = baseCial.FactorySoucheVente.ReadIntitule(souche);
                    mDoc.SetDefaultDO_Piece();
                    mDoc.DO_Date = DateTime.Now;
                    mDoc.DO_DateLivr = DateTime.Now;
                    mDoc.Devise = baseCpt.FactoryDevise.ReadIntitule(devise);
                    mDoc.DO_Ref = "";
                    mDoc.DepotStockage = baseCial.FactoryDepot.ReadIntitule(depot);
                    IBOClient3 client = baseCpt.FactoryClient.ReadNumero(clients);
                    IBOClient3 payeur = baseCpt.FactoryClient.ReadNumero(payeurs);
                    mDoc.CategorieTarif = client.CatTarif;
                    mDoc.CompteG = client.CompteGPrinc;
                    mDoc.Tiers = client;

                    mDoc.TiersPayeur = payeur;
                    IBOCollaborateur collabs = baseCpt.FactoryCollaborateur.ReadNomPrenom(nom_vendeur, prenom_vendeur);
                    mDoc.Collaborateur = collabs;
                    IBOCompteA3 comptes = baseCpt.FactoryCompteA.ReadNumero(baseCpt.FactoryAnalytique.ReadIntitule(nAnalytique), tier);
                    mDoc.CompteA = comptes;

                    mDoc.WriteDefault();
                    //LIGNE//
                    foreach (var item in ligne)
                    {
                        IBOArticle3 art = baseCial.FactoryArticle.ReadReference(item.reference);
                        IBODocumentVenteLigne3 mLig = (IBODocumentVenteLigne3)CreeFACTURE.AddArticle(art, item.quantite);
                        IBODepot3 depots = baseCial.FactoryDepot.ReadIntitule(depot);
                        mLig.Depot = depots;
                        mLig.Collaborateur = collabs;
                        mLig.CompteA = comptes;
                        mLig.SetDefaultRemise();
                        mLig.Remise.FromString(item.remise);
                        mLig.WriteDefault();
                    }


                    if (CreeFACTURE.CanProcess)
                    {
                        CreeFACTURE.Process();
                        return CreeFACTURE.DocumentResult;
                    }
                    else
                    {
                        string str = "";
                        foreach (IFailInfo ifail in CreeFACTURE.Errors)
                        {
                            str += ifail.Text;
                            str += "\n";
                        }
                        MessageBox.Show(str, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            closeCial();
            return null;
        }

        //public IBODocumentVente3 ArchiverDocument(string devise, string souche, string nAnalytique, string tier, string depot, string nom_vendeur, string prenom_vendeur, string clients, List<Fligne> ligne)
        //{
        //    openCpt();
        //    try
        //    {
        //        if (baseCial.IsOpen)
        //        {
        //            IPMDocument CreeFACTURE = baseCial.CreateProcess_Document(DocumentType.DocumentTypeVenteArchive);
        //            IBODocumentVente3 mDoc = (IBODocumentVente3)CreeFACTURE.Document;
        //            mDoc.Souche = baseCial.FactorySoucheVente.ReadIntitule(souche);
        //            mDoc.SetDefaultDO_Piece();
        //            mDoc.DO_Date = DateTime.Now;
        //            mDoc.DO_DateLivr = DateTime.Now;
        //            mDoc.Devise = baseCpt.FactoryDevise.ReadIntitule(devise);
        //            mDoc.DO_Ref = "ticket";
        //            mDoc.DepotStockage = baseCial.FactoryDepot.ReadIntitule(depot);
        //            IBOClient3 client = baseCpt.FactoryClient.ReadNumero(clients);
        //            mDoc.Tiers = client;
        //            IBOCollaborateur collabs = baseCpt.FactoryCollaborateur.ReadNomPrenom(nom_vendeur, prenom_vendeur);
        //            mDoc.Collaborateur = collabs;
        //            IBOCompteA3 comptes = baseCpt.FactoryCompteA.ReadNumero(baseCpt.FactoryAnalytique.ReadIntitule(nAnalytique), tier);
        //            mDoc.CompteA = comptes;
        //            foreach (var item in ligne)
        //            {
        //                IBOArticle3 art = baseCial.FactoryArticle.ReadReference(item.reference);
        //                IBODocumentVenteLigne3 mLig = (IBODocumentVenteLigne3)CreeFACTURE.AddArticle(art, item.quantite);
        //                IBODepot3 depots = baseCial.FactoryDepot.ReadIntitule(depot);
        //                mLig.Depot = depots;
        //                mLig.Collaborateur = collabs;
        //                mLig.CompteA = comptes;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    closeCial();
        //    return null;
        //}






        public IBODocumentReglement ArchiveReglement(F_CREGLEMENT f_CREGLEMENT)
        {
            openCpt();
            try
            {
                if (baseCial.IsOpen)
                {
                    IPMDocument CreeFACTURE = baseCial.CreateProcess_Document(DocumentType.DocumentTypeVenteArchive);
                    IBODocumentVente3 mDoc = (IBODocumentVente3)CreeFACTURE.Document;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            closeCial();
            return null;
        }

        public IBODocumentReglement createReglement(string rg_libelle, DateTime dates, double montant, string reglement, string piece, string devise, string journal)
        {
            openCpt();

            //Piece Facture Cible//
            IPMReglerEcheances pRegler = null;
            try
            {
                if (baseCial.IsOpen)
                {
                    bool isExist = baseCial.FactoryDocumentVente.ExistPiece(DocumentType.DocumentTypeVenteFacture, piece);
                    if (isExist)
                    {
                        IBODocumentVente3 mDoc = baseCial.FactoryDocumentVente.ReadPiece(DocumentType.DocumentTypeVenteFacture, piece);
                        IBOTiersPart3 client = mDoc.TiersPayeur;
                        IBODocumentReglement iReglt = (IBODocumentReglement)baseCial.FactoryDocumentReglement.Create();
                        iReglt.SetDefault();
                        iReglt.TiersPayeur = client;
                        iReglt.RG_Date = dates;
                        iReglt.RG_Libelle = rg_libelle;
                        iReglt.RG_Montant = montant;
                        iReglt.Devise = baseCpt.FactoryDevise.ReadIntitule(devise);
                        iReglt.Reglement = baseCial.CptaApplication.FactoryReglement.ReadIntitule(reglement);
                        iReglt.Journal = baseCial.CptaApplication.FactoryJournal.ReadNumero(journal);
                        iReglt.WriteDefault();
                        pRegler = baseCial.CreateProcess_ReglerEcheances();
                        pRegler.Reglement = iReglt;
                        if (mDoc.FactoryDocumentEcheance.List.Count > 0)
                        {
                            foreach (IBODocumentEcheance3 iEcheance in mDoc.FactoryDocumentEcheance.List)
                            {
                                pRegler.AddDocumentEcheance(iEcheance);
                            }
                        }
                        if (pRegler.CanProcess)
                        {
                            pRegler.Process();
                        }
                        return iReglt;
                    }
                }
            }
            catch (Exception ex)
            {
                string str = "";
                foreach (IFailInfo ifail in pRegler.Errors)
                {
                    str += ifail.Text;
                    str += "\n";
                }
                MessageBox.Show(str, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            closeCial();
            return null;
        }

        public IBODocument3 CreateFACTURE(string devise, string depot, string nAnalytique, string tier, string nom_vendeur, string prenom_vendeur, string clients, string payeurs, List<Fligne> ligne)
        {
            openCpt();

            try
            {
                if (baseCial.IsOpen)
                {
                    //ENTETE//
                    IPMDocument CreeFACTURE = baseCial.CreateProcess_Document(DocumentType.DocumentTypeVenteFacture);

                    IBODocumentVente3 mDoc = (IBODocumentVente3)CreeFACTURE.Document;
                    mDoc.SetDefault();
                    mDoc.SetDefaultDO_Piece();
                    mDoc.DO_Date = DateTime.Now;
                    mDoc.DO_DateLivr = DateTime.Now;
                    mDoc.Devise = baseCpt.FactoryDevise.ReadIntitule(devise);
                    mDoc.DepotStockage = baseCial.FactoryDepot.ReadIntitule(depot);
                    IBOClient3 client = baseCpt.FactoryClient.ReadNumero(clients);
                    IBOClient3 payeur = baseCpt.FactoryClient.ReadNumero(payeurs);
                    mDoc.CategorieTarif = client.CatTarif;
                    mDoc.CompteG = client.CompteGPrinc;
                    mDoc.Tiers = client;
                    mDoc.TiersPayeur = payeur;
                    IBOCollaborateur collabs = baseCpt.FactoryCollaborateur.ReadNomPrenom(nom_vendeur, prenom_vendeur);
                    mDoc.Collaborateur = collabs;
                    IBOCompteA3 comptes = baseCpt.FactoryCompteA.ReadNumero(baseCpt.FactoryAnalytique.ReadIntitule(nAnalytique), tier);
                    mDoc.CompteA = comptes;
                    mDoc.DO_Ref = "";

                    //LIGNE//
                    foreach (var item in ligne)
                    {
                        IBOArticle3 art = baseCial.FactoryArticle.ReadReference(item.reference);
                        IBODocumentVenteLigne3 mLig = (IBODocumentVenteLigne3)CreeFACTURE.AddArticle(art, item.quantite);
                        IBODepot3 depots = baseCial.FactoryDepot.ReadIntitule(depot);
                        mLig.CompteA = comptes;
                        mLig.Collaborateur = collabs;
                        mLig.Depot = depots;
                        mLig.SetDefaultRemise();
                        mLig.Remise.FromString(item.remise);
                    }
                    if (CreeFACTURE.CanProcess)
                    {
                        CreeFACTURE.Process();
                        return CreeFACTURE.DocumentResult;
                    }
                    else
                    {
                        string str = "";
                        foreach (IFailInfo ifail in CreeFACTURE.Errors)
                        {
                            str += ifail.Text;
                            str += "\n";
                        }
                        MessageBox.Show(str, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            closeCial();
            return null;
        }



        // EFA METY NY DOCUMENTS DU TYPE VENTES FA NY ACHATS NO MBOLA TSY METY
        //public IBODocument3 CreerDocument(DocumentType typeDocument, string devise, string depot, string nAnalytique, string tier, string client, string nom_vendeur, string prenom_vendeur, string payeur, string expeditInt, DateTime dateLivr, DateTime dateLivrReal, string reference)
        //{
        //    openCpt();

        //    try
        //    {
        //        if (baseCial.IsOpen)
        //        {
        //            // =============================== Création DOENTETE avec Objet métier ===============================
        //            IPMDocument doc = baseCial.CreateProcess_Document(typeDocument);

        //            List<DocumentType> docTypeVente = new List<DocumentType> { DocumentType.DocumentTypeVenteDevis, DocumentType.DocumentTypeVenteCommande, DocumentType.DocumentTypeVentePrepaLivraison, DocumentType.DocumentTypeVenteLivraison, DocumentType.DocumentTypeVenteReprise, DocumentType.DocumentTypeVenteAvoir };
        //            List<DocumentType> docTypeAchat = new List<DocumentType> { DocumentType.DocumentTypeAchatFacture, DocumentType.DocumentTypeAchatAvoir };

        //            // Création objet dans F_DOCENTETE pour document de type vente (Devis, Bon de commande, Prep Livr, etc.)

        //            if (docTypeVente.Contains(typeDocument))
        //            {
        //                IBODocumentVente3 mDoc = (IBODocumentVente3)doc.Document;

        //                // Valeurs par défaut Docentete
        //                mDoc.SetDefault();
        //                mDoc.SetDefaultDO_Piece();

        //                // Recherches valeurs à mettre à jour
        //                IBOClient3 iboClient = baseCpt.FactoryClient.ReadNumero(client);
        //                IBOClient3 iboPayeur = baseCpt.FactoryClient.ReadNumero(payeur);
        //                IBPExpedition3 exepdition = baseCial.FactoryExpedition.ReadIntitule(expeditInt);

        //                // Propriétés du docentete (Modification valeurs par défaut)
        //                mDoc.DepotStockage = baseCial.FactoryDepot.ReadIntitule(depot);
        //                mDoc.DO_Date = DateTime.Now;
        //                mDoc.CompteG = iboClient.CompteGPrinc;
        //                mDoc.Tiers = iboClient;
        //                mDoc.TiersPayeur = iboPayeur;
        //                mDoc.Expedition = exepdition;
        //                mDoc.DO_DateLivr = dateLivr == null ? new DateTime(1753, 01, 01, 00, 00, 00) : dateLivr;
        //                mDoc.DO_DateLivrRealisee = dateLivrReal == null ? new DateTime(1753, 01, 01, 00, 00, 00) : dateLivrReal;
        //                mDoc.DO_Ref = reference;
        //            }
        //            // Création objet dans F_DOCENTETE pour document de type achat (Factures, etc.)
        //            else
        //            {
        //                //ENTETE//
        //                IPMDocument CreeFACTURE = baseCial.CreateProcess_Document(DocumentType.DocumentTypeVenteFacture);

        //                IBODocumentVente3 mDoc = (IBODocumentVente3)CreeFACTURE.Document;
        //                mDoc.SetDefault();
        //                mDoc.SetDefaultDO_Piece();
        //                mDoc.DO_Date = DateTime.Now;
        //                mDoc.DO_DateLivr = DateTime.Now;
        //                mDoc.DepotStockage = baseCial.FactoryDepot.ReadIntitule(depot);
        //                IBOClient3 iboClient = baseCpt.FactoryClient.ReadNumero(client);
        //                IBOClient3 iboPayeur = baseCpt.FactoryClient.ReadNumero(payeur);
        //                mDoc.CategorieTarif = iboClient.CatTarif;
        //                mDoc.CompteG = iboClient.CompteGPrinc;
        //                mDoc.Tiers = iboClient;
        //                mDoc.TiersPayeur = iboPayeur;
        //                IBOCollaborateur collabs = baseCpt.FactoryCollaborateur.ReadNomPrenom(nom_vendeur, prenom_vendeur);
        //                mDoc.Collaborateur = collabs;
        //                IBOCompteA3 comptes = baseCpt.FactoryCompteA.ReadNumero(baseCpt.FactoryAnalytique.ReadIntitule(nAnalytique), tier);
        //                mDoc.CompteA = comptes;
        //                mDoc.DO_Ref = reference;

        //                //LIGNE//
        //                List<Fligne> ligne = new List<Fligne>();
        //                foreach (var item in ligne)
        //                {
        //                    IBOArticle3 art = baseCial.FactoryArticle.ReadReference(item.reference);
        //                    IBODocumentVenteLigne3 mLig = (IBODocumentVenteLigne3)CreeFACTURE.AddArticle(art, item.quantite);
        //                    IBODepot3 depots = baseCial.FactoryDepot.ReadIntitule(depot);
        //                    mLig.CompteA = comptes;
        //                    mLig.Collaborateur = collabs;
        //                    mLig.Depot = depots;
        //                    mLig.SetDefaultRemise();
        //                    mLig.Remise.FromString(item.remise);
        //                }
        //                if (doc.CanProcess)
        //                {
        //                    doc.Process();
        //                    return doc.DocumentResult;
        //                }
        //                else
        //                {
        //                    string str = "";
        //                    foreach (IFailInfo ifail in doc.Errors)
        //                    {
        //                        str += ifail.Text;
        //                        str += "\n";
        //                    }
        //                    MessageBox.Show(str, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return null;
        //                }
        //            }


        //            // =============================== Mise à jour des colonnes avec SQL Query ou EntityFramework ===============================
        //            //IBOCollaborateur collabs = baseCpt.FactoryCollaborateur.ReadNomPrenom(nom_vendeur, prenom_vendeur);
        //            //if (collabs != null)
        //            //{
        //            //    mDoc.Collaborateur = collabs;
        //            //}
        //            //F_COMPTEA f_COMPTEA = _context.F_COMPTEA.Where(cmta => cmta.CA_Num == nAnalytique).FirstOrDefault();
        //            //var anal = baseCpt.FactoryAnalytique.ReadIntitule(f_COMPTEA.CA_Intitule);
        //            //IBOCompteA3 comptes = baseCpt.FactoryCompteA.ReadNumero(anal, tier);
        //            //mDoc.CompteA = comptes;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "IMPORT", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return null;
        //    }
        //    closeCial();
        //    return null;
        //}


    }
}
