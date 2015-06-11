namespace LeagueManagement_DX.Forms
{
    partial class AccountSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSetting));
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCreateAccount = new DevExpress.XtraEditors.SimpleButton();
            this.userDataset = new LeagueManagement_DX.UserDataset();
            this.userDetailTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.UserDetailTableAdapter();
            this.groupUserTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.GroupUserTableAdapter();
            this.accountListUser = new LeagueManagement_DX.CustomControlLibrary.AccountList();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(384, 280);
            this.simpleButtonCancel.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(100, 30);
            this.simpleButtonCancel.TabIndex = 2;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonCreateAccount
            // 
            this.simpleButtonCreateAccount.Location = new System.Drawing.Point(384, 12);
            this.simpleButtonCreateAccount.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCreateAccount.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCreateAccount.Name = "simpleButtonCreateAccount";
            this.simpleButtonCreateAccount.Size = new System.Drawing.Size(100, 34);
            this.simpleButtonCreateAccount.TabIndex = 1;
            this.simpleButtonCreateAccount.Text = "Create Account";
            this.simpleButtonCreateAccount.Click += new System.EventHandler(this.simpleButtonCreateAccount_Click);
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
            // groupUserTableAdapter
            // 
            this.groupUserTableAdapter.ClearBeforeFill = true;
            // 
            // accountListUser
            // 
            this.accountListUser.AddForm = null;
            this.accountListUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountListUser.ListType = LeagueManagement_DX.CustomControlLibrary.eTypeControlList.NONE;
            this.accountListUser.Location = new System.Drawing.Point(12, 12);
            this.accountListUser.Name = "accountListUser";
            this.accountListUser.Size = new System.Drawing.Size(366, 295);
            this.accountListUser.TabIndex = 0;
            this.accountListUser.Load += new System.EventHandler(this.accountList1_Load);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(384, 74);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(100, 33);
            this.simpleButtonDelete.TabIndex = 3;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // AccountSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(496, 322);
            this.Controls.Add(this.simpleButtonDelete);
            this.Controls.Add(this.simpleButtonCreateAccount);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.accountListUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximumSize = new System.Drawing.Size(512, 361);
            this.MinimumSize = new System.Drawing.Size(512, 361);
            this.Name = "AccountSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Setting";
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlLibrary.AccountList accountListUser;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCreateAccount;
        private UserDataset userDataset;
        private UserDatasetTableAdapters.UserDetailTableAdapter userDetailTableAdapter;
        private UserDatasetTableAdapters.GroupUserTableAdapter groupUserTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
    }
}