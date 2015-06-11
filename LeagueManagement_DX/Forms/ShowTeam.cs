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

namespace LeagueManagement_DX.Forms
{
    public partial class ShowTeam : DevExpress.XtraEditors.XtraForm
    {
        private ControlList controlList;
        private bool IsOpenInMain;
        private int TourId;
        private int TeamId;
        private bool dialogState;
        public LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow teamDataRow;
        private Form parentForm;
        public ShowTeam(ControlList _controlList, LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow _teamDataRow, bool OpenInMain, int _tourID)
        {
            InitializeComponent();
            IsOpenInMain = OpenInMain;
            TourId = _tourID;
            //Vinh Sua
            foreach (var row in teamTableAdapter.GetData())
            {
                if (row.Id == _teamDataRow.Id)
                {
                    teamDataRow = row;
                    break;
                }
            }

            TeamId = Convert.ToInt32(this.teamDataRow[0]);
            controlList = _controlList;
            dialogState = false;
    
        }

        public void ReloadData()
        {
            ShowTeam_Load(this, EventArgs.Empty);
        }
        public void LoadMatchList()
        {
            matchList.TourID = TourId;
            matchList.TeamID = TeamId;
            matchList.LoadDataFromTable(IsOpenInMain);
            if (IsOpenInMain)
            {
                matchList.SetLevelAccess(1);
            }
        }
        public void LoadFootballer()
        {
            footballerList.TeamID = TeamId;
            footballerList.TourID = TourId;
            footballerList.LoadDataFromTable(IsOpenInMain);
        }
        private void ShowTeam_Load(object sender, EventArgs e)
        {
            this.Text = teamDataRow.Name;
            LoadFootballer();
            LoadMatchList();
                    
            this.customTextBoxName.Text = this.teamDataRow["Name"].ToString();
            this.customTextBoxStadium.Text = this.teamDataRow["Stadium"].ToString();
            this.pictureEdit1.ContextMenuStrip = new ContextMenuStrip();
            this.pictureEdit1.ContextMenuStrip.Enabled = false;
            this.loadImage(teamDataRow["Avatar"].ToString());
            
            if (IsOpenInMain == false)
            {
                this.groupControlTeamoverview.Show();
                SetTeamOverView(TourId);
                this.registrationTableAdapter.Fill(leagueDatabaseDataSet1.Registration);
                DataView dv = leagueDatabaseDataSet1.Registration.DefaultView;
                dv.RowFilter = "TourId = " + TourId + " and " + "TeamId = " + TeamId;
                this.customTextBoxNumberPlayer.Text = dv.Count.ToString();
            }
            else
            {
                this.groupControlTeamoverview.Hide();
                this.groupControlListMatch.Location = new Point(13, 182);
                this.groupControlListMatch.Size = new System.Drawing.Size(462, 350);
                this.simpleButtonEdit.Hide();
                this.teamDetailTableAdapter.Fill(leagueDatabaseDataSet1.TeamDetail);
                DataView dv = leagueDatabaseDataSet1.TeamDetail.DefaultView;
                dv.RowFilter ="TeamId = " + TeamId;
                this.customTextBoxNumberPlayer.Text = dv.Count.ToString();
            }
            if (UserAccessLevel.Instance.GetAccessLevel == 1)
            {
                this.simpleButtonEdit.Enabled = false;               
                footballerList.SetLevelAccess(1);
                if (IsOpenInMain == false)
                {
                    matchList.SetLevelAccess(1);
                }
            }
        }
        public void SetTeamOverView(int id = 0)
        {
            if (IsOpenInMain == false)
            {
                FindPostionTeam(id);
                TourId = id;
                this.teamJoinTourTableAdapter.Fill(leagueDatabaseDataSet1.TeamJoinTour);
                var teamjointourRow = leagueDatabaseDataSet1.TeamJoinTour.FindByTourIdTeamId(TourId, TeamId);
                this.labelControlWin.Text = teamjointourRow["Win"].ToString();
                this.labelControlDraw.Text = teamjointourRow["Draw"].ToString();
                this.labelControlLose.Text = teamjointourRow["Lose"].ToString();
                this.labelControlPoint.Text = teamjointourRow["Point"].ToString();
            }          
        }
        public void FindPostionTeam(int id)
        {
            //Find Position of team
            this.toursTableAdapter.Fill(leagueDatabaseDataSet1.Tours);
            DataView dv1 = leagueDatabaseDataSet1.Tours.DefaultView;
            dv1.RowFilter = "Id = " + ((id == 0 )? TourId : id);
            FormCollection formCollec = Application.OpenForms; //["TourManagement"];
            foreach (Form frm in formCollec)
            {
                if (frm.Name == "TourManagement" && frm.Text == dv1[0].Row["TourName"].ToString())
                {
                    parentForm = frm;
                    this.labelControlPosition.Text = ((frm as TourManagement).GetTeamPosition(teamDataRow["Name"].ToString()).ToString());
                }
            }
        }
        private void loadImage(string _stringpath)
        {
            if (File.Exists(_stringpath))
            {
                //this.pictureEdit1.Image = Image.FromFile(_stringpath);
                this.pictureEdit1.Image = Image.FromHbitmap(new Bitmap(_stringpath).GetHbitmap());
            }
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            DialogResult dlResult = System.Windows.Forms.DialogResult.No;
            if (IsOpenInMain == false)
            {
                this.toursTableAdapter.Fill(leagueDatabaseDataSet1.Tours);
                DataRow[] tourRows = leagueDatabaseDataSet1.Tours.Select("Id = " + TourId);
                var Regisform = new RegisterForm(tourRows[0]);
                Regisform.ShowDialog(TeamId);
                if (Regisform.Has_Change)
                {
                    // reload playerList and count player
                    LoadFootballer();
                    this.registrationTableAdapter.Fill(leagueDatabaseDataSet1.Registration);
                    DataView dv = leagueDatabaseDataSet1.Registration.DefaultView;
                    dv.RowFilter = "TourId = " + TourId + " and " + "TeamId = " + TeamId;
                    this.customTextBoxNumberPlayer.Text = dv.Count.ToString();
                }
            }
            else
            {
                var editteamform = new AddTeamForm();
                editteamform.TeamRow = teamDataRow;
                dlResult = editteamform.ShowDialog();
                if (dlResult == System.Windows.Forms.DialogResult.OK)
                {
                    ShowTeam_Load(sender, e);
                    dialogState = true;
                }
            }
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dialogState)
            {
                //FindAllReferenceAndReload();
            }   
            this.Close();
        }

        private void ShowTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.dialogState == true)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //FindAllReferenceAndReload();
            }   
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            //pictureEdit1.Image.Dispose();
        }
        private void FindAllReferenceAndReload()
        {
            FormCollection formCollec = Application.OpenForms; //["TourManagement"];
            foreach (Form frm in formCollec)
            {
                if (frm.Name == "TourManagement")
                {
                    (frm as TourManagement).ReloadTeamMatchStandingTab();
                }
            }
            Form form = Application.OpenForms["MainManagement"];
            (form as MainManagement).Reload_AfterEdit();
        }
    }
}