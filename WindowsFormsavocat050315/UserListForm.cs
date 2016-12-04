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
    public partial class UserListForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.users objetcourant
        {
            get { return (avocat2015.DATA.baavocat.users)this.UserBindingSource.Current; }
        }
        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonModifier_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.users aobject;
            UserEditForm editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new UserEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.UserListxpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonSupprimer_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.users aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                    dr = XtraMessageBox.Show("êtes vous sûr de supprimer ce user?", "user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {  aobject.Delete();}

                    else aobject.Reload();
                    this.UserListxpCollection.Reload();
                

            }
            catch (Exception ex)
            {

            }

        }

        private void simpleButtonEnregistre_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.users aobject;
            UserEditForm editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.users(DevExpress.Xpo.Session.DefaultSession);
                editform = new UserEditForm(aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.UserListxpCollection.Reload();

            }
            catch (Exception ex)
            {

            }

        }

        private void simpleButtonAnnuler_Click(object sender, EventArgs e)
        {
          
              avocat2015.DATA.baavocat.users aobject;
            try
            {
                aobject = this.objetcourant;
                this.Close ();    
             }
             catch (Exception ex)
            {

            }
        
        
        
        }

        }
    }
