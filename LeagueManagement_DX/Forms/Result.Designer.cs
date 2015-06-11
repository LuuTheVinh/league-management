namespace LeagueManagement_DX.Forms
{
    partial class Result
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewGoals = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FootballerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControlDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlStadium = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAway = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHome = new DevExpress.XtraEditors.LabelControl();
            this.labelControlRound = new DevExpress.XtraEditors.LabelControl();
            this.labelControlShowRound = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlHomeGoal = new DevExpress.XtraEditors.LabelControl();
            this.labelControlAwayGoal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTourname = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.leagueDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.toursTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ToursTableAdapter();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.goalOfMatchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter();
            this.selectFootballerByMatchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByMatchTableAdapter();
            this.resultTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControlDate);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControlStadium);
            this.groupControl1.Controls.Add(this.labelControlAway);
            this.groupControl1.Controls.Add(this.labelControlHome);
            this.groupControl1.Controls.Add(this.labelControlRound);
            this.groupControl1.Controls.Add(this.labelControlShowRound);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControlHomeGoal);
            this.groupControl1.Controls.Add(this.labelControlAwayGoal);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControlTourname);
            this.groupControl1.Controls.Add(this.pictureEdit2);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 508);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Match Result ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(156, 477);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 68;
            this.simpleButton1.Text = "Update";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(260, 477);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 67;
            this.simpleButton2.Text = "Exit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataGridViewGoals);
            this.groupControl2.Location = new System.Drawing.Point(20, 222);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(459, 249);
            this.groupControl2.TabIndex = 65;
            this.groupControl2.Text = "Goals";
            // 
            // dataGridViewGoals
            // 
            this.dataGridViewGoals.AllowUserToAddRows = false;
            this.dataGridViewGoals.AllowUserToDeleteRows = false;
            this.dataGridViewGoals.AllowUserToResizeColumns = false;
            this.dataGridViewGoals.AllowUserToResizeRows = false;
            this.dataGridViewGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.Time,
            this.TeamName,
            this.FootballerName,
            this.GoalType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGoals.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGoals.Location = new System.Drawing.Point(19, 24);
            this.dataGridViewGoals.Name = "dataGridViewGoals";
            this.dataGridViewGoals.ReadOnly = true;
            this.dataGridViewGoals.RowHeadersVisible = false;
            this.dataGridViewGoals.Size = new System.Drawing.Size(423, 220);
            this.dataGridViewGoals.TabIndex = 64;
            // 
            // Stt
            // 
            this.Stt.Frozen = true;
            this.Stt.HeaderText = "No.";
            this.Stt.Name = "Stt";
            this.Stt.ReadOnly = true;
            this.Stt.Visible = false;
            this.Stt.Width = 30;
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 50;
            // 
            // TeamName
            // 
            this.TeamName.Frozen = true;
            this.TeamName.HeaderText = "Team Name";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            this.TeamName.Width = 120;
            // 
            // FootballerName
            // 
            this.FootballerName.Frozen = true;
            this.FootballerName.HeaderText = "Footballer Name";
            this.FootballerName.Name = "FootballerName";
            this.FootballerName.ReadOnly = true;
            this.FootballerName.Width = 150;
            // 
            // GoalType
            // 
            this.GoalType.Frozen = true;
            this.GoalType.HeaderText = "Goal Type";
            this.GoalType.Name = "GoalType";
            this.GoalType.ReadOnly = true;
            // 
            // labelControlDate
            // 
            this.labelControlDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControlDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlDate.Location = new System.Drawing.Point(260, 47);
            this.labelControlDate.Name = "labelControlDate";
            this.labelControlDate.Size = new System.Drawing.Size(98, 13);
            this.labelControlDate.TabIndex = 62;
            this.labelControlDate.Text = "Null";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(244, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = " | ";
            // 
            // labelControlStadium
            // 
            this.labelControlStadium.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControlStadium.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControlStadium.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlStadium.Location = new System.Drawing.Point(133, 47);
            this.labelControlStadium.Name = "labelControlStadium";
            this.labelControlStadium.Size = new System.Drawing.Size(105, 13);
            this.labelControlStadium.TabIndex = 60;
            this.labelControlStadium.Text = "Null";
            // 
            // labelControlAway
            // 
            this.labelControlAway.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlAway.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlAway.Location = new System.Drawing.Point(308, 209);
            this.labelControlAway.Name = "labelControlAway";
            this.labelControlAway.Size = new System.Drawing.Size(100, 13);
            this.labelControlAway.TabIndex = 59;
            this.labelControlAway.Text = "Null";
            // 
            // labelControlHome
            // 
            this.labelControlHome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlHome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlHome.Location = new System.Drawing.Point(86, 208);
            this.labelControlHome.Name = "labelControlHome";
            this.labelControlHome.Size = new System.Drawing.Size(100, 13);
            this.labelControlHome.TabIndex = 58;
            this.labelControlHome.Text = "Null";
            // 
            // labelControlRound
            // 
            this.labelControlRound.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlRound.Location = new System.Drawing.Point(258, 66);
            this.labelControlRound.Name = "labelControlRound";
            this.labelControlRound.Size = new System.Drawing.Size(63, 13);
            this.labelControlRound.TabIndex = 57;
            this.labelControlRound.Text = "Null";
            // 
            // labelControlShowRound
            // 
            this.labelControlShowRound.Location = new System.Drawing.Point(221, 66);
            this.labelControlShowRound.Name = "labelControlShowRound";
            this.labelControlShowRound.Size = new System.Drawing.Size(38, 13);
            this.labelControlShowRound.TabIndex = 56;
            this.labelControlShowRound.Text = "Round: ";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(341, 84);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(27, 13);
            this.labelControl14.TabIndex = 53;
            this.labelControl14.Text = "Away";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(120, 84);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(27, 13);
            this.labelControl13.TabIndex = 54;
            this.labelControl13.Text = "Home";
            // 
            // labelControlHomeGoal
            // 
            this.labelControlHomeGoal.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.labelControlHomeGoal.Location = new System.Drawing.Point(206, 128);
            this.labelControlHomeGoal.Name = "labelControlHomeGoal";
            this.labelControlHomeGoal.Size = new System.Drawing.Size(25, 48);
            this.labelControlHomeGoal.TabIndex = 47;
            this.labelControlHomeGoal.Text = "0";
            // 
            // labelControlAwayGoal
            // 
            this.labelControlAwayGoal.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.labelControlAwayGoal.Location = new System.Drawing.Point(260, 128);
            this.labelControlAwayGoal.Name = "labelControlAwayGoal";
            this.labelControlAwayGoal.Size = new System.Drawing.Size(25, 48);
            this.labelControlAwayGoal.TabIndex = 46;
            this.labelControlAwayGoal.Text = "0";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(237, 128);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(17, 48);
            this.labelControl9.TabIndex = 45;
            this.labelControl9.Text = "-";
            // 
            // labelControlTourname
            // 
            this.labelControlTourname.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControlTourname.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlTourname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlTourname.Location = new System.Drawing.Point(86, 24);
            this.labelControlTourname.Name = "labelControlTourname";
            this.labelControlTourname.Size = new System.Drawing.Size(322, 16);
            this.labelControlTourname.TabIndex = 40;
            this.labelControlTourname.Text = "Tour Name";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Location = new System.Drawing.Point(308, 103);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(100, 100);
            this.pictureEdit2.TabIndex = 32;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(86, 103);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 100);
            this.pictureEdit1.TabIndex = 31;
            // 
            // leagueDatabaseDataSetBindingSource
            // 
            this.leagueDatabaseDataSetBindingSource.DataSource = this.leagueDatabaseDataSet;
            this.leagueDatabaseDataSetBindingSource.Position = 0;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // goalOfMatchTableAdapter
            // 
            this.goalOfMatchTableAdapter.ClearBeforeFill = true;
            // 
            // selectFootballerByMatchTableAdapter
            // 
            this.selectFootballerByMatchTableAdapter.ClearBeforeFill = true;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 524);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "Result";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControlTourname;
        private DevExpress.XtraEditors.LabelControl labelControlHomeGoal;
        private DevExpress.XtraEditors.LabelControl labelControlAwayGoal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.BindingSource leagueDatabaseDataSetBindingSource;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControlDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlStadium;
        private DevExpress.XtraEditors.LabelControl labelControlAway;
        private DevExpress.XtraEditors.LabelControl labelControlHome;
        private DevExpress.XtraEditors.LabelControl labelControlRound;
        private DevExpress.XtraEditors.LabelControl labelControlShowRound;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGridViewGoals;
        private LeagueDatabaseDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter goalOfMatchTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByMatchTableAdapter selectFootballerByMatchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FootballerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalType;
        private LeagueDatabaseDataSetTableAdapters.ResultTableAdapter resultTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}