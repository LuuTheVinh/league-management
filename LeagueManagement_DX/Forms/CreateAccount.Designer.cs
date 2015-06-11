namespace LeagueManagement_DX.Forms
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerDateofbirth = new System.Windows.Forms.DateTimePicker();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataset = new LeagueManagement_DX.UserDataset();
            this.pictureEditUserAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButtonBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditSelectGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonCreate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.userDetailTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.UserDetailTableAdapter();
            this.groupTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.GroupUserTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.customTextBoxFullname = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBoxUsername = new WindowsFormsControlLibrary.CustomTextBox();
            this.tableAdapterManager = new LeagueManagement_DX.UserDatasetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelectGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Full name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Date of birth";
            // 
            // dateTimePickerDateofbirth
            // 
            this.dateTimePickerDateofbirth.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateofbirth.Location = new System.Drawing.Point(88, 126);
            this.dateTimePickerDateofbirth.Name = "dateTimePickerDateofbirth";
            this.dateTimePickerDateofbirth.Size = new System.Drawing.Size(141, 21);
            this.dateTimePickerDateofbirth.TabIndex = 4;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "UserDetail";
            this.userBindingSource.DataSource = this.userDataset;
            // 
            // userDataset
            // 
            this.userDataset.DataSetName = "UserDataset";
            this.userDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureEditUserAvatar
            // 
            this.pictureEditUserAvatar.Location = new System.Drawing.Point(313, 26);
            this.pictureEditUserAvatar.Name = "pictureEditUserAvatar";
            this.pictureEditUserAvatar.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditUserAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditUserAvatar.Size = new System.Drawing.Size(100, 112);
            this.pictureEditUserAvatar.TabIndex = 8;
            // 
            // simpleButtonBrowse
            // 
            this.simpleButtonBrowse.Location = new System.Drawing.Point(327, 144);
            this.simpleButtonBrowse.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonBrowse.Name = "simpleButtonBrowse";
            this.simpleButtonBrowse.Size = new System.Drawing.Size(75, 27);
            this.simpleButtonBrowse.TabIndex = 6;
            this.simpleButtonBrowse.Text = "Browse...";
            this.simpleButtonBrowse.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // comboBoxEditSelectGroup
            // 
            this.comboBoxEditSelectGroup.Location = new System.Drawing.Point(88, 160);
            this.comboBoxEditSelectGroup.Name = "comboBoxEditSelectGroup";
            this.comboBoxEditSelectGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditSelectGroup.Size = new System.Drawing.Size(110, 20);
            this.comboBoxEditSelectGroup.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 163);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Group";
            // 
            // simpleButtonCreate
            // 
            this.simpleButtonCreate.Location = new System.Drawing.Point(88, 226);
            this.simpleButtonCreate.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCreate.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCreate.Name = "simpleButtonCreate";
            this.simpleButtonCreate.Size = new System.Drawing.Size(75, 33);
            this.simpleButtonCreate.TabIndex = 7;
            this.simpleButtonCreate.Text = "Create";
            this.simpleButtonCreate.Click += new System.EventHandler(this.simpleButtonCreate_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(214, 226);
            this.simpleButtonCancel.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 33);
            this.simpleButtonCancel.TabIndex = 8;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // userDetailTableAdapter
            // 
            this.userDetailTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditPassword);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.customTextBoxFullname);
            this.groupControl1.Controls.Add(this.customTextBoxUsername);
            this.groupControl1.Controls.Add(this.comboBoxEditSelectGroup);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.dateTimePickerDateofbirth);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(295, 202);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Information";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxUsername_Paint);
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(88, 62);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(145, 20);
            this.textEditPassword.TabIndex = 2;
            this.textEditPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxUsername_Paint);
            // 
            // customTextBoxFullname
            // 
            this.customTextBoxFullname.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxFullname.Appearance.Options.UseBackColor = true;
            this.customTextBoxFullname.AutoSize = true;
            this.customTextBoxFullname.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxFullname.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxFullname.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxFullname.isRequired = true;
            this.customTextBoxFullname.Location = new System.Drawing.Point(88, 92);
            this.customTextBoxFullname.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxFullname.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxFullname.Multiline = false;
            this.customTextBoxFullname.Name = "customTextBoxFullname";
            this.customTextBoxFullname.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxFullname.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxFullname.ReadOnly = false;
            this.customTextBoxFullname.Size = new System.Drawing.Size(145, 20);
            this.customTextBoxFullname.StringPattern = "^[a-zA-Z ]{1,30}$";
            this.customTextBoxFullname.TabIndex = 3;
            this.customTextBoxFullname.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxFullname.TextPanelMessage = "Invalid Full name";
            this.customTextBoxFullname.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxFullname.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxFullname.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxFullname_Paint);
            // 
            // customTextBoxUsername
            // 
            this.customTextBoxUsername.AccessibleDescription = "";
            this.customTextBoxUsername.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxUsername.Appearance.Options.UseBackColor = true;
            this.customTextBoxUsername.AutoSize = true;
            this.customTextBoxUsername.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxUsername.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxUsername.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxUsername.isRequired = true;
            this.customTextBoxUsername.Location = new System.Drawing.Point(88, 26);
            this.customTextBoxUsername.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxUsername.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxUsername.Multiline = false;
            this.customTextBoxUsername.Name = "customTextBoxUsername";
            this.customTextBoxUsername.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxUsername.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxUsername.ReadOnly = false;
            this.customTextBoxUsername.Size = new System.Drawing.Size(145, 20);
            this.customTextBoxUsername.StringPattern = "^[0-9]{1,10}$";
            this.customTextBoxUsername.TabIndex = 1;
            this.customTextBoxUsername.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxUsername.TextPanelMessage = "Username must be digit";
            this.customTextBoxUsername.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxUsername.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxUsername_Paint);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupPermissionTableAdapter = null;
            this.tableAdapterManager.GroupUserTableAdapter = this.groupTableAdapter;
            this.tableAdapterManager.PermissionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LeagueManagement_DX.UserDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDetailTableAdapter = this.userDetailTableAdapter;
            // 
            // CreateAccount
            // 
            this.AcceptButton = this.simpleButtonCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(422, 271);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonCreate);
            this.Controls.Add(this.simpleButtonBrowse);
            this.Controls.Add(this.pictureEditUserAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAccount_FormClosing);
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateAccount_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditUserAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditSelectGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateofbirth;
        private DevExpress.XtraEditors.PictureEdit pictureEditUserAvatar;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBrowse;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditSelectGroup;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private UserDatasetTableAdapters.UserDetailTableAdapter userDetailTableAdapter;
        private UserDatasetTableAdapters.GroupUserTableAdapter groupTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCreate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private UserDataset userDataset;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxUsername;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxFullname;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
    }
}