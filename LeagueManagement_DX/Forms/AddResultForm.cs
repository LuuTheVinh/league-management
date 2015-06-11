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
using WindowsFormsControlLibrary;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

namespace LeagueManagement_DX.Forms
{
    public partial class AddResultForm : DevExpress.XtraEditors.XtraForm
    {
        public class CustomItem
        {

            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
            public CustomItem(string text, object value)
            {
                this.Text = text;
                this.Value = value;
            }
            public CustomItem()
            {
 
            }
        }
        LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow _tourRow;
        DataRow _matchRow;
        private LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow _homeTeam;
        private LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow _awayTeam;
       // private List<int> _deleteGoalList;
        private int _matchID;
        private bool _formstate;
        private bool isEdit;
        public LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow TourRow
        {
            get { return _tourRow; }
            set { _tourRow = value; }
        }
        public AddResultForm()
        {
            InitializeComponent();
           // this._deleteGoalList = new List<int>();



            
        }
        public AddResultForm(LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow tourRow)
        {
            InitializeComponent();
            this.TourRow = tourRow;
            this.matchList.TourID = this.TourRow.Id;
           // this._deleteGoalList = new List<int>();
            this.Text = this.TourRow["TourName"].ToString();
            _formstate = false;
            isEdit = false;
            
        }
        public AddResultForm(LeagueManagement_DX.LeagueDatabaseDataSet.MatchRow matchRow)
        {
            InitializeComponent();
            this._matchRow = matchRow;
           // this.TourRow.Id = Convert.ToInt32(this._matchRow["TourId"]);
         //   this._deleteGoalList = new List<int>();
            this.matchList.TourID = Convert.ToInt32(this._matchRow["TourId"]);
            this.toursTableAdapter.Fill(this.leagueDatabaseDataSet.Tours);
            this.TourRow = this.leagueDatabaseDataSet.Tours.FindById(Convert.ToInt32(this._matchRow["TourId"]));
            this.Text = this.TourRow["TourName"].ToString();
            _formstate = false;
            isEdit = true;
        }
        private void ReloadMatchList()
        {
            this.matchList.LoadDataFromTable();
            foreach (ControlListItem Item in this.matchList.flowLayoutPanel.Controls)
            {
                if (Convert.ToInt32((Item as MatchControlListItem).DataRowItem["Id"]) != Convert.ToInt32(this._matchRow["Id"]))
                {
                    (Item as MatchControlListItem).Enabled = false;

                }
                else
                {
                    (Item as MatchControlListItem).Select();
                    (Item as MatchControlListItem).Selected = true;
                    (Item as MatchControlListItem).BackColor = Color.SkyBlue;
                    (Item as MatchControlListItem).SelectColor = Color.SkyBlue;
                    //this.item_Click((Item as MatchControlListItem), e);
                    matchList.ReloadItem(int.Parse(_matchRow["Id"].ToString()));
                }
            }
        }
        private void AddResultForm_Load(object sender, EventArgs e)
        {
           
            this.matchList.LoadDataFromTable();
            if (this._matchRow != null)
            {
                foreach (ControlListItem Item in this.matchList.flowLayoutPanel.Controls)
                {
                    if(Convert.ToInt32((Item as MatchControlListItem).DataRowItem["Id"]) != Convert.ToInt32(this._matchRow["Id"]))
                    {
                        (Item as MatchControlListItem).Enabled = false;
                        
                    }
                    else
                    {
                        (Item as MatchControlListItem).Select();
                        (Item as MatchControlListItem).Selected = true;
                        (Item as MatchControlListItem).BackColor = Color.SkyBlue;
                        (Item as MatchControlListItem).SelectColor = Color.SkyBlue;
                        this.item_Click((Item as MatchControlListItem), e);
                        
                    }
                }
            }
            this.footballerTableAdapter.Fill(this.leagueDatabaseDataSet.Footballer);
            this.goalTypeNameTableAdapter.FillByTourId(this.leagueDatabaseDataSet.GoalTypeName,this.TourRow.Id);
            foreach (ControlListItem item in this.matchList.flowLayoutPanel.Controls)
            {
                item.Click +=item_Click;
                (item as MatchControlListItem).RemoveDoubleClick();
            }
            //foreach (ControlListItem item in this.matchList.flowLayoutPanel.Controls)
            //{
            //    var temp = (MatchControlListItem)item;
            //    if ((temp.DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.MatchRow).Id == Convert.ToInt32(this._matchRow["Id"]))
            //    {
            //        item.Selected = true;
            //    }
            //}
            //this.listBoxControlAwayPlayerList.Enabled = false;
           // this.listBoxControlHomePlayerList.Enabled = false;
            if (this._matchRow == null)
            {
                this.simpleButtonSubmit.Enabled = false;
                this.simpleButtonOK.Enabled = false;
                this.simpleButtonAdd.Enabled = false;
                this.customTextBoxTime.Enabled = false;
            }
        }

