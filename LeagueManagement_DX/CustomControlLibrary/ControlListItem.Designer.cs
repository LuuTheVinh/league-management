namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class ControlListItem
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoItem,
            this.editItem,
            this.deleteItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(134, 70);
            // 
            // infoItem
            // 
            this.infoItem.Name = "infoItem";
            this.infoItem.Size = new System.Drawing.Size(133, 22);
            this.infoItem.Text = "Infomation";
            // 
            // editItem
            // 
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(133, 22);
            this.editItem.Text = "Edit";
            // 
            // deleteItem
            // 
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(133, 22);
            this.deleteItem.Text = "Delete";
            // 
            // ControlListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.DoubleBuffered = true;
            this.Name = "ControlListItem";
            this.Size = new System.Drawing.Size(840, 50);
            this.menuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ContextMenuStrip menuStrip;
        protected System.Windows.Forms.ToolStripMenuItem deleteItem;
        protected System.Windows.Forms.ToolStripMenuItem infoItem;
        protected System.Windows.Forms.ToolStripMenuItem editItem;
    }
}
