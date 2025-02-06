using ComponentFactory.Krypton.Toolkit;
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
    public partial class ChoixCreationENUMGAMMEDansDetailsArticle : KryptonForm
    {
        // =============================================================================================================================
        // DEBUT DECLARATION DES VARIABLES =============================================================================================
        // =============================================================================================================================
        private readonly string _referenceArt;
        // =============================================================================================================================
        // FIN DECLARATION DES VARIABLES ===============================================================================================
        // =============================================================================================================================





        // =============================================================================================================================
        // DEBUT CONSTRUCTEUR ==========================================================================================================
        // =============================================================================================================================
        public ChoixCreationENUMGAMMEDansDetailsArticle(string referenceArt)
        {
            InitializeComponent();
            _referenceArt = referenceArt;
        }
        // =============================================================================================================================
        // FIN CONSTRUCTEUR ============================================================================================================
        // =============================================================================================================================





        // =============================================================================================================================
        // DEBUT EVENEMENTS ============================================================================================================
        // =============================================================================================================================
        private void btnCreerPourGamme1_Click(object sender, EventArgs e)
        {
            CreerEnumereArticlesAyantDeuxGammes creerEnumereArticlesAyantDeuxGammes = new CreerEnumereArticlesAyantDeuxGammes(_referenceArt, true);
            creerEnumereArticlesAyantDeuxGammes.ShowDialog();
            Close();
        }

        private void btnCreerPourGamme2_Click(object sender, EventArgs e)
        {
            CreerEnumereArticlesAyantDeuxGammes creerEnumereArticlesAyantDeuxGammes = new CreerEnumereArticlesAyantDeuxGammes(_referenceArt, false);
            creerEnumereArticlesAyantDeuxGammes.ShowDialog();
            Close();
        }









        // =============================================================================================================================
        // FIN EVENEMENTS ==============================================================================================================
        // =============================================================================================================================
    }
}
