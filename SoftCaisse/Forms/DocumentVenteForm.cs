using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Models.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
namespace SoftCaisse.Forms.DocumentVente
{
    /* =========================================================== DÉBUT CONSTRUCTEUR =========================================================== */
    /* ==================================================================================================================================== */
    public partial class DocumentVenteForm : KryptonForm
    {
        private readonly AppDbContext _context;
        private DataTable _bindingSource;
        private Button _boutonActifMaintenant;

        private readonly List<TypeDocument> docs;
        private readonly List<string> listeLangues;

        private List<F_DOCENTETE> listeDocuments;
        private readonly List<F_COMPTET> listeClients;
        private readonly List<P_SOUCHEVENTE> listeSouche;
        private readonly List<F_CAISSE> listeCaisse;
        private readonly List<F_DEPOT> listeDepot;
        private readonly List<P_DEVISE> listeDevise;
        private readonly List<P_EXPEDITION> listeExpedition;
        private readonly List<F_LIVRAISON> listeLivraison;
        private readonly List<P_CONDLIVR> listeCondLivr;
        private readonly List<P_UNITE> listeUnite;
        private readonly List<F_COLLABORATEUR> listeCollab;
        private readonly List<P_CATTARIF> listeCatTarif;
        private readonly P_CATCOMPTA catComptas;
        private readonly List<string> listeCatComptasVente;

        private F_DOCENTETE _selectedDoc;

        public DocumentVenteForm()
        {
            InitializeComponent();

            _context = new AppDbContext();
            _boutonActifMaintenant = btnTous;
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Type"));
            _bindingSource.Columns.Add(new DataColumn("Etat"));
            //_bindingSource.Columns.Add(new DataColumn("Rectifée"));
            _bindingSource.Columns.Add(new DataColumn("N° pièce"));
            _bindingSource.Columns.Add(new DataColumn("Référence"));
            _bindingSource.Columns.Add(new DataColumn("Date"));
            _bindingSource.Columns.Add(new DataColumn("N° client"));
            _bindingSource.Columns.Add(new DataColumn("Intitulé client"));
            _bindingSource.Columns.Add(new DataColumn("Date livraison"));
            _bindingSource.Columns.Add(new DataColumn("Date livraison réalisée"));
            _bindingSource.Columns.Add(new DataColumn("Souche"));
            _bindingSource.Columns.Add(new DataColumn("Affaire"));
            _bindingSource.Columns.Add(new DataColumn("Caisse"));
            //_bindingSource.Columns.Add(new DataColumn("Transféré"));
            //_bindingSource.Columns.Add(new DataColumn("Demande avoir"));
            //_bindingSource.Columns.Add(new DataColumn("E statut"));
            //_bindingSource.Columns.Add(new DataColumn("Coffre-fort"));
            _bindingSource.Columns.Add(new DataColumn("Hors taxe"));
            //_bindingSource.Columns.Add(new DataColumn("N° facture origine"));
            _bindingSource.Columns.Add(new DataColumn("Dépôt"));
            //_bindingSource.Columns.Add(new DataColumn("Contact"));
            _bindingSource.Columns.Add(new DataColumn("Langue"));
            _bindingSource.Columns.Add(new DataColumn("Devise"));
            _bindingSource.Columns.Add(new DataColumn("Mode expédition"));
            _bindingSource.Columns.Add(new DataColumn("Lieu livraison"));
            _bindingSource.Columns.Add(new DataColumn("Condition livraison"));
            _bindingSource.Columns.Add(new DataColumn("Nb colis"));
            _bindingSource.Columns.Add(new DataColumn("Type colisage"));
            _bindingSource.Columns.Add(new DataColumn("Nom représentant"));
            _bindingSource.Columns.Add(new DataColumn("Payeur"));
            //_bindingSource.Columns.Add(new DataColumn("Centrale d'achat"));
            _bindingSource.Columns.Add(new DataColumn("Catégorie tarifaire"));
            _bindingSource.Columns.Add(new DataColumn("Catégorie comptable"));
            //_bindingSource.Columns.Add(new DataColumn("Entête 1"));
            //_bindingSource.Columns.Add(new DataColumn("Entête 2"));
            //_bindingSource.Columns.Add(new DataColumn("Entête 3"));
            //_bindingSource.Columns.Add(new DataColumn("Entête 4"));
            //_bindingSource.Columns.Add(new DataColumn("Début périodicité"));
            //_bindingSource.Columns.Add(new DataColumn("Fin périodicité"));
            //_bindingSource.Columns.Add(new DataColumn("Suivi eFacture"));
            //_bindingSource.Columns.Add(new DataColumn("Document lié"));
            _bindingSource.Columns.Add(new DataColumn("Total HT Net"));
            _bindingSource.Columns.Add(new DataColumn("Total TTC"));
            _bindingSource.Columns.Add(new DataColumn("Solde dû"));
            _bindingSource.Columns.Add(new DataColumn("Commentaires"));


            docs = JsonSerializer.Deserialize<List<TypeDocument>>(File.ReadAllText("E:\\Softwell\\SCDJNM\\SoftCaisse\\DataJSon\\TypeDocument.json"));
            listeLangues = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("E:\\Softwell\\SCDJNM\\SoftCaisse\\DataJSon\\Langue.json"));

