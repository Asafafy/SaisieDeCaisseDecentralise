using SoftCaisse.Forms.ParamSociete;
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

namespace SoftCaisse.Controls
{
    public partial class CaisseControl : UserControl
    {
        public List<string> _caisse;
        private readonly AppDbContext _context;
        private readonly ClientRepository _clientRepository;
        public CaisseControl()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _clientRepository = new ClientRepository(_context);
            _caisse = _clientRepository.GetCTNumF_CompteT();
        }

        private void btnParamCaisseClose_Click(object sender, EventArgs e)
        {
            Form ParamCaisseForm = this.FindForm();
            if(ParamCaisseForm !=null) 
            { 
                ParamCaisseForm.Close();
            }
        }

        private void ClientComptoirCmbx_Click(object sender, EventArgs e)
        {
            ClientComptoirCmbx.Items.Clear();
            ClientComptoirCmbx.Items.AddRange(_caisse.ToArray());
        }
    }
}
