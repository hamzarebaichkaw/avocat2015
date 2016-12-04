namespace WindowsFormsavocat050315
{
    partial class FormeJuridiqueEditForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CodeFormeJuridiqueSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.FormeJuridiquebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FormeJuridiquexpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.FormeJuridique1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCodeFormeJuridique = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFormeJuridique1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ValiderSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeFormeJuridiqueSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquexpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridique1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodeFormeJuridique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFormeJuridique1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataLayoutControl1);
            this.layoutControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FormeJuridiquebindingSource, "FormeJuridique1", true));
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(672, 215);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CodeFormeJuridiqueSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.FormeJuridique1TextEdit);
            this.dataLayoutControl1.DataSource = this.FormeJuridiquebindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(648, 88);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CodeFormeJuridiqueSpinEdit
            // 
            this.CodeFormeJuridiqueSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.FormeJuridiquebindingSource, "CodeFormeJuridique", true));
            this.CodeFormeJuridiqueSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CodeFormeJuridiqueSpinEdit.Location = new System.Drawing.Point(119, 12);
            this.CodeFormeJuridiqueSpinEdit.Name = "CodeFormeJuridiqueSpinEdit";
            this.CodeFormeJuridiqueSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CodeFormeJuridiqueSpinEdit.Size = new System.Drawing.Size(517, 20);
            this.CodeFormeJuridiqueSpinEdit.StyleController = this.dataLayoutControl1;
            this.CodeFormeJuridiqueSpinEdit.TabIndex = 4;
            // 
            // FormeJuridiquebindingSource
            // 
            this.FormeJuridiquebindingSource.DataSource = this.FormeJuridiquexpCollection;
            // 
            // FormeJuridiquexpCollection
            // 
            this.FormeJuridiquexpCollection.LoadingEnabled = false;
            this.FormeJuridiquexpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.FormeJuridique);
            // 
            // FormeJuridique1TextEdit
            // 
            this.FormeJuridique1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.FormeJuridiquebindingSource, "FormeJuridique1", true));
            this.FormeJuridique1TextEdit.Location = new System.Drawing.Point(119, 36);
            this.FormeJuridique1TextEdit.Name = "FormeJuridique1TextEdit";
            this.FormeJuridique1TextEdit.Size = new System.Drawing.Size(517, 20);
            this.FormeJuridique1TextEdit.StyleController = this.dataLayoutControl1;
            this.FormeJuridique1TextEdit.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(648, 88);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCodeFormeJuridique,
            this.ItemForFormeJuridique1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(628, 68);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForCodeFormeJuridique
            // 
            this.ItemForCodeFormeJuridique.Control = this.CodeFormeJuridiqueSpinEdit;
            this.ItemForCodeFormeJuridique.CustomizationFormText = "Code Forme Juridique";
            this.ItemForCodeFormeJuridique.Location = new System.Drawing.Point(0, 0);
            this.ItemForCodeFormeJuridique.Name = "ItemForCodeFormeJuridique";
            this.ItemForCodeFormeJuridique.Size = new System.Drawing.Size(628, 24);
            this.ItemForCodeFormeJuridique.Text = "Code Forme Juridique";
            this.ItemForCodeFormeJuridique.TextSize = new System.Drawing.Size(104, 13);
            // 
            // ItemForFormeJuridique1
            // 
            this.ItemForFormeJuridique1.Control = this.FormeJuridique1TextEdit;
            this.ItemForFormeJuridique1.CustomizationFormText = "Forme Juridique1";
            this.ItemForFormeJuridique1.Location = new System.Drawing.Point(0, 24);
            this.ItemForFormeJuridique1.Name = "ItemForFormeJuridique1";
            this.ItemForFormeJuridique1.Size = new System.Drawing.Size(628, 44);
            this.ItemForFormeJuridique1.Text = "Forme Juridique1";
            this.ItemForFormeJuridique1.TextSize = new System.Drawing.Size(104, 13);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(672, 215);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(652, 195);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ValiderSimpleButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 224);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(672, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AnnulerSimpleButton
            // 
            this.AnnulerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnulerSimpleButton.Location = new System.Drawing.Point(317, 3);
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Size = new System.Drawing.Size(163, 26);
            this.AnnulerSimpleButton.TabIndex = 0;
            this.AnnulerSimpleButton.Text = "خروج";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // ValiderSimpleButton
            // 
            this.ValiderSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValiderSimpleButton.Location = new System.Drawing.Point(486, 3);
            this.ValiderSimpleButton.Name = "ValiderSimpleButton";
            this.ValiderSimpleButton.Size = new System.Drawing.Size(163, 26);
            this.ValiderSimpleButton.TabIndex = 1;
            this.ValiderSimpleButton.Text = "تسجيل";
            this.ValiderSimpleButton.Click += new System.EventHandler(this.ValiderSimpleButton_Click);
            // 
            // FormeJuridiqueEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormeJuridiqueEditForm";
            this.Text = "FormeJuridiqueEditForm";
            this.Load += new System.EventHandler(this.FormeJuridiqueEditForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeFormeJuridiqueSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquexpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridique1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodeFormeJuridique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFormeJuridique1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection FormeJuridiquexpCollection;
        private System.Windows.Forms.BindingSource FormeJuridiquebindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SpinEdit CodeFormeJuridiqueSpinEdit;
        private DevExpress.XtraEditors.TextEdit FormeJuridique1TextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCodeFormeJuridique;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFormeJuridique1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ValiderSimpleButton;
    }
}