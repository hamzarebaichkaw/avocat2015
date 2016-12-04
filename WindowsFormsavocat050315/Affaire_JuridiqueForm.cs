using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering;

namespace WindowsFormsavocat050315
{
    public partial class Affaire_JuridiqueForm : Form
    {
        private avocat2015.DATA.baavocat.Kadhiya objetcourant
        {
            get;
            set;
        }
        public string cheminEXE = System.Environment.CurrentDirectory;
        public Affaire_JuridiqueForm()
        {
            InitializeComponent();
        }
        public Affaire_JuridiqueForm(avocat2015.DATA.baavocat.Kadhiya courantUser)
        {
            InitializeComponent();
            objetcourant = courantUser;
            objetcourant = courantUser;
            document1xpCollection.CriteriaString = string.Format("[Code_kadhiya] = '{0}'", objetcourant.Code_kadhiya);
        }
        private void dataGridView_DOCUMENT1_DoubleClick(object sender, EventArgs e)
        {
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            avocat2015.DATA.baavocat.Document_ka doc = (bindingSourceDOCUMENT1.AddNew() as avocat2015.DATA.baavocat.Document_ka);
            doc.Nom= this.openFileDialog1.FileName;
            doc.Type = "kadeya";
            doc.Docum = this.openFileDialog1.SafeFileName;
            doc.Code_kadhiya = objetcourant.Code_kadhiya;
            doc.Save();
            document1xpCollection.Reload();
            
          
               
        }

        private void Valide_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Affaire_JuridiqueForm_Load(object sender, EventArgs e)
        {
            this.kadeybindingSource.DataSource = objetcourant;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.ShowDialog();

           // (bindingSourceDOCUMENT2.AddNew() as avocat2015.DATA.baavocat.DOCUMENT2).NOM_FICHIER2 = this.openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.ShowDialog();

            //(bindingSourceDOCUMENT3.AddNew() as avocat2015.DATA.baavocat.DOCUMENT3).NOM_FICHIER3 = this.openFileDialog1.FileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  this.openFileDialog1.ShowDialog();

            //(bindingSourceDOCUMENT4.AddNew() as avocat2015.DATA.baavocat.DOCUMENT4).NOM_FICHIER4 = this.openFileDialog1.FileName;
        }
    }
}
