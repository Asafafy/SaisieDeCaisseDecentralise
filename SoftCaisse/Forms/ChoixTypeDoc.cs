using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class ChoixTypeDoc : KryptonForm
    {
        // =============================================================================
        // DECLARATION DES VARIABLES ===================================================
        // =============================================================================
        public string selectedOption { get; private set; }
        MainForm mainForm;
        // =============================================================================
        // FIN DECLARATION DES VARIABLES ===============================================
        // =============================================================================










        // =============================================================================
        // DEBUT CONSTRUCTEUR ==========================================================
        // =============================================================================
        public ChoixTypeDoc(MainForm form)
        {
            InitializeComponent();

            TopMost = true;
            mainForm = form;
        }
        // =============================================================================
        // FIN CONSTRUCTEUR ============================================================
        // =============================================================================










        // =============================================================================
        // DEBUT EVENEMENTS ============================================================
        // =============================================================================
        private void kptBtnOk_Click_1(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedOption = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                selectedOption = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                selectedOption = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                selectedOption = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                selectedOption = radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                selectedOption = radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                selectedOption = radioButton7.Text;
            }
            else if (radioButton8.Checked)
            {
                selectedOption = radioButton8.Text;
            }
            else if (radioButton9.Checked)
            {
                selectedOption = radioButton9.Text;
            }
            DialogResult = DialogResult.OK;
            NouveauEtMiseAJourDocumentDeVente nouveDocVente = new NouveauEtMiseAJourDocumentDeVente(selectedOption, mainForm, null);
            nouveDocVente.Show();
            Close();
        }





        private void kptAnnuler_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        // =============================================================================
        // FIN EVENEMENTS ==============================================================
        // =============================================================================
    }
}
