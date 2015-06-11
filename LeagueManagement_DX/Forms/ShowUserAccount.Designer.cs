namespace LeagueManagement_DX.Forms
{
    partial class ShowUserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUserAccount));
            this.pictureEditUserAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDateofBirth = new DevExpress.XtraEditors.LabelControl();
            this.labelControlGroup = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLastLogin = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxGroupName = new System.Windows.Forms.ComboBox();
            this.simpleButtonBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.userDataset = new LeagueManagement_DX.UserDataset();
            this.groupUserTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.GroupUserTableAdapter();
            this.userDetailTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.UserDetailTableAdapter();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textEditNewPass = new DevExpress.XtraEditors.TextEdit();
            this.textEditCurrentPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkBoxChangePassword = new System.Windows.Forms.CheckBox();
            this.textEditDateOfBirth = new DevExpress.XtraEditors.TextEdit();
            this.customTextBoxFullName = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBoxLastLogin = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBoxGroupName = new WindowsFormsControlLibrary.CustomTextBox();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCurrentPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDateOfBirth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEditUserAvatar
            // 
            this.pictureEditUserAvatar.Location = new System.Drawing.Point(12, 38);
            this.pictureEditUserAvatar.Name = "pictureEditUserAvatar";
            this.pictureEditUserAvatar.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditUserAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditUserAvatar.Size = new System.Drawing.Size(104, 139);
            this.pictureEditUserAvatar.TabIndex = 0;
            // 
            // labelControlName
            // 
            this.labelControlName.Location = new System.Drawing.Point(6, 26);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(46, 13);
            this.labelControlName.TabIndex = 1;
            this.labelControlName.Text = "Full Name";
            // 
            // labelControlDateofBirth
            // 
            this.labelControlDateofBirth.Location = new System.Drawing.Point(6, 58);
            this.labelControlDateofBirth.Name = "labelControlDateofBirth";
            this.labelControlDateofBirth.Size = new System.Drawing.Size(61, 13);
            this.labelControlDateofBirth.TabIndex = 2;
            this.labelControlDateofBirth.Text = "Date of Birth";
            // 
            // labelControlGroup
            // 
            this.labelControlGroup.Location = new System.Drawing.Point(6, 92);
            this.labelControlGroup.Name = "labelControlGroup";
            this.labelControlGroup.Size = new System.Drawing.Size(32, 13);
            this.labelControlGroup.TabIndex = 3;
            this.labelControlGroup.Text = "Group ";
            // 
            // labelControlLastLogin
            // 
            this.labelControlLastLogin.Location = new System.Drawing.Point(4, 126);
            this.labelControlLastLogin.Name = "labelControlLastLogin";
            this.labelControlLastLogin.Size = new System.Drawing.Size(48, 13);
            this.labelControlLastLogin.TabIndex = 4;
            this.labelControlLastLogin.Text = "Last Login";
            // 
            // comboBoxGroupName
            // 
            this.comboBoxGroupName.FormattingEnabled = true;
            this.comboBoxGroupName.Location = new System.Drawing.Point(77, 84);
            this.comboBoxGroupName.Name = "comboBoxGroupName";
            this.comboBoxGroupName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroupName.TabIndex = 3;
            // 
            // simpleButtonBrowse
            // 
            this.simpleButtonBrowse.Location = new System.Drawing.Point(25, 183);
            this.simpleButtonBrowse.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonBrowse.Name = "simpleButtonBrowse";
            this.simpleButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonBrowse.TabIndex = 5;
            this.simpleButtonBrowse.Text = "Browse...";
            this.simpleButtonBrowse.Click += new System.EventHandler(this.simpleButtonBrowse_Click);
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Location = new System.Drawing.Point(79, 264);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEdit.TabIndex = 12;
            this.simpleButtonEdit.Text = "Edit";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(294, 264);
            this.simpleButtonCancel.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 11;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // userDataset
            // 
            this.userDataset.DataSetName = "UserDataset";
            this.userDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupUserTableAdapter
            // 
            this.groupUserTableAdapter.ClearBeforeFill = true;
            // 
            // userDetailTableAdapter
            // 
            this.userDetailTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Location = new System.Drawing.Point(79, 264);
            this.simpleButtonOK.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOK.TabIndex = 9;
            this.simpleButtonOK.Text = "OK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(77, 52);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(148, 21);
            this.dateTimePickerDateOfBirth.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEditNewPass);
            this.groupBox1.Controls.Add(this.textEditCurrentPass);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.checkBoxChangePassword);
            this.groupBox1.Controls.Add(this.textEditDateOfBirth);
            this.groupBox1.Controls.Add(this.labelControlName);
            this.groupBox1.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupBox1.Controls.Add(this.customTextBoxFullName);
            this.groupBox1.Controls.Add(this.labelControlDateofBirth);
            this.groupBox1.Controls.Add(this.customTextBoxLastLogin);
            this.groupBox1.Controls.Add(this.comboBoxGroupName);
            this.groupBox1.Controls.Add(this.labelControlLastLogin);
            this.groupBox1.Controls.Add(this.customTextBoxGroupName);
            this.groupBox1.Controls.Add(this.labelControlGroup);
            this.groupBox1.Location = new System.Drawing.Point(157, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 246);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowUserAccount_Paint);
            // 
            // textEditNewPass
            // 
            this.textEditNewPass.Location = new System.Drawing.Point(112, 211);
            this.textEditNewPass.Name = "textEditNewPass";
            this.textEditNewPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditNewPass.Properties.UseSystemPasswordChar = true;
            this.textEditNewPass.Size = new System.Drawing.Size(141, 20);
            this.textEditNewPass.TabIndex = 8;
            // 
            // textEditCurrentPass
            // 
            this.textEditCurrentPass.Location = new System.Drawing.Point(112, 178);
            this.textEditCurrentPass.Name = "textEditCurrentPass";
            this.textEditCurrentPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditCurrentPass.Properties.UseSystemPasswordChar = true;
            this.textEditCurrentPass.Size = new System.Drawing.Size(141, 20);
            this.textEditCurrentPass.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 214);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "New Password";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 181);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Current Password";
            // 
            // checkBoxChangePassword
            // 
            this.checkBoxChangePassword.AutoSize = true;
            this.checkBoxChangePassword.Location = new System.Drawing.Point(6, 148);
            this.checkBoxChangePassword.Name = "checkBoxChangePassword";
            this.checkBoxChangePassword.Size = new System.Drawing.Size(112, 17);
            this.checkBoxChangePassword.TabIndex = 6;
            this.checkBoxChangePassword.Text = "Change Password";
            this.checkBoxChangePassword.UseVisualStyleBackColor = true;
            this.checkBoxChangePassword.CheckedChanged += new System.EventHandler(this.checkBoxChangePassword_CheckedChanged);
            // 
            // textEditDateOfBirth
            // 
            this.textEditDateOfBirth.Location = new System.Drawing.Point(77, 53);
            this.textEditDateOfBirth.Name = "textEditDateOfBirth";
            this.textEditDateOfBirth.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditDateOfBirth.Size = new System.Drawing.Size(148, 20);
            this.textEditDateOfBirth.TabIndex = 16;
            // 
            // customTextBoxFullName
            // 
            this.customTextBoxFullName.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxFullName.Appearance.Options.UseBackColor = true;
            this.customTextBoxFullName.AutoSize = true;
            this.customTextBoxFullName.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxFullName.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxFullName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxFullName.isRequired = true;
            this.customTextBoxFullName.Location = new System.Drawing.Point(77, 19);
            this.customTextBoxFullName.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxFullName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxFullName.Multiline = false;
            this.customTextBoxFullName.Name = "customTextBoxFullName";
            this.customTextBoxFullName.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxFullName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxFullName.ReadOnly = false;
            this.customTextBoxFullName.Size = new System.Drawing.Size(148, 20);
            this.customTextBoxFullName.StringPattern = "^[a-zA-Z]{1,30}$";
            this.customTextBoxFullName.TabIndex = 1;
            this.customTextBoxFullName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxFullName.TextPanelMessage = "Invalid Full Name";
            this.customTextBoxFullName.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxFullName.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxFullName.xTextChanged += new System.EventHandler(this.customTextBoxFullName_xTextChanged);
            this.customTextBoxFullName.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowUserAccount_Paint);
            // 
            // customTextBoxLastLogin
            // 
            this.customTextBoxLastLogin.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxLastLogin.Appearance.Options.UseBackColor = true;
            this.customTextBoxLastLogin.AutoSize = true;
            this.customTextBoxLastLogin.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxLastLogin.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxLastLogin.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxLastLogin.isRequired = true;
            this.customTextBoxLastLogin.Location = new System.Drawing.Point(77, 119);
            this.customTextBoxLastLogin.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxLastLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxLastLogin.Multiline = false;
            this.customTextBoxLastLogin.Name = "customTextBoxLastLogin";
            this.customTextBoxLastLogin.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxLastLogin.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxLastLogin.ReadOnly = false;
            this.customTextBoxLastLogin.Size = new System.Drawing.Size(148, 20);
            this.customTextBoxLastLogin.StringPattern = "";
            this.customTextBoxLastLogin.TabIndex = 4;
            this.customTextBoxLastLogin.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxLastLogin.TextPanelMessage = "This is an error message.";
            this.customTextBoxLastLogin.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxLastLogin.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxLastLogin.xTextChanged += new System.EventHandler(this.customTextBoxLastLogin_xTextChanged);
            // 
            // customTextBoxGroupName
            // 
            this.customTextBoxGroupName.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxGroupName.Appearance.Options.UseBackColor = true;
            this.customTextBoxGroupName.AutoSize = true;
            this.customTextBoxGroupName.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxGroupName.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxGroupName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxGroupName.isRequired = true;
            this.customTextBoxGroupName.Location = new System.Drawing.Point(77, 84);
            this.customTextBoxGroupName.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxGroupName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxGroupName.Multiline = false;
            this.customTextBoxGroupName.Name = "customTextBoxGroupName";
            this.customTextBoxGroupName.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxGroupName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxGroupName.ReadOnly = false;
            this.customTextBoxGroupName.Size = new System.Drawing.Size(148, 20);
            this.customTextBoxGroupName.StringPattern = "";
            this.customTextBoxGroupName.TabIndex = 8;
            this.customTextBoxGroupName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxGroupName.TextPanelMessage = "This is an error message.";
            this.customTextBoxGroupName.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxGroupName.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxGroupName.xTextChanged += new System.EventHandler(this.customTextBoxGroupName_xTextChanged);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(188, 264);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonDelete.TabIndex = 10;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // ShowUserAccount
            // 
            this.AcceptButton = this.simpleButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(473, 299);
            this.Controls.Add(this.simpleButtonDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonEdit);
            this.Controls.Add(this.simpleButtonBrowse);
            this.Controls.Add(this.pictureEditUserAvatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximumSize = new System.Drawing.Size(489, 338);
            this.MinimumSize = new System.Drawing.Size(489, 338);
            this.Name = "ShowUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowUserAccount_FormClosing);
            this.Load += new System.EventHandler(this.ShowUserAccount_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowUserAccount_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCurrentPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDateOfBirth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEditUserAvatar;
        private DevExpress.XtraEditors.LabelControl labelControlName;
        private DevExpress.XtraEditors.LabelControl labelControlDateofBirth;
        private DevExpress.XtraEditors.LabelControl labelControlGroup;
        private DevExpress.XtraEditors.LabelControl labelControlLastLogin;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxGroupName;
        private System.Windows.Forms.ComboBox comboBoxGroupName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBrowse;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private UserDataset userDataset;
        private UserDatasetTableAdapters.GroupUserTableAdapter groupUserTableAdapter;
        private UserDatasetTableAdapters.UserDetailTableAdapter userDetailTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxLastLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit textEditDateOfBirth;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxFullName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox checkBoxChangePassword;
        private DevExpress.XtraEditors.TextEdit textEditNewPass;
        private DevExpress.XtraEditors.TextEdit textEditCurrentPass;
    }
}