using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.VenteComptoir;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils.Connection;

namespace SoftCaisse.Forms.Article
{
    public partial class ArticleARechercher : KryptonForm 
    {
        private readonly AppDbContext _context;
        private readonly ArticleRepository _articleRepository;
        private readonly List<F_ARTICLE> _articles;

        public ArticleARechercher()
        {
            _context = new AppDbContext();
            _articleRepository = new ArticleRepository(_context);
            _articles = _articleRepository.GetAll().ToList();
            InitializeComponent();

            this.Load += ArticleARechercher_Load;
        }
    private void AfficherTouT()
        {
            var rows = _articles.Select(article =>
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewArticle);
                row.SetValues(article.AR_Ref, article.AR_Design, article.FA_CodeFamille);
                return row;
            }).ToArray();

            dataGridViewArticle.Rows.AddRange(rows);
        }

        private void ArticleARechercher_Load(object sender, EventArgs e)
        {
            AfficherTouT();
        }
        private void textBoxBarreDeRecherche_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxBarreDeRecherche.Text.Trim().ToUpper();

            IEnumerable<F_ARTICLE> articleFiltrer = _articles.Where(article => article.FA_CodeFamille.ToUpper().Contains(searchTerm));
            dataGridViewArticle.Rows.Clear();
            foreach (var article in articleFiltrer)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewArticle);
                row.SetValues(article.AR_Ref, article.AR_Design, article.FA_CodeFamille);
                dataGridViewArticle.Rows.Add(row);
            }
        }

  /*     private void ButtonRechercherArticle_Click(object sender, EventArgs e)
        {
  
        }*/
        private void labelParametreFiltre_Click(object sender, EventArgs e)
        { 
            groupBoxFiltre.Visible = !groupBoxFiltre.Visible;
            if(groupBoxFiltre.Visible == true)
            {
                labelParametreFiltre.BackColor = Color.LightSkyBlue;
                dataGridViewArticle.Dock = DockStyle.Bottom;
                dataGridViewArticle.Width = 740;
                dataGridViewArticle.Height = 317;
            }
            else
            {
                labelParametreFiltre.BackColor = Color.Transparent;
                dataGridViewArticle.Dock = DockStyle.Fill;
            }
        }

        private void ButtonCloseArticle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewArticle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewArticle.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridViewArticle.Rows[e.RowIndex];
                ButtonOKArticle_Click(sender, e);
            }
        }
        //AJOUT DE L'ARTICLE SELECTIONNE
        private void ButtonOKArticle_Click(object sender, EventArgs e)
        {
            if (dataGridViewArticle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewArticle.SelectedRows[0];
                string afRef = selectedRow.Cells["reference"].Value.ToString();
                string afDesign = selectedRow.Cells["designation"].Value.ToString();
                string faCodeFamille = selectedRow.Cells["famille"].Value.ToString();

                var infoSupplementaire = _context.F_ARTICLE.Where(article => article.AR_Ref == afRef).Select(article => new
                {
                    QuantiteStock = article.AR_UnitePoids,
                    PuHT = article.AR_PrixVen,
                    PuTTC = article.AR_PrixTTC,
                    QuantiteVendue = article.AR_UniteVen
                }).FirstOrDefault();
                
                VenteComptoirForm venteComptoirForm = Application.OpenForms.OfType<VenteComptoirForm>().FirstOrDefault();
                if (venteComptoirForm != null)
                {
                    venteComptoirForm.AjouterArticle(afRef, afDesign, faCodeFamille, (int)infoSupplementaire.QuantiteStock, (decimal)infoSupplementaire.PuHT, (decimal)infoSupplementaire.PuTTC, (int)infoSupplementaire.QuantiteVendue);

                }

            }

            this.Close();
        }
    }
}
