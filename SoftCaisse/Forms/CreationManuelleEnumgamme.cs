using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.DTO;
using SoftCaisse.DTO.DetailsArticle;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU.ModelsRepository;
using SoftCaisse.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SoftCaisse.Forms
{
    public partial class CreationManuelleEnumgamme : KryptonForm
    {
        // =======================================================================================================================================
        // =================================================== DEBUT DECLARATION DES VARIABLES ===================================================
        // =======================================================================================================================================
        private AppDbContext _context;

        private readonly F_ARTENUMREFRepository _f_ARTENUMREFRepository;
        private readonly F_TARIFGAMRepository _f_TARIFGAMRepository;

        private readonly F_ARTENUMREFService _f_ARTENUMREFService;
        private readonly F_TARIFGAMService _f_TARIFGAMService;

        public string Resultat { get; set; }

        public readonly string _AR_Ref;
        public readonly int? _AG_No1;
        public readonly int? _AG_No2;

        public List<decimal?> valeursCatTarifParDefauts;
        // =======================================================================================================================================
        // ==================================================== FIN DECLARATION DES VARIABLES ====================================================
        // =======================================================================================================================================



        static string ConserverChiffresApresVirgule(decimal? valeur)
        {
            string valeurString = valeur?.ToString("G29");   // "G29" permet de conserver jusqu'à 29 chiffres significatifs
            //return valeurString.TrimEnd('0').TrimEnd('.');  // Supprimer les zéros inutiles après la virgule
            return valeurString;  // Supprimer les zéros inutiles après la virgule
        }




        // ========================================================================================================================================
        // ========================================================== DEBUT CONSTRUCTEUR ==========================================================
        // ========================================================================================================================================
        public CreationManuelleEnumgamme(int? AG_No1, int? AG_No2, string AR_Ref)
        {
            InitializeComponent();

            _context = new AppDbContext();

            _AR_Ref = AR_Ref;
            _AG_No1 = AG_No1;
            _AG_No2 = AG_No2;

            _f_ARTENUMREFRepository = new F_ARTENUMREFRepository(_context);
            _f_TARIFGAMRepository = new F_TARIFGAMRepository();

            _f_ARTENUMREFService = new F_ARTENUMREFService(_context, _f_ARTENUMREFRepository);
            _f_TARIFGAMService = new F_TARIFGAMService(_context, _f_TARIFGAMRepository);

            valeursCatTarifParDefauts = new List<decimal?>();

            string EG_Enumere1 = _context.F_ARTGAMME.Where(ag => ag.AG_No == AG_No1).Select(ag => ag.EG_Enumere).FirstOrDefault();
            string EG_Enumere2 = _context.F_ARTGAMME.Where(ag => ag.AG_No == AG_No2).Select(ag => ag.EG_Enumere).FirstOrDefault();
            F_ARTICLE _selectedArt = _context.F_ARTICLE.Where(art => art.AR_Ref == AR_Ref).FirstOrDefault();
            decimal? aR_PrixAch = _context.F_ARTICLE.Where(art => art.AR_Ref == AR_Ref).Select(art => art.AR_PrixAch).FirstOrDefault();

            labelEnumere.Text = "Enuméré : " + EG_Enumere1 + EG_Enumere2;
            txtBxPrixAch.Text = aR_PrixAch.ToString();



            var catTarifaires = _context.F_ARTCLIENT.Where(cat => cat.AR_Ref == _selectedArt.AR_Ref && cat.AC_Categorie != 0)
                .Select(cat => new CategoriesTarifaires { AC_Categorie = cat.AC_Categorie, AC_Coef = cat.AC_Coef, AC_PrixVen = cat.AC_PrixVen, AC_Remise = cat.AC_Remise, AC_PrixTTC = cat.AC_PrixTTC })
                .ToList();
            if (catTarifaires.Count < 3)
            {
                bool contains1 = new[] { 1 }.All(val => catTarifaires.Any(cat => cat.AC_Categorie == val));
                bool contains2 = new[] { 2 }.All(val => catTarifaires.Any(cat => cat.AC_Categorie == val));
                bool contains3 = new[] { 3 }.All(val => catTarifaires.Any(cat => cat.AC_Categorie == val));
                if (!contains1 && !contains2 && !contains3)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                if (contains1 && !contains2 && !contains3)
                {
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains2 && !contains1 && !contains3)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains3 && !contains1 && !contains2)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains1 && contains2 && !contains3)
                {
                    catTarifaires.Insert(2, new CategoriesTarifaires { AC_Categorie = 3, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains1 && contains3 && !contains2)
                {
                    catTarifaires.Insert(1, new CategoriesTarifaires { AC_Categorie = 2, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
                else if (contains2 & contains3 && !contains1)
                {
                    catTarifaires.Insert(0, new CategoriesTarifaires { AC_Categorie = 1, AC_Coef = _selectedArt.AR_Coef, AC_PrixVen = _selectedArt.AR_PrixVen, AC_Remise = 0, AC_PrixTTC = _selectedArt.AR_PrixTTC });
                }
            }
            catTarifaires.OrderBy(cat => cat.AC_Categorie);
            foreach (var catTarif in catTarifaires)
            {
                var prixVente = "";
                if (catTarif.AC_PrixVen != 0)
                {
                    prixVente = ConserverChiffresApresVirgule(catTarif.AC_PrixVen);
                    //prixVente = ConserverChiffresApresVirgule(catTarif.AC_PrixVen) + (catTarif.AC_PrixTTC == 0 ? " HT" : " TTC");
                }
                else
                {
                    prixVente = ConserverChiffresApresVirgule(_selectedArt.AR_PrixVen);
                    //prixVente = ConserverChiffresApresVirgule(_selectedArt.AR_PrixVen) + (_selectedArt.AR_PrixTTC == 0 ? " HT" : " TTC");
                }

                if ((int)catTarif.AC_Categorie - 1 == 0) {
                    txtBxGrossistes.Text = prixVente;
                    valeursCatTarifParDefauts.Add(catTarif.AC_PrixVen);
                } else if ((int)catTarif.AC_Categorie - 1 == 1) {
                    txtBxDetaillants.Text = prixVente;
                    valeursCatTarifParDefauts.Add(catTarif.AC_PrixVen);
                } else {
                    txtBxClientsComptoir.Text = prixVente;
                    valeursCatTarifParDefauts.Add(catTarif.AC_PrixVen);
                }
            }

            
            
        }
        // ======================================================================================================================================
        // ========================================================== FIN CONSTRUCTEUR ==========================================================
        // ======================================================================================================================================





        // ========================================================================================================================================
        // =========================================================== DEBUT EVENEMENTS ===========================================================
        // ========================================================================================================================================
        
        // ======================================================================================================================================================================
        // =========================================================== DEBUT DEFINITION DES COMPORTEMENTS DES TEXTBOX ===========================================================
        private void txtBxGrossistes_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie que la valeur est non nulle
            if (int.TryParse(txtBxGrossistes.Text, out int value))
            {
                if (value <= 0)
                {
                    MessageBox.Show("Veuillez entrer une valeur numérique non nulle.");
                    txtBxGrossistes.Clear();
                }
            }
        }


        private void txtBxDetaillants_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie que la valeur est non nulle
            if (int.TryParse(txtBxDetaillants.Text, out int value))
            {
                if (value <= 0)
                {
                    MessageBox.Show("Veuillez entrer une valeur numérique non nulle.");
                    txtBxDetaillants.Clear();
                }
            }
        }


        private void txtBxClientsComptoir_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie que la valeur est non nulle
            if (int.TryParse(txtBxClientsComptoir.Text, out int value))
            {
                if (value <= 0)
                {
                    MessageBox.Show("Veuillez entrer une valeur numérique non nulle.");
                    txtBxClientsComptoir.Clear();
                }
            }
        }


        private void txtBxCodeBarres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtBxReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifie si le caractère est une lettre (A-Z, a-z) ou un chiffre (0-9)
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // Bloque la saisie des caractères non autorisés
            }
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
        // =========================================================== FIN DEFINITION DES COMPORTEMENTS DES TEXTBOX ===========================================================
        // ====================================================================================================================================================================





        private void kryptonButtonAnnuler_Click(object sender, EventArgs e)
        {
            Close();
            Resultat = "Annuler";
        }





        private void kryptonButtonOK_Click(object sender, EventArgs e)
        {
            // Enregistrement des entrées dans la table F_ARTENUMREF
            string AE_Ref = txtBxReference.Text;
            string AE_CodeBarre = txtBxCodeBarres.Text;
            _f_ARTENUMREFService.NouveauGammePasAPas(_AR_Ref, _AG_No1, _AG_No2, AE_Ref, AE_CodeBarre);

            // Enregistrement des entrées dans la table F_TARIFGAM
            int numeroLigne = 0;
            if (Convert.ToDecimal(txtBxGrossistes.Text) != valeursCatTarifParDefauts[0])
            {
                numeroLigne = 1;
                _f_TARIFGAMService.NouveauTarifGamme(_AR_Ref, numeroLigne, _AG_No1, _AG_No2, Convert.ToDecimal(txtBxGrossistes.Text));
            }
            if (Convert.ToDecimal(txtBxDetaillants.Text) != valeursCatTarifParDefauts[1])
            {
                numeroLigne = 2;
                _f_TARIFGAMService.NouveauTarifGamme(_AR_Ref, numeroLigne, _AG_No1, _AG_No2, Convert.ToDecimal(txtBxDetaillants.Text));
            }
            if (Convert.ToDecimal(txtBxClientsComptoir.Text) != valeursCatTarifParDefauts[2])
            {
                numeroLigne = 3;
                _f_TARIFGAMService.NouveauTarifGamme(_AR_Ref, numeroLigne, _AG_No1, _AG_No2, Convert.ToDecimal(txtBxClientsComptoir.Text));
            }

            Close();
        }

















        // ======================================================================================================================================
        // =========================================================== FIN EVENEMENTS ===========================================================
        // ======================================================================================================================================
    }
}
