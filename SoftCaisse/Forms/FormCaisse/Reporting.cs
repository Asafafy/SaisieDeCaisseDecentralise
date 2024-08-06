using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using SoftCaisse.CustomModel;
using SoftCaisse.DTO;
using SoftCaisse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Reporting(Fentete fentete,List<Fligne> Fligne, List<Freglement> Freglement,string devi)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.TicketCaisse.rdlc";
            double montant = Fligne.Sum(u=>u.montant_ht);
            double rendu = Freglement.Sum(u=>u.Montant) - montant;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Caisse", fentete.caisse));
            reportParameters.Add(new ReportParameter("Type", fentete.type));
            reportParameters.Add(new ReportParameter("Date", fentete.date));
            reportParameters.Add(new ReportParameter("Numero", fentete.numero));
            reportParameters.Add(new ReportParameter("TotalHT", montant.ToString("0.##")));
            reportParameters.Add(new ReportParameter("Taux", "20%"));
            reportParameters.Add(new ReportParameter("Taxe", (montant*0.2).ToString("0.##")));
            reportParameters.Add(new ReportParameter("Acompte", " "));
            reportParameters.Add(new ReportParameter("TotalTTC", (montant*1.2).ToString("0.##")));
            reportParameters.Add(new ReportParameter("Rendu", (rendu).ToString("0.##")));
            reportParameters.Add(new ReportParameter("Devis", devi));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            ReportDataSource reports2= new ReportDataSource("DataSet1", Fligne);
            ReportDataSource reports3= new ReportDataSource("DataSet3", Freglement);
            this.reportViewer1.LocalReport.DataSources.Add(reports2);
            this.reportViewer1.LocalReport.DataSources.Add(reports3);
        }
        public Reporting(List<Freglement> reglement)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.ClotureFacture.rdlc";

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            double somme = reglement.Sum(u => u.Montant);
            reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            ReportDataSource reports2 = new ReportDataSource("DataSet1", reglement);
            this.reportViewer1.LocalReport.DataSources.Add(reports2);
        }
        public Reporting(DateTime debut, DateTime fin, IEnumerable<Fstatistique> statistique, StatType type)
        {
            InitializeComponent();
            if (type == StatType.ParArticle)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.StatistiqueCaisseArticle.rdlc";
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("Debut", debut.ToShortDateString()));
                reportParameters.Add(new ReportParameter("Fin", fin.ToShortDateString()));
                double somme = statistique.Sum(u => u.CANet);
                reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", statistique);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            if (type == StatType.ParFamille)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.StatistiqueCaisseFamille.rdlc";
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("Debut", debut.ToShortDateString()));
                reportParameters.Add(new ReportParameter("Fin", fin.ToShortDateString()));
                double somme = statistique.Sum(u => u.CANet);
                reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                ReportDataSource reportDataSource = new ReportDataSource("DataSet1", statistique);
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
        }
        public Reporting(DateTime debut, DateTime fin, IEnumerable<Freglement> statistique)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SoftCaisse.StatistiqueCaisseReglement.rdlc";
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Debut", debut.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Fin", fin.ToShortDateString()));
            double somme = statistique.Sum(u => u.Montant);
            reportParameters.Add(new ReportParameter("Total", somme.ToString("N2")));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", statistique);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }
        private void Reporting_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
