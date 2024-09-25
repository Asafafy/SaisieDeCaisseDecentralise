using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SoftCaisse.Forms.ParamSociete
{
    public partial class ParamVenteComptoir : KryptonForm
    {
        private readonly AppDbContext _context;
        private P_PARAMETRECIAL _parametrecial;
        private List<F_COMPTEG> _listeCompteG;
        private readonly string _initCompteDebit;
        private readonly string _initCompteCredit;
        private readonly bool _initComptabiliser;
        public ParamVenteComptoir()
        {
            InitializeComponent();

            _context = new AppDbContext();

            _parametrecial = _context.P_PARAMETRECIAL.FirstOrDefault();
            _initComptabiliser = (_parametrecial.P_CptaCaisse == 1) ? true : false;
            _listeCompteG = _context.F_COMPTEG.OrderBy(c => c.CG_Num).ToList();
            checkBoxComptabiliser.Checked = _initComptabiliser;
            if (_initComptabiliser == false)
            {
                comboBoxCompteDebit.Enabled = false;
                comboBoxCompteCredit.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
            }

            comboBoxCompteDebit.DataSource = _listeCompteG.Select(c => c.CG_Num + " - " + c.CG_Intitule).ToList();
            int indexDebit = _listeCompteG.FindIndex(c => c.CG_Num == _parametrecial.P_DebitCaisse);
            comboBoxCompteDebit.SelectedIndex = indexDebit;

            comboBoxCompteCredit.DataSource = _listeCompteG.Select(c => c.CG_Num + " - " + c.CG_Intitule).ToList();
            int indexCredit = _listeCompteG.FindIndex(c => c.CG_Num == _parametrecial.P_CreditCaisse);
            comboBoxCompteCredit.SelectedIndex = indexCredit;

            _initCompteDebit = comboBoxCompteDebit.Text;
            _initCompteCredit = comboBoxCompteCredit.Text;
        }

        private void kryptonButtonOK_Click(object sender, System.EventArgs e)
        {
            if (checkBoxComptabiliser.Checked == true)
            {
                if (_initCompteDebit != comboBoxCompteDebit.Text || _initCompteCredit != comboBoxCompteCredit.Text)
                {
                    try
                    {
                        _parametrecial.P_DebitCaisse = comboBoxCompteDebit.Text.Split('-')[0].Trim();
                        _parametrecial.P_CreditCaisse = comboBoxCompteCredit.Text.Split('-')[0].Trim();
                        _parametrecial.P_CptaCaisse = (checkBoxComptabiliser.Checked == true) ? (short?)1 : (short?)0;
                        if ((_listeCompteG.Select(c => c.CG_Num).ToList().Contains(_parametrecial.P_DebitCaisse) || _parametrecial.P_DebitCaisse == "") && (_listeCompteG.Select(c => c.CG_Num).ToList().Contains(_parametrecial.P_CreditCaisse) || _parametrecial.P_CreditCaisse == ""))
                        {
                            _context.SaveChanges();
                            MessageBox.Show("Mise à jour avec succés! \n Compte débit: " + _parametrecial.P_DebitCaisse + "\n Compte crédit: " + _parametrecial.P_CreditCaisse);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Vos données sont erronées.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite! Vérifiez bien vos données d'entrées \n Erreur :" + ex);
                    }
                }
                else if (_initComptabiliser == false)
                {
                    _parametrecial.P_CptaCaisse = 1;
                    _context.SaveChanges();
                    MessageBox.Show("Modification effectuée avec succès!");
                    Close();
                }
                else
                {
                    Close();
                }

            }
            else
            {
                if (_initComptabiliser == true)
                {
                    _parametrecial.P_CptaCaisse = 0;
                    _context.SaveChanges();
                    MessageBox.Show("Modification effectuée avec succès!");
                    Close();
                }
                else
                {
                    Close();
                }

            }

        }

        private void checkBoxComptabiliser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComptabiliser.Checked == false)
            {
                label1.Enabled = false;
                label2.Enabled = false;
                comboBoxCompteDebit.Enabled = false;
                comboBoxCompteCredit.Enabled = false;
            }
            else
            {
                label1.Enabled = true;
                label2.Enabled = true;
                comboBoxCompteDebit.Enabled = true;
                comboBoxCompteCredit.Enabled = true;
            }
        }
    }
}
