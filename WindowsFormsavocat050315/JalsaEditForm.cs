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
    public partial class JalsaEditForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Jalsa objectcourant
        {
            get;
            set;
        }

        public JalsaEditForm()
        {
            InitializeComponent();
        }
        public JalsaEditForm(avocat2015 .DATA .baavocat .Jalsa  courantjalsa )
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
        
        private void JalsaEditForm_Load_1(object sender, EventArgs e)
        {
            JalsaXpCollection.Add(objectcourant);
        }
        
       }
}