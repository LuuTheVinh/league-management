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

namespace LeagueManagement_DX.Forms
{
    public partial class AddResult : DevExpress.XtraEditors.XtraForm
    {
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
            public ComboBoxItem(string text, object value)
            {
                this.Text = text;
                this.Value = value;
            }
        }
        private LeagueManagement_DX.LeagueDatabaseDataSet.MatchRow _matchRow;
        private LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow _homeTeam;
        private LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow _awayTeam;
        private int _tourID;
        private List<ComboBoxItem> _listItem;
       
        public LeagueManagement_DX.LeagueDatabaseDataSet.MatchRow MatchRow
        {
            get { return this._matchRow; }
            set { this._matchRow = value; }
        }

        public AddResult()
        {
            InitializeComponent();
            this._listItem = new List<ComboBoxItem>();
            _tourID = 11;
        }
        public AddResult(LeagueManagement_DX.LeagueDatabaseDataSet.MatchRow matchRow)
        {
            InitializeComponent();
            this.MatchRow = matchRow;
            this._listItem = new List<ComboBoxItem>();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leagueDatabaseDataSet.GoalOfMatch' table. You can move, or remove it, as needed.
            this.matchTableAdapter.Fill(this.leagueDatabaseDataSet.Match);
            this.MatchRow = this.leagueDatabaseDataSet.Match.Last();
            this._tourID = Convert.ToInt32(this.MatchRow["TourId"]);
            this.goalOfMatchTableAdapter.Fill(this.leagueDatabaseDataSet.GoalOfMatch);
            this.teamTableAdapter.Fill(this.leagueDatabaseDataSet.Team);
            this.footballerTableAdapter.Fill(this.leagueDatabaseDataSet.Footballer);
            this._homeTeam = this.leagueDatabaseDataSet.Team.FindById(Convert.ToInt32(this.MatchRow["Home"]));
            this._awayTeam = this.leagueDatabaseDataSet.Team.FindById(Convert.ToInt32(this.MatchRow["Away"]));
            this._listItem.Add(new ComboBoxItem(this._homeTeam["Name"].ToString(), this._homeTeam["Id"]));
            this._listItem.Add(new ComboBoxItem(this._awayTeam["Name"].ToString(), this._awayTeam["Id"]));
            foreach(ComboBoxItem item in this._listItem)
            {
                this.comboBoxEditTeam.Properties.Items.Add(item);
            }
            this.registrationTableAdapter.FillByTeamId(this.leagueDatabaseDataSet.Registration, Convert.ToInt32(this._homeTeam["Id"]));
            foreach(DataRow row in this.leagueDatabaseDataSet.Registration.Rows)
            {
                LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["PLayerId"]));
                ComboBoxItem item = new ComboBoxItem(playerRow.Name, playerRow.Id);
                this.comboBoxEditHomePlayer.Properties.Items.Add(item);
            }
            this.registrationTableAdapter.FillByTeamId(this.leagueDatabaseDataSet.Registration, Convert.ToInt32(this._awayTeam["Id"]));
            foreach (DataRow row in this.leagueDatabaseDataSet.Registration.Rows)
            {
                LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["PLayerId"]));
                ComboBoxItem item = new ComboBoxItem(playerRow.Name, playerRow.Id);
                this.comboBoxEditAwayPlayer.Properties.Items.Add(item);
            }
            this.goalTypeNameTableAdapter.Fill(this.leagueDatabaseDataSet.GoalTypeName);
            foreach (DataRow row in this.leagueDatabaseDataSet.GoalTypeName.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row["GoalType"].ToString(), this._matchRow["TourId"]);
                this.comboBoxEditGoalType.Properties.Items.Add(item);
                ((DataGridViewComboBoxColumn)this.dataGridViewGoalOfMatch.Columns["TypeGoal"]).Items.Add(item);
            }
            this.comboBoxEditHomePlayer.Enabled = false;
            this.comboBoxEditAwayPlayer.Enabled = false;
            //this.comboBoxEditGoalType.Enabled = false;
            this.customTextBoxGoalTime.Enabled = false;
            //this.simpleButtonAdd.Enabled = false;
            //this.simpleButtonOK.Enabled = false;

            
        }


        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEditTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxEditTeam.SelectedIndex == 0)
            {
                this.comboBoxEditHomePlayer.Enabled = true;
                this.comboBoxEditAwayPlayer.Enabled = false;
            }
            if (this.comboBoxEditTeam.SelectedIndex == 1)
            {
                this.comboBoxEditHomePlayer.Enabled = false;
                this.comboBoxEditAwayPlayer.Enabled = true; ;
            }

        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            ComboBoxItem temp;
            var index =  this.dataGridViewGoalOfMatch.Rows.Add();
            this.dataGridViewGoalOfMatch.Rows[index].Cells["Team"].Value = this.comboBoxEditTeam.SelectedItem;
            this.dataGridViewGoalOfMatch.Rows[index].Cells["TypeGoal"].Value = (this.dataGridViewGoalOfMatch.Rows[index].Cells["TypeGoal"] as DataGridViewComboBoxCell).Items[this.comboBoxEditGoalType.SelectedIndex];
            this.dataGridViewGoalOfMatch.Rows[index].Cells["Time"].Value = this.customTextBoxGoalTime.Text;
            if (this.comboBoxEditHomePlayer.SelectedIndex != -1)
            {
                this.dataGridViewGoalOfMatch.Rows[index].Cells["Player"].Value = this.comboBoxEditHomePlayer.SelectedItem;
                temp = (ComboBoxItem)this.comboBoxEditHomePlayer.SelectedItem;
                this.dataGridViewGoalOfMatch.Rows[index].Cells["PlayerId"].Value = temp.Value;
            }
            if (this.comboBoxEditAwayPlayer.SelectedIndex != -1)
            {
                this.dataGridViewGoalOfMatch.Rows[index].Cells["Player"].Value = this.comboBoxEditAwayPlayer.SelectedItem;
                temp = (ComboBoxItem)this.comboBoxEditAwayPlayer.SelectedItem;
                this.dataGridViewGoalOfMatch.Rows[index].Cells["PlayerId"].Value = temp.Value;
            }
            temp = (ComboBoxItem)this.comboBoxEditTeam.SelectedItem;
            this.dataGridViewGoalOfMatch.Rows[index].Cells["TeamId"].Value = temp.Value;
            this.dataGridViewGoalOfMatch.Rows[index].Cells["MatchId"].Value = this.MatchRow["Id"];
            
            
        }

        private void comboBoxEditHomePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxEditHomePlayer.SelectedIndex == -1)
            {
                this.customTextBoxGoalTime.Enabled = false;
                this.comboBoxEditGoalType.Enabled = false;
            }
            else
            {
                this.customTextBoxGoalTime.Enabled = true;
                this.comboBoxEditGoalType.Enabled = true;
            }
        }
        //private bool isExist()
        //{
            
        //}
        private void comboBoxEditAwayPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxEditAwayPlayer.SelectedIndex == -1)
            {
                this.customTextBoxGoalTime.Enabled = false;
                this.comboBoxEditGoalType.Enabled = false;
            }
            else
            {
                this.customTextBoxGoalTime.Enabled = true;
                this.comboBoxEditGoalType.Enabled = true;
            }
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewGoalOfMatch.Rows)
            {
                DataRow _newRow = this.leagueDatabaseDataSet.GoalOfMatch.NewRow();
                _newRow.BeginEdit();
                _newRow["MatchId"] = row.Cells["MatchId"].Value;
                _newRow["TeamId"] = row.Cells["TeamId"].Value;
                _newRow["PlayerId"] = row.Cells["PlayerId"].Value;
                _newRow["Time"] = row.Cells["Time"].Value;
                _newRow["TypeGoal"] = row.Cells["TypeGoal"].Value;
                _newRow.EndEdit();
                this.leagueDatabaseDataSet.GoalOfMatch.Rows.Add(_newRow);
                this.goalOfMatchTableAdapter.Update(this.leagueDatabaseDataSet);
                this.leagueDatabaseDataSet.AcceptChanges();

            }

        }

    }
}