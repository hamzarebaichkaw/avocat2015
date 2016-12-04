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
    public partial class Travail_JusticeListForm : Form
    {

        private avocat2015.DATA.baavocat.Travail_Justice objetcourant
        {
            get { return (avocat2015.DATA.baavocat.Travail_Justice)this.bindingSource1.Current; }
        }
        public Travail_JusticeListForm()
        {
            InitializeComponent();
        }

        private void ModifierSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Travail_Justice aobject;
            Travail_JusticeEditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new Travail_JusticeEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.xpCollection1.Reload();

            }
            catch (Exception ex)
            {

            }

        }

        private void AjouterSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Travail_Justice aobject;
            Travail_JusticeEditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Travail_Justice(DevExpress.Xpo.Session.DefaultSession);
                editform = new Travail_JusticeEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.xpCollection1.Reload();

            }
            catch (Exception ex)
            {

            }

        }

        private void SupprimerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Travail_Justice aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("هل أنت متأكد لإزالة هذه  القضية ؟ ", "القضية ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.xpCollection1.Reload();


            }
            catch (Exception ex)
            {

            }

        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Travail_Justice aobject;
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
