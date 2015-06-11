using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LeagueManagement_DX.CustomControlLibrary
{
    public partial class AccountListItem : ControlListItem
    {
        DataRow _userRowItem;
        //private UserDatasetTableAdapters.GroupUserTableAdapter groupUserTableAdapter;
        public AccountListItem(AccountList accountList,DataRow Item) : base(accountList)
        {
            InitializeComponent();
            this.userAvatar.ContextMenuStrip = new ContextMenuStrip();
            this.NormalColor = Color.WhiteSmoke;
            this.SelectColor = Color.BlueViolet;
            this.HoverColor = Color.BlueViolet;
            this.BackColor = this.NormalColor;
           
            this._userRowItem= Item;
            this.DataRowItem = Item;
            this.Name = Item["Username"].ToString();
            this.userFullName.Text = this._userRowItem["FullName"].ToString();
            this.userGroup.Text = groupUserTableAdapter.GetGroupName(Convert.ToInt32(this._userRowItem["Username"])).ToString();
            if (File.Exists(this._userRowItem["Avatar"].ToString()))
            {
                this.userAvatar.Image = Image.FromFile(this._userRowItem["Avatar"].ToString());
            }
            this.MouseDoubleClick += this.accountList_DoubleClick;
            this.ParentListControl = accountList;
            //this.MenuStrip.ItemClicked += this.MenuStrip_ItemClick;
            this.menuStrip.Items.Clear();
        }

        private void accountList_DoubleClick(object sender, MouseEventArgs e)
        {
            if (this.userAvatar.Image != null)
            {
                this.userAvatar.Image.Dispose();
                
            }
            this.ParentListControl.ShowItemDetail();
            this.ParentListControl.LoadDataFromTable();
            
            
        }
        private void MenuStrip_ItemClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == infoItem)
            {
                this.ParentListControl.ShowItemDetail();
            }
            else if (e.ClickedItem == deleteItem)
            {
                //DELETE DATA GO HERE...
                this.ParentListControl.RemoveSelected();
            }
            else if (e.ClickedItem == editItem)
            {
                //SETTING TOUR GO HERE...
            }
        }

        public override void RemoveData()
        {
            base.RemoveData();
            if (this._userRowItem != null)
            {
                this._userRowItem.Delete();
                this.userDetailTableAdapter.Update(this.userDataset);
                this.userDataset.AcceptChanges();
            }
        }

        private void AccountListItem_Load(object sender, EventArgs e)
        {
           // this.userDetailTableAdapter.Fill(this.userDataset.UserDetail);
        }

    }
}
