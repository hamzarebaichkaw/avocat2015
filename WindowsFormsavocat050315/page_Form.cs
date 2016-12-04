using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsavocat050315
{
    public partial class page_Form : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static Form FrmParent;
        public page_Form()
        {
            InitializeComponent();
            FrmParent = this;
             
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            AffaireJurdiqueListForm MyFrm5 = new AffaireJurdiqueListForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Travail_JusticeListForm MyFrm5 = new Travail_JusticeListForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Conseil_JuridiqueListForm MyFrm5 = new Conseil_JuridiqueListForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Travail_Divers_ListForm MyFrm5 = new Travail_Divers_ListForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {

            KathyaAvocatListeForm MyFrm5 = new KathyaAvocatListeForm();
            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            JustusPortListeForm MyFrm5 = new JustusPortListeForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClientListForm MyFrm5 = new ClientListForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            AgendaForm1 MyFrm5 = new AgendaForm1();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {

            Reglement_Avocat_ListeForm MyFrm5 = new Reglement_Avocat_ListeForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {

            Reglement_ClientForm MyFrm5 = new Reglement_ClientForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {

            JalsaListForm1 MyFrm5 = new JalsaListForm1();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {

            JustusListForm MyFrm5 = new JustusListForm();

            MyFrm5.MdiParent = this;
            MyFrm5.Show();
        }
    }
}