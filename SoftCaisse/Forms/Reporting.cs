using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using Objets100cLib;
using SoftCaisse.CustomModel;
using SoftCaisse.DTO;
using SoftCaisse.Models;
using SoftCaisse.Repositories;
using SoftCaisse.Repositories.BIJOU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoftCaisse.Forms.FormCaisse
{
    public partial class Reporting : Form
    {
        public bool UserHasPrinted { get; private set; } = false;


        // ===================================================================================================
        // DEBUT TICKET DE CAISSE ============================================================================
        public Reporting(Fentete fentete, List<Fligne> Fligne, List<Freglement> Freglement, string devi)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.ModelesDocuments.TicketCaisse.rdlc";
            double montant = Fligne.Sum(u => u.montant_ht);
            double rendu = Freglement.Sum(u => u.Montant) - montant;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Caisse", fentete.caisse));
            reportParameters.Add(new ReportParameter("Type", fentete.type));
            reportParameters.Add(new ReportParameter("Date", fentete.date));
            reportParameters.Add(new ReportParameter("Numero", fentete.numero));
            reportParameters.Add(new ReportParameter("TotalHT", montant.ToString("0.##")));
            reportParameters.Add(new ReportParameter("Taux", "20%"));
            reportParameters.Add(new ReportParameter("Taxe", (montant * 0.2).ToString("0.##")));
            reportParameters.Add(new ReportParameter("Acompte", " "));
            reportParameters.Add(new ReportParameter("TotalTTC", (montant * 1.2).ToString("0.##")));
            reportParameters.Add(new ReportParameter("Rendu", (rendu).ToString("0.##")));
            reportParameters.Add(new ReportParameter("Devis", devi));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            ReportDataSource reports2 = new ReportDataSource("DataSet1", Fligne);
            ReportDataSource reports3 = new ReportDataSource("DataSet3", Freglement);
            this.reportViewer1.LocalReport.DataSources.Add(reports2);
            this.reportViewer1.LocalReport.DataSources.Add(reports3);
        }
        // FIN TICKET DE CAISSE ============================================================================
        // =================================================================================================




        // =================================================================================================
        // DEBUT CLOTURE FACTURE ===========================================================================
        public Reporting(List<Freglement> reglement)
        {
            InitializeComponent();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.ModelesDocuments.ClotureFacture.rdlc";

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            double somme = reglement.Sum(u => u.Montant);
            reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            ReportDataSource reports2 = new ReportDataSource("DataSet1", reglement);
            this.reportViewer1.LocalReport.DataSources.Add(reports2);
        }
        // FIN CLOTURE FACTURE =============================================================================
        // =================================================================================================




        // =================================================================================================
        // DEBUT STATISTIQUE CAISSE ========================================================================
        public Reporting(DateTime debut, DateTime fin, IEnumerable<Fstatistique> statistique, StatType type)
        {
            InitializeComponent();
            if (type == StatType.ParArticle)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.ModelesDocuments.StatistiqueCaisseArticle.rdlc";
                
                double somme = statistique.Sum(u => u.CANet);

                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("Debut", debut.ToShortDateString()));
                reportParameters.Add(new ReportParameter("Fin", fin.ToShortDateString()));
                reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);

                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", statistique);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            if (type == StatType.ParFamille)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.ModelesDocuments.StatistiqueCaisseFamille.rdlc";
                
                double somme = statistique.Sum(u => u.CANet);

                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("Debut", debut.ToShortDateString()));
                reportParameters.Add(new ReportParameter("Fin", fin.ToShortDateString()));
                reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);

                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", statistique);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
        }
        // FIN STATISTIQUE CAISSE ==========================================================================
        // =================================================================================================




        // =================================================================================================
        // DEBUT STATISTIQUE CAISSE ========================================================================
        public Reporting(DateTime debut, DateTime fin, IEnumerable<Freglement> statistique)
        {
            InitializeComponent();

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.ModelesDocuments.StatistiqueCaisseReglement.rdlc";
            
            double somme = statistique.Sum(u => u.Montant);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Debut", debut.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Fin", fin.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", statistique);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }
        // FIN STATISTIQUE CAISSE ==========================================================================
        // =================================================================================================





        // ==================================================================================================
        // DEBUT DOCUMENTS DE VENTE =========================================================================
        public Reporting(string typeDocumentDeVente, string caisse, DateTime date, string numero, string devise, decimal TotalHT, decimal TotalTTC, List<Fligne> Fligne, List<ListeEcheancesPourImpressionDocumentsDeVente> listeEcheances)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.ModelesDocuments.DocumentDeVente.rdlc";

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("DocumentDeVente", typeDocumentDeVente));
            reportParameters.Add(new ReportParameter("Caisse", caisse));
            reportParameters.Add(new ReportParameter("Date", date.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Numero", numero));
            reportParameters.Add(new ReportParameter("Devise", devise));
            reportParameters.Add(new ReportParameter("TotalHT", TotalHT.ToString("0.##")));
            reportParameters.Add(new ReportParameter("TotalTTC", TotalTTC.ToString("0.##")));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            ReportDataSource reports2 = new ReportDataSource("DataSet1", Fligne);
            ReportDataSource reports3 = new ReportDataSource("DataSet2", listeEcheances);
            this.reportViewer1.LocalReport.DataSources.Add(reports2);
            this.reportViewer1.LocalReport.DataSources.Add(reports3);

            this.reportViewer1.PrintingBegin += ReportViewer1_PrintingBegin;
        }
        // FIN DOCUMENTS DE VENTE ==========================================================================
        // =================================================================================================
        



        private async void ReportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            UserHasPrinted = true;
            if (UserHasPrinted)
            {
                await Task.Delay(5000);
                this.Close();
            }
        }



        private void Reporting_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
