using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueManagement_DX.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public partial class MatchControlListItem : ControlListItem
    {
        private ToolStripMenuItem _updateResultItem;
        public ToolStripMenuItem UpdateResultItem;

        public MatchControlListItem(MatchList matchlist, LeagueDatabaseDataSet.MatchRow matchrow) : base (matchlist)
        {
            this.NormalColor = Color.WhiteSmoke;
            this.SelectColor = Color.DodgerBlue;
            this.HoverColor = Color.SkyBlue;

            InitializeComponent();

            //this.DataRowItem = matchrow;
            DataRowItem = matchTableAdapter.GetData().FindById(matchrow.Id);
            
            //them - Nghia
            this.DoubleClick += MatchControlListItem_DoubleClick;
            //_updateResultItem = new ToolStripMenuItem("Update Result");
            //this.MenuStrip.Items.Add(_updateResultItem);

            this.MenuStrip.ItemClicked += MenuStripOnItemClicked;
            this.Name = "matchItem" + matchrow.Id.ToString();

        }
        //them -Thang
        public void RemoveDoubleClick()
        {
            this.DoubleClick -= MatchControlListItem_DoubleClick;
        }
        //them - Nghia
        void MatchControlListItem_DoubleClick(object sender, EventArgs e)
        {
            if (this.ParentForm.IsMdiChild)
            {
                if (ParentForm.Name == "TourManagement")
                {
                    var resultForm = new Result(this.DataRowItem as LeagueDatabaseDataSet.MatchRow, true);
                    resultForm.ShowDialog();
                }
                else
                {
                    var resultForm = new Result(this.DataRowItem as LeagueDatabaseDataSet.MatchRow, false);
                    resultForm.ShowDialog();
                }             
            }
            else
            {
                var resultForm = new Result(this.DataRowItem as LeagueDatabaseDataSet.MatchRow, true);
                resultForm.ShowDialog();
            }
            
        }
        //--Nghia Edit
        public void MenuStripOnItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int id = 0;
            if (e.ClickedItem == infoItem)
            {
                MatchControlListItem_DoubleClick(sender, (EventArgs)e);
            }
            else if (e.ClickedItem == deleteItem)
            {
                //DELETE DATA GO HERE...
                this.ParentListControl.RemoveSelected();
                FormCollection formCollec = Application.OpenForms; //["TourManagement"];
                foreach (Form frm in formCollec)
                {
                    if (frm.Name == "TourManagement")
                    {
                        id = (frm as TourManagement).TourID;
                        (frm as TourManagement).ReloadMatchList();
                    }
                    if (frm.Name == "ShowTeam")
                        (frm as ShowTeam).SetTeamOverView(id);
                }
            }
            else //if (e.ClickedItem == editItem)
            {
                //EDIT GO HERE...
                var updateResultForm = new AddResultForm(this.DataRowItem as LeagueDatabaseDataSet.MatchRow);
                updateResultForm.ShowDialog();
            }
        }

        private void MatchControlListItem_Load(object sender, EventArgs e)
        {
            //Init
            this.BackColor = this.NormalColor;

            //teamTableAdapter.Fill(this.ParentListControl.leagueDatabaseDataSet.Team);
            //resultTableAdapter.Fill(this.ParentListControl.leagueDatabaseDataSet.Result);

            teamTableAdapter.Fill(leagueDatabaseDataSet.Team);
            resultTableAdapter.Fill(leagueDatabaseDataSet.Result);

            var matchRow = this.DataRowItem as LeagueDatabaseDataSet.MatchRow;
            if (matchRow != null)
            {
                //var teamhomerow = this.ParentListControl.leagueDatabaseDataSet.Team.FindById(matchRow.Home);
                //var teamawayrow = this.ParentListControl.leagueDatabaseDataSet.Team.FindById(matchRow.Away);
                //var result = this.ParentListControl.leagueDatabaseDataSet.Result.FindByMatchId(matchRow.Id);

                Infomation_Load();

                Result_Load();
            }
        }

        public void SetMatchData(string team1, string team2, string score1, string score2)
        {
            statusPanel.BackColor = Color.GreenYellow;
            nameTeamOne.Text = team1;
            nameTeamTwo.Text = team2;
            nameTeamTwo.Location = new Point(this.Width - 45 - nameTeamTwo.Width, nameTeamTwo.Location.Y);

            scoreTeamTwo.Text = score1;
            scoreTeamOne.Text = score2;
        }

        public override void RemoveData()
        {
            base.RemoveData();

            //REMOVE ITEM DATA GO HERE...
            if (DataRowItem != null)
            {
                this.DataRowItem.Delete();
                //this.ParentListControl.tableAdapterManager.MatchTableAdapter.Update(this.ParentListControl.leagueDatabaseDataSet);
                //this.ParentListControl.leagueDatabaseDataSet.AcceptChanges();

                matchTableAdapter.Update(DataRowItem);
                leagueDatabaseDataSet.AcceptChanges();
            }
        }

        public override void ReloadDataEdited()
        {
            base.ReloadDataEdited();

            Result_Load();
            Infomation_Load();
        }

        private void Result_Load()
        {
            var newDataRow = matchTableAdapter.GetData().FindById(int.Parse(DataRowItem["Id"].ToString()));
            var result = resultTableAdapter.GetData().FindByMatchId(int.Parse(DataRowItem["Id"].ToString()));

            if (result != null)
            {
                if (!(newDataRow.IsRealDateNull()))
                {
                    statusPanel.BackColor = Color.GreenYellow;
                    scoreTeamTwo.Text = result.Away.ToString();
                    scoreTeamOne.Text = result.Home.ToString();

                    DataRowItem = newDataRow;
                }
                else
                {
                    if(statusPanel.BackColor != Color.Red)
                        statusPanel.BackColor = Color.Red;
                }
            }
        }

        private void Infomation_Load()
        {
            var teamhomerow = teamTableAdapter.GetData().FindById(int.Parse(DataRowItem["Home"].ToString()));
            var teamawayrow = teamTableAdapter.GetData().FindById(int.Parse(DataRowItem["Away"].ToString()));

            if (teamawayrow == null || teamhomerow == null) return;

            //LOGO
            if (File.Exists(teamawayrow.Avatar))
            {
                //logoTeamOne.Image = Image.FromFile(teamawayrow.Avatar);
                //logoTeamTwo.Image = Image.FromHbitmap(new Bitmap(teamawayrow.Avatar).GetHbitmap());
                var img = Image.FromFile(teamawayrow.Avatar);
                logoTeamTwo.Image = new Bitmap(img);
            }

            if (File.Exists(teamhomerow.Avatar))
            {
                //logoTeamTwo.Image = Image.FromFile(teamhomerow.Avatar);
                //logoTeamOne.Image = Image.FromHbitmap(new Bitmap(teamhomerow.Avatar).GetHbitmap());
                var img = Image.FromFile(teamhomerow.Avatar);
                logoTeamOne.Image = new Bitmap(img);
            }

            if(nameTeamOne.Text != teamhomerow.Name)
                nameTeamOne.Text = teamhomerow.Name;

            if (nameTeamTwo.Text != teamawayrow.Name)
                nameTeamTwo.Text = teamawayrow.Name;

            //Positon
            nameTeamTwo.Location = new Point(this.Width - 45 - nameTeamTwo.Width, nameTeamTwo.Location.Y);
        }
    }
}
