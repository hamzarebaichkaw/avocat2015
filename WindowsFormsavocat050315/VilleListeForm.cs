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
    public partial class VilleListeForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Ville objetcourant
        {
            get { return (avocat2015.DATA.baavocat.Ville)this.VilleBindingSource.Current; }
        }
        public VilleListeForm()
        {
            InitializeComponent();
        }

        private void simpleButtonModifier_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Ville aobject;
            VilleEditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new VilleEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.VilleListeXpCollection.Reload();
            }
            catch ( Exception ex)
            {}

        }

        private void simpleButtonAjouter_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Ville aobject;
            VilleEditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Ville(DevExpress.Xpo.Session.DefaultSession);
                editform = new VilleEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.VilleListeXpCollection.Reload();

            }
            catch (Exception ex)
            {

            }

        }

        private void simpleButtonSupprimer_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Ville aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce user?", "user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.VilleListeXpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }
    }
}