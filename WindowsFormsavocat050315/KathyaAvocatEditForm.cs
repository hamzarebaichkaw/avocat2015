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
    public partial class KathyaAvocatEditForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.kadhiya_avocat objetcourant
        {
            get;
            set;
        }
        public KathyaAvocatEditForm()
        {
            InitializeComponent();
        }
        public KathyaAvocatEditForm(avocat2015.DATA.baavocat.kadhiya_avocat  courantUser)
        {
            InitializeComponent();
            objetcourant = courantUser;

        }
        private void ValiderSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void KathyaAvocatEditForm_Load(object sender, EventArgs e)
        {
            KathyaAvocatXpCollection.Add(objetcourant);
        }
    }
}