            listeDocuments = _context.F_DOCENTETE.ToList();
            listeClients = _context.F_COMPTET.ToList();
            listeSouche = _context.P_SOUCHEVENTE.ToList();
            listeCaisse = _context.F_CAISSE.ToList();
            listeDepot = _context.F_DEPOT.ToList();
            listeDevise = _context.P_DEVISE.ToList();
            listeExpedition = _context.P_EXPEDITION.ToList();
            listeLivraison = _context.F_LIVRAISON.ToList();
            listeCondLivr = _context.P_CONDLIVR.ToList();
            listeUnite = _context.P_UNITE.ToList();
            listeCollab = _context.F_COLLABORATEUR.ToList();
            listeCatTarif = _context.P_CATTARIF.ToList();
            catComptas = _context.P_CATCOMPTA.FirstOrDefault();
            listeCatComptasVente = new List<string> { "", catComptas.CA_ComptaAch01, catComptas.CA_ComptaAch02, catComptas.CA_ComptaAch03, catComptas.CA_ComptaAch04, catComptas.CA_ComptaAch05, catComptas.CA_ComptaAch06, catComptas.CA_ComptaAch07, catComptas.CA_ComptaAch08, catComptas.CA_ComptaAch09, catComptas.CA_ComptaAch10, catComptas.CA_ComptaAch11, catComptas.CA_ComptaAch12, catComptas.CA_ComptaAch13, catComptas.CA_ComptaAch14, catComptas.CA_ComptaAch15, catComptas.CA_ComptaAch16, catComptas.CA_ComptaAch17, catComptas.CA_ComptaAch18, catComptas.CA_ComptaAch19, catComptas.CA_ComptaAch20, catComptas.CA_ComptaAch21, catComptas.CA_ComptaAch22, catComptas.CA_ComptaAch23, catComptas.CA_ComptaAch24, catComptas.CA_ComptaAch25, catComptas.CA_ComptaAch26, catComptas.CA_ComptaAch27, catComptas.CA_ComptaAch28, catComptas.CA_ComptaAch29, catComptas.CA_ComptaAch30, catComptas.CA_ComptaAch31, catComptas.CA_ComptaAch32, catComptas.CA_ComptaAch33, catComptas.CA_ComptaAch34, catComptas.CA_ComptaAch35, catComptas.CA_ComptaAch36, catComptas.CA_ComptaAch37, catComptas.CA_ComptaAch38, catComptas.CA_ComptaAch39, catComptas.CA_ComptaAch40, catComptas.CA_ComptaAch41, catComptas.CA_ComptaAch42, catComptas.CA_ComptaAch43, catComptas.CA_ComptaAch44, catComptas.CA_ComptaAch45, catComptas.CA_ComptaAch46, catComptas.CA_ComptaAch47, catComptas.CA_ComptaAch48, catComptas.CA_ComptaAch49, catComptas.CA_ComptaAch50 };

            AjouterLignesDataGrid(listeDocuments);
            dataGridView1.DataSource = _bindingSource;

