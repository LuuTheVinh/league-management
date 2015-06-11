using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LeagueManagement_DX.CustomControlLibrary;
namespace LeagueManagement_DX.Forms
{
    public partial class AccountSetting : DevExpress.XtraEditors.XtraForm
    {
        private CreateAccount _createForm;
        private UserDataset.UserDetailDataTable _userDetailTable;
        private UserDataset.GroupUserDataTable _groupUserTable;
        private int _currentUsername;
        public AccountSetting(int username)
        {
            InitializeComponent();
            _createForm = new CreateAccount();
            this._currentUsername = username;
        }

        private void accountList1_Load(object sender, EventArgs e)
        {
            userDetailTableAdapter.Fill(userDataset.UserDetail);
            this._userDetailTable = userDataset.UserDetail;
            groupUserTableAdapter.Fill(userDataset.GroupUser);
            this._groupUserTable = userDataset.GroupUser;

            accountListUser.LoadDataFromTable();

        }

        private void simpleButtonCreateAccount_Click(object sender, EventArgs e)
        {
            DialogResult dresult = this._createForm.ShowDialog();
            if (dresult == System.Windows.Forms.DialogResult.OK)
            {
                this.accountListUser.LoadDataFromTable();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please re-login if you have modified anything", "Warning", MessageBoxButtons.OK);
            this.Close();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            var item = this.accountListUser.GetSelected();
            if (item != null)
            {
                if (Convert.ToInt32(item.DataRowItem["Username"]) == this._currentUsername)
                {
                    MessageBox.Show("Cannot delete account that being logged", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    this.userDetailTableAdapter.Fill(this.userDataset.UserDetail);
                    DataRow deleteRow = this.userDataset.UserDetail.FindByUsername(Convert.ToInt32(item.DataRowItem["Username"]));
                    deleteRow.Delete();
                    this.userDetailTableAdapter.Update(this.userDataset.UserDetail);
                    this.userDataset.AcceptChanges();

                    this.accountListUser.LoadDataFromTable();
                }
            }
        }
    }
}