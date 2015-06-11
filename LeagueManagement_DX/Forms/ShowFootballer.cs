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
using System.Data.SqlClient;
using LeagueManagement_DX.CustomControlLibrary;
using WindowsFormsControlLibrary;
using System.IO;
using LeagueManagement_DX.Properties;

//using LeagueManagement_DX.CustomControlLibrary;
namespace LeagueManagement_DX.Forms
{
    public partial class ShowFootballer : DevExpress.XtraEditors.XtraForm
    {
        public DataRow _footballerInfo;      
        private LeagueDatabaseDataSet.SelectFootballerByTeamDataTable _footballerInfoTable;
        private ControlList _controlList;
        private int _teamID;
        private int _tourID;
        private int footballerId;
        private Image temp;
        private bool IsOpenInShowTeam;
        private bool dialogState;
        private bool Isedit;
        private int count;
        private bool IsSuccess = false;
        public ShowFootballer()
        {
            InitializeComponent();
            this.pictureEditFootballer.ContextMenuStrip = new ContextMenuStrip();

            
        }
        //VINH EDIT
        public ShowFootballer(DataRow rowitem, bool OpenInShowTeam, bool IsEdit, int teamID)
        {
            InitializeComponent();
            this.pictureEditFootballer.ContextMenuStrip = new ContextMenuStrip();
            this._teamID = teamID;
            IsOpenInShowTeam = OpenInShowTeam;
            this.dialogState = false;
            this.Isedit = IsEdit;
            footballerId = Convert.ToInt32(rowitem["Id"].ToString());
            count = 0;
        }

        //VINH
        public PlayerGridPreview PlayerGrid { get; set; }

        public ShowFootballer(ControlList controlList, bool OpenInShowTeam, bool IsEdit)
        {
            
            InitializeComponent();
            this._controlList = controlList;
            this.pictureEditFootballer.ContextMenuStrip = new ContextMenuStrip();   
            this._teamID = ((FootballerList)controlList).TeamID;
            this._tourID = ((FootballerList)controlList).TourID; ;
            IsOpenInShowTeam = OpenInShowTeam;              
            this.dialogState = false;
            this.Isedit = IsEdit;
            footballerId = Convert.ToInt32(_controlList.GetSelected().DataRowItem["Id"].ToString());
            count = 0;
        }

        //VINH
        public void ReloadData()
        {
            ShowFootballer_Load(this, EventArgs.Empty);
        }
        
