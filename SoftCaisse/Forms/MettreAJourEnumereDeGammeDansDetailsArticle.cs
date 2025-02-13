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
    public partial class MettreAJourEnumereDeGammeDansDetailsArticle : KryptonForm
    {
        // =====================================================================================================
        // DEBUT DECLARATION DES VARIABLES =====================================================================
        // =====================================================================================================
        private readonly AppDbContext _context;

        public bool? RefreshListeEnumGammes { get; set; }

        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;
        private readonly F_ARTENUMREFRepository _f_ARTENUMREFRepository;
        private readonly F_ARTPRIXRepository _f_ARTPRIXRepository;

        private readonly F_ARTGAMMEService _f_ARTGAMMEService;
        private readonly F_ARTENUMREFService _f_ARTENUMREFService;
        private readonly F_ARTPRIXService _f_ARTPRIXService;

        private string _init_EG_EnumereGamme1;
        private string _init_EG_EnumereGamme2;
        private int? _init_AG_No1;
        private int? _init_AG_No2;

        private F_ARTENUMREF _init_F_ARTENUMREF;
        private F_ARTPRIX _init_F_ARTPRIX;
        // =====================================================================================================
        // FIN DECLARATION DES VARIABLES =======================================================================
        // =====================================================================================================





        // =====================================================================================================
        // DEBUT FONCTIONS =====================================================================================
        // =====================================================================================================
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
        // =====================================================================================================
        // FIN FONCTIONS =======================================================================================
        // =====================================================================================================





        // =====================================================================================================
        // DEBUT CONSTRUCTEUR ==================================================================================
        // =====================================================================================================
        public MettreAJourEnumereDeGammeDansDetailsArticle(string AR_Ref, string EG_EnumereGamme1, string EG_EnumereGamme2)
        {
            _context = new AppDbContext();

            _f_ARTGAMMERepository = new F_ARTGAMMERepository(_context);
            _f_ARTENUMREFRepository = new F_ARTENUMREFRepository(_context);
            _f_ARTPRIXRepository = new F_ARTPRIXRepository(_context);

            _f_ARTGAMMEService = new F_ARTGAMMEService(_context, _f_ARTGAMMERepository);
            _f_ARTENUMREFService = new F_ARTENUMREFService(_context, _f_ARTENUMREFRepository);
            _f_ARTPRIXService = new F_ARTPRIXService(_context, _f_ARTPRIXRepository);

            _init_EG_EnumereGamme1 = EG_EnumereGamme1;
            _init_EG_EnumereGamme2 = EG_EnumereGamme2;

            _init_AG_No1 = _f_ARTGAMMERepository.GetByEG_Enumere(EG_EnumereGamme1).AG_No;
            if (_init_EG_EnumereGamme2 != "")
            {
                _init_AG_No2 = _f_ARTGAMMERepository.GetByEG_Enumere(EG_EnumereGamme2).AG_No;
            }
            else
            {
                _init_AG_No2 = 0;
            }

            _init_F_ARTENUMREF = _f_ARTENUMREFRepository.GetF_ARTENUMREF(AR_Ref, _init_AG_No1, _init_AG_No2);
            _init_F_ARTPRIX = _f_ARTPRIXRepository.GetF_ARTPRIX(AR_Ref, _init_AG_No1, _init_AG_No2);



            InitializeComponent();

            txtBxPrixDAchat.KeyPress += TxtBx_KeyPressHandler;
            txtBxCoutStandard.KeyPress += TxtBx_KeyPressHandler;
            txtBxDernierPrixDAchat.KeyPress += TxtBx_KeyPressHandler;

            txtBxEnumere2.Enabled = _init_AG_No2 == 0 ? false : true;

            txtBxEnumere1.Text = EG_EnumereGamme1;
            txtBxEnumere2.Text = EG_EnumereGamme2;
            txtBxCodeEDI.Text = _init_F_ARTENUMREF.AE_EdiCode ?? "";
            txtBxReference.Text = _init_F_ARTENUMREF.AE_Ref;
            txtBxCodeBarres.Text = _init_F_ARTENUMREF.AE_CodeBarre;
            txtBxPrixDAchat.Text = _init_F_ARTENUMREF.AE_PrixAch.ToString();
            txtBxCoutStandard.Text = _init_F_ARTPRIX.AR_CoutStd == 0 ? "" : _init_F_ARTPRIX.AR_CoutStd.ToString();
            txtBxDernierPrixDAchat.Text = _init_F_ARTPRIX.AR_PUNet == 0 ? "" : _init_F_ARTPRIX.AR_PUNet.ToString();
        }
        // =====================================================================================================
        // FIN CONSTRUCTEUR ====================================================================================
        // =====================================================================================================






        // =====================================================================================================
        // DEBUT EVENEMENTS ====================================================================================
        // =====================================================================================================
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void txtBxCodeBarres_KeyPress(object sender, KeyPressEventArgs e)
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

        
        
        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtBxPrixDAchat.Text == "")
            {
                MessageBox.Show("Le prix d'achat ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtBxEnumere1.Text == "" || txtBxEnumere2.Text == "")
            {
                if (txtBxEnumere2.Text == "" && _init_AG_No2 == 0)
                {
                    // ne rien faire
                }
                else
                {
                    MessageBox.Show("Les noms des énumérés ne peuvent pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (_init_EG_EnumereGamme1 != txtBxEnumere1.Text)
            {
                _f_ARTGAMMEService.UpdateEG_EnumereGamme(_init_EG_EnumereGamme1, txtBxEnumere1.Text);
            }

            if (_init_EG_EnumereGamme2 != txtBxEnumere2.Text)
            {
                _f_ARTGAMMEService.UpdateEG_EnumereGamme(_init_EG_EnumereGamme2 , txtBxEnumere2.Text);
            }


            if (_init_F_ARTENUMREF.AE_PrixAch != Convert.ToDecimal(txtBxPrixDAchat.Text)
                || _init_F_ARTENUMREF.AE_Ref != txtBxReference.Text
                || _init_F_ARTENUMREF.AE_CodeBarre != txtBxCodeBarres.Text
                || _init_F_ARTENUMREF.AE_EdiCode != txtBxCodeEDI.Text)
            {
                decimal? AE_PrixAch = string.IsNullOrWhiteSpace(txtBxPrixDAchat.Text) ? 0m : Convert.ToDecimal(txtBxPrixDAchat.Text);
                string AE_Ref = txtBxReference.Text == "" ? null : txtBxReference.Text;
                string AE_CodeBarre = txtBxCodeBarres.Text == "" ? null : txtBxCodeBarres.Text;
                string AE_EdiCode = txtBxCodeEDI.Text == "" ? null : txtBxCodeEDI.Text;

                _f_ARTENUMREFService.UpdateF_ARTENUMREF(_init_F_ARTENUMREF.AR_Ref, _init_AG_No1, _init_AG_No2, AE_PrixAch, AE_Ref, AE_CodeBarre, AE_EdiCode);
            }


            decimal? newAR_CoutStd = string.IsNullOrWhiteSpace(txtBxCoutStandard.Text) ? 0m : Convert.ToDecimal(txtBxCoutStandard.Text);
            decimal? newAR_PUNet = string.IsNullOrWhiteSpace(txtBxDernierPrixDAchat.Text) ? 0m : Convert.ToDecimal(txtBxDernierPrixDAchat.Text);

            if (newAR_CoutStd != _init_F_ARTPRIX.AR_CoutStd || newAR_PUNet != _init_F_ARTPRIX.AR_PUNet)
            {
                if (newAR_CoutStd == 0 && newAR_PUNet == 0)
                {
                    _f_ARTPRIXService.DeleteF_ARTPRIXAyantAG_No1EtAG_No2(_init_F_ARTENUMREF.AR_Ref, _init_AG_No1, _init_AG_No2);
                }
                else if (_init_F_ARTPRIX.AR_CoutStd == 0 && _init_F_ARTPRIX.AR_PUNet == 0
                    && (newAR_CoutStd != 0 || newAR_PUNet != 0))
                {
                    _f_ARTPRIXService.InsertF_ARTPRIX(_init_F_ARTENUMREF.AR_Ref, _init_AG_No1, _init_AG_No2, newAR_PUNet, newAR_CoutStd);
                }
                else
                {
                    _f_ARTPRIXService.UpdateF_ARTPRIX(_init_F_ARTENUMREF.AR_Ref, _init_AG_No1, _init_AG_No2, newAR_PUNet, newAR_CoutStd);
                }
            }

            if (_init_F_ARTENUMREF.AE_PrixAch != Convert.ToDecimal(txtBxPrixDAchat.Text)
                || _init_F_ARTENUMREF.AE_Ref != txtBxReference.Text
                || _init_F_ARTENUMREF.AE_CodeBarre != txtBxCodeBarres.Text
                || _init_F_ARTENUMREF.AE_EdiCode != txtBxCodeEDI.Text
                || newAR_CoutStd != _init_F_ARTPRIX.AR_CoutStd || newAR_PUNet != _init_F_ARTPRIX.AR_PUNet)
            {
                RefreshListeEnumGammes = true;
            }
            Close();
        }




        // =====================================================================================================
        // FIN EVENEMENTS ======================================================================================
        // =====================================================================================================
    }
}
