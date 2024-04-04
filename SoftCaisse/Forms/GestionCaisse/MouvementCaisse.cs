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
        private readonly FCReglementRepository _fCReglementRepository;
        private readonly FCollaborateurRepository _fCollaborateurRepository;

        public MouvementCaisse(string Intitule)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _fCaisseRepository = new FCaisseRepository(_context);
            _fCReglementRepository = new FCReglementRepository(_context);
            var data = _fCaisseRepository.GetAll();
            tableMouvement.DataSource = _fCReglementRepository.GetAll().Select(u =>
            {
                var caissier = _context.F_COLLABORATEUR.FirstOrDefault(a=>a.CO_No.Value==u.CA_No);
                var vendeur = _context.F_COLLABORATEUR.FirstOrDefault(a=>a.CO_No.Value==u.cbCA_No);
                return new
                {
                    RG_No = u.RG_No,
                    RG_Date = u.RG_Date,
                    Caissier = caissier.CO_Nom,
                    Vendeur = vendeur.cbCO_Nom,
                    Montant = u.RG_Montant,
                    RG_Libelle = u.RG_Libelle

                };
            }
            ) ;   
            listeCaisse.DataSource =data;
            listeCaisse.DisplayMember = "CA_Intitule";
            listeCaisse.ValueMember = "CA_No";
            listeCaisse.SelectedText = Intitule;
        }

        private void document_state(object sender, EventArgs e)
        {
            //listeCaisse.DataSource = data;
        }
    }
}
