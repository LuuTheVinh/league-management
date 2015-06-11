namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class PlayerGridPreview
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
            this.footballerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShirt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // footballerBindingSource
            // 
            this.footballerBindingSource.DataMember = "Footballer";
            this.footballerBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colNation,
            this.colTeam,
            this.colShirt});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(475, 233, 210, 179);
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowIncrementalSearch = false;
            this.colName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowMove = false;
            this.colName.OptionsColumn.AllowShowHide = false;
            this.colName.OptionsColumn.AllowSize = false;
            this.colName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 200;
            // 
            // colNation
            // 
            this.colNation.FieldName = "Nation";
            this.colNation.Name = "colNation";
            this.colNation.OptionsColumn.AllowEdit = false;
            this.colNation.OptionsColumn.AllowFocus = false;
            this.colNation.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNation.OptionsColumn.AllowIncrementalSearch = false;
            this.colNation.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNation.OptionsColumn.AllowMove = false;
            this.colNation.OptionsColumn.AllowShowHide = false;
            this.colNation.OptionsColumn.AllowSize = false;
            this.colNation.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNation.OptionsColumn.ReadOnly = true;
            this.colNation.OptionsFilter.AllowAutoFilter = false;
            this.colNation.OptionsFilter.AllowFilter = false;
            this.colNation.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colNation.Visible = true;
            this.colNation.VisibleIndex = 1;
            this.colNation.Width = 150;
            // 
            // colTeam
            // 
            this.colTeam.Caption = "Team";
            this.colTeam.FieldName = "Team";
            this.colTeam.Name = "colTeam";
            this.colTeam.OptionsColumn.AllowEdit = false;
            this.colTeam.OptionsColumn.AllowFocus = false;
            this.colTeam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTeam.OptionsColumn.AllowIncrementalSearch = false;
            this.colTeam.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTeam.OptionsColumn.AllowMove = false;
            this.colTeam.OptionsColumn.AllowShowHide = false;
            this.colTeam.OptionsColumn.AllowSize = false;
            this.colTeam.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTeam.OptionsColumn.ReadOnly = true;
            this.colTeam.OptionsFilter.AllowAutoFilter = false;
            this.colTeam.OptionsFilter.AllowFilter = false;
            this.colTeam.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colTeam.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colTeam.Visible = true;
            this.colTeam.VisibleIndex = 2;
            this.colTeam.Width = 160;
            // 
            // colShirt
            // 
            this.colShirt.Caption = "Shirt";
            this.colShirt.FieldName = "Shirt";
            this.colShirt.Name = "colShirt";
            this.colShirt.OptionsColumn.AllowEdit = false;
            this.colShirt.OptionsColumn.AllowFocus = false;
            this.colShirt.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colShirt.OptionsColumn.AllowIncrementalSearch = false;
            this.colShirt.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colShirt.OptionsColumn.AllowMove = false;
            this.colShirt.OptionsColumn.AllowShowHide = false;
            this.colShirt.OptionsColumn.AllowSize = false;
            this.colShirt.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colShirt.OptionsColumn.ReadOnly = true;
            this.colShirt.OptionsFilter.AllowAutoFilter = false;
            this.colShirt.OptionsFilter.AllowFilter = false;
            this.colShirt.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colShirt.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colShirt.Visible = true;
            this.colShirt.VisibleIndex = 3;
            this.colShirt.Width = 110;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.footballerBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(638, 291);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl_MouseClick);
            this.gridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(138, 70);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // PlayerGridPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Name = "PlayerGridPreview";
            this.Size = new System.Drawing.Size(638, 291);
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource footballerBindingSource;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNation;
        private DevExpress.XtraGrid.Columns.GridColumn colTeam;
        private DevExpress.XtraGrid.Columns.GridColumn colShirt;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
