namespace LeagueManagement_DX.Forms
{
    partial class TypeofGoal
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
            this.bindingSource_goaltypename = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.label_TourName = new System.Windows.Forms.Label();
            this.tableAdapterManager = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TableAdapterManager();
            this.goalTypeNameTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.GoalTypeNameTableAdapter();
            this.toursTableAdapter1 = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ToursTableAdapter();
            this.bindingSource_tour = new System.Windows.Forms.BindingSource(this.components);
            this.customTextBox1 = new WindowsFormsControlLibrary.CustomTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl_Team = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_goaltypename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Team)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource_goaltypename
            // 
            this.bindingSource_goaltypename.DataMember = "GoalTypeName";
            this.bindingSource_goaltypename.DataSource = this.leagueDatabaseDataSet;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_TourName
            // 
            this.label_TourName.Font = new System.Drawing.Font("Tahoma", 12.5F);
            this.label_TourName.Location = new System.Drawing.Point(12, 9);
            this.label_TourName.Name = "label_TourName";
            this.label_TourName.Size = new System.Drawing.Size(260, 26);
            this.label_TourName.TabIndex = 1;
            this.label_TourName.Text = "TourName";
            this.label_TourName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardOfMatchTableAdapter = null;
            this.tableAdapterManager.FootballerTableAdapter = null;
            this.tableAdapterManager.GoalOfMatchTableAdapter = null;
            this.tableAdapterManager.GoalTypeNameTableAdapter = this.goalTypeNameTableAdapter;
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
            // goalTypeNameTableAdapter
            // 
            this.goalTypeNameTableAdapter.ClearBeforeFill = true;
            // 
            // toursTableAdapter1
            // 
            this.toursTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource_tour
            // 
            this.bindingSource_tour.DataMember = "Tours";
            this.bindingSource_tour.DataSource = this.leagueDatabaseDataSet;
            // 
            // customTextBox1
            // 
            this.customTextBox1.Appearance.BackColor = System.Drawing.Color.White;
            this.customTextBox1.Appearance.Options.UseBackColor = true;
            this.customTextBox1.AutoSize = true;
            this.customTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.customTextBox1.ErrorBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox1.HoverBorderColor = System.Drawing.Color.Cyan;
            this.customTextBox1.isRequired = true;
            this.customTextBox1.Location = new System.Drawing.Point(31, 117);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.NormalBorderColor = System.Drawing.Color.Silver;
            this.customTextBox1.PanelBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.customTextBox1.ReadOnly = false;
            this.customTextBox1.Size = new System.Drawing.Size(80, 20);
            this.customTextBox1.StringPattern = "^([ẮẰẲẴẶĂẤẦẨẪẬÂÁÀÃẢẠĐẾỀỂỄỆÊÉÈẺẼẸÍÌỈĨỊỐỒỔỖỘÔỚỜỞỠỢƠÓÒÕỎỌỨỪỬỮỰƯÚÙỦŨỤÝỲỶỸỴA-Za-z0-9 ]" +
    ")*$";
            this.customTextBox1.TabIndex = 1;
            this.customTextBox1.TextPadding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customTextBox1.TextPanelMessage = "This is an error message.";
            this.customTextBox1.TextPanelMessageColor = System.Drawing.Color.White;
            this.customTextBox1.ValidBorderColor = System.Drawing.Color.LightGreen;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(71, 219);
            this.simpleButton1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(49, 31);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Add";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(160, 219);
            this.simpleButton2.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(51, 31);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Remove";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // listBoxControl_Team
            // 
            this.listBoxControl_Team.Appearance.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.listBoxControl_Team.Appearance.Options.UseFont = true;
            this.listBoxControl_Team.DataSource = this.bindingSource_goaltypename;
            this.listBoxControl_Team.DisplayMember = "GoalType";
            this.listBoxControl_Team.HorizontalScrollbar = true;
            this.listBoxControl_Team.HotTrackItems = true;
            this.listBoxControl_Team.ItemHeight = 35;
            this.listBoxControl_Team.Location = new System.Drawing.Point(179, 47);
            this.listBoxControl_Team.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.listBoxControl_Team.LookAndFeel.UseDefaultLookAndFeel = false;
            this.listBoxControl_Team.Name = "listBoxControl_Team";
            this.listBoxControl_Team.Size = new System.Drawing.Size(93, 153);
            this.listBoxControl_Team.TabIndex = 7;
            this.listBoxControl_Team.TabStop = false;
            this.listBoxControl_Team.ValueMember = "GoalType";
            // 
            // TypeofGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.listBoxControl_Team);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.label_TourName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "TypeofGoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TypeofGoal";
            this.Load += new System.EventHandler(this.TypeofGoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_goaltypename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl_Team)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource_goaltypename;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private LeagueDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LeagueDatabaseDataSetTableAdapters.GoalTypeNameTableAdapter goalTypeNameTableAdapter;
        private System.Windows.Forms.Label label_TourName;
        private LeagueDatabaseDataSetTableAdapters.ToursTableAdapter toursTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource_tour;
        private WindowsFormsControlLibrary.CustomTextBox customTextBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl_Team;

    }
}