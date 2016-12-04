namespace WindowsFormsavocat050315
{
    partial class VilleListeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VilleListeForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.VilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VilleListeXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerSel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerTous = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonModifier = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleListeXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.gridControl1.DataSource = this.VilleBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 261);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // VilleBindingSource
            // 
            this.VilleBindingSource.DataSource = this.VilleListeXpCollection;
            // 
            // VilleListeXpCollection
            // 
            this.VilleListeXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Ville);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeVille,
            this.colNomVille});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCodeVille
            // 
            this.colCodeVille.FieldName = "CodeVille";
            this.colCodeVille.Name = "colCodeVille";
            this.colCodeVille.Visible = true;
            this.colCodeVille.VisibleIndex = 0;
            // 
            // colNomVille
            // 
            this.colNomVille.FieldName = "NomVille";
            this.colNomVille.Name = "colNomVille";
            this.colNomVille.Visible = true;
            this.colNomVille.VisibleIndex = 1;
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
            this.simpleButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnnuler.Image")));
            this.simpleButtonAnnuler.Location = new System.Drawing.Point(23, 3);
            this.simpleButtonAnnuler.Name = "simpleButtonAnnuler";
            this.simpleButtonAnnuler.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonAnnuler.TabIndex = 0;
            this.simpleButtonAnnuler.Text = "خورج";
            // 
            // simpleButtonImprimerSel
            // 
            this.simpleButtonImprimerSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerSel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerSel.Image")));
            this.simpleButtonImprimerSel.Location = new System.Drawing.Point(189, 3);
            this.simpleButtonImprimerSel.Name = "simpleButtonImprimerSel";
            this.simpleButtonImprimerSel.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonImprimerSel.TabIndex = 1;
            this.simpleButtonImprimerSel.Text = "طباعة";
            // 
            // simpleButtonImprimerTous
            // 
            this.simpleButtonImprimerTous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerTous.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerTous.Image")));
            this.simpleButtonImprimerTous.Location = new System.Drawing.Point(355, 3);
            this.simpleButtonImprimerTous.Name = "simpleButtonImprimerTous";
            this.simpleButtonImprimerTous.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonImprimerTous.TabIndex = 2;
            this.simpleButtonImprimerTous.Text = "طباعة";
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSupprimer.Image")));
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(521, 3);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonSupprimer.TabIndex = 3;
            this.simpleButtonSupprimer.Text = "حذف";
            this.simpleButtonSupprimer.Click += new System.EventHandler(this.simpleButtonSupprimer_Click);
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAjouter.Image")));
            this.simpleButtonAjouter.Location = new System.Drawing.Point(687, 3);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(160, 28);
            this.simpleButtonAjouter.TabIndex = 4;
            this.simpleButtonAjouter.Text = "اظافة";
            this.simpleButtonAjouter.Click += new System.EventHandler(this.simpleButtonAjouter_Click);
            // 
            // simpleButtonModifier
            // 
            this.simpleButtonModifier.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModifier.Image")));
            this.simpleButtonModifier.Location = new System.Drawing.Point(853, 3);
            this.simpleButtonModifier.Name = "simpleButtonModifier";
            this.simpleButtonModifier.Size = new System.Drawing.Size(100, 28);
            this.simpleButtonModifier.TabIndex = 5;
            this.simpleButtonModifier.Text = "تعديل";
            this.simpleButtonModifier.Click += new System.EventHandler(this.simpleButtonModifier_Click);
            // 
            // VilleListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VilleListeForm";
            this.Text = "VilleListeForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleListeXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection VilleListeXpCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource VilleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeVille;
        private DevExpress.XtraGrid.Columns.GridColumn colNomVille;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAnnuler;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerSel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerTous;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModifier;
    }
}