using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
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
        private readonly P_PARAMETRECIAL _parametrecial;
        private List<F_COMPTEG> _listeCompteG;
        public MouvementCaisseForm()
        {
            InitializeComponent();

            _context = new AppDbContext();

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
                        int typereg = text == 0 ? 5 : 4;
                        string query = @"
                        Insert INTO [dbo].[F_CREGLEMENT](
                            [RG_Date],
                            [RG_Montant],
                            [N_Reglement],
                            [RG_Impute],
                            [RG_Libelle],
                            [RG_MontantDev],
                            [RG_Reference] ,
                            [RG_Compta],
                            [EC_No],
                            [RG_Type],
                            [RG_Cours],
                            [RG_TypeReg],
                            [N_Devise],
                            [JO_Num],
                            [RG_Impaye],
                            [RG_Heure],
                            [RG_Piece],
                            [CA_No],
                            [cbCA_No],
                            [CO_NoCaissier],
                            [cbCO_NoCaissier],
                            [RG_Transfere],
                            [RG_Cloture],
                            [RG_Ticket],
                            [RG_Souche],
                            [RG_DateEchCont],
                            [RG_MontantEcart],
                            [RG_NoBonAchat],
                            [RG_Valide],
                            [RG_Anterieur],
                            [RG_MontantCommission],
                            [RG_MontantNet],
                            [cbProt],
                            [cbModification],
                            [cbReplication],
                            [cbFlag],
                            [cbCreation],
                            [cbHashVersion],
                            [cbHashDate],
                            [RG_Banque],
                            [CG_Num]
                        )
                        values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},
                        {23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39},{40})";
                        _context.Database.ExecuteSqlCommand(query,
                            kryptonDateTimePicker1.Value,
                            montant,
                            3,
                            0,
                            commentaire_mouvement.Text,
                            0,
                            "",
                            0,
                            0,
                            2,
                            0,
                            typereg,
                            0,
                            "CAIS",
                            new DateTime(1753, 1, 1),
                            "000" + DateTime.Now.ToString("HH:mm:ss").Replace(":", ""),
                            "",
                            CaisseOuvert.CaisseID,
                            CaisseOuvert.CaisseID,
                            CaisseOuvert.CaissierID,
                            CaisseOuvert.CaissierID,
                            0,
                            0,
                            1,
                            0,
                            new DateTime(1753, 1, 1),
                            0,
                            0,
                            1,
                            0,
                            0,
                            0,
                            0,
                            DateTime.Now,
                            0,
                            0,
                            DateTime.Now,
                            1,
                            DateTime.Now,
                            0,
                            comboBox2.Text == "" ? null : comboBox2.Text.Split('-')[0].Trim()
                        );
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
