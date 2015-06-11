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
using System.Globalization;
using System.IO;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using WindowsFormsControlLibrary;

namespace LeagueManagement_DX.Forms
{
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow tourRow;
        int[] a_shirtnumber;
        string[] a_position;
        int selectedteam;
        public RegisterForm(DataRow dataRow)
        {
            InitializeComponent();
            tourRow = dataRow as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow;
            selectedteam = -1;
        }

        bool has_change;

        public bool Has_Change
        {
            get { return has_change; }
            set { has_change = value; }
        }
        public void ShowDialog(int teamid)
        {
            selectedteam = teamid;
            this.ShowDialog();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'leagueDatabaseDataSet.CardOfMatch' table. You can move, or remove it, as needed.
            customTextBox_Stadium.StringPattern =
                "^[" + LeagueManagement_DX.Properties.Resources.VNCharacters + "a-zA-Z'\\- ]{1,30}$";
            // TODO: This line of code loads data into the 'leagueDatabaseDataSet.Footballer' table. You can move, or remove it, as needed.
            //this.footballerTableAdapter.Fill(this.leagueDatabaseDataSet.Footballer);
          //  this.radioButton_New.Checked = false;
            Has_Change = false;
            this.customTextBox_ShirtValue.Enabled = false;
            this.comboBoxEdit_postion.Enabled = false;
          //  this.simpleButtonBrowse.Enabled = false;
            // TODO: This line of code loads data into the 'leagueDatabaseDataSet.Team' table. You can move, or remove it, as needed.

            this.teamDetailTableAdapter.Fill(this.leagueDatabaseDataSet.TeamDetail);

            //this.teamTableAdapter.FillByTour(this.leagueDatabaseDataSet.Team, tourRow.Id);
            this.teamJoinTourTableAdapter.Fill(leagueDatabaseDataSet.TeamJoinTour);
            this.teamTableAdapter.Fill(this.leagueDatabaseDataSet.Team);
           
            if (selectedteam != -1)
            {
                var teamrow = leagueDatabaseDataSet.Team.FindById(selectedteam) as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow;
                if (teamrow == null)
                    throw new Exception("Check selectedteam");

                string teamname = teamrow.Name;
                int selectedindex = this.listBoxControl_Team.FindString(teamname);
                if (selectedindex < 0)
                    throw new Exception("Check selectedteam");

                this.listBoxControl_Team.SetSelected(selectedindex, true);
                //this.listBoxControl_Team.SelectionMode = SelectionMode.None;
                this.listBoxControl_Team.Enabled = false;
                this.listBoxControl_Team.ForeColor = Color.FromArgb(30,30,30);
               // (this.listBoxControl_Team.SelectedItem 
                
            }
        }

        
        private void radioButton_Exists_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                this.customTextBox_Name.Enabled = false;
                this.listBoxControl_Team.Enabled = true;
                this.customTextBox_ShirtValue.Enabled = false;
                this.comboBoxEdit_postion.Enabled = false;
                //this.simpleButtonBrowse.Enabled = false;
            }
            
        }

        private void radioButton_New_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                //this.simpleButtonBrowse.Enabled = true;
                this.customTextBox_ShirtValue.Enabled = true;
                this.comboBoxEdit_postion.Enabled = true;
                this.checkedListBoxControl_Player.Enabled = true;
                this.customTextBox_Name.Enabled = true;
                this.listBoxControl_Team.Enabled = false;
                this.customTextBox_Name.ResetText();
                this.customTextBox_Stadium.ResetText();
                this.customTextBox_ShirtValue.ResetText();
                this.comboBoxEdit_postion.ResetText();
                this.a_shirtnumber = null;
                this.a_position = null;
                this.footballerTableAdapter.FillByPlayerFree(this.leagueDatabaseDataSet.Footballer);
                this.listBoxControl_Team.SelectedIndex = -1;
                this.teamBindingSource.CancelEdit();
            }
            this.labelControlNumber.Text = 0.ToString();
        }

        private void listBoxControl_Team_EnabledChanged(object sender, EventArgs e)
        {
            if ((sender as ListBoxControl).Enabled == true)
            {
                (sender as ListBoxControl).SelectedIndex = 0;
                this.listBoxControl_Team_SelectedIndexChanged(null, EventArgs.Empty);
            }
        }

        private void listBoxControl_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.radioButton_New.Checked == true)
            //    return;     
            this.checkedListBoxControl_Player.Enabled = true;
            if (teamBindingSource.Position == -1)
                return;
            LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow teamrow
                = (this.teamBindingSource.CurrencyManager.Current as DataRowView).Row as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow;
            int teamId = teamrow.Id;
            LeagueManagement_DX.LeagueDatabaseDataSet.Official_StadiumRow officialsta_row
                = this.official_StadiumTableAdapter.GetData().FindByTeamIdTourId(teamId, tourRow.Id);

            this.customTextBox_Name.Text = teamrow.Name;
            this.customTextBox_Stadium.Text = 
                (officialsta_row == null)?teamrow.Stadium:officialsta_row.StadiumName;

            this.footballerTableAdapter.FillByTeamId(this.leagueDatabaseDataSet.Footballer, teamId);

            /* - check vào các footballer đã có regis */
            this.fillRegistedFootballer(teamId);
            string avt = teamrow.Avatar;
            this.pictureEditTeamLogo.Image = this.updateimage(avt);

            LeagueManagement_DX.LeagueDatabaseDataSet.TeamJoinTourRow row 
                = this.leagueDatabaseDataSet.TeamJoinTour.FindByTourIdTeamId(tourRow.Id, teamId);
            if (row == null)
            {
                this.pictureBox_r.Image = global::LeagueManagement_DX.Properties.Resources.Red;
                this.toolTip1.SetToolTip(this.pictureBox_r, "Đội chưa được đăng kí trong giải");
            }
            else
            {
                this.pictureBox_r.Image = global::LeagueManagement_DX.Properties.Resources.green;
                this.toolTip1.SetToolTip(this.pictureBox_r, "Đội đã được đăng kí trong giải");
            }
        }

        private void customTextBox_Paint(object sender, PaintEventArgs e)
        {
            //kiểm tra điều kiện để enable ok button
            this.Button_Save.Enabled = true;
            if (this.customTextBox_Name.CheckCodition() == false)
            {
                this.Button_Save.Enabled = false;
                return;
            }
            if (this.customTextBox_Stadium.CheckCodition() == false)
            {
                this.Button_Save.Enabled = false;
                return;
            }
        }

        private void simpleButtonBrowse_Click(object sender, EventArgs e)
        {
            this.pictureEditTeamLogo.LoadImage();
        }

        private void label_BirthValue_TextChanged(object sender, EventArgs e)
        {
            //tính tuổi
            int currentYear = this.tourRow.BeginDate.Year;
            if (this.footballerBindingSource.CurrencyManager.Position == -1)
            {
                this.label_AgeValue.Text = 0.ToString();
            }
            else
            {
                int playerYear = ((DateTime)(this.footballerBindingSource.CurrencyManager.Current as DataRowView).Row["Birth"]).Year;
                this.label_AgeValue.Text = (currentYear - playerYear).ToString();
            }
        }

        private void label_NationValue_TextChanged(object sender, EventArgs e)
        {
            //kiểm tra ngoại binh - nội binh
            string str = (sender as Label).Text;
            (sender as Label).ForeColor =  (str == "VietNam" || str == "Viet Nam")? Color.Lime : Color.DeepSkyBlue;
        }

        private void checkedListBoxControl_Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.footballerBindingSource.CurrencyManager.Position == -1)
                return;
            LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow footballerRow
                = (this.footballerBindingSource.CurrencyManager.Current as DataRowView).Row as LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow;
            if (DBNull.Value.Equals(footballerRow.Avatar))
                return;
            if (String.IsNullOrEmpty(footballerRow.Avatar))
                return;
            if (File.Exists(footballerRow.Avatar))
                this.pictureEdit_player.Image = Image.FromFile(footballerRow.Avatar);

        }

        private void checkedListBoxControl_Player_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            this.labelControlNumber.Text = (sender as BaseCheckedListBoxControl).CheckedItemsCount.ToString();
            if (this.footballerBindingSource.CurrencyManager.Position == -1)
                return;
            LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow footballerRow
                = (this.footballerBindingSource.CurrencyManager.Current as DataRowView).Row as LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow;

            if (this.teamBindingSource.CurrencyManager.Position == -1)
                return;
            var teamrow =
                (this.teamBindingSource.CurrencyManager.Current as DataRowView).Row as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow;

            LeagueManagement_DX.LeagueDatabaseDataSet.TeamDetailRow teamdetailrow =
                this.leagueDatabaseDataSet.TeamDetail.FindByTeamIdPlayerId(teamrow.Id, footballerRow.Id);
            this.customTextBox_ShirtValue.Text = teamdetailrow.ShirtNumber.ToString();
            this.comboBoxEdit_postion.Text = teamdetailrow.Position;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            //if (this.radioButton_New.Checked == true)
            //    this.ok_buttonClick_New();
            //else
            Has_Change = true;
                this.ok_buttonClickExists();
        }

        private void footballerBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            // show shirt number and position
            if (footballerBindingSource.Position < 0)
                return;
            int playerId = Convert.ToInt32((this.footballerBindingSource.CurrencyManager.Current as DataRowView).Row["Id"]);
            int teamId = Convert.ToInt32((this.teamBindingSource.CurrencyManager.Current as DataRowView).Row["Id"]);
            var teamDetailRow = this.leagueDatabaseDataSet.TeamDetail.FindByTeamIdPlayerId(teamId, playerId);

            //if (this.radioButton_Exists.Checked == true)
            //{
            //    if (teamDetailRow == null)
            //        return;
            //    this.customTextBox_ShirtValue.Text = teamDetailRow.ShirtNumber.ToString();
            //    this.comboBoxEdit_postion.Text = teamDetailRow.Position;
            //}
            //if (this.radioButton_New.Checked == true)
            //{
            //    int bindposition = this.footballerBindingSource.Position;
            //    if (a_shirtnumber == null)
            //    {
            //        a_shirtnumber = new int[this.leagueDatabaseDataSet.Footballer.Count];
            //    }
            //    if (a_position == null)
            //    {
            //        a_position = new string[this.leagueDatabaseDataSet.Footballer.Count];
            //    }
            //    this.customTextBox_ShirtValue.Text = a_shirtnumber[bindposition].ToString();
            //    this.comboBoxEdit_postion.Text = a_position[bindposition];
            //}
            string avt = (this.footballerBindingSource.CurrencyManager.Current as DataRowView).Row["Avatar"].ToString();
            this.pictureEdit_player.Image = updateimage(avt);

        }

        private void customTextBox_ShirtValue_xTextChanged(object sender, EventArgs e)
        {
            //// gán text vào a_shirtnumber với index bằng với position của bindsource
            //if (String.IsNullOrEmpty((sender as TextBox).Text))
            //    return;
            ////if (this.radioButton_Exists.Checked == true)
            ////    return;
            //int pos = this.footballerBindingSource.Position;
            //a_shirtnumber[pos] = Int32.Parse((sender as TextBox).Text);
        }
        
        private void comboBoxEdit_postion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////gán combobox text position cho mảng
            ////if (this.radioButton_Exists.Checked == true)
            ////    return;
            //int pos = this.footballerBindingSource.Position;
            //a_position[pos] = this.comboBoxEdit_postion.Text;
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.leagueDatabaseDataSet.RejectChanges(); //check
            this.Close();
        }

        #region Private Method

        private void fillRegistedFootballer(int teamId)
        {
            if (footballerBindingSource.Position == -1)
                return;
            this.registrationTableAdapter.FillByTeamIdTourId(this.leagueDatabaseDataSet.Registration,teamId,tourRow.Id);
            foreach (DataRowView item in this.leagueDatabaseDataSet.Registration.DefaultView)
            {
                var row = item.Row as LeagueManagement_DX.LeagueDatabaseDataSet.RegistrationRow;
                int playerid = row.PLayerId; // lấy được playerId
                var list = leagueDatabaseDataSet.Footballer
                    .Where(fooballer => fooballer.Id == playerid)
                    .Select(datarow => datarow.Name).First();

                int i = this.checkedListBoxControl_Player.FindString(list);
                this.checkedListBoxControl_Player.SetItemChecked(i, true);

            }
            this.checkedListBoxControl_Player_ItemCheck(this.checkedListBoxControl_Player, new DevExpress.XtraEditors.Controls.ItemCheckEventArgs(0, CheckState.Indeterminate));
        }

        private void createOfficalStadium(int tourId, int teamId)
        {
            //create offical stadium
            this.official_StadiumTableAdapter.Fill(this.leagueDatabaseDataSet.Official_Stadium);
            LeagueManagement_DX.LeagueDatabaseDataSet.Official_StadiumRow OSrow;
            OSrow = leagueDatabaseDataSet.Official_Stadium.FindByTeamIdTourId(teamId, tourId);
            if (OSrow == null)
            {
                OSrow = this.leagueDatabaseDataSet.Official_Stadium.NewOfficial_StadiumRow();
                OSrow.TourId = tourId;
                OSrow.TeamId = teamId;
                OSrow.StadiumName = this.customTextBox_Stadium.Text;
                OSrow.EndEdit();
                this.leagueDatabaseDataSet.Official_Stadium.AddOfficial_StadiumRow(OSrow);
                this.richTextBox_message.Text += "stadium added success\n";
            }
            else
            {
                OSrow.BeginEdit();
                OSrow.StadiumName = this.customTextBox_Stadium.Text;
                OSrow.EndEdit();
                this.richTextBox_message.Text += "stadium changed success\n";                
            }

            this.official_StadiumTableAdapter.Update(OSrow);
            this.leagueDatabaseDataSet.AcceptChanges();
        }

        private int addTeamJoinTour(int tourId, int teamId)
        {
            //create team jointour row
            var row = this.leagueDatabaseDataSet.TeamJoinTour.NewTeamJoinTourRow();
            row.TourId = tourId;
            row.TeamId = teamId;
            this.leagueDatabaseDataSet.TeamJoinTour.AddTeamJoinTourRow(row);
            var teamrow = this.leagueDatabaseDataSet.Team.FindById(teamId);
            int success = 0;
            try
            {
                success = this.teamJoinTourTableAdapter.Update(row);
                this.leagueDatabaseDataSet.AcceptChanges();
                this.richTextBox_message.Text += "team '" + teamrow.Name + "' register to tour success\n";
            }
            catch (SqlException sqle)
            {
                foreach (SqlError item in sqle.Errors)
                {
                    switch (item.Number)
                    {
                        case 50000: //trigger
                            //if (item.Procedure == "Trigger_Registration_TeamDetail")
                            //{
                                richTextBox_message.Text += "ERROR: " + item.Message + "\n";
                            //}
                            if (item.Procedure == "Trigger_Join_Condition")
                            {
                                richTextBox_message.Text += "ERROR: " + item.Message + "\n";
                            }
                            break;
                        default:
                            break;
                    }
                }
                richTextBox_message.Text += "Team registers unsuccess.\n";
                this.leagueDatabaseDataSet.RejectChanges();
            }
            return success;
            //error exception ??
        }

        private void ok_buttonClickExists()
        {
            registrationTableAdapter.Fill(leagueDatabaseDataSet.Registration);

            LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow teamrow
                = (this.teamBindingSource.CurrencyManager.Current as DataRowView).Row as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow;
            int tourId = tourRow.Id;
            int teamId = teamrow.Id;

            /* add checked items */
            var listcheckedItem = this.checkedListBoxControl_Player.CheckedItems; //các item được check
            foreach (var item in listcheckedItem)
            {
                int playerId = Convert.ToInt32((item as DataRowView).Row["Id"]);//playerId
                var row = leagueDatabaseDataSet.Registration.NewRegistrationRow();
                row.TourId = tourId;
                row.TeamId = teamId;
                row.PLayerId = playerId;
                row.EndEdit();
                var existsrow = leagueDatabaseDataSet.Registration.FindByTourIdTeamIdPLayerId(tourId, teamId, playerId);
                if (existsrow != null)
                    continue;
                try
                {
                    leagueDatabaseDataSet.Registration.Rows.Add(row);
                }
                catch (ConstraintException e)
                {
                    
                    if (e.Message.Contains("Column 'TourId, TeamId, PLayerId' is constrained to be unique"))
                        continue; // row đã tồn tại thì bỏ qua
                }
            }

            /* remove unchecked items */
            for (int i = 0; i < this.footballerBindingSource.Count - 1; i++)
            {
                if (this.checkedListBoxControl_Player.GetItemCheckState(i) == CheckState.Checked)
                    continue;
                int playerId = Convert.ToInt32((this.checkedListBoxControl_Player.GetItem(i) as DataRowView).Row["Id"]);
                var row = leagueDatabaseDataSet.Registration.FindByTourIdTeamIdPLayerId(tourId, teamId, playerId);
                if (row != null)
                    row.Delete();
            }
            /*---*/
            int regissucces = 0;
            try
            {

                regissucces = registrationTableAdapter.Update(leagueDatabaseDataSet.Registration);
                this.richTextBox_message.Text += regissucces.ToString() + " registration changed\n";
               // leagueDatabaseDataSet.AcceptChanges();
            }
            catch (SqlException e)
            {
                foreach (SqlError error in e.Errors)
                {
                    switch (error.Number)
                    {
                        case 50000: this.richTextBox_message.Text += error.Message +"\n"; break;
                        default: break;
                    }
                }
                //this.rickTextBox_message.Text += regissucces.ToString() + " registration changed\n";
                leagueDatabaseDataSet.RejectChanges();
            }

            this.teamJoinTourTableAdapter.Fill(leagueDatabaseDataSet.TeamJoinTour);
            var checkexistteam = leagueDatabaseDataSet.TeamJoinTour.FindByTourIdTeamId(tourRow.Id, teamId) 
                as LeagueManagement_DX.LeagueDatabaseDataSet.TeamJoinTourRow;

            // create teamjointour row
            int success = 0;
            if (checkexistteam == null)
                success = this.addTeamJoinTour(tourId, teamId);

            // create offical stadium row
           // if (success != 0)
            this.createOfficalStadium(tourId, teamId);
            //refresh team list
            //this.teamTableAdapter.FillNotJoinTour(this.leagueDatabaseDataSet.Team);
            this.teamDetailTableAdapter.Fill(this.leagueDatabaseDataSet.TeamDetail);
            //accepchanges
            this.listBoxControl_Team_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private void ok_buttonClick_New()
        {
            //create new team row

            var checkeditems = this.checkedListBoxControl_Player.CheckedItems;
            var teamdetailrows = new LeagueDatabaseDataSet.TeamDetailRow[this.checkedListBoxControl_Player.ItemCount];
            var registrationrows = new LeagueManagement_DX.LeagueDatabaseDataSet.RegistrationRow[this.checkedListBoxControl_Player.ItemCount];

            for (int index = 0; index < this.checkedListBoxControl_Player.ItemCount; index++)
            {
                if (checkedListBoxControl_Player.GetItemCheckState(index) != CheckState.Checked)
                    continue;
                var row = checkedListBoxControl_Player.GetItem(index) as DataRowView;
                teamdetailrows[index] = this.leagueDatabaseDataSet.TeamDetail.NewTeamDetailRow();
                int playerId = Convert.ToInt32(row["Id"]);
                teamdetailrows[index].PlayerId = playerId;
                teamdetailrows[index].ShirtNumber = Convert.ToByte(a_shirtnumber[index]);
                teamdetailrows[index].Position = a_position[index];

                registrationrows[index] = this.leagueDatabaseDataSet.Registration.NewRegistrationRow();
                registrationrows[index].PLayerId = playerId;
                registrationrows[index].TourId = tourRow.Id;
            }
            if (this.newTeamRow() == 0) //create new team(s). if no one success return 0
            {
                for (int i = 0; i < teamdetailrows.Length; i++)
                {
                    if (teamdetailrows[i] != null)
                    teamdetailrows[i].CancelEdit(); // dispose some teamdetail row
                }
                return;
            }

            //int teamid = this.leagueDatabaseDataSet.Team.Last().Id;
            var teamrow = this.leagueDatabaseDataSet.Team.Last();

            //create some teamdetail rows
            for (int i = 0; i < teamdetailrows.Length; i++)
            {
                if (teamdetailrows[i] == null)
                    continue;
                teamdetailrows[i].TeamId = teamrow.Id;
                try
                {
                    this.leagueDatabaseDataSet.TeamDetail.AddTeamDetailRow(teamdetailrows[i]);
                }
                catch (NoNullAllowedException nonull_E)
                {
                    if (nonull_E.Message.Contains("Position"))
                    {
                        richTextBox_message.Text += "ERROR: position of checked player does not allow null.\n";
                        richTextBox_message.Text += "\t Check player: " + 
                            this.leagueDatabaseDataSet.Footballer.FindById(teamdetailrows[i].PlayerId).Name + "\n";
                    }
                    teamdetailrows[i].CancelEdit();
                }
            }
            try
            {
                var i = this.teamDetailTableAdapter.Update(leagueDatabaseDataSet.TeamDetail);
                this.leagueDatabaseDataSet.AcceptChanges();
                richTextBox_message.Text += i.ToString() + " player(s) add to this team success\n";
            }
            catch (SqlException sqle)
            {
                foreach (SqlError item in sqle.Errors)
                {
                    switch (item.Number)
                    {
                        case 50000: //trigger
                            if (item.Procedure == "Trigger_TeamDetail_ShirtNumber")
                            {
                                richTextBox_message.Text += "ERROR: "+item.Message + "\n";
                            }
                            break;
                        default:
                            break;
                    }
                }
                this.leagueDatabaseDataSet.GetChanges().RejectChanges();
            }


            //create some registration rows
            for (int i = 0; i < registrationrows.Length; i++)
            {
                if (registrationrows[i] == null)
                    continue;
                registrationrows[i].TeamId = teamrow.Id;

                this.leagueDatabaseDataSet.Registration.AddRegistrationRow(registrationrows[i]);
            }
            try
            {
                var i = this.registrationTableAdapter.Update(leagueDatabaseDataSet.Registration);
                this.leagueDatabaseDataSet.AcceptChanges();
                richTextBox_message.Text += i.ToString() + " team(s) register to tour success\n";
            }
            catch (SqlException sqle)
            {
                foreach (SqlError item in sqle.Errors)
                {
                    switch (item.Number)
                    {
                        case 50000: //trigger
                            if (item.Procedure == "Trigger_Registration_TeamDetail")
                            {
                                richTextBox_message.Text += "ERROR: " + item.Message + "\n";
                                richTextBox_message.Text += "Team registers unsuccess.\n";
                            }
                            break;
                        default:
                            break;
                    }
                }
                this.leagueDatabaseDataSet.RejectChanges();
            }
            //create team join tour row
            var teamjointour = this.leagueDatabaseDataSet.TeamJoinTour.NewTeamJoinTourRow();
            teamjointour.TeamId =  teamrow.Id;
            teamjointour.TourId = tourRow.Id;
            this.leagueDatabaseDataSet.TeamJoinTour.AddTeamJoinTourRow(teamjointour);
            try
            {
                this.teamJoinTourTableAdapter.Update(teamjointour);
                this.leagueDatabaseDataSet.AcceptChanges();
                this.richTextBox_message.Text += "team '" + teamrow.Name + "' register to tour success\n";
            }
            catch (SqlException sqle)
            {
                foreach (SqlError item in sqle.Errors)
                {
                    switch (item.Number)
                    {
                        case 50000: //trigger
                            if (item.Procedure == "Trigger_Join_Condition")
                            richTextBox_message.Text += "ERROR: " + item.Message + "\n";
                            richTextBox_message.Text += "team: '" + teamrow.Name + "' register to tour unsuccess\n";
                            break;
                        default:
                            break;
                    }
                }
            }
            this.createOfficalStadium(tourRow.Id, teamrow.Id);
            this.teamTableAdapter.FillNotJoinTour(this.leagueDatabaseDataSet.Team);
            //refresh footballerlist
        }

        // trả về số dòng add thành côngs
        private int newTeamRow()
        {
            var teamrow = (this.teamBindingSource.AddNew() as DataRowView).Row as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow;
            teamrow.Name = this.customTextBox_Name.Text;
            teamrow.Stadium = this.customTextBox_Stadium.Text;
            
            this.leagueDatabaseDataSet.Team.AddTeamRow(teamrow);
            int success=0;
            try
            {
                success = this.teamTableAdapter.Update(teamrow);
                this.leagueDatabaseDataSet.AcceptChanges();
                richTextBox_message.Text += "create " + success.ToString() + " team(s) success\n";
            }catch(SqlException sqle)
            {
                foreach (SqlError item in sqle.Errors)
                {
                    switch (sqle.Number)
                    {
                        case 2627:
                            if (item.Message.Contains("UQ__Team__737584F6AD4FB765"))
                            {
                                richTextBox_message.Text += "ERROR: Two teams has same name.\n";
                            }
                            break;
                        default:
                            break;
                    }
                }
                this.leagueDatabaseDataSet.RejectChanges();
            }

            if (success == 0)
                return success;

            //sửa avt
            teamrow = this.leagueDatabaseDataSet.Team.Last();
            string strpath = @"Image\Team\" + teamrow.Id.ToString() + ".jpg";
            teamrow.BeginEdit();
            teamrow.Avatar = strpath;
            teamrow.EndEdit();
            this.teamTableAdapter.Update(teamrow);
            this.leagueDatabaseDataSet.AcceptChanges();
            
            //save image
            if (Directory.Exists(@"Image\Team"))
                Directory.CreateDirectory(@"Image\Team");
            if (this.pictureEditTeamLogo.Image != null)
                pictureEditTeamLogo.Image.Save(strpath);
            return success;
        }

        // add text to ricktextbox with p has corlor
        private void addTextAppend(RichTextBox rickTextBox, string p, Color color)
        {
            rickTextBox.Text += p;
            rickTextBox.Find(p);
            rickTextBox.SelectionColor = color;
        }

        private Image updateimage(string stringpath)
        {
            if (string.IsNullOrEmpty(stringpath))
                return null;
            if (File.Exists(stringpath))
                return Image.FromFile(stringpath);
            return null;
        }
        #endregion

        private void label_FootballerName_TextChanged(object sender, EventArgs e)
        {
            (sender as Label).Text = (sender as Label).Text.TrimEnd();
        }
        //-----------
    }
}