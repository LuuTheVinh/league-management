using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LeagueManagement_DX.CustomControlLibrary;
using System.IO;
using WindowsFormsControlLibrary;
using System.Data.SqlClient;
using DevExpress.XtraSpellChecker;
using LeagueManagement_DX.Properties;

namespace LeagueManagement_DX.Forms
{
    public partial class AddTeamForm : DevExpress.XtraEditors.XtraForm
    {
        private ControlList _controlList;
        private LeagueDatabaseDataSet.FootballerDataTable _freePlayerTable;
      
        private LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow _teamRow;
        bool formState;
        public int TeamID { get; set; }
        public LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow TeamRow
        {
            get { return _teamRow; }
            set { _teamRow = value; }
        }

        int count;
        Image temp;
        List<DataRow> deleteList;
        public AddTeamForm(ControlList controlList)
        {
            InitializeComponent();
            this._controlList = controlList;
        }
        
        public AddTeamForm()
        {
            InitializeComponent();

            this.pictureEditTeamLogo.ContextMenuStrip = new ContextMenuStrip();
            this.deleteList = new List<DataRow>();

            this.formState = false;
            count = 0;
        }
        private void AddTeam_Load(object sender, EventArgs e)
        {
            customTextBoxName.StringPattern = "^[" + Resources.VNCharacters + "a-zA-Z'\\- ]{1,30}$";
            customTextBoxStadium.StringPattern = "^[" + Resources.VNCharacters + "a-zA-Z'\\- ]{1,30}$";

            this.pictureEditTeamLogo.ContextMenuStrip = new ContextMenuStrip();
            count = 0;
            this.deleteList = new List<DataRow>();
            this.formState = false;

            this.selectFootballerByTeamDataGridView.Refresh();

            this.pictureEditTeamLogo.ContextMenuStrip = new ContextMenuStrip();

            //VINH
            LoadeFreePlayerGridView();

            if (this.TeamRow == null)
            {
                //this.selectFootballerByTeamTableAdapter.Fill(this.leagueDatabaseDataSet1.SelectFootballerByTeam, 1);
                //this.selectFootballerByTeamDataGridView.DataSource = this.leagueDatabaseDataSet1.SelectFootballerByTeam;
                
                this.groupControl3.Visible = false;
                this.labelControlNumber.Text = "0";
                addPlayerBtn.Visible = false;
                groupControl2.Height = 400;
            }
            else
            {
                groupControl2.Height = 190;

                this.Text = this.TeamRow["Name"].ToString();
                TeamID = Convert.ToInt32(TeamRow["Id"]);
                this.teamDetailTableAdapter.Fill(this.leagueDatabaseDataSet1.TeamDetail);
                
                //VINH
                LoadSelectPlayersGridView();

                this.count = this.selectFootballerByTeamDataGridView.Rows.Count;
                this.labelControlNumber.Text = this.selectFootballerByTeamDataGridView.Rows.Count.ToString();
                this.temp = this.pictureEditTeamLogo.Image;
                this.customTextBoxName.Text = TeamRow["Name"].ToString();
                this.customTextBoxStadium.Text = TeamRow["Stadium"].ToString();
                this.selectFootballerByTeamDataGridView.Columns["Id1"].Visible = false;
                if (File.Exists(this.TeamRow["Avatar"].ToString()))
                {
                    this.pictureEditTeamLogo.Image = Image.FromFile(this.TeamRow["Avatar"].ToString());
                    this.pictureEditTeamLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                }
                this.temp = this.pictureEditTeamLogo.Image;
            }

        }

        //VINH
        private void LoadPositionForPlayer()
        {
            foreach (DataGridViewRow row in selectFootballerByTeamDataGridView.Rows)
            {
                var combo = row.Cells["Position1"] as DataGridViewComboBoxCell;
                if(combo == null) continue;

                foreach (var item in combo.Items)
                {
                    if (item.ToString().Trim(' ') == row.Cells["tempPosition"].Value.ToString().Trim(' '))
                    {
                        combo.Value = item;
                        break;
                    }
                }
            }
        }

