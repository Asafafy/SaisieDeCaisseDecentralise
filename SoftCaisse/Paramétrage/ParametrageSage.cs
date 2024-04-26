using Objets100cLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCaisse.Paramétrage
{
    public class ParametrageSage
    {
        BSCIALApplication100c baseCial = null;
        public string pathCpt = "C:\\Users\\Public\\Documents\\Sage\\Saisie de caisse décentralisée 100c\\Bijou.gcm";
        public ParametrageSage(string cheminCompta, string cheminCial, string utilisateur, string mdp)
        {
            this.initBaseSage(cheminCompta, cheminCial, utilisateur, mdp);
        }
        private void initBaseSage(string cheminCompta, string cheminCial, string utilisateur, string mdp)
        {
            baseCial = new BSCIALApplication100c();
            baseCial.Name = cheminCial;
            baseCial.Loggable.UserName = utilisateur;
            baseCial.Loggable.UserPwd = mdp;
        }
        //public bool CreerBLReguleAchatMPMAIS(List<ArticleAchat> listAr, string numDoc)
        //{
        //    bool test = false;
        //    IPMDocument CreeBL = baseCial.CreateProcess_Document(DocumentProvenanceType.DocProvenanceTicket);
        //    IBODocumentAchat3 mDoc = (IBODocumentAchat3)CreeBL.Document;
        //    IBODocumentAchat3 mdocBC = baseCial.FactoryDocumentAchat.ReadPiece(DocumentType.DocumentTypeAchatCommandeConf, numDoc);
        //    IBOFournisseur3 fournis = mdocBC.Fournisseur;
        //    mDoc.DO_Ref = "REGUL " + numDoc;
        //    mDoc.SetDefaultFournisseur(fournis);
        //    foreach (ArticleAchat ar in listAr)
        //    {
        //        IBOArticle3 art = baseCial.FactoryArticle.ReadReference(ar.Ar_ref);
        //        IBODocumentAchatLigne3 mLig = (IBODocumentAchatLigne3)CreeBL.AddArticle(art, -(double)ar.QteLivree);
        //        IBODepot3 depot = baseCial.FactoryDepot.ReadIntitule(ar.Depot);
        //        mLig.Depot = depot;

        //    }
        //    if (CreeBL.CanProcess)
        //    {
        //        try
        //        {
        //            try
        //            {
        //                CreeBL.Process();
        //            }
        //            catch { }
        //            test = true;
        //        }
        //        catch
        //        {
        //            test = false;
        //        }

        //    }
        //    return test;
        //}



        public bool openBaseCial()
        {
            if (baseCial.IsOpen)
            {
                try
                {
                    baseCial.Close();

                }
                catch
                {
                }
            }
            try
            {
                baseCial.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool closeBaseCial()
        {
            bool test = false;
            if (baseCial.IsOpen)
            {
                try
                {
                    baseCial.Close();
                    test = true;
                }
                catch
                {
                    test = false;
                }
            }
            return test;
        }


    }
}
