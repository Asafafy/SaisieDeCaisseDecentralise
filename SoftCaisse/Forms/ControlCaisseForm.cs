using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objets100cLib;

namespace SoftCaisse.Forms.ControlCaisse
{
    public partial class ControlCaisseForm : KryptonForm
    {
        // ======================================================================================================
        // DECLARATION DES VARIABLES ============================================================================
        // ======================================================================================================
        private readonly AppDbContext _context;
        public F_CAISSERepository _fcaisserepository { get; set; }
        public DeviseRepository _fdeviserepository { get; set; }
        public FReglementRepository _freglementrepository { get; set; }
        // ======================================================================================================
        // FIN DECLARATION DES VARIABLES ========================================================================
        // ======================================================================================================










        // ======================================================================================================
        // DEBUT CONSTRUCTEUR ===================================================================================
        // ======================================================================================================
        public ControlCaisseForm()
        {
            InitializeComponent();

            _context = new AppDbContext();

            _fcaisserepository = new F_CAISSERepository(_context);
            _fdeviserepository = new DeviseRepository(_context);
            _freglementrepository = new FReglementRepository(_context);

            var caisse = _fcaisserepository.GetAll();
            Caisse.Items.Clear();
            var DataCaisse = caisse.Select(c => new { Item = c.CA_No,Value = c.CA_Intitule }).ToArray();
            Caisse.DataSource = DataCaisse;
            Caisse.DisplayMember = "Value";
            Caisse.ValueMember = "Item";
            Devise.Items.Clear();
            var devise = _fdeviserepository.GetAll().Where(u=>!string.IsNullOrEmpty(u.D_Intitule));
            var DataDevise = devise.Select(c => new { Item = c.cbMarq, Value = c.D_Intitule }).ToArray();
            Devise.DataSource = DataDevise;
            Devise.DisplayMember = "Value";
            Devise.ValueMember = "Item";
            Controlecmbx.Items.Clear();
            List<Controle> listeControle = new List<Controle>()
            {
                new Controle() { item = "1" , valeur = "Selon les valeurs globales" },
                new Controle() { item = "2", valeur = "Par mode de réglement"}
            };
            Controlecmbx.DataSource = listeControle;
            Controlecmbx.DisplayMember = "valeur";
            Controlecmbx.ValueMember = "item";
            label8.Text = "Ecart";
        }
        // ======================================================================================================
        // FIN CONSTRUCTEUR =====================================================================================
        // ======================================================================================================










        // ======================================================================================================
        // DEBUT EVENEMENTS =====================================================================================
        // ======================================================================================================
        private void display_caisse(object sender, EventArgs e)
        {
            string value = Controlecmbx.SelectedValue.ToString();
            decimal somme = 0;
            if (value == "1")
            {
                var liste = _freglementrepository.GetAllReglement(kryptonDateTimePicker1.Value, Controlecmbx.SelectedValue.ToString(), Convert.ToInt32(Caisse.SelectedValue), Convert.ToInt32(Devise.SelectedValue));
                kryptonDataGridView1.DataSource = liste;
                kryptonDataGridView1.Columns["intitule"].HeaderText = "Intitulé ";
                kryptonDataGridView1.Columns["Montant"].HeaderText = "Montant en caisse";
                kryptonDataGridView1.Columns["MontantConstate"].Visible = false;
                kryptonDataGridView1.Columns["Ecart"].Visible=false;
                kryptonDataGridView1.Columns["intitule"].ReadOnly = true;
                kryptonDataGridView1.Columns["Montant"].ReadOnly = true;
                somme = _freglementrepository.get_somme_constate(kryptonDateTimePicker1.Value, Convert.ToInt32(Caisse.SelectedValue));
            }
            else
            {
                var liste = _freglementrepository.GetParModeReglement(kryptonDateTimePicker1.Value, Controlecmbx.SelectedValue.ToString(), Convert.ToInt32(Caisse.SelectedValue), Convert.ToInt32(Devise.SelectedValue));
                kryptonDataGridView1.DataSource = liste;
                kryptonDataGridView1.Columns["intitule"].HeaderText = "Intitulé ";
                kryptonDataGridView1.Columns["Montant"].HeaderText = "Montant en caisse";
                kryptonDataGridView1.Columns["MontantConstate"].HeaderText = "Montant constaté";
                kryptonDataGridView1.Columns["Ecart"].HeaderText = "Ecart";
                kryptonDataGridView1.Columns["MontantConstate"].Visible = true;
                kryptonDataGridView1.Columns["Ecart"].Visible = true;
                kryptonDataGridView1.Columns["MontantConstate"].ReadOnly = false;
                kryptonDataGridView1.Columns["intitule"].ReadOnly = true;
                kryptonDataGridView1.Columns["Montant"].ReadOnly = true;
                kryptonDataGridView1.Columns["Ecart"].ReadOnly = true;
                somme = _freglementrepository.get_somme_constate(kryptonDateTimePicker1.Value, Convert.ToInt32(Caisse.SelectedValue));
            }
            label9.Text = string.Format("{0:N2}", somme) ;
            label10.Text = string.Format("{0:N2}", somme);
            label11.Text = string.Format("{0:N2}", 0);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double debut = 0;
            double fin = 0;
            var boo1=Double.TryParse(textBox1.Text, out debut);
            label10.Text = string.Format("{0:N2}", debut);
            var boo2=Double.TryParse(label9.Text,out fin);
            if(string.IsNullOrEmpty(label10.Text) || !boo1)
            {
                label10.Text = "0";
            }
            if(string.IsNullOrEmpty(label9.Text) || !boo2)
            {
                label9.Text = "0";
            }
            debut -= fin;
            label11.Text = string.Format("{0:N2}", debut);
        }