        private void LoadSelectPlayersGridView()
        {
            this.selectFootballerByTeamTableAdapter.Fill(this.leagueDatabaseDataSet1.SelectFootballerByTeam, TeamID);
            this.selectFootballerByTeamDataGridView.DataSource = this.leagueDatabaseDataSet1.SelectFootballerByTeam;
            if (this.groupControl3.Visible == false)
                this.groupControl3.Visible = true;

            LoadPositionForPlayer();

            simpleButtonOK.Enabled = true;
        }

        private void LoadeFreePlayerGridView()
        {
            addPlayerBtn.Enabled = false;

            if(this.TeamRow == null)
                simpleButtonOK.Enabled = false;

            var freePlayerTable = this.footballerTableAdapter.GetDataByPlayerFree();
            this.footballerDataGridView.DataSource = freePlayerTable;

            foreach (DataGridViewRow row in footballerDataGridView.Rows)
            {
                var dataGridViewCheckBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (dataGridViewCheckBoxCell != null)
                    dataGridViewCheckBoxCell.Value = dataGridViewCheckBoxCell.FalseValue;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            this.formState = false;    
            this.Close();
        }

        private void AddTeam_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.formState == true)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            
            this.TeamRow = null;

            this.customTextBoxName.Text = "";
            this.customTextBoxStadium.Text = "";

            if (this.pictureEditTeamLogo.Image != null) 
                this.pictureEditTeamLogo.Image.Dispose();

            this.deleteList.Clear();

            //Clear
            this.leagueDatabaseDataSet1.SelectFootballerByTeam.Rows.Clear();
            this.selectFootballerByTeamDataGridView.DataSource = this.leagueDatabaseDataSet1.SelectFootballerByTeam;

        }

