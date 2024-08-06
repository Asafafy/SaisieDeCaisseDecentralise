using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.VenteComptoir;
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

namespace SoftCaisse.Forms.AttenteTicket
{
    public partial class ListAttenteForm : Form
    {

        private readonly AppDbContext _context;
        public ListAttenteForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            var liste = _context.F_DOCENTETE.Join(_context.F_CAISSE, post => post.CA_No, meta => meta.CA_No, (post, meta) => new { Post = post, Meta = meta })
            .Join(_context.F_COLLABORATEUR, post => post.Post.CO_No, meta => meta.CO_No, (post, meta) => new { Post = post, Meta = meta })
            .Where(u => u.Post.Post.DO_Attente == 1).ToList()
            .Select(u => new { Caisse = u.Post.Meta.CA_Intitule, Ticket = u.Post.Post.DO_Piece, Date = u.Post.Post.DO_Date, Heure = u.Post.Post.DO_Heure, Caissier = u.Meta.CO_Nom }).ToList();
            this.kryptonDataGridView1.DataSource = liste;
        }

        private void kryptonDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = kryptonDataGridView1.CurrentCell.RowIndex;
                string piece = kryptonDataGridView1.Rows[index].Cells["Ticket"].Value.ToString();
                F_DOCENTETE entete = _context.F_DOCENTETE.FirstOrDefault(u => u.DO_Piece == piece);
                List<F_DOCLIGNE> ligne = _context.F_DOCLIGNE.Where(u => u.DO_Piece == piece).ToList();
                this.Close();
                VenteComptoirForm comptoir = new VenteComptoirForm(entete.CA_No.Value, entete.CO_No.Value, entete, ligne);
                comptoir.Show();
            }
        }
    }
}
