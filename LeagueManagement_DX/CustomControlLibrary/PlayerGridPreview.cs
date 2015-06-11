using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using LeagueManagement_DX.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public partial class PlayerGridPreview : UserControl
    {
        public GridView GridView
        {
            get { return gridView1;}
            set { gridView1 = value; }
        }

        //public LeagueDatabaseDataSet LeagueDatabaseDataSet
        //{
        //    get { return leagueDatabaseDataSet; }

        //    set { leagueDatabaseDataSet = value; }
        //}

        public PlayerGridPreview()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            //footballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
            //teamDetailTableAdapter.Fill(leagueDatabaseDataSet.TeamDetail);
            //teamTableAdapter.Fill(leagueDatabaseDataSet.Team);
            gridView1.CustomUnboundColumnData += GridView1OnCustomUnboundColumnData;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, colTeam, "");
            }

            contextMenuStrip.ItemClicked += ContextMenuStripOnItemClicked;

            UserAccessLevel_Load();
        }

        private void ContextMenuStripOnItemClicked(object sender, ToolStripItemClickedEventArgs toolStripItemClickedEventArgs)
        {
            if (toolStripItemClickedEventArgs.ClickedItem == informationToolStripMenuItem)
            {
                ShowItemDetail();
            }
            else if (toolStripItemClickedEventArgs.ClickedItem == deleteToolStripMenuItem)
            {
                //DELETE DATA GO HERE...
                DeleteRowSelected(this.ParentForm as MainManagement);
            }
            else if (toolStripItemClickedEventArgs.ClickedItem == editToolStripMenuItem)
            {
                ShowItemDetail(true);
            }
        }

        private void GridView1OnCustomUnboundColumnData(object sender, CustomColumnDataEventArgs customColumnDataEventArgs)
        {
            //GridView view = sender as GridView;
            //var player = gridView1.GetDataRow(customColumnDataEventArgs.ListSourceRowIndex) as LeagueDatabaseDataSet.FootballerRow;
            //if (player == null) return;

            //foreach (var teamdeatail in leagueDatabaseDataSet.TeamDetail)
            //{
            //    if (teamdeatail.PlayerId == player.Id)
            //    {
            //        if (customColumnDataEventArgs.Column.FieldName == "Shirt")
            //        {
            //            customColumnDataEventArgs.Value = teamdeatail.ShirtNumber;
            //        }
            //        else if (customColumnDataEventArgs.Column.FieldName == "Team")
            //        {
            //            customColumnDataEventArgs.Value = leagueDatabaseDataSet.Team.FindById(teamdeatail.TeamId).Name;
            //        }
            //    }
            //}

            var player = customColumnDataEventArgs.Row as DataRowView;
            if (player == null) return;

            foreach (var teamdeatail in leagueDatabaseDataSet.TeamDetail)
            {
                if (teamdeatail.PlayerId == int.Parse(player["Id"].ToString()))
                {
                    if (customColumnDataEventArgs.Column.FieldName == "Shirt" && customColumnDataEventArgs.IsGetData)
                    {
                        customColumnDataEventArgs.Value = teamdeatail.ShirtNumber;
                    }
                    else if (customColumnDataEventArgs.Column.FieldName == "Team" && customColumnDataEventArgs.IsGetData)
                    {
                        customColumnDataEventArgs.Value = leagueDatabaseDataSet.Team.FindById(teamdeatail.TeamId).Name;
                    }
                }
            }
        }

        public void ReloadPlayers()
        {
            footballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
            teamDetailTableAdapter.Fill(leagueDatabaseDataSet.TeamDetail);
            teamTableAdapter.Fill(leagueDatabaseDataSet.Team);

            gridControl.DataSource = leagueDatabaseDataSet.Footballer;
        }

        public void DeleteRowSelected(MainManagement mainManagement = null)
        {
            var playerrow = gridView1.GetDataRow(gridView1.FocusedRowHandle) as LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow;
            if (playerrow == null) return;

            var rs = MessageBox.Show("Delete footballer make lose all of data in that footballer.\nDo you want to continue?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.OK)
            {
                string name = playerrow.Name;

                try
                {
                    //DELETE
                    playerrow.Delete();

                    footballerTableAdapter.Update(playerrow);
                    leagueDatabaseDataSet.Footballer.AcceptChanges();

                    ReloadPlayers();

                    if (mainManagement != null)
                    {
                        var form = mainManagement.FindChildForm(name);
                        if (form != null)
                        {
                            form.Close();
                        }
                    }

                }
                catch (SqlException exception)
                {
                    foreach (SqlError error in exception.Errors)
                    {
                        switch (error.Number)
                        {
                            case 547:
                                {
                                    MessageBox.Show(String.Format("Can't Delete. \"{0}\" is playing in tour.", name.TrimEnd(' ')));
                                    break;
                                }
                        }
                    }
                    leagueDatabaseDataSet.RejectChanges();
                }
            }
        }

        public void DeleteRow(int id, MainManagement mainManagement = null)
        {
            LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerrow = null;

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var row = gridView1.GetDataRow(i);
                if (int.Parse(row["Id"].ToString()) == id)
                {
                    playerrow = row as LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow;
                    break;
                }
            }

            if (playerrow == null) return;

            var rs = MessageBox.Show("Delete footballer make lose all of data in that footballer.\nDo you want to continue?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.OK)
            {
                string name = playerrow.Name;

                try
                {
                    //DELETE
                    playerrow.Delete();

                    footballerTableAdapter.Update(playerrow);
                    leagueDatabaseDataSet.Footballer.AcceptChanges();

                    ReloadPlayers();

                    if (mainManagement != null)
                    {
                        var form = mainManagement.FindChildForm(name);
                        if (form != null)
                        {
                            form.Close();
                        }
                    }
                }
                catch (SqlException exception)
                {
                    foreach (SqlError error in exception.Errors)
                    {
                        switch (error.Number)
                        {
                            case 547:
                                {
                                    MessageBox.Show(String.Format("Can't Delete. \"{0}\" is playing in tour.", name.TrimEnd(' ')));
                                    break;
                                }
                        }
                    }
                    leagueDatabaseDataSet.RejectChanges();
                }
            }
        }

        public void SetSelectedRow(int id)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var row = gridView1.GetDataRow(i);
                if (int.Parse(row["Id"].ToString()) == id)
                {
                    gridView1.FocusedRowHandle = i;
                    break;
                }
            }
        }

        public int GetTeamId(int playerid)
        {
            foreach (var teamdeatail in leagueDatabaseDataSet.TeamDetail)
            {
                if (teamdeatail.PlayerId == playerid)
                {
                    return leagueDatabaseDataSet.Team.FindById(teamdeatail.TeamId).Id;
                }
            }

            return -1;
        }

        public void ShowItemDetail(bool canEdit = false)
        {
            //SHOW DETAIL FORM GO HERE...
            var dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle) as LeagueDatabaseDataSet.FootballerRow;
            if (dataRow == null) return;
            int teamid = GetTeamId(dataRow.Id);

            ShowFootballer detailForm;

            if (this.ParentForm.IsMdiContainer == false)
            {
                using (detailForm = new ShowFootballer(dataRow, true, canEdit, teamid))
                {
                    detailForm.PlayerGrid = this;
                    DialogResult dlResult = detailForm.ShowDialog();
                    if (dlResult == DialogResult.OK)
                        this.ReloadPlayers();
                }
                
            }
            else
            {
                var form = (this.ParentForm as MainManagement).FindChildForm<ShowFootballer>(dataRow, "Name");
                if (form != null)
                {
                    form.Focus();
                }
                else
                {
                    detailForm = new ShowFootballer(dataRow, false, canEdit, teamid);
                    detailForm.PlayerGrid = this;
                    detailForm.MdiParent = this.ParentForm;
                    detailForm.Text = dataRow["Name"].ToString();
                    detailForm.Show();
                    if ((detailForm as ShowFootballer).GetStateDialogState())
                        this.ReloadPlayers();
                }
            }

        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowItemDetail();
        }

        private void gridControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(System.Windows.Forms.Cursor.Position);
            }
        }

        private void UserAccessLevel_Load()
        {
            switch (UserAccessLevel.Instance.GetAccessLevel)
            {
                case 1:
                {
                    contextMenuStrip.Items.Remove(editToolStripMenuItem);
                    contextMenuStrip.Items.Remove(deleteToolStripMenuItem);
                    break;
                }
            }
            
        }
    }
}