        private void pictureEditTeamLogo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButtonBrowse_Click(object sender, EventArgs e)
        {
            pictureEditTeamLogo.LoadImage();
            pictureEditTeamLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        //private bool IsValidInformation()
        //{
            /*
            this.simpleButtonOK.Enabled = true;
            
            if (this.TeamRow == null)
            {
                this.simpleButtonOK.Enabled = true;
                foreach (DataGridViewRow row in this.footballerDataGridView.Rows)
                {
                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)row.Cells["Select"];
                    if (Convert.ToInt32(check.EditedFormattedValue) != 0)
                    {
                        if (object.ReferenceEquals(row.Cells["ShirtNumber"].Value, null))
                        {
                            this.simpleButtonOK.Enabled = false;
                            return false;
                        }
                        if (object.ReferenceEquals(row.Cells["Position"].Value, null))
                        {
                            this.simpleButtonOK.Enabled = false;
                            return false;
                        }
                    }
                    else
                    {
                        //if (object.ReferenceEquals(row.Cells["ShirtNumber"].Value, null))
                        //{
                        //    addPlayerBtn.Enabled = false;
                        //    this.simpleButtonOK.Enabled = false;
                        //    return false;
                        //}
                        //if (object.ReferenceEquals(row.Cells["Position"].Value, null))
                        //{
                        //    addPlayerBtn.Enabled = false;
                        //    this.simpleButtonOK.Enabled = false;
                        //    return false;
                        //}
                    }
                }
             
            }
            else if (this.TeamRow != null)
            {
                //Vinh
                //Không cần kt ở đây
                //CheckFreePlayersSelected();

                foreach (DataGridViewRow row in this.selectFootballerByTeamDataGridView.Rows)
                {
                    if (object.ReferenceEquals(row.Cells["ShirtNumber1"].Value, null))
                    {
                        this.simpleButtonOK.Enabled = false;
                        return false;
                    }
                    if (object.ReferenceEquals(row.Cells["Position1"].Value, null))
                    {
                        this.simpleButtonOK.Enabled = false;
                        return false;
                    }
                }
               
            }
            this.simpleButtonOK.Enabled = true;
            */
            //return true;
        //}

        private void CheckException()
        {
            try
            {
                this.teamDetailTableAdapter.Update(this.leagueDatabaseDataSet1);
                this.leagueDatabaseDataSet1.AcceptChanges();
            }
            catch (SqlException ex)
            {
                this.leagueDatabaseDataSet1.RejectChanges();
                DialogResult dresult = 0;
                foreach (var error in ex.Errors)
                {
                    switch ((error as SqlError).Number)
                    {
                        case 547:
                            {
                                if ((error as SqlError).Message.Contains("CK_TeamDetail_NUMBER"))
                                {
                                    dresult = this.Exception_CK_NUMBER((error as SqlError).Message);
                                    break;
                                }
                                if ((error as SqlError).Message.Contains("CK_TeamDetail_POSITION"))
                                {
                                    dresult = this.Exception_CK_POSITION((error as SqlError).Message);
                                    break;
                                }
                                
                                break;
                            }
                        case 50000:
                            {
                                if ((error as SqlError).Message.Contains("Every team can not has 2 same shirtnumber"))
                                {
                                    dresult = this.Exception_CK_SHIRTNUMBER((error as SqlError).Message);
                                    break;
                                }
                                else
                                {
                                    this.Exception_Trigger_Raiserror((error as SqlError).Message);
                                    break;
                                }
                                
                            }
                            
                    }
                }
                if (dresult != System.Windows.Forms.DialogResult.Retry)
                {
                    this.Close();
                }
            }
        }
        private DialogResult Exception_Trigger_Raiserror(string p)
        {
            return MessageBox.Show(p, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private DialogResult Exception_CK_NUMBER(string p)
        {
            string msg = "Invalid Shirt Number. Shirt Number must be from 1 to 100";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_CK_POSITION(string p)
        {
            string msg = "Invalid Position.\n Position must be in 'CF,RW, SS, LW, AM, RM, CM, LM, RWB, DM, LWB, RB, CB, LB, SW, GK'";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_CK_SHIRTNUMBER(string p)
        {
            string msg = "The Shirt Number has already existed. Please try again!";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            if (TeamRow == null)
            {
                DataRow newRow = this.leagueDatabaseDataSet1.Team.NewRow();
                newRow.BeginEdit();
                newRow["Name"] = this.customTextBoxName.Text;
                newRow["Stadium"] = this.customTextBoxStadium.Text;
                newRow.EndEdit();
                this.leagueDatabaseDataSet1.Team.Rows.Add(newRow);
                this.teamTableAdapter.Update(this.leagueDatabaseDataSet1);
                this.leagueDatabaseDataSet1.AcceptChanges();

                this.teamTableAdapter.Fill(this.leagueDatabaseDataSet.Team);
                DataRow lastrow = this.leagueDatabaseDataSet1.Team.Last();
                int teamId = Convert.ToInt32(lastrow["Id"]);
                string dirPath = @"Image\Team";
                lastrow.BeginEdit();
                lastrow["Avatar"] = dirPath + "\\" + lastrow["Id"].ToString() + ".jpg";
                lastrow.EndEdit();
                this.teamTableAdapter.Update(this.leagueDatabaseDataSet1.Team);
                this.leagueDatabaseDataSet1.AcceptChanges();

                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
                if (this.pictureEditTeamLogo.Image != null)
                    this.pictureEditTeamLogo.Image.Save(lastrow["Avatar"].ToString());

                //Vinh
                AddFreePlayersToTeam(teamId);

                this.formState = true;
                this.Close();
            }
            else
            {
                //this.teamDetailTableAdapter.Fill(this.leagueDatabaseDataSet1.TeamDetail);

                //Vinh sửa, cho nó save ở nút remove luôn, để cập nhật được lên list free
                //SaveRemovePlayers();

                //this.CheckException();

                //int _teamId = Convert.ToInt32(this.TeamRow["Id"]);
                //this.teamTableAdapter.Fill(this.leagueDatabaseDataSet1.Team);
                //DataRow editRow = this.leagueDatabaseDataSet1.Team.FindById(_teamId);
                //editRow.BeginEdit();
                //editRow["Name"] = this.customTextBoxName.Text;
                //editRow["Stadium"] = this.customTextBoxStadium.Text;
                //editRow.EndEdit();

                string path = @"Image\Team";
                this.TeamRow.BeginEdit();
                this.TeamRow["Name"] = this.customTextBoxName.Text;
                this.TeamRow["Stadium"] = this.customTextBoxStadium.Text;
                if (this.TeamRow["Avatar"].ToString() == "" || this.TeamRow["Avatar"].ToString() == null)
                    this.TeamRow["Avatar"] = path + @"\" + this.TeamRow["Id"].ToString() + ".jpg";
                this.TeamRow.EndEdit();
                this.teamTableAdapter.Update(TeamRow);
                this.leagueDatabaseDataSet1.Team.AcceptChanges();
                
                //Vinh sửa không add ở nút OK nữa, chuyển qua nút Add
                //AddFreePlayersToTeam(TeamID);
                //this.CheckException();

                this.teamDetailTableAdapter.Fill(this.leagueDatabaseDataSet1.TeamDetail);
                      
                foreach (DataGridViewRow row in this.selectFootballerByTeamDataGridView.Rows)
                {
                    int _playerID = Convert.ToInt32(row.Cells["Id1"].Value);
                    DataRow _editRow = this.leagueDatabaseDataSet1.TeamDetail.FindByTeamIdPlayerId(TeamID, _playerID);
                    _editRow.BeginEdit();
                    _editRow["ShirtNumber"] = row.Cells["ShirtNumber1"].Value;
                    _editRow["Position"] = row.Cells["Position1"].Value;
                    _editRow.EndEdit();
                }
                this.CheckException();
                
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                if (this.pictureEditTeamLogo.Image != null)
                {
                    if (!object.ReferenceEquals(this.temp, this.pictureEditTeamLogo.Image))
                    {
                        if (this.temp != null)
                        {
                            this.temp.Dispose();
                        }

                        this.pictureEditTeamLogo.Image.Save(TeamRow["Avatar"].ToString());
                    }

                }
                //this.teamDetailTableAdapter.Fill(this.leagueDatabaseDataSet1.TeamDetail);

                this.formState = true;
                this.Close();
            }
        }

        /// VINH
        /// <summary>
        /// Thêm cầu thủ tự do vào đội bóng
        /// </summary>
        /// <param name="teamid">Id của đội bóng</param>
        private void AddFreePlayersToTeam(int teamid)
        {
            foreach (DataGridViewRow row in this.footballerDataGridView.Rows)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)row.Cells["Select"];
                if (Convert.ToInt32(check.EditedFormattedValue) == 1)
                {
                    DataRow _newRow;
                    _newRow = this.leagueDatabaseDataSet1.TeamDetail.NewRow();
                    _newRow.BeginEdit();
                    _newRow["TeamId"] = teamid;
                    _newRow["PlayerId"] = (row.DataBoundItem as DataRowView).Row["Id"];
                    _newRow["ShirtNumber"] = row.Cells["ShirtNumber"].Value;
                    _newRow["Position"] = row.Cells["Position"].Value;
                    _newRow.EndEdit();
                    this.leagueDatabaseDataSet1.TeamDetail.Rows.Add(_newRow);
                }
            }

            this.CheckException();
        }

        private void SaveRemovePlayers()
        {
            foreach (DataRow item in this.deleteList)
            {
                DataRow deleteRow = this.leagueDatabaseDataSet1.TeamDetail.FindByTeamIdPlayerId(Convert.ToInt32(item["TeamId"]), Convert.ToInt32(item["PlayerId"]));
                deleteRow.Delete();
                try
                {
                    this.teamDetailTableAdapter.Update(deleteRow);
                    this.leagueDatabaseDataSet1.TeamDetail.AcceptChanges();
                }
                catch (Exception exception)
                {
                    this.leagueDatabaseDataSet1.RejectChanges();
                    MessageBox.Show(exception.Message);
                }
                
            }
            this.deleteList.Clear();
        }

        private void customTextBoxName_Paint(object sender, PaintEventArgs e)
        {
            //this.simpleButtonOK.Enabled = true;
            //foreach (var control in this.groupControl1.Controls)
            //{
            //    if (control is CustomTextBox)
            //    {
            //        if (!(control as CustomTextBox).CheckCodition() || !this.IsValidInformation())
            //        {

            //                this.simpleButtonOK.Enabled = false;
            //                return;
            //        }
            //    }
            //}
        }

        private bool IsValidInformation()
        {
            if (this.TeamRow == null)
            {
                foreach (DataGridViewRow row in this.footballerDataGridView.Rows)
                {
                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell) row.Cells["Select"];
                    if (check.Value == check.TrueValue)
                    {
                        simpleButtonOK.Enabled = true;
                        if (object.ReferenceEquals(row.Cells["ShirtNumber"].Value, null))
                        {
                            simpleButtonOK.Enabled = false;
                            return false;
                        }

                        if (object.ReferenceEquals(row.Cells["Position"].Value, null))
                        {
                            simpleButtonOK.Enabled = false;
                            return false;
                        }
                    }
                }

                simpleButtonOK.Enabled = true;
                if (!customTextBoxName.CheckCodition() || !customTextBoxStadium.CheckCodition())
                {
                    simpleButtonOK.Enabled = false;
                    return false;
                }
            }
            else
            {
                simpleButtonOK.Enabled = true;
                if (!customTextBoxName.CheckCodition() || !customTextBoxStadium.CheckCodition())
                {
                    simpleButtonOK.Enabled = false;
                    return false;
                }

                foreach (DataGridViewRow row in this.footballerDataGridView.Rows)
                {
                    DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell) row.Cells["Select"];
                    if (check.Value == check.TrueValue)
                    {
                        addPlayerBtn.Enabled = true;
                        if (object.ReferenceEquals(row.Cells["ShirtNumber"].Value, null))
                        {
                            addPlayerBtn.Enabled = false;
                            return false;
                        }

                        if (object.ReferenceEquals(row.Cells["Position"].Value, null))
                        {
                            addPlayerBtn.Enabled = false;
                            return false;
                        }
                    }
                }

                foreach (DataGridViewRow row in this.selectFootballerByTeamDataGridView.Rows)
                {
                    simpleButtonOK.Enabled = true;
                    if (object.ReferenceEquals(row.Cells["ShirtNumber1"].Value, null))
                    {
                        this.simpleButtonOK.Enabled = false;
                        return false;
                    }
                    if (object.ReferenceEquals(row.Cells["Position1"].Value, null))
                    {
                        this.simpleButtonOK.Enabled = false;
                        return false;
                    }
                }
            }

            return true;
        }

        private void footballerDataGridView_Paint(object sender, PaintEventArgs e)
        {
            //this.simpleButtonOK.Enabled = true;
            //foreach (var control in this.groupControl1.Controls)
            //{
            //    if (control is CustomTextBox)
            //    {
            //        if (!(control as CustomTextBox).CheckCodition() || !this.IsValidInformation())
            //        {

            //                this.simpleButtonOK.Enabled = false;
            //                return;
                        
            //        }
            //    }
            //}

            //CheckFreePlayersSelected();
        }

        private void selectFootballerByTeamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.selectFootballerByTeamDataGridView.Columns[e.ColumnIndex].Name == "Mark")
            //{
            //    DataGridViewCheckBoxCell cbk = (DataGridViewCheckBoxCell)this.selectFootballerByTeamDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //    if (Convert.ToInt32(cbk.EditedFormattedValue) == 1)
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        count--;

