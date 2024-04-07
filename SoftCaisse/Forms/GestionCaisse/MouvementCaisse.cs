using SoftCaisse.Models;
using SoftCaisse.Repositories;
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

namespace SoftCaisse.Forms.GestionCaisse
{
    public partial class MouvementCaisse : Form
    {
        private readonly AppDbContext _context;
        private readonly FCaisseRepository _fCaisseRepository;
        public string menu { get; set; }

        public MouvementCaisse(string Intitule)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new FCaisseRepository(_context);
            var data = _fCaisseRepository.GetAll();
            listeCaisse.DataSource =data;
            listeCaisse.DisplayMember = "CA_Intitule";
            listeCaisse.ValueMember = "CA_No";
            menu =  "mouvement";

        }

        private void document_state(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "document";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();

        }

        private void details_click(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "details";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();
        }

        private void ticket_archive(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "ticketArchive";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();
        }

        private void mouvement_click(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "mouvement";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(listeCaisse.SelectedValue.ToString());
            if (menu== "document")
            {
                decimal sommeHT = 0;
                decimal sommeTaxe = 0;
                decimal sommeTTC = 0;
                tableMouvement.DataSource = _context.F_DOCENTETE.Where(u => u.CA_No == value).ToList().Select(u =>
                {

                    var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.CO_NoCaissier && a.CO_Vendeur == 1);
                    var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.CO_No && a.CO_Caissier == 1);
                    decimal montant = u.DO_TotalHT.Value;
                    sommeHT += montant;
                    sommeTaxe += montant*0.2m;
                    return new
                    {
                        Colonne1 = u.cbMarq,
                        Colonne2 = u.DO_Date,
                        Colonne3 = caissier == null ? "" : caissier.CO_Nom + " " + caissier.CO_Prenom,
                        Colonne4 = vendeur == null ? "" : vendeur.CO_Nom + " " + vendeur.CO_Prenom,
                        Colonne5 = montant *1.2m

                    };

                }
                ).ToList();
                sommeTTC = sommeHT+sommeTaxe;
                Total.Text = sommeTaxe + "";
                Fond.Text = sommeHT + "";
                Situation.Text = sommeTTC + "";
                label1.Text = "Chiffre d'affaire HT";
                label2.Text = "Total taxes";
                label3.Text = "Chiffre d'affaire TTC";
                tableMouvement.Columns["Colonne1"].HeaderText = "N° pièce ";
                tableMouvement.Columns["Colonne2"].HeaderText = "Date ";
                tableMouvement.Columns["Colonne3"].HeaderText = "Caissier ";
                tableMouvement.Columns["Colonne4"].HeaderText = "Vendeur ";
                tableMouvement.Columns["Colonne5"].HeaderText = "Montant TTC ";

            }
            else if(menu=="mouvement")
            {
                decimal fond = 0;
                _context.F_CREGLEMENT.Where(u=>u.CA_No==value && u.RG_TypeReg==2 && u.RG_Montant!=null).ToList().ForEach(u=>fond+=u.RG_Montant.Value);
                decimal total = 0;
                decimal situation = 0;
                var caisse = _context.F_CAISSE.FirstOrDefault(a => a.CA_No.Value == value );

                var tableau = _context.F_CREGLEMENT.Where(u => u.CA_No == value).ToList().Select(u =>
                {
                    var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.CO_NoCaissier && a.CO_Caissier == 1);
                    var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == caisse.CO_No && a.CO_Vendeur == 1);
                    total += u.RG_Montant.Value;

                    return new
                    {
                        Colonne1 = u.RG_No,
                        Colonne2 = u.RG_Date,
                        Colonne3 = caissier == null ? "" : caissier.CO_Nom + " " + caissier.CO_Prenom,
                        Colonne4 = vendeur == null ? "" : vendeur.CO_Nom + " " + vendeur.CO_Prenom,
                        Colonne5 = u.RG_Montant,
                        Colonne6 = u.RG_Libelle
                    };
                }
                ).ToList();
                situation = total + fond;
                Total.Text = total+"";
                Fond.Text = fond+"";
                Situation.Text = situation+"";
                label1.Text = "Fond de caisse initial";
                label2.Text = "Total mouvements";
                label3.Text = "Situation de caisse";

                tableMouvement.DataSource = tableau;
                tableMouvement.Columns["Colonne1"].HeaderText = "N° règlement ";
                tableMouvement.Columns["Colonne2"].HeaderText = "Date règlement ";
                tableMouvement.Columns["Colonne3"].HeaderText = "Caissier ";
                tableMouvement.Columns["Colonne4"].HeaderText = "Vendeur ";
                tableMouvement.Columns["Colonne5"].HeaderText = "Montant règlement ";
                tableMouvement.Columns["Colonne6"].HeaderText = "Libellé ";
            }
            else if(menu=="details")
            {
                decimal sommeHT = 0;
                decimal sommeTaxe = 0;
                decimal sommeTTC = 0;
                _context.F_DOCENTETE.Where(u => u.CA_No == value ).ToList().ForEach(u => sommeHT += u.DO_TotalHT.Value);
                sommeTaxe = 0.2m * sommeHT;
                var tableau = _context.F_DOCLIGNE.Join(_context.F_DOCENTETE,post=>post.DO_Piece,meta=>meta.DO_Piece, (post, meta) => new { Post = post, Meta = meta }).Where(u => u.Meta.CA_No==value && u.Post.DO_Piece==u.Meta.DO_Piece).ToList().Select(u =>
                {
                    var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.Meta.CO_NoCaissier && a.CO_Vendeur == 1);
                    var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.Meta.CO_No && a.CO_Caissier == 1);
                    var article = _context.F_ARTICLE.FirstOrDefault(a => a.AR_Ref == u.Post.AR_Ref);

                    return new
                    {
                        Colonne1 = u.Post.cbMarq,
                        Colonne2 = u.Post.DO_Date,
                        Colonne3 = caissier == null ? "" : caissier.CO_Nom + " " + caissier.CO_Prenom,
                        Colonne4 = vendeur == null ? "" : vendeur.CO_Nom + " " + vendeur.CO_Prenom,
                        Colonne5 = article == null ? "":article.AR_Ref,
                        Colonne6 = article == null ? "":article.AR_Design,
                        Colonne7 = u.Post.DL_Qte,
                        Colonne8 = u.Post.DL_PUTTC,
                        Colonne9 = u.Post.DL_MontantTTC,
                        Colonne10 = u.Post.DL_Remise01REM_Valeur
                    };
                }
                ).ToList();
                sommeTTC = sommeHT + sommeTaxe;
                Total.Text = sommeTaxe + "";
                Fond.Text = sommeHT + "";
                Situation.Text = sommeTTC + "";
                label1.Text = "Chiffre d'affaire HT";
                label2.Text = "Total taxes";
                label3.Text = "Chiffre d'affaire TTC";
                tableMouvement.DataSource = tableau; 
                tableMouvement.Columns["Colonne1"].HeaderText = "N° pièce ";
                tableMouvement.Columns["Colonne2"].HeaderText = "Date ";
                tableMouvement.Columns["Colonne3"].HeaderText = "Caissier ";
                tableMouvement.Columns["Colonne4"].HeaderText = "Vendeur ";
                tableMouvement.Columns["Colonne5"].HeaderText = "Référence article ";
                tableMouvement.Columns["Colonne6"].HeaderText = "Désignation article ";
                tableMouvement.Columns["Colonne7"].HeaderText = "Quantité ";
                tableMouvement.Columns["Colonne8"].HeaderText = "Prix unitaire TTC ";
                tableMouvement.Columns["Colonne9"].HeaderText = "Montant TTC ";
                tableMouvement.Columns["Colonne10"].HeaderText = "Remise ";
                
            }
            else
            {
                var tableau = _context.F_TICKETARCHIVE.Where(u => u.CA_No == value).ToList().Select(u =>
                {
                    var caisse = _context.F_DOCENTETE.FirstOrDefault(i => i.DO_Piece == u.DO_Piece);
                    var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == caisse.CO_NoCaissier && a.CO_Vendeur == 1);
                    var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == caisse.CO_No && a.CO_Caissier == 1);
                    return new
                    {
                        Colonne1 = u.cbMarq,
                        Colonne2 = u.TA_Date,
                        Colonne3 = u.TA_Heure,
                        Colonne4 = caissier == null ? "" : caissier.CO_Nom + " " + caissier.CO_Prenom,
                        Colonne5 = vendeur == null ? "" : vendeur.CO_Nom + " " + vendeur.CO_Prenom,
                        Colonne6 = caisse.DO_TotalHT
                    };
                }
                                ).ToList();
                tableMouvement.DataSource = tableau;
                tableMouvement.Columns["Colonne1"].HeaderText = "N° ticket ";
                tableMouvement.Columns["Colonne2"].HeaderText = "Date ";
                tableMouvement.Columns["Colonne3"].HeaderText = "Heure ";
                tableMouvement.Columns["Colonne4"].HeaderText = "Caissier ";
                tableMouvement.Columns["Colonne5"].HeaderText = "Vendeur ";
                tableMouvement.Columns["Colonne6"].HeaderText = "Montant TTC ";
            }
        }

        private void tableMouvement_Paint(object sender, PaintEventArgs e)
        {
                if (tableMouvement.Rows.Count == 0)
                    TextRenderer.DrawText(e.Graphics, "No records found.",
                        tableMouvement.Font, tableMouvement.ClientRectangle,
                        tableMouvement.ForeColor, tableMouvement.BackgroundColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
