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
    public partial class Reglement_ClientForm : Form
    {
        private avocat2015.DATA.baavocat.Reglement_Client objectcourant
        {
            get;
            set;
        }
        public Reglement_ClientForm()
        {
            InitializeComponent();
        }
        public Reglement_ClientForm(avocat2015.DATA.baavocat.Reglement_Client CurrentReglement)
        {
            InitializeComponent();
            objectcourant = CurrentReglement;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void Valide_Click(object sender, EventArgs e)
        {
            
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Reglement_ClientForm_Load(object sender, EventArgs e)
        {
            this.ReglementClientxpCollection.Add(objectcourant);
            this.kadyaaxpCollection.Add(objectcourant);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.Reglement_Client aobject;
            try
            {
                aobject = this.objectcourant;
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
