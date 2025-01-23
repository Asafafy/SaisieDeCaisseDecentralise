using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories.BIJOU.ModelsRepository;
using SoftCaisse.Services;

namespace SoftCaisse.Forms
{
    public partial class GammeForm : KryptonForm
    {
        // =============================================================================================================================================================================================
        // ============================================================================= DEBUT DECLARATION DES VARIABLES ===============================================================================
        // =============================================================================================================================================================================================
        private AppDbContext _context;

        private string elementSelectionne;

        private int estNouveau = 0;
        private int estGamme = 0;

        private readonly P_GAMMERepository _p_GAMMERepository;

        private readonly P_GAMMEService _p_GAMMEService;
        // =============================================================================================================================================================================================
        // =============================================================================== FIN DECLARATION DES VARIABLES ===============================================================================
        // =============================================================================================================================================================================================





        // =========================================================================================================================================================================================
        // ================================================================================== DEBUT CONSTRUCTEUR ===================================================================================
        // =========================================================================================================================================================================================
        public GammeForm()
        {
            InitializeComponent();

            _context = new AppDbContext();

            _p_GAMMERepository = new P_GAMMERepository(_context);

            _p_GAMMEService = new P_GAMMEService(_context, _p_GAMMERepository);

            elementSelectionne = "";

            btnEnregistrer.Enabled = false;

            List<P_GAMME> P_GAMMEs = _context.P_GAMME.Where(g => g.G_Intitule != "" && g.G_Type == 0).ToList();
            short? EG_Champ_F_ENUMGAMMEs = P_GAMMEs[0].cbIndice;
            List<F_ENUMGAMME> f_ENUMGAMMEs = _context.F_ENUMGAMME.Where(variante => variante.EG_Champ == EG_Champ_F_ENUMGAMMEs).ToList();

            textBox1.Text = P_GAMMEs[0].G_Intitule;
            
            listBox1.DataSource = P_GAMMEs.Select(g => g.G_Intitule).ToList();
            listBox2.DataSource = f_ENUMGAMMEs.Select(eg => eg.EG_Enumere).ToList();
        }
        // =========================================================================================================================================================================================
        // ==================================================================================== FIN CONSTRUCTEUR ===================================================================================
        // =========================================================================================================================================================================================





        // =========================================================================================================================================================================================
        // ==================================================================================== DEBUT EVENEMENTS ===================================================================================
        // =========================================================================================================================================================================================
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                estNouveau = 0;
                estGamme = 1;

                P_GAMME p_GAMME = _context.P_GAMME.Where(elt => elt.G_Intitule == listBox1.SelectedItem.ToString()).FirstOrDefault();
                List<F_ENUMGAMME> f_ENUMGAMMEs = _context.F_ENUMGAMME.Where(variante => variante.EG_Champ == p_GAMME.cbIndice).ToList();
                
                elementSelectionne = p_GAMME.G_Intitule;
                listBox2.DataSource = null;
                listBox2.DataSource = f_ENUMGAMMEs.Select(eg => eg.EG_Enumere).ToList();
                textBox1.Text = p_GAMME.G_Intitule;

                btnSuppr.Enabled = true;
                btnNouvelleEnum.Enabled = true;
            }
            else
            {
                btnSuppr.Enabled = false;
                btnNouvelleEnum.Enabled = false;
            }
        }


        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                estNouveau = 0;
                estGamme = 0;

                F_ENUMGAMME f_ENUMGAMME = _context.F_ENUMGAMME.Where(variante => variante.EG_Enumere == listBox2.SelectedItem.ToString()).FirstOrDefault();
                elementSelectionne = f_ENUMGAMME.EG_Enumere;
                textBox1.Text = f_ENUMGAMME.EG_Enumere;
                btnSuppr.Enabled = true;
            }
            else
            {
                btnSuppr.Enabled = false;
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((textBox1.Text + e.KeyChar) != elementSelectionne)
            {
                btnEnregistrer.Enabled = true;
            }
            else
            {
                btnEnregistrer.Enabled = false;
            }
        }


        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nouveauNom = textBox1.Text;
            btnEnregistrer.Enabled = false;

            // CAS CREATION NOUVEAU ==============================
            if (estNouveau == 1)
            {
                // CAS GAMME
                if (estGamme == 1)
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z].*[a-zA-Z].*[a-zA-Z]"))
                    {
                        string resultat = _p_GAMMEService.NouveauGamme(nouveauNom);
                        if (resultat == "success")
                        {
                            MessageBox.Show("Nouvelle gamme enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            _context = new AppDbContext();
                            List<P_GAMME> p_GAMMEs = _context.P_GAMME.Where(g => g.G_Intitule != "" && g.G_Type == 0).AsNoTracking().ToList();

                            listBox1.DataSource = null;
                            listBox1.DataSource = p_GAMMEs.Select(g => g.G_Intitule).ToList();
                            int index = listBox1.FindStringExact(nouveauNom);
                            listBox1.SelectedIndex = index;
                            listBox2.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("Vous avez atteint la limite maximale de 50 gammes. Impossible d'en créer de nouvelles.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois lettres de l'alphabet.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // CAS ENUMGAMME
                else
                {
                    
                }
            }
            // CAS MISE A JOUR ==================================
            else
            {
                // CAS GAMME
                if (estGamme == 1)
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z].*[a-zA-Z].*[a-zA-Z]"))
                    {
                        _p_GAMMEService.UpdateGamme(elementSelectionne, nouveauNom);

                        _context = new AppDbContext();
                        P_GAMME p_GAMME = _context.P_GAMME.Where(elt => elt.G_Intitule == nouveauNom).FirstOrDefault();
                        List<F_ENUMGAMME> f_ENUMGAMMEs = _context.F_ENUMGAMME.Where(variante => variante.EG_Champ == p_GAMME.cbIndice).ToList();
                        List<P_GAMME> p_GAMMEs = _context.P_GAMME.Where(g => g.G_Intitule != "" && g.G_Type == 0).AsNoTracking().ToList();

                        listBox1.DataSource = null;
                        listBox1.DataSource = p_GAMMEs.Select(g => g.G_Intitule).ToList();
                        int index = listBox1.FindStringExact(nouveauNom);
                        listBox1.SelectedIndex = index;
                        listBox2.DataSource = null;
                        listBox2.DataSource = f_ENUMGAMMEs.Select(eg => eg.EG_Enumere).ToList();

                        elementSelectionne = p_GAMME.G_Intitule;
                        textBox1.Text = p_GAMME.G_Intitule;

                        btnSuppr.Enabled = true;
                        btnNouvelleEnum.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois lettres de l'alphabet.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // CAS ENUMGAMME
                else
                {

                }
            }
        }


        private void btnNouvelleGamme_Click(object sender, EventArgs e)
        {
            estNouveau = 1;
            estGamme = 1;
            elementSelectionne = "";
            textBox1.Focus();
            textBox1.Text = "";
        }


        private void btnNouvelleEnum_Click(object sender, EventArgs e)
        {
            estNouveau = 1;
            estGamme = 0;
            elementSelectionne = "";
            textBox1.Focus();
            textBox1.Text = "";
        }




        // =========================================================================================================================================================================================
        // ===================================================================================== FIN EVENEMENTS ====================================================================================
        // =========================================================================================================================================================================================




    }
}
