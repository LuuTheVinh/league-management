using System;
using System.Data;
using System.Drawing;
using System.IO;
using DevExpress.Office.Utils;
using LeagueManagement_DX.Properties;
using LeagueManagement_DX.Forms;

namespace LeagueManagement_DX.CustomControlLibrary
{
    class FootballerControlListItemSmall : ControlListItem
    {
        private System.Windows.Forms.Label shirtNum;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl nameFootballer;
        private LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter teamDetailTableAdapter;
        private System.Windows.Forms.PictureBox avatarFootballer;
    
        public FootballerControlListItemSmall(ControlList teamlist, DataRow footballerrow)
            : base(teamlist)
        {
            this.NormalColor = Color.WhiteSmoke;
            this.SelectColor = Color.DodgerBlue;
            this.HoverColor = Color.SkyBlue;
            this.BackColor = this.NormalColor;

            InitializeComponent();

            this.DataRowItem = footballerrow;
            this.nameFootballer.Text = this.DataRowItem["Name"].ToString();
            this.shirtNum.Text = this.DataRowItem["ShirtNumber"].ToString();

            if (File.Exists(footballerrow["Avatar"].ToString()))
                this.avatarFootballer.Image = Image.FromHbitmap(new Bitmap(footballerrow["Avatar"].ToString()).GetHbitmap());
                //this.avatarFootballer.Image = Image.FromFile(footballerrow["Avatar"].ToString());
            else
                this.avatarFootballer.Image = Image.FromHbitmap(Resources.man_icon.GetHbitmap());

            //BUTTON
            this.MouseDoubleClick += FootballerListControlItem_MouseDoubleClick;

            //MENU STRIP
            this.MenuStrip.ItemClicked += MenuStrip_ItemClick;
            //Nghia-Edit
            this.MenuStrip.Items.RemoveAt(2);
            //this.nameFootballer.BackColorChanged += NameFootballerOnBackColorChanged;

            this.Name = "footballerItem" + footballerrow["Id"].ToString();
        }

        public FootballerControlListItemSmall(ControlList teamlist, LeagueDatabaseDataSet.FootballerRow footballerrow)
            : base(teamlist)
        {
            this.NormalColor = Color.WhiteSmoke;
            this.SelectColor = Color.DodgerBlue;
            this.HoverColor = Color.SkyBlue;
            this.BackColor = this.NormalColor;

            InitializeComponent();

            teamDetailTableAdapter.Fill(teamlist.leagueDatabaseDataSet.TeamDetail);

            this.DataRowItem = footballerrow;
            this.nameFootballer.Text = this.DataRowItem["Name"].ToString();


            foreach (var teamdetail in teamlist.leagueDatabaseDataSet.TeamDetail)
            {
                if (teamdetail.PlayerId == footballerrow.Id)
                {
                    this.shirtNum.Text = teamdetail.ShirtNumber.ToString();
                }
            }

            
            this.avatarFootballer.Image = Image.FromHbitmap(Resources.man_icon.GetHbitmap());

            //BUTTON
            this.MouseDoubleClick += FootballerListControlItem_MouseDoubleClick;

            //MENU STRIP
            this.MenuStrip.ItemClicked += MenuStrip_ItemClick;
            //Nghia-Edit
            this.MenuStrip.Items.RemoveAt(2);
            this.Name = "footballerItem" + footballerrow["Id"].ToString();

            
        }

        private void NameFootballerOnBackColorChanged(object sender, EventArgs eventArgs)
        {
            //this.nameFootballer.BackColor = this.BackColor;
        }

        public void MenuStrip_ItemClick(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == infoItem)
            {
                this.ParentListControl.ShowItemDetail();
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

        private void FootballerListControlItem_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.ParentForm.IsMdiContainer == false)
            {
                this.ParentListControl.ShowItemDetail();
            }
            else //khi click ở trong TourManagemment
            {
                var parent = this.ParentForm as MainManagement;
                var form = parent.FindChildForm<ShowFootballer>(this.DataRowItem, "Name"); //tìm xem có form nào được mở ứng với row này
                if (form == null) //không tìm được thì mở form mới
                    this.ParentListControl.ShowItemDetail();//hàm này mới viết thêm
                else
                    form.Focus(); // tìm được thì focus
            }
        }

        public override void RemoveData()
        {
            //base.RemoveData();
            //if (DataRowItem != null)
            //{
            //    this.DataRowItem.Delete();
            //    this.ParentListControl.tableAdapterManager.FootballerTableAdapter.Update(this.ParentListControl.leagueDatabaseDataSet);
            //    this.ParentListControl.leagueDatabaseDataSet.AcceptChanges();
            //}
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.shirtNum = new System.Windows.Forms.Label();
            this.avatarFootballer = new System.Windows.Forms.PictureBox();
            this.nameFootballer = new DevExpress.XtraEditors.LabelControl();
            this.teamDetailTableAdapter = new LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters.TeamDetailTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarFootballer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.shirtNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(550, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 35);
            this.panel1.TabIndex = 4;
            // 
            // shirtNum
            // 
            this.shirtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shirtNum.AutoSize = true;
            this.shirtNum.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.shirtNum.Enabled = false;
            this.shirtNum.Font = new System.Drawing.Font("UTM Avo", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shirtNum.Location = new System.Drawing.Point(-2, -8);
            this.shirtNum.Name = "shirtNum";
            this.shirtNum.Size = new System.Drawing.Size(40, 46);
            this.shirtNum.TabIndex = 3;
            this.shirtNum.Text = "4";
            this.shirtNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatarFootballer
            // 
            this.avatarFootballer.Dock = System.Windows.Forms.DockStyle.Left;
            this.avatarFootballer.Enabled = false;
            this.avatarFootballer.InitialImage = null;
            this.avatarFootballer.Location = new System.Drawing.Point(0, 0);
            this.avatarFootballer.Name = "avatarFootballer";
            this.avatarFootballer.Size = new System.Drawing.Size(35, 35);
            this.avatarFootballer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarFootballer.TabIndex = 0;
            this.avatarFootballer.TabStop = false;
            // 
            // nameFootballer
            // 
            this.nameFootballer.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameFootballer.Enabled = false;
            this.nameFootballer.Location = new System.Drawing.Point(41, 11);
            this.nameFootballer.Name = "nameFootballer";
            this.nameFootballer.Size = new System.Drawing.Size(43, 13);
            this.nameFootballer.TabIndex = 5;
            this.nameFootballer.Text = "No Name";
            // 
            // teamDetailTableAdapter
            // 
            this.teamDetailTableAdapter.ClearBeforeFill = true;
            // 
            // FootballerControlListItemSmall
            // 
            this.Controls.Add(this.nameFootballer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.avatarFootballer);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FootballerControlListItemSmall";
            this.Size = new System.Drawing.Size(600, 35);
            this.BackColorChanged += new System.EventHandler(this.NameFootballerOnBackColorChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarFootballer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
