using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LeagueManagement_DX.Forms;
using System.IO;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public partial class TourControlListItem : ControlListItem
    {
        public TourControlListItem(ControlList listcontrol, LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow tourrow) : base(listcontrol)
        {
            //Init
            this.NormalColor = Color.Gainsboro;
            this.SelectColor = Color.DodgerBlue;
            this.HoverColor = Color.SkyBlue;
            this.BackColor = this.NormalColor;

            //Designer
            InitializeComponent();

            //DATA ROW
            this.DataRowItem = tourrow;
            this.ItemName = this.DataRowItem["TourName"].ToString();
            this.Name = this.DataRowItem["Id"].ToString();
            //LABEL
            this.tourItemName.Text = this.ItemName;

            //BUTTON
            this.MouseDoubleClick += TourListControlItem_MouseDoubleClick;
            this.MouseHover += MourListControlItem_Hover;
            this.MouseLeave += MourListControlItem_Leave;

            //MENU STRIP
            this.MenuStrip.ItemClicked += MenuStrip_ItemClick;
            this.Name = "tourItem" + tourrow.Id.ToString();
        }

        private void MourListControlItem_Leave(object sender, EventArgs e)
        {

        }

        private void MourListControlItem_Hover(object sender, EventArgs e)
        {

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
                var contextMenuStrip = sender as ContextMenuStrip;
                if (contextMenuStrip != null) contextMenuStrip.Hide();

                var rs = MessageBox.Show("Delete tour make lose all of data in that tour.\nDo you want to continue?", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (rs == DialogResult.OK)
                {

                    string name = this.DataRowItem["TourName"].ToString();
                    var parent = this.ParentForm as MainManagement;
                    if (parent != null)
                    {
                        //var form = parent.FindChildForm<TourManagement>(this.DataRowItem, "TourName");
                        var form = parent.FindChildForm(name);
                        if (form != null)
                            form.Close();
                    }
                    this.removeImage(this.DataRowItem["Avatar"].ToString());
                    //Xóa control trước sau đó mới tìm tab để đóng
                    this.ParentListControl.RemoveSelected();
                    


                    
                    
                }
            }
            else if (e.ClickedItem == editItem)
            {
                //SETTING TOUR GO HERE...
                //truyền row vô cho trường hợp sửa thông tin giải.
                var addTour = this.ParentListControl.AddForm as AddTour;
                if (addTour != null)
                {
                    //dispose hình
                    string name = this.DataRowItem["TourName"].ToString();
                    int id = Convert.ToInt32(this.DataRowItem["Id"]);
                    var parent = this.ParentForm as MainManagement;
                    TourManagement form = null;
                    if (parent != null)
                    {
                        form = parent.FindChildForm(name) as TourManagement;
                        if (form != null)
                        {
                            if (form.Image != null)
                                form.Image.Dispose();
                        }
                    }

                    //edit
                    addTour.TourRow = this.DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow;
                    addTour.Text = this.DataRowItem["TourName"].ToString();
                    this.ParentListControl.AddListItem(); //Edit this
                    //foreach (TourControlListItem control in this.ParentListControl.flowLayoutPanel.Controls)
                    //{
                    //    control.Selected = false;
                    //    control.UpdateColor();
                    //}
                    //this.Selected = true;
                    //this.UpdateColor();
                    //reload form
                    this.ParentListControl.SetSelectedItem(id);
                    if (form != null)
                    {
                        //DataView dv = form.TourRow.Table.DefaultView;
                        //dv.RowFilter = "Id = " + id.ToString();
                        //form.TourRow = dv[0].Row as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow;
                        form.Refresh();
                    }
                }
            }
        }

        private void OpenItem()
        {
            var parent = this.ParentForm as MainManagement;
            var form = parent.FindChildForm<TourManagement>(this.DataRowItem, "TourName"); //tìm xem có form nào được mở ứng với row này
            if (form == null) //không tìm được thì mở form mới
                this.ParentListControl.ShowItemDetail(this.DataRowItem);//hàm này mới viết thêm
            else
                form.Focus(); // tìm được thì focus
        }

        private void TourListControlItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenItem();
        }

        public override void RemoveData()
        {
            base.RemoveData();

            if (DataRowItem != null)
            {
                this.DataRowItem.Delete();
                this.ParentListControl.tableAdapterManager.ToursTableAdapter.Update(this.ParentListControl.leagueDatabaseDataSet);
                this.ParentListControl.leagueDatabaseDataSet.AcceptChanges();
            }
        }
        private void removeImage(string stringpath)
        {
            if (File.Exists(stringpath))
            {
                File.Delete(stringpath);
            }
        }
    }
}
