namespace LeagueManagement_DX.Forms
{
    partial class CreateMatch
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
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.matchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.MatchTableAdapter();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.simpleButtonEditMatch = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancelMatch = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCreateMatch = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlMatchReview = new DevExpress.XtraEditors.GroupControl();
            this.labelControlDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlStadium = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAway = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHome = new DevExpress.XtraEditors.LabelControl();
            this.labelControlRound = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlShowRound = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditAway = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEditHome = new DevExpress.XtraEditors.PictureEdit();
            this.groupControlMatchInfo = new DevExpress.XtraEditors.GroupControl();
            this.customTextBoxRound = new WindowsFormsControlLibrary.CustomTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerRealDay = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerForeseeDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditAway = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditHome = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.reportTeamByTourTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ReportTeamByTourTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMatchReview)).BeginInit();
            this.groupControlMatchReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditAway.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditHome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMatchInfo)).BeginInit();
            this.groupControlMatchInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAway.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataMember = "Match";
            this.matchBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardOfMatchTableAdapter = null;
            this.tableAdapterManager.FootballerTableAdapter = null;
            this.tableAdapterManager.GoalOfMatchTableAdapter = null;
            this.tableAdapterManager.GoalTypeNameTableAdapter = null;
            this.tableAdapterManager.MatchTableAdapter = this.matchTableAdapter;
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
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButtonEditMatch
            // 
            this.simpleButtonEditMatch.Location = new System.Drawing.Point(204, 379);
            this.simpleButtonEditMatch.Name = "simpleButtonEditMatch";
            this.simpleButtonEditMatch.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEditMatch.TabIndex = 28;
            this.simpleButtonEditMatch.Text = "Edit";
            // 
            // simpleButtonCancelMatch
            // 
            this.simpleButtonCancelMatch.Location = new System.Drawing.Point(285, 379);
            this.simpleButtonCancelMatch.Name = "simpleButtonCancelMatch";
            this.simpleButtonCancelMatch.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancelMatch.TabIndex = 27;
            this.simpleButtonCancelMatch.Text = "Cancel";
            this.simpleButtonCancelMatch.Click += new System.EventHandler(this.simpleButtonCancelMatch_Click);
            // 
            // simpleButtonCreateMatch
            // 
            this.simpleButtonCreateMatch.Location = new System.Drawing.Point(123, 379);
            this.simpleButtonCreateMatch.Name = "simpleButtonCreateMatch";
            this.simpleButtonCreateMatch.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCreateMatch.TabIndex = 26;
            this.simpleButtonCreateMatch.Text = "Create";
            this.simpleButtonCreateMatch.Click += new System.EventHandler(this.simpleButtonCreateMatch_Click);
            // 
            // groupControlMatchReview
            // 
            this.groupControlMatchReview.Controls.Add(this.labelControlDate);
            this.groupControlMatchReview.Controls.Add(this.labelControl8);
            this.groupControlMatchReview.Controls.Add(this.labelControlStadium);
            this.groupControlMatchReview.Controls.Add(this.labelControl14);
            this.groupControlMatchReview.Controls.Add(this.labelControl13);
            this.groupControlMatchReview.Controls.Add(this.labelControlAway);
            this.groupControlMatchReview.Controls.Add(this.labelControlHome);
            this.groupControlMatchReview.Controls.Add(this.labelControlRound);
            this.groupControlMatchReview.Controls.Add(this.labelControl7);
            this.groupControlMatchReview.Controls.Add(this.labelControlShowRound);
            this.groupControlMatchReview.Controls.Add(this.pictureEditAway);
            this.groupControlMatchReview.Controls.Add(this.pictureEditHome);
            this.groupControlMatchReview.Location = new System.Drawing.Point(13, 150);
            this.groupControlMatchReview.Name = "groupControlMatchReview";
            this.groupControlMatchReview.Size = new System.Drawing.Size(455, 223);
            this.groupControlMatchReview.TabIndex = 25;
            this.groupControlMatchReview.Text = "Match Review";
            // 
            // labelControlDate
            // 
            this.labelControlDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControlDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlDate.Location = new System.Drawing.Point(235, 178);
            this.labelControlDate.Name = "labelControlDate";
            this.labelControlDate.Size = new System.Drawing.Size(84, 13);
            this.labelControlDate.TabIndex = 55;
            this.labelControlDate.Text = "Null";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(219, 178);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(10, 13);
            this.labelControl8.TabIndex = 54;
            this.labelControl8.Text = " | ";
            // 
            // labelControlStadium
            // 
            this.labelControlStadium.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControlStadium.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControlStadium.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlStadium.Location = new System.Drawing.Point(108, 178);
            this.labelControlStadium.Name = "labelControlStadium";
            this.labelControlStadium.Size = new System.Drawing.Size(105, 13);
            this.labelControlStadium.TabIndex = 53;
            this.labelControlStadium.Text = "Null";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(303, 23);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(27, 13);
            this.labelControl14.TabIndex = 43;
            this.labelControl14.Text = "Away";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(108, 23);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(27, 13);
            this.labelControl13.TabIndex = 43;
            this.labelControl13.Text = "Home";
            // 
            // labelControlAway
            // 
            this.labelControlAway.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlAway.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlAway.Location = new System.Drawing.Point(269, 151);
            this.labelControlAway.Name = "labelControlAway";
            this.labelControlAway.Size = new System.Drawing.Size(100, 13);
            this.labelControlAway.TabIndex = 52;
            this.labelControlAway.Text = "Null";
            // 
            // labelControlHome
            // 
            this.labelControlHome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlHome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlHome.Location = new System.Drawing.Point(75, 151);
            this.labelControlHome.Name = "labelControlHome";
            this.labelControlHome.Size = new System.Drawing.Size(100, 13);
            this.labelControlHome.TabIndex = 51;
            this.labelControlHome.Text = "Null";
            // 
            // labelControlRound
            // 
            this.labelControlRound.Location = new System.Drawing.Point(233, 198);
            this.labelControlRound.Name = "labelControlRound";
            this.labelControlRound.Size = new System.Drawing.Size(17, 13);
            this.labelControlRound.TabIndex = 41;
            this.labelControlRound.Text = "Null";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(210, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 25);
            this.labelControl7.TabIndex = 39;
            this.labelControl7.Text = "VS";
            // 
            // labelControlShowRound
            // 
            this.labelControlShowRound.Location = new System.Drawing.Point(196, 198);
            this.labelControlShowRound.Name = "labelControlShowRound";
            this.labelControlShowRound.Size = new System.Drawing.Size(38, 13);
            this.labelControlShowRound.TabIndex = 38;
            this.labelControlShowRound.Text = "Round: ";
            // 
            // pictureEditAway
            // 
            this.pictureEditAway.Location = new System.Drawing.Point(269, 42);
            this.pictureEditAway.Name = "pictureEditAway";
            this.pictureEditAway.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditAway.Size = new System.Drawing.Size(100, 100);
            this.pictureEditAway.TabIndex = 36;
            // 
            // pictureEditHome
            // 
            this.pictureEditHome.Location = new System.Drawing.Point(75, 42);
            this.pictureEditHome.Name = "pictureEditHome";
            this.pictureEditHome.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditHome.Size = new System.Drawing.Size(100, 100);
            this.pictureEditHome.TabIndex = 35;
            // 
            // groupControlMatchInfo
            // 
            this.groupControlMatchInfo.Controls.Add(this.customTextBoxRound);
            this.groupControlMatchInfo.Controls.Add(this.labelControl9);
            this.groupControlMatchInfo.Controls.Add(this.dateTimePickerRealDay);
            this.groupControlMatchInfo.Controls.Add(this.labelControl6);
            this.groupControlMatchInfo.Controls.Add(this.dateTimePickerForeseeDate);
            this.groupControlMatchInfo.Controls.Add(this.labelControl5);
            this.groupControlMatchInfo.Controls.Add(this.comboBoxEditAway);
            this.groupControlMatchInfo.Controls.Add(this.labelControl2);
            this.groupControlMatchInfo.Controls.Add(this.comboBoxEditHome);
            this.groupControlMatchInfo.Controls.Add(this.labelControl3);
            this.groupControlMatchInfo.Location = new System.Drawing.Point(13, 21);
            this.groupControlMatchInfo.Name = "groupControlMatchInfo";
            this.groupControlMatchInfo.Size = new System.Drawing.Size(455, 123);
            this.groupControlMatchInfo.TabIndex = 24;
            this.groupControlMatchInfo.Text = "Match Infomation";
            // 
            // customTextBoxRound
            // 
            this.customTextBoxRound.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxRound.Appearance.Options.UseBackColor = true;
            this.customTextBoxRound.AutoSize = true;
            this.customTextBoxRound.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxRound.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxRound.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxRound.isRequired = true;
            this.customTextBoxRound.Location = new System.Drawing.Point(75, 91);
            this.customTextBoxRound.Multiline = false;
            this.customTextBoxRound.Name = "customTextBoxRound";
            this.customTextBoxRound.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxRound.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxRound.ReadOnly = false;
            this.customTextBoxRound.Size = new System.Drawing.Size(30, 20);
            this.customTextBoxRound.StringPattern = "^[0-9]*$";
            this.customTextBoxRound.TabIndex = 40;
            this.customTextBoxRound.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxRound.TextPanelMessage = "This is an error message.";
            this.customTextBoxRound.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxRound.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(7, 91);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "Round";
            // 
            // dateTimePickerRealDay
            // 
            this.dateTimePickerRealDay.CustomFormat = "hh:mm dd/MM/yyyy";
            this.dateTimePickerRealDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRealDay.Location = new System.Drawing.Point(297, 60);
            this.dateTimePickerRealDay.Name = "dateTimePickerRealDay";
            this.dateTimePickerRealDay.Size = new System.Drawing.Size(128, 21);
            this.dateTimePickerRealDay.TabIndex = 29;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(229, 66);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Real Day";
            // 
            // dateTimePickerForeseeDate
            // 
            this.dateTimePickerForeseeDate.CustomFormat = "hh:mm dd/MM/yyyy";
            this.dateTimePickerForeseeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerForeseeDate.Location = new System.Drawing.Point(296, 33);
            this.dateTimePickerForeseeDate.Name = "dateTimePickerForeseeDate";
            this.dateTimePickerForeseeDate.Size = new System.Drawing.Size(129, 21);
            this.dateTimePickerForeseeDate.TabIndex = 27;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(229, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Foresee Day";
            // 
            // comboBoxEditAway
            // 
            this.comboBoxEditAway.Location = new System.Drawing.Point(75, 62);
            this.comboBoxEditAway.Name = "comboBoxEditAway";
            this.comboBoxEditAway.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditAway.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditAway.Size = new System.Drawing.Size(128, 20);
            this.comboBoxEditAway.TabIndex = 21;
            this.comboBoxEditAway.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditAway_SelectedIndexChanged_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Away";
            // 
            // comboBoxEditHome
            // 
            this.comboBoxEditHome.Location = new System.Drawing.Point(75, 36);
            this.comboBoxEditHome.Name = "comboBoxEditHome";
            this.comboBoxEditHome.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditHome.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditHome.Size = new System.Drawing.Size(129, 20);
            this.comboBoxEditHome.TabIndex = 19;
            this.comboBoxEditHome.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditHome_SelectedIndexChanged_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Home";
            // 
            // reportTeamByTourTableAdapter
            // 
            this.reportTeamByTourTableAdapter.ClearBeforeFill = true;
            // 
            // CreateMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 422);
            this.Controls.Add(this.simpleButtonEditMatch);
            this.Controls.Add(this.simpleButtonCancelMatch);
            this.Controls.Add(this.simpleButtonCreateMatch);
            this.Controls.Add(this.groupControlMatchReview);
            this.Controls.Add(this.groupControlMatchInfo);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "CreateMatch";
            this.Text = "Create Match";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateMatch_FormClosing);
            this.Load += new System.EventHandler(this.CreateMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMatchReview)).EndInit();
            this.groupControlMatchReview.ResumeLayout(false);
            this.groupControlMatchReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditAway.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditHome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMatchInfo)).EndInit();
            this.groupControlMatchInfo.ResumeLayout(false);
            this.groupControlMatchInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAway.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHome.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource matchBindingSource;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private LeagueDatabaseDataSetTableAdapters.MatchTableAdapter matchTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEditMatch;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancelMatch;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCreateMatch;
        private DevExpress.XtraEditors.GroupControl groupControlMatchReview;
        private DevExpress.XtraEditors.LabelControl labelControlDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControlStadium;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControlAway;
        private DevExpress.XtraEditors.LabelControl labelControlHome;
        private DevExpress.XtraEditors.LabelControl labelControlRound;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControlShowRound;
        private DevExpress.XtraEditors.PictureEdit pictureEditAway;
        private DevExpress.XtraEditors.PictureEdit pictureEditHome;
        private DevExpress.XtraEditors.GroupControl groupControlMatchInfo;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxRound;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DateTimePicker dateTimePickerRealDay;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker dateTimePickerForeseeDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditAway;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditHome;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private LeagueDatabaseDataSetTableAdapters.ReportTeamByTourTableAdapter reportTeamByTourTableAdapter;
        
    }
}