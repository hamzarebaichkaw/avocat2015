using System.Runtime.Serialization;
namespace WindowsFormsavocat050315
{
    partial class Type_Payement_list_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Type_Payement_list_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Type_PayementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Type_PayementXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colType_Payement1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerToutSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerSelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SupprimersimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AjouterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ModifierSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.gridControl1.DataSource = this.Type_PayementBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Type_PayementBindingSource
            // 
            this.Type_PayementBindingSource.DataSource = this.Type_PayementXpCollection;
            // 
            // Type_PayementXpCollection
            // 
            this.Type_PayementXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Type_Payement);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colType_Payement1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colType_Payement1
            // 
            this.colType_Payement1.Caption = "طريقة الدفع";
            this.colType_Payement1.FieldName = "Type_Payement1";
            this.colType_Payement1.Name = "colType_Payement1";
            this.colType_Payement1.Visible = true;
            this.colType_Payement1.VisibleIndex = 0;
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
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerToutSimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerSelSimpleButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.SupprimersimpleButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.AjouterSimpleButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifierSimpleButton, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AnnulerSimpleButton
            // 
            this.AnnulerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnulerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AnnulerSimpleButton.Image")));
            this.AnnulerSimpleButton.Location = new System.Drawing.Point(23, 3);
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.AnnulerSimpleButton.TabIndex = 0;
            this.AnnulerSimpleButton.Text = "خورج";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // ImprimerToutSimpleButton
            // 
            this.ImprimerToutSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimerToutSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerToutSimpleButton.Image")));
            this.ImprimerToutSimpleButton.Location = new System.Drawing.Point(189, 3);
            this.ImprimerToutSimpleButton.Name = "ImprimerToutSimpleButton";
            this.ImprimerToutSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.ImprimerToutSimpleButton.TabIndex = 1;
            this.ImprimerToutSimpleButton.Text = "طباعة";
            // 
            // ImprimerSelSimpleButton
            // 
            this.ImprimerSelSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimerSelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerSelSimpleButton.Image")));
            this.ImprimerSelSimpleButton.Location = new System.Drawing.Point(355, 3);
            this.ImprimerSelSimpleButton.Name = "ImprimerSelSimpleButton";
            this.ImprimerSelSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.ImprimerSelSimpleButton.TabIndex = 2;
            this.ImprimerSelSimpleButton.Text = "طباعة";
            // 
            // SupprimersimpleButton
            // 
            this.SupprimersimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupprimersimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimersimpleButton.Image")));
            this.SupprimersimpleButton.Location = new System.Drawing.Point(521, 3);
            this.SupprimersimpleButton.Name = "SupprimersimpleButton";
            this.SupprimersimpleButton.Size = new System.Drawing.Size(160, 28);
            this.SupprimersimpleButton.TabIndex = 3;
            this.SupprimersimpleButton.Text = "حذف";
            this.SupprimersimpleButton.Click += new System.EventHandler(this.SupprimersimpleButton_Click);
            // 
            // AjouterSimpleButton
            // 
            this.AjouterSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AjouterSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AjouterSimpleButton.Image")));
            this.AjouterSimpleButton.Location = new System.Drawing.Point(687, 3);
            this.AjouterSimpleButton.Name = "AjouterSimpleButton";
            this.AjouterSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.AjouterSimpleButton.TabIndex = 4;
            this.AjouterSimpleButton.Text = "اظافة";
            this.AjouterSimpleButton.Click += new System.EventHandler(this.AjouterSimpleButton_Click);
            // 
            // ModifierSimpleButton
            // 
            this.ModifierSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifierSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifierSimpleButton.Image")));
            this.ModifierSimpleButton.Location = new System.Drawing.Point(853, 3);
            this.ModifierSimpleButton.Name = "ModifierSimpleButton";
            this.ModifierSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.ModifierSimpleButton.TabIndex = 5;
            this.ModifierSimpleButton.Text = "تعديل";
            this.ModifierSimpleButton.Click += new System.EventHandler(this.ModifierSimpleButton_Click);
            // 
            // Type_Payement_list_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Type_Payement_list_Form";
            this.Text = "Type_Payement_list_Form";
            this.Load += new System.EventHandler(this.Type_Payement_list_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Type_PayementXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection Type_PayementXpCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource Type_PayementBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colType_Payement1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerToutSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerSelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SupprimersimpleButton;
        private DevExpress.XtraEditors.SimpleButton AjouterSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ModifierSimpleButton;
    }
}