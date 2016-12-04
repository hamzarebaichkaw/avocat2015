namespace WindowsFormsavocat050315
{
    partial class FormJuridiqueListeForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.FormeJuridiquebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FormeJuridiquexpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeFormeJuridique = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormeJuridique1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SortirsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimertoussimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimersimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.supprimersimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AjoutsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.modifiersimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquexpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.FormeJuridiquebindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FormeJuridiquebindingSource
            // 
            this.FormeJuridiquebindingSource.DataSource = this.FormeJuridiquexpCollection;
            // 
            // FormeJuridiquexpCollection
            // 
            this.FormeJuridiquexpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.FormeJuridique);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeFormeJuridique,
            this.colFormeJuridique1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCodeFormeJuridique
            // 
            this.colCodeFormeJuridique.Caption = "رقم الشكل القانوني ";
            this.colCodeFormeJuridique.FieldName = "CodeFormeJuridique";
            this.colCodeFormeJuridique.Name = "colCodeFormeJuridique";
            this.colCodeFormeJuridique.Visible = true;
            this.colCodeFormeJuridique.VisibleIndex = 0;
            // 
            // colFormeJuridique1
            // 
            this.colFormeJuridique1.Caption = "الشكل القانوني";
            this.colFormeJuridique1.FieldName = "FormeJuridique1";
            this.colFormeJuridique1.Name = "colFormeJuridique1";
            this.colFormeJuridique1.Visible = true;
            this.colFormeJuridique1.VisibleIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.SortirsimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimertoussimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimersimpleButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.supprimersimpleButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.AjoutsimpleButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.modifiersimpleButton, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // SortirsimpleButton
            // 
            this.SortirsimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortirsimpleButton.Location = new System.Drawing.Point(23, 3);
            this.SortirsimpleButton.Name = "SortirsimpleButton";
            this.SortirsimpleButton.Size = new System.Drawing.Size(160, 28);
            this.SortirsimpleButton.TabIndex = 0;
            this.SortirsimpleButton.Text = "خورج";
            this.SortirsimpleButton.Click += new System.EventHandler(this.SortirsimpleButton_Click);
            // 
            // ImprimertoussimpleButton
            // 
            this.ImprimertoussimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimertoussimpleButton.Location = new System.Drawing.Point(189, 3);
            this.ImprimertoussimpleButton.Name = "ImprimertoussimpleButton";
            this.ImprimertoussimpleButton.Size = new System.Drawing.Size(160, 28);
            this.ImprimertoussimpleButton.TabIndex = 1;
            this.ImprimertoussimpleButton.Text = "طباعة";
            // 
            // ImprimersimpleButton
            // 
            this.ImprimersimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimersimpleButton.Location = new System.Drawing.Point(355, 3);
            this.ImprimersimpleButton.Name = "ImprimersimpleButton";
            this.ImprimersimpleButton.Size = new System.Drawing.Size(160, 28);
            this.ImprimersimpleButton.TabIndex = 2;
            this.ImprimersimpleButton.Text = "طباعة";
            // 
            // supprimersimpleButton
            // 
            this.supprimersimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supprimersimpleButton.Location = new System.Drawing.Point(521, 3);
            this.supprimersimpleButton.Name = "supprimersimpleButton";
            this.supprimersimpleButton.Size = new System.Drawing.Size(160, 28);
            this.supprimersimpleButton.TabIndex = 3;
            this.supprimersimpleButton.Text = "حذف";
            this.supprimersimpleButton.Click += new System.EventHandler(this.supprimersimpleButton_Click);
            // 
            // AjoutsimpleButton
            // 
            this.AjoutsimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AjoutsimpleButton.Location = new System.Drawing.Point(687, 3);
            this.AjoutsimpleButton.Name = "AjoutsimpleButton";
            this.AjoutsimpleButton.Size = new System.Drawing.Size(160, 28);
            this.AjoutsimpleButton.TabIndex = 4;
            this.AjoutsimpleButton.Text = "اظافة";
            this.AjoutsimpleButton.Click += new System.EventHandler(this.AjoutsimpleButton_Click);
            // 
            // modifiersimpleButton
            // 
            this.modifiersimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifiersimpleButton.Location = new System.Drawing.Point(853, 3);
            this.modifiersimpleButton.Name = "modifiersimpleButton";
            this.modifiersimpleButton.Size = new System.Drawing.Size(160, 28);
            this.modifiersimpleButton.TabIndex = 5;
            this.modifiersimpleButton.Text = "تعديل";
            this.modifiersimpleButton.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // FormJuridiqueListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJuridiqueListeForm";
            this.Text = "FormJuridiqueListeForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormeJuridiquexpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource FormeJuridiquebindingSource;
        private DevExpress.Xpo.XPCollection FormeJuridiquexpCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeFormeJuridique;
        private DevExpress.XtraGrid.Columns.GridColumn colFormeJuridique1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton SortirsimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimertoussimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimersimpleButton;
        private DevExpress.XtraEditors.SimpleButton supprimersimpleButton;
        private DevExpress.XtraEditors.SimpleButton AjoutsimpleButton;
        private DevExpress.XtraEditors.SimpleButton modifiersimpleButton;
    }
}