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
    public partial class Conseil_JuridiqueListForm : Form
    {
        private avocat2015.DATA.baavocat.Conseil_Juridique objetcourant
        {
            get { return (avocat2015.DATA.baavocat.Conseil_Juridique)this.Conseil_JuridiquebindingSource.Current; }
        }
        public Conseil_JuridiqueListForm()
        {
            InitializeComponent();
        }

        private void simpleButtonModifier_Click(object sender, EventArgs e)
        {
             avocat2015.DATA.baavocat.Conseil_Juridique aobject;
            Conseil_Juridique_EditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new Conseil_Juridique_EditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.Conseil_JuridiquexpCollection.Reload();
            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButtonAjouter_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Conseil_Juridique aobject;
            Conseil_Juridique_EditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Conseil_Juridique(DevExpress.Xpo.Session.DefaultSession);
                editform = new Conseil_Juridique_EditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.Conseil_JuridiquexpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButtonAnnuler_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Conseil_Juridique aobject;
            try
            {
                aobject = this.objetcourant;
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButtonSupprimer_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Conseil_Juridique aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce   ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.Conseil_JuridiquexpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }
    }
}
