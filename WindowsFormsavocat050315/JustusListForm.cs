using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsavocat050315
{
    public partial class JustusListForm : Form
    {
        private avocat2015.DATA.baavocat.PALAIS_JUSTICE objetcourant
        {
            get { return (avocat2015.DATA.baavocat.PALAIS_JUSTICE)this.bindingSource.Current; }
        }
        public JustusListForm()
        {
            InitializeComponent();
        }

        private void simpleButtonModifier_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.PALAIS_JUSTICE aobject;
            JustusEditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new JustusEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this. xpCollection.Reload();

            }
            catch (Exception ex)
            {

            }

        }

        private void simpleButtonAjouter_Click(object sender, EventArgs e)
        {

            avocat2015.DATA.baavocat.PALAIS_JUSTICE aobject;
            JustusEditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.PALAIS_JUSTICE(DevExpress.Xpo.Session.DefaultSession);
                editform = new JustusEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.xpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButtonSupprimer_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.PALAIS_JUSTICE aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce user?", "user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.xpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButtonAnnuler_Click(object sender, EventArgs e)
        {

            avocat2015.DATA.baavocat.PALAIS_JUSTICE aobject;
            try
            {
                aobject = this.objetcourant;
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
