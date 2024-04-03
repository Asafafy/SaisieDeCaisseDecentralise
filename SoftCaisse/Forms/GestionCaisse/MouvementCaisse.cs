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

namespace SoftCaisse.Forms.GestionCaisse
{
    public partial class MouvementCaisse : Form
    {
        private readonly AppDbContext _context;
        private readonly FCaisseRepository _fCaisseRepository;

        public MouvementCaisse(string Intitule)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new FCaisseRepository(_context);
            var data = _fCaisseRepository.GetAll();
            string select= data.FirstOrDefault(u=>u.CA_Intitule==Intitule).CA_No+"";
            listeCaisse.DataSource =new BindingList<F_CAISSE>(data);
            listeCaisse.SelectedIndex = listeCaisse.FindString(select);
        }
    }
}
