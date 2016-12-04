using System.Runtime.Serialization;
namespace WindowsFormsavocat050315
{
    partial class VilleEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VilleEditForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CodeVilleSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.VilleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VilleXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.NomVilleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCodeVille = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNomVille = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonValider = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeVilleSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomVilleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodeVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNomVille)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataLayoutControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CodeVilleSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.NomVilleTextEdit);
            this.dataLayoutControl1.DataSource = this.VilleBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(549, 108);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CodeVilleSpinEdit
            // 
            this.CodeVilleSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.VilleBindingSource, "CodeVille", true));
            this.CodeVilleSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CodeVilleSpinEdit.Location = new System.Drawing.Point(61, 12);
            this.CodeVilleSpinEdit.Name = "CodeVilleSpinEdit";
            this.CodeVilleSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CodeVilleSpinEdit.Size = new System.Drawing.Size(476, 20);
            this.CodeVilleSpinEdit.StyleController = this.dataLayoutControl1;
            this.CodeVilleSpinEdit.TabIndex = 4;
            // 
            // VilleBindingSource
            // 
            this.VilleBindingSource.DataSource = this.VilleXpCollection;
            // 
            // VilleXpCollection
            // 
            this.VilleXpCollection.LoadingEnabled = false;
            this.VilleXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Ville);
            // 
            // NomVilleTextEdit
            // 
            this.NomVilleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.VilleBindingSource, "NomVille", true));
            this.NomVilleTextEdit.Location = new System.Drawing.Point(61, 36);
            this.NomVilleTextEdit.Name = "NomVilleTextEdit";
            this.NomVilleTextEdit.Size = new System.Drawing.Size(476, 20);
            this.NomVilleTextEdit.StyleController = this.dataLayoutControl1;
            this.NomVilleTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(549, 108);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCodeVille,
            this.ItemForNomVille});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(529, 88);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForCodeVille
            // 
            this.ItemForCodeVille.Control = this.CodeVilleSpinEdit;
            this.ItemForCodeVille.CustomizationFormText = "Code Ville";
            this.ItemForCodeVille.Location = new System.Drawing.Point(0, 0);
            this.ItemForCodeVille.Name = "ItemForCodeVille";
            this.ItemForCodeVille.Size = new System.Drawing.Size(529, 24);
            this.ItemForCodeVille.Text = "Code Ville";
            this.ItemForCodeVille.TextSize = new System.Drawing.Size(46, 13);
            // 
            // ItemForNomVille
            // 
            this.ItemForNomVille.Control = this.NomVilleTextEdit;
            this.ItemForNomVille.CustomizationFormText = "Nom Ville";
            this.ItemForNomVille.Location = new System.Drawing.Point(0, 24);
            this.ItemForNomVille.Name = "ItemForNomVille";
            this.ItemForNomVille.Size = new System.Drawing.Size(529, 64);
            this.ItemForNomVille.Text = "Nom Ville";
            this.ItemForNomVille.TextSize = new System.Drawing.Size(46, 13);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonValider, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButtonAnnuler, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButtonValider
            // 
            this.simpleButtonValider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonValider.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonValider.Image")));
            this.simpleButtonValider.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButtonValider.Location = new System.Drawing.Point(352, 3);
            this.simpleButtonValider.Name = "simpleButtonValider";
            this.simpleButtonValider.Size = new System.Drawing.Size(174, 28);
            this.simpleButtonValider.TabIndex = 0;
            this.simpleButtonValider.Text = " تسجيل";
            this.simpleButtonValider.Click += new System.EventHandler(this.simpleButtonValider_Click);
            // 
            // simpleButtonAnnuler
            // 
            this.simpleButtonAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAnnuler.Image")));
            this.simpleButtonAnnuler.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButtonAnnuler.Location = new System.Drawing.Point(172, 3);
            this.simpleButtonAnnuler.Name = "simpleButtonAnnuler";
            this.simpleButtonAnnuler.Size = new System.Drawing.Size(174, 28);
            this.simpleButtonAnnuler.TabIndex = 1;
            this.simpleButtonAnnuler.Text = "خروج";
            this.simpleButtonAnnuler.Click += new System.EventHandler(this.simpleButtonAnnuler_Click);
            // 
            // VilleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 154);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VilleEditForm";
            this.Text = "VilleEditForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeVilleSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VilleXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomVilleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCodeVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNomVille)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection VilleXpCollection;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SpinEdit CodeVilleSpinEdit;
        private System.Windows.Forms.BindingSource VilleBindingSource;
        private DevExpress.XtraEditors.TextEdit NomVilleTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCodeVille;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNomVille;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonValider;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAnnuler;
    }
}