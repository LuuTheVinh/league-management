namespace LeagueManagement_DX.Forms
{
    partial class AddResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.goalOfMatchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            this.matchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.MatchTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditTeam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditHomePlayer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditGoalType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.groupControlResultInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditAwayPlayer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.customTextBoxGoalTime = new WindowsFormsControlLibrary.CustomTextBox();
            this.groupControlPlayerList = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewGoalOfMatch = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeGoal = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter();
            this.goalTypeNameTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.GoalTypeNameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTeam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHomePlayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGoalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlResultInfo)).BeginInit();
            this.groupControlResultInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAwayPlayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPlayerList)).BeginInit();
            this.groupControlPlayerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoalOfMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goalOfMatchTableAdapter
            // 
            this.goalOfMatchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardOfMatchTableAdapter = null;
            this.tableAdapterManager.FootballerTableAdapter = null;
            this.tableAdapterManager.GoalOfMatchTableAdapter = this.goalOfMatchTableAdapter;
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
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Team";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Home Player";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Time";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(238, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "TypeGoal";
            // 
            // comboBoxEditTeam
            // 
            this.comboBoxEditTeam.Location = new System.Drawing.Point(79, 29);
            this.comboBoxEditTeam.Name = "comboBoxEditTeam";
            this.comboBoxEditTeam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditTeam.Size = new System.Drawing.Size(127, 20);
            this.comboBoxEditTeam.TabIndex = 5;
            this.comboBoxEditTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditTeam_SelectedIndexChanged);
            // 
            // comboBoxEditHomePlayer
            // 
            this.comboBoxEditHomePlayer.Location = new System.Drawing.Point(79, 70);
            this.comboBoxEditHomePlayer.Name = "comboBoxEditHomePlayer";
            this.comboBoxEditHomePlayer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditHomePlayer.Size = new System.Drawing.Size(124, 20);
            this.comboBoxEditHomePlayer.TabIndex = 6;
            this.comboBoxEditHomePlayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditHomePlayer_SelectedIndexChanged);
            // 
            // comboBoxEditGoalType
            // 
            this.comboBoxEditGoalType.Location = new System.Drawing.Point(298, 114);
            this.comboBoxEditGoalType.Name = "comboBoxEditGoalType";
            this.comboBoxEditGoalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditGoalType.Size = new System.Drawing.Size(124, 20);
            this.comboBoxEditGoalType.TabIndex = 7;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(166, 179);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonAdd.TabIndex = 10;
            this.simpleButtonAdd.Text = "Add";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Location = new System.Drawing.Point(151, 408);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonOK.TabIndex = 11;
            this.simpleButtonOK.Text = "OK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(289, 408);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonCancel.TabIndex = 12;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // groupControlResultInfo
            // 
            this.groupControlResultInfo.Controls.Add(this.labelControl5);
            this.groupControlResultInfo.Controls.Add(this.comboBoxEditAwayPlayer);
            this.groupControlResultInfo.Controls.Add(this.customTextBoxGoalTime);
            this.groupControlResultInfo.Controls.Add(this.labelControl1);
            this.groupControlResultInfo.Controls.Add(this.comboBoxEditTeam);
            this.groupControlResultInfo.Controls.Add(this.labelControl2);
            this.groupControlResultInfo.Controls.Add(this.simpleButtonAdd);
            this.groupControlResultInfo.Controls.Add(this.comboBoxEditHomePlayer);
            this.groupControlResultInfo.Controls.Add(this.labelControl3);
            this.groupControlResultInfo.Controls.Add(this.comboBoxEditGoalType);
            this.groupControlResultInfo.Controls.Add(this.labelControl4);
            this.groupControlResultInfo.Location = new System.Drawing.Point(12, 12);
            this.groupControlResultInfo.Name = "groupControlResultInfo";
            this.groupControlResultInfo.Size = new System.Drawing.Size(449, 208);
            this.groupControlResultInfo.TabIndex = 13;
            this.groupControlResultInfo.Text = "Result Information";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(223, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Away Player";
            // 
            // comboBoxEditAwayPlayer
            // 
            this.comboBoxEditAwayPlayer.Location = new System.Drawing.Point(298, 70);
            this.comboBoxEditAwayPlayer.Name = "comboBoxEditAwayPlayer";
            this.comboBoxEditAwayPlayer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditAwayPlayer.Size = new System.Drawing.Size(124, 20);
            this.comboBoxEditAwayPlayer.TabIndex = 12;
            this.comboBoxEditAwayPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditAwayPlayer_SelectedIndexChanged);
            // 
            // customTextBoxGoalTime
            // 
            this.customTextBoxGoalTime.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxGoalTime.Appearance.Options.UseBackColor = true;
            this.customTextBoxGoalTime.AutoSize = true;
            this.customTextBoxGoalTime.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxGoalTime.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxGoalTime.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxGoalTime.isRequired = true;
            this.customTextBoxGoalTime.Location = new System.Drawing.Point(76, 114);
            this.customTextBoxGoalTime.Multiline = false;
            this.customTextBoxGoalTime.Name = "customTextBoxGoalTime";
            this.customTextBoxGoalTime.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxGoalTime.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxGoalTime.ReadOnly = false;
            this.customTextBoxGoalTime.Size = new System.Drawing.Size(52, 20);
            this.customTextBoxGoalTime.StringPattern = "^[0-9]{0,3}$";
            this.customTextBoxGoalTime.TabIndex = 11;
            this.customTextBoxGoalTime.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxGoalTime.TextPanelMessage = "This is an error message.";
            this.customTextBoxGoalTime.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxGoalTime.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // groupControlPlayerList
            // 
            this.groupControlPlayerList.Controls.Add(this.dataGridViewGoalOfMatch);
            this.groupControlPlayerList.Location = new System.Drawing.Point(12, 220);
            this.groupControlPlayerList.Name = "groupControlPlayerList";
            this.groupControlPlayerList.Size = new System.Drawing.Size(455, 182);
            this.groupControlPlayerList.TabIndex = 14;
            this.groupControlPlayerList.Text = "Player List";
            // 
            // dataGridViewGoalOfMatch
            // 
            this.dataGridViewGoalOfMatch.AllowUserToAddRows = false;
            this.dataGridViewGoalOfMatch.AllowUserToDeleteRows = false;
            this.dataGridViewGoalOfMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoalOfMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Player,
            this.TypeGoal,
            this.Time,
            this.MatchId,
            this.PlayerId,
            this.TeamId,
            this.GoalId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGoalOfMatch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGoalOfMatch.Location = new System.Drawing.Point(5, 24);
            this.dataGridViewGoalOfMatch.Name = "dataGridViewGoalOfMatch";
            this.dataGridViewGoalOfMatch.Size = new System.Drawing.Size(444, 150);
            this.dataGridViewGoalOfMatch.TabIndex = 10;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            // 
            // Player
            // 
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            // 
            // TypeGoal
            // 
            this.TypeGoal.HeaderText = "TypeGoal";
            this.TypeGoal.Name = "TypeGoal";
            this.TypeGoal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeGoal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // MatchId
            // 
            this.MatchId.HeaderText = "MatchId";
            this.MatchId.Name = "MatchId";
            this.MatchId.Visible = false;
            // 
            // PlayerId
            // 
            this.PlayerId.HeaderText = "PlayerId";
            this.PlayerId.Name = "PlayerId";
            this.PlayerId.Visible = false;
            // 
            // TeamId
            // 
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            this.TeamId.Visible = false;
            // 
            // GoalId
            // 
            this.GoalId.HeaderText = "GoalId";
            this.GoalId.Name = "GoalId";
            this.GoalId.Visible = false;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // goalTypeNameTableAdapter
            // 
            this.goalTypeNameTableAdapter.ClearBeforeFill = true;
            // 
            // AddResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 437);
            this.Controls.Add(this.groupControlPlayerList);
            this.Controls.Add(this.groupControlResultInfo);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonOK);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "AddResult";
            this.Text = "AddResult";
            this.Load += new System.EventHandler(this.AddResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTeam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHomePlayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGoalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlResultInfo)).EndInit();
            this.groupControlResultInfo.ResumeLayout(false);
            this.groupControlResultInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditAwayPlayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPlayerList)).EndInit();
            this.groupControlPlayerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoalOfMatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter goalOfMatchTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LeagueDatabaseDataSetTableAdapters.MatchTableAdapter matchTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTeam;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditHomePlayer;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditGoalType;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControlResultInfo;
        private DevExpress.XtraEditors.GroupControl groupControlPlayerList;
        private LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxGoalTime;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditAwayPlayer;
        private LeagueDatabaseDataSetTableAdapters.GoalTypeNameTableAdapter goalTypeNameTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewGoalOfMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalId;

    }
}