            kryptonButtonSuppr.Enabled = false;
        }
        /* =========================================================== FIN CONSTRUCTEUR =========================================================== */
        /* ==================================================================================================================================== */





        /* =========================================================== DEBUT FONCTIONS =========================================================== */
        /* ==================================================================================================================================== */
        private void SelectTabParametres(Button activeButton)
        {
            List<Button> listeBoutons = new List<Button> { btnTous, btnDocsEnCours, btnDevis, btnBonCommande, btnPrepLivr, btnBonLivr, btnBnRetour, btnBnAvrFinancier, btnFacture, btnFactCompt };
            foreach (var btn in listeBoutons)
            {
                if (btn != activeButton)
                {
                    btn.BackColor = SystemColors.ControlLightLight;
                }
                else
                {
                    activeButton.BackColor = Color.LightBlue;
                }
            }
        }

        private void AjouterLignesDataGrid(List<F_DOCENTETE> listeDocEnTete)
        {
            foreach (var doc in listeDocEnTete)
            {
                _bindingSource.Rows.Add(
                    docs[(int)doc.DO_Type].IntituleTypeDocument,
                    doc.DO_Valide == 1 ? "Validé" : "",
                    doc.DO_Piece,
                    doc.DO_Ref,
                    doc.DO_Date?.ToString("dd/MM/yyyy"),
                    doc.CT_NumPayeur,
                    listeClients.Where(c => c.CT_Num == doc.CT_NumPayeur).Select(c => c.CT_Intitule).FirstOrDefault(),
                    doc.DO_DateLivr?.ToString("dd/MM/yyyy") == "01/01/1753" ? "" : doc.DO_DateLivr?.ToString("dd/MM/yyyy"),
                    doc.DO_DateLivrRealisee?.ToString("dd/MM/yyyy") == "01/01/1753" ? "" : doc.DO_DateLivrRealisee?.ToString("dd/MM/yyyy"),
                    listeSouche.Where(s => s.cbMarq - 1 == doc.DO_Souche).Select(s => s.S_Intitule).FirstOrDefault(),
                    doc.CA_Num,
                    (doc.CA_No == 0) ? "" : listeCaisse.Where(c => c.CA_No == doc.CA_No).Select(c => c.CA_Intitule).FirstOrDefault(),
                    doc.DO_TotalHT?.ToString("F2"),
                    (doc.DE_No == 0) ? "" : listeDepot.Where(d => d.DE_No == doc.DE_No).Select(d => d.DE_Intitule).FirstOrDefault(),
                    listeLangues[(int)doc.DO_Langue],
                    (doc.DO_Devise == 0) ? "Aucune" : listeDevise.Where(d => d.cbMarq == doc.DO_Devise).Select(d => d.D_Intitule).FirstOrDefault(),
                    (doc.DO_Expedit == 0) ? "" : listeExpedition.Where(exp => exp.cbMarq == doc.DO_Expedit).Select(exp => exp.E_Intitule).FirstOrDefault(),
                    (doc.LI_No == 0) ? "" : listeLivraison.Where(l => l.LI_No == doc.LI_No).Select(l => l.LI_Intitule + l.LI_Adresse + l.LI_CodePostal + l.LI_Ville).FirstOrDefault(),
                    (doc.DO_Condition == 0) ? "" : listeCondLivr.Where(c => c.cbMarq == doc.DO_Condition).Select(c => c.C_Intitule).FirstOrDefault(),
                    doc.DO_Colisage,
                    (doc.DO_TypeColis == 0) ? "" : listeUnite.Where(u => u.cbMarq == doc.DO_TypeColis).Select(c => c.U_Intitule).FirstOrDefault(),
                    (doc.CO_No == 0) ? "" : listeCollab.Where(c => c.CO_No == doc.CO_No).Select(c => c.CO_Nom + c.CO_Prenom).FirstOrDefault(),
                    doc.CT_NumPayeur ?? "",
                    (doc.DO_Tarif == 0) ? "" : listeCatTarif.Where(c => c.cbMarq == doc.DO_Tarif).Select(c => c.CT_Intitule).FirstOrDefault(),
                    listeCatComptasVente[(int)doc.N_CatCompta],
                    doc.DO_TotalHTNet.ToString("F2"),
                    doc.DO_TotalTTC.ToString("F2"),
                    doc.DO_NetAPayer.ToString("F2"),
                    doc.Commentaires
                );
            }
        }

