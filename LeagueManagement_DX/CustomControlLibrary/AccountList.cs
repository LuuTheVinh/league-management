using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueManagement_DX.Forms;
namespace LeagueManagement_DX.CustomControlLibrary
{
    public class AccountList : ControlList
    {
        public UserDataset userDataset;
        private UserDatasetTableAdapters.UserDetailTableAdapter userDetailTableAdapter1;
        private UserDatasetTableAdapters.GroupUserTableAdapter groupUserTableAdapter1;
        public UserDatasetTableAdapters.TableAdapterManager userTableAdapterManager;
        
        public override void AddListItem()
        {
            base.AddListItem();
        }
        public AccountList()
        {
            this.InitializeComponent();
            //this.detailForm = new ShowUserAccount();
            //this.addForm = new CreateAccount();
            //this.detailForm = new ShowUserAccount(this);
        }
        public void AddItem(DataRow Item)
        {
            var item = new AccountListItem(this, Item);
            item.DataRowItem = Item;
            this.Add(item);
        }
        public override void LoadDataFromTable()
        {

            base.LoadDataFromTable();
            this.userTableAdapterManager.UserDetailTableAdapter.Fill(userDataset.UserDetail);
            this.userTableAdapterManager.GroupUserTableAdapter.Fill(userDataset.GroupUser);
            foreach (var userItem in this.userDataset.UserDetail)
            {
                var item = new AccountListItem(this, userItem);
               
                item.ParentListControl = this;
                //item.DataRowItem = userItem;
                this.Add(item);
            }
            flowLayoutPanel.Visible = true;

        }
        public override void ShowItemDetail()
        {
            this.detailForm = new ShowUserAccount(this.GetSelected().DataRowItem as UserDataset.UserDetailRow);
            //base.ShowItemDetail();
            DialogResult dresult = this.detailForm.ShowDialog();
            if (dresult == DialogResult.OK)
                this.LoadDataFromTable();
        }

        private void InitializeComponent()
        {
            this.userDataset = new LeagueManagement_DX.UserDataset();
            this.userTableAdapterManager = new LeagueManagement_DX.UserDatasetTableAdapters.TableAdapterManager();
            this.userDetailTableAdapter1 = new LeagueManagement_DX.UserDatasetTableAdapters.UserDetailTableAdapter();
            this.groupUserTableAdapter1 = new LeagueManagement_DX.UserDatasetTableAdapters.GroupUserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataset
            // 
            this.userDataset.DataSetName = "UserDataset";
            this.userDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapterManager
            // 
            this.userTableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.userTableAdapterManager.GroupPermissionTableAdapter = null;
            this.userTableAdapterManager.GroupUserTableAdapter = this.groupUserTableAdapter1;
            this.userTableAdapterManager.PermissionTableAdapter = null;
            this.userTableAdapterManager.UpdateOrder = LeagueManagement_DX.UserDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.userTableAdapterManager.UserDetailTableAdapter = this.userDetailTableAdapter1;
            // 
            // userDetailTableAdapter1
            // 
            this.userDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // groupUserTableAdapter1
            // 
            this.groupUserTableAdapter1.ClearBeforeFill = true;
            // 
            // AccountList
            // 
            this.Name = "AccountList";
            this.Size = new System.Drawing.Size(153, 135);
            this.Load += new System.EventHandler(this.AccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leagueDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataset)).EndInit();
            this.ResumeLayout(false);
            
        }

        private void AccountList_Load(object sender, EventArgs e)
        {
            //this.detailForm = new ShowUserAccount(this.GetSelected().DataRowItem as UserDataset.UserDetailRow);
            //this.LoadDataFromTable();
            //this.detailForm = new ShowUserAccount();
            //this.userTableAdapterManager.UserDetailTableAdapter.Fill(userDataset.UserDetail);
            //this.userTableAdapterManager.GroupUserTableAdapter.Fill(userDataset.GroupUser);
        }
        
    }
}
