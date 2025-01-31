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

            _p_GAMMEService = new P_GAMMEService(_context, _p_GAMMERepository);
            _f_ENUMGAMMEService = new F_ENUMGAMMEService(_context, _f_ENUMGAMMERepository);
            _f_ARTENUMREFService = new F_ARTENUMREFService(_context, _f_ARTENUMREFRepository);
            _f_ARTGAMMEService = new F_ARTGAMMEService(_context, _f_ARTGAMMERepository);

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

            // =========================================================== CAS CREATION NOUVEAU ===========================================================
            if (estNouveau == 1)
            {
                // CAS GAMME ==============================================================================================================================
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
                // CAS ENUMGAMME ==============================================================================================================================
                else
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z].*[a-zA-Z].*[a-zA-Z]"))
                    {
                        string G_Intitule = listBox1.SelectedItem.ToString();
                        P_GAMME p_GAMME = _context.P_GAMME.Where(elt => elt.G_Intitule == G_Intitule).FirstOrDefault();
                        List<F_ARTICLE> listeArticles = _context.F_ARTICLE.Where(a => a.AR_Gamme1 == p_GAMME.cbIndice || a.AR_Gamme2 == p_GAMME.cbIndice).ToList();

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
                                        _context = new AppDbContext();
                                        F_ARTGAMME f_ARTGAMME = _context.F_ARTGAMME.Where(artG => artG.EG_Enumere == nouveauNom).FirstOrDefault();
                                        _f_ARTENUMREFService.NouveauGamme(f_ARTICLE.AR_Ref, estAG_No2, (short)f_ARTGAMME.AG_No, "", "");
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

                                        _context = new AppDbContext();
                                        F_ARTGAMME f_ARTGAMME = _context.F_ARTGAMME.Where(artG => artG.EG_Enumere == nouveauNom).FirstOrDefault();
                                        List<(int?, int?)> listeAG_No = _f_ARTENUMREFService.GetCombinaisonsAG_No(f_ARTICLE, estAG_No2, (short?)f_ARTGAMME.AG_No);
                                        foreach (var (AG_No1, AG_No2) in listeAG_No)
                                        {
                                            CreationManuelleEnumgamme creationManuelleEnumgamme = new CreationManuelleEnumgamme(AG_No1, AG_No2, f_ARTICLE.AR_Ref);
                                            creationManuelleEnumgamme.ShowDialog();
                                            if (choixCreationENUMGAMME.Resultat != null)
                                            {

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
                        _context = new AppDbContext();
                        listBox2.DataSource = null;
                        listBox2.DataSource = _context.F_ENUMGAMME.Where(eg => eg.EG_Enumere == nouveauNom).Select(eg => eg.EG_Enumere).ToList();
                        int index = listBox2.FindStringExact(nouveauNom);
                        listBox2.SelectedIndex = index;
                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois lettres de l'alphabet.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }


            // =========================================================== CAS MISE A JOUR ===========================================================
            else
            {
                // CAS GAMME ==============================================================================================================================
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
                // CAS ENUMGAMME ==============================================================================================================================
                else
                {
                    if (Regex.IsMatch(nouveauNom, @"[a-zA-Z].*[a-zA-Z].*[a-zA-Z]"))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Entrez au moins trois lettres de l'alphabet.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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




        // =========================================================================================================================================================================================
        // ===================================================================================== FIN EVENEMENTS ====================================================================================
        // =========================================================================================================================================================================================




    }
}
