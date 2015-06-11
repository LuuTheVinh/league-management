namespace LeagueManagement_DX.CustomControlLibrary
{
    partial class TeamGrid
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.reportTeamByTourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leagueDatabaseDataSet = new LeagueManagement_DX.LeagueDatabaseDataSet();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlayed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDrawn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoalsFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoalsAgainst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoalDifference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoalWinAway = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoints = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.reportTeamByTourTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ReportTeamByTourTableAdapter();
            this.toursTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ToursTableAdapter();
            this.queriesTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.matchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.MatchTableAdapter();
            this.resultTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTeamByTourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.reportTeamByTourBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(826, 357);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Load += new System.EventHandler(this.gridControl_Load);
            // 
            // reportTeamByTourBindingSource
            // 
            this.reportTeamByTourBindingSource.DataMember = "ReportTeamByTour";
            this.reportTeamByTourBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // leagueDatabaseDataSet
            // 
            this.leagueDatabaseDataSet.DataSetName = "LeagueDatabaseDataSet";
            this.leagueDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView
            // 
            this.gridView.ActiveFilterEnabled = false;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPosition,
            this.colName,
            this.colPlayed,
            this.colWon,
            this.colDrawn,
            this.colLost,
            this.colGoalsFor,
            this.colGoalsAgainst,
            this.colGoalDifference,
            this.colGoalWinAway,
            this.colPoints});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
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
            this.colPosition.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPosition.OptionsColumn.ReadOnly = true;
            this.colPosition.OptionsFilter.AllowAutoFilter = false;
            this.colPosition.OptionsFilter.AllowFilter = false;
            this.colPosition.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colPosition.ToolTip = "Vị trí";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 0;
            this.colPosition.Width = 50;
            // 
            // colName
            // 
            this.colName.Caption = "Clubs";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowMove = false;
            this.colName.OptionsColumn.AllowShowHide = false;
            this.colName.OptionsColumn.AllowSize = false;
            this.colName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.OptionsFilter.AllowAutoFilter = false;
            this.colName.OptionsFilter.AllowFilter = false;
            this.colName.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colName.ToolTip = "Đội bóng";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 160;
            // 
            // colPlayed
            // 
            this.colPlayed.Caption = "Played";
            this.colPlayed.FieldName = "MatchPlayed";
            this.colPlayed.Name = "colPlayed";
            this.colPlayed.OptionsColumn.AllowEdit = false;
            this.colPlayed.OptionsColumn.AllowFocus = false;
            this.colPlayed.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPlayed.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPlayed.OptionsColumn.AllowMove = false;
            this.colPlayed.OptionsColumn.AllowShowHide = false;
            this.colPlayed.OptionsColumn.AllowSize = false;
            this.colPlayed.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPlayed.OptionsColumn.ReadOnly = true;
            this.colPlayed.OptionsFilter.AllowAutoFilter = false;
            this.colPlayed.OptionsFilter.AllowFilter = false;
            this.colPlayed.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colPlayed.ToolTip = "Trận đã thi đấu";
            this.colPlayed.Visible = true;
            this.colPlayed.VisibleIndex = 2;
            this.colPlayed.Width = 40;
            // 
            // colWon
            // 
            this.colWon.Caption = "Won";
            this.colWon.FieldName = "Win";
            this.colWon.Name = "colWon";
            this.colWon.OptionsColumn.AllowEdit = false;
            this.colWon.OptionsColumn.AllowFocus = false;
            this.colWon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colWon.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colWon.OptionsColumn.AllowMove = false;
            this.colWon.OptionsColumn.AllowShowHide = false;
            this.colWon.OptionsColumn.AllowSize = false;
            this.colWon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colWon.OptionsColumn.ReadOnly = true;
            this.colWon.OptionsFilter.AllowAutoFilter = false;
            this.colWon.OptionsFilter.AllowFilter = false;
            this.colWon.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colWon.ToolTip = "Thắng";
            this.colWon.Visible = true;
            this.colWon.VisibleIndex = 3;
            this.colWon.Width = 40;
            // 
            // colDrawn
            // 
            this.colDrawn.Caption = "Drawn";
            this.colDrawn.FieldName = "Draw";
            this.colDrawn.Name = "colDrawn";
            this.colDrawn.OptionsColumn.AllowEdit = false;
            this.colDrawn.OptionsColumn.AllowFocus = false;
            this.colDrawn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDrawn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDrawn.OptionsColumn.AllowMove = false;
            this.colDrawn.OptionsColumn.AllowShowHide = false;
            this.colDrawn.OptionsColumn.AllowSize = false;
            this.colDrawn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDrawn.OptionsColumn.ReadOnly = true;
            this.colDrawn.OptionsFilter.AllowAutoFilter = false;
            this.colDrawn.OptionsFilter.AllowFilter = false;
            this.colDrawn.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colDrawn.ToolTip = "Hòa";
            this.colDrawn.Visible = true;
            this.colDrawn.VisibleIndex = 4;
            this.colDrawn.Width = 40;
            // 
            // colLost
            // 
            this.colLost.Caption = "Lost";
            this.colLost.FieldName = "Lose";
            this.colLost.Name = "colLost";
            this.colLost.OptionsColumn.AllowEdit = false;
            this.colLost.OptionsColumn.AllowFocus = false;
            this.colLost.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLost.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLost.OptionsColumn.AllowMove = false;
            this.colLost.OptionsColumn.AllowShowHide = false;
            this.colLost.OptionsColumn.AllowSize = false;
            this.colLost.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLost.OptionsColumn.ReadOnly = true;
            this.colLost.OptionsFilter.AllowAutoFilter = false;
            this.colLost.OptionsFilter.AllowFilter = false;
            this.colLost.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colLost.ToolTip = "Thua";
            this.colLost.Visible = true;
            this.colLost.VisibleIndex = 5;
            this.colLost.Width = 40;
            // 
            // colGoalsFor
            // 
            this.colGoalsFor.Caption = "GF";
            this.colGoalsFor.FieldName = "GoalWin";
            this.colGoalsFor.Name = "colGoalsFor";
            this.colGoalsFor.OptionsColumn.AllowEdit = false;
            this.colGoalsFor.OptionsColumn.AllowFocus = false;
            this.colGoalsFor.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsFor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsFor.OptionsColumn.AllowMove = false;
            this.colGoalsFor.OptionsColumn.AllowShowHide = false;
            this.colGoalsFor.OptionsColumn.AllowSize = false;
            this.colGoalsFor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsFor.OptionsColumn.ReadOnly = true;
            this.colGoalsFor.OptionsFilter.AllowAutoFilter = false;
            this.colGoalsFor.OptionsFilter.AllowFilter = false;
            this.colGoalsFor.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsFor.ToolTip = "Số bàn thắng";
            this.colGoalsFor.Visible = true;
            this.colGoalsFor.VisibleIndex = 6;
            this.colGoalsFor.Width = 40;
            // 
            // colGoalsAgainst
            // 
            this.colGoalsAgainst.Caption = "GA";
            this.colGoalsAgainst.FieldName = "GoalLose";
            this.colGoalsAgainst.Name = "colGoalsAgainst";
            this.colGoalsAgainst.OptionsColumn.AllowEdit = false;
            this.colGoalsAgainst.OptionsColumn.AllowFocus = false;
            this.colGoalsAgainst.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsAgainst.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsAgainst.OptionsColumn.AllowMove = false;
            this.colGoalsAgainst.OptionsColumn.AllowShowHide = false;
            this.colGoalsAgainst.OptionsColumn.AllowSize = false;
            this.colGoalsAgainst.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsAgainst.OptionsColumn.ReadOnly = true;
            this.colGoalsAgainst.OptionsFilter.AllowAutoFilter = false;
            this.colGoalsAgainst.OptionsFilter.AllowFilter = false;
            this.colGoalsAgainst.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalsAgainst.ToolTip = "Số bàn thua";
            this.colGoalsAgainst.Visible = true;
            this.colGoalsAgainst.VisibleIndex = 7;
            this.colGoalsAgainst.Width = 40;
            // 
            // colGoalDifference
            // 
            this.colGoalDifference.Caption = "GD";
            this.colGoalDifference.FieldName = "GoalDiference";
            this.colGoalDifference.Name = "colGoalDifference";
            this.colGoalDifference.OptionsColumn.AllowEdit = false;
            this.colGoalDifference.OptionsColumn.AllowFocus = false;
            this.colGoalDifference.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalDifference.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalDifference.OptionsColumn.AllowMove = false;
            this.colGoalDifference.OptionsColumn.AllowShowHide = false;
            this.colGoalDifference.OptionsColumn.AllowSize = false;
            this.colGoalDifference.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalDifference.OptionsColumn.ReadOnly = true;
            this.colGoalDifference.OptionsFilter.AllowAutoFilter = false;
            this.colGoalDifference.OptionsFilter.AllowFilter = false;
            this.colGoalDifference.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalDifference.ToolTip = "Hiệu số";
            this.colGoalDifference.Visible = true;
            this.colGoalDifference.VisibleIndex = 8;
            this.colGoalDifference.Width = 40;
            // 
            // colGoalWinAway
            // 
            this.colGoalWinAway.Caption = "GWA";
            this.colGoalWinAway.FieldName = "GoalWinAway";
            this.colGoalWinAway.Name = "colGoalWinAway";
            this.colGoalWinAway.OptionsColumn.AllowEdit = false;
            this.colGoalWinAway.OptionsColumn.AllowFocus = false;
            this.colGoalWinAway.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalWinAway.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalWinAway.OptionsColumn.AllowMove = false;
            this.colGoalWinAway.OptionsColumn.AllowShowHide = false;
            this.colGoalWinAway.OptionsColumn.AllowSize = false;
            this.colGoalWinAway.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalWinAway.OptionsColumn.ReadOnly = true;
            this.colGoalWinAway.OptionsFilter.AllowAutoFilter = false;
            this.colGoalWinAway.OptionsFilter.AllowFilter = false;
            this.colGoalWinAway.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colGoalWinAway.ToolTip = "Bàn thắng sân khách";
            this.colGoalWinAway.Visible = true;
            this.colGoalWinAway.VisibleIndex = 9;
            this.colGoalWinAway.Width = 40;
            // 
            // colPoints
            // 
            this.colPoints.Caption = "PTS";
            this.colPoints.FieldName = "Point";
            this.colPoints.Name = "colPoints";
            this.colPoints.OptionsColumn.AllowEdit = false;
            this.colPoints.OptionsColumn.AllowFocus = false;
            this.colPoints.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPoints.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPoints.OptionsColumn.AllowMove = false;
            this.colPoints.OptionsColumn.AllowShowHide = false;
            this.colPoints.OptionsColumn.AllowSize = false;
            this.colPoints.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPoints.OptionsColumn.ReadOnly = true;
            this.colPoints.OptionsFilter.AllowAutoFilter = false;
            this.colPoints.OptionsFilter.AllowFilter = false;
            this.colPoints.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colPoints.ToolTip = "Điểm";
            this.colPoints.Visible = true;
            this.colPoints.VisibleIndex = 10;
            this.colPoints.Width = 40;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.leagueDatabaseDataSet;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // reportTeamByTourTableAdapter
            // 
            this.reportTeamByTourTableAdapter.ClearBeforeFill = true;
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // TeamGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Name = "TeamGrid";
            this.Size = new System.Drawing.Size(826, 357);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTeamByTourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private LeagueDatabaseDataSet leagueDatabaseDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colPlayed;
        private DevExpress.XtraGrid.Columns.GridColumn colWon;
        private DevExpress.XtraGrid.Columns.GridColumn colDrawn;
        private DevExpress.XtraGrid.Columns.GridColumn colLost;
        private DevExpress.XtraGrid.Columns.GridColumn colGoalsFor;
        private DevExpress.XtraGrid.Columns.GridColumn colGoalsAgainst;
        private DevExpress.XtraGrid.Columns.GridColumn colGoalDifference;
        private DevExpress.XtraGrid.Columns.GridColumn colPoints;
        private LeagueDatabaseDataSetTableAdapters.ReportTeamByTourTableAdapter reportTeamByTourTableAdapter;
        private System.Windows.Forms.BindingSource reportTeamByTourBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colGoalWinAway;
        private LeagueDatabaseDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.MatchTableAdapter matchTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.ResultTableAdapter resultTableAdapter;

    }
}
