namespace WindowsFormsavocat050315
{
    partial class UserListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserListxpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonModifier = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerT = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonImprimerS = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListxpCollection)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.UserBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 269);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // UserBindingSource
            // 
            this.UserBindingSource.DataSource = this.UserListxpCollection;
            // 
            // UserListxpCollection
            // 
            this.UserListxpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.users);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.collogin,
            this.colmp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // collogin
            // 
            this.collogin.FieldName = "login";
            this.collogin.Name = "collogin";
            this.collogin.Visible = true;
            this.collogin.VisibleIndex = 1;
            // 
            // colmp
            // 
            this.colmp.FieldName = "mp";
            this.colmp.Name = "colmp";
            this.colmp.Visible = true;
            this.colmp.VisibleIndex = 2;
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonModifier, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAnnuler, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAjouter, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonImprimerS, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonSupprimer, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 278);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 26);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButtonModifier
            // 
            this.simpleButtonModifier.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonModifier.Appearance.Options.UseFont = true;
            this.simpleButtonModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonModifier.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonModifier.Image")));
            this.simpleButtonModifier.Location = new System.Drawing.Point(856, 3);
            this.simpleButtonModifier.Name = "simpleButtonModifier";
            this.simpleButtonModifier.Size = new System.Drawing.Size(161, 20);
            this.simpleButtonModifier.TabIndex = 0;
            this.simpleButtonModifier.Text = "تعديل";
            this.simpleButtonModifier.Click += new System.EventHandler(this.simpleButtonModifier_Click);
            // 
            // simpleButtonAnnuler
            // 
            this.simpleButtonAnnuler.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAnnuler.Appearance.Options.UseFont = true;
            this.simpleButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnnuler.Image")));
            this.simpleButtonAnnuler.Location = new System.Drawing.Point(23, 3);
            this.simpleButtonAnnuler.Name = "simpleButtonAnnuler";
            this.simpleButtonAnnuler.Size = new System.Drawing.Size(170, 20);
            this.simpleButtonAnnuler.TabIndex = 5;
            this.simpleButtonAnnuler.Text = "خورج";
            this.simpleButtonAnnuler.Click += new System.EventHandler(this.simpleButtonAnnuler_Click);
            // 
            // simpleButtonImprimerT
            // 
            this.simpleButtonImprimerT.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonImprimerT.Appearance.Options.UseFont = true;
            this.simpleButtonImprimerT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerT.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerT.Image")));
            this.simpleButtonImprimerT.Location = new System.Drawing.Point(199, 3);
            this.simpleButtonImprimerT.Name = "simpleButtonImprimerT";
            this.simpleButtonImprimerT.Size = new System.Drawing.Size(150, 20);
            this.simpleButtonImprimerT.TabIndex = 4;
            this.simpleButtonImprimerT.Text = "طباعة";
            // 
            // simpleButtonAjouter
            // 
            this.simpleButtonAjouter.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonAjouter.Appearance.Options.UseFont = true;
            this.simpleButtonAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAjouter.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAjouter.Image")));
            this.simpleButtonAjouter.Location = new System.Drawing.Point(689, 3);
            this.simpleButtonAjouter.Name = "simpleButtonAjouter";
            this.simpleButtonAjouter.Size = new System.Drawing.Size(161, 20);
            this.simpleButtonAjouter.TabIndex = 1;
            this.simpleButtonAjouter.Text = "اظافة";
            this.simpleButtonAjouter.Click += new System.EventHandler(this.simpleButtonEnregistre_Click);
            // 
            // simpleButtonImprimerS
            // 
            this.simpleButtonImprimerS.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonImprimerS.Appearance.Options.UseFont = true;
            this.simpleButtonImprimerS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonImprimerS.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImprimerS.Image")));
            this.simpleButtonImprimerS.Location = new System.Drawing.Point(355, 3);
            this.simpleButtonImprimerS.Name = "simpleButtonImprimerS";
            this.simpleButtonImprimerS.Size = new System.Drawing.Size(161, 20);
            this.simpleButtonImprimerS.TabIndex = 3;
            this.simpleButtonImprimerS.Text = "طباعة";
            // 
            // simpleButtonSupprimer
            // 
            this.simpleButtonSupprimer.Appearance.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonSupprimer.Appearance.Options.UseFont = true;
            this.simpleButtonSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSupprimer.Image")));
            this.simpleButtonSupprimer.Location = new System.Drawing.Point(522, 3);
            this.simpleButtonSupprimer.Name = "simpleButtonSupprimer";
            this.simpleButtonSupprimer.Size = new System.Drawing.Size(161, 20);
            this.simpleButtonSupprimer.TabIndex = 2;
            this.simpleButtonSupprimer.Text = "حذف";
            this.simpleButtonSupprimer.Click += new System.EventHandler(this.simpleButtonSupprimer_Click);
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserListxpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection UserListxpCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource UserBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn collogin;
        private DevExpress.XtraGrid.Columns.GridColumn colmp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonModifier;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAjouter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSupprimer;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerS;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAnnuler;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImprimerT;
    }
}