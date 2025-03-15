using Soft_Caisse.Forms;
using Soft_Caisse.Views.Donnees;
using Soft_Caisse.Views.FonctionsViews;
using Soft_Caisse.Views.Operations;
using Soft_Caisse.Views.Parametres;
using Soft_Caisse.Views.Statistiques;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Soft_Caisse
{
    public partial class Home : Form
    {
        // =========================================================================================================
        // DECLARATION DES VARIABLES ===============================================================================
        // =========================================================================================================
        public Form formActif;










        // =========================================================================================================
        // FONCTIONS DESIGN ========================================================================================
        // =========================================================================================================

        private void button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(128, 46, 89, 132);
            }
        }



        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.Transparent; // Couleur d'origine
            }
        }



        public void ShowBackgroundImage()
        {
            int trentPourcent = (int)(panelContainer.Width * 30 / 100);
            int newWidth = (int)(panelContainer.Width - trentPourcent);

            pictureBoxBackground.Visible = true;
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.CenterImage;
            ResizeImage.ResizeImagePictureBox(pictureBoxBackground, newWidth, newWidth);
        }



        public void HideBackgroundImage()
        {
            pictureBoxBackground.Visible = false;
        }



        public void OpenFormInPanel(Form childForm)
        {
            if (childForm == formActif) return;

            // Fermer tous les autres formulaires dans le panel
            foreach (Control ctrl in panelContainer.Controls)
            {
                if (ctrl is Form form)
                {
                    formActif = null;
                    form.Close();
                }
            }

            HideBackgroundImage();

            // Configuration du formulaire enfant
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            int leftPosition = (panelContainer.Width - childForm.Width) / 2;
            int topPosition = (panelContainer.Height - childForm.Height) / 2;
            if (topPosition < 0) topPosition = 0;
            if (leftPosition < 0) leftPosition = 0;
            childForm.Top = topPosition;
            childForm.Left = leftPosition;

            // Ajouter le formulaire au panel et l'afficher
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }











        // =========================================================================================================
        // CONSTRUCTEUR ============================================================================================
        // =========================================================================================================
        public Home()
        {
            InitializeComponent();

            BorderRadius.ApplyBorderRaduisOnButton(btnSeDeconnecter, 56);

            BorderRadius.ApplyBorderRaduisOnButton(btnParametres, 56);
            BorderRadius.ApplyBorderRaduisOnButton(btnDonnees, 56);
            BorderRadius.ApplyBorderRaduisOnButton(btnOperations, 56);
            BorderRadius.ApplyBorderRaduisOnButton(btnStatistiques, 56);

            BorderRadius.ApplyBorderRaduisOnButton(btnParametresDeLaBase, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnParametresSociete, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnGestionDesUtilisateurs, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnGestionDesRoles, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnArticles, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnCaisses, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnClients, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnCollaborateurs, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnFamilles, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnOuvertureDeCaisse, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnVenteComptoir, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnMouvementsDeCaisse, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnFermetureDeCaisse, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnDocumentsDesStocks, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnDocumentsDesVentes, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnSaisieDesReglements, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnClotureDesCaisses, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnControleDesCaisses, 35);
            BorderRadius.ApplyBorderRaduisOnButton(btnStatistiquesDesCaisses, 35);

            btnParametresDeLaBase.MouseEnter += button_MouseEnter;
            btnParametresSociete.MouseEnter += button_MouseEnter;
            btnGestionDesUtilisateurs.MouseEnter += button_MouseEnter;
            btnArticles.MouseEnter += button_MouseEnter;
            btnCaisses.MouseEnter += button_MouseEnter;
            btnClients.MouseEnter += button_MouseEnter;
            btnCollaborateurs.MouseEnter += button_MouseEnter;
            btnFamilles.MouseEnter += button_MouseEnter;
            btnOuvertureDeCaisse.MouseEnter += button_MouseEnter;
            btnGestionDesRoles.MouseEnter += button_MouseEnter;
            btnVenteComptoir.MouseEnter += button_MouseEnter;
            btnMouvementsDeCaisse.MouseEnter += button_MouseEnter;
            btnFermetureDeCaisse.MouseEnter += button_MouseEnter;
            btnDocumentsDesStocks.MouseEnter += button_MouseEnter;
            btnDocumentsDesVentes.MouseEnter += button_MouseEnter;
            btnSaisieDesReglements.MouseEnter += button_MouseEnter;
            btnClotureDesCaisses.MouseEnter += button_MouseEnter;
            btnControleDesCaisses.MouseEnter += button_MouseEnter;
            btnStatistiquesDesCaisses.MouseEnter += button_MouseEnter;

            btnParametresDeLaBase.MouseLeave += button_MouseLeave;
            btnParametresSociete.MouseLeave += button_MouseLeave;
            btnGestionDesUtilisateurs.MouseLeave += button_MouseLeave;
            btnArticles.MouseLeave += button_MouseLeave;
            btnCaisses.MouseLeave += button_MouseLeave;
            btnClients.MouseLeave += button_MouseLeave;
            btnCollaborateurs.MouseLeave += button_MouseLeave;
            btnFamilles.MouseLeave += button_MouseLeave;
            btnOuvertureDeCaisse.MouseLeave += button_MouseLeave;
            btnGestionDesRoles.MouseLeave += button_MouseLeave;
            btnVenteComptoir.MouseLeave += button_MouseLeave;
            btnMouvementsDeCaisse.MouseLeave += button_MouseLeave;
            btnFermetureDeCaisse.MouseLeave += button_MouseLeave;
            btnDocumentsDesStocks.MouseLeave += button_MouseLeave;
            btnDocumentsDesVentes.MouseLeave += button_MouseLeave;
            btnSaisieDesReglements.MouseLeave += button_MouseLeave;
            btnClotureDesCaisses.MouseLeave += button_MouseLeave;
            btnControleDesCaisses.MouseLeave += button_MouseLeave;
            btnStatistiquesDesCaisses.MouseLeave += button_MouseLeave;

            btnParametresDeLaBase.Visible = true;
            btnParametresSociete.Visible = true;
            btnGestionDesUtilisateurs.Visible = true;
            btnGestionDesRoles.Visible = true;
            btnArticles.Visible = false;
            btnCaisses.Visible = false;
            btnClients.Visible = false;
            btnCollaborateurs.Visible = false;
            btnFamilles.Visible = false;
            btnOuvertureDeCaisse.Visible = false;
            btnVenteComptoir.Visible = false;
            btnMouvementsDeCaisse.Visible = false;
            btnFermetureDeCaisse.Visible = false;
            btnDocumentsDesStocks.Visible = false;
            btnDocumentsDesVentes.Visible = false;
            btnSaisieDesReglements.Visible = false;
            btnClotureDesCaisses.Visible = false;
            btnControleDesCaisses.Visible = false;
            btnStatistiquesDesCaisses.Visible = false;
        }











        // =========================================================================================================
        // EVENEMENTS DESIGN =======================================================================================
        // =========================================================================================================
        private void btnParametres_Click(object sender, EventArgs e)
        {
            btnParametresDeLaBase.Visible = true;
            btnParametresSociete.Visible = true;
            btnGestionDesUtilisateurs.Visible = true;
            btnGestionDesRoles.Visible = true;
            btnArticles.Visible = false;
            btnCaisses.Visible = false;
            btnClients.Visible = false;
            btnCollaborateurs.Visible = false;
            btnFamilles.Visible = false;
            btnOuvertureDeCaisse.Visible = false;
            btnVenteComptoir.Visible = false;
            btnMouvementsDeCaisse.Visible = false;
            btnFermetureDeCaisse.Visible = false;
            btnDocumentsDesStocks.Visible = false;
            btnDocumentsDesVentes.Visible = false;
            btnSaisieDesReglements.Visible = false;
            btnClotureDesCaisses.Visible = false;
            btnControleDesCaisses.Visible = false;
            btnStatistiquesDesCaisses.Visible = false;
        }



        private void btnDonnees_Click(object sender, EventArgs e)
        {
            btnParametresDeLaBase.Visible = false;
            btnParametresSociete.Visible = false;
            btnGestionDesUtilisateurs.Visible = false;
            btnGestionDesRoles.Visible = false;
            btnArticles.Visible = true;
            btnCaisses.Visible = true;
            btnClients.Visible = true;
            btnCollaborateurs.Visible = true;
            btnFamilles.Visible = true;
            btnOuvertureDeCaisse.Visible = false;
            btnVenteComptoir.Visible = false;
            btnMouvementsDeCaisse.Visible = false;
            btnFermetureDeCaisse.Visible = false;
            btnDocumentsDesStocks.Visible = false;
            btnDocumentsDesVentes.Visible = false;
            btnSaisieDesReglements.Visible = false;
            btnClotureDesCaisses.Visible = false;
            btnControleDesCaisses.Visible = false;
            btnStatistiquesDesCaisses.Visible = false;
        }


        private void btnOperations_Click(object sender, EventArgs e)
        {
            btnParametresDeLaBase.Visible = false;
            btnParametresSociete.Visible = false;
            btnGestionDesUtilisateurs.Visible = false;
            btnGestionDesRoles.Visible = false;
            btnArticles.Visible = false;
            btnCaisses.Visible = false;
            btnClients.Visible = false;
            btnCollaborateurs.Visible = false;
            btnFamilles.Visible = false;
            btnOuvertureDeCaisse.Visible = true;
            btnVenteComptoir.Visible = true;
            btnMouvementsDeCaisse.Visible = true;
            btnFermetureDeCaisse.Visible = true;
            btnDocumentsDesStocks.Visible = true;
            btnDocumentsDesVentes.Visible = true;
            btnSaisieDesReglements.Visible = true;
            btnClotureDesCaisses.Visible = true;
            btnControleDesCaisses.Visible = false;
            btnStatistiquesDesCaisses.Visible = false;
        }


        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            btnParametresDeLaBase.Visible = false;
            btnParametresSociete.Visible = false;
            btnGestionDesUtilisateurs.Visible = false;
            btnGestionDesRoles.Visible = false;
            btnArticles.Visible = false;
            btnCaisses.Visible = false;
            btnClients.Visible = false;
            btnCollaborateurs.Visible = false;
            btnFamilles.Visible = false;
            btnOuvertureDeCaisse.Visible = false;
            btnVenteComptoir.Visible = false;
            btnMouvementsDeCaisse.Visible = false;
            btnFermetureDeCaisse.Visible = false;
            btnDocumentsDesStocks.Visible = false;
            btnDocumentsDesVentes.Visible = false;
            btnSaisieDesReglements.Visible = false;
            btnClotureDesCaisses.Visible = false;
            btnControleDesCaisses.Visible = true;
            btnStatistiquesDesCaisses.Visible = true;
        }



        private void Home_Load(object sender, EventArgs e)
        {
            // LOGIN ============================================
            using (BlurForm blurForm = new BlurForm(this))
            {
                blurForm.Show();
                using (SeConnecter seConnecter = new SeConnecter())
                {
                    seConnecter.ShowDialog();
                }
                blurForm.Close();
            }
        }



        private void panelContainer_Resize(object sender, EventArgs e)
        {
            ShowBackgroundImage();
        }











        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================
        private void btnParametresDeLaBase_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Paramètres de la base"
            if (formActif is ParametresDeLaBase) return;
            ParametresDeLaBase parametresDeLaBase = new ParametresDeLaBase(this);
            OpenFormInPanel(parametresDeLaBase);
            formActif = parametresDeLaBase;
        }

        private void btnParametresSociete_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Paramètres société"
            if (formActif is ParametresSocietes) return;
            ParametresSocietes parametresSociete = new ParametresSocietes(this);
            OpenFormInPanel(parametresSociete);
            formActif = parametresSociete;
        }

        private void btnGestionDesUtilisateurs_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Gestion des utilisateurs"
            if (formActif is GestionDesUtilisateurs) return;
            GestionDesUtilisateurs gestionDesUtilisateurs = new GestionDesUtilisateurs(this);
            OpenFormInPanel(gestionDesUtilisateurs);
            formActif = gestionDesUtilisateurs;
        }

        private void btnGestionDesRoles_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Gestion des rôles"
            if (formActif is GestionDesRoles) return;
            GestionDesRoles gestionDesUtilisateurs = new GestionDesRoles(this);
            OpenFormInPanel(gestionDesUtilisateurs);
            formActif = gestionDesUtilisateurs;
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Articles"
            if (formActif is Articles) return;
            Articles articles = new Articles(this);
            OpenFormInPanel(articles);
            formActif = articles;
        }

        private void btnCaisses_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Caisses"
            if (formActif is Caisses) return;
            Caisses caisses = new Caisses(this);
            OpenFormInPanel(caisses);
            formActif = caisses;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Clients"
            if (formActif is Clients) return;
            Clients clients = new Clients(this);
            OpenFormInPanel(clients);
            formActif = clients;
        }

        private void btnCollaborateurs_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Collaborateurs"
            if (formActif is Collaborateurs) return;
            Collaborateurs collaborateurs = new Collaborateurs(this);
            OpenFormInPanel(collaborateurs);
            formActif = collaborateurs;
        }

        private void btnFamilles_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Familles"
            if (formActif is Familles) return;
            Familles familles = new Familles(this);
            OpenFormInPanel(familles);
            formActif = familles;

        }

        private void btnOuvertureDeCaisse_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Ouverture de caisse"
            if (formActif is OuvertureDeCaisse) return;
            OuvertureDeCaisse ouvertureDeCaisse = new OuvertureDeCaisse(this);
            OpenFormInPanel(ouvertureDeCaisse);
            formActif = ouvertureDeCaisse;
        }

        private void btnVenteComptoir_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Vente comptoir"
            if (formActif is VenteComptoir) return;
            VenteComptoir venteComptoir = new VenteComptoir(this);
            OpenFormInPanel(venteComptoir);
            formActif = venteComptoir;
        }

        private void btnMouvementsDeCaisse_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Mouvements de caisse"
            if (formActif is MouvementDeCaisse) return;
            MouvementDeCaisse mouvementDeCaisse = new MouvementDeCaisse(this);
            OpenFormInPanel(mouvementDeCaisse);
            formActif = mouvementDeCaisse;
        }

        private void btnFermetureDeCaisse_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Fermeture de caisse"
            if (formActif is FermetureDeCaisse) return;
            FermetureDeCaisse fermetureDeCaisse = new FermetureDeCaisse(this);
            OpenFormInPanel(fermetureDeCaisse);
            formActif = fermetureDeCaisse;
        }

        private void btnDocumentsDesStocks_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Documents des stocks"
            if (formActif is DocumentsDesStocks) return;
            DocumentsDesStocks documentsDesStocks = new DocumentsDesStocks(this);
            OpenFormInPanel(documentsDesStocks);
            formActif = documentsDesStocks;
        }

        private void btnDocumentsDesVentes_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Documents des ventes"
            if (formActif is DocumentsDesVentes) return;
            DocumentsDesVentes documentsDesVentes = new DocumentsDesVentes(this);
            OpenFormInPanel(documentsDesVentes);
            formActif = documentsDesVentes;
        }

        private void btnSaisieDesReglements_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Saisie des règlements"
            if (formActif is SaisieDesReglements) return;
            SaisieDesReglements saisieDesReglements = new SaisieDesReglements(this);
            OpenFormInPanel(saisieDesReglements);
            formActif = saisieDesReglements;
        }

        private void btnClotureDesCaisses_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Clôture des caisses"
            if (formActif is ClotureDesCaisses) return;
            ClotureDesCaisses clotureDesCaisses = new ClotureDesCaisses(this);
            OpenFormInPanel(clotureDesCaisses);
            formActif = clotureDesCaisses;
        }

        private void btnControleDesCaisses_Click(object sender, EventArgs e)
        {
            //  Route vers Fenêtre "Contrôle des caisses"
            if (formActif is ControleDeCaisse) return;
            ControleDeCaisse controleDeCaisse = new ControleDeCaisse(this);
            OpenFormInPanel(controleDeCaisse);
            formActif = controleDeCaisse;
        }

        private void btnStatistiquesDesCaisses_Click(object sender, EventArgs e)
        {
            // Route vers Fenêtre "Statistiques des caisses"
            if (formActif is StatistiquesDesCaisses) return;
            StatistiquesDesCaisses statistiquesDesCaisses = new StatistiquesDesCaisses(this);
            OpenFormInPanel(statistiquesDesCaisses);
            formActif = statistiquesDesCaisses;
        }













        // =========================================================================================================
        // EVENEMENTS ROUTES =======================================================================================
        // =========================================================================================================









    }
}
