using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.Forms.FondCaisse;
using SoftCaisse.Forms.VenteComptoir;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Utils;
using SoftCaisse.Utils.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SoftCaisse.Forms.OuvertureCaisse
{
    public partial class OuvertureCaisseForm : KryptonForm
    {
        private MainForm mainForm;
        private List<dynamic> _caisse = new List<dynamic>();
        private List<dynamic> _collabo = new List<dynamic>();
        private readonly AppDbContext _context;
        private readonly SCDContext _sCDContext;
        private F_CAISSERepository _fCaisseRepository;
        private readonly F_COLLABORATEURRepository _fCollaborateurRepository;
        private int IdCaisse;
        private int IdCaissier;
        private ToolStripMenuItem _menu;
        public OuvertureCaisseForm(ToolStripMenuItem menu, MainForm form)
        {
            InitializeComponent();

            mainForm = form;

            OuvertureCaisseCmbx.KeyDown += (sender, e) => EventHandlers.KeyDownEnterHandler(sender, e, btnOuvertureCaisse_Click);
            OuvertureCaissierCmbx.KeyDown += (sender, e) => EventHandlers.KeyDownEnterHandler(sender, e, btnOuvertureCaisse_Click);
            txtOuvertureCaissePwd.KeyDown += (sender, e) => EventHandlers.KeyDownEnterHandler(sender, e, btnOuvertureCaisse_Click);
            FondCaisseType.KeyDown += (sender, e) => EventHandlers.KeyDownEnterHandler(sender, e, btnOuvertureCaisse_Click);

            _context = new AppDbContext();
            _sCDContext = new SCDContext();
            _fCaisseRepository = new F_CAISSERepository(_context);
            _fCollaborateurRepository = new F_COLLABORATEURRepository(_context);
            var _caisse = _fCaisseRepository.GetAll();
            var _collabo = _fCollaborateurRepository.GetAll();
            var listCaisse = _caisse.Select(c => new Controle() { valeur = c.CA_No + "", item = c.CA_Intitule }).ToArray();
            var listCollabo = _collabo.Where(u => u.CO_Caissier == 1).Select(c => new Controle() { valeur = c.CO_No + "", item = c.CO_Nom.ToString() + " " + c.CO_Prenom }).ToArray();
            OuvertureCaisseCmbx.DataSource = listCaisse;
            OuvertureCaissierCmbx.DataSource = listCollabo;
            OuvertureCaisseCmbx.DisplayMember = "item";
            OuvertureCaisseCmbx.ValueMember = "valeur";
            OuvertureCaissierCmbx.DisplayMember = "item";
            OuvertureCaissierCmbx.ValueMember = "valeur";
            FondCaisseType.SelectedIndex = 0;
            _menu = menu;
        }

        private void btnOuvrCaisseClose_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            Parent = null;
        }
        public void LoadData()
        {
            txtOuvertureCaissePwd.Select();
        }


        private void btnOuvertureCaisse_Click(object sender, EventArgs e)
        {
            int caisse = 0;
            int caissier = 0;
            int.TryParse(OuvertureCaisseCmbx.SelectedValue.ToString(), out caisse);
            int.TryParse(OuvertureCaissierCmbx.SelectedValue.ToString(), out caissier);
            F_CAISSE caisses = _context.F_CAISSE.FirstOrDefault(u => u.CA_No == caisse);
            F_COLLABORATEUR obj = _context.F_COLLABORATEUR.FirstOrDefault(u => u.CO_No == caissier);
            CaisseOuvert.CaisseID = OuvertureCaisseCmbx.SelectedValue.ToString();
            CaisseOuvert.CaisseText = caisses.CA_Intitule;
            CaisseOuvert.CaissierID = OuvertureCaissierCmbx.SelectedValue.ToString();
            CaisseOuvert.CaissierText = obj.CO_Nom + " " + obj.CO_Prenom;
            string motDePasseUser = txtOuvertureCaissePwd.Text;
            Collaborateur collab = (from c in _sCDContext.Collaborateur
                                    where c.Nom_Collab.Equals(obj.CO_Nom) && c.Prenoms_Collab.Equals(obj.CO_Prenom)
                                    select c).FirstOrDefault();
            Users user = (from u in _sCDContext.Users
                          where u.UserId == collab.UserId && u.UserPassword == motDePasseUser
                          select u).FirstOrDefault();
            if (user != null)
            {
                if (fondCaisseCbox.Checked)
                {
                    Close();
                    if (FondCaisseType.SelectedIndex == 1)
                    {
                        FondCaisseBilletageForm fondCaisseForm = new FondCaisseBilletageForm(caisse, caissier);
                        fondCaisseForm.Show();
                    }
                    else
                    {
                        FondCaisseDevisForm fondcaissedevisform = new FondCaisseDevisForm(caisse, caissier);
                        fondcaissedevisform.Show();
                    }
                }
                else
                {
                    Close();
                    VenteComptoirForm venteComptoir = new VenteComptoirForm(caisse, caissier, null, null);
                    venteComptoir.Show();
                }
                _menu.DropDownItems["ouvertureDeCaisseToolStripMenuItem"].Enabled = false;
                _menu.DropDownItems["ventesComptoirToolStripMenuItem"].Enabled = true;
                _menu.DropDownItems["mouvementsToolStripMenuItem"].Enabled = true;
                _menu.DropDownItems["dOToolStripMenuItem"].Enabled = true;
                _menu.DropDownItems["fermetureDeCaisseToolStripMenuItem"].Enabled = true;

                mainForm.CaisseNo = OuvertureCaisseCmbx.SelectedIndex + 1;
                mainForm.CaissierCollabNo = OuvertureCaissierCmbx.SelectedIndex + 1;
            }
            else
            {
                MessageBox.Show("Erreur Pseudo/Mot de passe !", "Erreur Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void OuvertureCaisseCmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            Controle val = (Controle)OuvertureCaisseCmbx.SelectedItem;
            F_CAISSE caisse = _context.F_CAISSE.FirstOrDefault(u => u.CA_No + "" == val.valeur);
            if (caisse.CO_No != 0)
            {
                F_COLLABORATEUR collabo = _context.F_COLLABORATEUR.FirstOrDefault(u => u.CO_No == caisse.CO_NoCaissier);
                OuvertureCaissierCmbx.SelectedIndex = OuvertureCaissierCmbx.FindString(collabo.CO_Nom + " " + collabo.CO_Prenom);
            }
        }

        private void fondCaisseCbox_CheckedChanged(object sender, EventArgs e)
        {
            if (fondCaisseCbox.Checked)
            {
                FondCaisseType.Enabled = true;
            }
            else
            {
                FondCaisseType.Enabled = false;
            }
        }
    }
}
