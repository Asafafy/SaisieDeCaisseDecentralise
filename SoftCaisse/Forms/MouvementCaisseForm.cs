using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Services;
using SoftCaisse.Utils.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms.MouvementCaisse
{
    public partial class MouvementCaisseForm : KryptonForm
    {
        private readonly AppDbContext _context;

        private readonly F_CREGLEMENTRepository f_CREGLEMENTRepository;

        private readonly P_PARAMETRECIAL _parametrecial;

        private List<F_COMPTEG> _listeCompteG;

        MainForm mainForm;




        public MouvementCaisseForm(MainForm form)
        {
            InitializeComponent();

            _context = new AppDbContext();
            f_CREGLEMENTRepository = new F_CREGLEMENTRepository(_context);
            mainForm = form;

            _parametrecial = _context.P_PARAMETRECIAL.FirstOrDefault();
            if (_parametrecial.P_CptaCaisse == 1)
            {
                comboBox2.Enabled = true;
                _listeCompteG = _context.F_COMPTEG.OrderBy(c => c.CG_Num).ToList();
                comboBox2.DataSource = _listeCompteG.Select(c => c.CG_Num + " - " + c.CG_Intitule).ToList();
                comboBox2.SelectedIndex = _listeCompteG.FindIndex(c => c.CG_Num == _parametrecial.P_DebitCaisse);
            }
            label2.Text = CaisseOuvert.CaisseText;
            type_mouvement.DataSource = new List<string> { "Sortie", "Entrée" };
            type_mouvement.SelectedIndex = 0;
        }


        private void type_mouvement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_mouvement.SelectedIndex == 0)
            {
                if (_parametrecial.P_DebitCaisse != "")
                {
                    comboBox2.SelectedIndex = _listeCompteG.FindIndex(c => c.CG_Num == _parametrecial.P_DebitCaisse);
                }
                else
                {
                    comboBox2.Text = "";
                }
            }
            else
            {
                if (_parametrecial.P_CreditCaisse != "")
                {
                    comboBox2.SelectedIndex = _listeCompteG.FindIndex(c => c.CG_Num == _parametrecial.P_CreditCaisse);
                }
                else
                {
                    comboBox2.Text = "";
                }
            }
        }


        private void enregistrement_mouvement(object sender, EventArgs e)
        {
            if (montant_mouvement.Text == "")
            {
                MessageBox.Show("Le champ \"Montant\" est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal montant;
                if (decimal.TryParse(montant_mouvement.Text, out montant))
                {
                    if (montant != 0)
                    {
                        int text = type_mouvement.SelectedIndex;
                        int typereg = text == 0 ? 4 : 5;
                        int? maxRG_No = _context.F_CREGLEMENT.Max(fcr => fcr.RG_No);

                        F_CREGLEMENT newFCReglement = new F_CREGLEMENT
                        {
                            RG_No = maxRG_No + 1,
                            RG_Date = kryptonDateTimePicker1.Value,
                            RG_Montant = montant,
                            N_Reglement = 3,
                            RG_Impute = 0,
                            RG_Libelle = commentaire_mouvement.Text,
                            RG_MontantDev = 0,
                            RG_Reference = "",
                            RG_Compta = 0,
                            EC_No = 0,
                            RG_Type = 2,
                            RG_Cours = 0,
                            RG_TypeReg = (short?)typereg,
                            N_Devise = 0,
                            JO_Num = "CAIS",
                            RG_Impaye = new DateTime(1753, 1, 1),
                            RG_Heure = "000" + DateTime.Now.ToString("HH:mm:ss").Replace(":", ""),
                            RG_Piece = "",
                            CA_No = mainForm.CaisseNo,
                            cbCA_No = mainForm.CaisseNo,
                            CO_NoCaissier = mainForm.CaissierCollabNo,
                            cbCO_NoCaissier = mainForm.CaissierCollabNo,
                            RG_Transfere = 0,
                            RG_Cloture = 0,
                            RG_Ticket = 1,
                            RG_Souche = 0,
                            RG_DateEchCont = new DateTime(1753, 1, 1),
                            RG_MontantEcart = 0,
                            RG_NoBonAchat = 0,
                            RG_Valide = 1,
                            RG_Anterieur = 0,
                            RG_MontantCommission = 0,
                            RG_MontantNet = 0,
                            cbProt = 0,
                            cbModification = DateTime.Now,
                            cbReplication = 0,
                            cbFlag = 0,
                            cbCreation = DateTime.Now,
                            cbHashVersion = 1,
                            cbHashDate = DateTime.Now,
                            RG_Banque = 0,
                            CG_Num = comboBox2.Text == "" ? null : comboBox2.Text.Split('-')[0].Trim()
                        };
                        f_CREGLEMENTRepository.Add(newFCReglement);

                        MessageBox.Show("Mouvement de caisse effectué.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Le montant du mouvement de caisse est nul.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Saisissez un nombre entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void montant_mouvement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void montant_mouvement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enregistrement_mouvement(sender, e);
            }
        }

        private void commentaire_mouvement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enregistrement_mouvement(sender, e);
            }
        }
    }
}
