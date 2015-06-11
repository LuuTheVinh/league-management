namespace LeagueManagement_DX.Forms
{
    partial class AddResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResultForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlMessage = new DevExpress.XtraEditors.GroupControl();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.groupControlTeamPlayerList = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControlAwayPlayerList = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControlAway = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControlHomePlayerList = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControlHome = new DevExpress.XtraEditors.LabelControl();
            this.groupControlMatchList = new DevExpress.XtraEditors.GroupControl();
            this.dateTimePickerRealDay = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlAddGoal = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonRemove = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEditTypeGoal = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditPlayer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditTeam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewGoalInformation = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControlAddPlayer = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.chklbHomePlayerList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControlAwayTeam = new DevExpress.XtraEditors.LabelControl();
            this.chklbAwayPlayerList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControlHomeTeam = new DevExpress.XtraEditors.LabelControl();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.registrationTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter();
            this.goalTypeNameTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.GoalTypeNameTableAdapter();
            this.goalOfMatchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter();
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            this.playerListTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.PlayerListTableAdapter();
            this.matchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.MatchTableAdapter();
            this.toursTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ToursTableAdapter();
            this.matchList = new LeagueManagement_DX.CustomControlLibrary.MatchList();
            this.customTextBoxTime = new WindowsFormsControlLibrary.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMessage)).BeginInit();
            this.groupControlMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTeamPlayerList)).BeginInit();
            this.groupControlTeamPlayerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlAwayPlayerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlHomePlayerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMatchList)).BeginInit();
            this.groupControlMatchList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddGoal)).BeginInit();
            this.groupControlAddGoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTypeGoal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPlayer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTeam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoalInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddPlayer)).BeginInit();
            this.groupControlAddPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklbHomePlayerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chklbAwayPlayerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 12);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControlMessage);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControlTeamPlayerList);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControlMatchList);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dateTimePickerRealDay);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButtonCancel);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButtonOK);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControlAddGoal);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControlAddPlayer);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(849, 682);
            this.splitContainerControl1.SplitterPosition = 403;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControlMessage
            // 
            this.groupControlMessage.Controls.Add(this.richTextBoxMessage);
            this.groupControlMessage.Location = new System.Drawing.Point(8, 544);
            this.groupControlMessage.Name = "groupControlMessage";
            this.groupControlMessage.Size = new System.Drawing.Size(391, 96);
            this.groupControlMessage.TabIndex = 7;
            this.groupControlMessage.Text = "Message";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(5, 24);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(381, 65);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "";
            // 
            // groupControlTeamPlayerList
            // 
            this.groupControlTeamPlayerList.Controls.Add(this.listBoxControlAwayPlayerList);
            this.groupControlTeamPlayerList.Controls.Add(this.labelControlAway);
            this.groupControlTeamPlayerList.Controls.Add(this.listBoxControlHomePlayerList);
            this.groupControlTeamPlayerList.Controls.Add(this.labelControlHome);
            this.groupControlTeamPlayerList.Location = new System.Drawing.Point(3, 326);
            this.groupControlTeamPlayerList.Name = "groupControlTeamPlayerList";
            this.groupControlTeamPlayerList.Size = new System.Drawing.Size(396, 212);
            this.groupControlTeamPlayerList.TabIndex = 6;
            this.groupControlTeamPlayerList.Text = "Team Player List";
            // 
            // listBoxControlAwayPlayerList
            // 
            this.listBoxControlAwayPlayerList.Location = new System.Drawing.Point(205, 49);
            this.listBoxControlAwayPlayerList.Name = "listBoxControlAwayPlayerList";
            this.listBoxControlAwayPlayerList.Size = new System.Drawing.Size(170, 158);
            this.listBoxControlAwayPlayerList.TabIndex = 2;
            // 
            // labelControlAway
            // 
            this.labelControlAway.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAway.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControlAway.Location = new System.Drawing.Point(268, 24);
            this.labelControlAway.Name = "labelControlAway";
            this.labelControlAway.Size = new System.Drawing.Size(39, 19);
            this.labelControlAway.TabIndex = 4;
            this.labelControlAway.Text = "Away";
            // 
            // listBoxControlHomePlayerList
            // 
            this.listBoxControlHomePlayerList.Location = new System.Drawing.Point(8, 49);
            this.listBoxControlHomePlayerList.Name = "listBoxControlHomePlayerList";
            this.listBoxControlHomePlayerList.Size = new System.Drawing.Size(170, 158);
            this.listBoxControlHomePlayerList.TabIndex = 1;
            // 
            // labelControlHome
            // 
            this.labelControlHome.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlHome.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlHome.Location = new System.Drawing.Point(61, 24);
            this.labelControlHome.Name = "labelControlHome";
            this.labelControlHome.Size = new System.Drawing.Size(42, 19);
            this.labelControlHome.TabIndex = 3;
            this.labelControlHome.Text = "Home";
            // 
            // groupControlMatchList
            // 
            this.groupControlMatchList.Controls.Add(this.matchList);
            this.groupControlMatchList.Location = new System.Drawing.Point(3, 3);
            this.groupControlMatchList.Name = "groupControlMatchList";
            this.groupControlMatchList.Size = new System.Drawing.Size(396, 317);
            this.groupControlMatchList.TabIndex = 5;
            this.groupControlMatchList.Text = "Match List";
            // 
            // dateTimePickerRealDay
            // 
            this.dateTimePickerRealDay.CustomFormat = "dd/MM/yyyy- HH:mm:ss";
            this.dateTimePickerRealDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRealDay.Location = new System.Drawing.Point(88, 286);
            this.dateTimePickerRealDay.Name = "dateTimePickerRealDay";
            this.dateTimePickerRealDay.Size = new System.Drawing.Size(166, 21);
            this.dateTimePickerRealDay.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 292);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Real Day";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(259, 637);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(85, 25);
            this.simpleButtonCancel.TabIndex = 10;
            this.simpleButtonCancel.Text = "Close";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Location = new System.Drawing.Point(121, 637);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(85, 25);
            this.simpleButtonOK.TabIndex = 9;
            this.simpleButtonOK.Text = "OK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // groupControlAddGoal
            // 
            this.groupControlAddGoal.Controls.Add(this.simpleButtonRemove);
            this.groupControlAddGoal.Controls.Add(this.customTextBoxTime);
            this.groupControlAddGoal.Controls.Add(this.simpleButtonAdd);
            this.groupControlAddGoal.Controls.Add(this.comboBoxEditTypeGoal);
            this.groupControlAddGoal.Controls.Add(this.comboBoxEditPlayer);
            this.groupControlAddGoal.Controls.Add(this.comboBoxEditTeam);
            this.groupControlAddGoal.Controls.Add(this.labelControl4);
            this.groupControlAddGoal.Controls.Add(this.labelControl3);
            this.groupControlAddGoal.Controls.Add(this.labelControl2);
            this.groupControlAddGoal.Controls.Add(this.labelControl1);
            this.groupControlAddGoal.Controls.Add(this.dataGridViewGoalInformation);
            this.groupControlAddGoal.Location = new System.Drawing.Point(10, 324);
            this.groupControlAddGoal.Name = "groupControlAddGoal";
            this.groupControlAddGoal.Size = new System.Drawing.Size(409, 307);
            this.groupControlAddGoal.TabIndex = 5;
            this.groupControlAddGoal.Text = "Goal Information";
            this.groupControlAddGoal.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControlAddGoal_Paint);
            // 
            // simpleButtonRemove
            // 
            this.simpleButtonRemove.Location = new System.Drawing.Point(317, 270);
            this.simpleButtonRemove.Name = "simpleButtonRemove";
            this.simpleButtonRemove.Size = new System.Drawing.Size(75, 33);
            this.simpleButtonRemove.TabIndex = 8;
            this.simpleButtonRemove.Text = "Remove";
            this.simpleButtonRemove.Click += new System.EventHandler(this.simpleButtonRemove_Click);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.Location = new System.Drawing.Point(283, 105);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(94, 28);
            this.simpleButtonAdd.TabIndex = 7;
            this.simpleButtonAdd.Text = "Add";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // comboBoxEditTypeGoal
            // 
            this.comboBoxEditTypeGoal.Location = new System.Drawing.Point(96, 73);
            this.comboBoxEditTypeGoal.Name = "comboBoxEditTypeGoal";
            this.comboBoxEditTypeGoal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditTypeGoal.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditTypeGoal.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditTypeGoal.TabIndex = 5;
            this.comboBoxEditTypeGoal.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxTime_Paint);
            // 
            // comboBoxEditPlayer
            // 
            this.comboBoxEditPlayer.Location = new System.Drawing.Point(96, 47);
            this.comboBoxEditPlayer.Name = "comboBoxEditPlayer";
            this.comboBoxEditPlayer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPlayer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditPlayer.Size = new System.Drawing.Size(148, 20);
            this.comboBoxEditPlayer.TabIndex = 4;
            this.comboBoxEditPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxTime_Paint);
            // 
            // comboBoxEditTeam
            // 
            this.comboBoxEditTeam.Location = new System.Drawing.Point(96, 21);
            this.comboBoxEditTeam.Name = "comboBoxEditTeam";
            this.comboBoxEditTeam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditTeam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditTeam.Size = new System.Drawing.Size(148, 20);
            this.comboBoxEditTeam.TabIndex = 3;
            this.comboBoxEditTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditTeam_SelectedIndexChanged);
            this.comboBoxEditTeam.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxTime_Paint);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 105);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Time";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Type Goal";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Player";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Team";
            // 
            // dataGridViewGoalInformation
            // 
            this.dataGridViewGoalInformation.AllowUserToAddRows = false;
            this.dataGridViewGoalInformation.AllowUserToDeleteRows = false;
            this.dataGridViewGoalInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoalInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Player,
            this.TypeGoal,
            this.Time,
            this.PlayerId,
            this.TeamId,
            this.MatchId,
            this.GoalId});
            this.dataGridViewGoalInformation.Location = new System.Drawing.Point(6, 139);
            this.dataGridViewGoalInformation.Name = "dataGridViewGoalInformation";
            this.dataGridViewGoalInformation.ReadOnly = true;
            this.dataGridViewGoalInformation.Size = new System.Drawing.Size(398, 125);
            this.dataGridViewGoalInformation.TabIndex = 0;
            this.dataGridViewGoalInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGoalInformation_CellContentClick);
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            this.Team.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Team.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Player
            // 
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            this.Player.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Player.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TypeGoal
            // 
            this.TypeGoal.HeaderText = "TypeGoal";
            this.TypeGoal.Name = "TypeGoal";
            this.TypeGoal.ReadOnly = true;
            this.TypeGoal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeGoal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 55;
            // 
            // PlayerId
            // 
            this.PlayerId.HeaderText = "PlayerId";
            this.PlayerId.Name = "PlayerId";
            this.PlayerId.ReadOnly = true;
            this.PlayerId.Visible = false;
            // 
            // TeamId
            // 
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            this.TeamId.ReadOnly = true;
            this.TeamId.Visible = false;
            // 
            // MatchId
            // 
            this.MatchId.HeaderText = "MatchId";
            this.MatchId.Name = "MatchId";
            this.MatchId.ReadOnly = true;
            this.MatchId.Visible = false;
            // 
            // GoalId
            // 
            this.GoalId.HeaderText = "GoalId";
            this.GoalId.Name = "GoalId";
            this.GoalId.ReadOnly = true;
            this.GoalId.Visible = false;
            // 
            // groupControlAddPlayer
            // 
            this.groupControlAddPlayer.Controls.Add(this.simpleButtonSubmit);
            this.groupControlAddPlayer.Controls.Add(this.chklbHomePlayerList);
            this.groupControlAddPlayer.Controls.Add(this.labelControlAwayTeam);
            this.groupControlAddPlayer.Controls.Add(this.chklbAwayPlayerList);
            this.groupControlAddPlayer.Controls.Add(this.labelControlHomeTeam);
            this.groupControlAddPlayer.Location = new System.Drawing.Point(10, 3);
            this.groupControlAddPlayer.Name = "groupControlAddPlayer";
            this.groupControlAddPlayer.Size = new System.Drawing.Size(409, 271);
            this.groupControlAddPlayer.TabIndex = 4;
            this.groupControlAddPlayer.Text = "Registed Player List";
            // 
            // simpleButtonSubmit
            // 
            this.simpleButtonSubmit.Location = new System.Drawing.Point(159, 239);
            this.simpleButtonSubmit.Name = "simpleButtonSubmit";
            this.simpleButtonSubmit.Size = new System.Drawing.Size(94, 27);
            this.simpleButtonSubmit.TabIndex = 1;
            this.simpleButtonSubmit.Text = "Submit";
            this.simpleButtonSubmit.Click += new System.EventHandler(this.simpleButtonSubmit_Click);
            // 
            // chklbHomePlayerList
            // 
            this.chklbHomePlayerList.CheckOnClick = true;
            this.chklbHomePlayerList.HotTrackItems = true;
            this.chklbHomePlayerList.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.chklbHomePlayerList.Location = new System.Drawing.Point(17, 54);
            this.chklbHomePlayerList.Name = "chklbHomePlayerList";
            this.chklbHomePlayerList.Size = new System.Drawing.Size(179, 169);
            this.chklbHomePlayerList.TabIndex = 0;
            this.chklbHomePlayerList.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chklbHomePlayerList_ItemCheck);
            // 
            // labelControlAwayTeam
            // 
            this.labelControlAwayTeam.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAwayTeam.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControlAwayTeam.Location = new System.Drawing.Point(283, 32);
            this.labelControlAwayTeam.Name = "labelControlAwayTeam";
            this.labelControlAwayTeam.Size = new System.Drawing.Size(39, 19);
            this.labelControlAwayTeam.TabIndex = 3;
            this.labelControlAwayTeam.Text = "Away";
            // 
            // chklbAwayPlayerList
            // 
            this.chklbAwayPlayerList.CheckOnClick = true;
            this.chklbAwayPlayerList.HotTrackItems = true;
            this.chklbAwayPlayerList.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.chklbAwayPlayerList.Location = new System.Drawing.Point(213, 57);
            this.chklbAwayPlayerList.Name = "chklbAwayPlayerList";
            this.chklbAwayPlayerList.Size = new System.Drawing.Size(179, 166);
            this.chklbAwayPlayerList.TabIndex = 1;
            this.chklbAwayPlayerList.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chklbAwayPlayerList_ItemCheck);
            // 
            // labelControlHomeTeam
            // 
            this.labelControlHomeTeam.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlHomeTeam.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControlHomeTeam.Location = new System.Drawing.Point(78, 29);
            this.labelControlHomeTeam.Name = "labelControlHomeTeam";
            this.labelControlHomeTeam.Size = new System.Drawing.Size(42, 19);
            this.labelControlHomeTeam.TabIndex = 2;
            this.labelControlHomeTeam.Text = "Home";
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // goalTypeNameTableAdapter
            // 
            this.goalTypeNameTableAdapter.ClearBeforeFill = true;
            // 
            // goalOfMatchTableAdapter
            // 
            this.goalOfMatchTableAdapter.ClearBeforeFill = true;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardOfMatchTableAdapter = null;
            this.tableAdapterManager.FootballerTableAdapter = this.footballerTableAdapter;
            this.tableAdapterManager.GoalOfMatchTableAdapter = this.goalOfMatchTableAdapter;
            this.tableAdapterManager.GoalTypeNameTableAdapter = this.goalTypeNameTableAdapter;
            this.tableAdapterManager.MatchTableAdapter = null;
            this.tableAdapterManager.Official_StadiumTableAdapter = null;
            this.tableAdapterManager.PlayerListTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = this.registrationTableAdapter;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.SubListTableAdapter = null;
            this.tableAdapterManager.SwitchPlayerTableAdapter = null;
            this.tableAdapterManager.TeamDetailTableAdapter = null;
            this.tableAdapterManager.TeamJoinTourTableAdapter = null;
            this.tableAdapterManager.TeamTableAdapter = this.teamTableAdapter;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerListTableAdapter
            // 
            this.playerListTableAdapter.ClearBeforeFill = true;
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // matchList
            // 
            this.matchList.AddForm = null;
            this.matchList.ListType = LeagueManagement_DX.CustomControlLibrary.eTypeControlList.MATCH;
            this.matchList.Location = new System.Drawing.Point(8, 24);
            this.matchList.Name = "matchList";
            this.matchList.Size = new System.Drawing.Size(383, 288);
            this.matchList.TabIndex = 0;
            this.matchList.TeamID = 0;
            this.matchList.TourID = 0;
            // 
            // customTextBoxTime
            // 
            this.customTextBoxTime.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBoxTime.Appearance.Options.UseBackColor = true;
            this.customTextBoxTime.AutoSize = true;
            this.customTextBoxTime.BorderColor = System.Drawing.Color.Gray;
            this.customTextBoxTime.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxTime.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBoxTime.isRequired = true;
            this.customTextBoxTime.Location = new System.Drawing.Point(96, 99);
            this.customTextBoxTime.Multiline = false;
            this.customTextBoxTime.Name = "customTextBoxTime";
            this.customTextBoxTime.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBoxTime.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxTime.ReadOnly = false;
            this.customTextBoxTime.Size = new System.Drawing.Size(43, 20);
            this.customTextBoxTime.StringPattern = "^[0-9]{1,3}$";
            this.customTextBoxTime.TabIndex = 6;
            this.customTextBoxTime.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxTime.TextPanelMessage = "Invalid value";
            this.customTextBoxTime.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxTime.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxTime.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxTime_Paint);
            // 
            // AddResultForm
            // 
            this.AcceptButton = this.simpleButtonCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 694);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximumSize = new System.Drawing.Size(889, 733);
            this.MinimumSize = new System.Drawing.Size(889, 733);
            this.Name = "AddResultForm";
            this.Text = "Create Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddResultForm_FormClosing);
            this.Load += new System.EventHandler(this.AddResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMessage)).EndInit();
            this.groupControlMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlTeamPlayerList)).EndInit();
            this.groupControlTeamPlayerList.ResumeLayout(false);
            this.groupControlTeamPlayerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlAwayPlayerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlHomePlayerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMatchList)).EndInit();
            this.groupControlMatchList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddGoal)).EndInit();
            this.groupControlAddGoal.ResumeLayout(false);
            this.groupControlAddGoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTypeGoal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPlayer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTeam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoalInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddPlayer)).EndInit();
            this.groupControlAddPlayer.ResumeLayout(false);
            this.groupControlAddPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklbHomePlayerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chklbAwayPlayerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private CustomControlLibrary.MatchList matchList;
        private DevExpress.XtraEditors.LabelControl labelControlAway;
        private DevExpress.XtraEditors.LabelControl labelControlHome;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlAwayPlayerList;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlHomePlayerList;
        private DevExpress.XtraEditors.LabelControl labelControlAwayTeam;
        private DevExpress.XtraEditors.LabelControl labelControlHomeTeam;
        private DevExpress.XtraEditors.CheckedListBoxControl chklbAwayPlayerList;
        private DevExpress.XtraEditors.CheckedListBoxControl chklbHomePlayerList;
        private DevExpress.XtraEditors.GroupControl groupControlTeamPlayerList;
        private DevExpress.XtraEditors.GroupControl groupControlMatchList;
        private DevExpress.XtraEditors.GroupControl groupControlAddGoal;
        private DevExpress.XtraEditors.GroupControl groupControlAddPlayer;
        private System.Windows.Forms.DataGridView dataGridViewGoalInformation;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.GoalTypeNameTableAdapter goalTypeNameTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.GoalOfMatchTableAdapter goalOfMatchTableAdapter;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTypeGoal;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPlayer;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTeam;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private LeagueDatabaseDataSetTableAdapters.PlayerListTableAdapter playerListTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSubmit;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalId;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemove;
        private DevExpress.XtraEditors.GroupControl groupControlMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.DateTimePicker dateTimePickerRealDay;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private LeagueDatabaseDataSetTableAdapters.MatchTableAdapter matchTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.ToursTableAdapter toursTableAdapter;


    }
}