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
    public partial class JustusEditForm : Form
    {
        private avocat2015.DATA.baavocat.PALAIS_JUSTICE objetcourant
        {
            get;
            set;
        }
        public JustusEditForm()
        {
            InitializeComponent();
        }
        public JustusEditForm(avocat2015.DATA.baavocat.PALAIS_JUSTICE courantUser)
        {
            InitializeComponent();
            objetcourant = courantUser;
        }

        private void ValideSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void JustusEditForm_Load(object sender, EventArgs e)
        {
            this.bindingSource1.DataSource = objetcourant;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
