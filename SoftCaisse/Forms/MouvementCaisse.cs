using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.CustomModel;
using SoftCaisse.Forms.FormCaisse;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms.GestionCaisse
{
    public partial class MouvementCaisse : KryptonForm
    {
        private readonly AppDbContext _context;
        private readonly F_CAISSERepository _fCaisseRepository;
        public string menu { get; set; }

        public MouvementCaisse(string Intitule)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new F_CAISSERepository(_context);
            var data = _fCaisseRepository.GetAll();
            listeCaisse.DataSource = data;
            listeCaisse.DisplayMember = "CA_Intitule";
            listeCaisse.ValueMember = "CA_No";
            menu = "mouvement";
            Ticket.Hide();

        }

        private void document_state(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "document";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();
            Ticket.Show();

        }

        private void details_click(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "details";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();
            Ticket.Hide();

        }

        private void ticket_archive(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "ticketArchive";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();
            Ticket.Hide();

        }

        private void mouvement_click(object sender, EventArgs e)
        {
            Total.Text = "";
            Fond.Text = "";
            Situation.Text = "";
            menu = "mouvement";
            tableMouvement.DataSource = null;
            tableMouvement.Refresh();
            Ticket.Hide();

        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(listeCaisse.SelectedValue.ToString());
            if (menu == "document")
            {
                decimal? sommeHT = 0;
                decimal? sommeTaxe = 0;
                decimal? sommeTTC = 0;
                tableMouvement.DataSource = _context.F_DOCENTETE.Where(u => u.CA_No == value).ToList().Select(u =>
                {

                    var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.CO_NoCaissier && a.CO_Vendeur == 1);
                    var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.CO_No && a.CO_Caissier == 1);

                    sommeTTC += u.DO_TotalTTC;
                    sommeHT += u.DO_TotalHTNet;
                    return new
                    {
                        Colonne1 = u.DO_Piece,
                        Colonne2 = u.DO_Date,
                        Colonne3 = caissier == null ? "" : caissier.CO_Nom + " " + caissier.CO_Prenom,
                        Colonne4 = vendeur == null ? "" : vendeur.CO_Nom + " " + vendeur.CO_Prenom,
                        Colonne5 = u.DO_TotalTTC

                    };

                }
                ).ToList();
                sommeTaxe = sommeTTC - sommeHT;
                Fond.Text = sommeHT + "";
                Total.Text = sommeTaxe + "";
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
            else if (menu == "mouvement")
            {
                decimal fond = 0;
                _context.F_CREGLEMENT.Where(u => u.CA_No == value && u.RG_TypeReg == 2 && u.RG_Montant != null).ToList().ForEach(u => fond += u.RG_Montant.Value);
                decimal total = 0;
                decimal situation = 0;
                var caisse = _context.F_CAISSE.FirstOrDefault(a => a.CA_No.Value == value);

                var tableau = _context.F_CREGLEMENT.Where(u => u.CA_No == value && u.RG_TypeReg != 6).ToList().Select(u =>
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
                Total.Text = total + "";
                Fond.Text = fond + "";
                Situation.Text = situation + "";
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
            else if (menu == "details")
            {
                decimal sommeHT = 0;
                decimal sommeTaxe = 0;
                decimal sommeTTC = 0;
                _context.F_DOCENTETE.Where(u => u.CA_No == value).ToList().ForEach(u => sommeHT += u.DO_TotalHT.Value);
                var tableau = _context.F_DOCLIGNE.Join(_context.F_DOCENTETE, post => post.DO_Piece, meta => meta.DO_Piece, (post, meta) => new { Post = post, Meta = meta }).Where(u => u.Meta.CA_No == value && u.Post.DO_Piece == u.Meta.DO_Piece).ToList().Select(u =>
                {
                    var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.Meta.CO_NoCaissier && a.CO_Vendeur == 1);
                    var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No.Value == u.Meta.CO_No && a.CO_Caissier == 1);
                    var article = _context.F_ARTICLE.FirstOrDefault(a => a.AR_Ref == u.Post.AR_Ref);
                    sommeTTC += u.Post.DL_MontantTTC.Value;
                    sommeHT += u.Post.DL_MontantHT.Value;
                    return new
                    {
                        Colonne1 = u.Post.DO_Piece,
                        Colonne2 = u.Post.DO_Date,
                        Colonne3 = caissier == null ? "" : caissier.CO_Nom + " " + caissier.CO_Prenom,
                        Colonne4 = vendeur == null ? "" : vendeur.CO_Nom + " " + vendeur.CO_Prenom,
                        Colonne5 = article == null ? "" : article.AR_Ref,
                        Colonne6 = article == null ? "" : article.AR_Design,
                        Colonne7 = u.Post.DL_Qte,
                        Colonne8 = u.Post.DL_PUTTC,
                        Colonne9 = u.Post.DL_MontantTTC,
                        Colonne10 = u.Post.DL_Remise01REM_Valeur
                    };
                }
                ).ToList();
                sommeTaxe = sommeTTC - sommeHT;
                Total.Text = sommeTaxe + "";
                Fond.Text = sommeHT + "";
                Situation.Text = sommeTTC + "";
                label1.Text = "Chiffre d'affaire HT";
                label2.Text = "Total taxes";
                label3.Text = "Chiffre d'affaire TTC";
                tableMouvement.DataSource = tableau;
                tableMouvement.Columns["Colonne1"].HeaderText = "N° Document pièce ";
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
                decimal? sommeHT = 0;
                decimal? sommeTaxe = 0;
                decimal? sommeTTC = 0;
                var tableau = _context.F_TICKETARCHIVE.Join(_context.F_DOCENTETE, post => post.DO_Piece, meta => meta.DO_Piece, (post, meta) => new { Meta = meta, Post = post }).Where(u => u.Post.CA_No == value).ToList().Select(u =>
                {
                    var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No == u.Meta.CO_NoCaissier && a.CO_Vendeur == 1);
                    var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a => a.CO_No == u.Meta.CO_No && a.CO_Caissier == 1);
                    sommeTTC += u.Meta.DO_TotalTTC;
                    sommeHT += u.Meta.DO_TotalHT.Value;
                    return new
                    {
                        Colonne1 = u.Post.DO_Piece,
                        Colonne2 = u.Post.TA_Date,
                        Colonne3 = u.Post.TA_Heure,
                        Colonne4 = caissier == null ? "" : caissier.CO_Nom + " " + caissier.CO_Prenom,
                        Colonne5 = vendeur == null ? "" : vendeur.CO_Nom + " " + vendeur.CO_Prenom,
                        Colonne6 = u.Meta.DO_TotalTTC
                    };
                }
                ).ToList();
                sommeTaxe = sommeTTC - sommeHT;
                Total.Text = sommeTaxe + "";
                Fond.Text = sommeHT + "";
                Situation.Text = sommeTTC + "";
                label1.Text = "Chiffre d'affaire HT";
                label2.Text = "Total taxes";
                label3.Text = "Chiffre d'affaire TTC";
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

        private void Ticket_Click(object sender, EventArgs e)
        {
            if (tableMouvement.SelectedCells != null)
            {
                string valeur = tableMouvement.CurrentRow.Cells[0].FormattedValue.ToString();
                var entete = _context.F_DOCENTETE.FirstOrDefault(u => u.DO_Piece == valeur);
                var ligne = _context.F_DOCLIGNE.Where(u => u.DO_Piece == valeur).ToList();
                var reglement = _context.F_CREGLEMENT.Where(u => u.RG_Libelle.Contains(valeur)).ToList();
                var caisse = _context.F_CAISSE.FirstOrDefault(u => u.cbMarq == entete.CA_No);
                string typedoc = entete.DO_Type == 30 ? "Ticket" : "Facture";
                Fentete fentete = new Fentete()
                {
                    caisse = caisse.CA_Intitule,
                    date = entete.DO_Date.Value.ToShortDateString(),
                    numero = entete.DO_Piece,
                    type = typedoc
                };
                List<Fligne> fligne = new List<Fligne>();
                List<Freglement> freglements = new List<Freglement>();
                foreach (var f in ligne)
                {
                    fligne.Add(new Fligne()
                    {
                        date = f.DO_Date.Value.ToShortDateString(),
                        designation = f.DL_Design,
                        montant_ht = (double)f.DL_MontantHT.Value,
                        prix_unitaire = (double)f.DL_PrixUnitaire.Value,
                        quantite = (double)f.DL_Qte.Value,
                        reference = f.AR_Ref
                    });
                }
                string devis = _context.P_DEVISE.FirstOrDefault(u => u.cbMarq == entete.DO_Devise).D_Intitule;
                foreach (var f in reglement)
                {
                    string regl = _context.P_REGLEMENT.FirstOrDefault(u => u.cbMarq == f.N_Reglement).R_Intitule;
                    freglements.Add(new Freglement()
                    {
                        Date = f.RG_Date.Value.ToShortDateString(),
                        Type = regl,
                        Montant = (double)f.RG_Montant.Value
                    });
                }
                Reporting reporting = new Reporting(fentete, fligne, freglements, devis);
                reporting.Show();
            }
        }
    }
}
