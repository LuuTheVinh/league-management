using DevExpress.XtraEditors;
using LeagueManagement_DX.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public class TourList : ControlList
    {
        private LeagueDatabaseDataSetTableAdapters.ToursTableAdapter toursTableAdapter;
        public TourList()
        {
            InitializeComponent();

            this.ListType = eTypeControlList.TOUR;
            this.tableAdapterManager.ToursTableAdapter = toursTableAdapter;
            

            this.AddForm = new AddTour(this);
            //this.detailForm = new TourManagement();
        }

        public override void LoadDataFromTable()
        {
            base.LoadDataFromTable();

            flowLayoutPanel.Visible = false;

            this.tableAdapterManager.ToursTableAdapter.Fill(leagueDatabaseDataSet.Tours);
            
            foreach (var touritem in this.leagueDatabaseDataSet.Tours)
            {
                var item = new TourControlListItem(this, touritem);
				//7ung
				//kiểm tra quyền truy xuất
                if (UserAccessLevel.Instance.GetAccessLevel == 1)
                {
                    item.MenuStrip.Items.RemoveByKey("deleteItem");
                    item.MenuStrip.Items.RemoveByKey("editItem");
                }
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
            //SELECTED ITEM DETAIL FOR "DETAILFORM" GO HERE...
            base.ShowItemDetail();
        }

        public override void ShowItemDetail(DataRow dataRow)
        {
            // sử lý chổ này để truyền datarow và cái form để lấy thông tin.
            this.detailForm = new TourManagement(dataRow);
            this.detailForm.MdiParent = this.ParentForm;
            this.detailForm.Text = (dataRow as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow).TourName;
            this.detailForm.Show();
        }
        private void InitializeComponent()
        {
            this.toursTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.ToursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toursTableAdapter
            // 
            this.toursTableAdapter.ClearBeforeFill = true;
            // 
            // TourList
            // 
            this.Name = "TourList";
            this.Size = new System.Drawing.Size(148, 148);
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
