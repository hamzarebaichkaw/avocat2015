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
    public partial class Travail_JusticeEditForm : Form
    {
        private avocat2015.DATA.baavocat.Travail_Justice objectcourant
        {
            get;
            set;
        }
        public Travail_JusticeEditForm()
        {
            InitializeComponent();
        }
        public Travail_JusticeEditForm(avocat2015.DATA.baavocat.Travail_Justice courantjalsa)
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

        private void Travail_JusticeEditForm_Load(object sender, EventArgs e)
        {
            JalsaXpCollection.Add(objectcourant);
        }
    }
}
