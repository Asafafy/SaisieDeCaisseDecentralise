using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Models;
using SoftCaisse.Repositories;

namespace SoftCaisse.Forms.Billetage
{
    public partial class BilletageForm : KryptonForm
    {

        private readonly AppDbContext context;
        private readonly FBilletageRepository _fbilletageRepository;
        public BilletageForm(int cbMarque)
        {
            InitializeComponent();
            context = new AppDbContext();
            _fbilletageRepository = new FBilletageRepository(context);
            kryptonDataGridView1.DataSource = _fbilletageRepository.GetAll().Where(u=>u.N_Devise == cbMarque).Select(u=>new { Intitulé=u.BI_Intitule, Valeur=u.BI_Valeur, cbMarq=u.cbMarq }).ToList();

        }
    }
}
