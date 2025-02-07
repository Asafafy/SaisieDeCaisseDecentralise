using ComponentFactory.Krypton.Toolkit;
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

namespace SoftCaisse.Forms
{
    public partial class CreerEnumereArticlesAyantUnSeulGamme : KryptonForm
    {
        // =====================================================================================================================================================
        // ========================================================== DEBUT DECLARATION DES VARIABLES ==========================================================
        // =====================================================================================================================================================
        private readonly AppDbContext _context;

        public bool? RefreshListeEnumGammes { get; set; }

        private readonly F_ARTGAMMEService _f_ARTGAMMEService;
        private readonly F_GAMSTOCKService _f_GAMSTOCKService;
        private readonly F_ARTENUMREFService _f_ARTENUMREFService;
        private readonly F_ARTPRIXService _f_ARTPRIXService;

        private readonly F_ARTICLERepository _f_ARTICLERepository;
        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;
        private readonly F_GAMSTOCKRepository _f_GAMSTOCKRepository;
        private readonly F_ARTENUMREFRepository _f_ARTENUMREFRepository;
        private readonly F_ARTPRIXRepository _f_ARTPRIXRepository;

        private readonly F_ARTICLE _f_ARTICLEConcerne;
        private readonly string _AR_Ref;
        private readonly decimal? _init_AR_PrixAch;


        // =====================================================================================================================================================
        // =========================================================== FIN DECLARATION DES VARIABLES ===========================================================
        // =====================================================================================================================================================



        public CreerEnumereArticlesAyantUnSeulGamme(string AR_Ref)
        {
            _context = new AppDbContext();

            InitializeComponent();

            _f_ARTICLERepository = new F_ARTICLERepository(_context);
            _f_ARTGAMMERepository = new F_ARTGAMMERepository(_context);
            _f_GAMSTOCKRepository = new F_GAMSTOCKRepository(_context);
            _f_ARTENUMREFRepository = new F_ARTENUMREFRepository(_context);
            _f_ARTPRIXRepository = new F_ARTPRIXRepository(_context);

            _f_ARTGAMMEService = new F_ARTGAMMEService(_context, _f_ARTGAMMERepository);
            _f_GAMSTOCKService = new F_GAMSTOCKService(_context, _f_GAMSTOCKRepository);
            _f_ARTENUMREFService = new F_ARTENUMREFService(_context, _f_ARTENUMREFRepository);
            _f_ARTPRIXService = new F_ARTPRIXService(_context, _f_ARTPRIXRepository);

            _AR_Ref = AR_Ref;
            _f_ARTICLEConcerne = _f_ARTICLERepository.GetF_ARTICLEByAR_Ref(_AR_Ref);
            _init_AR_PrixAch = _f_ARTICLEConcerne.AR_PrixAch;

            txtBxPrixDAchat.Text = _init_AR_PrixAch.ToString();
        }




        // =====================================================================================================================================================
        // ================================================================= DEBUT EVENEMENTS ==================================================================
        // =====================================================================================================================================================

        // =====================================================================================================================================================
        // ========================================================== DEBUT COMPORTEMENTS DES TEXTBOX ==========================================================
        private void txtBxCodesBarres_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Vérifie si le caractère est une lettre ou un chiffre
            if ((!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                   (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                   char.IsDigit(e.KeyChar))) 
                  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Empêche la saisie
            }
            if (char.IsLower(e.KeyChar))
            {
                // Convertit les minuscules en majuscules
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }



        private void TxtBx_KeyPressHandler(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox == null) return;

            // Vérifie si la première position est une virgule
            if (e.KeyChar == ',' && textBox.SelectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            // Autorise chiffres, Backspace, un seul point, et un signe moins au début
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)
                && (e.KeyChar != ',' || textBox.Text.Contains(","))
                && (e.KeyChar != '-' || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }





        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBxEnumere.Text == "")
            {
                MessageBox.Show("Veuillez saisir l'énuméré de la gamme à créer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBxPrixDAchat.Text == "")
            {
                MessageBox.Show("Le champ prix d'achat ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _f_ARTGAMMEService.NouveauGamme(_AR_Ref, txtBxEnumere.Text, 0);

            _f_ARTICLERepository.UpdateDateModifArticle(_f_ARTICLEConcerne.cbMarq);

            _f_GAMSTOCKService.CreateF_GAMSTOCKPourGamme1Uniquement(_AR_Ref);

            int? AG_No1 = _f_ARTGAMMERepository.GetLastAG_No1();
            _f_ARTENUMREFService.NouveauGammePasAPas(_AR_Ref, AG_No1, 0, txtBxReference.Text, txtBxCodesBarres.Text, Convert.ToDecimal(txtBxPrixDAchat.Text));

            if (txtBxDernierPrixDAchat.Text != "" || txtBxCoutStandard.Text != "")
            {
                decimal? dernierPrixDAchat = txtBxDernierPrixDAchat.Text == "" ? 0 : Convert.ToDecimal(txtBxDernierPrixDAchat.Text);
                decimal? coutStandard = txtBxCoutStandard.Text == "" ? 0 : Convert.ToDecimal(txtBxCoutStandard.Text);
                _f_ARTPRIXService.CreerF_ARTPRIXGamme1Uniquement(_AR_Ref, dernierPrixDAchat, coutStandard);
            }

            Close();
            RefreshListeEnumGammes = true;
        }





        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }


        // =========================================================== FIN COMPORTEMENTS DES TEXTBOX ===========================================================
        // =====================================================================================================================================================









        // =====================================================================================================================================================
        // ================================================================= DEBUT EVENEMENTS ==================================================================
        // =====================================================================================================================================================
    }
}