        private void LoadData()
        {
          
            this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList,Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]));
            this.footballerTableAdapter.Fill(this.leagueDatabaseDataSet.Footballer);
            foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
            {
                LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["Player"]));
                CustomItem _item = new CustomItem(playerRow.Name, playerRow.Id);
                this.chklbHomePlayerList.Items.Add(_item, true);
                this.listBoxControlHomePlayerList.Items.Add(_item);
            }
            //this.registrationTableAdapter.FillByTeamId(this.leagueDatabaseDataSet.Registration, Convert.ToInt32(this._homeTeam["Id"]));
            this.registrationTableAdapter.FillByTeamIdTourId(this.leagueDatabaseDataSet.Registration,Convert.ToInt32(this._homeTeam["Id"]),this.TourRow.Id);
            foreach (DataRow row in this.leagueDatabaseDataSet.Registration.Rows)
            {
                LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["PLayerId"]));
                CustomItem _item = new CustomItem(playerRow.Name, playerRow.Id);
                bool isExist = false;
                for (int i = 0; i < this.chklbHomePlayerList.Items.Count; i++)
                {
                    var item = this.chklbHomePlayerList.Items[i].Value;
                    CustomItem temp = new CustomItem(((CustomItem)item).Text, ((CustomItem)item).Value);
                    if(object.Equals(temp.Value,_item.Value))
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist == false)
                {
                    this.chklbHomePlayerList.Items.Add(_item, false);
                }
            }

            this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]));
            foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
            {
                LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["Player"]));
                CustomItem _item = new CustomItem(playerRow.Name, playerRow.Id);
                this.chklbAwayPlayerList.Items.Add(_item, true);
                this.listBoxControlAwayPlayerList.Items.Add(_item);
            }
            //this.registrationTableAdapter.FillByTeamId(this.leagueDatabaseDataSet.Registration, Convert.ToInt32(this._awayTeam["Id"]));
            this.registrationTableAdapter.FillByTeamIdTourId(this.leagueDatabaseDataSet.Registration, Convert.ToInt32(this._awayTeam["Id"]), this.TourRow.Id);
            foreach (DataRow row in this.leagueDatabaseDataSet.Registration.Rows)
            {
                LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["PLayerId"]));
                CustomItem _item = new CustomItem(playerRow.Name, playerRow.Id);
                bool isExist = false;
                for (int i = 0; i < this.chklbAwayPlayerList.Items.Count; i++)
                {
                    var item = this.chklbAwayPlayerList.Items[i].Value;
                    CustomItem temp = new CustomItem(((CustomItem)item).Text, ((CustomItem)item).Value);
                    if (Convert.ToInt32(temp.Value) == Convert.ToInt32(_item.Value))
                    {
                        isExist = true;
                        break;
                    }
                }
                if (isExist == false)
                {
                    this.chklbAwayPlayerList.Items.Add(_item, false);
                }
            }

        }
        private void LoadDataToGridView()
        {
            this.goalOfMatchTableAdapter.FillByMatchId(this.leagueDatabaseDataSet.GoalOfMatch, Convert.ToInt32(this._matchRow["Id"]));
            foreach (DataRow row in this.leagueDatabaseDataSet.GoalOfMatch.Rows)
            {
                LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["PlayerId"]));
                LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow teamRow = this.leagueDatabaseDataSet.Team.FindById(Convert.ToInt32(row["TeamId"]));
                var index = this.dataGridViewGoalInformation.Rows.Add();
                this.dataGridViewGoalInformation.Rows[index].Cells["GoalId"].Value = row["GoalId"];
                this.dataGridViewGoalInformation.Rows[index].Cells["MatchId"].Value = row["MatchId"];
                this.dataGridViewGoalInformation.Rows[index].Cells["TeamId"].Value = row["TeamId"];
                this.dataGridViewGoalInformation.Rows[index].Cells["PlayerId"].Value = row["PlayerId"];
                this.dataGridViewGoalInformation.Rows[index].Cells["TypeGoal"].Value = row["TypeGoal"];
                this.dataGridViewGoalInformation.Rows[index].Cells["Time"].Value = row["Time"];
                this.dataGridViewGoalInformation.Rows[index].Cells["Player"].Value = playerRow.Name;
                this.dataGridViewGoalInformation.Rows[index].Cells["Team"].Value = teamRow.Name;
            }
        }
        private void item_Click(object sender, EventArgs e)
        {
            this.chklbAwayPlayerList.Items.Clear();
            this.chklbAwayPlayerList.Refresh();
            this.chklbHomePlayerList.Items.Clear();
            this.chklbHomePlayerList.Refresh();
            this.comboBoxEditTeam.Properties.Items.Clear();
            this.comboBoxEditTeam.Refresh();
            this.comboBoxEditTypeGoal.Properties.Items.Clear();
            this.comboBoxEditTypeGoal.Refresh();
            this.comboBoxEditPlayer.Properties.Items.Clear();
            this.comboBoxEditPlayer.Refresh();
            this.listBoxControlAwayPlayerList.Items.Clear();
            this.listBoxControlAwayPlayerList.Refresh();
            this.listBoxControlHomePlayerList.Items.Clear();
            this.listBoxControlHomePlayerList.Refresh();
            this.dataGridViewGoalInformation.Rows.Clear();
            this.dataGridViewGoalInformation.Refresh();
            var item = (MatchControlListItem)sender;
            
            this._matchRow = item.DataRowItem;
            this.simpleButtonSubmit.Enabled = true;
            this.simpleButtonOK.Enabled = true;
            this.simpleButtonAdd.Enabled = true;
            this.customTextBoxTime.Enabled = true;
            this._matchID = Convert.ToInt32(this._matchRow["Id"]);
            this.teamTableAdapter.Fill(this.leagueDatabaseDataSet.Team);
            this._homeTeam = this.leagueDatabaseDataSet.Team.FindById(Convert.ToInt32(this._matchRow["Home"]));
            this._awayTeam = this.leagueDatabaseDataSet.Team.FindById(Convert.ToInt32(this._matchRow["Away"]));
            List<CustomItem> _listItem = new List<CustomItem>();
            _listItem.Add(new CustomItem(this._homeTeam["Name"].ToString(), this._homeTeam["Id"]));
            _listItem.Add(new CustomItem(this._awayTeam["Name"].ToString(), this._awayTeam["Id"]));
            foreach (CustomItem i in _listItem)
            {
                this.comboBoxEditTeam.Properties.Items.Add(i);
            }

            this.LoadData();

            this.labelControlHome.Text = this._homeTeam["Name"].ToString();
            this.labelControlHomeTeam.Text = this._homeTeam["Name"].ToString();
            this.labelControlAway.Text = this._awayTeam["Name"].ToString();
            this.labelControlAwayTeam.Text = this._awayTeam["Name"].ToString();
            this.goalTypeNameTableAdapter.FillByTourId(this.leagueDatabaseDataSet.GoalTypeName,this.TourRow.Id);
            foreach (DataRow row in this.leagueDatabaseDataSet.GoalTypeName)
            {
                CustomItem _item = new CustomItem(row["GoalType"].ToString(), Convert.ToInt32(row["ToursID"]));
                this.comboBoxEditTypeGoal.Properties.Items.Add(_item);
            }
            this.LoadDataToGridView();
        }

        private void dataGridViewGoalInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            //this._formstate = true;
            this.Close();
        }


        private void chklbAwayPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxEditTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxEditTeam.SelectedIndex == 0)
            {
                this.comboBoxEditPlayer.Properties.Items.Clear();
                this.comboBoxEditPlayer.Refresh();
                
                this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]));
                foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
                {
                    LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["Player"]));
                    CustomItem item = new CustomItem(playerRow["Name"].ToString(), Convert.ToInt32(playerRow["Id"]));
                    this.comboBoxEditPlayer.Properties.Items.Add(item);

                }
                this.comboBoxEditPlayer.SelectedIndex = -1;
            }
            if (this.comboBoxEditTeam.SelectedIndex == 1)
            {

                this.comboBoxEditPlayer.Properties.Items.Clear();
                this.comboBoxEditPlayer.Refresh();
                this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]));
                foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
                {
                    LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["Player"]));
                    CustomItem item = new CustomItem(playerRow["Name"].ToString(), Convert.ToInt32(playerRow["Id"]));
                    this.comboBoxEditPlayer.Properties.Items.Add(item);

                }
                this.comboBoxEditPlayer.SelectedIndex = -1;
            }
        }

        private void chklbHomePlayerList_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
            {
                var item = this.chklbHomePlayerList.Items[e.Index].Value;
                CustomItem newItem = new CustomItem(((CustomItem)item).Text, ((CustomItem)item).Value);
                
                this.listBoxControlHomePlayerList.Items.Add(newItem);

            }
            if (e.State == CheckState.Unchecked)
            {
                object item = this.chklbHomePlayerList.Items[e.Index].Value;
                foreach (object i in this.listBoxControlHomePlayerList.Items)
                {
                    if (((CustomItem)i).Value == ((CustomItem)item).Value)
                    {
                        
                        this.listBoxControlHomePlayerList.Items.Remove(i);
                        this.listBoxControlHomePlayerList.Refresh();
                        break;
                    }

                }
            }
        }

        private void chklbAwayPlayerList_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
            {
                var item = this.chklbAwayPlayerList.Items[e.Index].Value;
                CustomItem newItem = new CustomItem(((CustomItem)item).Text, ((CustomItem)item).Value);
                this.listBoxControlAwayPlayerList.Items.Add(newItem);
                

            }
            if (e.State == CheckState.Unchecked)
            {
                object item = this.chklbAwayPlayerList.Items[e.Index].Value;
                foreach (object i in this.listBoxControlAwayPlayerList.Items)
                {
                    if (((CustomItem)i).Value == ((CustomItem)item).Value)
                    {
                       
                        this.listBoxControlAwayPlayerList.Items.Remove(i);
                        this.listBoxControlAwayPlayerList.Refresh();
                        break;
                    }

                }
            }
        }
        private bool CheckException()
        {
            try
            {
                this.playerListTableAdapter.Update(this.leagueDatabaseDataSet);
                this.leagueDatabaseDataSet.AcceptChanges();
                this.playerListTableAdapter.Fill(this.leagueDatabaseDataSet.PlayerList);
                return true;
            }
            catch(SqlException ex)
            {
                this.leagueDatabaseDataSet.RejectChanges();
                foreach (var error in ex.Errors)
                {
                    switch ((error as SqlError).Number)
                    {
                        case 50000:
                            {
                                if ((error as SqlError).Message.Contains("Player of a match can not than 11"))
                                {
                                    MessageBox.Show("Player of team in match can not more than 11 persons", "Error", MessageBoxButtons.OK);
                                    break;
                                }

                            }
                            break;

                    }
                }
                return false;
            }
        }
        private void ReloadPlayerList()
        {
            this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]));
            foreach(var item in this.chklbHomePlayerList.Items)
            {
                if (((CheckedListBoxItem)item).CheckState == CheckState.Unchecked)
                    continue;
                if (this.leagueDatabaseDataSet.PlayerList.
                    Any(player => player.Player == Convert.ToInt32(((CustomItem)(((ListBoxItem)(item)).Value)).Value)))
                {
                    continue;
                }
                int index = this.chklbHomePlayerList.Items.IndexOf(item);
                foreach (object i in this.listBoxControlHomePlayerList.Items)
                {
                    if (((CustomItem)i).Value == ((CustomItem)(((ListBoxItem)(item)).Value)).Value)
                    {

                        this.listBoxControlHomePlayerList.Items.Remove(i);
                        this.listBoxControlHomePlayerList.Refresh();
                        break;
                    }

                }
                this.chklbHomePlayerList.SetItemChecked(index, false);
            }
            this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]));
            foreach (var item in this.chklbAwayPlayerList.Items)
            {
                if (((CheckedListBoxItem)item).CheckState == CheckState.Unchecked)
                    continue;
                if (this.leagueDatabaseDataSet.PlayerList.
                    Any(player => player.Player == Convert.ToInt32(((CustomItem)(((ListBoxItem)(item)).Value)).Value)))
                {
                    continue;
                }
                int index = this.chklbAwayPlayerList.Items.IndexOf(item);

                foreach (object i in this.listBoxControlAwayPlayerList.Items)
                {
                    if (((CustomItem)i).Value == ((CustomItem)(((ListBoxItem)(item)).Value)).Value)
                    {

                        this.listBoxControlAwayPlayerList.Items.Remove(i);
                        this.listBoxControlAwayPlayerList.Refresh();
                        break;
                    }

                }

                this.chklbAwayPlayerList.SetItemChecked(index, false);
            }

        }
        private void simpleButtonSubmit_Click(object sender, EventArgs e)
        {
            bool ishomeAdded=false;
            bool isawayAdded=false;
            this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]));
            for (int i = 0; i < this.listBoxControlHomePlayerList.Items.Count ; i++)
            {
                
                var item = this.listBoxControlHomePlayerList.Items[i];
                DataRow _newRow = this.leagueDatabaseDataSet.PlayerList.NewRow();
                _newRow.BeginEdit();
                _newRow["MatchID"] = this._matchRow["Id"];
                _newRow["TeamId"] = this._homeTeam["Id"];
                _newRow["Player"] = ((CustomItem)item).Value;
                _newRow.EndEdit();
                
                if (this.leagueDatabaseDataSet.PlayerList.FindByMatchIDTeamIdPlayer(Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]), Convert.ToInt32(_newRow["Player"])) == null)
                {
                    this.leagueDatabaseDataSet.PlayerList.Rows.Add(_newRow);

                    
                }

            }
            ishomeAdded = this.CheckException();
            this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]));
            for (int i = 0; i < this.listBoxControlAwayPlayerList.Items.Count ; i++)
            {
                var item = this.listBoxControlAwayPlayerList.Items[i];
                DataRow _newRow = this.leagueDatabaseDataSet.PlayerList.NewRow();
                _newRow.BeginEdit();
                _newRow["MatchID"] = this._matchRow["Id"];
                _newRow["TeamId"] = this._awayTeam["Id"];
                _newRow["Player"] = ((CustomItem)item).Value;
                _newRow.EndEdit();
                if (this.leagueDatabaseDataSet.PlayerList.FindByMatchIDTeamIdPlayer(Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]), Convert.ToInt32(_newRow["Player"])) == null)
                {
                    this.leagueDatabaseDataSet.PlayerList.Rows.Add(_newRow);

                    
                }

            }
            isawayAdded = this.CheckException();
            if (ishomeAdded == true && isawayAdded == true)
            {
                List<DataRow> deleteList = new List<DataRow>();
                this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]));
                foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
                {
                    bool isExist = false;
                    for (int i = 0; i < this.listBoxControlHomePlayerList.ItemCount; i++)
                    {
                        var item = this.listBoxControlHomePlayerList.Items[i];
                        DataRow temp =
                        this.leagueDatabaseDataSet.PlayerList.FindByMatchIDTeamIdPlayer(Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]), Convert.ToInt32(((CustomItem)item).Value));

                        if (row == temp)
                        {
                            isExist = true;
                        }
                    }
                    if (isExist == false)
                    {
                        deleteList.Add(row);
                    }
                }
                foreach (DataRow item in deleteList)
                {
                    DataRow deleteRow = this.leagueDatabaseDataSet.PlayerList.FindByMatchIDTeamIdPlayer(Convert.ToInt32(item["MatchID"]), Convert.ToInt32(item["TeamId"]), Convert.ToInt32(item["Player"]));
                    deleteRow.Delete();
                    this.playerListTableAdapter.Update(this.leagueDatabaseDataSet);
                    this.leagueDatabaseDataSet.AcceptChanges();
                }
                deleteList.Clear();
                this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]));
                foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
                {
                    bool isExist = false;
                    for (int i = 0; i < this.listBoxControlAwayPlayerList.ItemCount; i++)
                    {
                        var item = this.listBoxControlAwayPlayerList.Items[i];
                        DataRow temp =
                        this.leagueDatabaseDataSet.PlayerList.FindByMatchIDTeamIdPlayer(Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]), Convert.ToInt32(((CustomItem)item).Value));

                        if (row == temp)
                        {
                            isExist = true;
                        }
                    }
                    if (isExist == false)
                    {
                        deleteList.Add(row);
                    }
                }

                foreach (DataRow item in deleteList)
                {
                    DataRow deleteRow = this.leagueDatabaseDataSet.PlayerList.FindByMatchIDTeamIdPlayer(Convert.ToInt32(item["MatchID"]), Convert.ToInt32(item["TeamId"]), Convert.ToInt32(item["Player"]));
                    deleteRow.Delete();
                    this.playerListTableAdapter.Update(this.leagueDatabaseDataSet);
                    this.leagueDatabaseDataSet.AcceptChanges();
                }

                if (this.comboBoxEditTeam.SelectedIndex == 0)
                {
                    this.comboBoxEditPlayer.Properties.Items.Clear();
                    this.comboBoxEditPlayer.Refresh();
                    this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._homeTeam["Id"]));
                    foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
                    {
                        LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["Player"]));
                        CustomItem item = new CustomItem(playerRow["Name"].ToString(), Convert.ToInt32(playerRow["Id"]));
                        this.comboBoxEditPlayer.Properties.Items.Add(item);

                    }

                }
                if (this.comboBoxEditTeam.SelectedIndex == 1)
                {
                    this.comboBoxEditPlayer.Properties.Items.Clear();
                    this.comboBoxEditPlayer.Refresh();
                    this.playerListTableAdapter.FillByMatchIdTeamId(this.leagueDatabaseDataSet.PlayerList, Convert.ToInt32(this._matchRow["Id"]), Convert.ToInt32(this._awayTeam["Id"]));
                    foreach (DataRow row in this.leagueDatabaseDataSet.PlayerList.Rows)
                    {
                        LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow playerRow = this.leagueDatabaseDataSet.Footballer.FindById(Convert.ToInt32(row["Player"]));
                        CustomItem item = new CustomItem(playerRow["Name"].ToString(), Convert.ToInt32(playerRow["Id"]));
                        this.comboBoxEditPlayer.Properties.Items.Add(item);

                    }
                }
                this.dataGridViewGoalInformation.Rows.Clear();
                this.dataGridViewGoalInformation.Refresh();
                this.LoadDataToGridView();
                this.richTextBoxMessage.Text += "Player list has been Modified sucessfully\n";
                this.richTextBoxMessage.SelectionStart = this.richTextBoxMessage.Text.Length;
                this.richTextBoxMessage.ScrollToCaret();
            }
            else
            {
                this.ReloadPlayerList();
                return;
            }
        }
        
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            
            CustomItem temp;
            var index = this.dataGridViewGoalInformation.Rows.Add();
            this.dataGridViewGoalInformation.Rows[index].Cells["Team"].Value = this.comboBoxEditTeam.SelectedItem;
            this.dataGridViewGoalInformation.Rows[index].Cells["Player"].Value = this.comboBoxEditPlayer.SelectedItem;
            this.dataGridViewGoalInformation.Rows[index].Cells["TypeGoal"].Value = this.comboBoxEditTypeGoal.SelectedItem;
            this.dataGridViewGoalInformation.Rows[index].Cells["Time"].Value = Convert.ToInt32(this.customTextBoxTime.Text);
            temp = (CustomItem)this.comboBoxEditTeam.SelectedItem;
            this.dataGridViewGoalInformation.Rows[index].Cells["TeamId"].Value = temp.Value;
            temp = (CustomItem)this.comboBoxEditPlayer.SelectedItem;
            this.dataGridViewGoalInformation.Rows[index].Cells["PlayerId"].Value = temp.Value;
            this.dataGridViewGoalInformation.Rows[index].Cells["MatchId"].Value = this._matchRow["Id"];
            this.richTextBoxMessage.Text += "Goal has been added sucessfully\n";
            this.richTextBoxMessage.SelectionStart = this.richTextBoxMessage.Text.Length;
            this.richTextBoxMessage.ScrollToCaret();
            
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            this.goalOfMatchTableAdapter.FillByMatchId(this.leagueDatabaseDataSet.GoalOfMatch,Convert.ToInt32(this._matchRow["Id"]));
            this.goalOfMatchTableAdapter.DeleteByMatchId(Convert.ToInt32(this._matchRow["Id"]));
            this.leagueDatabaseDataSet.AcceptChanges();
            this.goalOfMatchTableAdapter.FillByMatchId(this.leagueDatabaseDataSet.GoalOfMatch, Convert.ToInt32(this._matchRow["Id"]));
            foreach (DataGridViewRow row in this.dataGridViewGoalInformation.Rows)
            {
                DataRow _newRow = this.leagueDatabaseDataSet.GoalOfMatch.NewRow();
                _newRow["MatchId"] = row.Cells["MatchId"].Value;
                _newRow["TeamId"] = row.Cells["TeamId"].Value;
                _newRow["PlayerId"] = row.Cells["PlayerId"].Value;
                _newRow["TypeGoal"] = row.Cells["TypeGoal"].Value;
                _newRow["Time"] = row.Cells["Time"].Value;
                this.leagueDatabaseDataSet.GoalOfMatch.Rows.Add(_newRow);

            }
            this.goalOfMatchTableAdapter.Update(this.leagueDatabaseDataSet.GoalOfMatch);
            this.leagueDatabaseDataSet.AcceptChanges();
            //Thang edit

            //if (this._deleteGoalList.Count != 0)
            //{
            //    this.goalOfMatchTableAdapter.Fill(this.leagueDatabaseDataSet.GoalOfMatch);
            //    foreach (int item in this._deleteGoalList)
            //    {
            //        DataRow deleteRow = this.leagueDatabaseDataSet.GoalOfMatch.FindByGoalId(item);
            //        deleteRow.Delete();
            //    }
            //    this.goalOfMatchTableAdapter.Update(this.leagueDatabaseDataSet.GoalOfMatch);
            //    this.leagueDatabaseDataSet.AcceptChanges();
            //    this._deleteGoalList.Clear();

            //}

            this.matchTableAdapter.Fill(this.leagueDatabaseDataSet.Match);
            DataRow _editRow = this.leagueDatabaseDataSet.Match.FindById(this._matchID);
            _editRow.BeginEdit();
            _editRow["RealDate"] = this.dateTimePickerRealDay.Value;
            _editRow.EndEdit();
            this.matchTableAdapter.Update(this.leagueDatabaseDataSet.Match);
            this.leagueDatabaseDataSet.AcceptChanges();
            this.matchTableAdapter.Fill(this.leagueDatabaseDataSet.Match);
            this._matchRow = this.leagueDatabaseDataSet.Match.FindById(this._matchID);
            if(isEdit == false)
            {
                this.matchList.LoadDataFromTable();
                foreach (ControlListItem item in this.matchList.flowLayoutPanel.Controls)
                {
                    item.Click += item_Click;
                }
            }
            else
            {
                this.ReloadMatchList();
            }
            this.richTextBoxMessage.Text += "The result has been Added/Modified sucessfully\n";
            this.richTextBoxMessage.SelectionStart = this.richTextBoxMessage.Text.Length;
            this.richTextBoxMessage.ScrollToCaret();
            this._formstate = true;
            
        }
        private bool isValid()
        {
            if (this.comboBoxEditPlayer.SelectedIndex == -1)
                return false;
            if (this.comboBoxEditTeam.SelectedIndex == -1)
                return false;
            if (this.comboBoxEditTypeGoal.SelectedIndex == -1)
                return false;
            return true;
        }
        private void customTextBoxTime_Paint(object sender, PaintEventArgs e)
        {
            this.simpleButtonAdd.Enabled = true;
            foreach (var control in this.groupControlAddGoal.Controls)
            {
                if (control is CustomTextBox)
                {
                    if ((control as CustomTextBox).CheckCodition() == false || this.isValid() == false)
                    {
                        this.simpleButtonAdd.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void groupControlAddGoal_Paint(object sender, PaintEventArgs e)
        {
            //this.simpleButtonAdd.Enabled = true;
            //foreach (var control in this.groupControlAddGoal.Controls)
            //{
            //    if (control is CustomTextBox)
            //    {
            //        if ((control as CustomTextBox).CheckCodition() == false || this.isValid() == false)
            //        {
            //            this.simpleButtonAdd.Enabled = false;
            //            return;
            //        }
            //    }
            //}
        }

        private void simpleButtonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in this.dataGridViewGoalInformation.SelectedCells)
            {
                if (cell.Selected)
                {
                    DataGridViewRow selectedRow = this.dataGridViewGoalInformation.Rows[cell.RowIndex];
                    if (selectedRow != null)
                    {
                        if (selectedRow.Cells["GoalId"].Value == null || Convert.ToInt32(selectedRow.Cells["GoalId"].Value) == null)
                        {
                            this.dataGridViewGoalInformation.Rows.Remove(selectedRow);
                            this.dataGridViewGoalInformation.Refresh();
                        }
                        else
                        {
                            int _goalId = Convert.ToInt32(selectedRow.Cells["GoalId"].Value);
                            //DataRow _deleteRow = this.leagueDatabaseDataSet.GoalOfMatch.FindByGoalId(_goalId);
                            //this._deleteGoalList.Add(_goalId);
                            this.dataGridViewGoalInformation.Rows.Remove(selectedRow);
                            this.dataGridViewGoalInformation.Refresh();
                        }
                    }
                }
            }
        }

        private void AddResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._formstate == true)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                FormCollection formCollec = Application.OpenForms; //["TourManagement"];
                foreach (Form frm in formCollec)
                {
                    if (frm.Name == "TourManagement")
                    {
                        (frm as TourManagement).ReloadMatchList(int.Parse(_matchRow["Id"].ToString()));
                    }


                    if (frm.Name == "ShowTeam")
                    {
                        (frm as ShowTeam).LoadMatchList();
                    }
                }
            }
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
