namespace LeagueManagement_DX.Forms
{
    partial class ShowFootballer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFootballer));
            this.pictureEditFootballer = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelControlPosition = new DevExpress.XtraEditors.LabelControl();
            this.customTextBoxCountry = new WindowsFormsControlLibrary.CustomTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.customTextBoxName = new WindowsFormsControlLibrary.CustomTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlShirtNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAppearance = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlGoal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonuOK = new DevExpress.XtraEditors.SimpleButton();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.selectFootballerByTeamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter();
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.registrationTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter();
            this.goalOfMatchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter();
            this.playerListTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.PlayerListTableAdapter();
            this.selectFootballerByTourTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByTourTableAdapter();
            this.selectTourbyFootballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectTourbyFootballerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditFootballer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEditFootballer
            // 
            this.pictureEditFootballer.Location = new System.Drawing.Point(12, 12);
            this.pictureEditFootballer.Name = "pictureEditFootballer";
            this.pictureEditFootballer.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditFootballer.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditFootballer.Size = new System.Drawing.Size(106, 134);
            this.pictureEditFootballer.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupControl1.Controls.Add(this.labelControlPosition);
            this.groupControl1.Controls.Add(this.customTextBoxCountry);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.customTextBoxName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControlShirtNumber);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(136, 3);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(282, 189);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Player Information";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(117, 60);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(132, 21);
            this.dateTimePickerDateOfBirth.TabIndex = 18;
            // 
            // labelControlPosition
            // 
            this.labelControlPosition.Location = new System.Drawing.Point(117, 156);
            this.labelControlPosition.Name = "labelControlPosition";
            this.labelControlPosition.Size = new System.Drawing.Size(15, 13);
            this.labelControlPosition.TabIndex = 15;
            this.labelControlPosition.Text = "CM";
            // 
            // customTextBoxCountry
            // 
            this.customTextBoxCountry.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxCountry.Appearance.Options.UseBackColor = true;
            this.customTextBoxCountry.AutoSize = true;
            this.customTextBoxCountry.BorderColor = System.Drawing.Color.Silver;
            this.customTextBoxCountry.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxCountry.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxCountry.isRequired = true;
            this.customTextBoxCountry.Location = new System.Drawing.Point(117, 94);
            this.customTextBoxCountry.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxCountry.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxCountry.Multiline = false;
            this.customTextBoxCountry.Name = "customTextBoxCountry";
            this.customTextBoxCountry.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxCountry.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxCountry.ReadOnly = true;
            this.customTextBoxCountry.Size = new System.Drawing.Size(132, 20);
            this.customTextBoxCountry.StringPattern = "^[a-zA-Z \' - /]{1,15}$";
            this.customTextBoxCountry.TabIndex = 19;
            this.customTextBoxCountry.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxCountry.TextPanelMessage = "Only allow normal characters.";
            this.customTextBoxCountry.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxCountry.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxCountry.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxName_Paint);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(30, 156);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(37, 13);
            this.labelControl10.TabIndex = 14;
            this.labelControl10.Text = "Position";
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
            this.customTextBoxName.Location = new System.Drawing.Point(117, 28);
            this.customTextBoxName.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.customTextBoxName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.customTextBoxName.Multiline = false;
            this.customTextBoxName.Name = "customTextBoxName";
            this.customTextBoxName.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxName.ReadOnly = true;
            this.customTextBoxName.Size = new System.Drawing.Size(132, 20);
            this.customTextBoxName.StringPattern = "^[a-zA-Z -\'.]{1,30}$";
            this.customTextBoxName.TabIndex = 17;
            this.customTextBoxName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxName.TextPanelMessage = "Only allow normal characters.";
            this.customTextBoxName.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxName.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxName.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxName_Paint);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Country of birth";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Date of birth";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // labelControlShirtNumber
            // 
            this.labelControlShirtNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlShirtNumber.Location = new System.Drawing.Point(117, 130);
            this.labelControlShirtNumber.Name = "labelControlShirtNumber";
            this.labelControlShirtNumber.Size = new System.Drawing.Size(41, 13);
            this.labelControlShirtNumber.TabIndex = 8;
            this.labelControlShirtNumber.Text = "9";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 130);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "ShirtNumber";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControlAppearance);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControlGoal);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Location = new System.Drawing.Point(12, 197);
            this.groupControl2.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(406, 281);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Career overview";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.tour,
            this.team});
            this.dataGridView1.Location = new System.Drawing.Point(13, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(383, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // time
            // 
            this.time.Frozen = true;
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 110;
            // 
            // tour
            // 
            this.tour.Frozen = true;
            this.tour.HeaderText = "Tour";
            this.tour.Name = "tour";
            this.tour.ReadOnly = true;
            this.tour.Width = 150;
            // 
            // team
            // 
            this.team.Frozen = true;
            this.team.HeaderText = "Team";
            this.team.Name = "team";
            this.team.ReadOnly = true;
            this.team.Width = 120;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelControl7.Location = new System.Drawing.Point(18, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Achievements";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.labelControl3.Location = new System.Drawing.Point(18, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "List team has participated";
            // 
            // labelControlAppearance
            // 
            this.labelControlAppearance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlAppearance.Location = new System.Drawing.Point(99, 43);
            this.labelControlAppearance.Name = "labelControlAppearance";
            this.labelControlAppearance.Size = new System.Drawing.Size(41, 13);
            this.labelControlAppearance.TabIndex = 13;
            this.labelControlAppearance.Text = "0";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(18, 43);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(63, 13);
            this.labelControl13.TabIndex = 12;
            this.labelControl13.Text = "Appearances";
            // 
            // labelControlGoal
            // 
            this.labelControlGoal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlGoal.Location = new System.Drawing.Point(99, 62);
            this.labelControlGoal.Name = "labelControlGoal";
            this.labelControlGoal.Size = new System.Drawing.Size(41, 13);
            this.labelControlGoal.TabIndex = 9;
            this.labelControlGoal.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 62);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Goals";
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonEdit.Location = new System.Drawing.Point(85, 503);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEdit.TabIndex = 3;
            this.simpleButtonEdit.Text = "Edit";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // simpleButtonExit
            // 
            this.simpleButtonExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonExit.Location = new System.Drawing.Point(253, 503);
            this.simpleButtonExit.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonExit.TabIndex = 22;
            this.simpleButtonExit.Text = "Exit";
            this.simpleButtonExit.Click += new System.EventHandler(this.simpleButtonExit_Click);
            // 
            // simpleButtonBrowse
            // 
            this.simpleButtonBrowse.Location = new System.Drawing.Point(26, 152);
            this.simpleButtonBrowse.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonBrowse.Name = "simpleButtonBrowse";
            this.simpleButtonBrowse.Size = new System.Drawing.Size(76, 28);
            this.simpleButtonBrowse.TabIndex = 20;
            this.simpleButtonBrowse.Text = "Browse";
            this.simpleButtonBrowse.Click += new System.EventHandler(this.simpleButtonBrowse_Click);
            // 
            // simpleButtonuOK
            // 
            this.simpleButtonuOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButtonuOK.Location = new System.Drawing.Point(85, 503);
            this.simpleButtonuOK.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonuOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonuOK.Name = "simpleButtonuOK";
            this.simpleButtonuOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonuOK.TabIndex = 21;
            this.simpleButtonuOK.Text = "OK";
            this.simpleButtonuOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
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
            // teamDetailTableAdapter
            // 
            this.teamDetailTableAdapter.ClearBeforeFill = true;
            // 
            // selectFootballerByTeamTableAdapter
            // 
            this.selectFootballerByTeamTableAdapter.ClearBeforeFill = true;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // goalOfMatchTableAdapter
            // 
            this.goalOfMatchTableAdapter.ClearBeforeFill = true;
            // 
            // playerListTableAdapter
            // 
            this.playerListTableAdapter.ClearBeforeFill = true;
            // 
            // selectFootballerByTourTableAdapter
            // 
            this.selectFootballerByTourTableAdapter.ClearBeforeFill = true;
            // 
            // selectTourbyFootballerTableAdapter
            // 
            this.selectTourbyFootballerTableAdapter.ClearBeforeFill = true;
            // 
            // ShowFootballer
            // 
            this.AcceptButton = this.simpleButtonuOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButtonExit;
            this.ClientSize = new System.Drawing.Size(437, 538);
            this.Controls.Add(this.simpleButtonuOK);
            this.Controls.Add(this.simpleButtonBrowse);
            this.Controls.Add(this.simpleButtonExit);
            this.Controls.Add(this.simpleButtonEdit);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEditFootballer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "ShowFootballer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Footballer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowFootballer_FormClosing);
            this.Load += new System.EventHandler(this.ShowFootballer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowFootballer_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditFootballer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEditFootballer;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControlGoal;
        private DevExpress.XtraEditors.LabelControl labelControlShirtNumber;
        private DevExpress.XtraEditors.LabelControl labelControlAppearance;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExit;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxCountry;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxName;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBrowse;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControlPosition;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton simpleButtonuOK;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter selectFootballerByTeamTableAdapter;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter goalOfMatchTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.PlayerListTableAdapter playerListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn team;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByTourTableAdapter selectFootballerByTourTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.SelectTourbyFootballerTableAdapter selectTourbyFootballerTableAdapter;
    }
}