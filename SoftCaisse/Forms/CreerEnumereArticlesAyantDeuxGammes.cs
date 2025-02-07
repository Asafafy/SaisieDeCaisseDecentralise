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
    public partial class CreerEnumereArticlesAyantDeuxGammes : KryptonForm
    {
        // =============================================================================================================================
        // DEBUT DECLARATION DES VARIABLES =============================================================================================
        // =============================================================================================================================
        private readonly AppDbContext _context;

        public bool? RefreshListeEnumGammes { get; set; }

        private readonly F_ARTICLERepository _f_ARTICLERepository;
        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;
        private readonly F_GAMSTOCKRepository _f_GAMSTOCKRepository;
        private readonly F_ARTENUMREFRepository _f_ARTENUMREFRepository;

        private readonly F_ARTGAMMEService _f_ARTGAMMEService;
        private readonly F_GAMSTOCKService _f_GAMSTOCKService;
        private readonly F_ARTENUMREFService _f_ARTENUMREFService;

        private readonly F_ARTICLE _f_ARTICLEConcerne;
        private readonly string _AR_Ref;
        private readonly decimal? _init_AR_PrixAch;
        private readonly bool _estGamme1;
        // =============================================================================================================================
        // FIN DECLARATION DES VARIABLES ===============================================================================================
        // =============================================================================================================================





        // =============================================================================================================================
        // DEBUT CONSTRUCTEUR ==========================================================================================================
        // =============================================================================================================================
        public CreerEnumereArticlesAyantDeuxGammes(string AR_Ref, bool estGamme1)
        {
            _context = new AppDbContext();

            _f_ARTICLERepository = new F_ARTICLERepository(_context);
            _f_ARTGAMMERepository = new F_ARTGAMMERepository(_context);
            _f_GAMSTOCKRepository = new F_GAMSTOCKRepository(_context);
            _f_ARTENUMREFRepository = new F_ARTENUMREFRepository(_context);

            _f_ARTGAMMEService = new F_ARTGAMMEService(_context, _f_ARTGAMMERepository);
            _f_GAMSTOCKService = new F_GAMSTOCKService(_context, _f_GAMSTOCKRepository);
            _f_ARTENUMREFService = new F_ARTENUMREFService(_context, _f_ARTENUMREFRepository);

            InitializeComponent();

            _AR_Ref = AR_Ref;
            _estGamme1 = estGamme1;
            _f_ARTICLEConcerne = _f_ARTICLERepository.GetF_ARTICLEByAR_Ref(_AR_Ref);
            _init_AR_PrixAch = _f_ARTICLEConcerne.AR_PrixAch;

            txtBxPrixDAchat.Text = _init_AR_PrixAch.ToString();

            if (_estGamme1)
            {
                lblEnum2.Enabled = false;
                txtBxEnumere2.Enabled = false;
            }
            else
            {
                lblEnum1.Enabled = false;
                txtBxEnumere1.Enabled = false;
            }
        }
        // =============================================================================================================================
        // FIN CONSTRUCTEUR ============================================================================================================
        // =============================================================================================================================





        // =============================================================================================================================
        // DEBUT EVENEMENTS ============================================================================================================
        // =============================================================================================================================
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void txtBxPrixDAchat_KeyPress(object sender, KeyPressEventArgs e)
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
            _f_ARTGAMMEService.NouveauGamme(_AR_Ref, _estGamme1 ? txtBxEnumere1.Text : txtBxEnumere2.Text, _estGamme1 ? 0 : 1);

            _f_GAMSTOCKService.CreateF_GAMSTOCKPourArticleAyantDeuxGammes(_AR_Ref, !_estGamme1);

            int? AG_No = _estGamme1 ? _f_ARTGAMMERepository.GetLastAG_No1() : _f_ARTGAMMERepository.GetLastAG_No2();
            decimal? AR_PrixAch = 0;
            if (_init_AR_PrixAch != Convert.ToDecimal(txtBxPrixDAchat.Text))
            {
                AR_PrixAch = Convert.ToDecimal(txtBxPrixDAchat.Text);
            }
            else
            {
                AR_PrixAch = null;
            }
            _f_ARTENUMREFService.NouveauGamme(_AR_Ref, _estGamme1 ? 0 : 1, (short?)AG_No, "", "", AR_PrixAch);
            
            RefreshListeEnumGammes = true;
            Close();
        }





        // =============================================================================================================================
        // FIN EVENEMENTS ==============================================================================================================
        // =============================================================================================================================
    }
}
