namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class MatchControlListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.resultTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ResultTableAdapter();
            this.scoreTeamTwo = new DevExpress.XtraEditors.LabelControl();
            this.scoreTeamOne = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nameTeamTwo = new DevExpress.XtraEditors.LabelControl();
            this.nameTeamOne = new DevExpress.XtraEditors.LabelControl();
            this.logoTeamTwo = new System.Windows.Forms.PictureBox();
            this.logoTeamOne = new System.Windows.Forms.PictureBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.matchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.MatchTableAdapter();
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.logoTeamTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTeamOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // scoreTeamTwo
            // 
            this.scoreTeamTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.scoreTeamTwo.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.scoreTeamTwo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.scoreTeamTwo.Enabled = false;
            this.scoreTeamTwo.Location = new System.Drawing.Point(438, 1);
            this.scoreTeamTwo.Name = "scoreTeamTwo";
            this.scoreTeamTwo.Size = new System.Drawing.Size(12, 33);
            this.scoreTeamTwo.TabIndex = 9;
            this.scoreTeamTwo.Text = "-";
            // 
            // scoreTeamOne
            // 
            this.scoreTeamOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.scoreTeamOne.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.scoreTeamOne.Appearance.ForeColor = System.Drawing.Color.Black;
            this.scoreTeamOne.Enabled = false;
            this.scoreTeamOne.Location = new System.Drawing.Point(346, 1);
            this.scoreTeamOne.Name = "scoreTeamOne";
            this.scoreTeamOne.Size = new System.Drawing.Size(12, 33);
            this.scoreTeamOne.TabIndex = 9;
            this.scoreTeamOne.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(396, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "v";
            // 
            // nameTeamTwo
            // 
            this.nameTeamTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTeamTwo.Appearance.ForeColor = System.Drawing.Color.Black;
            this.nameTeamTwo.Enabled = false;
            this.nameTeamTwo.Location = new System.Drawing.Point(702, 11);
            this.nameTeamTwo.Name = "nameTeamTwo";
            this.nameTeamTwo.Size = new System.Drawing.Size(49, 13);
            this.nameTeamTwo.TabIndex = 8;
            this.nameTeamTwo.Text = "Team Two";
            // 
            // nameTeamOne
            // 
            this.nameTeamOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameTeamOne.Appearance.ForeColor = System.Drawing.Color.Black;
            this.nameTeamOne.Enabled = false;
            this.nameTeamOne.Location = new System.Drawing.Point(41, 11);
            this.nameTeamOne.Name = "nameTeamOne";
            this.nameTeamOne.Size = new System.Drawing.Size(49, 13);
            this.nameTeamOne.TabIndex = 8;
            this.nameTeamOne.Text = "Team One";
            // 
            // logoTeamTwo
            // 
            this.logoTeamTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoTeamTwo.Enabled = false;
            this.logoTeamTwo.Image = global::LeagueManagement_DX.Properties.Resources.Add_File_icon;
            this.logoTeamTwo.Location = new System.Drawing.Point(757, 0);
            this.logoTeamTwo.Name = "logoTeamTwo";
            this.logoTeamTwo.Size = new System.Drawing.Size(35, 35);
            this.logoTeamTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoTeamTwo.TabIndex = 1;
            this.logoTeamTwo.TabStop = false;
            // 
            // logoTeamOne
            // 
            this.logoTeamOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logoTeamOne.Enabled = false;
            this.logoTeamOne.Image = global::LeagueManagement_DX.Properties.Resources.Add_File_icon;
            this.logoTeamOne.Location = new System.Drawing.Point(0, 0);
            this.logoTeamOne.Name = "logoTeamOne";
            this.logoTeamOne.Size = new System.Drawing.Size(35, 35);
            this.logoTeamOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoTeamOne.TabIndex = 0;
            this.logoTeamOne.TabStop = false;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.Transparent;
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusPanel.Location = new System.Drawing.Point(792, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(8, 35);
            this.statusPanel.TabIndex = 11;
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MatchControlListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.scoreTeamTwo);
            this.Controls.Add(this.scoreTeamOne);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.nameTeamTwo);
            this.Controls.Add(this.nameTeamOne);
            this.Controls.Add(this.logoTeamTwo);
            this.Controls.Add(this.logoTeamOne);
            this.Controls.Add(this.statusPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MatchControlListItem";
            this.Size = new System.Drawing.Size(800, 35);
            this.Load += new System.EventHandler(this.MatchControlListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoTeamTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTeamOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoTeamOne;
        private System.Windows.Forms.PictureBox logoTeamTwo;
        private DevExpress.XtraEditors.LabelControl nameTeamOne;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl scoreTeamOne;
        private DevExpress.XtraEditors.LabelControl scoreTeamTwo;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.ResultTableAdapter resultTableAdapter;
        private System.Windows.Forms.Panel statusPanel;
        private DevExpress.XtraEditors.LabelControl nameTeamTwo;
        private LeagueDatabaseDataSetTableAdapters.MatchTableAdapter matchTableAdapter;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
    }
}
