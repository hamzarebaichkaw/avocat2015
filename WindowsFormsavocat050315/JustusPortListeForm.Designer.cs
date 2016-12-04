namespace WindowsFormsavocat050315
{
    partial class JustusPortListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JustusPortListeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.JustusPortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JustusPortXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_ka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_cin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLieu_cin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD_Justice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonImprimer = new DevExpress.XtraEditors.SimpleButton();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerS = new DevExpress.XtraEditors.SimpleButton();
            this.SupprimerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AjouterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ModifierSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JustusPortBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JustusPortXpCollection)).BeginInit();
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
            this.gridControl1.DataSource = this.JustusPortBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.Size = new System.Drawing.Size(1042, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // JustusPortBindingSource
            // 
            this.JustusPortBindingSource.DataSource = this.JustusPortXpCollection;
            // 
            // JustusPortXpCollection
            // 
            this.JustusPortXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Justice_Port);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_ka,
            this.colDescription,
            this.colTel,
            this.colGsm,
            this.colFax,
            this.colVille,
            this.colAdresse,
            this.colEmail,
            this.colDate_cin,
            this.colLieu_cin,
            this.colCin,
            this.colNom,
            this.colCOD_Justice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCode_ka
            // 
            this.colCode_ka.Caption = "رقم القضية ";
            this.colCode_ka.FieldName = "Code_ka";
            this.colCode_ka.Name = "colCode_ka";
            this.colCode_ka.Visible = true;
            this.colCode_ka.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "التفاصيل";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colTel
            // 
            this.colTel.Caption = "الهاتف القار";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 8;
            // 
            // colGsm
            // 
            this.colGsm.Caption = "الهاتف الجوال";
            this.colGsm.FieldName = "Gsm";
            this.colGsm.Name = "colGsm";
            this.colGsm.Visible = true;
            this.colGsm.VisibleIndex = 7;
            // 
            // colFax
            // 
            this.colFax.Caption = "الفاكس";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 6;
            // 
            // colVille
            // 
            this.colVille.Caption = "المدينة ";
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 9;
            // 
            // colAdresse
            // 
            this.colAdresse.Caption = "العنوان";
            this.colAdresse.FieldName = "Adresse";
            this.colAdresse.Name = "colAdresse";
            this.colAdresse.Visible = true;
            this.colAdresse.VisibleIndex = 10;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "العنوان الالكتروني";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 2;
            // 
            // colDate_cin
            // 
            this.colDate_cin.Caption = "تاريخ بطاقة تعريف الوطنية";
            this.colDate_cin.FieldName = "Date_cin";
            this.colDate_cin.Name = "colDate_cin";
            this.colDate_cin.Visible = true;
            this.colDate_cin.VisibleIndex = 3;
            // 
            // colLieu_cin
            // 
            this.colLieu_cin.Caption = "مكان بطاقة تعريف الوطنية";
            this.colLieu_cin.FieldName = "Lieu_cin";
            this.colLieu_cin.Name = "colLieu_cin";
            this.colLieu_cin.Visible = true;
            this.colLieu_cin.VisibleIndex = 4;
            // 
            // colCin
            // 
            this.colCin.Caption = "رقم بطاقة تعريف الوطنية";
            this.colCin.FieldName = "Cin";
            this.colCin.Name = "colCin";
            this.colCin.Visible = true;
            this.colCin.VisibleIndex = 5;
            // 
            // colNom
            // 
            this.colNom.Caption = "أسم";
            this.colNom.FieldName = "Nom";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 11;
            // 
            // colCOD_Justice
            // 
            this.colCOD_Justice.Caption = "رامز عادل التنفيذ ";
            this.colCOD_Justice.FieldName = "COD_Justice";
            this.colCOD_Justice.Name = "colCOD_Justice";
            this.colCOD_Justice.Visible = true;
            this.colCOD_Justice.VisibleIndex = 12;
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
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimer, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerS, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.SupprimerSimpleButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.AjouterSimpleButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifierSimpleButton, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButtonImprimer
            // 
            this.simpleButtonImprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimer.Image")));
            this.simpleButtonImprimer.Location = new System.Drawing.Point(189, 3);
            this.simpleButtonImprimer.Name = "simpleButtonImprimer";
            this.simpleButtonImprimer.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonImprimer.TabIndex = 1;
            this.simpleButtonImprimer.Text = "طباعة";
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
            // simpleButtonImprimerS
            // 
            this.simpleButtonImprimerS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerS.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerS.Image")));
            this.simpleButtonImprimerS.Location = new System.Drawing.Point(355, 3);
            this.simpleButtonImprimerS.Name = "simpleButtonImprimerS";
            this.simpleButtonImprimerS.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonImprimerS.TabIndex = 2;
            this.simpleButtonImprimerS.Text = "طباعة";
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
            this.AjouterSimpleButton.Location = new System.Drawing.Point(853, 3);
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
            this.ModifierSimpleButton.Location = new System.Drawing.Point(687, 3);
            this.ModifierSimpleButton.Name = "ModifierSimpleButton";
            this.ModifierSimpleButton.Size = new System.Drawing.Size(160, 28);
            this.ModifierSimpleButton.TabIndex = 5;
            this.ModifierSimpleButton.Text = "تعديل";
            this.ModifierSimpleButton.Click += new System.EventHandler(this.ModifierSimpleButton_Click);
            // 
            // JustusPortListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JustusPortListeForm";
            this.Text = "قائمة عدول التنفيذ";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JustusPortBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JustusPortXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection JustusPortXpCollection;
        private System.Windows.Forms.BindingSource JustusPortBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_Justice;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colGsm;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colCin;
        private DevExpress.XtraGrid.Columns.GridColumn colLieu_cin;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_cin;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_ka;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimer;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerS;
        private DevExpress.XtraEditors.SimpleButton SupprimerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AjouterSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ModifierSimpleButton;
    }
}