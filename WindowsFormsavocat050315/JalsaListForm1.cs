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
    public partial class JalsaListForm1 : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Jalsa objetcourant
            {
            get { return (avocat2015.DATA.baavocat.Jalsa)this.JalsaBindingSource .Current; }
            }
        public JalsaListForm1()
        {
            InitializeComponent();
        }

        private void JalsaListForm1_Load(object sender, EventArgs e)
        {

        }

        private void ModifierSimpleButton_Click(object sender, EventArgs e)
        {
             avocat2015.DATA.baavocat.Jalsa aobject;
            JalsaEditForm  editform;
            DialogResult dr;
            try
            {
                aobject = this .objetcourant ;
                editform = new  JalsaEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.JalsaXpCollection .Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Jalsa aobject;
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
            avocat2015.DATA.baavocat.Jalsa aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce jalsa?", "jalsa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.JalsaXpCollection .Reload();


            }
            catch (Exception ex)
            {

            }
        }

        private void AjouterSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Jalsa aobject;
            JalsaEditForm  editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Jalsa(DevExpress.Xpo.Session.DefaultSession);
                editform = new JalsaEditForm (aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.JalsaXpCollection .Reload();

            }
            catch (Exception ex)
            {

            }

        }
        }
    }
