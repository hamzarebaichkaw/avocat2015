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
    public partial class UserEditForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.users objetcourant
        {
            get;
            set;
        }

        public UserEditForm()
        {
            InitializeComponent();
        }
        public UserEditForm(avocat2015.DATA.baavocat.users courantUser)
        {
            InitializeComponent();
            objetcourant = courantUser;

        }
        private void ValideSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            this.UserEditBindingSource.DataSource = objetcourant;
              
        }
    }
}