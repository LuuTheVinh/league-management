namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class TourControlListItem
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
            this.tourItemName = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // tourItemName
            // 
            this.tourItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tourItemName.Appearance.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tourItemName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.tourItemName.Enabled = false;
            this.tourItemName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tourItemName.Location = new System.Drawing.Point(13, 13);
            this.tourItemName.Name = "tourItemName";
            this.tourItemName.Size = new System.Drawing.Size(71, 19);
            this.tourItemName.TabIndex = 0;
            this.tourItemName.Text = "Unknown.";
            this.tourItemName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TourListControlItem_MouseDoubleClick);
            // 
            // TourControlListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.tourItemName);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "TourControlListItem";
            this.Size = new System.Drawing.Size(800, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl tourItemName;



    }
}
