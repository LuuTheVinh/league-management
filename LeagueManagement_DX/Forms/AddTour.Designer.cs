namespace LeagueManagement_DX.Forms
{
    partial class AddTour
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
            this.group_general = new DevExpress.XtraEditors.GroupControl();
            this.nameTextBox = new WindowsFormsControlLibrary.CustomTextBox();
            this.dateTimePicker_Enddate = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePicker_Begindate = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit_advanced = new DevExpress.XtraEditors.CheckEdit();
            this.group_setting = new DevExpress.XtraEditors.GroupControl();
            this.trackBar_matchtime = new System.Windows.Forms.TrackBar();
            this.customTextBox_MaxSwitch = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_MaxSub = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_MatchTime = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_Round = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_Lose = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_Draw = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_Win = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_ForeignMax = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_ForeignMin = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_AgeMin = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_AgeMax = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_NumberPlayerMax = new WindowsFormsControlLibrary.CustomTextBox();
            this.customTextBox_NumberMin = new WindowsFormsControlLibrary.CustomTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit_priority = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Okbutton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit_Logo = new DevExpress.XtraEditors.PictureEdit();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.group_general)).BeginInit();
            this.group_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_advanced.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_setting)).BeginInit();
            this.group_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_matchtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_priority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Logo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // group_general
            // 
            this.group_general.Controls.Add(this.nameTextBox);
            this.group_general.Controls.Add(this.dateTimePicker_Enddate);
            this.group_general.Controls.Add(this.labelControl3);
            this.group_general.Controls.Add(this.dateTimePicker_Begindate);
            this.group_general.Controls.Add(this.labelControl2);
            this.group_general.Controls.Add(this.labelControl1);
            this.group_general.Location = new System.Drawing.Point(12, 22);
            this.group_general.Name = "group_general";
            this.group_general.Size = new System.Drawing.Size(312, 104);
            this.group_general.TabIndex = 0;
            this.group_general.Text = "General";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Appearance.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Appearance.Options.UseBackColor = true;
            this.nameTextBox.AutoSize = true;
            this.nameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.nameTextBox.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.nameTextBox.HoverBorderColor = System.Drawing.Color.Cyan;
            this.nameTextBox.isRequired = true;
            this.nameTextBox.Location = new System.Drawing.Point(75, 33);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.NormalBorderColor = System.Drawing.Color.Gray;
            this.nameTextBox.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.nameTextBox.ReadOnly = false;
            this.nameTextBox.Size = new System.Drawing.Size(196, 20);
            this.nameTextBox.StringPattern = "^[a-zA-Z0-9 ]{0,30}$";
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.nameTextBox.TextPanelMessage = "Only accep normal character";
            this.nameTextBox.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.nameTextBox, "Tên giải đấu");
            this.nameTextBox.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.nameTextBox.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.nameTextBox.Click += new System.EventHandler(this.nameTextBox_Click);
            this.nameTextBox.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // dateTimePicker_Enddate
            // 
            this.dateTimePicker_Enddate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_Enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Enddate.Location = new System.Drawing.Point(200, 63);
            this.dateTimePicker_Enddate.Name = "dateTimePicker_Enddate";
            this.dateTimePicker_Enddate.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker_Enddate.TabIndex = 3;
            this.toolTipController1.SetToolTip(this.dateTimePicker_Enddate, "Ngày kết thúc");
            this.dateTimePicker_Enddate.Value = new System.DateTime(2015, 6, 15, 0, 0, 0, 0);
            this.dateTimePicker_Enddate.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(183, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(10, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "to";
            // 
            // dateTimePicker_Begindate
            // 
            this.dateTimePicker_Begindate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_Begindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Begindate.Location = new System.Drawing.Point(75, 63);
            this.dateTimePicker_Begindate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Begindate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Begindate.Name = "dateTimePicker_Begindate";
            this.dateTimePicker_Begindate.Size = new System.Drawing.Size(101, 21);
            this.dateTimePicker_Begindate.TabIndex = 2;
            this.toolTipController1.SetToolTip(this.dateTimePicker_Begindate, "Ngày bắt đầu");
            this.dateTimePicker_Begindate.Value = new System.DateTime(2014, 8, 15, 8, 34, 0, 0);
            this.dateTimePicker_Begindate.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Time";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name";
            // 
            // checkEdit_advanced
            // 
            this.checkEdit_advanced.Location = new System.Drawing.Point(377, 132);
            this.checkEdit_advanced.Name = "checkEdit_advanced";
            this.checkEdit_advanced.Properties.Caption = "Advanced";
            this.checkEdit_advanced.Size = new System.Drawing.Size(75, 19);
            this.checkEdit_advanced.TabIndex = 1;
            this.checkEdit_advanced.CheckStateChanged += new System.EventHandler(this.checkEdit1_CheckStateChanged);
            // 
            // group_setting
            // 
            this.group_setting.Controls.Add(this.trackBar_matchtime);
            this.group_setting.Controls.Add(this.customTextBox_MaxSwitch);
            this.group_setting.Controls.Add(this.customTextBox_MaxSub);
            this.group_setting.Controls.Add(this.customTextBox_MatchTime);
            this.group_setting.Controls.Add(this.customTextBox_Round);
            this.group_setting.Controls.Add(this.customTextBox_Lose);
            this.group_setting.Controls.Add(this.customTextBox_Draw);
            this.group_setting.Controls.Add(this.customTextBox_Win);
            this.group_setting.Controls.Add(this.customTextBox_ForeignMax);
            this.group_setting.Controls.Add(this.customTextBox_ForeignMin);
            this.group_setting.Controls.Add(this.customTextBox_AgeMin);
            this.group_setting.Controls.Add(this.customTextBox_AgeMax);
            this.group_setting.Controls.Add(this.customTextBox_NumberPlayerMax);
            this.group_setting.Controls.Add(this.customTextBox_NumberMin);
            this.group_setting.Controls.Add(this.labelControl9);
            this.group_setting.Controls.Add(this.labelControl7);
            this.group_setting.Controls.Add(this.labelControl23);
            this.group_setting.Controls.Add(this.labelControl22);
            this.group_setting.Controls.Add(this.labelControl21);
            this.group_setting.Controls.Add(this.labelControl20);
            this.group_setting.Controls.Add(this.labelControl19);
            this.group_setting.Controls.Add(this.labelControl18);
            this.group_setting.Controls.Add(this.labelControl15);
            this.group_setting.Controls.Add(this.labelControl16);
            this.group_setting.Controls.Add(this.labelControl17);
            this.group_setting.Controls.Add(this.labelControl14);
            this.group_setting.Controls.Add(this.labelControl11);
            this.group_setting.Controls.Add(this.labelControl8);
            this.group_setting.Controls.Add(this.labelControl6);
            this.group_setting.Controls.Add(this.comboBoxEdit_priority);
            this.group_setting.Controls.Add(this.labelControl5);
            this.group_setting.Location = new System.Drawing.Point(12, 155);
            this.group_setting.Name = "group_setting";
            this.group_setting.Size = new System.Drawing.Size(440, 324);
            this.group_setting.TabIndex = 2;
            this.group_setting.Text = "Advanced Setting";
            this.group_setting.Visible = false;
            this.group_setting.VisibleChanged += new System.EventHandler(this.groupControl2_VisibleChanged);
            // 
            // trackBar_matchtime
            // 
            this.trackBar_matchtime.Location = new System.Drawing.Point(113, 179);
            this.trackBar_matchtime.Maximum = 120;
            this.trackBar_matchtime.Minimum = 45;
            this.trackBar_matchtime.Name = "trackBar_matchtime";
            this.trackBar_matchtime.Size = new System.Drawing.Size(184, 45);
            this.trackBar_matchtime.TabIndex = 16;
            this.trackBar_matchtime.TickFrequency = 5;
            this.trackBar_matchtime.Value = 90;
            this.trackBar_matchtime.Scroll += new System.EventHandler(this.trackBar_matchtime_Scroll);
            // 
            // customTextBox_MaxSwitch
            // 
            this.customTextBox_MaxSwitch.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_MaxSwitch.Appearance.Options.UseBackColor = true;
            this.customTextBox_MaxSwitch.AutoSize = true;
            this.customTextBox_MaxSwitch.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_MaxSwitch.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_MaxSwitch.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_MaxSwitch.isRequired = true;
            this.customTextBox_MaxSwitch.Location = new System.Drawing.Point(136, 286);
            this.customTextBox_MaxSwitch.Multiline = false;
            this.customTextBox_MaxSwitch.Name = "customTextBox_MaxSwitch";
            this.customTextBox_MaxSwitch.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_MaxSwitch.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_MaxSwitch.ReadOnly = false;
            this.customTextBox_MaxSwitch.Size = new System.Drawing.Size(40, 20);
            this.customTextBox_MaxSwitch.StringPattern = "^[0-9]*$";
            this.customTextBox_MaxSwitch.TabIndex = 20;
            this.customTextBox_MaxSwitch.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_MaxSwitch.TextPanelMessage = "Only accept number";
            this.customTextBox_MaxSwitch.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_MaxSwitch, "Số lần thay người");
            this.customTextBox_MaxSwitch.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_MaxSwitch.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_MaxSwitch.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_MaxSub
            // 
            this.customTextBox_MaxSub.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_MaxSub.Appearance.Options.UseBackColor = true;
            this.customTextBox_MaxSub.AutoSize = true;
            this.customTextBox_MaxSub.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_MaxSub.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_MaxSub.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_MaxSub.isRequired = true;
            this.customTextBox_MaxSub.Location = new System.Drawing.Point(136, 260);
            this.customTextBox_MaxSub.Multiline = false;
            this.customTextBox_MaxSub.Name = "customTextBox_MaxSub";
            this.customTextBox_MaxSub.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_MaxSub.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_MaxSub.ReadOnly = false;
            this.customTextBox_MaxSub.Size = new System.Drawing.Size(40, 20);
            this.customTextBox_MaxSub.StringPattern = "^[0-9]*$";
            this.customTextBox_MaxSub.TabIndex = 19;
            this.customTextBox_MaxSub.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_MaxSub.TextPanelMessage = "Only accept number";
            this.customTextBox_MaxSub.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_MaxSub, "Sô cầu thủ dự bị");
            this.customTextBox_MaxSub.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_MaxSub.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_MaxSub.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_MatchTime
            // 
            this.customTextBox_MatchTime.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_MatchTime.Appearance.Options.UseBackColor = true;
            this.customTextBox_MatchTime.AutoSize = true;
            this.customTextBox_MatchTime.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_MatchTime.Enabled = false;
            this.customTextBox_MatchTime.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_MatchTime.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_MatchTime.isRequired = true;
            this.customTextBox_MatchTime.Location = new System.Drawing.Point(303, 183);
            this.customTextBox_MatchTime.Multiline = false;
            this.customTextBox_MatchTime.Name = "customTextBox_MatchTime";
            this.customTextBox_MatchTime.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_MatchTime.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_MatchTime.ReadOnly = false;
            this.customTextBox_MatchTime.Size = new System.Drawing.Size(30, 20);
            this.customTextBox_MatchTime.StringPattern = "^[0-9]*$";
            this.customTextBox_MatchTime.TabIndex = 17;
            this.customTextBox_MatchTime.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_MatchTime.TextPanelMessage = "Only accept number";
            this.customTextBox_MatchTime.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_MatchTime, "Thời gian tối đa mỗi trận");
            this.customTextBox_MatchTime.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_MatchTime.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_MatchTime.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_Round
            // 
            this.customTextBox_Round.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_Round.Appearance.Options.UseBackColor = true;
            this.customTextBox_Round.AutoSize = true;
            this.customTextBox_Round.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Round.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Round.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_Round.isRequired = true;
            this.customTextBox_Round.Location = new System.Drawing.Point(114, 153);
            this.customTextBox_Round.Multiline = false;
            this.customTextBox_Round.Name = "customTextBox_Round";
            this.customTextBox_Round.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Round.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Round.ReadOnly = false;
            this.customTextBox_Round.Size = new System.Drawing.Size(55, 20);
            this.customTextBox_Round.StringPattern = "^[0-9]*$";
            this.customTextBox_Round.TabIndex = 15;
            this.customTextBox_Round.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_Round.TextPanelMessage = "Only accept number";
            this.customTextBox_Round.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_Round, "Số vòng đấu tối đa");
            this.customTextBox_Round.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_Round.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_Round.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_Lose
            // 
            this.customTextBox_Lose.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_Lose.Appearance.Options.UseBackColor = true;
            this.customTextBox_Lose.AutoSize = true;
            this.customTextBox_Lose.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Lose.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Lose.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_Lose.isRequired = true;
            this.customTextBox_Lose.Location = new System.Drawing.Point(270, 127);
            this.customTextBox_Lose.Multiline = false;
            this.customTextBox_Lose.Name = "customTextBox_Lose";
            this.customTextBox_Lose.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Lose.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Lose.ReadOnly = false;
            this.customTextBox_Lose.Size = new System.Drawing.Size(30, 20);
            this.customTextBox_Lose.StringPattern = "^[0-9]*$";
            this.customTextBox_Lose.TabIndex = 14;
            this.customTextBox_Lose.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_Lose.TextPanelMessage = "Only accept number";
            this.customTextBox_Lose.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_Lose, "Số điểm cho mỗi trận thua");
            this.customTextBox_Lose.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_Lose.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_Lose.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_Draw
            // 
            this.customTextBox_Draw.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_Draw.Appearance.Options.UseBackColor = true;
            this.customTextBox_Draw.AutoSize = true;
            this.customTextBox_Draw.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Draw.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Draw.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_Draw.isRequired = true;
            this.customTextBox_Draw.Location = new System.Drawing.Point(203, 127);
            this.customTextBox_Draw.Multiline = false;
            this.customTextBox_Draw.Name = "customTextBox_Draw";
            this.customTextBox_Draw.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Draw.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Draw.ReadOnly = false;
            this.customTextBox_Draw.Size = new System.Drawing.Size(30, 20);
            this.customTextBox_Draw.StringPattern = "^[0-9]*$";
            this.customTextBox_Draw.TabIndex = 13;
            this.customTextBox_Draw.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_Draw.TextPanelMessage = "Only accept number";
            this.customTextBox_Draw.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_Draw, "Số điểm cho mỗi trận hoà");
            this.customTextBox_Draw.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_Draw.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_Win
            // 
            this.customTextBox_Win.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_Win.Appearance.Options.UseBackColor = true;
            this.customTextBox_Win.AutoSize = true;
            this.customTextBox_Win.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Win.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Win.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_Win.isRequired = true;
            this.customTextBox_Win.Location = new System.Drawing.Point(139, 127);
            this.customTextBox_Win.Multiline = false;
            this.customTextBox_Win.Name = "customTextBox_Win";
            this.customTextBox_Win.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_Win.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_Win.ReadOnly = false;
            this.customTextBox_Win.Size = new System.Drawing.Size(30, 20);
            this.customTextBox_Win.StringPattern = "^[0-9]*$";
            this.customTextBox_Win.TabIndex = 12;
            this.customTextBox_Win.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_Win.TextPanelMessage = "Only accept number";
            this.customTextBox_Win.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_Win, "Số điểm cho mỗi trận thắng");
            this.customTextBox_Win.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_Win.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_Win.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            this.customTextBox_Win.Leave += new System.EventHandler(this.customTextBox_Win_Leave);
            // 
            // customTextBox_ForeignMax
            // 
            this.customTextBox_ForeignMax.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_ForeignMax.Appearance.Options.UseBackColor = true;
            this.customTextBox_ForeignMax.AutoSize = true;
            this.customTextBox_ForeignMax.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_ForeignMax.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_ForeignMax.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_ForeignMax.isRequired = true;
            this.customTextBox_ForeignMax.Location = new System.Drawing.Point(232, 92);
            this.customTextBox_ForeignMax.Multiline = false;
            this.customTextBox_ForeignMax.Name = "customTextBox_ForeignMax";
            this.customTextBox_ForeignMax.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_ForeignMax.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_ForeignMax.ReadOnly = false;
            this.customTextBox_ForeignMax.Size = new System.Drawing.Size(35, 20);
            this.customTextBox_ForeignMax.StringPattern = "^[0-9]*$";
            this.customTextBox_ForeignMax.TabIndex = 11;
            this.customTextBox_ForeignMax.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_ForeignMax.TextPanelMessage = "Only accept number";
            this.customTextBox_ForeignMax.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_ForeignMax, "Số cầu thủ nước ngoài tối đa");
            this.customTextBox_ForeignMax.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_ForeignMax.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_ForeignMax.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_ForeignMin
            // 
            this.customTextBox_ForeignMin.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_ForeignMin.Appearance.Options.UseBackColor = true;
            this.customTextBox_ForeignMin.AutoSize = true;
            this.customTextBox_ForeignMin.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_ForeignMin.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_ForeignMin.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_ForeignMin.isRequired = true;
            this.customTextBox_ForeignMin.Location = new System.Drawing.Point(170, 93);
            this.customTextBox_ForeignMin.Multiline = false;
            this.customTextBox_ForeignMin.Name = "customTextBox_ForeignMin";
            this.customTextBox_ForeignMin.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_ForeignMin.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_ForeignMin.ReadOnly = false;
            this.customTextBox_ForeignMin.Size = new System.Drawing.Size(35, 20);
            this.customTextBox_ForeignMin.StringPattern = "^[0-9]*$";
            this.customTextBox_ForeignMin.TabIndex = 10;
            this.customTextBox_ForeignMin.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_ForeignMin.TextPanelMessage = "Only accept number";
            this.customTextBox_ForeignMin.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_ForeignMin, "Số cầu thủ nước ngoài tối thiểu");
            this.customTextBox_ForeignMin.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_ForeignMin.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_ForeignMin.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_AgeMin
            // 
            this.customTextBox_AgeMin.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_AgeMin.Appearance.Options.UseBackColor = true;
            this.customTextBox_AgeMin.AutoSize = true;
            this.customTextBox_AgeMin.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_AgeMin.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_AgeMin.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_AgeMin.isRequired = true;
            this.customTextBox_AgeMin.Location = new System.Drawing.Point(170, 65);
            this.customTextBox_AgeMin.Multiline = false;
            this.customTextBox_AgeMin.Name = "customTextBox_AgeMin";
            this.customTextBox_AgeMin.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_AgeMin.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_AgeMin.ReadOnly = false;
            this.customTextBox_AgeMin.Size = new System.Drawing.Size(35, 20);
            this.customTextBox_AgeMin.StringPattern = "^[0-9]*$";
            this.customTextBox_AgeMin.TabIndex = 8;
            this.customTextBox_AgeMin.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_AgeMin.TextPanelMessage = "Only accept number";
            this.customTextBox_AgeMin.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_AgeMin, "Tuổi tối thiểu");
            this.customTextBox_AgeMin.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_AgeMin.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_AgeMin.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_AgeMax
            // 
            this.customTextBox_AgeMax.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_AgeMax.Appearance.Options.UseBackColor = true;
            this.customTextBox_AgeMax.AutoSize = true;
            this.customTextBox_AgeMax.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_AgeMax.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_AgeMax.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_AgeMax.isRequired = true;
            this.customTextBox_AgeMax.Location = new System.Drawing.Point(232, 65);
            this.customTextBox_AgeMax.Multiline = false;
            this.customTextBox_AgeMax.Name = "customTextBox_AgeMax";
            this.customTextBox_AgeMax.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_AgeMax.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_AgeMax.ReadOnly = false;
            this.customTextBox_AgeMax.Size = new System.Drawing.Size(35, 20);
            this.customTextBox_AgeMax.StringPattern = "^[0-9]*$";
            this.customTextBox_AgeMax.TabIndex = 9;
            this.customTextBox_AgeMax.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_AgeMax.TextPanelMessage = "Only accept number";
            this.customTextBox_AgeMax.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_AgeMax, "Tuổi tối đa");
            this.customTextBox_AgeMax.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_AgeMax.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_AgeMax.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_NumberPlayerMax
            // 
            this.customTextBox_NumberPlayerMax.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_NumberPlayerMax.Appearance.Options.UseBackColor = true;
            this.customTextBox_NumberPlayerMax.AutoSize = true;
            this.customTextBox_NumberPlayerMax.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_NumberPlayerMax.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_NumberPlayerMax.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_NumberPlayerMax.isRequired = true;
            this.customTextBox_NumberPlayerMax.Location = new System.Drawing.Point(232, 35);
            this.customTextBox_NumberPlayerMax.Multiline = false;
            this.customTextBox_NumberPlayerMax.Name = "customTextBox_NumberPlayerMax";
            this.customTextBox_NumberPlayerMax.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_NumberPlayerMax.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_NumberPlayerMax.ReadOnly = false;
            this.customTextBox_NumberPlayerMax.Size = new System.Drawing.Size(35, 20);
            this.customTextBox_NumberPlayerMax.StringPattern = "^[0-9]*$";
            this.customTextBox_NumberPlayerMax.TabIndex = 7;
            this.customTextBox_NumberPlayerMax.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_NumberPlayerMax.TextPanelMessage = "Only accept number";
            this.customTextBox_NumberPlayerMax.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_NumberPlayerMax, "Số cầu thủ tối đa");
            this.customTextBox_NumberPlayerMax.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_NumberPlayerMax.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_NumberPlayerMax.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // customTextBox_NumberMin
            // 
            this.customTextBox_NumberMin.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox_NumberMin.Appearance.Options.UseBackColor = true;
            this.customTextBox_NumberMin.AutoSize = true;
            this.customTextBox_NumberMin.BorderColor = System.Drawing.Color.Gray;
            this.customTextBox_NumberMin.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_NumberMin.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox_NumberMin.isRequired = true;
            this.customTextBox_NumberMin.Location = new System.Drawing.Point(170, 35);
            this.customTextBox_NumberMin.Multiline = false;
            this.customTextBox_NumberMin.Name = "customTextBox_NumberMin";
            this.customTextBox_NumberMin.NormalBorderColor = System.Drawing.Color.Gray;
            this.customTextBox_NumberMin.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox_NumberMin.ReadOnly = false;
            this.customTextBox_NumberMin.Size = new System.Drawing.Size(35, 20);
            this.customTextBox_NumberMin.StringPattern = "^[0-9]*$";
            this.customTextBox_NumberMin.TabIndex = 6;
            this.customTextBox_NumberMin.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox_NumberMin.TextPanelMessage = "Only accept number";
            this.customTextBox_NumberMin.TextPanelMessageColor = System.Drawing.Color.White;
            this.toolTipController1.SetToolTip(this.customTextBox_NumberMin, "Số cầu thủ tối thiểu");
            this.customTextBox_NumberMin.ValidBorderColor = System.Drawing.Color.LightGreen;
            this.customTextBox_NumberMin.xTextChanged += new System.EventHandler(this.nameTextBox_xTextChanged);
            this.customTextBox_NumberMin.Paint += new System.Windows.Forms.PaintEventHandler(this.TextBox_Paint);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(216, 96);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(4, 13);
            this.labelControl9.TabIndex = 39;
            this.labelControl9.Text = "-";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(216, 67);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(4, 13);
            this.labelControl7.TabIndex = 38;
            this.labelControl7.Text = "-";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(29, 286);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(87, 13);
            this.labelControl23.TabIndex = 35;
            this.labelControl23.Text = "Max Switch Player";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(29, 260);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(80, 13);
            this.labelControl22.TabIndex = 34;
            this.labelControl22.Text = "Max Substitution";
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(356, 190);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(37, 13);
            this.labelControl21.TabIndex = 33;
            this.labelControl21.Text = "minutes";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(29, 183);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(54, 13);
            this.labelControl20.TabIndex = 30;
            this.labelControl20.Text = "Match Time";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(29, 156);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(31, 13);
            this.labelControl19.TabIndex = 28;
            this.labelControl19.Text = "Round";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(240, 130);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(22, 13);
            this.labelControl18.TabIndex = 26;
            this.labelControl18.Text = "Lose";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(173, 130);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(25, 13);
            this.labelControl15.TabIndex = 23;
            this.labelControl15.Text = "Draw";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(113, 130);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(18, 13);
            this.labelControl16.TabIndex = 22;
            this.labelControl16.Text = "Win";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(29, 130);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(29, 13);
            this.labelControl17.TabIndex = 21;
            this.labelControl17.Text = "Points";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(29, 100);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(51, 13);
            this.labelControl14.TabIndex = 16;
            this.labelControl14.Text = "Foreigners";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(29, 71);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(19, 13);
            this.labelControl11.TabIndex = 11;
            this.labelControl11.Text = "Age";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(216, 38);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(4, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "-";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(29, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Number Players";
            // 
            // comboBoxEdit_priority
            // 
            this.comboBoxEdit_priority.EditValue = "Point - Goal Away - Goal Diference - Versus";
            this.comboBoxEdit_priority.Location = new System.Drawing.Point(113, 225);
            this.comboBoxEdit_priority.Name = "comboBoxEdit_priority";
            this.comboBoxEdit_priority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_priority.Properties.Items.AddRange(new object[] {
            "Point - Goal Away - Goal Diference - Versus",
            "Point - Versus - Goal Away - Goal Diference",
            "Point - Versus - Goal Diference - Goal Away",
            "Point - Goal Diference - Versus - Goal Away"});
            this.comboBoxEdit_priority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_priority.Size = new System.Drawing.Size(232, 20);
            this.comboBoxEdit_priority.TabIndex = 18;
            this.comboBoxEdit_priority.ToolTipTitle = "Thứ tự ưu tiên xếphạng";
            this.comboBoxEdit_priority.TextChanged += new System.EventHandler(this.comboBoxEdit1_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 233);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Priority";
            // 
            // Okbutton
            // 
            this.Okbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Okbutton.Location = new System.Drawing.Point(125, 516);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(85, 30);
            this.Okbutton.TabIndex = 3;
            this.Okbutton.Text = "OK";
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(239, 516);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pictureEdit_Logo
            // 
            this.pictureEdit_Logo.Location = new System.Drawing.Point(343, 24);
            this.pictureEdit_Logo.Name = "pictureEdit_Logo";
            this.pictureEdit_Logo.Properties.AllowScrollViaMouseDrag = false;
            this.pictureEdit_Logo.Size = new System.Drawing.Size(100, 100);
            this.pictureEdit_Logo.TabIndex = 5;
            this.pictureEdit_Logo.ToolTip = "Double click to browse";
            this.pictureEdit_Logo.ToolTipController = this.toolTipController1;
            this.pictureEdit_Logo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureEdit_Logo_MouseDoubleClick);
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolTipController1.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.5F);
            this.toolTipController1.Appearance.Options.UseBackColor = true;
            this.toolTipController1.Appearance.Options.UseFont = true;
            this.toolTipController1.AppearanceTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolTipController1.AppearanceTitle.Options.UseBackColor = true;
            this.toolTipController1.ToolTipStyle = DevExpress.Utils.ToolTipStyle.Windows7;
            // 
            // AddTour
            // 
            this.AcceptButton = this.Okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(464, 558);
            this.Controls.Add(this.pictureEdit_Logo);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.group_setting);
            this.Controls.Add(this.checkEdit_advanced);
            this.Controls.Add(this.group_general);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "AddTour";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creat New Tour";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTour_FormClosing);
            this.Load += new System.EventHandler(this.AddTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.group_general)).EndInit();
            this.group_general.ResumeLayout(false);
            this.group_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_advanced.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group_setting)).EndInit();
            this.group_setting.ResumeLayout(false);
            this.group_setting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_matchtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_priority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Logo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl group_general;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Begindate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Enddate;
        private DevExpress.XtraEditors.CheckEdit checkEdit_advanced;
        private DevExpress.XtraEditors.GroupControl group_setting;
        private DevExpress.XtraEditors.SimpleButton Okbutton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_priority;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private WindowsFormsControlLibrary.CustomTextBox nameTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_ForeignMax;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_ForeignMin;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_AgeMin;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_AgeMax;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_NumberPlayerMax;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_NumberMin;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_MaxSwitch;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_MaxSub;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_MatchTime;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_Round;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_Lose;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_Draw;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox_Win;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Logo;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.TrackBar trackBar_matchtime;

    }
}

