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
    public partial class JustusPortEditForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Justice_Port objectcourant
        {
            get;
            set;
        }
        public JustusPortEditForm()
        {
            InitializeComponent();
        }
        public JustusPortEditForm(avocat2015.DATA.baavocat.Justice_Port courantjalsa) 
        {
            InitializeComponent();
            objectcourant = courantjalsa;
        }

        private void ValiderSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void JustusPortEditForm_Load(object sender, EventArgs e)
        {
            this.JustusPortBindingSource .DataSource = objectcourant;
        }
    }
}