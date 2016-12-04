using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsavocat050315
{
    public partial class Reglement_Avocat_ListeForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Reglement_Avocat objectcourant
        {
            get { return (avocat2015.DATA.baavocat.Reglement_Avocat)this.Reglement_AvocatBindingSource.Current; }
        }
        public Reglement_Avocat_ListeForm()
        {
            InitializeComponent();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Reglement_Avocat aobject;
            Reglement_Avocat_EditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objectcourant;
                editform = new Reglement_Avocat_EditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.Reglement_avocatXpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Reglement_Avocat aobject;
            Reglement_Avocat_EditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Reglement_Avocat(DevExpress.Xpo.Session.DefaultSession);
                editform = new Reglement_Avocat_EditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.Reglement_avocatXpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Reglement_Avocat aobject;
            DialogResult dr;
            try
            {

                aobject = this.objectcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce user?", "user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.Reglement_avocatXpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            avocat2015.DATA.baavocat.Reglement_Avocat aobject;
            try
            {
                aobject = this.objectcourant;
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}