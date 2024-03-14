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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SoftCaisse.Forms.ControlCaisse
{
    public partial class ControlCaisseForm : KryptonForm
    {
        private readonly AppDbContext _context;
        public FCaisseRepository _fcaisserepository { get; set; }
        public DeviseRepository _fdeviserepository { get; set; }
        public FReglementRepository _freglementrepository { get; set; }
        public static List<object> liste_objet = new List<object>()
        {
            new {Item="0" , valeur ="Règlement"},
            new {Item="1" , valeur ="Acompte"},
            new {Item="2" , valeur ="Fond de caisse"},
            new {Item="3" , valeur ="Remise en banque"},
            new {Item="4" , valeur ="Sortie de caisse"},
            new {Item="5" , valeur ="Entrée de caisse"},
            new {Item="6" , valeur ="Remise à zéro"},
            new {Item="7" , valeur ="Contrôle de caisse"},
            new {Item="8" , valeur ="Bon d'achat"}
        };
        public ControlCaisseForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fcaisserepository = new FCaisseRepository(_context);
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

        }

        private void display_caisse(object sender, EventArgs e)
        {
            var liste = _freglementrepository.GetAllReglement(kryptonDateTimePicker1.Value, Controlecmbx.SelectedValue.ToString(), Convert.ToInt32(Caisse.SelectedValue), Convert.ToInt32(Devise.SelectedValue));
            decimal somme = _freglementrepository.get_somme_constate(liste);
            label9.Text = string.Format("{0:N2}", somme) ;
            label10.Text = string.Format("{0:N2}", somme);
            kryptonDataGridView1.DataSource = liste;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = textBox1.Text;
        }

        private void Controlecmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = Controlecmbx.SelectedValue.ToString();
            if(value == "1")
            {
                label5.Show();
                textBox1.Show();
            }
            else
            {
                label5.Hide();
                textBox1.Hide();
            }
        }
    }
}
