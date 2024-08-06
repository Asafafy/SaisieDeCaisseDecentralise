using Objets100cLib;
using SoftCaisse.DTO;
using SoftCaisse.Forms.Article;
using SoftCaisse.Forms.ConnexBase;
using SoftCaisse.Forms.ControlCaisse;
using SoftCaisse.Forms.FondCaisse;
using SoftCaisse.Forms.FormCaisse;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftCaisse
{
    internal static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string serveurFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurCfg.txt");
            string sageFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ServeurSage.txt");
            string sageFileObj = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ObjSage.txt");


            if (File.Exists(serveurFilePath) && File.Exists(sageFilePath) && File.Exists(sageFileObj))
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("La base de donnée n'est pas encore configurée");
                Application.Run(new ConnectDbForm());
            }
            //BSCPTAApplication100c baseCpt = new BSCPTAApplication100c();
            //baseCpt.Name = "C:\\Users\\Public\\Documents\\Sage\\Entreprise 100c\\BIJOU.MAE";
            //baseCpt.Loggable.UserName = "<Administrateur>";
            //baseCpt.Loggable.UserPwd = "";
            //baseCpt.Open();
            //BSCIALApplication100c baseCial = new BSCIALApplication100c();
            //baseCial.Name = "C:\\Users\\Public\\Documents\\Sage\\Entreprise 100c\\Bijou.gcm";
            //baseCial.Loggable.UserName = "<Administrateur>";
            //baseCial.Loggable.UserPwd = "";
            //baseCial.Open();
            //IBODocumentVente3 mDoc = baseCial.FactoryDocumentVente.ReadPiece(DocumentType.DocumentTypeVenteFacture, "TK000055");
            //IBOTiersPart3 client = mDoc.TiersPayeur;
            //IBODocumentReglement iReglt = (IBODocumentReglement)baseCial.FactoryDocumentReglement.Create();
            //iReglt.TiersPayeur = client;
            //iReglt.RG_Date = DateTime.Now;
            //iReglt.RG_Libelle = "Exemple";
            //iReglt.RG_Montant = 2000;
            //iReglt.Devise = baseCpt.FactoryDevise.ReadIntitule("Euro");
            //iReglt.Reglement = baseCpt.FactoryReglement.ReadIntitule("Chèque");
            //iReglt.Journal = baseCpt.FactoryJournal.ReadNumero("CAIS");
            //iReglt.CompteG = client.CompteGPrinc;
            //iReglt.WriteDefault();
            //baseCial.Close();
            //baseCpt.Close();
            //MessageBox.Show("METY BE!");
        }
    }
}
