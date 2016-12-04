namespace WindowsFormsavocat050315
{
    partial class Reglement_ClientForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ReglementClientbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReglementClientxpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_Reglement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode_Kadhiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMontant_reg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMode_Payement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_piece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_payement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_piece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode_client = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Txt_code = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Txt_Montant_reg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Valide = new System.Windows.Forms.Button();
            this.Txt_Code_Reglement = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Dat_Date_payement = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Dat_Date_piece = new System.Windows.Forms.DateTimePicker();
            this.Txt_Num_piece = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Banque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_montant_res = new System.Windows.Forms.TextBox();
            this.kadyabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kadyaaxpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Montants_reg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Montant_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReglementClientbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReglementClientxpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadyabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadyaaxpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ReglementClientbindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1042, 147);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // ReglementClientbindingSource
            // 
            this.ReglementClientbindingSource.DataSource = this.ReglementClientxpCollection;
            // 
            // ReglementClientxpCollection
            // 
            this.ReglementClientxpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Reglement_Client);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_Reglement,
            this.colCode_Kadhiya,
            this.colMontant_reg,
            this.colMode_Payement,
            this.colNum_piece,
            this.colBanque,
            this.colDate_payement,
            this.colDate_piece,
            this.colCode_client,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Style3D";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCode_client, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCode_Reglement
            // 
            this.colCode_Reglement.FieldName = "Code_Reglement";
            this.colCode_Reglement.Name = "colCode_Reglement";
            this.colCode_Reglement.Visible = true;
            this.colCode_Reglement.VisibleIndex = 0;
            // 
            // colCode_Kadhiya
            // 
            this.colCode_Kadhiya.FieldName = "Code_Kadhiya";
            this.colCode_Kadhiya.Name = "colCode_Kadhiya";
            this.colCode_Kadhiya.Visible = true;
            this.colCode_Kadhiya.VisibleIndex = 1;
            // 
            // colMontant_reg
            // 
            this.colMontant_reg.FieldName = "Montant_reg";
            this.colMontant_reg.Name = "colMontant_reg";
            this.colMontant_reg.Visible = true;
            this.colMontant_reg.VisibleIndex = 2;
            // 
            // colMode_Payement
            // 
            this.colMode_Payement.FieldName = "Mode_Payement";
            this.colMode_Payement.Name = "colMode_Payement";
            this.colMode_Payement.Visible = true;
            this.colMode_Payement.VisibleIndex = 3;
            // 
            // colNum_piece
            // 
            this.colNum_piece.FieldName = "Num_piece";
            this.colNum_piece.Name = "colNum_piece";
            this.colNum_piece.Visible = true;
            this.colNum_piece.VisibleIndex = 4;
            // 
            // colBanque
            // 
            this.colBanque.FieldName = "Banque";
            this.colBanque.Name = "colBanque";
            this.colBanque.Visible = true;
            this.colBanque.VisibleIndex = 5;
            // 
            // colDate_payement
            // 
            this.colDate_payement.FieldName = "Date_payement";
            this.colDate_payement.Name = "colDate_payement";
            this.colDate_payement.Visible = true;
            this.colDate_payement.VisibleIndex = 6;
            // 
            // colDate_piece
            // 
            this.colDate_piece.FieldName = "Date_piece";
            this.colDate_piece.Name = "colDate_piece";
            this.colDate_piece.Visible = true;
            this.colDate_piece.VisibleIndex = 7;
            // 
            // colCode_client
            // 
            this.colCode_client.FieldName = "Code_client";
            this.colCode_client.Name = "colCode_client";
            this.colCode_client.Visible = true;
            this.colCode_client.VisibleIndex = 8;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchLookUpEdit1);
            this.groupBox1.Controls.Add(this.Txt_code);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Txt_Montant_reg);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Valide);
            this.groupBox1.Controls.Add(this.Txt_Code_Reglement);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Dat_Date_payement);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Txt_Description);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Dat_Date_piece);
            this.groupBox1.Controls.Add(this.Txt_Num_piece);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Banque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_montant_res);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_Montants_reg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Montant_total);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(3, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xpCollection1, "Type_Payement1", true));
            this.searchLookUpEdit1.EditValue = "";
            this.searchLookUpEdit1.Location = new System.Drawing.Point(259, 65);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.xpCollection1;
            this.searchLookUpEdit1.Properties.DisplayMember = "Type_Payement1";
            this.searchLookUpEdit1.Properties.ValueMember = "Type_Payement1";
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(139, 20);
            this.searchLookUpEdit1.TabIndex = 661;
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(avocat2015.DATA.baavocat.Type_Payement);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Txt_code
            // 
            this.Txt_code.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReglementClientbindingSource, "Code_Kadhiya!Key", true));
            this.Txt_code.Location = new System.Drawing.Point(7, 122);
            this.Txt_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_code.Name = "Txt_code";
            this.Txt_code.Size = new System.Drawing.Size(135, 20);
            this.Txt_code.TabIndex = 660;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(152, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 19);
            this.label16.TabIndex = 659;
            this.label16.Text = "رقم القضية... :";
            // 
            // Txt_Montant_reg
            // 
            this.Txt_Montant_reg.Location = new System.Drawing.Point(529, 68);
            this.Txt_Montant_reg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Montant_reg.Name = "Txt_Montant_reg";
            this.Txt_Montant_reg.Size = new System.Drawing.Size(127, 20);
            this.Txt_Montant_reg.TabIndex = 658;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(660, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 19);
            this.label14.TabIndex = 657;
            this.label14.Text = "المبلغ المدفوع :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(24, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 33);
            this.button1.TabIndex = 656;
            this.button1.Text = "غلق";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(97, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 33);
            this.button3.TabIndex = 655;
            this.button3.Text = "إلغاء";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Valide
            // 
            this.Valide.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Valide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Valide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Valide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Valide.Location = new System.Drawing.Point(672, 189);
            this.Valide.Name = "Valide";
            this.Valide.Size = new System.Drawing.Size(81, 34);
            this.Valide.TabIndex = 654;
            this.Valide.Text = "تسجيل";
            this.Valide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Valide.UseVisualStyleBackColor = true;
            this.Valide.Click += new System.EventHandler(this.Valide_Click);
            // 
            // Txt_Code_Reglement
            // 
            this.Txt_Code_Reglement.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReglementClientbindingSource, "Code_Reglement", true));
            this.Txt_Code_Reglement.Enabled = false;
            this.Txt_Code_Reglement.Location = new System.Drawing.Point(529, 39);
            this.Txt_Code_Reglement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Code_Reglement.Name = "Txt_Code_Reglement";
            this.Txt_Code_Reglement.Size = new System.Drawing.Size(127, 20);
            this.Txt_Code_Reglement.TabIndex = 653;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(662, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 652;
            this.label11.Text = "رقم الدفع...... :";
            // 
            // Dat_Date_payement
            // 
            this.Dat_Date_payement.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ReglementClientbindingSource, "Date_payement", true));
            this.Dat_Date_payement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Date_payement.Location = new System.Drawing.Point(8, 63);
            this.Dat_Date_payement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dat_Date_payement.Name = "Dat_Date_payement";
            this.Dat_Date_payement.Size = new System.Drawing.Size(134, 20);
            this.Dat_Date_payement.TabIndex = 651;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(151, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 650;
            this.label10.Text = "تاريخ الدفع.... :";
            // 
            // Txt_Description
            // 
            this.Txt_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReglementClientbindingSource, "Description", true));
            this.Txt_Description.Location = new System.Drawing.Point(259, 125);
            this.Txt_Description.Multiline = true;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(397, 69);
            this.Txt_Description.TabIndex = 649;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(662, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 648;
            this.label9.Text = "الملاحظات..... :";
            // 
            // Dat_Date_piece
            // 
            this.Dat_Date_piece.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ReglementClientbindingSource, "Date_piece", true));
            this.Dat_Date_piece.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Date_piece.Location = new System.Drawing.Point(8, 92);
            this.Dat_Date_piece.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dat_Date_piece.Name = "Dat_Date_piece";
            this.Dat_Date_piece.Size = new System.Drawing.Size(134, 20);
            this.Dat_Date_piece.TabIndex = 647;
            // 
            // Txt_Num_piece
            // 
            this.Txt_Num_piece.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReglementClientbindingSource, "Num_piece", true));
            this.Txt_Num_piece.Location = new System.Drawing.Point(261, 95);
            this.Txt_Num_piece.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Num_piece.Name = "Txt_Num_piece";
            this.Txt_Num_piece.Size = new System.Drawing.Size(137, 20);
            this.Txt_Num_piece.TabIndex = 646;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(401, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 645;
            this.label8.Text = "رقم الصك.......... :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(151, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 644;
            this.label7.Text = "تاريخ الصك... :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(662, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 643;
            this.label4.Text = "البنك............ :";
            // 
            // Txt_Banque
            // 
            this.Txt_Banque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReglementClientbindingSource, "Banque", true));
            this.Txt_Banque.Location = new System.Drawing.Point(529, 97);
            this.Txt_Banque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Banque.Name = "Txt_Banque";
            this.Txt_Banque.Size = new System.Drawing.Size(127, 20);
            this.Txt_Banque.TabIndex = 641;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(401, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 640;
            this.label2.Text = "طريقة الدفع........ :";
            // 
            // Txt_montant_res
            // 
            this.Txt_montant_res.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kadyabindingSource, "montant_restant", true));
            this.Txt_montant_res.Location = new System.Drawing.Point(8, 13);
            this.Txt_montant_res.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_montant_res.Name = "Txt_montant_res";
            this.Txt_montant_res.Size = new System.Drawing.Size(134, 20);
            this.Txt_montant_res.TabIndex = 639;
            // 
            // kadyabindingSource
            // 
            this.kadyabindingSource.DataSource = this.kadyaaxpCollection;
            // 
            // kadyaaxpCollection
            // 
            this.kadyaaxpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.Kadhiya);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(151, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 638;
            this.label6.Text = "المبلغ المتبقي :";
            // 
            // Txt_Montants_reg
            // 
            this.Txt_Montants_reg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kadyabindingSource, "totalPaye", true));
            this.Txt_Montants_reg.Location = new System.Drawing.Point(259, 11);
            this.Txt_Montants_reg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Montants_reg.Name = "Txt_Montants_reg";
            this.Txt_Montants_reg.Size = new System.Drawing.Size(139, 20);
            this.Txt_Montants_reg.TabIndex = 637;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(401, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 636;
            this.label5.Text = "المبلغ الذي تم دفعه :";
            // 
            // Txt_Montant_total
            // 
            this.Txt_Montant_total.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReglementClientbindingSource, "Montant_reg", true));
            this.Txt_Montant_total.Location = new System.Drawing.Point(529, 9);
            this.Txt_Montant_total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Montant_total.Name = "Txt_Montant_total";
            this.Txt_Montant_total.Size = new System.Drawing.Size(127, 20);
            this.Txt_Montant_total.TabIndex = 635;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(662, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 634;
            this.label3.Text = "المبلغ الجملي. :";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.xpCollection1;
            // 
            // Reglement_ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reglement_ClientForm";
            this.Text = "سجل أداءات الحريف";
            this.Load += new System.EventHandler(this.Reglement_ClientForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReglementClientbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReglementClientxpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadyabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadyaaxpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection ReglementClientxpCollection;
        private System.Windows.Forms.BindingSource ReglementClientbindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Reglement;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Kadhiya;
        private DevExpress.XtraGrid.Columns.GridColumn colMontant_reg;
        private DevExpress.XtraGrid.Columns.GridColumn colMode_Payement;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_piece;
        private DevExpress.XtraGrid.Columns.GridColumn colBanque;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_payement;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_piece;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_client;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_code;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Txt_Montant_reg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Valide;
        private System.Windows.Forms.TextBox Txt_Code_Reglement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Dat_Date_payement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Dat_Date_piece;
        private System.Windows.Forms.TextBox Txt_Num_piece;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Banque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_montant_res;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Montants_reg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Montant_total;
        private System.Windows.Forms.Label label3;
        private DevExpress.Xpo.XPCollection kadyaaxpCollection;
        private System.Windows.Forms.BindingSource kadyabindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.Xpo.XPCollection xpCollection1;
    }
}