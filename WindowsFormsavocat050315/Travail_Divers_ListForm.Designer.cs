namespace WindowsFormsavocat050315
{
    partial class Travail_Divers_ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travail_Divers_ListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonModifier = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerT = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerS = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_travail_divers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType_travail_divers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSujet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_travail_divers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_dossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
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
            this.simpleButtonModifier.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonModifier.Appearance.Options.UseFont = true;
            this.simpleButtonModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonModifier.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModifier.Image")));
            this.simpleButtonModifier.Location = new System.Drawing.Point(848, 3);
            this.simpleButtonModifier.Name = "simpleButtonModifier";
            this.simpleButtonModifier.Size = new System.Drawing.Size(159, 28);
            this.simpleButtonModifier.TabIndex = 0;
            this.simpleButtonModifier.Text = "تعديل";
            // 
            // simpleButtonAnnuler
            // 
            this.simpleButtonAnnuler.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAnnuler.Appearance.Options.UseFont = true;
            this.simpleButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnnuler.Image")));
            this.simpleButtonAnnuler.Location = new System.Drawing.Point(23, 3);
            this.simpleButtonAnnuler.Name = "simpleButtonAnnuler";
            this.simpleButtonAnnuler.Size = new System.Drawing.Size(169, 28);
            this.simpleButtonAnnuler.TabIndex = 5;
            this.simpleButtonAnnuler.Text = "خورج";
            // 
            // simpleButtonImprimerT
            // 
            this.simpleButtonImprimerT.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonImprimerT.Appearance.Options.UseFont = true;
            this.simpleButtonImprimerT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerT.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerT.Image")));
            this.simpleButtonImprimerT.Location = new System.Drawing.Point(198, 3);
            this.simpleButtonImprimerT.Name = "simpleButtonImprimerT";
            this.simpleButtonImprimerT.Size = new System.Drawing.Size(149, 28);
            this.simpleButtonImprimerT.TabIndex = 4;
            this.simpleButtonImprimerT.Text = "طباعة";
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAjouter.Appearance.Options.UseFont = true;
            this.simpleButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAjouter.Image")));
            this.simpleButtonAjouter.Location = new System.Drawing.Point(683, 3);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(159, 28);
            this.simpleButtonAjouter.TabIndex = 1;
            this.simpleButtonAjouter.Text = "اظافة";
            // 
            // simpleButtonImprimerS
            // 
            this.simpleButtonImprimerS.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonImprimerS.Appearance.Options.UseFont = true;
            this.simpleButtonImprimerS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerS.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerS.Image")));
            this.simpleButtonImprimerS.Location = new System.Drawing.Point(353, 3);
            this.simpleButtonImprimerS.Name = "simpleButtonImprimerS";
            this.simpleButtonImprimerS.Size = new System.Drawing.Size(159, 28);
            this.simpleButtonImprimerS.TabIndex = 3;
            this.simpleButtonImprimerS.Text = "طباعة";
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonSupprimer.Appearance.Options.UseFont = true;
            this.simpleButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSupprimer.Image")));
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(518, 3);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(101, 28);
            this.simpleButtonSupprimer.TabIndex = 2;
            this.simpleButtonSupprimer.Text = "حذف";
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
            // bindingSource
            // 
            this.bindingSource.DataSource = this.xpCollection;
            // 
            // xpCollection
            // 
            this.xpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Travail_Divers);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_travail_divers,
            this.colClient,
            this.colNom_client,
            this.colType_travail_divers,
            this.colSujet,
            this.colDate_travail_divers,
            this.colPrix,
            this.colNom_dossier});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCode_travail_divers
            // 
            this.colCode_travail_divers.Caption = "رقم الأعمال المتفرقة";
            this.colCode_travail_divers.FieldName = "Code_travail_divers";
            this.colCode_travail_divers.Name = "colCode_travail_divers";
            this.colCode_travail_divers.Visible = true;
            this.colCode_travail_divers.VisibleIndex = 7;
            // 
            // colClient
            // 
            this.colClient.Caption = " رقم  الحريف ";
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 4;
            // 
            // colNom_client
            // 
            this.colNom_client.Caption = "الحريف ";
            this.colNom_client.FieldName = "Nom_client";
            this.colNom_client.Name = "colNom_client";
            this.colNom_client.Visible = true;
            this.colNom_client.VisibleIndex = 5;
            // 
            // colType_travail_divers
            // 
            this.colType_travail_divers.Caption = "نوع  الأعمال المتفرقة";
            this.colType_travail_divers.FieldName = "Type_travail_divers";
            this.colType_travail_divers.Name = "colType_travail_divers";
            this.colType_travail_divers.Visible = true;
            this.colType_travail_divers.VisibleIndex = 6;
            // 
            // colSujet
            // 
            this.colSujet.Caption = "الموضوع ";
            this.colSujet.FieldName = "Sujet";
            this.colSujet.Name = "colSujet";
            this.colSujet.Visible = true;
            this.colSujet.VisibleIndex = 3;
            // 
            // colDate_travail_divers
            // 
            this.colDate_travail_divers.Caption = "تاريخ الأعمال المتفرقة";
            this.colDate_travail_divers.FieldName = "Date_travail_divers";
            this.colDate_travail_divers.Name = "colDate_travail_divers";
            this.colDate_travail_divers.Visible = true;
            this.colDate_travail_divers.VisibleIndex = 2;
            // 
            // colPrix
            // 
            this.colPrix.Caption = "المبلغ ";
            this.colPrix.FieldName = "Prix";
            this.colPrix.Name = "colPrix";
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 0;
            // 
            // colNom_dossier
            // 
            this.colNom_dossier.Caption = "رقم الملف ";
            this.colNom_dossier.FieldName = "Nom_dossier";
            this.colNom_dossier.Name = "colNom_dossier";
            this.colNom_dossier.Visible = true;
            this.colNom_dossier.VisibleIndex = 1;
            // 
            // Travail_Divers_ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Travail_Divers_ListForm";
            this.Text = "قائمة الأعمال المتفرقة";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModifier;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAnnuler;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerT;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerS;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.Xpo.XPCollection xpCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_travail_divers;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_client;
        private DevExpress.XtraGrid.Columns.GridColumn colType_travail_divers;
        private DevExpress.XtraGrid.Columns.GridColumn colSujet;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_travail_divers;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_dossier;

    }
}