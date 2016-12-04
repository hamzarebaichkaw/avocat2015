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
    public partial class FormJuridiqueListeForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.FormeJuridique objetcourant
        {
            get { return (avocat2015.DATA.baavocat.FormeJuridique)this.FormeJuridiquebindingSource.Current; }
        }
        public FormJuridiqueListeForm()
        {
            InitializeComponent();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.FormeJuridique aobject;
            FormeJuridiqueEditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new FormeJuridiqueEditForm(aobject); 
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.FormeJuridiquexpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void AjoutsimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.FormeJuridique aobject;
            FormeJuridiqueEditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.FormeJuridique(DevExpress.Xpo.Session.DefaultSession);
                editform = new FormeJuridiqueEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.FormeJuridiquexpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void supprimersimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.FormeJuridique aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce Forme juridique?", "FormeJuridique", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.FormeJuridiquexpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }

        private void SortirsimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.FormeJuridique aobject;
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