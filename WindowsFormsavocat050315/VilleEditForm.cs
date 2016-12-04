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
    public partial class VilleEditForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Ville objetcourant
        {
            get;
            set;
        }
        public VilleEditForm()
        {
            InitializeComponent();
        }
         public VilleEditForm(avocat2015.DATA.baavocat.Ville courantUser)
        {
            InitializeComponent();
            objetcourant = courantUser;

        }


        private void simpleButtonValider_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButtonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}