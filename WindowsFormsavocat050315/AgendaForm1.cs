using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;



namespace WindowsFormsavocat050315
{
    public partial class AgendaForm1 : DevExpress.XtraEditors.XtraForm
    {
        
       
        public AgendaForm1()
        {
            InitializeComponent();
        }

        private void AgendaForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baavocatDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.baavocatDataSet.Resources);
            // TODO: This line of code loads data into the 'baavocatDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.baavocatDataSet.Appointments);

        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(baavocatDataSet);
            baavocatDataSet.AcceptChanges();
        }
        public event CustomDrawObjectEventHandler CustomDrawDayHeader;
        private void schedulerControl1_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e)
        {
            
            // Check whether the current object is a Day Header.
          //  var header = e.ObjectInfo as SchedulerHeader;

          //  if (header != null)
         //   {
          //      var gotIt = Hermes.DisplayDateInArabic.ConvertDateToArabicWithDay(header.Interval.Start.Date);
         //       header.Caption = string.Empty;
         //       header.Caption += String.Format("{0}", gotIt);

         //   }
        }
    }
}