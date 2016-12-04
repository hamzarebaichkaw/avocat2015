namespace WindowsFormsavocat050315
{
    partial class Conseil_JuridiqueListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conseil_JuridiqueListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonModifier = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerT = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerS = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Conseil_JuridiquebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Conseil_JuridiquexpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_Conseil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode_kadhiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType_Conseil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSujet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Conseil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_fin_kadhiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_fin_rapport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmontant_restant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_dossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conseil_JuridiquebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conseil_JuridiquexpCollection)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 307);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonModifier, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAnnuler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAjouter, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerS, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonSupprimer, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 274);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 30);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // simpleButtonModifier
            // 
            this.simpleButtonModifier.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonModifier.Appearance.Options.UseFont = true;
            this.simpleButtonModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonModifier.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModifier.Image")));
            this.simpleButtonModifier.Location = new System.Drawing.Point(841, 3);
            this.simpleButtonModifier.Name = "simpleButtonModifier";
            this.simpleButtonModifier.Size = new System.Drawing.Size(158, 24);
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
            this.simpleButtonAnnuler.Size = new System.Drawing.Size(167, 24);
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
            this.simpleButtonImprimerT.Location = new System.Drawing.Point(196, 3);
            this.simpleButtonImprimerT.Name = "simpleButtonImprimerT";
            this.simpleButtonImprimerT.Size = new System.Drawing.Size(147, 24);
            this.simpleButtonImprimerT.TabIndex = 4;
            this.simpleButtonImprimerT.Text = "طباعة";
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAjouter.Appearance.Options.UseFont = true;
            this.simpleButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAjouter.Image")));
            this.simpleButtonAjouter.Location = new System.Drawing.Point(677, 3);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(158, 24);
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
            this.simpleButtonImprimerS.Location = new System.Drawing.Point(349, 3);
            this.simpleButtonImprimerS.Name = "simpleButtonImprimerS";
            this.simpleButtonImprimerS.Size = new System.Drawing.Size(158, 24);
            this.simpleButtonImprimerS.TabIndex = 3;
            this.simpleButtonImprimerS.Text = "طباعة";
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonSupprimer.Appearance.Options.UseFont = true;
            this.simpleButtonSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSupprimer.Image")));
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(513, 3);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(158, 24);
            this.simpleButtonSupprimer.TabIndex = 2;
            this.simpleButtonSupprimer.Text = "حذف";
            this.simpleButtonSupprimer.Click += new System.EventHandler(this.simpleButtonSupprimer_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.Conseil_JuridiquebindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 265);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Conseil_JuridiquebindingSource
            // 
            this.Conseil_JuridiquebindingSource.DataSource = this.Conseil_JuridiquexpCollection;
            // 
            // Conseil_JuridiquexpCollection
            // 
            this.Conseil_JuridiquexpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Conseil_Juridique);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_kadhiya,
            this.colType_Conseil,
            this.colSujet,
            this.colNom_client,
            this.colDate_Conseil,
            this.colPrix,
            this.colDate_fin_kadhiya,
            this.colDate_fin_rapport,
            this.colmontant_restant,
            this.colNum_dossier,
            this.colClient,
            this.colCode_Conseil});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCode_Conseil
            // 
            this.colCode_Conseil.Caption = "رقم الاستشارة ";
            this.colCode_Conseil.FieldName = "Code_Conseil";
            this.colCode_Conseil.Name = "colCode_Conseil";
            this.colCode_Conseil.Visible = true;
            this.colCode_Conseil.VisibleIndex = 0;
            // 
            // colClient
            // 
            this.colClient.Caption = "رقم الحريف ";
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 1;
            // 
            // colCode_kadhiya
            // 
            this.colCode_kadhiya.Caption = "رقم القضية ";
            this.colCode_kadhiya.FieldName = "Code_kadhiya";
            this.colCode_kadhiya.Name = "colCode_kadhiya";
            this.colCode_kadhiya.Visible = true;
            this.colCode_kadhiya.VisibleIndex = 2;
            // 
            // colType_Conseil
            // 
            this.colType_Conseil.Caption = "نوع  الاستشارة";
            this.colType_Conseil.FieldName = "Type_Conseil";
            this.colType_Conseil.Name = "colType_Conseil";
            this.colType_Conseil.Visible = true;
            this.colType_Conseil.VisibleIndex = 3;
            // 
            // colSujet
            // 
            this.colSujet.Caption = "الموضوع  ";
            this.colSujet.FieldName = "Sujet";
            this.colSujet.Name = "colSujet";
            this.colSujet.Visible = true;
            this.colSujet.VisibleIndex = 4;
            // 
            // colNom_client
            // 
            this.colNom_client.Caption = "أسم الحريف ";
            this.colNom_client.FieldName = "Nom_client";
            this.colNom_client.Name = "colNom_client";
            this.colNom_client.Visible = true;
            this.colNom_client.VisibleIndex = 5;
            // 
            // colDate_Conseil
            // 
            this.colDate_Conseil.Caption = "تاريخ الاستشارة ";
            this.colDate_Conseil.FieldName = "Date_Conseil";
            this.colDate_Conseil.Name = "colDate_Conseil";
            this.colDate_Conseil.Visible = true;
            this.colDate_Conseil.VisibleIndex = 6;
            // 
            // colPrix
            // 
            this.colPrix.Caption = "المبلغ ";
            this.colPrix.FieldName = "Prix";
            this.colPrix.Name = "colPrix";
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 7;
            // 
            // colDate_fin_kadhiya
            // 
            this.colDate_fin_kadhiya.Caption = "موعد القضية ";
            this.colDate_fin_kadhiya.FieldName = "Date_fin_kadhiya";
            this.colDate_fin_kadhiya.Name = "colDate_fin_kadhiya";
            this.colDate_fin_kadhiya.Visible = true;
            this.colDate_fin_kadhiya.VisibleIndex = 8;
            // 
            // colDate_fin_rapport
            // 
            this.colDate_fin_rapport.Caption = "اخر أجل لاعطى المستندة ";
            this.colDate_fin_rapport.FieldName = "Date_fin_rapport";
            this.colDate_fin_rapport.Name = "colDate_fin_rapport";
            this.colDate_fin_rapport.Visible = true;
            this.colDate_fin_rapport.VisibleIndex = 9;
            // 
            // colmontant_restant
            // 
            this.colmontant_restant.Caption = "المبلغ المتبقي";
            this.colmontant_restant.FieldName = "montant_restant";
            this.colmontant_restant.Name = "colmontant_restant";
            this.colmontant_restant.Visible = true;
            this.colmontant_restant.VisibleIndex = 10;
            // 
            // colNum_dossier
            // 
            this.colNum_dossier.Caption = "رقم الملف  ";
            this.colNum_dossier.FieldName = "Num_dossier";
            this.colNum_dossier.Name = "colNum_dossier";
            this.colNum_dossier.Visible = true;
            this.colNum_dossier.VisibleIndex = 11;
            // 
            // Conseil_JuridiqueListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conseil_JuridiqueListForm";
            this.Text = "قائمة الاستشارات";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conseil_JuridiquebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conseil_JuridiquexpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection Conseil_JuridiquexpCollection;
        private System.Windows.Forms.BindingSource Conseil_JuridiquebindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Conseil;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_kadhiya;
        private DevExpress.XtraGrid.Columns.GridColumn colType_Conseil;
        private DevExpress.XtraGrid.Columns.GridColumn colSujet;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_client;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Conseil;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_fin_kadhiya;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_fin_rapport;
        private DevExpress.XtraGrid.Columns.GridColumn colmontant_restant;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_dossier;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModifier;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAnnuler;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerT;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerS;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;

    }
}