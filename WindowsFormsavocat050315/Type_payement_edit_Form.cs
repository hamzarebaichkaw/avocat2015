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
    public partial class Type_Payement_edit_Form : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Type_Payement objectcourant
        {
            get;
            set;
        }

        public Type_Payement_edit_Form()
        {
            InitializeComponent();
        }
        public Type_Payement_edit_Form(avocat2015.DATA.baavocat.Type_Payement  couranttypepayement)
        {
            InitializeComponent();
            objectcourant = couranttypepayement;
        }
        private void ValiderSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Type_Payement_edit_Form_Load(object sender, EventArgs e)
        {
            this.Type_PayementBindingSource.DataSource = objectcourant;
        }
    }
}