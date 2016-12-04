using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace WindowsFormsavocat050315
{
    public partial class AuthentificationForm : Form
    {
        private avocat2015.DATA.baavocat.users objetcourant
        {
            get;
            set;
        }
        public AuthentificationForm()
        {
            InitializeComponent();
        }
        public AuthentificationForm(avocat2015.DATA.baavocat.users courantUser)
        {
            InitializeComponent();
            objetcourant = courantUser;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var currentUser = (from avocat2015.DATA.baavocat.users u in xpCollectionusers where (this.login.Text == u.login && this.pwd.Text == u.mp) select u).ToList();
            if (currentUser.Count < 1)
            {
                // l'utilisateur n'existe pas
            }
            else
            {

                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();

                
               // login'utilisateur 
            }
        }
    }
}
