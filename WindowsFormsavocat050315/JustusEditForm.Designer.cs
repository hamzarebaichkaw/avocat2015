using System.Collections;
namespace WindowsFormsavocat050315
{
    partial class JustusEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JustusEditForm));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ValideSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.COD_PALAISTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CtitreTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TelTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AdresseTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.FaxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.VilleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCOD_PALAIS = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCtitre = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTel = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAdresse = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFax = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVille = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCP = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COD_PALAISTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtitreTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresseTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOD_PALAIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCtitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAdresse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.xpCollection1;
            // 
            // xpCollection1
            // 
            this.xpCollection1.LoadingEnabled = false;
            this.xpCollection1.ObjectType = typeof(avocat2015.DATA.baavocat.PALAIS_JUSTICE);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 481F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.Controls.Add(this.ValideSimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1016, 73);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ValideSimpleButton
            // 
            this.ValideSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValideSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ValideSimpleButton.Image")));
            this.ValideSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ValideSimpleButton.Location = new System.Drawing.Point(741, 3);
            this.ValideSimpleButton.Name = "ValideSimpleButton";
            this.ValideSimpleButton.Size = new System.Drawing.Size(251, 67);
            this.ValideSimpleButton.TabIndex = 2;
            this.ValideSimpleButton.Text = " تسجيل\r\n";
            this.ValideSimpleButton.Click += new System.EventHandler(this.ValideSimpleButton_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton2.Location = new System.Drawing.Point(484, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(251, 67);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "خروج";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 346);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.COD_PALAISTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CtitreTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TelTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AdresseTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FaxTextEdit);
            this.dataLayoutControl1.Controls.Add(this.VilleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CPTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.DataSource = this.bindingSource1;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1016, 261);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // COD_PALAISTextEdit
            // 
            this.COD_PALAISTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "COD_PALAIS", true));
            this.COD_PALAISTextEdit.Location = new System.Drawing.Point(78, 12);
            this.COD_PALAISTextEdit.Name = "COD_PALAISTextEdit";
            this.COD_PALAISTextEdit.Size = new System.Drawing.Size(926, 20);
            this.COD_PALAISTextEdit.StyleController = this.dataLayoutControl1;
            this.COD_PALAISTextEdit.TabIndex = 4;
            // 
            // NomTextEdit
            // 
            this.NomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Nom", true));
            this.NomTextEdit.Location = new System.Drawing.Point(78, 36);
            this.NomTextEdit.Name = "NomTextEdit";
            this.NomTextEdit.Size = new System.Drawing.Size(926, 20);
            this.NomTextEdit.StyleController = this.dataLayoutControl1;
            this.NomTextEdit.TabIndex = 5;
            // 
            // CtitreTextEdit
            // 
            this.CtitreTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Ctitre", true));
            this.CtitreTextEdit.Location = new System.Drawing.Point(78, 60);
            this.CtitreTextEdit.Name = "CtitreTextEdit";
            this.CtitreTextEdit.Size = new System.Drawing.Size(926, 20);
            this.CtitreTextEdit.StyleController = this.dataLayoutControl1;
            this.CtitreTextEdit.TabIndex = 6;
            // 
            // TelTextEdit
            // 
            this.TelTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Tel", true));
            this.TelTextEdit.Location = new System.Drawing.Point(78, 84);
            this.TelTextEdit.Name = "TelTextEdit";
            this.TelTextEdit.Size = new System.Drawing.Size(926, 20);
            this.TelTextEdit.StyleController = this.dataLayoutControl1;
            this.TelTextEdit.TabIndex = 7;
            // 
            // AdresseTextEdit
            // 
            this.AdresseTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Adresse", true));
            this.AdresseTextEdit.Location = new System.Drawing.Point(78, 108);
            this.AdresseTextEdit.Name = "AdresseTextEdit";
            this.AdresseTextEdit.Size = new System.Drawing.Size(926, 20);
            this.AdresseTextEdit.StyleController = this.dataLayoutControl1;
            this.AdresseTextEdit.TabIndex = 8;
            // 
            // FaxTextEdit
            // 
            this.FaxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Fax", true));
            this.FaxTextEdit.Location = new System.Drawing.Point(78, 132);
            this.FaxTextEdit.Name = "FaxTextEdit";
            this.FaxTextEdit.Size = new System.Drawing.Size(926, 20);
            this.FaxTextEdit.StyleController = this.dataLayoutControl1;
            this.FaxTextEdit.TabIndex = 9;
            // 
            // VilleTextEdit
            // 
            this.VilleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Ville", true));
            this.VilleTextEdit.Location = new System.Drawing.Point(78, 156);
            this.VilleTextEdit.Name = "VilleTextEdit";
            this.VilleTextEdit.Size = new System.Drawing.Size(926, 20);
            this.VilleTextEdit.StyleController = this.dataLayoutControl1;
            this.VilleTextEdit.TabIndex = 10;
            // 
            // CPTextEdit
            // 
            this.CPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "CP", true));
            this.CPTextEdit.Location = new System.Drawing.Point(78, 180);
            this.CPTextEdit.Name = "CPTextEdit";
            this.CPTextEdit.Size = new System.Drawing.Size(926, 20);
            this.CPTextEdit.StyleController = this.dataLayoutControl1;
            this.CPTextEdit.TabIndex = 11;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Description", true));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(78, 204);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(926, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 12;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource1, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(78, 228);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(926, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1016, 261);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCOD_PALAIS,
            this.ItemForNom,
            this.ItemForCtitre,
            this.ItemForTel,
            this.ItemForAdresse,
            this.ItemForFax,
            this.ItemForVille,
            this.ItemForCP,
            this.ItemForDescription,
            this.ItemForEmail});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(996, 241);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForCOD_PALAIS
            // 
            this.ItemForCOD_PALAIS.Control = this.COD_PALAISTextEdit;
            this.ItemForCOD_PALAIS.CustomizationFormText = "COD_PALAIS";
            this.ItemForCOD_PALAIS.Location = new System.Drawing.Point(0, 0);
            this.ItemForCOD_PALAIS.Name = "ItemForCOD_PALAIS";
            this.ItemForCOD_PALAIS.Size = new System.Drawing.Size(996, 24);
            this.ItemForCOD_PALAIS.Text = "COD_PALAIS";
            this.ItemForCOD_PALAIS.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForNom
            // 
            this.ItemForNom.Control = this.NomTextEdit;
            this.ItemForNom.CustomizationFormText = "Nom";
            this.ItemForNom.Location = new System.Drawing.Point(0, 24);
            this.ItemForNom.Name = "ItemForNom";
            this.ItemForNom.Size = new System.Drawing.Size(996, 24);
            this.ItemForNom.Text = "Nom";
            this.ItemForNom.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForCtitre
            // 
            this.ItemForCtitre.Control = this.CtitreTextEdit;
            this.ItemForCtitre.CustomizationFormText = "Ctitre";
            this.ItemForCtitre.Location = new System.Drawing.Point(0, 48);
            this.ItemForCtitre.Name = "ItemForCtitre";
            this.ItemForCtitre.Size = new System.Drawing.Size(996, 24);
            this.ItemForCtitre.Text = "Ctitre";
            this.ItemForCtitre.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForTel
            // 
            this.ItemForTel.Control = this.TelTextEdit;
            this.ItemForTel.CustomizationFormText = "Tel";
            this.ItemForTel.Location = new System.Drawing.Point(0, 72);
            this.ItemForTel.Name = "ItemForTel";
            this.ItemForTel.Size = new System.Drawing.Size(996, 24);
            this.ItemForTel.Text = "Tel";
            this.ItemForTel.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForAdresse
            // 
            this.ItemForAdresse.Control = this.AdresseTextEdit;
            this.ItemForAdresse.CustomizationFormText = "Adresse";
            this.ItemForAdresse.Location = new System.Drawing.Point(0, 96);
            this.ItemForAdresse.Name = "ItemForAdresse";
            this.ItemForAdresse.Size = new System.Drawing.Size(996, 24);
            this.ItemForAdresse.Text = "Adresse";
            this.ItemForAdresse.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForFax
            // 
            this.ItemForFax.Control = this.FaxTextEdit;
            this.ItemForFax.CustomizationFormText = "Fax";
            this.ItemForFax.Location = new System.Drawing.Point(0, 120);
            this.ItemForFax.Name = "ItemForFax";
            this.ItemForFax.Size = new System.Drawing.Size(996, 24);
            this.ItemForFax.Text = "Fax";
            this.ItemForFax.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForVille
            // 
            this.ItemForVille.Control = this.VilleTextEdit;
            this.ItemForVille.CustomizationFormText = "Ville";
            this.ItemForVille.Location = new System.Drawing.Point(0, 144);
            this.ItemForVille.Name = "ItemForVille";
            this.ItemForVille.Size = new System.Drawing.Size(996, 24);
            this.ItemForVille.Text = "Ville";
            this.ItemForVille.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForCP
            // 
            this.ItemForCP.Control = this.CPTextEdit;
            this.ItemForCP.CustomizationFormText = "CP";
            this.ItemForCP.Location = new System.Drawing.Point(0, 168);
            this.ItemForCP.Name = "ItemForCP";
            this.ItemForCP.Size = new System.Drawing.Size(996, 24);
            this.ItemForCP.Text = "CP";
            this.ItemForCP.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.CustomizationFormText = "Description";
            this.ItemForDescription.Location = new System.Drawing.Point(0, 192);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(996, 24);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(63, 13);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.CustomizationFormText = "Email";
            this.ItemForEmail.Location = new System.Drawing.Point(0, 216);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(996, 25);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextSize = new System.Drawing.Size(63, 13);
            // 
            // JustusEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 346);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JustusEditForm";
            this.Text = "JustusEditForm";
            this.Load += new System.EventHandler(this.JustusEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.COD_PALAISTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtitreTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresseTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOD_PALAIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCtitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAdresse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton ValideSimpleButton;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit COD_PALAISTextEdit;
        private DevExpress.XtraEditors.TextEdit NomTextEdit;
        private DevExpress.XtraEditors.TextEdit CtitreTextEdit;
        private DevExpress.XtraEditors.TextEdit TelTextEdit;
        private DevExpress.XtraEditors.TextEdit AdresseTextEdit;
        private DevExpress.XtraEditors.TextEdit FaxTextEdit;
        private DevExpress.XtraEditors.TextEdit VilleTextEdit;
        private DevExpress.XtraEditors.TextEdit CPTextEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCOD_PALAIS;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCtitre;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTel;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAdresse;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFax;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVille;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCP;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
    }
}