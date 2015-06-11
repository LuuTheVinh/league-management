namespace LeagueManagement_DX.Forms
{
    partial class Footballer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Footballer));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditFootballerAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.simpleButtonBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControlStatus = new DevExpress.XtraEditors.LabelControl();
            this.customTextBoxNation = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBoxName = new WindowsFormsControlLibrary.CustomTextBox();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditFootballerAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nation";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Date of Birth";
            // 
            // pictureEditFootballerAvatar
            // 
            this.pictureEditFootballerAvatar.Location = new System.Drawing.Point(307, 53);
            this.pictureEditFootballerAvatar.Name = "pictureEditFootballerAvatar";
            this.pictureEditFootballerAvatar.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditFootballerAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditFootballerAvatar.Size = new System.Drawing.Size(91, 111);
            this.pictureEditFootballerAvatar.TabIndex = 3;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(106, 121);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(127, 21);
            this.dateTimePickerDateOfBirth.TabIndex = 3;
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfBirth_ValueChanged);
            // 
            // simpleButtonBrowse
            // 
            this.simpleButtonBrowse.Location = new System.Drawing.Point(315, 166);
            this.simpleButtonBrowse.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonBrowse.Name = "simpleButtonBrowse";
            this.simpleButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonBrowse.TabIndex = 4;
            this.simpleButtonBrowse.Text = "Browse";
            this.simpleButtonBrowse.Click += new System.EventHandler(this.simpleButtonBrowse_Click);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(120, 222);
            this.simpleButtonAdd.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonAdd.TabIndex = 5;
            this.simpleButtonAdd.Text = "OK";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(220, 222);
            this.simpleButtonCancel.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 6;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(319, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Profile picture";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControlStatus);
            this.groupControl1.Controls.Add(this.customTextBoxNation);
            this.groupControl1.Controls.Add(this.customTextBoxName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.simpleButtonCancel);
            this.groupControl1.Controls.Add(this.simpleButtonAdd);
            this.groupControl1.Controls.Add(this.simpleButtonBrowse);
            this.groupControl1.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupControl1.Controls.Add(this.pictureEditFootballerAvatar);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(430, 261);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Infomation";
            // 
            // labelControlStatus
            // 
            this.labelControlStatus.Location = new System.Drawing.Point(28, 171);
            this.labelControlStatus.Name = "labelControlStatus";
            this.labelControlStatus.Size = new System.Drawing.Size(63, 13);
            this.labelControlStatus.TabIndex = 1;
            this.labelControlStatus.Text = "labelControl5";
            // 
            // customTextBoxNation
            // 
            this.customTextBoxNation.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxNation.Appearance.Options.UseBackColor = true;
            this.customTextBoxNation.AutoSize = true;
            this.customTextBoxNation.BorderColor = System.Drawing.Color.Silver;
            this.customTextBoxNation.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxNation.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxNation.isRequired = true;
            this.customTextBoxNation.Location = new System.Drawing.Point(106, 86);
            this.customTextBoxNation.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxNation.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxNation.Multiline = false;
            this.customTextBoxNation.Name = "customTextBoxNation";
            this.customTextBoxNation.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxNation.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxNation.ReadOnly = false;
            this.customTextBoxNation.Size = new System.Drawing.Size(145, 20);
            this.customTextBoxNation.StringPattern = "^[a-zA-Z ]{1,15}$";
            this.customTextBoxNation.TabIndex = 2;
            this.customTextBoxNation.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxNation.TextPanelMessage = "Only allow normal characters.";
            this.customTextBoxNation.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxNation.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxNation.Click += new System.EventHandler(this.customTextBoxNation_Click);
            this.customTextBoxNation.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxName_Paint);
            // 
            // customTextBoxName
            // 
            this.customTextBoxName.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxName.Appearance.Options.UseBackColor = true;
            this.customTextBoxName.AutoSize = true;
            this.customTextBoxName.BorderColor = System.Drawing.Color.Silver;
            this.customTextBoxName.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxName.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxName.isRequired = true;
            this.customTextBoxName.Location = new System.Drawing.Point(106, 53);
            this.customTextBoxName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxName.Multiline = false;
            this.customTextBoxName.Name = "customTextBoxName";
            this.customTextBoxName.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxName.ReadOnly = false;
            this.customTextBoxName.Size = new System.Drawing.Size(145, 20);
            this.customTextBoxName.StringPattern = "^[a-zA-Z\' ]{1,20}$";
            this.customTextBoxName.TabIndex = 1;
            this.customTextBoxName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxName.TextPanelMessage = "Only allow normal characters.";
            this.customTextBoxName.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxName.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxName.Click += new System.EventHandler(this.customTextBoxName_Click);
            this.customTextBoxName.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxName_Paint);
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardOfMatchTableAdapter = null;
            this.tableAdapterManager.FootballerTableAdapter = this.footballerTableAdapter;
            this.tableAdapterManager.GoalOfMatchTableAdapter = null;
            this.tableAdapterManager.GoalTypeNameTableAdapter = null;
            this.tableAdapterManager.MatchTableAdapter = null;
            this.tableAdapterManager.Official_StadiumTableAdapter = null;
            this.tableAdapterManager.PlayerListTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.SubListTableAdapter = null;
            this.tableAdapterManager.SwitchPlayerTableAdapter = null;
            this.tableAdapterManager.TeamDetailTableAdapter = null;
            this.tableAdapterManager.TeamJoinTourTableAdapter = null;
            this.tableAdapterManager.TeamTableAdapter = null;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Footballer
            // 
            this.AcceptButton = this.simpleButtonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(460, 285);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximumSize = new System.Drawing.Size(476, 324);
            this.MinimumSize = new System.Drawing.Size(476, 324);
            this.Name = "Footballer";
            this.Text = "Create Footballer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Footballer_FormClosing);
            this.Load += new System.EventHandler(this.Footballer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditFootballerAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEditFootballerAvatar;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBrowse;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxNation;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxName;
        private DevExpress.XtraEditors.LabelControl labelControlStatus;
    }
}