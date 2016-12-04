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
    public partial class ClientEditForm : Form
    {
        private avocat2015.DATA.baavocat.Client objectcourant
        {
            get;
            set;
        }
        public ClientEditForm()
        {
            InitializeComponent();
        }
        public ClientEditForm(avocat2015.DATA.baavocat.Client courantClient)
        {
            InitializeComponent();
            objectcourant = courantClient;
        }

        private void ValiderSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ClientEditForm_Load(object sender, EventArgs e)
        {
            FormeJuridiquexpCollection.Add(objectcourant);
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
