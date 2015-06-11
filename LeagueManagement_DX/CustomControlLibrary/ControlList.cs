using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LeagueManagement_DX.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    public enum eTypeControlList
    {
        NONE,
        TOUR,
        TEAM,
        FOOTBALLER,
        MATCH,
    }

    public partial class ControlList : XtraUserControl
    {
        /// <summary>
        /// Tham khao
        /// http://www.codeproject.com/Articles/333864/Flexible-List-Control
        /// </summary>
        /// 

        public eTypeControlList ListType { get; set; }

        public FlowLayoutPanel flowLayoutPanel;
        private XtraForm addForm;

        public XtraForm AddForm
        {
            get { return addForm; }
            set { addForm = value; }
        }
        protected XtraForm detailForm;
        public ControlList()
        {
            InitializeComponent();

            flowLayoutPanel = new FlowLayoutPanel
            {
                AutoScroll = true,
                AutoSize = false,
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 0),
                WrapContents = false,
                HorizontalScroll = { Enabled = false},
                BorderStyle = BorderStyle.None,
            };
            this.Controls.Add(flowLayoutPanel);
            this.BorderStyle = BorderStyle.None;
            this.Padding = new Padding(0);

            this.ListType = eTypeControlList.NONE;

            this.SizeChanged += ControlList_SizeChanged;
        }

        private void ControlList_SizeChanged(object sender, EventArgs e)
        {
            UpdateItemSize();
        }

        private void UpdateItemSize()
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                {
                    var control = flowLayoutPanel.Controls[i];
                    if (i == 0)
                    {
                        control.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                        if (flowLayoutPanel.VerticalScroll.Visible == true)
                        {
                            control.Width = flowLayoutPanel.Width - SystemInformation.VerticalScrollBarWidth - control.Margin.Horizontal;
                        }
                        else
                        {
                            control.Width = flowLayoutPanel.Width - control.Margin.Horizontal;
                        }
                    }
                    else
                    {
                        control.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    }
                }
            }

            this.Update();
        }

        public void Add(Control control)
        {
            //Tìm control xem có trong list chưa, có rồi thì return
            var c = this.flowLayoutPanel.Controls.Find(control.Name, true);
            if (c.Length != 0)
            {
                return;
            }

            flowLayoutPanel.Controls.Add(control);
            UpdateItemSize();
        }
        
        public void Remove(Control control)
        {
            flowLayoutPanel.Controls.Remove(control);
            control.Dispose();
            UpdateItemSize();
        }

        //xoá một control dựa trên stringkey
        //nó tự đọng tìm xem control nào có Name = stringkey
        public void Remove(string stringkey)
        {
            var control = flowLayoutPanel.Controls[stringkey] as ControlListItem;
            if (control != null)
            {
                control.RemoveData();
                flowLayoutPanel.Controls[stringkey].Dispose();
                flowLayoutPanel.Controls.RemoveByKey(stringkey);
                UpdateItemSize();
            }
        }
        public void RemoveSelected()
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                {
                    var control = flowLayoutPanel.Controls[i] as ControlListItem;
                    if (control.Selected)
                    {
                        control.RemoveData();
                        this.Remove(control);
                        return;
                    }
                }
            }
        }

        public void SetSelectedItem(ControlListItem selectedItem)
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                {
                    var control = flowLayoutPanel.Controls[i] as ControlListItem;
                    if (control == null) continue;

                    control.Selected = control.Equals(selectedItem);
                    control.UpdateColor();
                }
            }
        }

        public void SetSelectedItem(int id)
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                {
                    var control = flowLayoutPanel.Controls[i] as ControlListItem;
                    if (control == null) continue;

                    control.Selected = int.Parse(control.DataRowItem["Id"].ToString()) == id;
                    control.UpdateColor();
                }
            }
        }

        public virtual void AddListItem()
        {
            if (AddForm != null)
            {
                this.AddForm.ShowDialog();
            }
        }

        public virtual void ShowItemDetail()
        {
            if(detailForm != null)
            {
                detailForm.ShowDialog();
            }
        }
        public void Edit()
        {
        }
        public virtual ControlListItem GetSelected()
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                {
                    var control = flowLayoutPanel.Controls[i] as ControlListItem;
                    if (control.Selected)
                    {
                        return control;
                    }
                }
            }
            return null;
        }

        public virtual void LoadDataFromTable()
        {
            flowLayoutPanel.Controls.Clear();
        }

        //thêm hàm này, đặt virtual để list khác có thể override.
        //throw exception tại cũng k biết viết gì. throw để tự override lại
        public virtual void ShowItemDetail(DataRow dataRow)
        {
            throw new Exception("Override needed");
        }
        public virtual void RemoveSelectedItem()
        {

        }
        public virtual void EditItemDetail()
        {

        }

        public virtual void ReloadItem(int id)
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                {
                    var control = flowLayoutPanel.Controls[i] as ControlListItem;
                    if (control == null) continue;

                    if (int.Parse(control.DataRowItem["Id"].ToString()) == id)
                    {
                        control.ReloadDataEdited();
                        return;
                    }
                }
            }
        }
    }
}
