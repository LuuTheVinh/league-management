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
using System.IO;

namespace LeagueManagement_DX.Forms
{
    public partial class Result : DevExpress.XtraEditors.XtraForm
    {
        private LeagueDatabaseDataSet.MatchRow matchrow;
        private LeagueDatabaseDataSet.ToursRow tourrow;
        private LeagueDatabaseDataSet.ResultRow resultRow; 
        private int tourId;
        private int teamId;
        private int matchId;
        private bool IsChanged;
        private LeagueDatabaseDataSet.TeamRow teamRow;
        private bool IsCanUpdate;
        public Result()
        {
            InitializeComponent();
        }
        public Result(DataRow matchRow, bool flag)
        {
            InitializeComponent();
            matchrow = matchRow as LeagueDatabaseDataSet.MatchRow ;
            matchId = matchrow.Id;
            IsCanUpdate = flag;
        }

        private void Result_Load(object sender, EventArgs e)
        {

            if (IsCanUpdate == false)
                this.simpleButton1.Enabled = false;
            this.toursTableAdapter.Fill(leagueDatabaseDataSet.Tours);
            tourId = Convert.ToInt32(matchrow["TourId"].ToString());
            DataView dv = leagueDatabaseDataSet.Tours.DefaultView;
            dv.RowFilter = "Id = " + tourId.ToString();
            this.tourrow = dv[0].Row as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow;
            this.labelControlTourname.Text = tourrow["TourName"].ToString();
            this.labelControlStadium.Text = matchrow["Stadium"].ToString();
            if (matchrow["RealDate"].ToString() == "")
            {
                this.labelControlDate.Text = "Not Played";
            }
            else
            {
                this.labelControlDate.Text = ((DateTime)matchrow["RealDate"]).ToString("dd/MM/yyyy hh:mm");
            }
            this.labelControlRound.Text = matchrow["Round"].ToString();           
            this.SetTeamNameAndAvatar(matchrow.Home, this.pictureEdit1, this.labelControlHome);
            this.SetTeamNameAndAvatar(matchrow.Away, this.pictureEdit2, this.labelControlAway);
            LoadGoalList();
            IsChanged = false;
            if (UserAccessLevel.Instance.GetAccessLevel == 1)
            {
                this.simpleButton1.Enabled = false;
            }
        }
        private void LoadGoalList()
        {
            this.selectFootballerByMatchTableAdapter.FillByMatchId(leagueDatabaseDataSet.SelectFootballerByMatch, matchId);
            this.resultTableAdapter.Fill(leagueDatabaseDataSet.Result);
            resultRow = this.leagueDatabaseDataSet.Result.FindByMatchId(matchId);
            this.labelControlHomeGoal.Text = resultRow.Home.ToString();
            this.labelControlAwayGoal.Text = resultRow.Away.ToString();
            int No = 1;
            this.dataGridViewGoals.Rows.Clear();
            foreach (DataRow item in leagueDatabaseDataSet.SelectFootballerByMatch)
            {
                string teamName = item["TeamName"].ToString();
                string footballerName = item["Footballername"].ToString();
                string timeGoal = item["Time"].ToString();
                string GoalType = item["TypeGoal"].ToString();

                DataGridViewRowCollection row = this.dataGridViewGoals.Rows;
                object[] goal = new object[] { No.ToString(), timeGoal, teamName, footballerName, GoalType };
                row.Add(goal);
                No++;
            }
            this.dataGridViewGoals.Sort(dataGridViewGoals.Columns["Time"], ListSortDirection.Ascending);
            IsChanged = true;
        }
        private void loadImage(string _stringpath, PictureEdit team)
        {
            team.ContextMenuStrip = new ContextMenuStrip();
            team.ContextMenuStrip.Enabled = false;
            if (File.Exists(_stringpath))
            {
                team.Image = Image.FromFile(_stringpath);
                
            }         
        }
        private void SetTeamNameAndAvatar(int idTeam, PictureEdit pic, LabelControl label)
        {
            this.teamTableAdapter.Fill(leagueDatabaseDataSet.Team);
            DataView dv = leagueDatabaseDataSet.Team.DefaultView;
            dv.RowFilter = "Id = " + idTeam.ToString();
            this.teamRow = dv[0].Row as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow;
            label.Text = teamRow.Name;
            loadImage(teamRow.Avatar, pic);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var form = new AddResultForm(matchrow);
            DialogResult dl = form.ShowDialog();
            this.Close();
            //if ( dl == System.Windows.Forms.DialogResult.OK)
            //    LoadGoalList();
        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsChanged == true)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //FormCollection formCollec = Application.OpenForms; //["TourManagement"];
                //foreach (Form frm in formCollec)
                //{
                //    if (frm.Name == "TourManagement" && frm.Text == tourrow["TourName"].ToString())
                //    {
                //        (frm as TourManagement).ReloadMatchList();
                //    }
                //    if (frm.Name == "ShowTeam" && (frm.Text == labelControlHome.Text || frm.Text == labelControlAway.Text))
                //    {
                //        (frm as ShowTeam).LoadMatchList();
                //    }
                //}
            }
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}