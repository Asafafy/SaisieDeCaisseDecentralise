using ComponentFactory.Krypton.Toolkit;
using SoftCaisse.DTO;
using SoftCaisse.Models;
using SoftCaisse.Utils.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCaisse.Forms.MouvementCaisse
{
    public partial class MouvementCaisseForm : KryptonForm
    {
        private readonly AppDbContext _context;
        public MouvementCaisseForm()
        {
            label2.Text =CaisseOuvert.CaisseText;
            _context = new AppDbContext();
            InitializeComponent();
        }

        private void enregistrement_mouvement(object sender, EventArgs e)
        {
            int typereg = type_mouvement.SelectedText == "Entrée" ? 5 : 4;
            string query = @"
                Insert INTO [dbo].[F_CREGLEMENT](
                    [RG_Date],
                    [RG_Montant],
                    [N_Reglement],
                    [RG_Impute],
                    [RG_Libelle],
                    [RG_MontantDev],
                    [RG_Reference] ,
                    [RG_Compta],
                    [EC_No],
                    [RG_Type],
                    [RG_Cours],
                    [RG_TypeReg],
                    [N_Devise],
                    [JO_Num],
                    [RG_Impaye],
                    [RG_Heure],
                    [RG_Piece],
                    [CA_No],
                    [cbCA_No],
                    [CO_NoCaissier],
                    [RG_Banque],
                    [RG_Transfere],
                    [RG_Cloture],
                    [RG_Ticket],
                    [RG_Souche],
                    [RG_DateEchCont],
                    [RG_MontantEcart],
                    [RG_NoBonAchat],
                    [RG_Valide],
                    [RG_Anterieur],
                    [RG_MontantCommission],
                    [RG_MontantNet],
                    [cbProt],
                    [cbModification],
                    [cbReplication],
                    [cbFlag],
                    [cbCreation],
                    [cbHashVersion],
                    [cbHashDate]
                )
                values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},
                {23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38})
                ";
            _context.Database.ExecuteSqlCommand(query,
                kryptonDateTimePicker1.Value,
                Decimal.Parse(montant_mouvement.Text),
                3,
                0,
                commentaire_mouvement.Text,
                0,
                "",
                0,
                0,
                2,
                0,
                typereg,
                0,
                "CAIS",
                new DateTime(1753, 1, 1),
                "000" + DateTime.Now.ToString("HH:mm:ss").Replace(":", ""),
                "",
                CaisseOuvert.CaisseID,
                CaisseOuvert.CaisseID,
                0,
                0,
                0,
                0,
                1,
                0,
                new DateTime(1753, 1, 1),
                0,
                0,
                1,
                0,
                0,
                0,
                0,
                DateTime.Now,
                0,
                0,
                DateTime.Now,
                1,
                DateTime.Now
            );
            this.Close();
            
             
             
        }
    }
}
