using LeagueManagement_DX.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    class TeamList : ControlList
    {
        private LeagueDatabaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter footballerTableAdapter;
        private int _tourID;
        public TeamList()
        {
            InitializeComponent();

            this.tableAdapterManager.TeamTableAdapter = teamTableAdapter;
            this.tableAdapterManager.FootballerTableAdapter = footballerTableAdapter;
            this.tableAdapterManager.TeamDetailTableAdapter = teamDetailTableAdapter;
            /// them vao cho nay moi chay dc (thang)
            this.AddForm = new AddTeamForm(this);
            //this.tableAdapterManager.TeamTableAdapter.Fill(leagueDatabaseDataSet.Team);
        }

        public override void AddListItem()
        {
            if (AddForm != null)
            {
                (AddForm as AddTeamForm).TeamRow = null;
                DialogResult dlResult = AddForm.ShowDialog();
                
                 if (dlResult == DialogResult.OK)
                    LoadDataFromTable();
            }
        }

        public void ShowAddForm(LeagueDatabaseDataSet.TeamRow teamrow)
        {
            this.AddForm = new AddTeamForm(this);
            (AddForm as AddTeamForm).TeamRow = teamrow;

            if (AddForm != null)
            {
                DialogResult dlResult = AddForm.ShowDialog();

                if (dlResult == DialogResult.OK)
                    LoadDataFromTable();
            }
        }

        //-Nghia
        public override void RemoveSelectedItem()
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                {
                    var control = flowLayoutPanel.Controls[i] as TeamControlListItem;
                    if (control.Selected)
                    {
                        if (control.RemoveDataItem())
                            this.Remove(control);
                        return;
                    }
                }
            }
        }
        public override void EditItemDetail()
        {
            Form form = Application.OpenForms["MainManagement"];
            (form as MainManagement).ShowAddTeamForm();
        }
        //Nghia -
        public override void ShowItemDetail()
        {
            if (this.ParentForm.IsMdiContainer == false)
            {
                
                
                this.detailForm = new ShowTeam(this, this.GetSelected().DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow, false, _tourID);
                if (detailForm != null)
                {
                    detailForm.ShowDialog();
                }
            }    
            else
            {
                DataRow dataRow = this.GetSelected().DataRowItem;
                this.detailForm = new ShowTeam(this, this.GetSelected().DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow, true, _tourID);
                this.detailForm.MdiParent = this.ParentForm;
                this.detailForm.Text = dataRow["Name"].ToString();
                this.detailForm.Show();
            }    
        }
        public override void LoadDataFromTable()
        {
            base.LoadDataFromTable();

            //Cho nó ẩn đi, add xong mới hiện lên
            flowLayoutPanel.Visible = false;

            this.tableAdapterManager.TeamTableAdapter.Fill(leagueDatabaseDataSet.Team);

            this.tableAdapterManager.TeamDetailTableAdapter.Fill(leagueDatabaseDataSet.TeamDetail);
            this.tableAdapterManager.FootballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);

            //foreach (var touritem in this.leagueDatabaseDataSet.Team)
            foreach (var touritem in this.teamTableAdapter.GetData())
            {
                var item = new TeamControlListItem(this, touritem);
                this.Add(item);
            }

            //Hiện lên
            flowLayoutPanel.Visible = true;
        }

        /// <summary>
        /// Load thông tin đội theo giải.
        /// </summary>
        /// <param name="_tour"></param>
        public void LoadDataFromTable(int _tour)
        {
            _tourID = _tour;
            base.LoadDataFromTable();
            
            //Cho nó ẩn đi, add xong mới hiện lên
            flowLayoutPanel.Visible = false;

            this.tableAdapterManager.TeamTableAdapter.FillByTour(leagueDatabaseDataSet.Team,_tour);

            foreach (var touritem in this.leagueDatabaseDataSet.Team)
            {
                var item = new TeamControlListItem(this, touritem);
                this.Add(item);
            }

            //Hiện lên
            flowLayoutPanel.Visible = true;
        }
        private void InitializeComponent()
        {
            this.teamTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamTableAdapter();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.footballerTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.FootballerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailTableAdapter
            // 
            this.teamDetailTableAdapter.ClearBeforeFill = true;
            // 
            // footballerTableAdapter
            // 
            this.footballerTableAdapter.ClearBeforeFill = true;
            // 
            // TeamList
            // 
            this.Name = "TeamList";
            this.Size = new System.Drawing.Size(148, 148);
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }
        public void SetLevelAccess(int i)
        {
            if (i==1)
            {
                foreach (var item in flowLayoutPanel.Controls)
                {
                    (item as TeamControlListItem).MenuStrip.Items.RemoveByKey("deleteItem");
                    (item as TeamControlListItem).MenuStrip.Items.RemoveByKey("editItem");
                }
            }
            else
            {
                foreach (var item in flowLayoutPanel.Controls)
                {
                    if ((item as TeamControlListItem).MenuStrip.Items.Find("editItem", true).Length == 0)
                    {
                        var menustripItem = new ToolStripMenuItem("Edit") { Name = "editItem" };
                        (item as TeamControlListItem).MenuStrip.Items.Add(menustripItem);
                    }
                    if ((item as TeamControlListItem).MenuStrip.Items.Find("deleteItem", true).Length == 0)
                    {
                        var menustripItem = new ToolStripMenuItem("Delete") { Name = "deleteItem" };
                        (item as TeamControlListItem).MenuStrip.Items.Add(menustripItem);
                    }
                }
            }
        }
    }
}
