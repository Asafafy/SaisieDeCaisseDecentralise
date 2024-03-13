using SoftCaisse.Forms.Billetage;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Controls
{
    public partial class DeviseControl : UserControl
    {
        private readonly AppDbContext context;
        private readonly DeviseRepository _fCollaborateurRepository;
        public DeviseControl()
        {
            InitializeComponent();
            context = new AppDbContext();
            _fCollaborateurRepository = new DeviseRepository(context);
            var listCollabo = _fCollaborateurRepository.GetAll();
            var data = listCollabo.Select(collab => new { cbMarque = collab.cbMarq , Devise = collab.D_Intitule, Code_ISO = collab.D_CodeISO,Code_ISO_NUM = collab.D_CodeISONum,Cours = collab.D_Cours}).Where(collab => !string.IsNullOrEmpty(collab.Devise)).ToList();
            kryptonDataGridView1.DataSource = data;
        }

        private void btnDeviseClose_Click(object sender, EventArgs e)
        {
            Form ParamCaisseForm = this.FindForm();
            if (ParamCaisseForm != null)
            {
                ParamCaisseForm.Close();
            }

        }

        private void kryptonDataGridView1_DoubleClick(object sender, EventArgs e)
        {

            object datagrid = kryptonDataGridView1.CurrentRow.Cells["cbMarque"].Value;
            short cbMarq = Convert.ToInt16(datagrid.ToString());
            BilletageForm form = new BilletageForm(cbMarq);
            form.ShowDialog();
        }
    }
}
