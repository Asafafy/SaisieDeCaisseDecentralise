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
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
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
        private readonly F_ENUMGAMMERepository _f_ENUMGAMMERepository;
        private readonly F_ARTENUMREFRepository _f_ARTENUMREFRepository;
        private readonly F_ARTGAMMERepository _f_ARTGAMMERepository;
        private readonly F_ARTICLERepository _f_ARTICLERepository;

        private readonly P_GAMMEService _p_GAMMEService;
        private readonly F_ENUMGAMMEService _f_ENUMGAMMEService;
        private readonly F_ARTENUMREFService _f_ARTENUMREFService;
        private readonly F_ARTGAMMEService _f_ARTGAMMEService;
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
            _f_ENUMGAMMERepository = new F_ENUMGAMMERepository(_context);
            _f_ARTENUMREFRepository = new F_ARTENUMREFRepository(_context);
            _f_ARTGAMMERepository = new F_ARTGAMMERepository(_context);
            _f_ARTICLERepository = new F_ARTICLERepository(_context);

            _p_GAMMEService = new P_GAMMEService(_context, _p_GAMMERepository);
            _f_ENUMGAMMEService = new F_ENUMGAMMEService(_context, _f_ENUMGAMMERepository);
            _f_ARTENUMREFService = new F_ARTENUMREFService(_context, _f_ARTENUMREFRepository);
            _f_ARTGAMMEService = new F_ARTGAMMEService(_context, _f_ARTGAMMERepository);

            elementSelectionne = "";

            btnEnregistrer.Enabled = false;

            List<P_GAMME> P_GAMMEs = _p_GAMMERepository.GetAllNotEmptyStringAndTypeZero();
            short? EG_Champ_F_ENUMGAMMEs = P_GAMMEs[0].cbIndice;
            List<F_ENUMGAMME> f_ENUMGAMMEs = _f_ENUMGAMMERepository.GetAllEnumGammeOfAGamme(EG_Champ_F_ENUMGAMMEs);

            textBox1.Text = P_GAMMEs[0].G_Intitule;
            
            listBox1.DataSource = P_GAMMEs.Select(g => g.G_Intitule).ToList();
            listBox2.DataSource = f_ENUMGAMMEs.Select(eg => eg.EG_Enumere).ToList();
        }
        // =========================================================================================================================================================================================
        // ==================================================================================== FIN CONSTRUCTEUR ===================================================================================
        // =========================================================================================================================================================================================





        // =========================================================================================================================================================================================
        // =============================================================================== DEBUT FONCTIONS INTERNES ================================================================================
        // =========================================================================================================================================================================================
        public void RefreshListBox1(string nomSelectedGamme)
        {
            listBox1.DataSource = null;
            List<P_GAMME> listeGammesRefresh = _p_GAMMERepository.GetAllNotEmptyStringAndTypeZero();
            listBox1.DataSource = listeGammesRefresh.Select(g => g.G_Intitule).ToList();
            int index = listBox1.FindStringExact(nomSelectedGamme);
            listBox1.SelectedIndex = index;
        }



        public void RefreshListBox2()
        {
            listBox2.DataSource = null;
            short? EG_Champ_F_ENUMGAMMEs = _p_GAMMERepository.Get_P_GAMMEBy_G_Intitule(listBox1.SelectedItem.ToString()).cbIndice;
            List<F_ENUMGAMME> f_ENUMGAMMEs = _f_ENUMGAMMERepository.GetAllEnumGammeOfAGamme(EG_Champ_F_ENUMGAMMEs);
            listBox2.DataSource = f_ENUMGAMMEs.Select(eg => eg.EG_Enumere).ToList();
        }
        // =========================================================================================================================================================================================
        // ================================================================================ FIN FONCTIONS INTERNES =================================================================================
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

                P_GAMME p_GAMME = _p_GAMMERepository.Get_P_GAMMEBy_G_Intitule(listBox1.SelectedItem.ToString());
                
                elementSelectionne = p_GAMME.G_Intitule;
                textBox1.Text = p_GAMME.G_Intitule;

                RefreshListBox2();

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

                F_ENUMGAMME f_ENUMGAMME = _f_ENUMGAMMERepository.GetByEG_Enumere(listBox2.SelectedItem.ToString());
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

            // =========================================================== CAS CREATION NOUVEAU ===========================================================
            if (estNouveau == 1)
            {
                // CAS GAMME ==============================================================================================================================
                if (estGamme == 1)
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z0-9]{3,}"))
                    {
                        string resultat = _p_GAMMEService.NouveauGamme(nouveauNom);
                        if (resultat == "success")
                        {
                            MessageBox.Show("Nouvelle gamme enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RefreshListBox1(nouveauNom);
                            listBox2.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("Vous avez atteint la limite maximale de 50 gammes. Impossible d'en créer de nouvelles.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // CAS ENUMGAMME ==============================================================================================================================
                else
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z0-9]{3,}"))
                    {
                        string G_Intitule = listBox1.SelectedItem.ToString();
                        P_GAMME p_GAMME = _p_GAMMERepository.Get_P_GAMMEBy_G_Intitule(G_Intitule);
                        List<F_ARTICLE> listeArticles = _f_ARTICLERepository.GetAllF_ARTICLE();
                        List<F_ARTICLE> listeArticlesHavingGamme1Ou2 = listeArticles.Where(a => a.AR_Gamme1 == p_GAMME.cbIndice || a.AR_Gamme2 == p_GAMME.cbIndice).ToList();

                        int estAG_No2 = 0;

                        if (listeArticles.Count > 0) // Des articles sont liés au gamme manipulé
                        {
                            ChoixCreationENUMGAMME choixCreationENUMGAMME = new ChoixCreationENUMGAMME(G_Intitule);
                            choixCreationENUMGAMME.ShowDialog();

                            if (choixCreationENUMGAMME.Resultat != null)
                            {
                                if (choixCreationENUMGAMME.Resultat == "Non")
                                {
                                    _f_ENUMGAMMEService.NouveauGamme(p_GAMME.cbIndice, nouveauNom);
                                }
                                else if (choixCreationENUMGAMME.Resultat == "Créer automatiquement")
                                {

                                    _f_ENUMGAMMEService.NouveauGamme(p_GAMME.cbIndice, nouveauNom);

                                    foreach (F_ARTICLE f_ARTICLE in listeArticles)
                                    {
                                        if (f_ARTICLE.AR_Gamme2 == p_GAMME.cbIndice)
                                            estAG_No2 = 1;
                                        _f_ARTGAMMEService.NouveauGamme(f_ARTICLE.AR_Ref, nouveauNom, estAG_No2);

                                        F_ARTGAMME f_ARTGAMME = _f_ARTGAMMERepository.GetByEG_Enumere(nouveauNom);
                                        _f_ARTENUMREFService.NouveauGamme(f_ARTICLE.AR_Ref, estAG_No2, (short)f_ARTGAMME.AG_No, "", "", null);
                                    }
                                }
                                else
                                {
                                    _f_ENUMGAMMEService.NouveauGamme(p_GAMME.cbIndice, nouveauNom);

                                    foreach (F_ARTICLE f_ARTICLE in listeArticles)
                                    {
                                        if (f_ARTICLE.AR_Gamme2 == p_GAMME.cbIndice)
                                            estAG_No2 = 1;
                                        _f_ARTGAMMEService.NouveauGamme(f_ARTICLE.AR_Ref, nouveauNom, estAG_No2);

                                        F_ARTGAMME f_ARTGAMME = _f_ARTGAMMERepository.GetByEG_Enumere(nouveauNom);
                                        List<(int?, int?)> listeAG_No = _f_ARTENUMREFService.GetCombinaisonsAG_No(f_ARTICLE, estAG_No2, (short?)f_ARTGAMME.AG_No);
                                        foreach (var (AG_No1, AG_No2) in listeAG_No)
                                        {
                                            CreationManuelleEnumgamme creationManuelleEnumgamme = new CreationManuelleEnumgamme(AG_No1, AG_No2, f_ARTICLE.AR_Ref);
                                            creationManuelleEnumgamme.ShowDialog();
                                            if (choixCreationENUMGAMME.Resultat != null)
                                            {
                                                // TODO eto : Otran misy tokony hatao eto...
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else // Aucun article n'est lié au gamme manipulé
                        {
                            _f_ENUMGAMMEService.NouveauGamme(p_GAMME.cbIndice, nouveauNom);
                        }

                        // Rafaichir la liste des enumgammes après tout traitement
                        RefreshListBox2();
                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }


            // =========================================================== CAS MISE A JOUR ===========================================================
            else
            {
                // CAS GAMME ==============================================================================================================================
                if (estGamme == 1)
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z0-9]{3,}"))
                    {
                        _p_GAMMEService.UpdateGamme(elementSelectionne, nouveauNom);

                        RefreshListBox1(nouveauNom);
                        RefreshListBox2();

                        elementSelectionne = nouveauNom;
                        textBox1.Text = nouveauNom;

                        btnSuppr.Enabled = true;
                        btnNouvelleEnum.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // CAS ENUMGAMME ==============================================================================================================================
                else
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z0-9]{3,}"))
                    {
                        
                        elementSelectionne = nouveauNom;
                        textBox1.Text = nouveauNom;
                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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





        private void btnSuppr_Click(object sender, EventArgs e)
        {
            // CAS SUPPRESSION D'UNE GAMME ====================================================================================================================
            if (estGamme == 1)
            {
                elementSelectionne = listBox1.SelectedItem.ToString();

                P_GAMME gammeToDelete = _p_GAMMERepository.Get_P_GAMMEBy_G_Intitule(elementSelectionne);
                List<F_ENUMGAMME> enumeresDeLaGamme = _f_ENUMGAMMERepository.GetAllEnumGammeOfAGamme(gammeToDelete.cbIndice);
                if (enumeresDeLaGamme.Count() > 1)
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer une gamme qui contient des énumérés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _p_GAMMEService.SupprimerGamme(elementSelectionne);


                // Refresh listes à afficher
                List<P_GAMME> listeGammesRefresh = _p_GAMMERepository.GetAllTypeZero();
                P_GAMME gammeSelectionne = listeGammesRefresh[0];
                RefreshListBox1(gammeSelectionne.G_Intitule);
                RefreshListBox2();
            }


            // CAS SUPPRESSION D'UN ENUMERE DE GAMME =========================================================================================================
            else
            {
                elementSelectionne = listBox2.SelectedItem.ToString();
                int indexeGammeSelect = listBox1.SelectedIndex;

                _f_ENUMGAMMEService.DeleteEnumGamme(elementSelectionne);

                RefreshListBox2();
            }
        }




        // =========================================================================================================================================================================================
        // ===================================================================================== FIN EVENEMENTS ====================================================================================
        // =========================================================================================================================================================================================




    }
}
