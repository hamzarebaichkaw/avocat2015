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
    public partial class Conseil_Juridique_EditForm : Form
    {

        private avocat2015.DATA.baavocat.Conseil_Juridique objetcourant
        {
            get;
            set;
        }

        
        public Conseil_Juridique_EditForm()
        {
            InitializeComponent();
        }

        public Conseil_Juridique_EditForm(avocat2015.DATA.baavocat.Conseil_Juridique courantconsiel)
        {
            InitializeComponent();
            objetcourant = courantconsiel;
        }
        private void ValideSimpleButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Conseil_Juridique_EditForm_Load(object sender, EventArgs e)
        {
            this.bindingSource1.DataSource = objetcourant;
        }
    }
}
