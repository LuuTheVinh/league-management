namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class AccountListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.userFullName = new DevExpress.XtraEditors.LabelControl();
            this.userGroup = new DevExpress.XtraEditors.LabelControl();
            this.groupUserTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.GroupUserTableAdapter();
            this.userDetailTableAdapter = new LeagueManagement_DX.UserDatasetTableAdapters.UserDetailTableAdapter();
            this.userDataset = new LeagueManagement_DX.UserDataset();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // userAvatar
            // 
            this.userAvatar.Location = new System.Drawing.Point(3, 3);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Properties.AllowScrollViaMouseDrag = false;
            this.userAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.userAvatar.Size = new System.Drawing.Size(59, 64);
            this.userAvatar.TabIndex = 0;
            // 
            // userFullName
            // 
            this.userFullName.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFullName.Location = new System.Drawing.Point(114, 14);
            this.userFullName.Name = "userFullName";
            this.userFullName.Size = new System.Drawing.Size(59, 16);
            this.userFullName.TabIndex = 1;
            this.userFullName.Text = "Full Name";
            // 
            // userGroup
            // 
            this.userGroup.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGroup.Location = new System.Drawing.Point(114, 44);
            this.userGroup.Name = "userGroup";
            this.userGroup.Size = new System.Drawing.Size(35, 16);
            this.userGroup.TabIndex = 2;
            this.userGroup.Text = "Group";
            // 
            // groupUserTableAdapter
            // 
            this.groupUserTableAdapter.ClearBeforeFill = true;
            // 
            // userDetailTableAdapter
            // 
            this.userDetailTableAdapter.ClearBeforeFill = true;
            // 
            // userDataset
            // 
            this.userDataset.DataSetName = "UserDataset";
            this.userDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccountListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userGroup);
            this.Controls.Add(this.userFullName);
            this.Controls.Add(this.userAvatar);
            this.Name = "AccountListItem";
            this.Size = new System.Drawing.Size(399, 70);
            this.Load += new System.EventHandler(this.AccountListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit userAvatar;
        private DevExpress.XtraEditors.LabelControl userFullName;
        private DevExpress.XtraEditors.LabelControl userGroup;
        private UserDatasetTableAdapters.GroupUserTableAdapter groupUserTableAdapter;
        private UserDatasetTableAdapters.UserDetailTableAdapter userDetailTableAdapter;
        private UserDataset userDataset;

    }
}
