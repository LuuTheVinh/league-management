using LeagueManagement_DX.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Linq;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public class MatchList : ControlList
    {
        public int TeamID { get; set; }
        public int TourID { get; set; }
        LeagueDatabaseDataSet dataset;
        public MatchList()
        {
            InitializeComponent();

            this.tableAdapterManager.MatchTableAdapter = _matchTableAdapter;
            this.DoubleBuffered = true;
        }

        public override void LoadDataFromTable()
        {
            if (this.tableAdapterManager.MatchTableAdapter == null) 
                return;
            //base.LoadDataFromTable();

            //flowLayoutPanel.Visible = false;

            this.tableAdapterManager.MatchTableAdapter.FillByTour(leagueDatabaseDataSet.Match, TourID);
            foreach (var matchitem in this.leagueDatabaseDataSet.Match)
            {
                //var control = this.flowLayoutPanel.Controls.Find("matchItem" + matchitem.Id.ToString(), true);
                //if (control.Length != 0)
                //    continue;
                var item = new MatchControlListItem(this, matchitem);
                this.Add(item);
            }

            //flowLayoutPanel.Visible = true;
        }
        /// <summary>
        /// Hàm viết thêm
        /// </summary>
        /// <param name="isFull"></param>
        public void LoadDataFromTable(bool isFull)
        {
            if (this.tableAdapterManager.MatchTableAdapter == null)
                return;
            base.LoadDataFromTable();

            flowLayoutPanel.Visible = false;

            if (isFull)
            {
                this.tableAdapterManager.MatchTableAdapter.FillByTeam(leagueDatabaseDataSet.Match, TeamID);
                foreach (var matchitem in this.leagueDatabaseDataSet.Match)
                {
                    var item = new MatchControlListItem(this, matchitem);
                    this.Add(item);
                }
            }
            else
            {
                this.tableAdapterManager.MatchTableAdapter.FillByTeamIdTourId(leagueDatabaseDataSet.Match, TourID, TeamID);
                foreach (var matchitem in this.leagueDatabaseDataSet.Match)
                {
                    var item = new MatchControlListItem(this, matchitem);
                    this.Add(item);
                }
            }

            flowLayoutPanel.Visible = true;
        }
        
        public void LoadDataByTeam(int teamid)
        {

            flowLayoutPanel.Visible = false;

            if (this.tableAdapterManager.MatchTableAdapter == null) return;

            base.LoadDataFromTable();

            this.tableAdapterManager.MatchTableAdapter.FillByTeam(leagueDatabaseDataSet.Match, teamid);

            foreach (var matchitem in this.leagueDatabaseDataSet.Match)
            {
                var item = new MatchControlListItem(this, matchitem);
                this.Add(item);
            }

            flowLayoutPanel.Visible = true;
        }

        public void LoadDataByTour(int tourid)
        {
            flowLayoutPanel.Visible = false;

            if (this.tableAdapterManager.MatchTableAdapter == null) return;

            base.LoadDataFromTable();

            this.tableAdapterManager.MatchTableAdapter.FillByTour(leagueDatabaseDataSet.Match, tourid);

            foreach (var matchitem in this.leagueDatabaseDataSet.Match)
            {
                var item = new MatchControlListItem(this, matchitem);
                this.Add(item);
            }

            flowLayoutPanel.Visible = true;
        }

        public override void AddListItem()
        {
            
            base.AddListItem();
        }

        public override void ShowItemDetail()
        {
            //this.detailForm = ;
            base.ShowItemDetail();
        }

        private LeagueDatabaseDataSetTableAdapters.MatchTableAdapter _matchTableAdapter;

        private void InitializeComponent()
        {
            this._matchTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.MatchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // matchTableAdapter
            // 
            this._matchTableAdapter.ClearBeforeFill = true;
            // 
            // MatchList
            // 
            this.Name = "MatchList";
            this.Size = new System.Drawing.Size(148, 148);
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }
        //--nghia
        public void SetLevelAccess(int i)
        {
            if (i == 1)
            {
                foreach (var item in flowLayoutPanel.Controls)
                {
                    (item as MatchControlListItem).MenuStrip.Items.RemoveAt(2);
                    (item as MatchControlListItem).MenuStrip.Items.RemoveAt(1);
                }
            }
        }
    }
}
