using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.CustomModel;
using SoftCaisse.Forms.VenteComptoir;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms.Article
{
    public partial class ListeArticles : KryptonForm
    {
        private readonly AppDbContext _context;

        private DataTable _bindingSource;

        public ListeArticles(string searchTerm)
        {
            _context = new AppDbContext();
            InitializeComponent();

            var catalogues = _context.F_CATALOGUE.Where(u => u.CL_Niveau == 0).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
            catalogues.Insert(0, new Controle() { item = "Tous", valeur = "0" });
            cmbxFamille.DataSource = catalogues;
            cmbxFamille.DisplayMember = "item";
            cmbxFamille.ValueMember = "valeur";
            cmbxFamille.SelectedIndex = 0;
            afficherTous();
            AfficherArticleRechercher(searchTerm);
        }

        private void AfficherArticleRechercher(string searchTerm)
        {
            string searchTermToUpper = searchTerm.ToUpper();

            if (DataGridViewArticle.DataSource != null && !string.IsNullOrEmpty(searchTerm))
            {
                ((DataTable)DataGridViewArticle.DataSource).DefaultView.RowFilter = DataGridViewArticle.Columns[1].HeaderText.ToString() + " like '%" + searchTermToUpper + "%'";
            }

        }

        private void TextBoxBarreDeRecherche_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = TextBoxBarreDeRecherche.Text;
            AfficherArticleRechercher(searchTerm);
        }

        private void labelParametreFiltre_Click(object sender, EventArgs e)
        {
            if (PanelSousFamille.Visible == true)
            {
                groupBoxFiltre.Visible = true;
            }
            else
            {
                groupBoxFiltre.Visible = !groupBoxFiltre.Visible;
            }
            PanelSousFamille.Visible = false;
            if (groupBoxFiltre.Visible == true)
            {
                LabelParametreFiltre.BackColor = Color.LightSkyBlue;
                DataGridViewArticle.Dock = DockStyle.Bottom;
                DataGridViewArticle.Width = 740;
                DataGridViewArticle.Height = 317;
            }
            else
            {
                LabelParametreFiltre.BackColor = Color.Transparent;
                DataGridViewArticle.Dock = DockStyle.Fill;
            }
        }

        private void ButtonCloseArticle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < DataGridViewArticle.Rows.Count)
                {
                    DataGridViewRow selectedRow = DataGridViewArticle.Rows[e.RowIndex];
                    ButtonOKArticle_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonOKArticle_Click(object sender, EventArgs e)
        {
            try
            {

                if (DataGridViewArticle.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DataGridViewArticle.SelectedRows[0];
                    string afRef = selectedRow.Cells["reference"].Value.ToString();
                    string afDesign = selectedRow.Cells["designation"].Value.ToString();
                    string faCodeFamille = selectedRow.Cells["famille"].Value.ToString();

                    var infoSupplementaireArticle = _context.F_ARTICLE
                        .Where(article => article.AR_Ref == afRef)
                        .Select(article => new
                        {
                            PuHT = article.AR_PrixVen,
                            PuTTC = article.AR_PrixTTC,
                            article.AR_UniteVen,
                        }).FirstOrDefault();

                    var infoSupplementaireArticleTaxe = _context.F_ARTCOMPTA
                        .Where(article => article.AR_Ref == afRef)
                        .Select(article => new
                        {
                            IdentifiantChamp = article.ACP_Champ,
                            CodeTaxeAComptabiliser = article.ACP_ComptaCPT_Taxe1
                        }).FirstOrDefault();

                    var infoSupplementaireTaxe = _context.F_TAXE
                        .Where(article => article.TA_Code == infoSupplementaireArticleTaxe.CodeTaxeAComptabiliser)
                        .Select(article => new
                        {
                            TauxPriseEnCompte = article.TA_Taux,
                        }).FirstOrDefault();
                    var UniteVente = _context.P_UNITE
                        .Where(unite => unite.cbIndice == infoSupplementaireArticle.AR_UniteVen)
                        .Select(unite => new
                        {
                            UniteIntitule = unite.U_Intitule
                        }).FirstOrDefault();

                    decimal puTTC = (decimal)infoSupplementaireArticle.PuTTC;
                    decimal puHT = (decimal)infoSupplementaireArticle.PuHT;
                    decimal tauxTaxe = infoSupplementaireTaxe?.TauxPriseEnCompte ?? 0;

                    VenteComptoirForm venteComptoirForm = Application.OpenForms.OfType<VenteComptoirForm>().FirstOrDefault();

                    puTTC = puHT + (puHT * tauxTaxe / 100);
                    venteComptoirForm?.AjouterArticleDesigne(afRef, afDesign, 1, (decimal)infoSupplementaireArticle.PuHT, puTTC, UniteVente.UniteIntitule);
                    DetailsArticle detailsArticle = new DetailsArticle();
                    detailsArticle.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbxFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controle selectedCat = (Controle)cmbxFamille.SelectedItem;
            if (selectedCat.item == "Tous")
            {
                PanelSousFamille.Visible = false;
                groupBoxFiltre.Visible = false;
                afficherTous();
            }
            else
            {
                var famille1 = _context.F_CATALOGUE.Where(catalogue => catalogue.CL_Intitule == selectedCat.item).FirstOrDefault();
                int? famille1No = famille1.CL_No;
                var article_famille = _context.F_ARTICLE
                                         .Where(article => article.CL_No1.ToString() == selectedCat.valeur)
                                         .OrderBy(article => article.AR_Design)
                                         .ToList();
                afficherArticlesSousCatalogue(article_famille);
                var listeSousFamilles1 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 1 && catal.CL_NoParent.ToString() == selectedCat.valeur).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
                if (listeSousFamilles1.Count() < 1)
                {
                    // LE CATALOGUE 1 SÉLÉCTIONNÉ N'A PAS DE SOUS-FAMILLE.
                    PanelSousFamille.Visible = false;
                    groupBoxFiltre.Visible = false;
                    cmbxSousFamille2.Visible = false;
                    cmbxSousFamille3.Visible = false;
                    cmbxSousFamille4.Visible = false;
                }
                else
                {
                    listeSousFamilles1.Insert(0, new Controle() { item = "Tous", valeur = "0" });
                    cmbxSousFamille2.Visible = true;
                    cmbxSousFamille2.DataSource = listeSousFamilles1;
                    cmbxSousFamille2.DisplayMember = "item";
                    cmbxSousFamille2.ValueMember = "valeur";
                    cmbxSousFamille2.SelectedIndex = 0;
                    groupBoxFiltre.Visible = true;
                    PanelSousFamille.Visible = true;
                    cmbxSousFamille3.Visible = false;
                    cmbxSousFamille4.Visible = false;
                }
            }
        }
        private void cmbxSousFamille2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controle selectedCat = (Controle)cmbxFamille.SelectedItem;
            Controle selectedCat2 = (Controle)cmbxSousFamille2.SelectedItem;
            if (selectedCat2.item == "Tous")
            {
                var articlesTousSousFamilles2 = _context.F_ARTICLE
                                         .Where(article => article.CL_No1.ToString() == selectedCat.valeur)
                                         .OrderBy(article => article.AR_Design)
                                         .ToList();
                afficherArticlesSousCatalogue(articlesTousSousFamilles2);
                cmbxSousFamille3.Visible = false;
                cmbxSousFamille4.Visible = false;
            }
            else
            {
                var articlesSousFamilles2 = _context.F_ARTICLE
                                         .Where(article => article.CL_No1.ToString() == selectedCat.valeur && article.CL_No2.ToString() == selectedCat2.valeur)
                                         .OrderBy(article => article.AR_Design)
                                         .ToList();
                afficherArticlesSousCatalogue(articlesSousFamilles2);
                var listeSousFamilles2 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 2 && catal.CL_NoParent.ToString() == selectedCat2.valeur).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
                if (listeSousFamilles2.Count() < 1)
                {
                    // LE CATALOGUE 2 SÉLÉCTIONNÉ N'A PAS DE SOUS-FAMILLE.
                    cmbxSousFamille3.Visible = false;
                    cmbxSousFamille4.Visible = false;
                }
                else
                {
                    listeSousFamilles2.Insert(0, new Controle() { item = "Tous", valeur = "0" });
                    cmbxSousFamille3.DataSource = listeSousFamilles2;
                    cmbxSousFamille3.DisplayMember = "item";
                    cmbxSousFamille3.ValueMember = "valeur";
                    cmbxSousFamille3.SelectedIndex = 0;
                    groupBoxFiltre.Visible = true;
                    PanelSousFamille.Visible = true;
                    cmbxSousFamille3.Visible = true;
                    cmbxSousFamille4.Visible = false;
                }
            }
        }
        private void cmbxSousFamille3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controle selectedCat = (Controle)cmbxFamille.SelectedItem;
            Controle selectedCat2 = (Controle)cmbxSousFamille2.SelectedItem;
            Controle selectedCat3 = (Controle)cmbxSousFamille3.SelectedItem;
            if (selectedCat3.item == "Tous")
            {
                var articlesTousSousFamilles3 = _context.F_ARTICLE
                                         .Where(article => article.CL_No1.ToString() == selectedCat.valeur && article.CL_No2.ToString() == selectedCat2.valeur)
                                         .OrderBy(article => article.AR_Design)
                                         .ToList();
                afficherArticlesSousCatalogue(articlesTousSousFamilles3);
                cmbxSousFamille4.Visible = false;
            }
            else
            {
                var articlesSousFamilles3 = _context.F_ARTICLE
                                         .Where(article => article.CL_No1.ToString() == selectedCat.valeur && article.CL_No2.ToString() == selectedCat2.valeur && article.CL_No3.ToString() == selectedCat3.valeur)
                                         .OrderBy(article => article.AR_Design)
                                         .ToList();
                afficherArticlesSousCatalogue(articlesSousFamilles3);
                var listeSousFamilles3 = _context.F_CATALOGUE.Where(catal => catal.CL_Niveau == 3 && catal.CL_NoParent.ToString() == selectedCat3.valeur).Select(u => new Controle() { item = u.CL_Intitule, valeur = u.CL_No + "" }).ToList();
                if (listeSousFamilles3.Count() < 1)
                {
                    // LE CATALOGUE 3 SÉLÉCTIONNÉ N'A PAS DE SOUS-FAMILLE.
                    cmbxSousFamille4.Visible = false;
                }
                else
                {
                    listeSousFamilles3.Insert(0, new Controle() { item = "Tous", valeur = "0" });
                    cmbxSousFamille4.DataSource = listeSousFamilles3;
                    cmbxSousFamille4.DisplayMember = "item";
                    cmbxSousFamille4.ValueMember = "valeur";
                    cmbxSousFamille4.SelectedIndex = 0;
                    groupBoxFiltre.Visible = true;
                    PanelSousFamille.Visible = true;
                    cmbxSousFamille3.Visible = true;
                    cmbxSousFamille4.Visible = true;
                }
            }
        }
        private void cmbxSousFamille4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controle selectedCat = (Controle)cmbxFamille.SelectedItem;
            Controle selectedCat2 = (Controle)cmbxSousFamille2.SelectedItem;
            Controle selectedCat3 = (Controle)cmbxSousFamille3.SelectedItem;
            Controle selectedCat4 = (Controle)cmbxSousFamille4.SelectedItem;
            if (selectedCat4.item == "Tous")
            {
                var articlesTousSousFamilles4 = _context.F_ARTICLE
                                         .Where(article => article.CL_No1.ToString() == selectedCat.valeur && article.CL_No2.ToString() == selectedCat2.valeur && article.CL_No3.ToString() == selectedCat3.valeur)
                                         .OrderBy(article => article.AR_Design)
                                         .ToList();
                afficherArticlesSousCatalogue(articlesTousSousFamilles4);
            }
            else
            {
                var articlesSousFamilles4 = _context.F_ARTICLE
                                         .Where(article => article.CL_No1.ToString() == selectedCat.valeur && article.CL_No2.ToString() == selectedCat2.valeur && article.CL_No3.ToString() == selectedCat3.valeur && article.CL_No4.ToString() == selectedCat4.valeur)
                                         .OrderBy(article => article.AR_Design)
                                         .ToList();
                afficherArticlesSousCatalogue(articlesSousFamilles4);
            }
        }
        private void afficherArticlesSousCatalogue(List<F_ARTICLE> listeArticlesSousFamille)
        {
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Designation"));
            _bindingSource.Columns.Add(new DataColumn("Reference"));
            _bindingSource.Columns.Add(new DataColumn("Famille"));
            foreach (var article in listeArticlesSousFamille)
            {
                _bindingSource.Rows.Add(article.AR_Design, article.AR_Ref, article.FA_CodeFamille);
            }
            DataGridViewArticle.DataSource = _bindingSource;
        }
        private void afficherTous()
        {
            var article_famille = _context.F_ARTICLE.Join(_context.F_FAMILLE, post => post.FA_CodeFamille, meta => meta.FA_CodeFamille, (post, meta) => new { Post = post, Meta = meta }).Select(u => new Farticle() { Id = u.Post.cbMarq, Designation = u.Post.AR_Design, Reference = u.Post.AR_Ref, Famille = u.Post.FA_CodeFamille, CL_No1 = u.Meta.CL_No1 + "", CL_No2 = u.Meta.CL_No2 + "" }).OrderBy(u => u.Designation).ToList();
            _bindingSource = new DataTable();
            _bindingSource.Columns.Add(new DataColumn("Designation"));
            _bindingSource.Columns.Add(new DataColumn("Reference"));
            _bindingSource.Columns.Add(new DataColumn("Famille"));
            _bindingSource.Columns.Add(new DataColumn("CL_No1"));
            _bindingSource.Columns.Add(new DataColumn("CL_No2"));
            _bindingSource.Columns.Add(new DataColumn("Id"));
            foreach (var article in article_famille)
            {
                _bindingSource.Rows.Add(article.Designation, article.Reference, article.Famille, article.CL_No1, article.CL_No2, article.Id);
            }
            DataGridViewArticle.DataSource = _bindingSource;
            DataGridViewArticle.Columns["CL_No1"].Visible = false;
            DataGridViewArticle.Columns["CL_No2"].Visible = false;
            DataGridViewArticle.Columns["Id"].Visible = false;
        }
        private void labelTous_Click(object sender, EventArgs e)
        {
            afficherTous();
            cmbxFamille.SelectedIndex = 0;
        }

        private void labelTous_MouseHover(object sender, EventArgs e)
        {
            labelTous.Cursor = Cursors.Hand;
        }
    }
}
