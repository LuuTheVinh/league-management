namespace LeagueManagement_DX.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.userDataset = new LeagueManagement_DX.UserDataset();
            this.userDetailTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.UserDetailTableAdapter();
            this.labelControlNotify = new DevExpress.XtraEditors.LabelControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.permissionTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.PermissionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Username";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Password";
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLogin.Image")));
            this.simpleButtonLogin.Location = new System.Drawing.Point(59, 131);
            this.simpleButtonLogin.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(84, 38);
            this.simpleButtonLogin.TabIndex = 3;
            this.simpleButtonLogin.Text = "Login";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(186, 131);
            this.simpleButtonCancel.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(84, 38);
            this.simpleButtonCancel.TabIndex = 4;
            this.simpleButtonCancel.Text = "Exit";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // textEditUsername
            // 
            this.textEditUsername.Location = new System.Drawing.Point(105, 33);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Size = new System.Drawing.Size(165, 20);
            this.textEditUsername.TabIndex = 1;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(105, 72);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(165, 20);
            this.textEditPassword.TabIndex = 2;
            // 
            // userDataset
            // 
            this.userDataset.DataSetName = "UserDataset";
            this.userDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDetailTableAdapter
            // 
            this.userDetailTableAdapter.ClearBeforeFill = true;
            // 
            // labelControlNotify
            // 
            this.labelControlNotify.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlNotify.Location = new System.Drawing.Point(73, 103);
            this.labelControlNotify.Name = "labelControlNotify";
            this.labelControlNotify.Size = new System.Drawing.Size(22, 13);
            this.labelControlNotify.TabIndex = 6;
            this.labelControlNotify.Text = "label";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // permissionTableAdapter
            // 
            this.permissionTableAdapter.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.simpleButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(319, 181);
            this.Controls.Add(this.labelControlNotify);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditUsername);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonLogin);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private UserDataset userDataset;
        private UserDatasetTableAdapters.UserDetailTableAdapter userDetailTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControlNotify;
        private System.Windows.Forms.Timer timer;
        private UserDatasetTableAdapters.PermissionTableAdapter permissionTableAdapter;
    }
}