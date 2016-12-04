using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsavocat050315
{
    public partial class affaire_jurdiqueReport : DevExpress.XtraReports.UI.XtraReport
    {
        public affaire_jurdiqueReport()
        {
            InitializeComponent();
        }
        public static void Imprimer(object obj)
        {

            affaire_jurdiqueReport r = new affaire_jurdiqueReport();

            r.bindingSource1.DataSource = r.xpCollection1;
            r.bindingSource1.Add(obj);

            ReportPrintTool printtool = new ReportPrintTool(r);
            printtool.ShowPageSetup();
            printtool.ShowPreviewDialog();
        }
    }
}
