using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary;
using DevExpress.Data;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using LeagueManagement_DX.CustomControlLibrary;
using LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters;
using LeagueManagement_DX.Properties;
using DevExpress.XtraTabbedMdi;
using System.IO;

namespace LeagueManagement_DX.Forms
{
    public partial class MainManagement : DevExpress.XtraEditors.XtraForm
    {
        //int _currentUserLevel;
       // UserDataset.UserDetailDataTable _userTable;
        //UserDataset.GroupUserDataTable _groupTable;
        DataRow _userDetail;
        int _username;
        Image _currentUserAvatar;
        public MainManagement()
        {
            InitializeComponent();
            //_currentUserLevel = 0;
            this.pictureEditUserAvatar.ContextMenuStrip = new ContextMenuStrip();
            this.pictureEditUserAvatar.Properties.AllowScrollViaMouseDrag = false;
        }

        [System.STAThread]
        public static void ThreadProcess()
        {
            //LoginForm _loginForm;
            //System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA);
            Application.Run(new MainManagement());
        }
        private void LoadAcessLevel()
        {
            if (UserAccessLevel.Instance.GetAccessLevel <= 2)
            {
                //this.xtraTabAccount.PageEnabled = false;
                this.settingBtn.Enabled = false;
                if (UserAccessLevel.Instance.GetAccessLevel == 1)
                {
                    this.addTeamBtn.Enabled = false;
                    this.addTourBtn.Enabled = false;
                    this.editTeamBtn.Enabled = false;
                    this.editTourBtn.Enabled = false;
                    this.deleteTeamBtn.Enabled = false;
                    this.deleteTourBtn.Enabled = false;
                    this.settingBtn.Enabled = false;
                    this.typeGoalsBtn.Enabled = false;
                }

            }
        }

        private void MainManagement_Load(object sender, EventArgs e)
        {
            xtraTabControl.SelectedTabPage = xtraTabTours;
            
            tourList.LoadDataFromTable();
            teamList.LoadDataFromTable();

            CheckMDIChild();
#if !DEBUG
            using (LoginForm _loginForm = new LoginForm())
            {
                DialogResult _dresult = _loginForm.ShowDialog();
                if (_dresult == System.Windows.Forms.DialogResult.Cancel)
                    this.Close();
                else
                {
                    // 7ung
                    // xoá nút chuột phải khi user có quyền thấp nhất
                    foreach (TourControlListItem item in tourList.flowLayoutPanel.Controls)
                    {
                        if (UserAccessLevel.Instance.GetAccessLevel == 1)
                        {
                            item.MenuStrip.Items.RemoveByKey("deleteItem");
                            item.MenuStrip.Items.RemoveByKey("editItem");
                        }
                        
                        else
                        {
                            if (item.MenuStrip.Items.Find("editItem", true).Length == 0)
                            {
                                var menustripItem = new ToolStripMenuItem("Edit") { Name = "editItem" };
                                item.MenuStrip.Items.Add(menustripItem);
                            }                  
                            if (item.MenuStrip.Items.Find("deleteItem", true).Length == 0)
                            {
                                var menustripItem = new ToolStripMenuItem("Delete") { Name = "deleteItem" };
                                item.MenuStrip.Items.Add(menustripItem);
                            }
                        }
                    }
                    //nghia-Add
                    teamList.SetLevelAccess(UserAccessLevel.Instance.GetAccessLevel);

                    //-------

                    _username = Convert.ToInt32(_loginForm.TransferUserInfo["Username"]);
                    this.userDetailTableAdapter.Fill(this.userDataset.UserDetail);
                    _userDetail = this.userDataset.UserDetail.FindByUsername(_username);
                    this.LoadAcessLevel();
                    this.labelControlName.Text = _userDetail["FullName"].ToString();
                    this.labelControlDateOfBirth.Text = _userDetail["DateOfBirth"].ToString();
                    this.labelControlLastLogin.Text = _userDetail["LastLogin"].ToString();
                    this.labelControlGroup.Text = Convert.ToString(groupUserTableAdapter.GetGroupName(Convert.ToInt32(_userDetail["Username"])));
                    this.WindowState = FormWindowState.Maximized;
                    if (File.Exists(_userDetail["Avatar"].ToString()))
                        this.pictureEditUserAvatar.Image = Image.FromFile(_userDetail["Avatar"].ToString());
                    this._currentUserAvatar = this.pictureEditUserAvatar.Image;
                    //this.pictureEditUserAvatar.Image = Image.FromFile(Application.StartupPath + @"\Image\User\" + Convert.ToString(_userDetail["Avatar"]) + ".jpg");
                    //this.pictureEditUserAvatar.Properties.SizeMode = PictureSizeMode.Stretch;
                }
                
            }
#endif
            //VINH EDIT
            SearchPage_Load();
            playerGridPreview1.ReloadPlayers();
            Player_Load();
            PlayerPageAccessLevel_Load();

        }
        public void Reload_AfterEdit()
        {
            teamList.LoadDataFromTable();
            SearchPage_Load();
            Reload_PlayerGrid();
            CheckMDIChild();
        }
        public void Reload_PlayerGrid()
        {
            playerGridPreview1.ReloadPlayers();
            Player_Load();
        }
        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControl.SelectedPage == toursPage)
            {
                xtraTabControl.SelectedTabPage = xtraTabTours;
                //Load lai cac du lieu neu da edit
                tourList.LoadDataFromTable();
            }
            else if (ribbonControl.SelectedPage == teamsPage)
            {
                xtraTabControl.SelectedTabPage = xtraTabTeams;
                //Load lai
                if (UserAccessLevel.Instance.GetAccessLevel != 1)
                {
                    teamList.LoadDataFromTable();
                }
            }
            else if (ribbonControl.SelectedPage == searchPage)
            {
                xtraTabControl.SelectedTabPage = xtraTabSearch;
                //Load lai
                TeamCheckedComboBox_Load();
            }
            else if (ribbonControl.SelectedPage == accountPage)
            {
                xtraTabControl.SelectedTabPage = xtraTabAccount;
            }
            else if (ribbonControl.SelectedPage == playersPage)
            {
                xtraTabControl.SelectedTabPage = xtraTabPlayer;
            }

