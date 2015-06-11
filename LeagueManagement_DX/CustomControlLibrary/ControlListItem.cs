using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    /// <summary>
    /// Item có thể thiết lập các Properties theo ý muốn. Thêm các Event của "MenuStrip" cho các nút 
    /// thực hiện tùy các loại Item cụ thể.  
    /// </summary>
    public partial class ControlListItem : UserControl
    {
        #region Properties
        public string ItemName { get; set; }
        public bool Selected { get; set; }
        public bool Hovered { get; set; }
        public Color HoverColor { get; set; }
        public Color SelectColor { get; set; }
        public Color NormalColor { get; set; }
        public ControlList ParentListControl { get; set; }
        public int ID { get; set; }

        public DataRow DataRowItem { get; set; }

        public ContextMenuStrip MenuStrip
        {
            get { return menuStrip; }
        }
        #endregion

        public ControlListItem()
        {
            
        }

        public ControlListItem(ControlList listcontrol)
        {
            InitializeComponent();
            this.Selected = false;
            this.Hovered = false;
            this.ItemName = "Unknown.";
            
            this.HoverColor = Color.WhiteSmoke;
            this.NormalColor = Color.WhiteSmoke;
            this.SelectColor = Color.WhiteSmoke;

            this.BackColor = this.SelectColor;

            this.MouseClick += ControlListItem_MouseClick;
            //this.MouseHover += ControlListItem_MouseHover;
            //this.MouseLeave += ControlListItem_MouseLeave;
            //this.MouseMove += ControlListItem_MouseMove;

            this.ParentListControl = listcontrol;
            
            //INIT MenuStrip
            menuStrip.ItemClicked += menuStrip_ItemClick;
        }


        private void ControlListItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Bounds.Contains(e.Location.X, e.Location.Y + this.Location.Y))
            {
                ControlListItem_MouseHover(sender, e);
            }
        }
        private void menuStrip_ItemClick(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        public void UpdateColor()
        {
            if (!this.Hovered && !this.Selected && this.BackColor != NormalColor)
            {
                this.BackColor = this.NormalColor;
            }

            if (this.Selected && BackColor != SelectColor)
            {
                this.BackColor = this.SelectColor;
            }

            if (this.Hovered && !this.Selected && BackColor != HoverColor)
            {
                this.BackColor = this.HoverColor;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.Hovered = true;
            this.UpdateColor();

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Hovered = false;
            this.UpdateColor();

            base.OnMouseLeave(e);
        }

        protected void ControlListItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ParentListControl.flowLayoutPanel.Controls.Count > 0)
            {
                for (int i = 0; i < this.ParentListControl.flowLayoutPanel.Controls.Count; i++)
                {
                    var control = this.ParentListControl.flowLayoutPanel.Controls[i] as ControlListItem;
                    if (control == null || control == this) continue;

                    control.Selected = false;
                    control.UpdateColor();
                }
            }

            this.Selected = true;
            this.UpdateColor();

            if (e.Button == MouseButtons.Right)
            {
                menuStrip.Show(System.Windows.Forms.Cursor.Position);
            }
        }

        protected void ControlListItem_MouseHover(object sender, EventArgs e)
        {
            this.Hovered = true;
            this.UpdateColor();
        }

        protected void ControlListItem_MouseLeave(object sender, EventArgs e)
        {
            this.Hovered = false;
            this.UpdateColor();
        }

        public virtual void RemoveData()
        {
        }

        public virtual void ReloadDataEdited()
        {
        }
    }
}
