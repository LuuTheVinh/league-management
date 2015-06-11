using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LeagueManagement_DX;
using LeagueManagement_DX.Forms;
using LeagueManagement_DX.Properties;
using System.Data.SqlClient;
using LeagueManagement_DX.CustomControlLibrary;
namespace LeagueManagement_DX.Forms
{
    public partial class CreateMatch : DevExpress.XtraEditors.XtraForm
    {
        LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow tourRow;
        ControlList controllist;
        LeagueDatabaseDataSet dataset;
        public CreateMatch()
        {
            InitializeComponent();
        }
        public CreateMatch(ControlList _controlList)
        {
            InitializeComponent();
            this.controllist = _controlList;
            //this.tourRow = _tourRow;
            this.dataset = _controlList.leagueDatabaseDataSet;
            this.matchTableAdapter = _controlList.tableAdapterManager.MatchTableAdapter;
            
        }
        private void CreateMatch_Load(object sender, EventArgs e)
        {
            this.groupControlMatchInfo.Enabled = true;
            this.groupControlMatchReview.Enabled = true;
            this.dateTimePickerRealDay.Enabled = false;
            this.simpleButtonCreateMatch.Show();
            this.simpleButtonCancelMatch.Show();
            this.simpleButtonEditMatch.Hide();
            //this.reportTeamByTourTableAdapter.Fill(leagueDatabaseDataSet.ReportTeamByTour,)
            foreach (DataRow i in leagueDatabaseDataSet.ReportTeamByTour)
            {
                this.comboBoxEditHome.Properties.Items.Add(i["Name"]);
                this.comboBoxEditAway.Properties.Items.Add(i["Name"]);
            }
            this.dateTimePickerForeseeDate.Value = DateTime.Now;
            this.dateTimePickerRealDay.Value = this.dateTimePickerForeseeDate.Value;
        }

        private void CreateMatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            matchBindingSource.CancelEdit();
            ((Form)sender).Hide();
        }

        private void simpleButtonCreateMatch_Click(object sender, EventArgs e)
        {
            //if (this.comboBoxEditAway.SelectedIndex >= 0 && this.comboBoxEditHome.SelectedIndex >= 0 && this.customTextBoxRound.Text != "" && this.customTextBoxRound.CheckCodition())
            //{
                matchBindingSource.AddNew();
                DataRow currRow = ((DataRowView)((CurrencyManager)matchBindingSource.CurrencyManager).Current).Row;
               // currRow["TourId"] = this._currentTourDetail.Id;
                DataRow[] homeId = leagueDatabaseDataSet.Tables["Team"].Select(string.Format("CONVERT({0},System.String) LIKE '%{1}'", "Name", this.comboBoxEditHome.SelectedItem.ToString()));
                currRow["Home"] = homeId[0]["Id"];
                DataRow[] AwayId = leagueDatabaseDataSet.Tables["Team"].Select(string.Format("CONVERT({0},System.String) LIKE '%{1}'", "Name", this.comboBoxEditAway.SelectedItem.ToString()));
                currRow["Away"] = AwayId[0]["Id"];
                currRow["ForeseeDate"] = this.dateTimePickerForeseeDate.Value;
                currRow["Round"] = Convert.ToInt32(this.customTextBoxRound.Text);
                //
                //matchTableAdapter.Update(leagueDatabaseDataSet);
                //leagueDatabaseDataSet.AcceptChanges();
                try
                {

                    matchBindingSource.EndEdit();
                    matchTableAdapter.Update(leagueDatabaseDataSet);
                    leagueDatabaseDataSet.AcceptChanges();
                }
                catch (SqlException sqle)
                {
                    foreach (var error in sqle.Errors)
                    {
                        switch ((error as SqlError).Number)
                        {
                            //case 2627:
                            //    rs = this.Exception_Duplicate_TourName((error as SqlError).Message);
                            //    break;
                            case 547:
                                if ((error as SqlError).Message.Contains("CK_MATCH_HOME_AWAY"))
                                {
                                    this.Exception_CK_MATCH_HOME_AWAY((error as SqlError).Message);
                                    break;
                                }
                                break;
                            case 50000:
                                if ((error as SqlError).Procedure == "Trigger_Match_INSERT_UPDATE_ROUNDS")
                                {
                                    this.Exception_Trigger_Match_INSERT_UPDATE_ROUNDS((error as SqlError).Message);
                                    break;
                                }
                                if ((error as SqlError).Procedure == "Trigger_Match_InsertUpdate_Round")
                                {
                                    this.Exception_Trigger_Match_InsertUpdate_Round((error as SqlError).Message);
                                    break;
                                }
                                if ((error as SqlError).Procedure == "Trigger_Match_Time_InsertUpdate")
                                {
                                    this.Exception_Trigger_Match_Time_InsertUpdate((error as SqlError).Message);
                                    break;
                                }
                                break;
                            default:
                                {
                                    MessageBox.Show((error as SqlError).Message, "");
                                    break;
                                }
                        }

                    }
                    matchBindingSource.RemoveCurrent();
                }
            //}
            //else
            //{
            //    string mg = "";
            //    if (this.customTextBoxRound.Text == "")
            //        mg += "Round not allow null\n";
            //    if (this.comboBoxEditAway.SelectedIndex < 0)
            //        mg += "Away not allow null\n";
            //    if (this.comboBoxEditHome.SelectedIndex < 0)
            //        mg += "Home not allow null\n";
            //    if (this.customTextBoxRound.CheckCodition() == false)
            //        mg += "Round is number\n";
            //    MessageBox.Show(mg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private DialogResult Exception_CK_MATCH_HOME_AWAY(string p)
        {
            string msg = "Home and Away must difference.";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.OK);
        }

        private DialogResult Exception_Trigger_Match_INSERT_UPDATE_ROUNDS(string p)
        {
            return MessageBox.Show(p, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK);
        }
        private DialogResult Exception_Trigger_Match_InsertUpdate_Round(string p)
        {
            return MessageBox.Show(p, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK);
        }
        private DialogResult Exception_Trigger_Match_Time_InsertUpdate(string p)
        {
            return MessageBox.Show(p, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK);
        }

        private void simpleButtonCancelMatch_Click(object sender, EventArgs e)
        {
            matchBindingSource.CancelEdit();
            this.Close();
        }

        private void comboBoxEditHome_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //pictureEditHome.Image =  Image.FromFile(@"E:\Lib\Ky 2 nam 2\NMCNPM\Backup\Do an update\LeagueManagement_DX\Image\Team\" + this.comboBoxEditHome.SelectedItem.ToString() + ".png");
            //pictureEditHome.Image = Image.FromFile(Application.StartupPath + @"\Image\Team\" + this.comboBoxEditHome.SelectedIndex.ToString());
            //pictureEditHome.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.labelControlHome.Text = this.comboBoxEditHome.SelectedText;
            string stadium = "null";
            foreach (DataRow i in leagueDatabaseDataSet.ReportTeamByTour)
            {
                if (i["Name"].ToString() == this.comboBoxEditHome.Text)
                    stadium = i["Stadium"].ToString();
            }
            this.labelControlStadium.Text = stadium;
        }

        private void comboBoxEditAway_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }
    }
}