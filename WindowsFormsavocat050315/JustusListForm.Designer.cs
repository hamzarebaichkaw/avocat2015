namespace WindowsFormsavocat050315
{
    partial class JustusListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JustusListForm));
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonModifier = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerT = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerS = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD_PALAIS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.xpCollection;
            // 
            // xpCollection
            // 
            this.xpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.PALAIS_JUSTICE);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 307);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.63849F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.59767F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69096F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69096F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69096F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69096F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonModifier, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAnnuler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAjouter, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerS, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonSupprimer, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButtonModifier
            // 
            this.simpleButtonModifier.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonModifier.Appearance.Options.UseFont = true;
            this.simpleButtonModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonModifier.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModifier.Image")));
            this.simpleButtonModifier.Location = new System.Drawing.Point(843, 3);
            this.simpleButtonModifier.Name = "simpleButtonModifier";
            this.simpleButtonModifier.Size = new System.Drawing.Size(158, 28);
            this.simpleButtonModifier.TabIndex = 0;
            this.simpleButtonModifier.Text = "تعديل";
            this.simpleButtonModifier.Click += new System.EventHandler(this.simpleButtonModifier_Click);
            // 
            // simpleButtonAnnuler
            // 
            this.simpleButtonAnnuler.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAnnuler.Appearance.Options.UseFont = true;
            this.simpleButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnnuler.Image")));
            this.simpleButtonAnnuler.Location = new System.Drawing.Point(23, 3);
            this.simpleButtonAnnuler.Name = "simpleButtonAnnuler";
            this.simpleButtonAnnuler.Size = new System.Drawing.Size(168, 28);
            this.simpleButtonAnnuler.TabIndex = 5;
            this.simpleButtonAnnuler.Text = "خورج";
            this.simpleButtonAnnuler.Click += new System.EventHandler(this.simpleButtonAnnuler_Click);
            // 
            // simpleButtonImprimerT
            // 
            this.simpleButtonImprimerT.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonImprimerT.Appearance.Options.UseFont = true;
            this.simpleButtonImprimerT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerT.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerT.Image")));
            this.simpleButtonImprimerT.Location = new System.Drawing.Point(197, 3);
            this.simpleButtonImprimerT.Name = "simpleButtonImprimerT";
            this.simpleButtonImprimerT.Size = new System.Drawing.Size(148, 28);
            this.simpleButtonImprimerT.TabIndex = 4;
            this.simpleButtonImprimerT.Text = "طباعة";
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAjouter.Appearance.Options.UseFont = true;
            this.simpleButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAjouter.Image")));
            this.simpleButtonAjouter.Location = new System.Drawing.Point(679, 3);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(158, 28);
            this.simpleButtonAjouter.TabIndex = 1;
            this.simpleButtonAjouter.Text = "اظافة";
            this.simpleButtonAjouter.Click += new System.EventHandler(this.simpleButtonAjouter_Click);
            // 
            // simpleButtonImprimerS
            // 
            this.simpleButtonImprimerS.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonImprimerS.Appearance.Options.UseFont = true;
            this.simpleButtonImprimerS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerS.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerS.Image")));
            this.simpleButtonImprimerS.Location = new System.Drawing.Point(351, 3);
            this.simpleButtonImprimerS.Name = "simpleButtonImprimerS";
            this.simpleButtonImprimerS.Size = new System.Drawing.Size(158, 28);
            this.simpleButtonImprimerS.TabIndex = 3;
            this.simpleButtonImprimerS.Text = "طباعة";
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonSupprimer.Appearance.Options.UseFont = true;
            this.simpleButtonSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSupprimer.Image")));
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(515, 3);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(158, 28);
            this.simpleButtonSupprimer.TabIndex = 2;
            this.simpleButtonSupprimer.Text = "حذف";
            this.simpleButtonSupprimer.Click += new System.EventHandler(this.simpleButtonSupprimer_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 261);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTel,
            this.colAdresse,
            this.colFax,
            this.colVille,
            this.colDescription,
            this.colEmail,
            this.colCOD_PALAIS});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTel
            // 
            this.colTel.Caption = "رقم الهاتف ";
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            this.colTel.Visible = true;
            this.colTel.VisibleIndex = 1;
            // 
            // colAdresse
            // 
            this.colAdresse.Caption = "العنون ";
            this.colAdresse.FieldName = "Adresse";
            this.colAdresse.Name = "colAdresse";
            this.colAdresse.Visible = true;
            this.colAdresse.VisibleIndex = 2;
            // 
            // colFax
            // 
            this.colFax.Caption = "الفاكس ";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 3;
            // 
            // colVille
            // 
            this.colVille.Caption = "المدينة ";
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            this.colVille.Visible = true;
            this.colVille.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "التفاصيل ";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "العنون الالكتروني ";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colCOD_PALAIS
            // 
            this.colCOD_PALAIS.Caption = "رقم المحكم ";
            this.colCOD_PALAIS.FieldName = "COD_PALAIS";
            this.colCOD_PALAIS.Name = "colCOD_PALAIS";
            this.colCOD_PALAIS.Visible = true;
            this.colCOD_PALAIS.VisibleIndex = 0;
            // 
            // JustusListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JustusListForm";
            this.Text = "قائمة المحاكم";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.Xpo.XPCollection xpCollection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModifier;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAnnuler;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerT;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerS;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_PALAIS;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
    }
}