            //    }
            //    this.selectFootballerByTeamDataGridView.InvalidateCell(e.ColumnIndex, e.RowIndex);

            //}

            //this.labelControlNumber.Text = count.ToString();
            //this.selectFootballerByTeamDataGridView.InvalidateCell(e.ColumnIndex, e.RowIndex);
        }

        private void simpleButtonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell selectedCell in this.selectFootballerByTeamDataGridView.SelectedCells)
            {
                if (selectedCell.Selected)
                {
                    DataGridViewRow selectedRow = this.selectFootballerByTeamDataGridView.Rows[selectedCell.RowIndex];
                    if (selectedRow != null)
                    {
                       
                        int _playerId = Convert.ToInt32(selectedRow.Cells["Id1"].Value);
                        int _teamId = Convert.ToInt32(TeamRow["Id"]);
                        DataRow deleteRow = this.leagueDatabaseDataSet1.TeamDetail.FindByTeamIdPlayerId(_teamId, _playerId);
                        this.deleteList.Add(deleteRow);
                        this.selectFootballerByTeamDataGridView.Rows.Remove(selectedRow);
                        this.selectFootballerByTeamDataGridView.Refresh();
                        
                    }
                }
            }

            SaveRemovePlayers();
            LoadeFreePlayerGridView();

            labelControlNumber.Text = CountPlayersInTeam().ToString();
        }

        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            AddFreePlayersToTeam(TeamID);
            LoadSelectPlayersGridView();
            LoadeFreePlayerGridView();
            
            labelControlNumber.Text = CountPlayersInTeam().ToString();

            selectFootballerByTeamDataGridView.ClearSelection();
            selectFootballerByTeamDataGridView.Rows[selectFootballerByTeamDataGridView.RowCount - 1].Selected = true;
            selectFootballerByTeamDataGridView.Rows[selectFootballerByTeamDataGridView.RowCount - 1].Cells[2].Selected = true;
        }

        private void footballerDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var gridview = sender as DataGridView;
            if (gridview == null) return;

            if (gridview.SelectedCells.Count == 0) return;

            if (gridview.SelectedCells[0].OwningColumn != gridview.Columns["Select"])
            {
                var check = (gridview.Rows[e.RowIndex].Cells["Select"] as DataGridViewCheckBoxCell);
                if (check != null) check.Value = check.FalseValue;
            }
        }

        private int CountPlayersInTeam()
        {
            int playerchecked = 0;
            foreach (DataGridViewRow row in footballerDataGridView.Rows)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)row.Cells["Select"];

                if (check.Value == check.TrueValue)
                {
                    playerchecked++;
                }
            }

            return selectFootballerByTeamDataGridView.RowCount + playerchecked;
        }

        private void footballerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gridview = sender as DataGridView;
            if (gridview == null) return;

            if (gridview.SelectedCells.Count == 0) return;
            
            if (gridview.SelectedCells[0].OwningColumn == gridview.Columns["Select"])
            {
                var check = (gridview.Rows[e.RowIndex].Cells["Select"] as DataGridViewCheckBoxCell);
                if (check == null) return;

                if (check.Value == null || check.Value == check.FalseValue)
                {
                    check.Value = check.TrueValue;
                }
                else
                {
                    check.Value = check.FalseValue;
                }

                gridview.RefreshEdit();
            }
        }

        private bool CheckShirtNumberInput(object sender, DataGridViewCellEventArgs e)
        {
            //Check ShirtNumber Input
            var gridview = sender as DataGridView;
            if (gridview == null) return false;

            if (gridview.SelectedCells.Count == 0) return false;

            if (gridview.SelectedCells[0].OwningColumn == gridview.Columns[e.ColumnIndex])
            {
                var cell = (gridview.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewTextBoxCell);
                if (cell == null) return false;

                if (cell.Value == null || cell.Value.ToString() == string.Empty) return false;

                int tempTry;
                int.TryParse(cell.Value.ToString(), out tempTry);

                if (tempTry == 0)
                {
                    cell.Value = "";
                    MessageBox.Show("Only allow number frome 1 to 99.");
                }
                else
                {
                    //if (int.Parse(cell.Value.ToString()) < 1 || int.Parse(cell.Value.ToString()) > 99)
                    if (tempTry < 1 || tempTry > 99)
                    {
                        cell.Value = "";
                        MessageBox.Show("Invalid Shirt Number. Shirt Number must be from 1 to 99.");
                    }
                }
            }

            return true;
            //End Check ShirtNumber Input
        }

        private void footballerDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            labelControlNumber.Text = CountPlayersInTeam().ToString();

            CheckShirtNumberInput(sender, e);

            IsValidInformation();
        }

        private void customTextBoxName_xTextChanged(object sender, EventArgs e)
        {
            IsValidInformation();
        }

        private void selectFootballerByTeamDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void selectFootballerByTeamDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == selectFootballerByTeamDataGridView.Columns["ShirtNumber1"].Index)
            {
                MessageBox.Show("Invalid Shirt Number. Shirt Number must be from 1 to 99.");
            }
        }
    }
}