            CheckMDIChild();
        }

        private void ribbonControl_SelectedPageChanging(object sender, RibbonPageChangingEventArgs e)
        {
            
        }
        private int count = 0;

        private void addTourBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tourList.AddListItem();
        }
        private void xtraTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl.SelectedTabPage == xtraTabTours)
            {
                ribbonControl.SelectedPage = toursPage;
            }
            else if (xtraTabControl.SelectedTabPage == xtraTabTeams)
            {
                ribbonControl.SelectedPage = teamsPage;
            }
            else if (xtraTabControl.SelectedTabPage == xtraTabSearch)
            {
                ribbonControl.SelectedPage = searchPage;
            }
            else if (xtraTabControl.SelectedTabPage == xtraTabAccount)
            {
                ribbonControl.SelectedPage = accountPage;
            }
            else if (xtraTabControl.SelectedTabPage == xtraTabPlayer)
            {
                ribbonControl.SelectedPage = playersPage;
            }
        }

        private void addTeamBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            teamList.AddListItem();
        }

        private void settingBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new AccountSetting(this._username);
            form.MdiParent = this;
            if (this.pictureEditUserAvatar.Image != null)
                this.pictureEditUserAvatar.Image.Dispose();
            form.Show();
            
            
        }

        private void deleteTourBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selecteditem = tourList.GetSelected();
            if (selecteditem == null)
                return;
            var tourrow = selecteditem.DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow;

            var rs = MessageBox.Show("Delete tour make lose all of data in that tour.\nDo you want to continue?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.OK)
            {
                var form = this.FindChildForm<TourManagement>(tourrow, "TourName") as TourManagement;
                if (form != null)
                {
                    form.RemoveImage();
                    form.Close();
                }
                tourList.RemoveSelected();
            }

        }

        private void deleteTeamBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            teamList.RemoveSelectedItem();
        }

        private void signInBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure you wish to sign out League Management?", "Waring", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
               // System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA);
                System.Threading.Thread _thread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcess));
                _thread.SetApartmentState(System.Threading.ApartmentState.STA);
                _thread.Start();
                this.Close();
                
            }
        }

        public void ShowAddTourForm()
        {
            tourList.AddListItem();
        }
        public void ShowAddTourForm(DataRow _tourRow)
        {
            int id = (_tourRow as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow).Id;
            (tourList.AddForm as AddTour).TourRow = _tourRow as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow;
            tourList.AddListItem();
            tourList.SetSelectedItem(id);
        }   

        public void RemoveTourRow(DataRow _tourRow)
        {
            this.tourList.Remove(_tourRow["Id"].ToString());
            _tourRow.BeginEdit();
            _tourRow.Delete();
            _tourRow.EndEdit();
            tourList.tableAdapterManager.ToursTableAdapter.Update(_tourRow);
            tourList.LoadDataFromTable();//
            _tourRow.Table.AcceptChanges();
        }
        
        /// <summary>
        /// Tìm trong mdichild có form nào có text trùng với cột columnName của Row không
        /// </summary>
        /// <typeparam name="T">các form kế thừa từ XtraForm</typeparam>
        /// <param name="_dataRow">row muốn so sánh</param>
        /// <param name="columnName">tên cột có trong datarow mà muốn so sánh với text của form</param>
        /// <returns>trả về form</returns>
        public T FindChildForm<T> (DataRow _dataRow, string columnName)
        {
            if (typeof(T).BaseType != typeof(XtraForm))
                throw new Exception("T of Generic type must inherited from XtraForm");
            foreach (var item in this.MdiChildren)
            {
                if ((item is T) == false)
                    continue;
                if (item.Text == _dataRow[columnName].ToString())
                    return (T)Convert.ChangeType(item, typeof(T));
            }
            return (T)Convert.ChangeType(null, typeof(T));
        }//xem ví dụ cách sử dụng trong TourControlListItem.css

        public XtraForm FindChildForm(string text)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Text == text)
                    return item as XtraForm;
            }
            return null;
        }
        private void createMatchBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.SelectMatchTab(false);
        }

        private void deleteMatchBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.SelectMatchTab(true);
        }
        private void SelectMatchTab(bool IsDeleteMatch)
        {
            if (this.xtraTabbedMdiManager1.SelectedPage == null)
                return;
            string text = this.xtraTabbedMdiManager1.SelectedPage.Text;
            this.toursTableAdapter.Fill(leagueDatabaseDataSet.Tours);
            foreach (var touritem in this.leagueDatabaseDataSet.Tours)
            {
                if (text != touritem["TourName"].ToString())
                    continue;
                var form = this.FindChildForm(text) as TourManagement;
                form.SelectMatchTabPage(IsDeleteMatch);
            }
        }



        private void teamJoinTourBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var page = (this.xtraTabbedMdiManager1.SelectedPage);
            if (page == null) return;
            if ((page.MdiChild is TourManagement) == false)
                return;
            var row = (this.xtraTabbedMdiManager1.SelectedPage.MdiChild as TourManagement).TourRow;
            var regisform = new RegisterForm(row);
            regisform.Text = row.TourName;
            regisform.ShowDialog();
            (this.xtraTabbedMdiManager1.SelectedPage.MdiChild as TourManagement).ReloadTeamList();
        }

        private void editTourBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var item = tourList.GetSelected();
            if (item == null)
                    return;
            var tourrow = item.DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow;
            int id = tourrow.Id;
            var form = this.FindChildForm<TourManagement>(tourrow, "TourName");
            if (form != null)
            {
                if (form.Image != null)
                    form.Image.Dispose();
                form.Focus();
            }
            (this.tourList.AddForm as AddTour).TourRow = tourrow;
            //(this.tourList.AddForm as AddTour).TourRow = form.TourRow;
            (this.tourList.AddForm as AddTour).Text = tourrow.TourName;
            this.ShowAddTourForm(tourrow);

            if (form != null)
            {
                form.Refresh();
            }
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            var tabpage = this.xtraTabbedMdiManager1.SelectedPage as XtraMdiTabPage;
            SetSelectedItem(tabpage);

            if (UserAccessLevel.Instance.GetAccessLevel == 1)
            {
                return;
            }
            
            if (tabpage == null)
            {
                this.teamJoinTourBtn.Enabled = false;
                this.createMatchBtn.Enabled = false;
                this.deleteMatchBtn.Enabled = false;
                this.deleteTeamInTour.Enabled = false;
                this.updateResultBtn.Enabled = false;
                return;
            }

            //tabpage.MdiChild.MouseClick += MdiChildOnMouseClick;
            

            if ((tabpage.MdiChild is TourManagement) == false)
            {
                this.teamJoinTourBtn.Enabled = false;
                this.createMatchBtn.Enabled = false;
                this.deleteMatchBtn.Enabled = false;
                this.deleteTeamInTour.Enabled = false;
                this.updateResultBtn.Enabled = false;
            }
            else
            {
               // var control = this.tourList.flowLayoutPanel.Controls.Find("tourItem"+(tabpage.MdiChild as TourManagement).TourRow.Id, true);
                this.createMatchBtn.Enabled = true;
                this.deleteMatchBtn.Enabled = ((tabpage.MdiChild as TourManagement).TabPage.Name == "matchTabPage") ? true : false;
                this.teamJoinTourBtn.Enabled = true;
                this.deleteTeamInTour.Enabled =  ((tabpage.MdiChild as TourManagement).TabPage.Name == "teamTabPage")?true:false;
                this.updateResultBtn.Enabled = true;
                if ((tabpage.MdiChild as TourManagement).TabPage.Name == "teamTabPage")
                {
                    (tabpage.MdiChild as TourManagement).ReloadTeamList();
                }
            }
        }

        private void MdiChildOnMouseClick(object sender, MouseEventArgs mouseEventArgs)
        {
            //VINH
            SetSelectedItem(sender as XtraMdiTabPage);
        }

        //VINH
        private void SetSelectedItem(XtraMdiTabPage tabPage)
        {
            if (tabPage == null) return;

            if (tabPage.MdiChild is TourManagement)
            {
                var tourTab = tabPage.MdiChild as TourManagement;
                ribbonControl.SelectedPage = toursPage;
                tourList.SetSelectedItem(tourTab.TourRow.Id);
            }
            else if (tabPage.MdiChild is ShowTeam)
            {
                ribbonControl.SelectedPage = teamsPage;
                var teamTab = tabPage.MdiChild as ShowTeam;
                teamList.SetSelectedItem(teamTab.teamDataRow.Id);
            }
            else if (tabPage.MdiChild is ShowFootballer)
            {
                ribbonControl.SelectedPage = playersPage;
                var playerTab = tabPage.MdiChild as ShowFootballer;
                playerGridPreview1.SetSelectedRow(int.Parse(playerTab._footballerInfo["Id"].ToString()));
            }

        }

        //Nghia-edit
        // moi them vao (Thang)
        public void ShowAddTeamForm()
        {
            var item = teamList.GetSelected();
            if (item == null)
                return;
            var teamrow = item.DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow;

            var form = this.FindChildForm<ShowTeam>(teamrow, "Name") as ShowTeam;
            if (form != null)
            {
                form.Close();
            }
            teamList.ShowAddForm(teamrow as LeagueManagement_DX.LeagueDatabaseDataSet.TeamRow);
            
            SearchPage_Load();
            playerGridPreview1.ReloadPlayers();
            Player_Load();
            FormCollection formCollec = Application.OpenForms; //["TourManagement"];
            foreach (Form frm in formCollec)
            {
                if (frm.Name == "TourManagement")
                {
                    (frm as TourManagement).ReloadTeamMatchStandingTab();
                }
            }
        }
        //moi them vao (Thang)
        private void editTeamBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ShowAddTeamForm();
        }

        //VINH EDIT
        private void SearchPage_Load()
        {
            //itemTeamCheckedComboBox
            TeamCheckedComboBox_Load();
            
            itemTeamCheckedComboBox.EditValueChanged += ItemTeamCheckedComboBoxOnEditValueChanged;

            //Player Search
            itemPlayerSearchControl.EditValueChanged += ItemPlayerSearchControlOnEditValueChanged;

            //Position
            itemPositionCheckedComboBox.Items.AddRange(
                new object[]
                {
                    "CF",
                    "RW",
                    "SS",
                    "LW",
                    "AM",
                    "RM",
                    "CM",
                    "LM",
                    "RWB",
                    "DM",
                    "LWB",
                    "RB",
                    "CB",
                    "LB",
                    "SW",
                    "GK"
                });
            itemPositionCheckedComboBox.EditValueChanged += ItemPositionCheckedComboBoxOnEditValueChanged;

            //Nation
            itemNationCheckedComboBox.EditValueChanged += ItemNationCheckedComboBoxOnEditValueChanged;
        }

        private void TeamCheckedComboBox_Load()
        {
            itemTeamCheckedComboBox.Items.Clear();
            itemTeamCheckedComboBox.Items.Add("No Team");

            //teamTableAdapter.Fill(leagueDatabaseDataSet.Team);
            foreach (var team in teamTableAdapter.GetData())
            {
                itemTeamCheckedComboBox.Items.Add(team.Name);

                var players = footballerTableAdapter.GetFooballerByTeamId(team.Id);
                foreach (var player in players)
                {
                    bool canadd = true;
                    for (int index = 0; index < itemNationCheckedComboBox.Items.Count; index++)
                    {
                        var item = itemNationCheckedComboBox.Items[index];
                        if (item.ToString() == player.Nation.TrimEnd(' '))
                        {
                            canadd = false;
                            break;
                        }
                    }

                    if (canadd)
                        itemNationCheckedComboBox.Items.Add(player.Nation.TrimEnd(' '));
                }
            }
        }

        private void ItemNationCheckedComboBoxOnEditValueChanged(object sender, EventArgs eventArgs)
        {
            playerGrid.GridView.Columns["Nation"].FilterInfo = new ColumnFilterInfo();
            
            if (itemNationCheckedComboBox.GetCheckedItems().ToString() == "") return;

            var checkedItems = itemNationCheckedComboBox.GetCheckedItems().ToString().Replace(", ", "' OR [Nation]='");
            playerGrid.GridView.Columns["Nation"].FilterInfo = new ColumnFilterInfo("[Nation]='" + checkedItems + "'");
        }

        private void ItemPositionCheckedComboBoxOnEditValueChanged(object sender, EventArgs eventArgs)
        {
            playerGrid.GridView.Columns["Position"].FilterInfo = new ColumnFilterInfo();

            if (itemPositionCheckedComboBox.GetCheckedItems().ToString() == "") return;

            var checkedItems = itemPositionCheckedComboBox.GetCheckedItems().ToString().Replace(", ", "' OR [Position]='");
            playerGrid.GridView.Columns["Position"].FilterInfo = new ColumnFilterInfo("[Position]='" + checkedItems + "'");
        }

        private void ItemTeamCheckedComboBoxOnEditValueChanged(object sender, EventArgs eventArgs)
        {
            playerGrid.ClearGrid();
            ResetPlayerSearchOptions();

            var checkedItems = itemTeamCheckedComboBox.GetCheckedItems().ToString().Replace(", ", "|").Split('|');
            foreach (var checkedItem in checkedItems)
            {
                playerGrid.LoadAllPlayer(checkedItem);
            }
            
        }

        private void ItemPlayerSearchControlOnEditValueChanged(object sender, EventArgs eventArgs)
        {
            var searchControl = sender as SearchControl;
            if (searchControl != null)
            {
                searchControl.RefreshEditValue();
                var value = searchControl.Text;
                if (value != "")
                {
                    playerGrid.GridView.Columns["Name"].FilterInfo = new ColumnFilterInfo("[Name] LIKE '%" + value + "%'");
                }
                else
                {
                    playerGrid.GridView.Columns["Name"].FilterInfo = new ColumnFilterInfo();
                }
            }

           
        }

        private void updateResultBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tourList == null) return;

            var selected = tourList.GetSelected();
            if(selected == null) return;


            //var tourrow = tourList.GetSelected().DataRowItem as LeagueDatabaseDataSet.ToursRow;
            //if (tourrow == null) return;

            var tourManagement = this.xtraTabbedMdiManager1.SelectedPage.MdiChild as TourManagement;

            //var tourManagement = this.FindChildForm<TourManagement>(tourrow, "TourName");
            if (tourManagement == null) return;

            var updateResultForm = new AddResultForm(tourManagement.TourRow);
            updateResultForm.ShowDialog();
        }

        private void ResetPlayerSearchOptions()
        {
            comboPosition.EditValue = "";
            comboNation.EditValue = "";
            namePlayerSearch.EditValue = "";


            //Reset Filter
            for (int i = 0; i < playerGrid.GridView.Columns.Count; i++)
            {
                playerGrid.GridView.Columns[i].FilterInfo = new ColumnFilterInfo();
            }

            //Sort
            playerGrid.GridView.Columns["Name"].SortOrder = ColumnSortOrder.None;
            //playerGrid.GridView.Columns["Team"].SortOrder = ColumnSortOrder.None;
            playerGrid.GridView.Columns["Nation"].SortOrder = ColumnSortOrder.None;
            playerGrid.GridView.Columns["Goals"].SortOrder = ColumnSortOrder.None;
        }
        private void deleteTeamInTour_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.xtraTabbedMdiManager1.SelectedPage == null)
                return;
            var currenTourmanagement = this.xtraTabbedMdiManager1.SelectedPage.MdiChild as TourManagement;
            if (currenTourmanagement == null) 
                return;
            currenTourmanagement.RemoveRegistedTeam();

        }


        public void DisableDeleteTeamInTour()
        {
            if (this.deleteTeamInTour.Enabled == true)
                this.deleteTeamInTour.Enabled = false;
        }

        public void EnableDeleteTeamInTour()
        {
            if (UserAccessLevel.Instance.GetAccessLevel == 1)
                return;
            if (this.deleteTeamInTour.Enabled == false)
                this.deleteTeamInTour.Enabled = true;
        }
        public void DisableDeleteMatch()
        {
            if (this.deleteMatchBtn.Enabled == true)
                this.deleteMatchBtn.Enabled = false;
        }

        public void EnableDeleteMatch()
        {
            if (UserAccessLevel.Instance.GetAccessLevel == 1)
                return;            
            if (this.deleteMatchBtn.Enabled == false)
                this.deleteMatchBtn.Enabled = true;
        }

        public void ReloadFootballerList()
        {
            playerGridPreview1.ReloadPlayers();
        }

        private void createPlayerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //footballerList1.AddListItem();

            //VINH EDIT
            //DUNG PLAYER GRID
            var footballerAddForm = new Footballer();
            DialogResult dl = footballerAddForm.ShowDialog();
            if (dl == DialogResult.OK)
                playerGridPreview1.ReloadPlayers();
        }

        private void deletePlayerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Nghia Lam/Vinh Cmt lai
            //var selecteditem = footballerList1.GetSelected();
            //if (selecteditem == null)
            //    return;
            //var footballerRow = selecteditem.DataRowItem as LeagueManagement_DX.LeagueDatabaseDataSet.FootballerRow;

            //var rs = MessageBox.Show("Delete footballer make lose all of data in that footballer.\nDo you want to continue?", "Warning",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //if (rs == DialogResult.OK)
            //{
            //    var form = this.FindChildForm<ShowFootballer>(footballerRow, "Name") as ShowFootballer;
            //    if (form != null)
            //    {
            //        form.Close();
            //    }
            //    footballerList1.RemoveItemDetail();
            //}

            playerGridPreview1.DeleteRowSelected(this);
        }

        private void editPlayerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            playerGridPreview1.ShowItemDetail(true);
        }

        private void Player_Load()
        {
            playerSearchControl.EditValueChanged += PlayerSearchControlOnEditValueChanged;
        }

        private void PlayerPageAccessLevel_Load()
        {
            switch (UserAccessLevel.Instance.GetAccessLevel)
            {
                case 1:
                {
                    createPlayerBtn.Enabled = false;
                    editPlayerBtn.Enabled = false;
                    deletePlayerBtn.Enabled = false;
                    break;
                }
                case 2:
                case 3:
                {
                    createPlayerBtn.Enabled = true;
                    editPlayerBtn.Enabled = true;
                    deletePlayerBtn.Enabled = true;
                    break;
                }
            }
        }

        private void PlayerSearchControlOnEditValueChanged(object sender, EventArgs eventArgs)
        {
            var searchControl = sender as SearchControl;
            if (searchControl != null)
            {
                searchControl.RefreshEditValue();
                var value = searchControl.Text;
                if (value != "")
                {
                    playerGridPreview1.GridView.Columns["Name"].FilterInfo = new ColumnFilterInfo("[Name] LIKE '%" + value + "%'");
                }
                else
                {
                    playerGridPreview1.GridView.Columns["Name"].FilterInfo = new ColumnFilterInfo();
                }
            }
        }

        private void advancedButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl.SelectedPage = searchPage;
        }

        private void MainManagement_MdiChildActivate(object sender, EventArgs e)
        {
            CheckMDIChild();
        }

        private void CheckMDIChild()
        {
            if (this.ActiveMdiChild != null)
            {
                if (ribbonControl.SelectedPage == toursPage || ribbonControl.SelectedPage == teamsPage
                    || ribbonControl.SelectedPage == playersPage || ribbonControl.SelectedPage == accountPage)
                {
                    if (xtraTabControl.Dock != DockStyle.Left) xtraTabControl.Dock = DockStyle.Left;
                }
                else
                {
                    if (xtraTabControl.Dock != DockStyle.Fill) xtraTabControl.Dock = DockStyle.Fill;
                }
            }
            else
            {
                if (xtraTabControl.Dock != DockStyle.Fill) xtraTabControl.Dock = DockStyle.Fill;
            }
        }

        public TourControlListItem GetTourItem()
        {
            return tourList.GetSelected() as TourControlListItem ;
           
        }

        private void aboutUsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var about = new AboutUs();
            about.ShowDialog();
        }

        private void typeGoalsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.tourList.GetSelected() == null)
                return;
            TypeofGoal form = new TypeofGoal(Convert.ToInt32(this.tourList.GetSelected().DataRowItem["Id"]));
            form.ShowDialog();            
        }

    }
}