        private void ShowFootballer_Load(object sender, EventArgs e)
        {
            //THang
            if (UserAccessLevel.Instance.GetAccessLevel == 1)
            {
                this.simpleButtonEdit.Enabled = false;
                this.simpleButtonuOK.Enabled = false;
            }
        
            if(_teamID <0)
            {
                this.footballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
                _footballerInfo = leagueDatabaseDataSet.Footballer.Select(string.Format("CONVERT({0}, System.String) LIKE '%{1}'", "Id", footballerId.ToString()))[0];
                this.labelControlShirtNumber.Text = this.labelControlPosition.Text = "";
            }
            else
            {
                this._footballerInfoTable = selectFootballerByTeamTableAdapter.GetData(_teamID);
                _footballerInfo = _footballerInfoTable.Select(string.Format("CONVERT({0}, System.String) LIKE '%{1}'", "Id", footballerId.ToString()))[0];
                this.labelControlShirtNumber.Text = _footballerInfo["ShirtNumber"].ToString();
                this.labelControlPosition.Text = _footballerInfo["Position"].ToString();
            }

            //VINH EDIT
            //Doi ten Form
            this.Text = _footballerInfo["Name"].ToString();
            //this.Name = _footballerInfo["Name"].ToString();
            //Chuỗi Điều Kiện
            customTextBoxName.StringPattern = "^[" + Resources.VNCharacters + "A-Za-z' ]{1,30}$";
            //customTextBoxCountry.StringPattern = "^[" + Resources.VNCharacters + "a-zA-Z'-/ ]{1,15}$";

            this.simpleButtonBrowse.Visible = false;
            this.dateTimePickerDateOfBirth.Visible = true;
            this.dateTimePickerDateOfBirth.Enabled = false;
            this.simpleButtonuOK.Visible = false;           
            this.customTextBoxName.ReadOnly = true;
            this.customTextBoxCountry.ReadOnly = true;
            this.customTextBoxName.Text = _footballerInfo["Name"].ToString();
            this.customTextBoxCountry.Text = _footballerInfo["Nation"].ToString();
            this.dateTimePickerDateOfBirth.Text = ((DateTime)_footballerInfo["Birth"]).ToString();
            if (File.Exists(_footballerInfo["Avatar"].ToString()))
            {
                pictureEditFootballer.Image = Image.FromFile(_footballerInfo["Avatar"].ToString());
            }
            this.temp = this.pictureEditFootballer.Image;
            string playerId = footballerId.ToString();

            if (IsOpenInShowTeam)
            {
                this.groupControl2.Size = new System.Drawing.Size(406, 90);
                this.ClientSize = new System.Drawing.Size(437, 350);
                this.simpleButtonEdit.Location = new System.Drawing.Point(85, 310);
                this.simpleButtonExit.Location = new System.Drawing.Point(253, 310);
                this.simpleButtonuOK.Location = new System.Drawing.Point(85, 310);
                if (_tourID < 1)
                {
                    this.labelControlGoal.Text = _footballerInfo["Goals"].ToString();
                    if (_footballerInfo["MatchPlayed"].ToString() == "")
                        this.labelControlAppearance.Text = "0";
                    else
                        this.labelControlAppearance.Text = _footballerInfo["MatchPlayed"].ToString();
                }
                else
                {
                    LeagueDatabaseDataSet.SelectFootballerByTourDataTable _footballer;
                    _footballer = this.selectFootballerByTourTableAdapter.GetData(_tourID);
                    var _footballerInfoInTour = _footballer.Select(string.Format("CONVERT({0}, System.String) LIKE '%{1}'", "Id", footballerId.ToString()))[0];
                    this.labelControlGoal.Text = _footballerInfoInTour["Goals"].ToString();
                    if (_footballerInfoInTour["MatchPlayed"].ToString() == "")
                        this.labelControlAppearance.Text = "0";
                    else
                        this.labelControlAppearance.Text = _footballerInfoInTour["MatchPlayed"].ToString();
                }
            }
            else
            {
                this.playerListTableAdapter.Fill(leagueDatabaseDataSet.PlayerList);
                DataView rg = leagueDatabaseDataSet.PlayerList.DefaultView;
                rg.RowFilter = "Player = " + playerId;
                this.labelControlAppearance.Text = rg.Count.ToString();

                this.goalOfMatchTableAdapter.Fill(leagueDatabaseDataSet.GoalOfMatch);
                DataView gm = leagueDatabaseDataSet.GoalOfMatch.DefaultView;
                gm.RowFilter = "PLayerId = " + playerId + " and TypeGoal <> 'Own Goal'";
                this.labelControlGoal.Text = gm.Count.ToString();

                this.dataGridView1.Rows.Clear();
                var players = this.selectTourbyFootballerTableAdapter.GetDataByPlayer(Int32.Parse(playerId));
                foreach (DataRow item in players)
                {
                    if (item["TeamName"].ToString() == "")
                        break;
                    string time = ((DateTime)item["BeginDate"]).ToString("yyyy") + " - " + ((DateTime)item["EndDate"]).ToString("yyyy");
                    string teamName = item["TeamName"].ToString();
                    string tourName = item["TourName"].ToString();
                    DataGridViewRowCollection row = this.dataGridView1.Rows;
                    object[] Items = new object[] { time, tourName, teamName };
                    row.Add(Items);
                }
                this.dataGridView1.Sort(dataGridView1.Columns["Time"], ListSortDirection.Ascending);
            }

            if (Isedit)
            {
                if (count < 1)
                {
                    simpleButtonEdit_Click(sender, e);
                }
            }

        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            this.dialogState = false;
            if (((SimpleButton)sender).Text == "Cancel")
            {
                ShowFootballer_Load(sender, e);
                if (Isedit)
                    this.Close();
                this.simpleButtonEdit.Visible = true;
                this.simpleButtonExit.Text = "Exit";
                this.simpleButtonuOK.Visible = false;
                return;
            }
            this.Close();
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            this.customTextBoxName.ReadOnly = false;
            this.customTextBoxCountry.ReadOnly = false;
                           
            this.simpleButtonBrowse.Visible = true;
            this.customTextBoxName.Enabled = true;
            
            this.customTextBoxCountry.Enabled = true;
            this.simpleButtonuOK.Visible = true;
            this.simpleButtonEdit.Visible = false;              
            this.dateTimePickerDateOfBirth.Enabled = true;
            this.simpleButtonExit.Text = "Cancel";
        }

        private void simpleButtonBrowse_Click(object sender, EventArgs e)
        {
            this.pictureEditFootballer.LoadImage();            
        }

        private void ShowFootballer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dialogState == true)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            if (this.temp != null)
                this.temp.Dispose();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            //VINH
            //Find cai TAB hien tai, cap nhat lai ten
            if (IsOpenInShowTeam == false)
            {
                var mainForm = this.ParentForm as MainManagement;
                var thisTab = mainForm.FindChildForm<ShowFootballer>(_footballerInfo, "Name");
                thisTab.Text = this.customTextBoxName.Text;
            }
            string path = @"Image\Footballer";

