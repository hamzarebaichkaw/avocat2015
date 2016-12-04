using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsavocat050315
{
    public partial class FormeJuridiqueEditForm : Form
    {
        private avocat2015.DATA.baavocat.FormeJuridique objectcourant
        {
            get;
            set;
        }
        public FormeJuridiqueEditForm()
        {
            InitializeComponent();

        }
        public FormeJuridiqueEditForm(avocat2015.DATA.baavocat.FormeJuridique courantFormeJuridique)
        {
            InitializeComponent();
            objectcourant = courantFormeJuridique;
        }

        private void ValiderSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void FormeJuridiqueEditForm_Load(object sender, EventArgs e)
        {
            FormeJuridiquexpCollection.Add(objectcourant);
        }
    }
}