        private void Controlecmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = Controlecmbx.SelectedValue.ToString();
            //decimal somme = 0;
            if (value == "1")
            {
                label5.Show();
                textBox1.Show();
                //kryptonDataGridView1.Columns["MontantConstate"].Visible = false;
                //kryptonDataGridView1.Columns["Ecart"].Visible = false;
            }
            else
            {
                label5.Hide();
                textBox1.Hide();
                //kryptonDataGridView1.Columns["MontantConstate"].Visible = true;
                //kryptonDataGridView1.Columns["Ecart"].Visible = true;
                //var liste = _freglementrepository.GetParModeReglement(kryptonDateTimePicker1.Value, Controlecmbx.SelectedValue.ToString(), Convert.ToInt32(Caisse.SelectedValue), Convert.ToInt32(Devise.SelectedValue));
                //kryptonDataGridView1.DataSource = liste;
                //somme = _freglementrepository.get_somme_constate(liste);

            }
            //label9.Text = string.Format("{0:N2}", somme);
            //label10.Text = string.Format("{0:N2}", somme);
        }

        private void kryptonDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (kryptonDataGridView1.Rows.Count != 0 && e.RowIndex>=0)
            {
                if (kryptonDataGridView1.Columns[e.ColumnIndex].Name == "MontantConstate")
                {
                    double valeur = 0;
                    Double.TryParse(kryptonDataGridView1.Rows[e.RowIndex].Cells["Montant"].Value.ToString(), out valeur);
                    double somme = 0;
                    Double.TryParse(kryptonDataGridView1.Rows[e.RowIndex].Cells["MontantConstate"].Value.ToString(), out somme);
                    kryptonDataGridView1.Rows[e.RowIndex].Cells["Ecart"].Value = string.Format("{0:N2}", somme - valeur);
                    label10.Text = string.Format("{0:N2}", SommeColumn("MontantConstate"));
                    label11.Text = string.Format("{0:N2}", SommeColumn("Ecart"));
                }
            }
        }
        public double SommeColumn(string columns)
        {
            double valeur = 0;
            foreach (DataGridViewRow item in kryptonDataGridView1.Rows)
            {
                double val = 0;
                string constat = item.Cells[columns].FormattedValue.ToString();
                Double.TryParse(constat, out val);
                valeur += val;
            }
            return valeur;
        }

        private void generer_ecart(object sender, EventArgs e)
        {
            if(generation_ecart.Checked)
            {
                int caisse = Int32.Parse(Caisse.SelectedValue.ToString());

                //string path = "C:\\Users\\Public\\Documents\\Sage\\Saisie de caisse décentralisée 100c\\Bijou.gcm";
                //BSCIALApplication100c oCial = new BSCIALApplication100c();
                //oCial.Open();
                //IBODocumentReglement iReglt = (IBODocumentReglement)oCial.FactoryDocumentReglement.Create();
                //iReglt.RG_Date = DateTime.Now ;
                //iReglt.RG_Reference = "";
                //iReglt.RG_Libelle = "Ecart contrôle de caisse";
                //iReglt.RG_Montant = Double.Parse(label11.Text);
                //iReglt.Journal = oCial.CptaApplication.FactoryJournal.ReadNumero("CAIS");
                //iReglt.TiersPayeur. = ;
                //iReglt.CompteG = ;
                //iReglt.WriteDefault();

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
                    [RG_Banque],
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
                    [cbHashDate]
                )
                values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},
                {23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38})
                ";
                using (AppDbContext context = new AppDbContext())
                {
                    context.Database.ExecuteSqlCommand(query,
                    DateTime.Now,
                    Decimal.Parse(label11.Text),
                    3,
                    0,
                    "Ecart contrôle de caisse",
                    0,
                    "",
                    0,
                    0,
                    2,
                    0,
                    7,
                    Int16.Parse(Devise.SelectedValue.ToString()),
                    "CAIS",
                    new DateTime(1753, 1, 1),
                    "000" + DateTime.Now.ToString("HH:mm:ss").Replace(":", ""),
                    "",
                    caisse,
                    caisse,
                    0,
                    0,
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
                    DateTime.Now
                );
                }
                
                Close();
            }
        }



        // ======================================================================================================
        // DEBUT EVENEMENTS =====================================================================================
        // ======================================================================================================




    }
}
