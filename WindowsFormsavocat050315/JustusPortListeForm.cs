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
    public partial class JustusPortListeForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Justice_Port objetcourant
        {
            get { return (avocat2015.DATA.baavocat.Justice_Port)this.JustusPortBindingSource .Current; }
        }
        public JustusPortListeForm()
        {
            InitializeComponent();
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Justice_Port aobject;
            try
            {
                aobject = this.objetcourant;
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void SupprimerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Justice_Port aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce justice port?", "justice port", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.JustusPortXpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }

        private void ModifierSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Justice_Port aobject;
            JustusPortEditForm  editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new JustusPortEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.JustusPortXpCollection .Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void AjouterSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Justice_Port aobject;
            JustusPortEditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Justice_Port(DevExpress.Xpo.Session.DefaultSession);
                editform = new JustusPortEditForm (aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.JustusPortXpCollection .Reload();

            }
            catch (Exception ex)
            {

            }

        }
    }
}