namespace WindowsFormsavocat050315
{
    partial class UserEditForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UserEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserEditXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.mpTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForlogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFormp = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.ValideSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormp)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 159);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.loginTextEdit);
            this.dataLayoutControl1.Controls.Add(this.mpTextEdit);
            this.dataLayoutControl1.DataSource = this.UserEditBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(424, 113);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.UserEditBindingSource, "login", true));
            this.loginTextEdit.Location = new System.Drawing.Point(24, 43);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(289, 20);
            this.loginTextEdit.StyleController = this.dataLayoutControl1;
            this.loginTextEdit.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.loginTextEdit, conditionValidationRule1);
            // 
            // UserEditBindingSource
            // 
            this.UserEditBindingSource.DataSource = this.UserEditXpCollection;
            // 
            // UserEditXpCollection
            // 
            this.UserEditXpCollection.LoadingEnabled = false;
            this.UserEditXpCollection.ObjectType = typeof(avocat2015.DATA.baavocat.users);
            // 
            // mpTextEdit
            // 
            this.mpTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.UserEditBindingSource, "mp", true));
            this.mpTextEdit.Location = new System.Drawing.Point(24, 67);
            this.mpTextEdit.Name = "mpTextEdit";
            this.mpTextEdit.Size = new System.Drawing.Size(289, 20);
            this.mpTextEdit.StyleController = this.dataLayoutControl1;
            this.mpTextEdit.TabIndex = 6;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotContains;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            conditionValidationRule2.Value1 = "<Null>";
            conditionValidationRule2.Values.Add("^,.:<>?!§#");
            this.dxValidationProvider1.SetValidationRule(this.mpTextEdit, conditionValidationRule2);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(424, 113);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup2.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForlogin,
            this.ItemFormp});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(404, 93);
            this.layoutControlGroup2.Text = "المستخدم";
            // 
            // ItemForlogin
            // 
            this.ItemForlogin.Control = this.loginTextEdit;
            this.ItemForlogin.CustomizationFormText = "login";
            this.ItemForlogin.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemForlogin.Location = new System.Drawing.Point(0, 0);
            this.ItemForlogin.Name = "ItemForlogin";
            this.ItemForlogin.Size = new System.Drawing.Size(380, 24);
            this.ItemForlogin.Text = "أسم المستخدم";
            this.ItemForlogin.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemForlogin.TextSize = new System.Drawing.Size(84, 13);
            // 
            // ItemFormp
            // 
            this.ItemFormp.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemFormp.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemFormp.Control = this.mpTextEdit;
            this.ItemFormp.CustomizationFormText = "mp";
            this.ItemFormp.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.ItemFormp.Location = new System.Drawing.Point(0, 24);
            this.ItemFormp.Name = "ItemFormp";
            this.ItemFormp.Size = new System.Drawing.Size(380, 26);
            this.ItemFormp.Text = "كلمة المرور";
            this.ItemFormp.TextLocation = DevExpress.Utils.Locations.Right;
            this.ItemFormp.TextSize = new System.Drawing.Size(84, 13);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ValideSimpleButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton2.Location = new System.Drawing.Point(179, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 28);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "خروج";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ValideSimpleButton
            // 
            this.ValideSimpleButton.Image = ((System.Drawing.Image)(resources.GetObject("ValideSimpleButton.Image")));
            this.ValideSimpleButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.ValideSimpleButton.Location = new System.Drawing.Point(299, 3);
            this.ValideSimpleButton.Name = "ValideSimpleButton";
            this.ValideSimpleButton.Size = new System.Drawing.Size(114, 28);
            this.ValideSimpleButton.TabIndex = 0;
            this.ValideSimpleButton.Text = " تسجيل\r\n";
            this.ValideSimpleButton.Click += new System.EventHandler(this.ValideSimpleButton_Click);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 159);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserEditForm";
            this.Text = "UserEditForm";
            this.Load += new System.EventHandler(this.UserEditForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormp)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.Xpo.XPCollection UserEditXpCollection;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource UserEditBindingSource;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.TextEdit mpTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForlogin;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton ValideSimpleButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}