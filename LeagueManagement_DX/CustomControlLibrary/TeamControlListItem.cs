using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeagueManagement_DX.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public partial class TeamControlListItem : ControlListItem
    {
        public TeamControlListItem(ControlList teamlist, LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow teamrow) : base(teamlist)
        {
            this.NormalColor = Color.Gainsboro;
            this.SelectColor = Color.DodgerBlue;
            this.HoverColor = Color.SkyBlue;
            this.BackColor = this.NormalColor;
            
            InitializeComponent();

            //DATA ROW
            this.DataRowItem = teamrow;
            this.ItemName = this.DataRowItem["Name"].ToString();

            this.teamName.Text = this.ItemName;

            //AVATAR
            if (File.Exists(teamrow.Avatar))
            {
                //logoTeam.Image = Image.FromFile(teamrow.Avatar);
                logoTeam.Image = Image.FromHbitmap(new Bitmap(teamrow.Avatar).GetHbitmap());
            }

            //BUTTON
            this.MouseDoubleClick += TourListControlItem_MouseDoubleClick;

            //MENU STRIP
            this.MenuStrip.ItemClicked += MenuStrip_ItemClick;

            this.Name = "teamItem" + teamrow.Id.ToString();
        }

        private void MenuStrip_ItemClick(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == infoItem)
            {
                OpenItem();
            }
            else if (e.ClickedItem == deleteItem)
            {
                //DELETE DATA GO HERE...
                this.ParentListControl.RemoveSelectedItem();
                
            }
            else if (e.ClickedItem == editItem)
            {
                this.ParentListControl.EditItemDetail();
            }
        }

        //khi click ở trong TourManagemment
        private void TourListControlItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenItem();
        }


        private void OpenItem()
        {
            if (this.ParentForm == null) return;

            if (ParentForm.IsMdiContainer == false)
            {
                this.ParentListControl.ShowItemDetail();
            }
            else
            {
                var parent = this.ParentForm as MainManagement;
                var form = parent.FindChildForm<ShowTeam>(this.DataRowItem, "Name"); //tìm xem có form nào được mở ứng với row này
                if (form == null)                                                    //không tìm được thì mở form mới
                    this.ParentListControl.ShowItemDetail();
                else
                    form.Focus();                                                    //tìm được thì focus
            }
        }

        public bool RemoveDataItem()
        {

            //REMOVE ITEM DATA GO HERE...
            if (DataRowItem != null)
            {
                var rs = MessageBox.Show("Delete team make lose all of data in that team.\nDo you want to continue?", "Warning",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //Close before Delete
                    var parent = this.ParentForm as MainManagement;
                    var form = parent.FindChildForm<ShowTeam>(this.DataRowItem, "Name");
                    if (form != null)
                        form.Close();

                    //Luu thay doi va kiem tra co loi khi xoa khong (Thang)
                    return this.checkException();
                }
            }
            return false;
        }
	    // Bat exception khi xoa 1 Team item da tham gia tran dau (thang)
        private bool checkException()
        {
            try
            {   
                this.DataRowItem.Delete();
                //this.ParentListControl.tableAdapterManager.TeamTableAdapter.Update(this.ParentListControl.leagueDatabaseDataSet);
                this.ParentListControl.tableAdapterManager.TeamTableAdapter.Update(this.DataRowItem);
                this.ParentListControl.leagueDatabaseDataSet.AcceptChanges();
                //this.ParentListControl.LoadDataFromTable();

                return true;
            }
            catch (SqlException ex)
            {
                DialogResult dresult = 0;
                foreach (var error in ex.Errors)
                {
                    switch ((error as SqlError).Number)
                    {
                        case 547:
                            {
                                if ((error as SqlError).Message.Contains("FK__Match__Home"))
                                {
                                    dresult = this.Exception_FK_Match_Home((error as SqlError).Message);
                                    break;
                                }
                                break;
                            }
                        case 50000:
                            {
                                if ((error as SqlError).Procedure == "TeamJoinTour_Delete")
                                {
                                    dresult = this.Exception_Procedure_TeamJoinTour_Delete("Can't delete team has played at least a match");
                                    break;
                                }
                                break;
                            }                        
                    }
                }
                this.ParentListControl.leagueDatabaseDataSet.RejectChanges();
                return false;
            }
        }
        private DialogResult Exception_FK_Match_Home(string p)
        {
            string msg = "Could not delete team has been in match";
            return MessageBox.Show(msg, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private DialogResult Exception_Procedure_TeamJoinTour_Delete(string p)
        {
            return MessageBox.Show(p, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
