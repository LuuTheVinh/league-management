using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using LeagueManagement_DX.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public partial class TeamGrid : UserControl
    {
        public int TourId { get; set; }

        public GridView GridView
        {
            get { return gridView; }
            set { gridView = value; }
        }

        public TeamGrid()
        {
            InitializeComponent();
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadTeamsDataByTour(int tourid)
        {
            this.TourId = tourid;
            //leagueDatabaseDataSet.EnforceConstraints = false;

            teamTableAdapter.Fill(leagueDatabaseDataSet.Team);
            var teamsData = reportTeamByTourTableAdapter.GetData(this.TourId);
            int i = 0;
            foreach (var team in teamsData)
            {

                if (gridView != null)
                {
                    gridView.AddNewRow();

                    int rowHandle = gridView.GetRowHandle(gridView.DataRowCount);
                    //int rowHandle = i;
                    //if (gridView.IsNewItemRow(rowHandle))
                    {
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colName.Name], team.Name);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colPoints.Name], team.Point);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colWon.Name], team.Win);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colLost.Name], team.Lose);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colDrawn.Name], team.Draw);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colGoalsFor.Name], team.GoalWin);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colGoalsAgainst.Name], team.GoalWinHome);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colGoalDifference.Name], team.GoalDiference);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colPlayed.Name], team.MatchPlayed);
                        gridView.SetRowCellValue(rowHandle, gridView.Columns[colPosition.Name], i);
                        i++;
                    }
                    gridView.UpdateCurrentRow();
                }
            }
        }

        public void SortTeam(string priority)
        {
            leagueDatabaseDataSet.EnforceConstraints = false;
            reportTeamByTourTableAdapter.Fill(leagueDatabaseDataSet.ReportTeamByTour, TourId);

            gridView.BeginUpdate();
            gridView.BeginSort();
            switch (priority)
            {
                case "PADV":
                {
                    gridView.Columns["Point"].SortOrder = ColumnSortOrder.Descending;           //Diem
                    gridView.Columns["GoalWinAway"].SortOrder = ColumnSortOrder.Descending;     //Tong ban thang san khach
                    gridView.Columns["GoalDiference"].SortOrder = ColumnSortOrder.Descending;   //Hieu so
                    //Doi khang
                    SetTeamPosition();
                    SortOrderVersus(priority);
                    break;
                }
                case "PVAD":
                {
                    gridView.Columns["Point"].SortOrder = ColumnSortOrder.Descending;           //Diem
                    //Doi khang
                    SortOrderVersus(priority);
                    gridView.Columns["GoalWinAway"].SortOrder = ColumnSortOrder.Descending;     //Tong ban thang san khach
                    gridView.Columns["GoalDiference"].SortOrder = ColumnSortOrder.Descending;   //Hieu so
                    break;
                }
                case "PVDA":
                {
                    gridView.Columns["Point"].SortOrder = ColumnSortOrder.Descending;           //Diem
                    //Doi khang
                    SortOrderVersus(priority);
                    gridView.Columns["GoalDiference"].SortOrder = ColumnSortOrder.Descending;   //Hieu so
                    gridView.Columns["GoalWinAway"].SortOrder = ColumnSortOrder.Descending;     //Tong ban thang san khach
                    break;
                }
                case "PDVA":
                {
                    gridView.Columns["Point"].SortOrder = ColumnSortOrder.Descending;           //Diem
                    gridView.Columns["GoalDiference"].SortOrder = ColumnSortOrder.Descending;   //Hieu so
                    //Doi khang
                    SortOrderVersus(priority);
                    gridView.Columns["GoalWinAway"].SortOrder = ColumnSortOrder.Descending;     //Tong ban thang san khach
                    break;
                }
            }
            gridView.Columns[1].SortOrder = ColumnSortOrder.Ascending;     //Ten
            
            gridView.EndSort();
            gridView.EndUpdate();

            SetTeamPosition();
        }

        private void SetTeamPosition()
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var row = gridView.GetDataRow(i);
                row["Position"] = i + 1;
            }

            gridView.FocusedRowHandle = 0;
        }

        private void SortOrderVersus(string priority)
        {
            for(int i = 0; i < gridView.RowCount; i++)
            {
                DataRow row1 = gridView.GetDataRow(i);
                
                for (int j = 0; j < gridView.RowCount; j++)
                {
                    if (i != j)
                    {
                        switch (priority)
                        {
                            case "PADV":
                            {
                                var row2 = gridView.GetDataRow(j);
                                  if (  row1["Point"] == row2["Point"] &&
                                        row1["GoalWinAway"] == row2["GoalWinAway"] &&
                                        row1["GoalDiference"] == row2["GoalDiference"])
                                  {
                                      SwapTeamRow(ref row1, ref row2);
                                  }
                                break;
                            }

                            case "PVAD":
                            {
                                var row2 = gridView.GetDataRow(j);
                                if (row1["Point"] == row2["Point"])
                                {
                                    SwapTeamRow(ref row1, ref row2);
                                }
                                break;
                            }
                            case "PVDA":
                            {
                                var row2 = gridView.GetDataRow(j);
                                if (row1["Point"] == row2["Point"])
                                {
                                    SwapTeamRow(ref row1, ref row2);
                                }
                                break;
                            }
                            case "PDVA":
                            {
                                var row2 = gridView.GetDataRow(j);
                                if (    row1["Point"] == row2["Point"] &&
                                      row1["GoalDiference"] == row2["GoalDiference"])
                                {
                                    SwapTeamRow(ref row1, ref row2);
                                }
                                break;
                            }
                        }
                        
                    }
                }
            }
        }

        private void SwapTeamRow(ref DataRow row1, ref DataRow row2)
        {
            var teamid = queriesTableAdapter.Versus((int)row1["Id"], (int)row2["Id"]);

            if (teamid == (int)row1["Id"] && (int)row1["Id"] > (int)row2["Id"])
            {
                object value1 = row1["Position"];
                row1["Position"] = row2["Position"];
                row2["Position"] = value1;
            }
            else if (teamid == (int) row2["Id"] && (int) row2["Id"] > (int) row1["Id"])
            {
                object value2 = row2["Position"];
                row2["Position"] = row1["Position"];
                row1["Position"] = value2;
            }

            gridView.BeginSort();
                gridView.Columns[0].SortOrder = ColumnSortOrder.Ascending;
            gridView.EndSort();
        }
        //-Nghia
        public int GetPosition(string teamName)
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var row = gridView.GetDataRow(i);
                if (row["Name"].ToString() == teamName)
                    return Int32.Parse(row["Position"].ToString());
            }
            return -1;
        }
    }
}
