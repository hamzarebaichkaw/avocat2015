namespace WindowsFormsavocat050315
{
    partial class KathyaAvocatEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KathyaAvocatEditForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Code_Av_kaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.KathyaAvocatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KathyaAvocatXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.PrixSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCode_Av_ka = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrix = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ValiderSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Code_Av_kaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrixSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode_Av_ka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrix)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Code_Av_kaSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.PrixSpinEdit);
            this.dataLayoutControl1.DataSource = this.KathyaAvocatBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(629, 215);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Code_Av_kaSpinEdit
            // 
            this.Code_Av_kaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KathyaAvocatBindingSource, "Code_Av_ka", true));
            this.Code_Av_kaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Code_Av_kaSpinEdit.Location = new System.Drawing.Point(24, 43);
            this.Code_Av_kaSpinEdit.Name = "Code_Av_kaSpinEdit";
            this.Code_Av_kaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Code_Av_kaSpinEdit.Size = new System.Drawing.Size(517, 20);
            this.Code_Av_kaSpinEdit.StyleController = this.dataLayoutControl1;
            this.Code_Av_kaSpinEdit.TabIndex = 4;
            // 
            // KathyaAvocatBindingSource
            // 
            this.KathyaAvocatBindingSource.DataSource = this.KathyaAvocatXpCollection;
            // 
            // KathyaAvocatXpCollection
            // 
            this.KathyaAvocatXpCollection.LoadingEnabled = false;
            this.KathyaAvocatXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.kadhiya_avocat);
            // 
            // PrixSpinEdit
            // 
            this.PrixSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.KathyaAvocatBindingSource, "Prix", true));
            this.PrixSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PrixSpinEdit.Location = new System.Drawing.Point(24, 67);
            this.PrixSpinEdit.Name = "PrixSpinEdit";
            this.PrixSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.PrixSpinEdit.Size = new System.Drawing.Size(517, 20);
            this.PrixSpinEdit.StyleController = this.dataLayoutControl1;
            this.PrixSpinEdit.TabIndex = 9;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(629, 215);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.CustomizationFormText = "قاضية محاماة";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCode_Av_ka,
            this.ItemForPrix});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(609, 195);
            this.layoutControlGroup2.Text = "قاضية محاماة";
            // 
            // ItemForCode_Av_ka
            // 
            this.ItemForCode_Av_ka.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForCode_Av_ka.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForCode_Av_ka.Control = this.Code_Av_kaSpinEdit;
            this.ItemForCode_Av_ka.CustomizationFormText = "Code_Av_ka";
            this.ItemForCode_Av_ka.Location = new System.Drawing.Point(0, 0);
            this.ItemForCode_Av_ka.Name = "ItemForCode_Av_ka";
            this.ItemForCode_Av_ka.Size = new System.Drawing.Size(585, 24);
            this.ItemForCode_Av_ka.Text = "Code_Av_ka";
            this.ItemForCode_Av_ka.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForCode_Av_ka.TextSize = new System.Drawing.Size(61, 13);
            // 
            // ItemForPrix
            // 
            this.ItemForPrix.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForPrix.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForPrix.Control = this.PrixSpinEdit;
            this.ItemForPrix.CustomizationFormText = "Prix";
            this.ItemForPrix.Location = new System.Drawing.Point(0, 24);
            this.ItemForPrix.Name = "ItemForPrix";
            this.ItemForPrix.Size = new System.Drawing.Size(585, 128);
            this.ItemForPrix.Text = "السعر";
            this.ItemForPrix.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForPrix.TextSize = new System.Drawing.Size(61, 13);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ValiderSimpleButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 224);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(629, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AnnulerSimpleButton
            // 
            this.AnnulerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AnnulerSimpleButton.Image")));
            this.AnnulerSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.AnnulerSimpleButton.Location = new System.Drawing.Point(239, 3);
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Size = new System.Drawing.Size(180, 28);
            this.AnnulerSimpleButton.TabIndex = 1;
            this.AnnulerSimpleButton.Text = "خورج";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // ValiderSimpleButton
            // 
            this.ValiderSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ValiderSimpleButton.Image")));
            this.ValiderSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ValiderSimpleButton.Location = new System.Drawing.Point(425, 3);
            this.ValiderSimpleButton.Name = "ValiderSimpleButton";
            this.ValiderSimpleButton.Size = new System.Drawing.Size(180, 28);
            this.ValiderSimpleButton.TabIndex = 0;
            this.ValiderSimpleButton.Text = "تسجيل";
            this.ValiderSimpleButton.Click += new System.EventHandler(this.ValiderSimpleButton_Click);
            // 
            // KathyaAvocatEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KathyaAvocatEditForm";
            this.Text = "KathyaAvocatEditForm";
            this.Load += new System.EventHandler(this.KathyaAvocatEditForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Code_Av_kaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrixSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode_Av_ka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrix)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection KathyaAvocatXpCollection;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SpinEdit Code_Av_kaSpinEdit;
        private System.Windows.Forms.BindingSource KathyaAvocatBindingSource;
        private DevExpress.XtraEditors.SpinEdit PrixSpinEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCode_Av_ka;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ValiderSimpleButton;
    }
}