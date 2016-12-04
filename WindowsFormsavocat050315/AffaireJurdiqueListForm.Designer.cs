namespace WindowsFormsavocat050315
{
    partial class AffaireJurdiqueListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffaireJurdiqueListForm));
            this.kadeya_xpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.kadeya_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerToutSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerSelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SupprimerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ModifierSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AjouterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_kadhiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_dossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmplacement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient_Contre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSujet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType_ka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Debut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_dossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coletat_reglement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_fin_rapport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemplacement_doss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhokom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfrais_juridique = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kadeya_xpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadeya_bindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kadeya_xpCollection
            // 
            this.kadeya_xpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Kadhiya);
            // 
            // kadeya_bindingSource
            // 
            this.kadeya_bindingSource.DataSource = this.kadeya_xpCollection;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1058, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.AjouterSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifierSimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerToutSimpleButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.SupprimerSimpleButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerSelSimpleButton, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 326);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1052, 30);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // AnnulerSimpleButton
            // 
            this.AnnulerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnulerSimpleButton.Image = global::WindowsFormsavocat050315.Properties.Resources.ordinateur_eteint_plusaaa1;
            this.AnnulerSimpleButton.Location = new System.Drawing.Point(135, 3);
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Size = new System.Drawing.Size(143, 24);
            this.AnnulerSimpleButton.TabIndex = 0;
            this.AnnulerSimpleButton.Text = "خورج";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // ImprimerToutSimpleButton
            // 
            this.ImprimerToutSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimerToutSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerToutSimpleButton.Image")));
            this.ImprimerToutSimpleButton.Location = new System.Drawing.Point(284, 3);
            this.ImprimerToutSimpleButton.Name = "ImprimerToutSimpleButton";
            this.ImprimerToutSimpleButton.Size = new System.Drawing.Size(143, 24);
            this.ImprimerToutSimpleButton.TabIndex = 1;
            this.ImprimerToutSimpleButton.Text = "طباعة";
            // 
            // ImprimerSelSimpleButton
            // 
            this.ImprimerSelSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimerSelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerSelSimpleButton.Image")));
            this.ImprimerSelSimpleButton.Location = new System.Drawing.Point(433, 3);
            this.ImprimerSelSimpleButton.Name = "ImprimerSelSimpleButton";
            this.ImprimerSelSimpleButton.Size = new System.Drawing.Size(143, 24);
            this.ImprimerSelSimpleButton.TabIndex = 2;
            this.ImprimerSelSimpleButton.Text = "طباعة";
            this.ImprimerSelSimpleButton.Click += new System.EventHandler(this.ImprimerSelSimpleButton_Click);
            // 
            // SupprimerSimpleButton
            // 
            this.SupprimerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupprimerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerSimpleButton.Image")));
            this.SupprimerSimpleButton.Location = new System.Drawing.Point(582, 3);
            this.SupprimerSimpleButton.Name = "SupprimerSimpleButton";
            this.SupprimerSimpleButton.Size = new System.Drawing.Size(143, 24);
            this.SupprimerSimpleButton.TabIndex = 3;
            this.SupprimerSimpleButton.Text = "حذف";
            this.SupprimerSimpleButton.Click += new System.EventHandler(this.SupprimerSimpleButton_Click);
            // 
            // ModifierSimpleButton
            // 
            this.ModifierSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifierSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifierSimpleButton.Image")));
            this.ModifierSimpleButton.Location = new System.Drawing.Point(731, 3);
            this.ModifierSimpleButton.Name = "ModifierSimpleButton";
            this.ModifierSimpleButton.Size = new System.Drawing.Size(143, 24);
            this.ModifierSimpleButton.TabIndex = 5;
            this.ModifierSimpleButton.Text = "تعديل";
            this.ModifierSimpleButton.Click += new System.EventHandler(this.ModifierSimpleButton_Click);
            // 
            // AjouterSimpleButton
            // 
            this.AjouterSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AjouterSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AjouterSimpleButton.Image")));
            this.AjouterSimpleButton.Location = new System.Drawing.Point(880, 3);
            this.AjouterSimpleButton.Name = "AjouterSimpleButton";
            this.AjouterSimpleButton.Size = new System.Drawing.Size(143, 24);
            this.AjouterSimpleButton.TabIndex = 4;
            this.AjouterSimpleButton.Text = "اظافة";
            this.AjouterSimpleButton.UseWaitCursor = true;
            this.AjouterSimpleButton.Click += new System.EventHandler(this.AjouterSimpleButton_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kadeya_bindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1052, 317);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_kadhiya,
            this.colNum_dossier,
            this.colEmplacement,
            this.colClient,
            this.colClient_Contre,
            this.colSujet,
            this.colType_ka,
            this.colDate_Debut,
            this.colDate_Fin,
            this.colPrix,
            this.colNom_dossier,
            this.coletat_reglement,
            this.colDate_fin_rapport,
            this.colemplacement_doss,
            this.colhokom,
            this.colfrais_juridique});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.Text;
            this.gridView1.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gridView1.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.Default;
            // 
            // colCode_kadhiya
            // 
            this.colCode_kadhiya.Caption = "رمز القضية";
            this.colCode_kadhiya.FieldName = "Code_kadhiya";
            this.colCode_kadhiya.Name = "colCode_kadhiya";
            this.colCode_kadhiya.Visible = true;
            this.colCode_kadhiya.VisibleIndex = 15;
            this.colCode_kadhiya.Width = 86;
            // 
            // colNum_dossier
            // 
            this.colNum_dossier.Caption = "رقم الملف ";
            this.colNum_dossier.FieldName = "Num_dossier";
            this.colNum_dossier.Name = "colNum_dossier";
            this.colNum_dossier.Visible = true;
            this.colNum_dossier.VisibleIndex = 9;
            this.colNum_dossier.Width = 61;
            // 
            // colEmplacement
            // 
            this.colEmplacement.FieldName = "موقع";
            this.colEmplacement.Name = "colEmplacement";
            this.colEmplacement.Visible = true;
            this.colEmplacement.VisibleIndex = 1;
            this.colEmplacement.Width = 61;
            // 
            // colClient
            // 
            this.colClient.Caption = "الحريف";
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 5;
            this.colClient.Width = 61;
            // 
            // colClient_Contre
            // 
            this.colClient_Contre.FieldName = "الخصم ";
            this.colClient_Contre.Name = "colClient_Contre";
            this.colClient_Contre.Visible = true;
            this.colClient_Contre.VisibleIndex = 4;
            this.colClient_Contre.Width = 61;
            // 
            // colSujet
            // 
            this.colSujet.Caption = "الموضوع   ";
            this.colSujet.FieldName = "Sujet";
            this.colSujet.Name = "colSujet";
            this.colSujet.Visible = true;
            this.colSujet.VisibleIndex = 13;
            this.colSujet.Width = 61;
            // 
            // colType_ka
            // 
            this.colType_ka.Caption = "نوع القضية ";
            this.colType_ka.FieldName = "Type_ka";
            this.colType_ka.Name = "colType_ka";
            this.colType_ka.Visible = true;
            this.colType_ka.VisibleIndex = 14;
            this.colType_ka.Width = 61;
            // 
            // colDate_Debut
            // 
            this.colDate_Debut.Caption = "تاريخ بداية";
            this.colDate_Debut.FieldName = "Date_Debut";
            this.colDate_Debut.Name = "colDate_Debut";
            this.colDate_Debut.Visible = true;
            this.colDate_Debut.VisibleIndex = 11;
            this.colDate_Debut.Width = 61;
            // 
            // colDate_Fin
            // 
            this.colDate_Fin.Caption = "تاريخ انتهاء";
            this.colDate_Fin.FieldName = "Date_Fin";
            this.colDate_Fin.Name = "colDate_Fin";
            this.colDate_Fin.Visible = true;
            this.colDate_Fin.VisibleIndex = 10;
            this.colDate_Fin.Width = 61;
            // 
            // colPrix
            // 
            this.colPrix.Caption = "المبلغ";
            this.colPrix.FieldName = "Prix";
            this.colPrix.Name = "colPrix";
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 3;
            this.colPrix.Width = 61;
            // 
            // colNom_dossier
            // 
            this.colNom_dossier.Caption = "إسم الملف ";
            this.colNom_dossier.FieldName = "Nom_dossier";
            this.colNom_dossier.Name = "colNom_dossier";
            this.colNom_dossier.Visible = true;
            this.colNom_dossier.VisibleIndex = 8;
            this.colNom_dossier.Width = 61;
            // 
            // coletat_reglement
            // 
            this.coletat_reglement.Caption = "حالة الدفع ";
            this.coletat_reglement.FieldName = "etat_reglement";
            this.coletat_reglement.Name = "coletat_reglement";
            this.coletat_reglement.Visible = true;
            this.coletat_reglement.VisibleIndex = 0;
            this.coletat_reglement.Width = 61;
            // 
            // colDate_fin_rapport
            // 
            this.colDate_fin_rapport.Caption = "تاريخ انتهاء تقرير";
            this.colDate_fin_rapport.FieldName = "Date_fin_rapport";
            this.colDate_fin_rapport.Name = "colDate_fin_rapport";
            this.colDate_fin_rapport.Visible = true;
            this.colDate_fin_rapport.VisibleIndex = 6;
            this.colDate_fin_rapport.Width = 61;
            // 
            // colemplacement_doss
            // 
            this.colemplacement_doss.Caption = "موقع الملف";
            this.colemplacement_doss.FieldName = "emplacement_doss";
            this.colemplacement_doss.Name = "colemplacement_doss";
            this.colemplacement_doss.Visible = true;
            this.colemplacement_doss.VisibleIndex = 7;
            this.colemplacement_doss.Width = 61;
            // 
            // colhokom
            // 
            this.colhokom.Caption = "الحكم  ";
            this.colhokom.FieldName = "hokom";
            this.colhokom.Name = "colhokom";
            this.colhokom.Visible = true;
            this.colhokom.VisibleIndex = 12;
            this.colhokom.Width = 61;
            // 
            // colfrais_juridique
            // 
            this.colfrais_juridique.FieldName = "النفقات القانونية";
            this.colfrais_juridique.Name = "colfrais_juridique";
            this.colfrais_juridique.Visible = true;
            this.colfrais_juridique.VisibleIndex = 2;
            this.colfrais_juridique.Width = 73;
            // 
            // AffaireJurdiqueListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 359);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AffaireJurdiqueListForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "قائمة القضايا";
            ((System.ComponentModel.ISupportInitialize)(this.kadeya_xpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadeya_bindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.XPCollection kadeya_xpCollection;
        private System.Windows.Forms.BindingSource kadeya_bindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_kadhiya;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_dossier;
        private DevExpress.XtraGrid.Columns.GridColumn colEmplacement;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colClient_Contre;
        private DevExpress.XtraGrid.Columns.GridColumn colSujet;
        private DevExpress.XtraGrid.Columns.GridColumn colType_ka;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Debut;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Fin;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_dossier;
        private DevExpress.XtraGrid.Columns.GridColumn coletat_reglement;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_fin_rapport;
        private DevExpress.XtraGrid.Columns.GridColumn colemplacement_doss;
        private DevExpress.XtraGrid.Columns.GridColumn colhokom;
        private DevExpress.XtraGrid.Columns.GridColumn colfrais_juridique;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerToutSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerSelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SupprimerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AjouterSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ModifierSimpleButton;
    }
}