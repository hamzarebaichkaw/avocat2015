﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsavocat050315
{
    public partial class KathyaAvocatListeForm : DevExpress.XtraEditors.XtraForm
    {
        
        private avocat2015.DATA.baavocat.kadhiya_avocat  objetcourant   
        {
            get { return (avocat2015.DATA.baavocat.kadhiya_avocat )this.KathyaAvocatBindingSource .Current; }
        }
        public KathyaAvocatListeForm()
        {
            InitializeComponent();

        }

        private void ModifierSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.kadhiya_avocat  aobject;
            KathyaAvocatEditForm  editform;
            DialogResult dr;
            try
            {
                aobject = this.objetcourant;
                editform = new KathyaAvocatEditForm (aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                else aobject.Reload();
                this.KathyaAvocatXpCollection.Reload();

            }
            catch (Exception ex)
            {

            }
        }

        private void AnnulerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.kadhiya_avocat  aobject;
            try
            {
                aobject = this.objetcourant;
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void AjouterSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.kadhiya_avocat  aobject;
            KathyaAvocatEditForm  editform;
            DialogResult dr;
            try
            {
                aobject = new avocat2015.DATA.baavocat.kadhiya_avocat (DevExpress.Xpo.Session.DefaultSession);
                editform = new KathyaAvocatEditForm (aobject);
                dr = editform.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                    aobject.Save();
                this.KathyaAvocatXpCollection .Reload();

            }
            catch (Exception ex)
            {

            }

        }

        private void SupprimerSimpleButton_Click(object sender, EventArgs e)
        {
            avocat2015.DATA.baavocat.kadhiya_avocat  aobject;
            DialogResult dr;
            try
            {

                aobject = this.objetcourant;
                dr = XtraMessageBox.Show("هل أنت متأكد لإزالة هذه  القضية ؟ ", "القضية ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                { aobject.Delete(); }

                else aobject.Reload();
                this.KathyaAvocatXpCollection .Reload();


            }
            catch (Exception ex)
            {

            }
        }

        
    }
}