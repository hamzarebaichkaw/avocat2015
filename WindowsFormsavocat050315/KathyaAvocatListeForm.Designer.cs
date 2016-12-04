namespace WindowsFormsavocat050315
{
    partial class KathyaAvocatListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KathyaAvocatListeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.KathyaAvocatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KathyaAvocatXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_ka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLieu_cin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_cin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD_AVOCAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerToutSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerSelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SupprimerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AjouterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ModifierSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.KathyaAvocatBindingSource;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // KathyaAvocatBindingSource
            // 
            this.KathyaAvocatBindingSource.DataSource = this.KathyaAvocatXpCollection;
            // 
            // KathyaAvocatXpCollection
            // 
            this.KathyaAvocatXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.AVOCAT_CONTRE);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_ka,
            this.colNom,
            this.colLieu_cin,
            this.colGsm,
            this.colFax,
            this.colEmail,
            this.colDescription,
            this.colDate_cin,
            this.colCOD_AVOCAT,
            this.colCin,
            this.colAdresse,
            this.colTel,
            this.colVille});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCode_ka
            // 
            resources.ApplyResources(this.colCode_ka, "colCode_ka");
            this.colCode_ka.FieldName = "Code_ka";
            this.colCode_ka.Name = "colCode_ka";
            // 
            // colNom
            // 
            resources.ApplyResources(this.colNom, "colNom");
            this.colNom.FieldName = "Nom";
            this.colNom.Name = "colNom";
            // 
            // colLieu_cin
            // 
            resources.ApplyResources(this.colLieu_cin, "colLieu_cin");
            this.colLieu_cin.FieldName = "Lieu_cin";
            this.colLieu_cin.Name = "colLieu_cin";
            // 
            // colGsm
            // 
            resources.ApplyResources(this.colGsm, "colGsm");
            this.colGsm.FieldName = "Gsm";
            this.colGsm.Name = "colGsm";
            // 
            // colFax
            // 
            resources.ApplyResources(this.colFax, "colFax");
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            // 
            // colEmail
            // 
            resources.ApplyResources(this.colEmail, "colEmail");
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colDescription
            // 
            resources.ApplyResources(this.colDescription, "colDescription");
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colDate_cin
            // 
            resources.ApplyResources(this.colDate_cin, "colDate_cin");
            this.colDate_cin.FieldName = "Date_cin";
            this.colDate_cin.Name = "colDate_cin";
            // 
            // colCOD_AVOCAT
            // 
            resources.ApplyResources(this.colCOD_AVOCAT, "colCOD_AVOCAT");
            this.colCOD_AVOCAT.FieldName = "COD_AVOCAT";
            this.colCOD_AVOCAT.Name = "colCOD_AVOCAT";
            // 
            // colCin
            // 
            resources.ApplyResources(this.colCin, "colCin");
            this.colCin.FieldName = "Cin";
            this.colCin.Name = "colCin";
            // 
            // colAdresse
            // 
            resources.ApplyResources(this.colAdresse, "colAdresse");
            this.colAdresse.FieldName = "Adresse";
            this.colAdresse.Name = "colAdresse";
            // 
            // colTel
            // 
            resources.ApplyResources(this.colTel, "colTel");
            this.colTel.FieldName = "Tel";
            this.colTel.Name = "colTel";
            // 
            // colVille
            // 
            resources.ApplyResources(this.colVille, "colVille");
            this.colVille.FieldName = "Ville";
            this.colVille.Name = "colVille";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerToutSimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerSelSimpleButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.SupprimerSimpleButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.AjouterSimpleButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifierSimpleButton, 5, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // AnnulerSimpleButton
            // 
            resources.ApplyResources(this.AnnulerSimpleButton, "AnnulerSimpleButton");
            this.AnnulerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AnnulerSimpleButton.Image")));
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // ImprimerToutSimpleButton
            // 
            resources.ApplyResources(this.ImprimerToutSimpleButton, "ImprimerToutSimpleButton");
            this.ImprimerToutSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerToutSimpleButton.Image")));
            this.ImprimerToutSimpleButton.Name = "ImprimerToutSimpleButton";
            // 
            // ImprimerSelSimpleButton
            // 
            resources.ApplyResources(this.ImprimerSelSimpleButton, "ImprimerSelSimpleButton");
            this.ImprimerSelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerSelSimpleButton.Image")));
            this.ImprimerSelSimpleButton.Name = "ImprimerSelSimpleButton";
            // 
            // SupprimerSimpleButton
            // 
            resources.ApplyResources(this.SupprimerSimpleButton, "SupprimerSimpleButton");
            this.SupprimerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerSimpleButton.Image")));
            this.SupprimerSimpleButton.Name = "SupprimerSimpleButton";
            this.SupprimerSimpleButton.Click += new System.EventHandler(this.SupprimerSimpleButton_Click);
            // 
            // AjouterSimpleButton
            // 
            resources.ApplyResources(this.AjouterSimpleButton, "AjouterSimpleButton");
            this.AjouterSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AjouterSimpleButton.Image")));
            this.AjouterSimpleButton.Name = "AjouterSimpleButton";
            this.AjouterSimpleButton.UseWaitCursor = true;
            this.AjouterSimpleButton.Click += new System.EventHandler(this.AjouterSimpleButton_Click);
            // 
            // ModifierSimpleButton
            // 
            resources.ApplyResources(this.ModifierSimpleButton, "ModifierSimpleButton");
            this.ModifierSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifierSimpleButton.Image")));
            this.ModifierSimpleButton.Name = "ModifierSimpleButton";
            this.ModifierSimpleButton.Click += new System.EventHandler(this.ModifierSimpleButton_Click);
            // 
            // KathyaAvocatListeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KathyaAvocatListeForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KathyaAvocatXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection KathyaAvocatXpCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource KathyaAvocatBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerToutSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerSelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SupprimerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AjouterSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ModifierSimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_ka;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colLieu_cin;
        private DevExpress.XtraGrid.Columns.GridColumn colGsm;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_cin;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_AVOCAT;
        private DevExpress.XtraGrid.Columns.GridColumn colCin;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn colTel;
        private DevExpress.XtraGrid.Columns.GridColumn colVille;
    }
}