            //Vinh Edit
            _footballerInfo.BeginEdit();
            _footballerInfo["Name"] = this.customTextBoxName.Text;
            _footballerInfo["Birth"] = Convert.ToDateTime(this.dateTimePickerDateOfBirth.Value);
            _footballerInfo["Nation"] = this.customTextBoxCountry.Text;
            if (_footballerInfo["Avatar"].ToString() == "" || _footballerInfo["Avatar"].ToString() == null)
                _footballerInfo["Avatar"] = path + @"\" + _footballerInfo["Id"].ToString() + ".jpg";
            _footballerInfo.EndEdit();

            if (this.checkException())
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                if (this.pictureEditFootballer.Image != null)
                {
                    if (!object.ReferenceEquals(this.temp, pictureEditFootballer.Image))
                    {
                        if (this.temp != null)
                        {
                            this.temp.Dispose();
                        }
                        this.pictureEditFootballer.Image.Save(_footballerInfo["Avatar"].ToString());
                    }

                }
                this.dialogState = true;
                if (IsOpenInShowTeam == false)
                {
                    count++;
                    ShowFootballer_Load(sender, e);
                    this.simpleButtonEdit.Visible = true;
                    this.simpleButtonExit.Text = "Exit";
                    this.simpleButtonuOK.Visible = false;

                    //Reload List
                    if (PlayerGrid != null)
                        PlayerGrid.ReloadPlayers();
                    return;
                }
                //Reload List
                Form form = Application.OpenForms["MainManagement"];               
                (form as MainManagement).Reload_PlayerGrid();
                this.Close();           
            }
        }
        private bool checkException()
        {
            try
            {
                
                //this.footballerTableAdapter.Update(this.leagueDatabaseDataSet);
                footballerTableAdapter.Update(_footballerInfo);
                this.leagueDatabaseDataSet.AcceptChanges();
                
                IsSuccess = true;
            }
            catch (SqlException ex)
            {
                this.leagueDatabaseDataSet.RejectChanges();
                DialogResult dresult = 0;
                foreach (var error in ex.Errors)
                {
                    switch ((error as SqlError).Number)
                    {
                        case 547:
                            {
                                if ((error as SqlError).Message.Contains("CK_FOOTBALLER_BIRTH"))
                                {
                                    dresult = this.Exception_CK_FOOTBALLER_BIRTH((error as SqlError).Message);
                                    break;
                                }
                                if((error as SqlError).Message.Contains("FK__Registrat__PLaye"))
                                {
                                    dresult = this.Exception_CK_REGISTRATION((error as SqlError).Message);
                                    break;
                                }
                                break;
                            }
                        case 50000:
                            this.Exception_Trigger_Raiserror((error as SqlError).Message);
                            break;
                    }
                }
            }
            //this.footballerTableAdapter.Fill(this.leagueDatabaseDataSet.Footballer);
            return IsSuccess;
        }
        private void Exception_Trigger_Raiserror(string p)
        {
            IsSuccess = false;
            MessageBox.Show(p, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private DialogResult Exception_CK_FOOTBALLER_BIRTH(string p)
        {
            IsSuccess = false;
            string message = "Invalid Footballer's Date of Birth\n The Date of Bitrth must be smaller than the current Date";
            return MessageBox.Show(message, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private DialogResult Exception_CK_REGISTRATION(string p)
        {
            IsSuccess = false;
            string message = "Could not delete player has been joined tour";
            return MessageBox.Show(message, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void ShowFootballer_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {

            DataRow deleterow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(this._footballerInfo["Id"]));
            string path = deleterow["Avatar"].ToString();
            deleterow.Delete();
            this.checkException();
            if (File.Exists(path))
                File.Delete(path);                
        }
        public bool DeleteFootballer()
        {
            this.footballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
            DataRow deleterow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(this._footballerInfo["Id"]));
            string path = deleterow["Avatar"].ToString();
            deleterow.Delete();
            if (checkException())
            {
                if (File.Exists(path))
                    File.Delete(path);
                return true;
            }
            else
                return false;
        }

        private void customTextBoxName_Paint(object sender, PaintEventArgs e)
        {
            this.simpleButtonuOK.Enabled = true;
            foreach (var control in this.groupControl1.Controls)
            {
                if (control is CustomTextBox)
                {
                    if (!(control as CustomTextBox).CheckCodition())
                    {
                        this.simpleButtonuOK.Enabled = false;
                        return;
                    }
                }
            }
        }
        public bool GetStateDialogState()
        {
            return dialogState;
        }

    }
}