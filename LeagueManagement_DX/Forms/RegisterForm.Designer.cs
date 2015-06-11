namespace LeagueManagement_DX.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox_r = new System.Windows.Forms.PictureBox();
            this.customTextBox_Stadium = new WindowsFormsControlLibrary.CustomTextBox();
            this.label_Stadium = new System.Windows.Forms.Label();
            this.customTextBox_Name = new WindowsFormsControlLibrary.CustomTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControlNumber = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Player = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Name = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditTeamLogo = new DevExpress.XtraEditors.PictureEdit();
            this.Button_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Button_Close = new DevExpress.XtraEditors.SimpleButton();
            this.label_tipscontent = new System.Windows.Forms.Label();
            this.label_Tips = new System.Windows.Forms.Label();
            this.listBoxControl_Team = new DevExpress.XtraEditors.ListBoxControl();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.checkedListBoxControl_Player = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.footballerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureEdit_player = new DevExpress.XtraEditors.PictureEdit();
            this.label_FootballerName = new System.Windows.Forms.Label();
            this.label_Birth = new System.Windows.Forms.Label();
            this.label_Nation = new System.Windows.Forms.Label();
            this.label_BirthValue = new System.Windows.Forms.Label();
            this.label_NationValue = new System.Windows.Forms.Label();
            this.pictureEdit_Image = new DevExpress.XtraEditors.PictureEdit();
            this.label_AgeValue = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_Shirt = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.comboBoxEdit_postion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.registrationTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamJoinTourTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamJoinTourTableAdapter();
            this.official_StadiumTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.Official_StadiumTableAdapter();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.richTextBox_message = new System.Windows.Forms.RichTextBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_teamlist = new System.Windows.Forms.Label();
            this.label_playerlist = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.customTextBox_ShirtValue = new WindowsFormsControlLibrary.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditTeamLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_player.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Image.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_postion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox_r);
            this.groupControl1.Controls.Add(this.customTextBox_Stadium);
            this.groupControl1.Controls.Add(this.label_Stadium);
            this.groupControl1.Controls.Add(this.customTextBox_Name);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.labelControlNumber);
            this.groupControl1.Controls.Add(this.labelControl_Player);
            this.groupControl1.Controls.Add(this.labelControl_Name);
            this.groupControl1.Controls.Add(this.pictureEditTeamLogo);
            this.groupControl1.Location = new System.Drawing.Point(12, 23);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(437, 172);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Team Infomation";
            // 
            // pictureBox_r
            // 
            this.pictureBox_r.Location = new System.Drawing.Point(332, 114);
            this.pictureBox_r.Name = "pictureBox_r";
            this.pictureBox_r.Size = new System.Drawing.Size(40, 39);
            this.pictureBox_r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_r.TabIndex = 20;
            this.pictureBox_r.TabStop = false;
            // 
            // customTextBox_Stadium
            // 
            this.customTextBox_Stadium.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_Stadium.Appearance.Options.UseBackColor = true;
            this.customTextBox_Stadium.AutoSize = true;
            this.customTextBox_Stadium.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Stadium.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Stadium.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_Stadium.isRequired = true;
            this.customTextBox_Stadium.Location = new System.Drawing.Point(246, 74);
            this.customTextBox_Stadium.Multiline = false;
            this.customTextBox_Stadium.Name = "customTextBox_Stadium";
            this.customTextBox_Stadium.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Stadium.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Stadium.ReadOnly = false;
            this.customTextBox_Stadium.Size = new System.Drawing.Size(148, 20);
            this.customTextBox_Stadium.StringPattern = "^[a-zA-Z -.\']{0,30}$";
            this.customTextBox_Stadium.TabIndex = 6;
            this.customTextBox_Stadium.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_Stadium.TextPanelMessage = "Only accept normal character";
            this.customTextBox_Stadium.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.customTextBox_Stadium, "Sân đấu trong mùa giải");
            this.customTextBox_Stadium.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_Stadium.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBox_Paint);
            // 
            // label_Stadium
            // 
            this.label_Stadium.AutoSize = true;
            this.label_Stadium.Location = new System.Drawing.Point(179, 74);
            this.label_Stadium.Name = "label_Stadium";
            this.label_Stadium.Size = new System.Drawing.Size(45, 13);
            this.label_Stadium.TabIndex = 19;
            this.label_Stadium.Text = "Stadium";
            // 
            // customTextBox_Name
            // 
            this.customTextBox_Name.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_Name.Appearance.Options.UseBackColor = true;
            this.customTextBox_Name.AutoSize = true;
            this.customTextBox_Name.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Name.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Name.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_Name.isRequired = true;
            this.customTextBox_Name.Location = new System.Drawing.Point(246, 42);
            this.customTextBox_Name.Multiline = false;
            this.customTextBox_Name.Name = "customTextBox_Name";
            this.customTextBox_Name.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Name.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Name.ReadOnly = true;
            this.customTextBox_Name.Size = new System.Drawing.Size(148, 20);
            this.customTextBox_Name.StringPattern = "^[a-zA-Z \'-]{0,30}$";
            this.customTextBox_Name.TabIndex = 5;
            this.customTextBox_Name.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_Name.TextPanelMessage = "Text wrong format";
            this.customTextBox_Name.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.customTextBox_Name, "Tên đội bóng");
            this.customTextBox_Name.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_Name.Paint += new System.Windows.Forms.PaintEventHandler(this.customTextBox_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 17;
            // 
            // labelControlNumber
            // 
            this.labelControlNumber.Location = new System.Drawing.Point(246, 111);
            this.labelControlNumber.Name = "labelControlNumber";
            this.labelControlNumber.Size = new System.Drawing.Size(6, 13);
            this.labelControlNumber.TabIndex = 8;
            this.labelControlNumber.Text = "0";
            // 
            // labelControl_Player
            // 
            this.labelControl_Player.Location = new System.Drawing.Point(182, 111);
            this.labelControl_Player.Name = "labelControl_Player";
            this.labelControl_Player.Size = new System.Drawing.Size(35, 13);
            this.labelControl_Player.TabIndex = 4;
            this.labelControl_Player.Text = "Players";
            // 
            // labelControl_Name
            // 
            this.labelControl_Name.Location = new System.Drawing.Point(182, 42);
            this.labelControl_Name.Name = "labelControl_Name";
            this.labelControl_Name.Size = new System.Drawing.Size(27, 13);
            this.labelControl_Name.TabIndex = 1;
            this.labelControl_Name.Text = "Name";
            // 
            // pictureEditTeamLogo
            // 
            this.pictureEditTeamLogo.Location = new System.Drawing.Point(23, 28);
            this.pictureEditTeamLogo.Name = "pictureEditTeamLogo";
            this.pictureEditTeamLogo.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEditTeamLogo.Properties.ReadOnly = true;
            this.pictureEditTeamLogo.Properties.ShowMenu = false;
            this.pictureEditTeamLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditTeamLogo.Size = new System.Drawing.Size(120, 120);
            this.pictureEditTeamLogo.TabIndex = 0;
            // 
            // Button_Save
            // 
            this.Button_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Button_Save.Appearance.Options.UseFont = true;
            this.Button_Save.Location = new System.Drawing.Point(595, 472);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(106, 63);
            this.Button_Save.TabIndex = 3;
            this.Button_Save.Text = "Save";
            this.Button_Save.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Button_Close.Appearance.Options.UseFont = true;
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close.Location = new System.Drawing.Point(750, 472);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(106, 63);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "Close";
            this.Button_Close.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // label_tipscontent
            // 
            this.label_tipscontent.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.label_tipscontent.Location = new System.Drawing.Point(509, 82);
            this.label_tipscontent.Name = "label_tipscontent";
            this.label_tipscontent.Size = new System.Drawing.Size(171, 113);
            this.label_tipscontent.TabIndex = 13;
            this.label_tipscontent.Text = resources.GetString("label_tipscontent.Text");
            this.toolTip1.SetToolTip(this.label_tipscontent, resources.GetString("label_tipscontent.ToolTip"));
            // 
            // label_Tips
            // 
            this.label_Tips.AutoSize = true;
            this.label_Tips.Font = new System.Drawing.Font("Tahoma", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_Tips.Location = new System.Drawing.Point(524, 58);
            this.label_Tips.Name = "label_Tips";
            this.label_Tips.Size = new System.Drawing.Size(29, 12);
            this.label_Tips.TabIndex = 16;
            this.label_Tips.Text = "Tips:";
            // 
            // listBoxControl_Team
            // 
            this.listBoxControl_Team.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.listBoxControl_Team.Appearance.Options.UseFont = true;
            this.listBoxControl_Team.DataSource = this.teamBindingSource;
            this.listBoxControl_Team.DisplayMember = "Name";
            this.listBoxControl_Team.HorizontalScrollbar = true;
            this.listBoxControl_Team.ItemHeight = 35;
            this.listBoxControl_Team.Location = new System.Drawing.Point(12, 237);
            this.listBoxControl_Team.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.listBoxControl_Team.LookAndFeel.UseDefaultLookAndFeel = false;
            this.listBoxControl_Team.Name = "listBoxControl_Team";
            this.listBoxControl_Team.Size = new System.Drawing.Size(168, 229);
            this.listBoxControl_Team.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.listBoxControl_Team.TabIndex = 1;
            this.toolTip1.SetToolTip(this.listBoxControl_Team, "Tất cả đội bóng");
            this.listBoxControl_Team.ValueMember = "Name";
            this.listBoxControl_Team.SelectedIndexChanged += new System.EventHandler(this.listBoxControl_Team_SelectedIndexChanged);
            this.listBoxControl_Team.EnabledChanged += new System.EventHandler(this.listBoxControl_Team_EnabledChanged);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkedListBoxControl_Player
            // 
            this.checkedListBoxControl_Player.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.checkedListBoxControl_Player.Appearance.Options.UseFont = true;
            this.checkedListBoxControl_Player.CheckOnClick = true;
            this.checkedListBoxControl_Player.DataSource = this.footballerBindingSource;
            this.checkedListBoxControl_Player.DisplayMember = "Name";
            this.checkedListBoxControl_Player.HorizontalScrollbar = true;
            this.checkedListBoxControl_Player.HotTrackItems = true;
            this.checkedListBoxControl_Player.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.checkedListBoxControl_Player.ItemHeight = 35;
            this.checkedListBoxControl_Player.Location = new System.Drawing.Point(255, 237);
            this.checkedListBoxControl_Player.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.checkedListBoxControl_Player.LookAndFeel.UseDefaultLookAndFeel = false;
            this.checkedListBoxControl_Player.Name = "checkedListBoxControl_Player";
            this.checkedListBoxControl_Player.Size = new System.Drawing.Size(176, 230);
            this.checkedListBoxControl_Player.TabIndex = 2;
            this.toolTip1.SetToolTip(this.checkedListBoxControl_Player, "Danh sách cầu thủ của một đội");
            this.checkedListBoxControl_Player.ValueMember = "Name";
            this.checkedListBoxControl_Player.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl_Player_ItemCheck);
            this.checkedListBoxControl_Player.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxControl_Player_SelectedIndexChanged);
            // 
            // footballerBindingSource
            // 
            this.footballerBindingSource.DataMember = "Footballer";
            this.footballerBindingSource.DataSource = this.leagueDatabaseDataSet;
            this.footballerBindingSource.CurrentItemChanged += new System.EventHandler(this.footballerBindingSource_CurrentItemChanged);
            // 
            // pictureEdit_player
            // 
            this.pictureEdit_player.EditValue = global::LeagueManagement_DX.Properties.Resources.man_icon;
            this.pictureEdit_player.Location = new System.Drawing.Point(473, 237);
            this.pictureEdit_player.Name = "pictureEdit_player";
            this.pictureEdit_player.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEdit_player.Properties.ReadOnly = true;
            this.pictureEdit_player.Properties.ShowMenu = false;
            this.pictureEdit_player.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit_player.Size = new System.Drawing.Size(170, 170);
            this.pictureEdit_player.TabIndex = 19;
            // 
            // label_FootballerName
            // 
            this.label_FootballerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.footballerBindingSource, "Name", true));
            this.label_FootballerName.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label_FootballerName.Location = new System.Drawing.Point(435, 419);
            this.label_FootballerName.Name = "label_FootballerName";
            this.label_FootballerName.Size = new System.Drawing.Size(245, 33);
            this.label_FootballerName.TabIndex = 20;
            this.label_FootballerName.Text = "Name";
            this.label_FootballerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_FootballerName.TextChanged += new System.EventHandler(this.label_FootballerName_TextChanged);
            // 
            // label_Birth
            // 
            this.label_Birth.AutoSize = true;
            this.label_Birth.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_Birth.Location = new System.Drawing.Point(679, 249);
            this.label_Birth.Name = "label_Birth";
            this.label_Birth.Size = new System.Drawing.Size(48, 19);
            this.label_Birth.TabIndex = 21;
            this.label_Birth.Text = "Birth:";
            // 
            // label_Nation
            // 
            this.label_Nation.AutoSize = true;
            this.label_Nation.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_Nation.Location = new System.Drawing.Point(679, 317);
            this.label_Nation.Name = "label_Nation";
            this.label_Nation.Size = new System.Drawing.Size(61, 19);
            this.label_Nation.TabIndex = 22;
            this.label_Nation.Text = "Nation:";
            // 
            // label_BirthValue
            // 
            this.label_BirthValue.AutoSize = true;
            this.label_BirthValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.footballerBindingSource, "Birth", true));
            this.label_BirthValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_BirthValue.Location = new System.Drawing.Point(752, 249);
            this.label_BirthValue.Name = "label_BirthValue";
            this.label_BirthValue.Size = new System.Drawing.Size(46, 19);
            this.label_BirthValue.TabIndex = 23;
            this.label_BirthValue.Text = "value";
            this.toolTip1.SetToolTip(this.label_BirthValue, "Ngày sinh");
            this.label_BirthValue.TextChanged += new System.EventHandler(this.label_BirthValue_TextChanged);
            // 
            // label_NationValue
            // 
            this.label_NationValue.AutoSize = true;
            this.label_NationValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.footballerBindingSource, "Nation", true));
            this.label_NationValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_NationValue.Location = new System.Drawing.Point(752, 317);
            this.label_NationValue.Name = "label_NationValue";
            this.label_NationValue.Size = new System.Drawing.Size(46, 19);
            this.label_NationValue.TabIndex = 24;
            this.label_NationValue.Text = "value";
            this.toolTip1.SetToolTip(this.label_NationValue, "Quốc tịch");
            this.label_NationValue.TextChanged += new System.EventHandler(this.label_NationValue_TextChanged);
            // 
            // pictureEdit_Image
            // 
            this.pictureEdit_Image.EditValue = ((object)(resources.GetObject("pictureEdit_Image.EditValue")));
            this.pictureEdit_Image.Location = new System.Drawing.Point(194, 330);
            this.pictureEdit_Image.Name = "pictureEdit_Image";
            this.pictureEdit_Image.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEdit_Image.Properties.ReadOnly = true;
            this.pictureEdit_Image.Properties.ShowMenu = false;
            this.pictureEdit_Image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit_Image.Size = new System.Drawing.Size(44, 49);
            this.pictureEdit_Image.TabIndex = 25;
            // 
            // label_AgeValue
            // 
            this.label_AgeValue.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_AgeValue.Location = new System.Drawing.Point(752, 283);
            this.label_AgeValue.Name = "label_AgeValue";
            this.label_AgeValue.Size = new System.Drawing.Size(71, 23);
            this.label_AgeValue.TabIndex = 26;
            this.label_AgeValue.Text = "Value";
            this.toolTip1.SetToolTip(this.label_AgeValue, "Tuổi");
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_Age.Location = new System.Drawing.Point(679, 283);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(43, 19);
            this.label_Age.TabIndex = 27;
            this.label_Age.Text = "Age:";
            // 
            // label_Shirt
            // 
            this.label_Shirt.AutoSize = true;
            this.label_Shirt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_Shirt.Location = new System.Drawing.Point(680, 351);
            this.label_Shirt.Name = "label_Shirt";
            this.label_Shirt.Size = new System.Drawing.Size(110, 19);
            this.label_Shirt.TabIndex = 28;
            this.label_Shirt.Text = "Shirt Number:";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_Position.Location = new System.Drawing.Point(680, 385);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(71, 19);
            this.label_Position.TabIndex = 29;
            this.label_Position.Text = "Position:";
            // 
            // comboBoxEdit_postion
            // 
            this.comboBoxEdit_postion.Location = new System.Drawing.Point(800, 384);
            this.comboBoxEdit_postion.Name = "comboBoxEdit_postion";
            this.comboBoxEdit_postion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_postion.Properties.Items.AddRange(new object[] {
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
            this.comboBoxEdit_postion.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.comboBoxEdit_postion.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.comboBoxEdit_postion.Properties.ReadOnly = true;
            this.comboBoxEdit_postion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_postion.Size = new System.Drawing.Size(60, 20);
            this.comboBoxEdit_postion.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxEdit_postion, "Vị trí thi đấu");
            this.comboBoxEdit_postion.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_postion_SelectedIndexChanged);
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardOfMatchTableAdapter = null;
            this.tableAdapterManager.FootballerTableAdapter = null;
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
            this.tableAdapterManager.TeamTableAdapter = this.teamTableAdapter;
            this.tableAdapterManager.ToursTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // teamJoinTourTableAdapter
            // 
            this.teamJoinTourTableAdapter.ClearBeforeFill = true;
            // 
            // official_StadiumTableAdapter
            // 
            this.official_StadiumTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailTableAdapter
            // 
            this.teamDetailTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox_message
            // 
            this.richTextBox_message.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBox_message.Location = new System.Drawing.Point(12, 472);
            this.richTextBox_message.Name = "richTextBox_message";
            this.richTextBox_message.ReadOnly = true;
            this.richTextBox_message.Size = new System.Drawing.Size(419, 63);
            this.richTextBox_message.TabIndex = 32;
            this.richTextBox_message.Text = "";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold);
            this.label_Message.Location = new System.Drawing.Point(12, 539);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(48, 11);
            this.label_Message.TabIndex = 33;
            this.label_Message.Text = "Message";
            // 
            // label_teamlist
            // 
            this.label_teamlist.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamlist.Location = new System.Drawing.Point(12, 212);
            this.label_teamlist.Name = "label_teamlist";
            this.label_teamlist.Size = new System.Drawing.Size(100, 23);
            this.label_teamlist.TabIndex = 34;
            this.label_teamlist.Text = "All Team";
            this.toolTip1.SetToolTip(this.label_teamlist, "Tất cả đội bóng\r\ntrong hệ thống");
            // 
            // label_playerlist
            // 
            this.label_playerlist.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerlist.Location = new System.Drawing.Point(252, 212);
            this.label_playerlist.Name = "label_playerlist";
            this.label_playerlist.Size = new System.Drawing.Size(100, 23);
            this.label_playerlist.TabIndex = 35;
            this.label_playerlist.Text = "Player List";
            this.toolTip1.SetToolTip(this.label_playerlist, "Danh sách cầu thủ của một đội");
            // 
            // customTextBox_ShirtValue
            // 
            this.customTextBox_ShirtValue.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_ShirtValue.Appearance.Options.UseBackColor = true;
            this.customTextBox_ShirtValue.AutoSize = true;
            this.customTextBox_ShirtValue.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_ShirtValue.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_ShirtValue.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_ShirtValue.isRequired = true;
            this.customTextBox_ShirtValue.Location = new System.Drawing.Point(800, 351);
            this.customTextBox_ShirtValue.Multiline = false;
            this.customTextBox_ShirtValue.Name = "customTextBox_ShirtValue";
            this.customTextBox_ShirtValue.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_ShirtValue.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_ShirtValue.ReadOnly = true;
            this.customTextBox_ShirtValue.Size = new System.Drawing.Size(60, 20);
            this.customTextBox_ShirtValue.StringPattern = "^[0-9]*$";
            this.customTextBox_ShirtValue.TabIndex = 7;
            this.customTextBox_ShirtValue.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_ShirtValue.TextPanelMessage = "This is an error message.";
            this.customTextBox_ShirtValue.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.customTextBox_ShirtValue, "Số áo đấu");
            this.customTextBox_ShirtValue.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_ShirtValue.xTextChanged += new System.EventHandler(this.customTextBox_ShirtValue_xTextChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Close;
            this.ClientSize = new System.Drawing.Size(884, 555);
            this.Controls.Add(this.label_playerlist);
            this.Controls.Add(this.label_teamlist);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.richTextBox_message);
            this.Controls.Add(this.comboBoxEdit_postion);
            this.Controls.Add(this.customTextBox_ShirtValue);
            this.Controls.Add(this.label_Position);
            this.Controls.Add(this.label_Shirt);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.label_AgeValue);
            this.Controls.Add(this.pictureEdit_Image);
            this.Controls.Add(this.label_NationValue);
            this.Controls.Add(this.label_BirthValue);
            this.Controls.Add(this.label_Nation);
            this.Controls.Add(this.label_Birth);
            this.Controls.Add(this.label_FootballerName);
            this.Controls.Add(this.pictureEdit_player);
            this.Controls.Add(this.checkedListBoxControl_Player);
            this.Controls.Add(this.listBoxControl_Team);
            this.Controls.Add(this.label_Tips);
            this.Controls.Add(this.label_tipscontent);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditTeamLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_player.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Image.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_postion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControlNumber;
        private DevExpress.XtraEditors.LabelControl labelControl_Player;
        private DevExpress.XtraEditors.LabelControl labelControl_Name;
        private DevExpress.XtraEditors.PictureEdit pictureEditTeamLogo;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_Stadium;
        private System.Windows.Forms.Label label_Stadium;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_Name;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourNameColumn;
        private System.Windows.Forms.BindingSource footballerBindingSource;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private DevExpress.XtraEditors.SimpleButton Button_Save;
        private DevExpress.XtraEditors.SimpleButton Button_Close;
        private System.Windows.Forms.Label label_tipscontent;
        private System.Windows.Forms.Label label_Tips;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_Team;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxControl_Player;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_player;
        private System.Windows.Forms.Label label_FootballerName;
        private System.Windows.Forms.Label label_Birth;
        private System.Windows.Forms.Label label_Nation;
        private System.Windows.Forms.Label label_BirthValue;
        private System.Windows.Forms.Label label_NationValue;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Image;
        private System.Windows.Forms.Label label_AgeValue;
        private System.Windows.Forms.Label label_Age;
        private LeagueDatabaseDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private LeagueDatabaseDataSetTableAdapters.TeamJoinTourTableAdapter teamJoinTourTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.Official_StadiumTableAdapter official_StadiumTableAdapter;
        private System.Windows.Forms.Label label_Shirt;
        private System.Windows.Forms.Label label_Position;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_ShirtValue;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_postion;
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.RichTextBox richTextBox_message;
        private System.Windows.Forms.Label label_teamlist;
        private System.Windows.Forms.Label label_playerlist;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox_r;
    }
}