namespace WindowsFormsavocat050315
{
    partial class Type_Payement_edit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Type_Payement_edit_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Type_Payement1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Type_PayementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Type_PayementXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForType_Payement1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ValiderSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Type_Payement1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType_Payement1)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Type_Payement1TextEdit);
            this.dataLayoutControl1.DataSource = this.Type_PayementBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(584, 259);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Type_Payement1TextEdit
            // 
            this.Type_Payement1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.Type_PayementBindingSource, "Type_Payement1", true));
            this.Type_Payement1TextEdit.Location = new System.Drawing.Point(24, 43);
            this.Type_Payement1TextEdit.Name = "Type_Payement1TextEdit";
            this.Type_Payement1TextEdit.Size = new System.Drawing.Size(462, 20);
            this.Type_Payement1TextEdit.StyleController = this.dataLayoutControl1;
            this.Type_Payement1TextEdit.TabIndex = 4;
            // 
            // Type_PayementBindingSource
            // 
            this.Type_PayementBindingSource.DataSource = this.Type_PayementXpCollection;
            // 
            // Type_PayementXpCollection
            // 
            this.Type_PayementXpCollection.LoadingEnabled = false;
            this.Type_PayementXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Type_Payement);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 259);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForType_Payement1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(564, 239);
            this.layoutControlGroup2.Text = "طريقة الدفع";
            // 
            // ItemForType_Payement1
            // 
            this.ItemForType_Payement1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForType_Payement1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForType_Payement1.Control = this.Type_Payement1TextEdit;
            this.ItemForType_Payement1.CustomizationFormText = "Type_Payement1";
            this.ItemForType_Payement1.Location = new System.Drawing.Point(0, 0);
            this.ItemForType_Payement1.Name = "ItemForType_Payement1";
            this.ItemForType_Payement1.Size = new System.Drawing.Size(540, 196);
            this.ItemForType_Payement1.Text = "طريقة الدفع";
            this.ItemForType_Payement1.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForType_Payement1.TextSize = new System.Drawing.Size(71, 13);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ValiderSimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 268);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(584, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ValiderSimpleButton
            // 
            this.ValiderSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValiderSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ValiderSimpleButton.Image")));
            this.ValiderSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ValiderSimpleButton.Location = new System.Drawing.Point(433, 3);
            this.ValiderSimpleButton.Name = "ValiderSimpleButton";
            this.ValiderSimpleButton.Size = new System.Drawing.Size(127, 28);
            this.ValiderSimpleButton.TabIndex = 1;
            this.ValiderSimpleButton.Text = "تسجيل";
            this.ValiderSimpleButton.Click += new System.EventHandler(this.ValiderSimpleButton_Click);
            // 
            // AnnulerSimpleButton
            // 
            this.AnnulerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnulerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AnnulerSimpleButton.Image")));
            this.AnnulerSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.AnnulerSimpleButton.Location = new System.Drawing.Point(300, 3);
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Size = new System.Drawing.Size(127, 28);
            this.AnnulerSimpleButton.TabIndex = 0;
            this.AnnulerSimpleButton.Text = "خورج";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // Type_Payement_edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Type_Payement_edit_Form";
            this.Text = "Type_Payement_edit_Form";
            this.Load += new System.EventHandler(this.Type_Payement_edit_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Type_Payement1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType_Payement1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection Type_PayementXpCollection;
        private System.Windows.Forms.BindingSource Type_PayementBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit Type_Payement1TextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForType_Payement1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton ValiderSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
    }
}