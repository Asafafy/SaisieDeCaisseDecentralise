using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Forms.ClotureCaisse
{
    public partial class ClotureCaisse : Form
    {
        private readonly AppDbContext _context;
        public ClotureCaisse()
        {
            _context = new AppDbContext();
            InitializeComponent();
            kryptonComboBox1.DataSource =_context.F_CAISSE.Select(u=>new {Value= u.CA_No,Text = u.CA_Intitule }).ToArray();
            kryptonComboBox2.DataSource =_context.F_CAISSE.Select(u=>new {Value= u.CA_No,Text = u.CA_Intitule }).ToArray();
            kryptonComboBox3.DataSource =_context.P_SOUCHEVENTE.Where(u=> u.S_Valide==1 ).Select(u=>new {Value= u.cbMarq,Text=u.S_Intitule}).ToArray();
            kryptonComboBox1.ValueMember = "Value";
            kryptonComboBox1.DisplayMember = "Text";
            kryptonComboBox2.ValueMember = "Value";
            kryptonComboBox2.DisplayMember = "Text";
            kryptonComboBox3.ValueMember = "Value";
            kryptonComboBox3.DisplayMember = "Text";
            kryptonTextBox1.Text = _context.F_DOCCURRENTPIECE.FirstOrDefault(u=>u.cbMarq==74).DC_Piece;



        }

        private void show_options(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                kryptonComboBox7.Enabled = true;
                kryptonComboBox8.Enabled = true;
            }
            else
            {
                kryptonComboBox7.Enabled = false;
                kryptonComboBox8.Enabled = false;
            }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cloturer_caisse(object sender, EventArgs e)
        {
            var liste=_context.F_DOCENTETE.Where(u => u.CA_No >= Int32.Parse(kryptonComboBox1.SelectedValue.ToString()) && u.CA_No <= Int32.Parse(kryptonComboBox2.SelectedValue.ToString()));    
            foreach(var item in liste)
            {
                item.DO_Cloture = 1;
            }
            _context.SaveChanges();
        }
    }
}
