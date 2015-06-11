using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public partial class PlayerGrid : UserControl
    {
        public GridView GridView
        {
            get { return gridView1; }
            set { gridView1 = value; }
        }

        public PlayerGrid()
        {
            InitializeComponent();
            
        }

        public void LoadAllPlayer(string teamname)
        {

            var dataTable = leagueDatabaseDataSet.SelectFootballerByTeam as DataTable;

            if (teamname != "No Team")
            {
                teamTableAdapter.Fill(leagueDatabaseDataSet.Team);
                
                foreach (var team in leagueDatabaseDataSet.Team)
                {
                    if (team.Name != teamname) continue;

                    var players = selectFootballerByTeamTableAdapter.GetData(team.Id);
                    
                    foreach (var playerrow in players)
                    {
                        var dataRow = dataTable.NewRow();
                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            if (col != 12)
                                dataRow[col] = playerrow[col].ToString().TrimEnd(' ');
                        }

                        dataTable.Rows.Add(dataRow);
                        //int index = dataTable.Rows.IndexOf(dataRow);
                        //gridView1.SetRowCellValue(index, colTeam, teamname);
                    }

                }
                
            }
            else
            {
                var players = footballerTableAdapter.GetDataByPlayerFree();

                foreach (var playerrow in players)
                {
                    var dataRow = dataTable.NewRow();
                    
                    dataRow["Id"] = playerrow.Id;
                    dataRow["TeamId"] = 0;
                    dataRow["Birth"] = playerrow.Birth;
                    dataRow["Name"] = playerrow.Name.TrimEnd(' ');
                    dataRow["Nation"] = playerrow.Nation.TrimEnd(' ');
                    dataRow["ShirtNumber"] = 0;
                    dataRow["Position"] = "-";
                    dataRow["RedCards"] = 0;
                    dataRow["YellowCards"] = 0;
                    dataRow["Goals"] = 0;
                    dataRow["MatchPlayed"] = 0;

                    dataTable.Rows.Add(dataRow);
                }
            }

            gridControl1.DataSource = dataTable;
            
        }

        /// <summary>
        /// Load tất cả Player trong tour bằng tourId
        /// </summary>
        /// <param name="tourId">Id của tour</param>
        /// <param name="goals">false là chỉ load những cầu thủ ghi bàn, ngược lại là tất cả</param>
        public void LoadAllPlayerByTour(int tourId, bool goals = true)
        {
            teamTableAdapter.Fill(leagueDatabaseDataSet.Team);

            var dataTable = leagueDatabaseDataSet.SelectFootballerByTour as DataTable;
            dataTable.Clear();

            var players = selectFootballerByTourTableAdapter.GetData(tourId);

            foreach (var playerrow in players)
            {
                if (playerrow.Goals == 0 && !goals) continue;

                var dataRow = dataTable.NewRow();

                dataRow["Id"] = playerrow.Id;
                dataRow["TeamId"] = playerrow.TeamId;
                dataRow["TourId"] = playerrow.TourId;
                dataRow["Birth"] = playerrow.Birth;
                dataRow["Name"] = playerrow.Name.TrimEnd(' ');
                dataRow["Nation"] = playerrow.Nation.TrimEnd(' ');
                dataRow["ShirtNumber"] = playerrow.ShirtNumber;
                dataRow["Position"] = playerrow.Position;
                dataRow["RedCards"] = playerrow.RedCards;
                dataRow["YellowCards"] = playerrow.YellowCards;
                dataRow["Goals"] = playerrow.Goals;
                dataRow["MatchPlayed"] = playerrow.MatchPlayed;

                dataTable.Rows.Add(dataRow);
            }

            gridControl1.DataSource = dataTable;
        }

        /// <summary>
        /// Tìm kiếm Player
        /// </summary>
        /// <param name="searchText">Tên muốn tìm kiếm</param>
        /// <param name="column">Cột muốn tìm kiếm</param>
        public void SearchPlayers(string searchText, string column = "Name")
        {
            switch (column)
            {
                case "Club":
                {
                    column = "colTeam";
                    break;
                }
                case "Shirt":
                {
                    column = "ShirtNumber";
                    break;
                }
                case "Played":
                {
                    column = "MatchPlayed";
                    break;
                }
            }
            if (searchText != "")
            {
                this.GridView.Columns[column].FilterInfo = new ColumnFilterInfo(column + " LIKE '%" + searchText + "%'");
            }
            else
            {
                this.GridView.Columns[column].FilterInfo = new ColumnFilterInfo();
            }
        }

        public void ClearGridPlayerInTour()
        {
            var dataTable = leagueDatabaseDataSet.SelectFootballerByTour as DataTable;
            dataTable.Rows.Clear();
            gridControl1.DataSource = dataTable;
        }

        public void ClearGrid()
        {
            var dataTable = leagueDatabaseDataSet.SelectFootballerByTeam as DataTable;
            dataTable.Rows.Clear();
            gridControl1.DataSource = dataTable;
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridView1.CustomUnboundColumnData += GridView1OnCustomUnboundColumnData;
        }

        private void GridView1OnCustomUnboundColumnData(object sender, CustomColumnDataEventArgs customColumnDataEventArgs)
        {
            var player = customColumnDataEventArgs.Row as DataRowView;
            if (player == null) return;

            try
            {
                if (customColumnDataEventArgs.Column.FieldName == "colTeam" && customColumnDataEventArgs.IsGetData)
                    customColumnDataEventArgs.Value = leagueDatabaseDataSet.Team.FindById(int.Parse(player["TeamId"].ToString())).Name;
            }
            catch (Exception)
            {
                customColumnDataEventArgs.Value = "";
            }
            
        }
    }
}
