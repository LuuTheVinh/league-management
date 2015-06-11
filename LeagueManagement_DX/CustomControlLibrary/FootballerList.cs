using LeagueManagement_DX.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public enum eListType
    {
        SMALL,
        BIG
    }
    class FootballerList : ControlList
    {
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter selectFootballerByTeamTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.SelectFootballerByTourTableAdapter selectFooballerByTourTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;

        public eListType ListType { get; set; }
        public int TeamID { get; set; }
        public int TourID { get; set; }
        public FootballerList()
        {
            InitializeComponent();
        }


        // Hàm viết thêm
        public void LoadDataFromTable(bool isFull)
        {
            flowLayoutPanel.Visible = false;

            flowLayoutPanel.Controls.Clear();
            if (isFull)
            {
                //this.selectFootballerByTeamTableAdapter.Fill(leagueDatabaseDataSet.SelectFootballerByTeam,TeamID);
                var list = selectFootballerByTeamTableAdapter.GetData(TeamID);

                foreach (var footballeritem in list) //Get Footballer cập nhật trong dataset
                {
                    var item = new FootballerControlListItemSmall(this, footballeritem);
                    this.Add(item);
                }
            }
            else
            {
                //this.selectFooballerByTourTableAdapter.Fill(leagueDatabaseDataSet.SelectFootballerByTour, TourID);
                //var list = selectFooballerByTourTableAdapter.GetDataByTeamIdTourId(TourID, TeamID);
                var list = selectFooballerByTourTableAdapter.GetData(TourID);

                foreach (var footballeritem in list)//Get Footballer cập nhật trong dataset
                {
                    if (Int32.Parse(footballeritem["TeamId"].ToString()) == TeamID)
                    {
                        var item = new FootballerControlListItemSmall(this, footballeritem);
                        this.Add(item);
                    }
                    
                }
            }

            flowLayoutPanel.Visible = true;
        }
        public override void LoadDataFromTable()
        {
            flowLayoutPanel.Visible = false;

            flowLayoutPanel.Controls.Clear();
            this.tableAdapterManager.FootballerTableAdapter = footballerTableAdapter;
            this.tableAdapterManager.TeamDetailTableAdapter = teamDetailTableAdapter;

            this.tableAdapterManager.FootballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
            this.tableAdapterManager.TeamDetailTableAdapter.Fill(leagueDatabaseDataSet.TeamDetail);

            foreach (var footballeritem in tableAdapterManager.FootballerTableAdapter.GetDataByAllItem())
            {
                var item = new FootballerControlListItemSmall(this, footballeritem);
                this.Add(item);
            }

            flowLayoutPanel.Visible = true;
        }

        public void LoadAllFootballer()
        {
            flowLayoutPanel.Visible = false;

            this.tableAdapterManager.FootballerTableAdapter = footballerTableAdapter;
            this.tableAdapterManager.TeamDetailTableAdapter = teamDetailTableAdapter;

            this.tableAdapterManager.FootballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
            this.tableAdapterManager.TeamDetailTableAdapter.Fill(leagueDatabaseDataSet.TeamDetail);
            foreach (var player in leagueDatabaseDataSet.Footballer)
            {
                var item = new FootballerControlListItemSmall(this, player);
                this.Add(item);
            }

            flowLayoutPanel.Visible = true;
        }

        public override void AddListItem()
        {
            //ADD OR EDIT ITEM FORM GO HERE...
            AddForm = new Footballer(this);
            if (AddForm != null)
            {
                DialogResult dl = this.AddForm.ShowDialog();
                if (dl == DialogResult.OK)
                    LoadDataFromTable();
            }
        }

        public override void ShowItemDetail()
        {
            //SHOW DETAIL FORM GO HERE...
            DataRow dataRow = this.GetSelected().DataRowItem;
            using (detailForm = new ShowFootballer(this, true, false))
            {
                DialogResult dlResult = detailForm.ShowDialog();
                if (dlResult == DialogResult.OK)
                    LoadDataFromTable(true);
            }        
        }

        //--Nghia
        public override void EditItemDetail()
        {
            DataRow dataRow = this.GetSelected().DataRowItem;

            if (this.ParentForm.IsMdiContainer == false)
            {
                using (detailForm = new ShowFootballer(this, true, true))
                {
                    DialogResult dlResult = detailForm.ShowDialog();
                    if (dlResult == DialogResult.OK)
                        LoadDataFromTable(true);
                }
            }
           
        }
        //--Nghia
        public override void RemoveSelectedItem()
        {
            DataRow dataRow = this.GetSelected().DataRowItem;

            if (this.ParentForm.IsMdiContainer == false)
            {
                using (detailForm = new ShowFootballer(this, true, false))
                {
                    if ((detailForm as ShowFootballer).DeleteFootballer())
                    {
                        base.RemoveSelected();
                    }
                }
            }      
        }
        private void InitializeComponent()
        {
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.selectFootballerByTeamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByTeamTableAdapter();
            this.selectFooballerByTourTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.SelectFootballerByTourTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailTableAdapter
            // 
            this.teamDetailTableAdapter.ClearBeforeFill = true;
            // 
            // selectFootballerByTeamTableAdapter
            // 
            this.selectFootballerByTeamTableAdapter.ClearBeforeFill = true;
            // 
            // selectFooballerByTourTableAdapter
            // 
            this.selectFooballerByTourTableAdapter.ClearBeforeFill = true;
            // 
            // FootballerList
            // 
            this.Name = "FootballerList";
            this.Size = new System.Drawing.Size(148, 148);
            this.Load += new System.EventHandler(this.FootballerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private void FootballerList_Load(object sender, EventArgs e)
        {

            //this.tableAdapterManager.FootballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
            //this.tableAdapterManager.TeamDetailTableAdapter.Fill(leagueDatabaseDataSet.TeamDetail);
        }
        //--nghia edit
        public void SetLevelAccess(int i)
        {
            if (i==1)
            {
                foreach (var item in flowLayoutPanel.Controls)
                {
                    (item as FootballerControlListItemSmall).MenuStrip.Items.RemoveAt(1);

                }
            }
        }
    }
}
