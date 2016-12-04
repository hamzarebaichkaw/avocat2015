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
    public partial class ClientListForm : Form
    {
        private avocat2015.DATA.baavocat.Client objetcourant
        {
            get { return (avocat2015.DATA.baavocat.Client)this.ClientbindingSource.Current; }
        }
        public ClientListForm()
        {
            InitializeComponent();
        }

        private void xpCollection1_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
             avocat2015.DATA.baavocat.Client aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce Client?", "Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.ClientxpCollection.Reload();
            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Client aobject;
            ClientEditForm editform;
            DialogResult dr;
            try
            {
                
                aobject = new avocat2015.DATA.baavocat.Client(DevExpress.Xpo.Session.DefaultSession);
                editform = new ClientEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.ClientxpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Client aobject;
            ClientEditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new ClientEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.ClientxpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            avocat2015.DATA.baavocat.Client aobject;
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
