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
    public partial class AffaireJurdiqueListForm : Form
    {
        private avocat2015.DATA.baavocat.Kadhiya objetcourant
        {
            get { return (avocat2015.DATA.baavocat.Kadhiya)this.kadeya_bindingSource.Current; }
        }
        
        public AffaireJurdiqueListForm()
        {
            InitializeComponent();
        }

        private void ModifierSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Kadhiya aobject;
            Affaire_JuridiqueForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new Affaire_JuridiqueForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.kadeya_xpCollection.Reload();

            }
            catch (Exception ex)
            {

            }

        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Kadhiya  aobject;
            try
            {
                aobject = this.objetcourant;
                this.Close();
            }
            catch (Exception ex)
            {
 
            }
        }

        private void AjouterSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Kadhiya aobject;
           
            Affaire_JuridiqueForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.Kadhiya(DevExpress.Xpo.Session.DefaultSession);
                
                editform = new Affaire_JuridiqueForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
               aobject.Save();
                 
                this.kadeya_xpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void SupprimerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Kadhiya aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("هل أنت متأكد لإزالة هذه  القضية ؟ ", "القضية ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.kadeya_xpCollection.Reload();


            }
            catch (Exception ex)
            {

            }
        }

        private void ImprimerSelSimpleButton_Click(object sender, EventArgs e)
        {
            Imprimer();
        }
        public void Imprimer()
        {
            affaire_jurdiqueReport.Imprimer(kadeya_bindingSource.Current);
        }
        
    }
}
