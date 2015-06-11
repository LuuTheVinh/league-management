namespace LeagueManagement_DX.Forms
{
    partial class AddTeamForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeamForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.customTextBoxStadium = new WindowsFormsControlLibrary.CustomTextBox();
            this.labelControlStadium = new DevExpress.XtraEditors.LabelControl();
            this.customTextBoxName = new WindowsFormsControlLibrary.CustomTextBox();
            this.simpleButtonBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.labelControlNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditTeamLogo = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.addPlayerBtn = new DevExpress.XtraEditors.SimpleButton();
            this.footballerDataGridView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShirtNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.footballerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet1 = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButtonRemove = new DevExpress.XtraEditors.SimpleButton();
            this.selectFootballerByTeamDataGridView = new System.Windows.Forms.DataGridView();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShirtNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectFootballerByTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.selectFootballerByTeamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditTeamLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footballerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectFootballerByTeamDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectFootballerByTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.customTextBoxStadium);
            this.groupControl1.Controls.Add(this.labelControlStadium);
            this.groupControl1.Controls.Add(this.customTextBoxName);
            this.groupControl1.Controls.Add(this.simpleButtonBrowse);
            this.groupControl1.Controls.Add(this.labelControlNumber);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.pictureEditTeamLogo);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(677, 179);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Team Information";
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
            this.customTextBoxStadium.Location = new System.Drawing.Point(189, 50);
            this.customTextBoxStadium.Multiline = false;
            this.customTextBoxStadium.Name = "customTextBoxStadium";
            this.customTextBoxStadium.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxStadium.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxStadium.ReadOnly = false;
            this.customTextBoxStadium.Size = new System.Drawing.Size(150, 20);
            this.customTextBoxStadium.StringPattern = "^[a-zA-Z \' - ]{1,15}$";
            this.customTextBoxStadium.TabIndex = 2;
            this.customTextBoxStadium.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxStadium.TextPanelMessage = "Only allow normal charaters and length is 15.";
            this.customTextBoxStadium.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxStadium.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxStadium.xTextChanged += new System.EventHandler(this.customTextBoxName_xTextChanged);
            this.customTextBoxStadium.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxName_Paint);
            // 
            // labelControlStadium
            // 
            this.labelControlStadium.Location = new System.Drawing.Point(137, 54);
            this.labelControlStadium.Name = "labelControlStadium";
            this.labelControlStadium.Size = new System.Drawing.Size(38, 13);
            this.labelControlStadium.TabIndex = 13;
            this.labelControlStadium.Text = "Stadium";
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
            this.customTextBoxName.Location = new System.Drawing.Point(189, 24);
            this.customTextBoxName.Multiline = false;
            this.customTextBoxName.Name = "customTextBoxName";
            this.customTextBoxName.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBoxName.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBoxName.ReadOnly = false;
            this.customTextBoxName.Size = new System.Drawing.Size(150, 20);
            this.customTextBoxName.StringPattern = "^[a-zA-Z  \'-]{1,30}$";
            this.customTextBoxName.TabIndex = 1;
            this.customTextBoxName.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBoxName.TextPanelMessage = "Only allow normal charaters and length is 30.";
            this.customTextBoxName.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBoxName.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBoxName.xTextChanged += new System.EventHandler(this.customTextBoxName_xTextChanged);
            this.customTextBoxName.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBoxName_Paint);
            // 
            // simpleButtonBrowse
            // 
            this.simpleButtonBrowse.Location = new System.Drawing.Point(34, 137);
            this.simpleButtonBrowse.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonBrowse.Name = "simpleButtonBrowse";
            this.simpleButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonBrowse.TabIndex = 3;
            this.simpleButtonBrowse.Text = "Browse";
            this.simpleButtonBrowse.Click += new System.EventHandler(this.simpleButtonBrowse_Click);
            // 
            // labelControlNumber
            // 
            this.labelControlNumber.Location = new System.Drawing.Point(189, 80);
            this.labelControlNumber.Name = "labelControlNumber";
            this.labelControlNumber.Size = new System.Drawing.Size(6, 13);
            this.labelControlNumber.TabIndex = 8;
            this.labelControlNumber.Text = "0";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(137, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Players";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(137, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Name";
            // 
            // pictureEditTeamLogo
            // 
            this.pictureEditTeamLogo.Location = new System.Drawing.Point(21, 24);
            this.pictureEditTeamLogo.Name = "pictureEditTeamLogo";
            this.pictureEditTeamLogo.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditTeamLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditTeamLogo.Size = new System.Drawing.Size(100, 107);
            this.pictureEditTeamLogo.TabIndex = 0;
            this.pictureEditTeamLogo.EditValueChanged += new System.EventHandler(this.pictureEditTeamLogo_EditValueChanged);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(400, 603);
            this.simpleButtonCancel.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 29);
            this.simpleButtonCancel.TabIndex = 6;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButtonOK.Location = new System.Drawing.Point(216, 603);
            this.simpleButtonOK.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButtonOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(75, 29);
            this.simpleButtonOK.TabIndex = 5;
            this.simpleButtonOK.Text = "OK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.addPlayerBtn);
            this.groupControl2.Controls.Add(this.footballerDataGridView);
            this.groupControl2.Location = new System.Drawing.Point(12, 197);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(677, 190);
            this.groupControl2.TabIndex = 20;
            this.groupControl2.Text = "Free Player List";
            // 
            // addPlayerBtn
            // 
            this.addPlayerBtn.Location = new System.Drawing.Point(10, 155);
            this.addPlayerBtn.Name = "addPlayerBtn";
            this.addPlayerBtn.Size = new System.Drawing.Size(75, 28);
            this.addPlayerBtn.TabIndex = 5;
            this.addPlayerBtn.Text = "Add";
            this.addPlayerBtn.Click += new System.EventHandler(this.addPlayerBtn_Click);
            // 
            // footballerDataGridView
            // 
            this.footballerDataGridView.AllowUserToAddRows = false;
            this.footballerDataGridView.AllowUserToDeleteRows = false;
            this.footballerDataGridView.AllowUserToResizeColumns = false;
            this.footballerDataGridView.AllowUserToResizeRows = false;
            this.footballerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footballerDataGridView.AutoGenerateColumns = false;
            this.footballerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.footballerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.PlayerName,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.ShirtNumber,
            this.Position});
            this.footballerDataGridView.DataSource = this.footballerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.footballerDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.footballerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.footballerDataGridView.Location = new System.Drawing.Point(10, 25);
            this.footballerDataGridView.MultiSelect = false;
            this.footballerDataGridView.Name = "footballerDataGridView";
            this.footballerDataGridView.RowHeadersVisible = false;
            this.footballerDataGridView.Size = new System.Drawing.Size(656, 124);
            this.footballerDataGridView.TabIndex = 0;
            this.footballerDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.footballerDataGridView_CellBeginEdit);
            this.footballerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.footballerDataGridView_CellClick);
            this.footballerDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.footballerDataGridView_CellValueChanged);
            this.footballerDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.footballerDataGridView_Paint);
            // 
            // Select
            // 
            this.Select.FalseValue = "0";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.TrueValue = "1";
            this.Select.Width = 50;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlayerName.DataPropertyName = "Name";
            this.PlayerName.HeaderText = "PlayerName";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Birth";
            this.dataGridViewTextBoxColumn3.HeaderText = "Birth";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nation";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nation";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Avatar";
            this.dataGridViewTextBoxColumn5.HeaderText = "Avatar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn6.HeaderText = "Note";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // ShirtNumber
            // 
            this.ShirtNumber.HeaderText = "ShirtNumber";
            this.ShirtNumber.Name = "ShirtNumber";
            this.ShirtNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Items.AddRange(new object[] {
            "CF",
            "RW",
            "SS",
            "LW",
            "AM",
            "RM",
            "CM",
            "LM",
            "RWB",
            "DM",
            "LWB",
            "RB",
            "CB",
            "LB",
            "SW",
            "GK"});
            this.Position.Name = "Position";
            this.Position.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // footballerBindingSource
            // 
            this.footballerBindingSource.DataMember = "Footballer";
            this.footballerBindingSource.DataSource = this.leagueDatabaseDataSet1;
            // 
            // leagueDatabaseDataSet1
            // 
            this.leagueDatabaseDataSet1.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButtonRemove);
            this.groupControl3.Controls.Add(this.selectFootballerByTeamDataGridView);
            this.groupControl3.Location = new System.Drawing.Point(12, 393);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(677, 204);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Current Player List";
            // 
            // simpleButtonRemove
            // 
            this.simpleButtonRemove.Location = new System.Drawing.Point(10, 168);
            this.simpleButtonRemove.Name = "simpleButtonRemove";
            this.simpleButtonRemove.Size = new System.Drawing.Size(75, 28);
            this.simpleButtonRemove.TabIndex = 4;
            this.simpleButtonRemove.Text = "Remove";
            this.simpleButtonRemove.Click += new System.EventHandler(this.simpleButtonRemove_Click);
            // 
            // selectFootballerByTeamDataGridView
            // 
            this.selectFootballerByTeamDataGridView.AllowUserToAddRows = false;
            this.selectFootballerByTeamDataGridView.AllowUserToDeleteRows = false;
            this.selectFootballerByTeamDataGridView.AllowUserToResizeColumns = false;
            this.selectFootballerByTeamDataGridView.AllowUserToResizeRows = false;
            this.selectFootballerByTeamDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFootballerByTeamDataGridView.AutoGenerateColumns = false;
            this.selectFootballerByTeamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectFootballerByTeamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.ShirtNumber1,
            this.Position1,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn17,
            this.tempPosition});
            this.selectFootballerByTeamDataGridView.DataSource = this.selectFootballerByTeamBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.selectFootballerByTeamDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.selectFootballerByTeamDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.selectFootballerByTeamDataGridView.Location = new System.Drawing.Point(10, 24);
            this.selectFootballerByTeamDataGridView.MultiSelect = false;
            this.selectFootballerByTeamDataGridView.Name = "selectFootballerByTeamDataGridView";
            this.selectFootballerByTeamDataGridView.RowHeadersVisible = false;
            this.selectFootballerByTeamDataGridView.Size = new System.Drawing.Size(656, 138);
            this.selectFootballerByTeamDataGridView.TabIndex = 0;
            this.selectFootballerByTeamDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectFootballerByTeamDataGridView_CellContentClick);
            this.selectFootballerByTeamDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectFootballerByTeamDataGridView_CellValueChanged);
            this.selectFootballerByTeamDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.selectFootballerByTeamDataGridView_DataError);
            this.selectFootballerByTeamDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.footballerDataGridView_Paint);
            // 
            // Id1
            // 
            this.Id1.DataPropertyName = "Id";
            this.Id1.HeaderText = "Id";
            this.Id1.Name = "Id1";
            this.Id1.ReadOnly = true;
            this.Id1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id1.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TeamId";
            this.dataGridViewTextBoxColumn8.HeaderText = "TeamId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "PlayerName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ShirtNumber1
            // 
            this.ShirtNumber1.DataPropertyName = "ShirtNumber";
            this.ShirtNumber1.HeaderText = "ShirtNumber";
            this.ShirtNumber1.Name = "ShirtNumber1";
            this.ShirtNumber1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Position1
            // 
            this.Position1.HeaderText = "Position";
            this.Position1.Items.AddRange(new object[] {
            "CF",
            "RW",
            "SS",
            "LW",
            "AM",
            "RM",
            "CM",
            "LM",
            "RWB",
            "DM",
            "LWB",
            "RB",
            "CB",
            "LB",
            "SW",
            "GK"});
            this.Position1.Name = "Position1";
            this.Position1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Birth";
            this.dataGridViewTextBoxColumn10.HeaderText = "Birth";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Nation";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nation";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn18.HeaderText = "Note";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "RedCards";
            this.dataGridViewTextBoxColumn14.HeaderText = "RedCards";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "YellowCards";
            this.dataGridViewTextBoxColumn16.HeaderText = "YellowCards";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Goals";
            this.dataGridViewTextBoxColumn15.HeaderText = "Goals";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "MatchPlayed";
            this.dataGridViewTextBoxColumn19.HeaderText = "MatchPlayed";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Avatar";
            this.dataGridViewTextBoxColumn17.HeaderText = "Avatar";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // tempPosition
            // 
            this.tempPosition.DataPropertyName = "Position";
            this.tempPosition.HeaderText = "tempPosition";
            this.tempPosition.Name = "tempPosition";
            this.tempPosition.Visible = false;
            // 
            // selectFootballerByTeamBindingSource
            // 
            this.selectFootballerByTeamBindingSource.DataMember = "SelectFootballerByTeam";
            this.selectFootballerByTeamBindingSource.DataSource = this.leagueDatabaseDataSet1;
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
            this.tableAdapterManager.GoalOfMatchTableAdapter = null;
            this.tableAdapterManager.GoalTypeNameTableAdapter = null;
            this.tableAdapterManager.MatchTableAdapter = null;
            this.tableAdapterManager.Official_StadiumTableAdapter = null;
            this.tableAdapterManager.PlayerListTableAdapter = null;
            this.tableAdapterManager.RegistrationTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.SubListTableAdapter = null;
            this.tableAdapterManager.SwitchPlayerTableAdapter = null;
            this.tableAdapterManager.TeamDetailTableAdapter = this.teamDetailTableAdapter;
            this.tableAdapterManager.TeamJoinTourTableAdapter = null;
            this.tableAdapterManager.TeamTableAdapter = this.teamTableAdapter;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailTableAdapter
            // 
            this.teamDetailTableAdapter.ClearBeforeFill = true;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // selectFootballerByTeamTableAdapter
            // 
            this.selectFootballerByTeamTableAdapter.ClearBeforeFill = true;
            // 
            // AddTeamForm
            // 
            this.AcceptButton = this.simpleButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.simpleButtonCancel;
            this.ClientSize = new System.Drawing.Size(704, 641);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "AddTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTeam_FormClosing);
            this.Load += new System.EventHandler(this.AddTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditTeamLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.footballerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectFootballerByTeamDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectFootballerByTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEditTeamLogo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBrowse;
        private DevExpress.XtraEditors.LabelControl labelControlNumber;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxName;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private System.Windows.Forms.DataGridView footballerDataGridView;
        private System.Windows.Forms.BindingSource footballerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.BindingSource selectFootballerByTeamBindingSource;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter selectFootballerByTeamTableAdapter;
        private System.Windows.Forms.DataGridView selectFootballerByTeamDataGridView;
        private DevExpress.XtraEditors.LabelControl labelControlStadium;
        private WindowsFormsControlLibrary.CustomTextBox customTextBoxStadium;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRemove;
        private LeagueDatabaseDataSet leagueDatabaseDataSet1;
        private DevExpress.XtraEditors.SimpleButton addPlayerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShirtNumber1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Position1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempPosition;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShirtNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn Position;
    }
}