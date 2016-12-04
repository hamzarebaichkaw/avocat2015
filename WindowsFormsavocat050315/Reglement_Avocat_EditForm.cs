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
    public partial class Reglement_Avocat_EditForm : DevExpress.XtraEditors.XtraForm
    {
        private avocat2015.DATA.baavocat.Reglement_Avocat objectcourant
        {
            get;
            set;
        }
        public Reglement_Avocat_EditForm()
        {
           
            InitializeComponent();
        }
        public Reglement_Avocat_EditForm(avocat2015.DATA.baavocat.Reglement_Avocat CurrentReglement)
        {
            objectcourant = CurrentReglement;
            InitializeComponent();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            DialogResult = System.Windows.Forms.DialogResult.OK;
         

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Reglement_Avocat_EditForm_Load(object sender, EventArgs e)
        {
            Reglement_AvocatXpCollection.Add(objectcourant);           
        }
    }
}