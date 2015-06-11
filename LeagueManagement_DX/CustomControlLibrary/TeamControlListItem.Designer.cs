namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class TeamControlListItem
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
            this.teamName = new DevExpress.XtraEditors.LabelControl();
            this.logoTeam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // teamName
            // 
            this.teamName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.teamName.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teamName.Enabled = false;
            this.teamName.Location = new System.Drawing.Point(50, 12);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(52, 16);
            this.teamName.TabIndex = 1;
            this.teamName.Text = "No Name";
            // 
            // logoTeam
            // 
            this.logoTeam.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoTeam.Enabled = false;
            this.logoTeam.Image = global::LeagueManagement_DX.Properties.Resources.Add_File_icon;
            this.logoTeam.InitialImage = null;
            this.logoTeam.Location = new System.Drawing.Point(0, 0);
            this.logoTeam.Name = "logoTeam";
            this.logoTeam.Size = new System.Drawing.Size(40, 40);
            this.logoTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoTeam.TabIndex = 0;
            this.logoTeam.TabStop = false;
            // 
            // TeamControlListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.logoTeam);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "TeamControlListItem";
            this.Size = new System.Drawing.Size(850, 40);
            ((System.ComponentModel.ISupportInitialize)(this.logoTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoTeam;
        private DevExpress.XtraEditors.LabelControl teamName;
    }
}
