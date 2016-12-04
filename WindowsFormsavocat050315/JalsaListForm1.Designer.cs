namespace WindowsFormsavocat050315
{
    partial class JalsaListForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JalsaListForm1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.JalsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JalsaXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate_Prochaine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD_PALAIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhokom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode_Jalsa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButtonImprimerS = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SupprimerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AjouterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ModifierSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaXpCollection)).BeginInit();
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
            this.gridControl1.DataSource = this.JalsaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // JalsaBindingSource
            // 
            this.JalsaBindingSource.DataSource = this.JalsaXpCollection;
            // 
            // JalsaXpCollection
            // 
            this.JalsaXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Jalsa);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate_Prochaine,
            this.colCOD_PALAIS,
            this.colDescription,
            this.gridColumn1,
            this.colhokom,
            this.gridColumn2,
            this.colDate,
            this.colCode_Jalsa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDate_Prochaine
            // 
            this.colDate_Prochaine.Caption = "تاريخ المقبل لللجلسة";
            this.colDate_Prochaine.FieldName = "Date_Prochaine";
            this.colDate_Prochaine.Name = "colDate_Prochaine";
            this.colDate_Prochaine.Visible = true;
            this.colDate_Prochaine.VisibleIndex = 2;
            // 
            // colCOD_PALAIS
            // 
            this.colCOD_PALAIS.Caption = "رقم المحكم ";
            this.colCOD_PALAIS.FieldName = "COD_PALAIS";
            this.colCOD_PALAIS.Name = "colCOD_PALAIS";
            this.colCOD_PALAIS.Visible = true;
            this.colCOD_PALAIS.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "التفاصيل";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "رقم القضية ";
            this.gridColumn1.FieldName = "Code_ka!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // colhokom
            // 
            this.colhokom.Caption = "الحكم";
            this.colhokom.FieldName = "hokom";
            this.colhokom.Name = "colhokom";
            this.colhokom.Visible = true;
            this.colhokom.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "رمز القضية";
            this.gridColumn2.FieldName = "Code_ka!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            // 
            // colDate
            // 
            this.colDate.Caption = "التاريخ الجلسة";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colCode_Jalsa
            // 
            this.colCode_Jalsa.Caption = "رمز الجلسة";
            this.colCode_Jalsa.FieldName = "Code_Jalsa";
            this.colCode_Jalsa.Name = "colCode_Jalsa";
            this.colCode_Jalsa.Visible = true;
            this.colCode_Jalsa.VisibleIndex = 0;
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
            this.tableLayoutPanel2.Controls.Add(this.SimpleButtonImprimerS, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerSimpleButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.SupprimerSimpleButton, 4, 0);
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
            // SimpleButtonImprimerS
            // 
            this.SimpleButtonImprimerS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleButtonImprimerS.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButtonImprimerS.Image")));
            this.SimpleButtonImprimerS.Location = new System.Drawing.Point(189, 3);
            this.SimpleButtonImprimerS.Name = "SimpleButtonImprimerS";
            this.SimpleButtonImprimerS.Size = new System.Drawing.Size(160, 28);
            this.SimpleButtonImprimerS.TabIndex = 1;
            this.SimpleButtonImprimerS.Text = "طباعة";
            // 
            // ImprimerSimpleButton
            // 
            this.ImprimerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerSimpleButton.Image")));
            this.ImprimerSimpleButton.Location = new System.Drawing.Point(355, 3);
            this.ImprimerSimpleButton.Name = "ImprimerSimpleButton";
            this.ImprimerSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.ImprimerSimpleButton.TabIndex = 2;
            this.ImprimerSimpleButton.Text = "طباعة";
            // 
            // SupprimerSimpleButton
            // 
            this.SupprimerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupprimerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerSimpleButton.Image")));
            this.SupprimerSimpleButton.Location = new System.Drawing.Point(521, 3);
            this.SupprimerSimpleButton.Name = "SupprimerSimpleButton";
            this.SupprimerSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.SupprimerSimpleButton.TabIndex = 3;
            this.SupprimerSimpleButton.Text = "حذف";
            this.SupprimerSimpleButton.Click += new System.EventHandler(this.SupprimerSimpleButton_Click);
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
            // JalsaListForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JalsaListForm1";
            this.Text = "قائمة الجلسات";
            this.Load += new System.EventHandler(this.JalsaListForm1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JalsaXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection JalsaXpCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource JalsaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Jalsa;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Prochaine;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_PALAIS;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colhokom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SimpleButtonImprimerS;
        private DevExpress.XtraEditors.SimpleButton ImprimerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SupprimerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AjouterSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ModifierSimpleButton;
    }
}