        private void RefreshDonnees(Button boutonActifMaint, object sender, EventArgs e)
        {
            listeDocuments = _context.F_DOCENTETE.ToList();

            if (boutonActifMaint == btnTous)
            {
                btnTous_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnDocsEnCours)
            {
                btnDocsEnCours_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnDevis)
            {
                btnDevis_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnBonCommande)
            {
                btnBonCommande_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnPrepLivr)
            {
                btnPrepLivr_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnBonLivr)
            {
                btnBonLivr_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnBnRetour)
            {
                btnBnRetour_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnBnAvrFinancier)
            {
                btnBnAvrFinancier_Click(true, sender, e);
            }
            else if (boutonActifMaint == btnFacture)
            {
                btnFacture_Click(true, sender, e);
            }
            else
            {
                btnFactCompt_Click(true, sender, e);
            }
        }
        /* =========================================================== FIN FONCTIONS =========================================================== */
        /* ==================================================================================================================================== */





        /* =========================================================== DÉBUT EVENEMENTS =========================================================== */
        /* ==================================================================================================================================== */
        private void btnCloseDocVentes_Click(object sender, EventArgs e)
        {
            Close();
        }


        // ===================== DEBUT BOUTONS SIDEBAR À GAUCHE =====================
        private void btnTous_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnTous);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnTous || isRefresh == true)
            {
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeDocuments);
                _boutonActifMaintenant = btnTous;
            }
        }

        private void btnDocsEnCours_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnDocsEnCours);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnDocsEnCours || isRefresh == true)
            {
                List<F_DOCENTETE> listeDocsEnCours = listeDocuments.Where(d => d.DO_BLFact == 0).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeDocsEnCours);
                _boutonActifMaintenant = btnDocsEnCours;
            }
        }

        private void btnDevis_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnDevis);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnDevis || isRefresh == true)
            {
                List<F_DOCENTETE> listeDocsDevis = listeDocuments.Where(d => d.DO_Type == 0).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeDocsDevis);
                _boutonActifMaintenant = btnDevis;
            }
        }

        private void btnBonCommande_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnBonCommande);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnBonCommande || isRefresh == true)
            {
                List<F_DOCENTETE> listeBonCommande = listeDocuments.Where(d => d.DO_Type == 1).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeBonCommande);
                _boutonActifMaintenant = btnBonCommande;
            }
        }

        private void btnPrepLivr_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnPrepLivr);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnPrepLivr || isRefresh == true)
            {
                List<F_DOCENTETE> listePrepLivr = listeDocuments.Where(d => d.DO_Type == 2).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listePrepLivr);
                _boutonActifMaintenant = btnPrepLivr;
            }
        }

        private void btnBonLivr_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnBonLivr);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnBonLivr || isRefresh == true)
            {
                List<F_DOCENTETE> listeBonLivr = listeDocuments.Where(d => d.DO_Type == 3).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeBonLivr);
                _boutonActifMaintenant = btnBonLivr;
            }
        }

        private void btnBnRetour_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnBnRetour);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnBnRetour || isRefresh == true)
            {
                List<F_DOCENTETE> listeBonRetour = listeDocuments.Where(d => d.DO_Type == 4).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeBonRetour);
                _boutonActifMaintenant = btnBnRetour;
            }
        }

        private void btnBnAvrFinancier_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnBnAvrFinancier);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnBnAvrFinancier || isRefresh == true)
            {
                List<F_DOCENTETE> listeBonAvrFinance = listeDocuments.Where(d => d.DO_Type == 5).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeBonAvrFinance);
                _boutonActifMaintenant = btnBnAvrFinancier;
            }
        }

        private void btnFacture_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnFacture);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnFacture || isRefresh == true)
            {
                List<F_DOCENTETE> listeFact = listeDocuments.Where(d => d.DO_Type == 6).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeFact);
                _boutonActifMaintenant = btnFacture;
            }
        }

        private void btnFactCompt_Click(bool isRefresh, object sender, EventArgs e)
        {
            // Modification couleur btn on Click
            SelectTabParametres(btnFactCompt);
            kryptonButtonSuppr.Enabled = false;

            // Modification de la liste des documents à afficher
            if (_boutonActifMaintenant != btnFactCompt)
            {
                List<F_DOCENTETE> listeFactCompt = listeDocuments.Where(d => d.DO_Type == 7).ToList();
                _bindingSource.Rows.Clear();
                AjouterLignesDataGrid(listeFactCompt);
                _boutonActifMaintenant = btnFactCompt;
            }
        }
        // ===================== FIN BOUTONS SIDEBAR À GAUCHE =====================


        private void kptBtnNouveau_Click(object sender, EventArgs e)
        {
            NouveauDocumentDeVente nouveauDocumentDeVente = new NouveauDocumentDeVente();
            nouveauDocumentDeVente.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kryptonButtonSuppr.Enabled = e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count;
            if (kryptonButtonSuppr.Enabled)
            {
                string numPiece = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                _selectedDoc = _context.F_DOCENTETE.Where(d => d.DO_Piece == numPiece).FirstOrDefault();
            }
        }

        private void kryptonButtonSuppr_Click(object sender, EventArgs e)
        {
            if (_selectedDoc != null)
            {
                try
                {
                    List<F_DOCLIGNE> listeDocLigne = _context.F_DOCLIGNE.Where(dl => dl.DO_Piece == _selectedDoc.DO_Piece).ToList();

                    // Elaboration liste des F_DOCLIGNEEMPL
                    List<F_DOCLIGNEEMPL> listeDocLigneEmpl = new List<F_DOCLIGNEEMPL>();
                    foreach (var docLigne in listeDocLigne)
                    {
                        listeDocLigneEmpl.Add(_context.F_DOCLIGNEEMPL.Where(dle => dle.DL_No == docLigne.DL_No).FirstOrDefault());
                    }

                    // Mise à jour F_ARTSTOCKEMPL selon les articles présentes dans F_DOCLIGNEEMPL
                    List<F_ARTSTOCKEMPL> listeArtStockEmpl = new List<F_ARTSTOCKEMPL>();
                    foreach (var docLigneEmpl in listeDocLigneEmpl)
                    {
                        string refArt = _context.F_DOCLIGNE.Where(d => d.DL_No == docLigneEmpl.DL_No).Select(d => d.AR_Ref).FirstOrDefault();
                        F_ARTSTOCKEMPL stockEmpl = _context.F_ARTSTOCKEMPL.Where(ase => ase.DP_No == docLigneEmpl.DP_No && ase.AR_Ref == refArt).FirstOrDefault();
                        stockEmpl.AE_QteSto += docLigneEmpl.DL_Qte;
                        _context.F_DOCLIGNEEMPL.Remove(docLigneEmpl);
                        _context.SaveChanges();
                    }

                    // Mise à jour F_ARTSTOCK selon les articles présentes dans F_DOCLIGNE
                    List<F_ARTSTOCK> listeArtStock = new List<F_ARTSTOCK>();
                    foreach (var docLigne in listeDocLigne)
                    {
                        F_ARTSTOCK artStock = _context.F_ARTSTOCK.Where(a => a.AR_Ref == docLigne.AR_Ref && a.DE_No == docLigne.DE_No).FirstOrDefault();
                        artStock.AS_QteSto += docLigne.DL_Qte;
                        _context.F_DOCLIGNE.Remove(docLigne);
                        _context.SaveChanges();
                    }

                    F_DOCREGL docRegl = _context.F_DOCREGL.Where(dr => dr.DO_Piece == _selectedDoc.DO_Piece).FirstOrDefault();
                    _context.F_DOCREGL.Remove(docRegl);
                    _context.SaveChanges();

                    _context.F_DOCENTETE.Remove(_selectedDoc);
                    _context.SaveChanges();

                    RefreshDonnees(_boutonActifMaintenant, sender, e);

                    //_selectedDoc = null;
                    //kryptonButtonSuppr.Enabled = false;
                    Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible d'effectuer la suppression. \nEreur" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aucun document sélectionné pour la suppression.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /* =========================================================== FIN EVENEMENTS =========================================================== */
        /* ==================================================================================================================================== */

    }
}
