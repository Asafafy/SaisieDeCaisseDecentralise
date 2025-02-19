using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.CustomModel;
using SoftCaisse.DTO;
using SoftCaisse.Forms.FormCaisse;
using SoftCaisse.Models;
using System.Linq;
namespace SoftCaisse.Forms.StatCaisse
{
    public partial class StatCaisseForm : KryptonForm
    {
        // ============================================================================
        // DEBUT DECLARATION DES VARIABLES ============================================
        // ============================================================================
        private readonly AppDbContext _context;
        // ============================================================================
        // FIN DECLARATION DES VARIABLES ==============================================
        // ============================================================================










        // ============================================================================
        // DEBUT CONSTRUCTEUR =========================================================
        // ============================================================================
        public StatCaisseForm()
        {
            _context = new AppDbContext();

            InitializeComponent();
            
            kryptonComboBox9.DataSource = _context.F_CAISSE.Select(u=>new {Value= u.CA_No, Label=u.CA_Intitule}).ToList();
            kryptonComboBox9.DisplayMember = "Label";
            kryptonComboBox9.ValueMember = "Value";
            kryptonComboBox10.DataSource = _context.F_CAISSE.Select(u=>new {Value= u.CA_No, Label=u.CA_Intitule}).ToList();
            kryptonComboBox10.DisplayMember = "Label";
            kryptonComboBox10.ValueMember = "Value";
            kryptonComboBox2.SelectedIndex = 0;
            kryptonComboBox3.SelectedIndex = 0;
        }
        // ============================================================================
        // FIN CONSTRUCTEUR ===========================================================
        // ============================================================================










        // ============================================================================
        // DEBUT EVENEMENTS ===========================================================
        // ============================================================================
        private void kryptonButton4_Click(object sender, System.EventArgs e)
        {
            var statistiques = _context.F_DOCENTETE
                .Join(_context.F_DOCLIGNE, post => post.DO_Piece, meta => meta.DO_Piece, (post, meta) => new { Post = post, meta = meta })
                .Join(_context.F_ARTICLE, post => post.meta.AR_Ref, meta => meta.AR_Ref, (post, meta) => new { Post = post, meta = meta })
                .Join(_context.F_FAMILLE, post => post.meta.FA_CodeFamille, meta => meta.FA_CodeFamille, (post, meta) => new { Post = post, meta = meta })
                .Join(_context.F_CAISSE, post => post.Post.Post.Post.CA_No, meta => meta.CA_No, (post, meta) => new { Post = post, meta = meta })
                .Join(_context.F_DOCREGL, post => post.Post.Post.Post.Post.DO_Piece, meta => meta.DO_Piece, (post, meta) => new { post, meta = meta });
            if(kryptonComboBox3.SelectedIndex == 0)
            {
                statistiques = statistiques.Where(u => u.post.Post.Post.Post.Post.DO_Type != 30 && u.post.Post.Post.Post.Post.DO_Cloture != 1);
            }
            else if(kryptonComboBox3.SelectedIndex == 1)
            {
                statistiques = statistiques.Where(u => u.post.Post.Post.Post.Post.DO_Type != 30 && u.post.Post.Post.Post.Post.DO_Cloture == 1);
            }
            else if (kryptonComboBox3.SelectedIndex == 2)
            {
                statistiques = statistiques.Where(u => u.post.Post.Post.Post.Post.DO_Type == 30 && u.post.Post.Post.Post.Post.DO_Cloture != 1);
            }
            else
            {
                statistiques = statistiques.Where(u => u.post.Post.Post.Post.Post.DO_Type == 30 && u.post.Post.Post.Post.Post.DO_Cloture == 1);
            }

            if (kryptonComboBox2.SelectedIndex == 0)
            {

                var listes = statistiques.GroupBy(u => new { Caisse = u.post.meta.CA_Intitule, Reference = u.post.Post.Post.meta.AR_Ref, Designation = u.post.Post.Post.meta.AR_Design }).ToList().Select(u =>
                {
                    return new Fstatistique()
                    {
                        Caisse = u.Key.Caisse,
                        Designation = u.Key.Designation,
                        Reference = u.Key.Reference,
                        CANetHT = (double)u.Sum(i => i.post.Post.Post.Post.meta.DL_PrixRU.Value),
                        Quantite = (double)u.Sum(i => i.post.Post.Post.Post.meta.DL_Qte.Value),
                        CANet = (double)u.Sum(i => i.post.Post.Post.Post.meta.DL_Qte.Value * i.post.Post.Post.Post.meta.DL_PrixRU.Value * 0.8m)
                    };
                });
                Close();
                Reporting forms = new Reporting(kryptonDateTimePicker1.Value.Date, kryptonDateTimePicker2.Value.Date, listes, StatType.ParArticle);
                forms.Show();
            }
            else if (kryptonComboBox2.SelectedIndex == 1)
            {
                var listes = statistiques.GroupBy(u => new { Caisse = u.post.meta.CA_Intitule, Designation = u.post.Post.meta.FA_Intitule, Reference = u.post.Post.meta.FA_CodeFamille }).ToList().Select(u =>
                {
                    return new Fstatistique()
                    {
                        Designation = u.Key.Designation,
                        Reference = u.Key.Reference,
                        Caisse = u.Key.Caisse,
                        Quantite = (double)u.Sum(i => i.post.Post.Post.Post.meta.DL_Qte.Value),
                        CANetHT = (double)u.Sum(i => i.post.Post.Post.Post.meta.DL_PrixRU.Value),
                        CANet = (double)u.Sum(i => i.post.Post.Post.Post.meta.DL_Qte.Value * i.post.Post.Post.Post.meta.DL_PrixRU.Value * 0.8m)
                    };
                });
                Close();
                Reporting forms = new Reporting(kryptonDateTimePicker1.Value.Date, kryptonDateTimePicker2.Value.Date, listes, StatType.ParFamille);
                forms.Show();

            }
            else
            {
                var liste = statistiques.GroupBy(item => new { 
                    Caisse = item.post.Post.Post.Post.Post.CA_No,
                    Reglement = item.meta.N_Reglement 
                }).Select(u =>
                    new Freglement() {
                        Caisse = u.Key.Caisse + "",
                        Type = u.Key.Reglement + "",
                        Montant = (double) u.Sum(i => i.post.Post.Post.Post.Post.DO_TotalHTNet)
                }).ToList();
                liste.ForEach(u => u.Type = _context.P_REGLEMENT.FirstOrDefault(aa => aa.cbMarq + "" == u.Type).R_Intitule);
                liste.ForEach(u => u.Caisse = _context.F_CAISSE.FirstOrDefault(aa => aa.cbMarq + "" == u.Caisse).CA_Intitule);
                this.Close();
                Reporting form = new Reporting(kryptonDateTimePicker1.Value.Date, kryptonDateTimePicker2.Value.Date, liste);
                form.Show();
            }

        }

        // ============================================================================
        // DEBUT EVENEMENTS ===========================================================
        // ============================================================================


    }
}
