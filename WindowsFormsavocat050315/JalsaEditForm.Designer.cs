namespace WindowsFormsavocat050315
{
    partial class JalsaEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JalsaEditForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Code_JalsaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.JalsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JalsaXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.DateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Date_ProchaineDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.COD_PALAISTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hokomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCode_Jalsa = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDate_Prochaine = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCOD_PALAIS = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForhokom = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ValiderSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Code_JalsaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_ProchaineDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_ProchaineDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COD_PALAISTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hokomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode_Jalsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate_Prochaine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOD_PALAIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForhokom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 293);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Code_JalsaTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.Date_ProchaineDateEdit);
            this.dataLayoutControl1.Controls.Add(this.COD_PALAISTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.hokomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.textEdit2);
            this.dataLayoutControl1.DataSource = this.JalsaBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(630, 247);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Code_JalsaTextEdit
            // 
            this.Code_JalsaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.JalsaBindingSource, "Code_Jalsa", true));
            this.Code_JalsaTextEdit.Location = new System.Drawing.Point(24, 43);
            this.Code_JalsaTextEdit.Name = "Code_JalsaTextEdit";
            this.Code_JalsaTextEdit.Size = new System.Drawing.Size(444, 20);
            this.Code_JalsaTextEdit.StyleController = this.dataLayoutControl1;
            this.Code_JalsaTextEdit.TabIndex = 4;
            // 
            // JalsaBindingSource
            // 
            this.JalsaBindingSource.DataSource = this.JalsaXpCollection;
            // 
            // JalsaXpCollection
            // 
            this.JalsaXpCollection.LoadingEnabled = false;
            this.JalsaXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Jalsa);
            // 
            // DateDateEdit
            // 
            this.DateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.JalsaBindingSource, "Date", true));
            this.DateDateEdit.EditValue = null;
            this.DateDateEdit.Location = new System.Drawing.Point(24, 67);
            this.DateDateEdit.Name = "DateDateEdit";
            this.DateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DateDateEdit.Size = new System.Drawing.Size(444, 20);
            this.DateDateEdit.StyleController = this.dataLayoutControl1;
            this.DateDateEdit.TabIndex = 5;
            // 
            // Date_ProchaineDateEdit
            // 
            this.Date_ProchaineDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.JalsaBindingSource, "Date_Prochaine", true));
            this.Date_ProchaineDateEdit.EditValue = null;
            this.Date_ProchaineDateEdit.Location = new System.Drawing.Point(24, 91);
            this.Date_ProchaineDateEdit.Name = "Date_ProchaineDateEdit";
            this.Date_ProchaineDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Date_ProchaineDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Date_ProchaineDateEdit.Size = new System.Drawing.Size(444, 20);
            this.Date_ProchaineDateEdit.StyleController = this.dataLayoutControl1;
            this.Date_ProchaineDateEdit.TabIndex = 6;
            // 
            // COD_PALAISTextEdit
            // 
            this.COD_PALAISTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.JalsaBindingSource, "COD_PALAIS", true));
            this.COD_PALAISTextEdit.Location = new System.Drawing.Point(24, 115);
            this.COD_PALAISTextEdit.Name = "COD_PALAISTextEdit";
            this.COD_PALAISTextEdit.Size = new System.Drawing.Size(444, 20);
            this.COD_PALAISTextEdit.StyleController = this.dataLayoutControl1;
            this.COD_PALAISTextEdit.TabIndex = 7;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.JalsaBindingSource, "Description", true));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(24, 139);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(444, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 8;
            // 
            // hokomTextEdit
            // 
            this.hokomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.JalsaBindingSource, "hokom", true));
            this.hokomTextEdit.Location = new System.Drawing.Point(24, 163);
            this.hokomTextEdit.Name = "hokomTextEdit";
            this.hokomTextEdit.Size = new System.Drawing.Size(444, 20);
            this.hokomTextEdit.StyleController = this.dataLayoutControl1;
            this.hokomTextEdit.TabIndex = 9;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.JalsaBindingSource, "Code_ka!Key", true));
            this.textEdit2.Location = new System.Drawing.Point(24, 187);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(444, 20);
            this.textEdit2.StyleController = this.dataLayoutControl1;
            this.textEdit2.TabIndex = 11;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(630, 247);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlGroup2.CustomizationFormText = "الجلسة";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCode_Jalsa,
            this.ItemForDate,
            this.ItemForDate_Prochaine,
            this.ItemForCOD_PALAIS,
            this.ItemForDescription,
            this.ItemForhokom,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(610, 227);
            this.layoutControlGroup2.Text = "الجلسة";
            // 
            // ItemForCode_Jalsa
            // 
            this.ItemForCode_Jalsa.Control = this.Code_JalsaTextEdit;
            this.ItemForCode_Jalsa.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemForCode_Jalsa.CustomizationFormText = "Code_Jalsa";
            this.ItemForCode_Jalsa.Location = new System.Drawing.Point(0, 0);
            this.ItemForCode_Jalsa.Name = "ItemForCode_Jalsa";
            this.ItemForCode_Jalsa.Size = new System.Drawing.Size(586, 24);
            this.ItemForCode_Jalsa.Text = "رمز الجلسة";
            this.ItemForCode_Jalsa.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCode_Jalsa.TextSize = new System.Drawing.Size(135, 13);
            // 
            // ItemForDate
            // 
            this.ItemForDate.Control = this.DateDateEdit;
            this.ItemForDate.CustomizationFormText = "Date";
            this.ItemForDate.Location = new System.Drawing.Point(0, 24);
            this.ItemForDate.Name = "ItemForDate";
            this.ItemForDate.Size = new System.Drawing.Size(586, 24);
            this.ItemForDate.Text = "التاريخ الجلسة";
            this.ItemForDate.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForDate.TextSize = new System.Drawing.Size(135, 13);
            // 
            // ItemForDate_Prochaine
            // 
            this.ItemForDate_Prochaine.Control = this.Date_ProchaineDateEdit;
            this.ItemForDate_Prochaine.CustomizationFormText = "Date_Prochaine";
            this.ItemForDate_Prochaine.Location = new System.Drawing.Point(0, 48);
            this.ItemForDate_Prochaine.Name = "ItemForDate_Prochaine";
            this.ItemForDate_Prochaine.Size = new System.Drawing.Size(586, 24);
            this.ItemForDate_Prochaine.Text = "تاريخ المقبل لللجلسة";
            this.ItemForDate_Prochaine.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForDate_Prochaine.TextSize = new System.Drawing.Size(135, 13);
            // 
            // ItemForCOD_PALAIS
            // 
            this.ItemForCOD_PALAIS.Control = this.COD_PALAISTextEdit;
            this.ItemForCOD_PALAIS.CustomizationFormText = "COD_PALAIS";
            this.ItemForCOD_PALAIS.Location = new System.Drawing.Point(0, 72);
            this.ItemForCOD_PALAIS.Name = "ItemForCOD_PALAIS";
            this.ItemForCOD_PALAIS.Size = new System.Drawing.Size(586, 24);
            this.ItemForCOD_PALAIS.Text = "COD_PALAIS";
            this.ItemForCOD_PALAIS.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCOD_PALAIS.TextSize = new System.Drawing.Size(135, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.CustomizationFormText = "Description";
            this.ItemForDescription.Location = new System.Drawing.Point(0, 96);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(586, 24);
            this.ItemForDescription.Text = "التفاصيل";
            this.ItemForDescription.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForDescription.TextSize = new System.Drawing.Size(135, 13);
            // 
            // ItemForhokom
            // 
            this.ItemForhokom.Control = this.hokomTextEdit;
            this.ItemForhokom.CustomizationFormText = "hokom";
            this.ItemForhokom.Location = new System.Drawing.Point(0, 120);
            this.ItemForhokom.Name = "ItemForhokom";
            this.ItemForhokom.Size = new System.Drawing.Size(586, 24);
            this.ItemForhokom.Text = "الحكم";
            this.ItemForhokom.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForhokom.TextSize = new System.Drawing.Size(135, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.CustomizationFormText = "Code_ka";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem2.Name = "ItemForCode_ka!Key";
            this.layoutControlItem2.Size = new System.Drawing.Size(586, 40);
            this.layoutControlItem2.Text = "رمز القضية";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(135, 13);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74533F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25467F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ValiderSimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 256);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ValiderSimpleButton
            // 
            this.ValiderSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ValiderSimpleButton.Image")));
            this.ValiderSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ValiderSimpleButton.Location = new System.Drawing.Point(451, 3);
            this.ValiderSimpleButton.Name = "ValiderSimpleButton";
            this.ValiderSimpleButton.Size = new System.Drawing.Size(155, 28);
            this.ValiderSimpleButton.TabIndex = 0;
            this.ValiderSimpleButton.Text = " تسجيل";
            this.ValiderSimpleButton.Click += new System.EventHandler(this.ValiderSimpleButton_Click);
            // 
            // AnnulerSimpleButton
            // 
            this.AnnulerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AnnulerSimpleButton.Image")));
            this.AnnulerSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.AnnulerSimpleButton.Location = new System.Drawing.Point(292, 3);
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Size = new System.Drawing.Size(153, 28);
            this.AnnulerSimpleButton.TabIndex = 1;
            this.AnnulerSimpleButton.Text = "خروج";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // JalsaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JalsaEditForm";
            this.Text = "JalsaEditForm";
            this.Load += new System.EventHandler(this.JalsaEditForm_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Code_JalsaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_ProchaineDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_ProchaineDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COD_PALAISTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hokomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode_Jalsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDate_Prochaine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCOD_PALAIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForhokom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection JalsaXpCollection;
        private System.Windows.Forms.BindingSource JalsaBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit Code_JalsaTextEdit;
        private DevExpress.XtraEditors.DateEdit DateDateEdit;
        private DevExpress.XtraEditors.DateEdit Date_ProchaineDateEdit;
        private DevExpress.XtraEditors.TextEdit COD_PALAISTextEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit hokomTextEdit;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCode_Jalsa;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDate_Prochaine;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCOD_PALAIS;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForhokom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton ValiderSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
    }
}