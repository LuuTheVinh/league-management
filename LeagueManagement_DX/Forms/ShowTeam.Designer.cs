namespace LeagueManagement_DX.Forms
{
    partial class ShowTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTeam));
            this.groupControlTeamoverview = new DevExpress.XtraEditors.GroupControl();
            this.labelControlPosition = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlLose = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlPoint = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDraw = new DevExpress.XtraEditors.LabelControl();
            this.labelControlWin = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.customTextBoxNumberPlayer = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBoxStadium = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBoxName = new WindowsFormsControlLibrary.CustomTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.footballerList = new LeagueManagement_DX.CustomControlLibrary.FootballerList();
            this.groupControlListMatch = new DevExpress.XtraEditors.GroupControl();
            this.matchList = new LeagueManagement_DX.CustomControlLibrary.MatchList();
            this.leagueDatabaseDataSet1 = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.teamJoinTourTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamJoinTourTableAdapter();
            this.registrationTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.toursTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ToursTableAdapter();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTeamoverview)).BeginInit();
            this.groupControlTeamoverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListMatch)).BeginInit();
            this.groupControlListMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlTeamoverview
            // 
            this.groupControlTeamoverview.Controls.Add(this.labelControlPosition);
            this.groupControlTeamoverview.Controls.Add(this.labelControl19);
            this.groupControlTeamoverview.Controls.Add(this.labelControlLose);
            this.groupControlTeamoverview.Controls.Add(this.labelControl13);
            this.groupControlTeamoverview.Controls.Add(this.labelControlPoint);
            this.groupControlTeamoverview.Controls.Add(this.labelControlDraw);
            this.groupControlTeamoverview.Controls.Add(this.labelControlWin);
            this.groupControlTeamoverview.Controls.Add(this.labelControl8);
            this.groupControlTeamoverview.Controls.Add(this.labelControl6);
            this.groupControlTeamoverview.Controls.Add(this.labelControl5);
            this.groupControlTeamoverview.Location = new System.Drawing.Point(13, 182);
            this.groupControlTeamoverview.Name = "groupControlTeamoverview";
            this.groupControlTeamoverview.Size = new System.Drawing.Size(463, 98);
            this.groupControlTeamoverview.TabIndex = 5;
            this.groupControlTeamoverview.Text = "Team overview";
            // 
            // labelControlPosition
            // 
            this.labelControlPosition.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlPosition.Location = new System.Drawing.Point(279, 53);
            this.labelControlPosition.Name = "labelControlPosition";
            this.labelControlPosition.Size = new System.Drawing.Size(41, 13);
            this.labelControlPosition.TabIndex = 15;
            this.labelControlPosition.Text = "0";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(193, 53);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(37, 13);
            this.labelControl19.TabIndex = 14;
            this.labelControl19.Text = "Position";
            // 
            // labelControlLose
            // 
            this.labelControlLose.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlLose.Location = new System.Drawing.Point(65, 72);
            this.labelControlLose.Name = "labelControlLose";
            this.labelControlLose.Size = new System.Drawing.Size(41, 13);
            this.labelControlLose.TabIndex = 13;
            this.labelControlLose.Text = "0";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(18, 72);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(22, 13);
            this.labelControl13.TabIndex = 12;
            this.labelControl13.Text = "Lose";
            // 
            // labelControlPoint
            // 
            this.labelControlPoint.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlPoint.Location = new System.Drawing.Point(279, 34);
            this.labelControlPoint.Name = "labelControlPoint";
            this.labelControlPoint.Size = new System.Drawing.Size(41, 13);
            this.labelControlPoint.TabIndex = 11;
            this.labelControlPoint.Text = "0";
            // 
            // labelControlDraw
            // 
            this.labelControlDraw.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlDraw.Location = new System.Drawing.Point(65, 53);
            this.labelControlDraw.Name = "labelControlDraw";
            this.labelControlDraw.Size = new System.Drawing.Size(41, 13);
            this.labelControlDraw.TabIndex = 9;
            this.labelControlDraw.Text = "0";
            // 
            // labelControlWin
            // 
            this.labelControlWin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlWin.Location = new System.Drawing.Point(65, 34);
            this.labelControlWin.Name = "labelControlWin";
            this.labelControlWin.Size = new System.Drawing.Size(41, 13);
            this.labelControlWin.TabIndex = 8;
            this.labelControlWin.Text = "0";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(193, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Point";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Draw";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(18, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Win";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.customTextBoxNumberPlayer);
            this.groupControl1.Controls.Add(this.customTextBoxStadium);
            this.groupControl1.Controls.Add(this.customTextBoxName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(137, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(338, 147);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Team Information";
            // 
            // customTextBoxNumberPlayer
            // 
            this.customTextBoxNumberPlayer.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxNumberPlayer.Appearance.Options.UseBackColor = true;
            this.customTextBoxNumberPlayer.AutoSize = true;
            this.customTextBoxNumberPlayer.BorderColor = System.Drawing.Color.Silver;
            this.customTextBoxNumberPlayer.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxNumberPlayer.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxNumberPlayer.isRequired = true;
            this.customTextBoxNumberPlayer.Location = new System.Drawing.Point(129, 100);
            this.customTextBoxNumberPlayer.Multiline = false;
            this.customTextBoxNumberPlayer.Name = "customTextBoxNumberPlayer";
            this.customTextBoxNumberPlayer.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxNumberPlayer.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxNumberPlayer.ReadOnly = true;
            this.customTextBoxNumberPlayer.Size = new System.Drawing.Size(39, 20);
            this.customTextBoxNumberPlayer.StringPattern = "^[0-9]*$";
            this.customTextBoxNumberPlayer.TabIndex = 5;
            this.customTextBoxNumberPlayer.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxNumberPlayer.TextPanelMessage = "This is an error message.";
            this.customTextBoxNumberPlayer.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxNumberPlayer.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // customTextBoxStadium
            // 
            this.customTextBoxStadium.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxStadium.Appearance.Options.UseBackColor = true;
            this.customTextBoxStadium.AutoSize = true;
            this.customTextBoxStadium.BorderColor = System.Drawing.Color.Silver;
            this.customTextBoxStadium.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxStadium.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxStadium.isRequired = true;
            this.customTextBoxStadium.Location = new System.Drawing.Point(129, 71);
            this.customTextBoxStadium.Multiline = false;
            this.customTextBoxStadium.Name = "customTextBoxStadium";
            this.customTextBoxStadium.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxStadium.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxStadium.ReadOnly = true;
            this.customTextBoxStadium.Size = new System.Drawing.Size(178, 20);
            this.customTextBoxStadium.StringPattern = "^[a-zA-Z ]*$";
            this.customTextBoxStadium.TabIndex = 4;
            this.customTextBoxStadium.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxStadium.TextPanelMessage = "This is an error message.";
            this.customTextBoxStadium.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxStadium.ValidBorderColor = System.Drawing.Color.LightGreen;
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
            this.customTextBoxName.Location = new System.Drawing.Point(129, 43);
            this.customTextBoxName.Multiline = false;
            this.customTextBoxName.Name = "customTextBoxName";
            this.customTextBoxName.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxName.ReadOnly = true;
            this.customTextBoxName.Size = new System.Drawing.Size(178, 20);
            this.customTextBoxName.StringPattern = "^[a-zA-Z ]*$";
            this.customTextBoxName.TabIndex = 3;
            this.customTextBoxName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxName.TextPanelMessage = "This is an error message.";
            this.customTextBoxName.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxName.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Number of players";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Stadium";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(18, 25);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(106, 134);
            this.pictureEdit1.TabIndex = 3;
            // 
            // simpleButtonEdit
            // 
            this.simpleButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButtonEdit.Location = new System.Drawing.Point(320, 578);
            this.simpleButtonEdit.Name = "simpleButtonEdit";
            this.simpleButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonEdit.TabIndex = 8;
            this.simpleButtonEdit.Text = "Edit";
            this.simpleButtonEdit.Click += new System.EventHandler(this.simpleButtonEdit_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.footballerList);
            this.groupControl3.Location = new System.Drawing.Point(481, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(377, 559);
            this.groupControl3.TabIndex = 10;
            this.groupControl3.Text = "Player List";
            // 
            // footballerList
            // 
            this.footballerList.AddForm = null;
            this.footballerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footballerList.ListType = LeagueManagement_DX.CustomControlLibrary.eListType.SMALL;
            this.footballerList.Location = new System.Drawing.Point(5, 25);
            this.footballerList.Name = "footballerList";
            this.footballerList.Size = new System.Drawing.Size(367, 529);
            this.footballerList.TabIndex = 0;
            this.footballerList.TeamID = 0;
            this.footballerList.TourID = 0;
            // 
            // groupControlListMatch
            // 
            this.groupControlListMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControlListMatch.Controls.Add(this.matchList);
            this.groupControlListMatch.Location = new System.Drawing.Point(13, 286);
            this.groupControlListMatch.Name = "groupControlListMatch";
            this.groupControlListMatch.Size = new System.Drawing.Size(462, 285);
            this.groupControlListMatch.TabIndex = 11;
            this.groupControlListMatch.Text = "List Match";
            // 
            // matchList
            // 
            this.matchList.AddForm = null;
            this.matchList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchList.ListType = LeagueManagement_DX.CustomControlLibrary.eTypeControlList.MATCH;
            this.matchList.Location = new System.Drawing.Point(2, 21);
            this.matchList.Name = "matchList";
            this.matchList.Size = new System.Drawing.Size(458, 262);
            this.matchList.TabIndex = 0;
            this.matchList.TeamID = 0;
            this.matchList.TourID = 0;
            // 
            // leagueDatabaseDataSet1
            // 
            this.leagueDatabaseDataSet1.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamJoinTourTableAdapter
            // 
            this.teamJoinTourTableAdapter.ClearBeforeFill = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailTableAdapter
            // 
            this.teamDetailTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButtonClose.Location = new System.Drawing.Point(401, 578);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonClose.TabIndex = 12;
            this.simpleButtonClose.Text = "Close";
            this.simpleButtonClose.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // ShowTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(870, 613);
            this.Controls.Add(this.simpleButtonClose);
            this.Controls.Add(this.groupControlListMatch);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.simpleButtonEdit);
            this.Controls.Add(this.groupControlTeamoverview);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "ShowTeam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowTeam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowTeam_FormClosing);
            this.Load += new System.EventHandler(this.ShowTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTeamoverview)).EndInit();
            this.groupControlTeamoverview.ResumeLayout(false);
            this.groupControlTeamoverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListMatch)).EndInit();
            this.groupControlListMatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlTeamoverview;
        private DevExpress.XtraEditors.LabelControl labelControlLose;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControlPoint;
        private DevExpress.XtraEditors.LabelControl labelControlDraw;
        private DevExpress.XtraEditors.LabelControl labelControlWin;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControlPosition;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControlListMatch;
        private CustomControlLibrary.FootballerList footballerList;
        private LeagueDatabaseDataSet leagueDatabaseDataSet1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private CustomControlLibrary.MatchList matchList;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxNumberPlayer;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxStadium;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxName;
        private LeagueDatabaseDataSetTableAdapters.TeamJoinTourTableAdapter teamJoinTourTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private LeagueDatabaseDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;

    }
}