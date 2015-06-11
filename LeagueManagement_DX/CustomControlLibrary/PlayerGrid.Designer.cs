namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class PlayerGrid
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShirtNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoals = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatchPlayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.selectFootballerByTeamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectFootballerByTeamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter();
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.selectFootballerByTourTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByTourTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectFootballerByTeamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemPictureEdit});
            this.gridControl1.Size = new System.Drawing.Size(773, 332);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colTeam,
            this.colShirtNumber,
            this.colNation,
            this.colPosition,
            this.colGoals,
            this.colMatchPlayed});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(610, 281, 210, 172);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowMove = false;
            this.colName.OptionsColumn.AllowShowHide = false;
            this.colName.OptionsColumn.AllowSize = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.ToolTip = "Tên";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 250;
            // 
            // colTeam
            // 
            this.colTeam.Caption = "Club";
            this.colTeam.FieldName = "colTeam";
            this.colTeam.Name = "colTeam";
            this.colTeam.OptionsColumn.AllowEdit = false;
            this.colTeam.OptionsColumn.AllowFocus = false;
            this.colTeam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTeam.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTeam.OptionsColumn.AllowMove = false;
            this.colTeam.OptionsColumn.AllowShowHide = false;
            this.colTeam.OptionsColumn.AllowSize = false;
            this.colTeam.OptionsColumn.ReadOnly = true;
            this.colTeam.ToolTip = "Đội";
            this.colTeam.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colTeam.Visible = true;
            this.colTeam.VisibleIndex = 1;
            this.colTeam.Width = 175;
            // 
            // colShirtNumber
            // 
            this.colShirtNumber.Caption = "Shirt";
            this.colShirtNumber.FieldName = "ShirtNumber";
            this.colShirtNumber.Name = "colShirtNumber";
            this.colShirtNumber.OptionsColumn.AllowEdit = false;
            this.colShirtNumber.OptionsColumn.AllowFocus = false;
            this.colShirtNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colShirtNumber.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colShirtNumber.OptionsColumn.AllowMove = false;
            this.colShirtNumber.OptionsColumn.AllowShowHide = false;
            this.colShirtNumber.OptionsColumn.AllowSize = false;
            this.colShirtNumber.OptionsColumn.ReadOnly = true;
            this.colShirtNumber.ToolTip = "Số áo";
            this.colShirtNumber.Visible = true;
            this.colShirtNumber.VisibleIndex = 2;
            this.colShirtNumber.Width = 63;
            // 
            // colNation
            // 
            this.colNation.FieldName = "Nation";
            this.colNation.Name = "colNation";
            this.colNation.OptionsColumn.AllowEdit = false;
            this.colNation.OptionsColumn.AllowFocus = false;
            this.colNation.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNation.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNation.OptionsColumn.AllowMove = false;
            this.colNation.OptionsColumn.AllowShowHide = false;
            this.colNation.OptionsColumn.AllowSize = false;
            this.colNation.OptionsColumn.ReadOnly = true;
            this.colNation.ToolTip = "Quốc tịch";
            this.colNation.Visible = true;
            this.colNation.VisibleIndex = 3;
            this.colNation.Width = 63;
            // 
            // colPosition
            // 
            this.colPosition.Caption = "Position";
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.OptionsColumn.AllowEdit = false;
            this.colPosition.OptionsColumn.AllowFocus = false;
            this.colPosition.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPosition.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPosition.OptionsColumn.AllowMove = false;
            this.colPosition.OptionsColumn.AllowShowHide = false;
            this.colPosition.OptionsColumn.AllowSize = false;
            this.colPosition.OptionsColumn.ReadOnly = true;
            this.colPosition.ToolTip = "Vị trí";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 4;
            this.colPosition.Width = 63;
            // 
            // colGoals
            // 
            this.colGoals.Caption = "Goals";
            this.colGoals.FieldName = "Goals";
            this.colGoals.Name = "colGoals";
            this.colGoals.OptionsColumn.AllowEdit = false;
            this.colGoals.OptionsColumn.AllowFocus = false;
            this.colGoals.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colGoals.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGoals.OptionsColumn.AllowMove = false;
            this.colGoals.OptionsColumn.AllowShowHide = false;
            this.colGoals.OptionsColumn.AllowSize = false;
            this.colGoals.OptionsColumn.ReadOnly = true;
            this.colGoals.ToolTip = "Tổng số bàn thắng";
            this.colGoals.Visible = true;
            this.colGoals.VisibleIndex = 5;
            this.colGoals.Width = 63;
            // 
            // colMatchPlayed
            // 
            this.colMatchPlayed.Caption = "Played";
            this.colMatchPlayed.FieldName = "MatchPlayed";
            this.colMatchPlayed.Name = "colMatchPlayed";
            this.colMatchPlayed.OptionsColumn.AllowEdit = false;
            this.colMatchPlayed.OptionsColumn.AllowFocus = false;
            this.colMatchPlayed.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMatchPlayed.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatchPlayed.OptionsColumn.AllowMove = false;
            this.colMatchPlayed.OptionsColumn.AllowShowHide = false;
            this.colMatchPlayed.OptionsColumn.AllowSize = false;
            this.colMatchPlayed.OptionsColumn.ReadOnly = true;
            this.colMatchPlayed.ToolTip = "Số trận đã thi đấu";
            this.colMatchPlayed.Visible = true;
            this.colMatchPlayed.VisibleIndex = 6;
            this.colMatchPlayed.Width = 78;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemPictureEdit
            // 
            this.repositoryItemPictureEdit.Appearance.Image = global::LeagueManagement_DX.Properties.Resources.man_icon;
            this.repositoryItemPictureEdit.Appearance.Options.UseImage = true;
            this.repositoryItemPictureEdit.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.repositoryItemPictureEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repositoryItemPictureEdit.Name = "repositoryItemPictureEdit";
            this.repositoryItemPictureEdit.ReadOnly = true;
            this.repositoryItemPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "SelectFootballerByTeam";
            this.bindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectFootballerByTeamBindingSource
            // 
            this.selectFootballerByTeamBindingSource.DataMember = "SelectFootballerByTeam";
            this.selectFootballerByTeamBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // footballerBindingSource
            // 
            this.footballerBindingSource.DataMember = "Footballer";
            this.footballerBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // selectFootballerByTeamTableAdapter
            // 
            this.selectFootballerByTeamTableAdapter.ClearBeforeFill = true;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // selectFootballerByTourTableAdapter
            // 
            this.selectFootballerByTourTableAdapter.ClearBeforeFill = true;
            // 
            // PlayerGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "PlayerGrid";
            this.Size = new System.Drawing.Size(773, 332);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectFootballerByTeamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource selectFootballerByTeamBindingSource;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colShirtNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colNation;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colGoals;
        private DevExpress.XtraGrid.Columns.GridColumn colMatchPlayed;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter selectFootballerByTeamTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource footballerBindingSource;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTeam;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByTourTableAdapter selectFootballerByTourTableAdapter;
    }
}
