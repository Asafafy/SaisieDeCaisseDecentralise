using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.VenteComptoir;
using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Forms.Article
{
    public partial class ArticleARechercher : KryptonForm 
    {
        private readonly AppDbContext _context;

        private readonly ArticleRepository _articleRepository;
        
        private readonly List<DTO.Article> _articles;

        public ArticleARechercher(string searchTerm)
        {
            _context = new AppDbContext();
            _articleRepository = new ArticleRepository(_context);
            _articles = _articleRepository.GetAll().ToList();
            
            InitializeComponent();

            AfficherArticleRechercher(searchTerm);

            Load += ArticleARechercher_Load;
        }

        private void AfficherArticleRechercher(string searchTerm)
        {
            string searchTermToUpper = searchTerm.ToUpper();

            IEnumerable<DTO.Article> articleFiltrer = _articles.Where(article => article.FA_CodeFamille.ToUpper().Contains(searchTermToUpper) ||
                                                                                 article.AR_Design.ToUpper().Contains(searchTermToUpper));
            DataGridViewArticle.Rows.Clear();

            foreach (var article in articleFiltrer)
            {
                var row = new DataGridViewRow();
                row.CreateCells(DataGridViewArticle);
                row.SetValues(article.AR_Ref, article.AR_Design, article.FA_CodeFamille);
                DataGridViewArticle.Rows.Add(row);
            }
        }

        private void AfficherTouT()
        {
            var rows = _articles.Select(article =>
            {
                var row = new DataGridViewRow();
                row.CreateCells(DataGridViewArticle);
                row.SetValues(article.AR_Ref, article.AR_Design, article.FA_CodeFamille);

                return row;
            }).ToArray();

            DataGridViewArticle.Rows.AddRange(rows);
        }

        private void ArticleARechercher_Load(object sender, EventArgs e)
        {
            AfficherTouT();
        }

        private void TextBoxBarreDeRecherche_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = TextBoxBarreDeRecherche.Text;

            AfficherArticleRechercher(searchTerm);
        }

        private void labelParametreFiltre_Click(object sender, EventArgs e)
        { 
            groupBoxFiltre.Visible = !groupBoxFiltre.Visible;

            if(groupBoxFiltre.Visible == true)
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
                MessageBox.Show("Une erreur s'est produite : "+ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    venteComptoirForm?.AjouterArticleDesigne(afRef, afDesign, 1, (decimal)infoSupplementaireArticle.PuHT, puTTC,UniteVente.UniteIntitule);

                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
    }
}
