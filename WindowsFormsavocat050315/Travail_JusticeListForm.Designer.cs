namespace WindowsFormsavocat050315
{
    partial class Travail_JusticeListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travail_JusticeListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AnnulerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerToutSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ImprimerSelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SupprimerSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AjouterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ModifierSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_travail_justice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode_kadhiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType_travail_justice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSujet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_travail_justice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_dossier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 307);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.AnnulerSimpleButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerToutSimpleButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ImprimerSelSimpleButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.SupprimerSimpleButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.AjouterSimpleButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.ModifierSimpleButton, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 277);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 27);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // AnnulerSimpleButton
            // 
            this.AnnulerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnnulerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AnnulerSimpleButton.Image")));
            this.AnnulerSimpleButton.Location = new System.Drawing.Point(23, 3);
            this.AnnulerSimpleButton.Name = "AnnulerSimpleButton";
            this.AnnulerSimpleButton.Size = new System.Drawing.Size(162, 21);
            this.AnnulerSimpleButton.TabIndex = 0;
            this.AnnulerSimpleButton.Text = "خورج";
            this.AnnulerSimpleButton.Click += new System.EventHandler(this.AnnulerSimpleButton_Click);
            // 
            // ImprimerToutSimpleButton
            // 
            this.ImprimerToutSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimerToutSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerToutSimpleButton.Image")));
            this.ImprimerToutSimpleButton.Location = new System.Drawing.Point(191, 3);
            this.ImprimerToutSimpleButton.Name = "ImprimerToutSimpleButton";
            this.ImprimerToutSimpleButton.Size = new System.Drawing.Size(162, 21);
            this.ImprimerToutSimpleButton.TabIndex = 1;
            this.ImprimerToutSimpleButton.Text = "طباعة";
            // 
            // ImprimerSelSimpleButton
            // 
            this.ImprimerSelSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImprimerSelSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimerSelSimpleButton.Image")));
            this.ImprimerSelSimpleButton.Location = new System.Drawing.Point(359, 3);
            this.ImprimerSelSimpleButton.Name = "ImprimerSelSimpleButton";
            this.ImprimerSelSimpleButton.Size = new System.Drawing.Size(162, 21);
            this.ImprimerSelSimpleButton.TabIndex = 2;
            this.ImprimerSelSimpleButton.Text = "طباعة";
            // 
            // SupprimerSimpleButton
            // 
            this.SupprimerSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupprimerSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerSimpleButton.Image")));
            this.SupprimerSimpleButton.Location = new System.Drawing.Point(527, 3);
            this.SupprimerSimpleButton.Name = "SupprimerSimpleButton";
            this.SupprimerSimpleButton.Size = new System.Drawing.Size(162, 21);
            this.SupprimerSimpleButton.TabIndex = 3;
            this.SupprimerSimpleButton.Text = "حذف";
            this.SupprimerSimpleButton.Click += new System.EventHandler(this.SupprimerSimpleButton_Click);
            // 
            // AjouterSimpleButton
            // 
            this.AjouterSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AjouterSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("AjouterSimpleButton.Image")));
            this.AjouterSimpleButton.Location = new System.Drawing.Point(695, 3);
            this.AjouterSimpleButton.Name = "AjouterSimpleButton";
            this.AjouterSimpleButton.Size = new System.Drawing.Size(162, 21);
            this.AjouterSimpleButton.TabIndex = 4;
            this.AjouterSimpleButton.Text = "اظافة";
            this.AjouterSimpleButton.UseWaitCursor = true;
            this.AjouterSimpleButton.Click += new System.EventHandler(this.AjouterSimpleButton_Click);
            // 
            // ModifierSimpleButton
            // 
            this.ModifierSimpleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifierSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ModifierSimpleButton.Image")));
            this.ModifierSimpleButton.Location = new System.Drawing.Point(863, 3);
            this.ModifierSimpleButton.Name = "ModifierSimpleButton";
            this.ModifierSimpleButton.Size = new System.Drawing.Size(162, 21);
            this.ModifierSimpleButton.TabIndex = 5;
            this.ModifierSimpleButton.Text = "تعديل";
            this.ModifierSimpleButton.Click += new System.EventHandler(this.ModifierSimpleButton_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 268);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.xpCollection1;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(avocat2015.DATA.baavocat.Travail_Justice);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_travail_justice,
            this.colClient,
            this.colNom_client,
            this.colCode_kadhiya,
            this.colType_travail_justice,
            this.colSujet,
            this.colDate_travail_justice,
            this.colPrix,
            this.colNom_dossier});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCode_travail_justice
            // 
            this.colCode_travail_justice.Caption = "رقم الأعمال لدى المحاكم و الادارات ";
            this.colCode_travail_justice.FieldName = "Code_travail_justice";
            this.colCode_travail_justice.Name = "colCode_travail_justice";
            this.colCode_travail_justice.Visible = true;
            this.colCode_travail_justice.VisibleIndex = 8;
            // 
            // colClient
            // 
            this.colClient.Caption = "رقم الحريف ";
            this.colClient.FieldName = "Client";
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 5;
            // 
            // colNom_client
            // 
            this.colNom_client.Caption = "الحريف ";
            this.colNom_client.FieldName = "Nom_client";
            this.colNom_client.Name = "colNom_client";
            this.colNom_client.Visible = true;
            this.colNom_client.VisibleIndex = 4;
            // 
            // colCode_kadhiya
            // 
            this.colCode_kadhiya.Caption = "رقم القضية ";
            this.colCode_kadhiya.FieldName = "Code_kadhiya";
            this.colCode_kadhiya.Name = "colCode_kadhiya";
            this.colCode_kadhiya.Visible = true;
            this.colCode_kadhiya.VisibleIndex = 3;
            // 
            // colType_travail_justice
            // 
            this.colType_travail_justice.Caption = "نوع الأعمال ";
            this.colType_travail_justice.FieldName = "Type_travail_justice";
            this.colType_travail_justice.Name = "colType_travail_justice";
            this.colType_travail_justice.Visible = true;
            this.colType_travail_justice.VisibleIndex = 7;
            // 
            // colSujet
            // 
            this.colSujet.Caption = "الموضوع ";
            this.colSujet.FieldName = "Sujet";
            this.colSujet.Name = "colSujet";
            this.colSujet.Visible = true;
            this.colSujet.VisibleIndex = 6;
            // 
            // colDate_travail_justice
            // 
            this.colDate_travail_justice.Caption = "التاريخ ";
            this.colDate_travail_justice.FieldName = "Date_travail_justice";
            this.colDate_travail_justice.Name = "colDate_travail_justice";
            this.colDate_travail_justice.Visible = true;
            this.colDate_travail_justice.VisibleIndex = 0;
            // 
            // colPrix
            // 
            this.colPrix.Caption = "المبلغ ";
            this.colPrix.FieldName = "Prix";
            this.colPrix.Name = "colPrix";
            this.colPrix.Visible = true;
            this.colPrix.VisibleIndex = 1;
            // 
            // colNom_dossier
            // 
            this.colNom_dossier.Caption = "رقم الملف ";
            this.colNom_dossier.FieldName = "Nom_dossier";
            this.colNom_dossier.Name = "colNom_dossier";
            this.colNom_dossier.Visible = true;
            this.colNom_dossier.VisibleIndex = 2;
            // 
            // Travail_JusticeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Travail_JusticeListForm";
            this.Text = "قائمة الأعمال لدى المحاكم و الادارات";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton AnnulerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerToutSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ImprimerSelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SupprimerSimpleButton;
        private DevExpress.XtraEditors.SimpleButton AjouterSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ModifierSimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_travail_justice;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_client;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_kadhiya;
        private DevExpress.XtraGrid.Columns.GridColumn colType_travail_justice;
        private DevExpress.XtraGrid.Columns.GridColumn colSujet;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_travail_justice;
        private DevExpress.XtraGrid.Columns.GridColumn colPrix;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_dossier;
    }
}