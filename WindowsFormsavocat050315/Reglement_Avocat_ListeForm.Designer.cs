namespace WindowsFormsavocat050315
{
    partial class Reglement_Avocat_ListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reglement_Avocat_ListeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Reglement_AvocatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reglement_avocatXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_Reg_Avc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontant_reg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMode_Payement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_piece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_payement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontant_paye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerSel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerTous = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonModifier = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reglement_AvocatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reglement_avocatXpCollection)).BeginInit();
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
            this.gridControl1.DataSource = this.Reglement_AvocatBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.Size = new System.Drawing.Size(1042, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Reglement_AvocatBindingSource
            // 
            this.Reglement_AvocatBindingSource.DataSource = this.Reglement_avocatXpCollection;
            // 
            // Reglement_avocatXpCollection
            // 
            this.Reglement_avocatXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Reglement_Avocat);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_Reg_Avc,
            this.colMontant_reg,
            this.colMode_Payement,
            this.colNum_piece,
            this.colBanque,
            this.colDate_payement,
            this.colClient,
            this.colMontant_paye,
            this.colDescription,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCode_Reg_Avc
            // 
            this.colCode_Reg_Avc.AppearanceCell.Options.UseTextOptions = true;
            this.colCode_Reg_Avc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCode_Reg_Avc.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode_Reg_Avc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCode_Reg_Avc.Caption = "رمز محامي";
            this.colCode_Reg_Avc.FieldName = "Code_Reg_Avc";
            this.colCode_Reg_Avc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCode_Reg_Avc.Name = "colCode_Reg_Avc";
            this.colCode_Reg_Avc.Visible = true;
            this.colCode_Reg_Avc.VisibleIndex = 9;
            this.colCode_Reg_Avc.Width = 166;
            // 
            // colMontant_reg
            // 
            this.colMontant_reg.Caption = "المبلغ المتبقي ";
            this.colMontant_reg.FieldName = "Montant_reg";
            this.colMontant_reg.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colMontant_reg.Name = "colMontant_reg";
            this.colMontant_reg.Visible = true;
            this.colMontant_reg.VisibleIndex = 8;
            this.colMontant_reg.Width = 174;
            // 
            // colMode_Payement
            // 
            this.colMode_Payement.Caption = "كيفية الدفع ";
            this.colMode_Payement.FieldName = "Mode_Payement";
            this.colMode_Payement.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colMode_Payement.Name = "colMode_Payement";
            this.colMode_Payement.Visible = true;
            this.colMode_Payement.VisibleIndex = 7;
            this.colMode_Payement.Width = 112;
            // 
            // colNum_piece
            // 
            this.colNum_piece.Caption = "رقم شيك ";
            this.colNum_piece.FieldName = "Num_piece";
            this.colNum_piece.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colNum_piece.Name = "colNum_piece";
            this.colNum_piece.Visible = true;
            this.colNum_piece.VisibleIndex = 6;
            this.colNum_piece.Width = 112;
            // 
            // colBanque
            // 
            this.colBanque.Caption = "البنك ";
            this.colBanque.FieldName = "Banque";
            this.colBanque.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colBanque.Name = "colBanque";
            this.colBanque.Visible = true;
            this.colBanque.VisibleIndex = 5;
            this.colBanque.Width = 67;
            // 
            // colDate_payement
            // 
            this.colDate_payement.Caption = "تاريخ الدفع ";
            this.colDate_payement.FieldName = "Date_payement";
            this.colDate_payement.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colDate_payement.Name = "colDate_payement";
            this.colDate_payement.Visible = true;
            this.colDate_payement.VisibleIndex = 4;
            this.colDate_payement.Width = 105;
            // 
            // colClient
            // 
            this.colClient.Caption = "إسم الحريف ";
            this.colClient.FieldName = "Client";
            this.colClient.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colClient.Name = "colClient";
            this.colClient.Visible = true;
            this.colClient.VisibleIndex = 3;
            this.colClient.Width = 105;
            // 
            // colMontant_paye
            // 
            this.colMontant_paye.Caption = "المبلغ المدفوع ";
            this.colMontant_paye.FieldName = "Montant_paye";
            this.colMontant_paye.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colMontant_paye.Name = "colMontant_paye";
            this.colMontant_paye.Visible = true;
            this.colMontant_paye.VisibleIndex = 2;
            this.colMontant_paye.Width = 105;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "التفاصيل ";
            this.colDescription.FieldName = "Description";
            this.colDescription.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 89;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "رمز  القضية ";
            this.gridColumn1.FieldName = "Code_kadhiya!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 140;
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
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAnnuler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerSel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerTous, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonSupprimer, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAjouter, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonModifier, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButtonAnnuler
            // 
            this.simpleButtonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnnuler.Image")));
            this.simpleButtonAnnuler.Location = new System.Drawing.Point(23, 3);
            this.simpleButtonAnnuler.Name = "simpleButtonAnnuler";
            this.simpleButtonAnnuler.Size = new System.Drawing.Size(91, 28);
            this.simpleButtonAnnuler.TabIndex = 0;
            this.simpleButtonAnnuler.Text = "خورج";
            this.simpleButtonAnnuler.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonImprimerSel
            // 
            this.simpleButtonImprimerSel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerSel.Image")));
            this.simpleButtonImprimerSel.Location = new System.Drawing.Point(189, 3);
            this.simpleButtonImprimerSel.Name = "simpleButtonImprimerSel";
            this.simpleButtonImprimerSel.Size = new System.Drawing.Size(87, 28);
            this.simpleButtonImprimerSel.TabIndex = 1;
            this.simpleButtonImprimerSel.Text = "طباعة";
            // 
            // simpleButtonImprimerTous
            // 
            this.simpleButtonImprimerTous.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerTous.Image")));
            this.simpleButtonImprimerTous.Location = new System.Drawing.Point(355, 3);
            this.simpleButtonImprimerTous.Name = "simpleButtonImprimerTous";
            this.simpleButtonImprimerTous.Size = new System.Drawing.Size(87, 28);
            this.simpleButtonImprimerTous.TabIndex = 2;
            this.simpleButtonImprimerTous.Text = "طباعة";
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSupprimer.Image")));
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(521, 3);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(87, 28);
            this.simpleButtonSupprimer.TabIndex = 3;
            this.simpleButtonSupprimer.Text = "حذف";
            this.simpleButtonSupprimer.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAjouter.Image")));
            this.simpleButtonAjouter.Location = new System.Drawing.Point(687, 3);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(87, 28);
            this.simpleButtonAjouter.TabIndex = 4;
            this.simpleButtonAjouter.Text = "اظافة";
            this.simpleButtonAjouter.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButtonModifier
            // 
            this.simpleButtonModifier.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModifier.Image")));
            this.simpleButtonModifier.Location = new System.Drawing.Point(853, 3);
            this.simpleButtonModifier.Name = "simpleButtonModifier";
            this.simpleButtonModifier.Size = new System.Drawing.Size(87, 28);
            this.simpleButtonModifier.TabIndex = 5;
            this.simpleButtonModifier.Text = "تعديل";
            this.simpleButtonModifier.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // Reglement_Avocat_ListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reglement_Avocat_ListeForm";
            this.Text = "قائمة أتعاب المحامي";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reglement_AvocatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reglement_avocatXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection Reglement_avocatXpCollection;
        private System.Windows.Forms.BindingSource Reglement_AvocatBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Reg_Avc;
        private DevExpress.XtraGrid.Columns.GridColumn colMontant_reg;
        private DevExpress.XtraGrid.Columns.GridColumn colMode_Payement;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_piece;
        private DevExpress.XtraGrid.Columns.GridColumn colBanque;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_payement;
        private DevExpress.XtraGrid.Columns.GridColumn colClient;
        private DevExpress.XtraGrid.Columns.GridColumn colMontant_paye;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAnnuler;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerSel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerTous;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModifier;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}