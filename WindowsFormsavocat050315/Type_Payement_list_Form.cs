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
    public partial class Type_Payement_list_Form : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Type_Payement objectcourant
        {
            get { return (avocat2015.DATA.baavocat.Type_Payement)this.Type_PayementBindingSource.Current; }
        }
        public Type_Payement_list_Form()
        {
            InitializeComponent();
        }

        private void Type_Payement_list_Form_Load(object sender, EventArgs e)
        {

        }

        private void ModifierSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Type_Payement aobject;
          Type_Payement_edit_Form editform;
            DialogResult dr;
            try
            {
                aobject = this.objectcourant;
                editform = new Type_Payement_edit_Form(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.Type_PayementXpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void AjouterSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Type_Payement aobject;
            Type_Payement_edit_Form editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Type_Payement(DevExpress.Xpo.Session.DefaultSession);
                editform = new Type_Payement_edit_Form(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.Type_PayementXpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void SupprimersimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Type_Payement aobject;
            DialogResult dr;
            try
            {

                aobject = this.objectcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ?", "user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.Type_PayementXpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {

            avocat2015.DATA.baavocat.Type_Payement aobject;
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