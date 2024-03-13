using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            List<object> liste_objet = new List<object>()
            {
                new {Item="1" , valeur ="Fond de caisse"},
                new {Item="2" , valeur ="Entrées de caisse"},
                new {Item="3" , valeur ="Sorties de caisse"},
                new {Item="4" , valeur ="Remise à zéro"}
            };

        }

    }
}
