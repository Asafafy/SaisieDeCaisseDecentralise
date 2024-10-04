using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class NouveauDocumentDeVente : KryptonForm
    {
        MainForm mainForm;
        private readonly List<F_COMPTET> _listeClients;
        private readonly AppDbContext _context;
        private readonly List<F_DOCENTETE> _listeDocuments;
        private readonly string _typeDocument;
        private readonly string _currentDocPieceNo;
        private readonly List<F_DOCREGL> _listeDocRegl;
        private readonly List<F_LIVRAISON> _listeLivraisons;

        // ================================================ DEBUT CONSTRUCTEUR ================================================
        // ====================================================================================================================
        public NouveauDocumentDeVente(string typeDocument, MainForm form)
        {
            InitializeComponent();

            _context = new AppDbContext();
            _typeDocument = typeDocument;
            mainForm = form;

            _listeDocuments = _context.F_DOCENTETE.ToList();
            _listeClients = _context.F_COMPTET.ToList();
            _listeDocRegl = _context.F_DOCREGL.ToList();
            _listeLivraisons = _context.F_LIVRAISON.ToList();


            _currentDocPieceNo = GetCurrentDocNumber(typeDocument, _listeDocuments);

            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;

            ApplyRoundedCorners(tableLayoutPanel3, 30);
            ApplyRoundedCorners(tableLayoutPanel4, 30);
            ApplyRoundedCorners(tableLayoutPanel5, 30);


            List<F_COMPTEA> listePlanAnalitique = _context.F_COMPTEA.ToList();
            List<P_EXPEDITION> listeExpedit = _context.P_EXPEDITION.ToList();
            List<F_COLLABORATEUR> listeCollab = _context.F_COLLABORATEUR.ToList();

            textBox1.Text = _currentDocPieceNo;
            textBox1.Enabled = false;

            comboBoxClient.DataSource = _listeClients.Select(c => c.CT_Num + " - " + c.CT_Intitule).ToList();
            comboBoxClient.SelectedIndex = -1;
            comboBoxStatus.Text = "A comptabiliser";
            comboBoxAffaire.DataSource = listePlanAnalitique.Where(p => p.N_Analytique == 3).Select(p => p.CA_Num + " - " + p.CA_Intitule).ToList();
            comboBoxExpedit.DataSource = listeExpedit.Select(ex => ex.E_Intitule).ToList();
            comboBoxRepresentant.DataSource = listeCollab.Where(c => c.CO_Vendeur == 1).Select(c => c.CO_Nom + " - " + c.CO_Prenom).ToList();

            kptnBtnValider.Enabled = false;



        }
        // ================================================ FIN CONSTRUCTEUR ================================================
        // ==================================================================================================================





        // ================================================ DEBUT FONCTIONS ================================================
        // =================================================================================================================
        private void ApplyRoundedCorners(Control control, int borderRadius)
        {
            control.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                    path.AddArc(new Rectangle(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                    path.AddArc(new Rectangle(0, control.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                    path.CloseAllFigures();

                    control.Region = new Region(path);
                }
            };

            control.Invalidate();
        }
        private string FormatPieceNo(int maxNo, string prefixe)
        {
            string doPieceActu;
            if (maxNo <= 9)
            {
                doPieceActu = prefixe + "0000" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 99 && maxNo > 9)
            {
                doPieceActu = prefixe + "000" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 999 && maxNo > 99)
            {
                doPieceActu = prefixe + "00" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 9999 && maxNo > 999)
            {
                doPieceActu = prefixe + "0" + maxNo.ToString();
                return doPieceActu;
            }
            else if (maxNo <= 99999 && maxNo > 9999)
            {
                doPieceActu = prefixe + maxNo.ToString();
                return doPieceActu;
            }
            else
            {
                return null;
            }
        }
        private int? GetDocTypeNo(string docType)
        {
            if (docType == "Devis")
            {
                return 0;
            }
            else if (docType == "Bon de commande")
            {
                return 1;
            }
            else if (docType == "Préparation de livraison")
            {
                return 2;
            }
            else if (docType == "Bon de livraison")
            {
                return 3;
            }
            else if (docType == "Bon de retour")
            {
                return 4;
            }
            else if (docType == "Bon d'avoir finanicier")
            {
                return 5;
            }
            else if (docType == "Facture")
            {
                return 6;
            }
            else if (docType == "Facture de retour")
            {
                return 16;
            }
            else if (docType == "Facture d'avoir")
            {
                return 19;
            }
            else
            {
                return null;
            }
        }
        private string GetCurrentDocNumber(string docType, List<F_DOCENTETE> listeDocs)
        {
            int maxNumber;
            if (docType == "Devis")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("DE")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "DE");
            }
            else if (docType == "Bon de commande")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BC")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BC");
            }
            else if (docType == "Préparation de livraison")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("PL")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "PL");
            }
            else if (docType == "Bon de livraison")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BL")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BL");
            }
            else if (docType == "Bon de retour")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BR")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BR");
            }
            else if (docType == "Bon d'avoir finanicier")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("BA")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "BA");
            }
            else if (docType == "Facture")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("FA")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "FA");
            }
            else if (docType == "Facture de retour")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("FR")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "FR");
            }
            else if (docType == "Facture d'avoir")
            {
                List<string> listeDOPiece = listeDocs.Where(doc => doc.DO_Piece.StartsWith("FV")).Select(doc => doc.DO_Piece).ToList();
                List<int> listeNumDOPiece = new List<int>();
                if (listeDOPiece.Count() == 0)
                {
                    maxNumber = 1;
                }
                else
                {
                    foreach (var piece in listeDOPiece)
                    {
                        listeNumDOPiece.Add(int.Parse(piece.Substring(2)));
                    }
                    maxNumber = listeNumDOPiece.Max() + 1;
                }
                return FormatPieceNo(maxNumber, "FV");
            }
            else
            {
                return null;
            }
        }
        private (int transaction, int regime) GetTransacEtRegime(string typeDoc)
        {
            if (typeDoc == "Devis" || typeDoc == "Bon de commande" || typeDoc == "Préparation de livraison" || typeDoc == "Bon de livraison" || typeDoc == "Facture")
            {
                return (11, 21);
            }
            else if (typeDoc == "Bon de retour" || typeDoc == "Bon d'avoir finanicier" || typeDoc == "Facture de retour" || typeDoc == "Facture d'avoir")
            {
                return (21, 25);
            }
            else
            {
                return (0, 0);
            }
        }
        private void MettreAJourF_DOCCURRENTPIECE(string typeDoc, string currentPieceNo)
        {
            if (typeDoc == "Devis")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 1).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Bon de commande")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 2).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Préparation de livraison")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 3).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Bon de livraison")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 4).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Bon de retour")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 5).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Bon d'avoir finanicier")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 6).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Facture")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 74).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Facture de retour")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 75).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
            else if (typeDoc == "Facture d'avoir")
            {
                F_DOCCURRENTPIECE fDocCurrent = _context.F_DOCCURRENTPIECE.Where(dc => dc.cbMarq == 76).FirstOrDefault();
                fDocCurrent.DC_Piece = currentPieceNo;
                fDocCurrent.cbModification = DateTime.Now;
                _context.SaveChanges();
            }
        }
        private void InsertNewF_DOCREGL(List<F_DOCREGL> listeDocRegl, string numPieceActu, List<F_COMPTET> listeClients, string typeDocu)
        {
            int? newDrNo = listeDocRegl.Max(element => element.DR_No);
            string CT_NumActu = listeClients[comboBoxClient.SelectedIndex].CT_Num;
            List<F_REGLEMENTT> listeReglT = _context.F_REGLEMENTT.Where(r => r.CT_Num == CT_NumActu).ToList();
            foreach (var reglT in listeReglT)
            {
                DateTime date = DateTime.Now.AddDays((double)reglT.RT_NbJour);
                if (reglT.RT_Condition == 0)
                {
                    List<short?> joursTb = new List<short?>
                    {
                        reglT.RT_JourTb01,
                        reglT.RT_JourTb02,
                        reglT.RT_JourTb03,
                        reglT.RT_JourTb04,
                        reglT.RT_JourTb05,
                        reglT.RT_JourTb06
                    };
                    joursTb.RemoveAll(x => x == 0);
                    int? nextDay = joursTb.Where(d => d >= date.Day).OrderBy(d => d).FirstOrDefault();
                    if (!nextDay.HasValue)
                        nextDay = joursTb.FirstOrDefault();
                    date = new DateTime(date.Year, date.Month, (int)nextDay);
                }
                else if (reglT.RT_Condition == 1)
                {
                    date = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                    // Si le dernier jour du mois est un samedi, revenir au vendredi
                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        date.AddDays(-1);
                    }
                    // Si le dernier jour du mois est un dimanche, revenir au vendredi
                    else if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        date.AddDays(-2);
                    }
                }
                else
                {
                    date = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
                }
                //string query = @"
                //    Insert INTO [dbo].[F_DOCREGL] (
                //        [DR_No]
                //        [DO_Domaine],
                //        [DO_Type],
                //        [DO_Piece],
                //        [DR_TypeRegl],
                //        [DR_Date],
                //        [DR_Libelle],
                //        [DR_Pourcent],
                //        [DR_Montant],
                //        [DR_MontantDev],
                //        [DR_Equil],
                //        [EC_No],
                //        [cbEC_No],
                //        [DR_Regle],
                //        [N_Reglement],
                //        [CA_No],
                //        [DO_DocType],
                //        [cbCreateur],
                //        [DR_RefPaiement],
                //        [DR_AdressePaiement],
                //    )
                //    values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},
                //        {23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39},{40})";

                F_DOCREGL newDocRegl = new F_DOCREGL
                {
                    DR_No = newDrNo + 1,
                    DO_Domaine = 0,
                    DO_Type = 6,
                    DO_Piece = numPieceActu,
                    //cbDO_Piece = numPieceActu,
                    DR_TypeRegl = 2,
                    DR_Date = date,
                    DR_Libelle = "",
                    DR_Pourcent = reglT.RT_VRepart,
                    DR_Montant = 0,
                    DR_MontantDev = 0,
                    DR_Equil = 1,
                    EC_No = 0,
                    cbEC_No = 0,
                    DR_Regle = 0,
                    N_Reglement = 1,
                    CA_No = 3,
                    DO_DocType = (short?)GetDocTypeNo(typeDocu),
                    cbCreateur = "COLS",
                    DR_RefPaiement = null,
                    DR_AdressePaiement = "",
                };
                _context.F_DOCREGL.Add(newDocRegl);
                _context.SaveChanges();
            }
        }
        private void InsertNewF_DOCENTETE(string typeDoc, string noPiece, List<F_COMPTET> listeClients, List<F_LIVRAISON> listeLivr, short? numExpedit, string caNum, int numCaisse, int numCaissier, string expeditInt, DateTime dateLivrRealise, string refer)
        {
            P_EXPEDITION expedit = _context.P_EXPEDITION.Where(exp => exp.E_Intitule == expeditInt).FirstOrDefault();
            DateTime now = DateTime.Now;
            string heureNow = "000" + now.Hour + now.Minute + now.Second;
            int? typeNo = GetDocTypeNo(typeDoc);
            (int, int) tupleTransactionRegime = GetTransacEtRegime(typeDoc);
            F_COMPTET client = listeClients[comboBoxClient.SelectedIndex];
            F_LIVRAISON lieuLivrPrinc = listeLivr.Where(l => l.CT_Num == client.CT_Num && l.LI_Principal == 1).FirstOrDefault();
            F_DOCENTETE newDocEnTete = new F_DOCENTETE
            {
                DO_Domaine = 0,
                DO_Type = (short)typeNo,
                DO_Piece = noPiece,
                DO_Date = DateTime.Now,
                DO_Ref = refer,
                DO_Tiers = client.CT_Num,
                CO_No = client.CO_No,
                cbCO_No = client.CO_No,
                DO_Period = 1,
                DO_Devise = 0,
                DO_Cours = 0,
                DE_No = 1,
                cbDE_No = 1,
                LI_No = lieuLivrPrinc.LI_No,
                cbLI_No = lieuLivrPrinc.LI_No,
                CT_NumPayeur = client.CT_NumPayeur,
                DO_Expedit = numExpedit,
                DO_NbFacture = 1,
                DO_BLFact = 0,
                DO_TxEscompte = client.CT_Taux02,
                DO_Reliquat = 0,
                DO_Imprim = 0,
                CA_Num = caNum,
                DO_Coord01 = "",
                DO_Coord02 = "",
                DO_Coord03 = "",
                DO_Coord04 = "",
                DO_Souche = 0,
                DO_DateLivr = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_Condition = 1,
                DO_Tarif = 1,
                DO_Colisage = 1,
                DO_TypeColis = 1,
                DO_Transaction = (short?)tupleTransactionRegime.Item1,
                DO_Langue = 0,
                DO_Ecart = 0,
                DO_Regime = (short?)tupleTransactionRegime.Item2,
                N_CatCompta = 1,
                DO_Ventile = 0,
                AB_No = 0,
                DO_DebutAbo = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_FinAbo = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_DebutPeriod = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_FinPeriod = new DateTime(1753, 01, 01, 00, 00, 00),
                CG_Num = "4110000",
                DO_Statut = 2,
                DO_Heure = heureNow,
                CA_No = numCaisse,
                cbCA_No = numCaisse,
                CO_NoCaissier = numCaissier,
                cbCO_NoCaissier = numCaissier,
                DO_Transfere = 0,
                DO_Cloture = 0,
                DO_NoWeb = "",
                DO_Attente = 0,
                DO_Provenance = 0,
                MR_No = 0,
                CA_NumIFRS = "",
                DO_TypeFrais = 0,
                DO_ValFrais = expedit.E_ValFrais,
                DO_TypeLigneFrais = 0,
                DO_TypeFranco = 0,
                DO_ValFranco = expedit.E_ValFranco,
                DO_TypeLigneFranco = 0,
                DO_Taxe1 = 20,
                DO_TypeTaux1 = 0,
                DO_TypeTaxe1 = 0,
                DO_Taxe2 = 0,
                DO_TypeTaux2 = 0,
                DO_TypeTaxe2 = 0,
                DO_Taxe3 = 0,
                DO_TypeTaux3 = 0,
                DO_TypeTaxe3 = 0,
                DO_MajCpta = 0,
                DO_Motif = "",
                CT_NumCentrale = null,
                DO_Contact = "",
                DO_FactureElec = 0,
                DO_TypeTransac = 0,
                DO_DateLivrRealisee = dateLivrRealise,
                DO_DateExpedition = new DateTime(1753, 01, 01, 00, 00, 00),
                DO_FactureFrs = null,
                DO_PieceOrig = "",
            };
            _context.F_DOCENTETE.Add(newDocEnTete);
            _context.SaveChanges();
        }
        // ================================================ FIN FONCTIONS ================================================
        // =================================================================================================================





        // ================================================ DEBUT EVENEMENTS =================================================
        // ===================================================================================================================
        private void kptAnnuler_Click(object sender, System.EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Confirmez vous l'annulation de cette facture ?", "Confirmation d'annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBoxClient.SelectedIndex == -1)
            {
                kptnBtnValider.Enabled = false;
            }
            else
            {
                kptnBtnValider.Enabled = true;
            }
        }

        private void kptnBtnValider_Click(object sender, System.EventArgs e)
        {
            short? estBloque = _listeClients.Where(c => c.CT_Num + " - " + c.CT_Intitule == comboBoxClient.Text).Select(c => c.CT_ControlEnc).FirstOrDefault();
            if (estBloque == 2)
            {
                MessageBox.Show("Aucun document ne peut être émis depuis ce client car il est bloqué", "Client bloqué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MettreAJourF_DOCCURRENTPIECE(_typeDocument, _currentDocPieceNo);

                InsertNewF_DOCREGL(_listeDocRegl, _currentDocPieceNo, _listeClients, _typeDocument);

                int numExpedition = comboBoxExpedit.SelectedIndex + 1;
                string caNum = comboBoxAffaire.Text;
                int caisseNumber = mainForm.CaisseNo;
                int caissierNumber = mainForm.CaissierCollabNo;
                string reference = textBox3.Text;
                string expeditIntitule = comboBoxExpedit.Text;
                DateTime dateLivrReal;
                if (dateTimePicker3.Value == null)
                {
                    dateLivrReal = new DateTime(1753, 01, 01);
                }
                else
                {
                    dateLivrReal = dateTimePicker3.Value;
                }
                InsertNewF_DOCENTETE(_typeDocument, _currentDocPieceNo, _listeClients, _listeLivraisons, (short?)numExpedition, caNum, caisseNumber, caissierNumber, expeditIntitule, dateLivrReal, reference);
            }
        }

        // ================= DEBUT RESET DATETIME PICKER (DATE PRÉVU ET RÉALISÉE) =================
        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Long;
        }
        private void dateTimePicker3_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Long;
        }
        private void kryptonButton1_Click(object sender, System.EventArgs e)
        {
            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
        }
        private void kryptonButton4_Click(object sender, System.EventArgs e)
        {
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
        }
        // ================= FIN RESET DATETIME PICKER (DATE PRÉVU ET RÉALISÉE) =================



        // ================================================ FIN EVENEMENTS ===================================================
        // ===================================================================================================================
    }
}
