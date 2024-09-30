using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms
{
    public partial class NouveauReglement : KryptonForm
    {
        private readonly AppDbContext _context;
        private readonly string _placeholderPiece = "Pièce";
        private readonly string _placeholderLibelle = "Description du règlement";
        private readonly string _placeholderReference = "Référence";
        private readonly string _placeholderNTiersOrigine = "Numéro tiers origine";
        private readonly string _paceholderIntituleTiersOrigine = "Intitulé tiers origine";
        private readonly string _placeholerMontant = "Montant";
        private readonly string _placeholderCours = "Cours";
        private readonly string _placeholerMontantDevise = "Montant devise";
        private readonly string _placeholderEtat = "Etat";
        private readonly string _placeholderSolde = "Solde";
        private readonly string _placeholderCloture = "Cloture";
        private readonly string _placeholderMiseEnBanque = "Mise en banque";
        private readonly string _placeholderImputeAnterieur = "Imputé antérieur";
        private readonly string _placeholderCommission = "Commission";
        private readonly string _placeholderMontantNet = "Montant net";




        // ========================================================= DEBUT CONSTRUCTEUR =========================================================
        public NouveauReglement()
        {
            InitializeComponent();

            _context = new AppDbContext();
            List<F_CAISSE> listeCaisses = _context.F_CAISSE.OrderBy(c => c.CA_No).ToList();
            List<F_COLLABORATEUR> listeCaissier = _context.F_COLLABORATEUR.OrderBy(c => c.CO_Caissier).ToList();

            label6.Enabled = false;
            comboBox3.Enabled = false;

            comboBox1.DataSource = listeCaisses.Select(c => c.CA_Intitule).ToList();
            comboBox2.DataSource = listeCaissier.Select(c => c.CO_Nom).ToList();

            // Initialisation du placeholder pour chaque TextBox
            textBox1.Text = _placeholderPiece;
            textBox2.Text = _placeholderLibelle;
            textBox3.Text = _placeholderReference;
            textBox4.Text = _placeholderNTiersOrigine;
            textBox5.Text = _paceholderIntituleTiersOrigine;
            textBox6.Text = _placeholerMontant;
            textBox7.Text = _placeholderCours;
            textBox8.Text = _placeholerMontantDevise;
            textBox9.Text = _placeholderEtat;
            textBox10.Text = _placeholderSolde;
            textBox11.Text = _placeholderCloture;
            textBox12.Text = _placeholderMiseEnBanque;
            textBox13.Text = _placeholderImputeAnterieur;
            textBox14.Text = _placeholderCommission;
            textBox15.Text = _placeholderMontantNet;
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
            textBox4.ForeColor = Color.Gray;
            textBox5.ForeColor = Color.Gray;
            textBox6.ForeColor = Color.Gray;
            textBox7.ForeColor = Color.Gray;
            textBox8.ForeColor = Color.Gray;
            textBox9.ForeColor = Color.Gray;
            textBox10.ForeColor = Color.Gray;
            textBox11.ForeColor = Color.Gray;
            textBox12.ForeColor = Color.Gray;
            textBox13.ForeColor = Color.Gray;
            textBox14.ForeColor = Color.Gray;
            textBox15.ForeColor = Color.Gray;

            // Assigner les mêmes événements aux différents TextBox (Effet placeholder)
            textBox1.Enter += textBox_Enter;
            textBox1.Leave += textBox_Leave;
            textBox2.Enter += textBox_Enter;
            textBox2.Leave += textBox_Leave;
            textBox3.Enter += textBox_Enter;
            textBox3.Leave += textBox_Leave;
            textBox4.Enter += textBox_Enter;
            textBox4.Leave += textBox_Leave;
            textBox5.Enter += textBox_Enter;
            textBox5.Leave += textBox_Leave;
            textBox6.Enter += textBox_Enter;
            textBox6.Leave += textBox_Leave;
            textBox7.Enter += textBox_Enter;
            textBox7.Leave += textBox_Leave;
            textBox8.Enter += textBox_Enter;
            textBox8.Leave += textBox_Leave;
            textBox9.Enter += textBox_Enter;
            textBox9.Leave += textBox_Leave;
            textBox10.Enter += textBox_Enter;
            textBox10.Leave += textBox_Leave;
            textBox11.Enter += textBox_Enter;
            textBox11.Leave += textBox_Leave;
            textBox12.Enter += textBox_Enter;
            textBox12.Leave += textBox_Leave;
            textBox13.Enter += textBox_Enter;
            textBox13.Leave += textBox_Leave;
            textBox14.Enter += textBox_Enter;
            textBox14.Leave += textBox_Leave;
            textBox15.Enter += textBox_Enter;
            textBox15.Leave += textBox_Leave;
        }
        // ========================================================= FIN CONSTRUCTEUR =========================================================




        // ========================================================= FONCTIONS =========================================================
        // ========================= fonctions réliées aux placeholder des textBox
        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.Text == GetPlaceholderText(textBox))
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = GetPlaceholderText(textBox);
                textBox.ForeColor = Color.Gray;
            }
        }

        private string GetPlaceholderText(TextBox textBox)
        {
            if (textBox == textBox1)
                return _placeholderPiece;
            else if (textBox == textBox2)
                return _placeholderLibelle;
            else if (textBox == textBox3)
                return _placeholderReference;
            else if (textBox == textBox4)
                return _placeholderNTiersOrigine;
            else if (textBox == textBox5)
                return _paceholderIntituleTiersOrigine;
            else if (textBox == textBox6)
                return _placeholerMontant;
            else if (textBox == textBox7)
                return _placeholderCours;
            else if (textBox == textBox8)
                return _placeholerMontantDevise;
            else if (textBox == textBox9)
                return _placeholderEtat;
            else if (textBox == textBox10)
                return _placeholderSolde;
            else if (textBox == textBox11)
                return _placeholderCloture;
            else if (textBox == textBox12)
                return _placeholderMiseEnBanque;
            else if (textBox == textBox13)
                return _placeholderImputeAnterieur;
            else if (textBox == textBox14)
                return _placeholderCommission;
            else if (textBox == textBox15)
                return _placeholderMontantNet;
            return "";
        }




        // ========================================================= EVENEMENTS =========================================================
        private void kptnBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void kryptonButton2_Click(object sender, System.EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            checkBox1.Checked = false;
        }
    }
}
