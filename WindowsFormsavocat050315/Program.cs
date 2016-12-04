using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Collections;
namespace WindowsFormsavocat050315
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
        new System.Globalization.CultureInfo("ar");

            DevExpress.Xpo.XPBaseObject.AutoSaveOnEndEdit = false;
            DevExpress.Xpo.Session.DefaultSession.ConnectionString = @"XpoProvider=MSSqlServer;data source=CHKAW-PC\SQLEXPRESS;user id=sa;password=123;initial catalog=baavocat;Persist Security Info=true";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-tn");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-tn");
            Application.Run(new page_Form());
        }
    }
}
