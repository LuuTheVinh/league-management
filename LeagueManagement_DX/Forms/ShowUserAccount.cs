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
using WindowsFormsControlLibrary;
using System.IO;
using System.Data.SqlClient;
using LeagueManagement_DX.Properties;
namespace LeagueManagement_DX.Forms
{
    public partial class ShowUserAccount : DevExpress.XtraEditors.XtraForm
    {
        //AccountList _accountlList;
        private UserDataset.UserDetailDataTable _userDetailTable;
        private UserDataset.GroupUserDataTable _groupTable;
        //private UserDataset _userDataSet;
        private DataRow _userInfo;
        Image temp;
        bool formState;
        public ShowUserAccount()
        {
            InitializeComponent();
            this.pictureEditUserAvatar.ContextMenuStrip = new ContextMenuStrip();
        }


        public ShowUserAccount(DataRow Item)
        {
            InitializeComponent();
            this.pictureEditUserAvatar.ContextMenuStrip = new ContextMenuStrip();
            this._userInfo = Item;
            this.formState = false;
            this.Text = this._userInfo["FullName"].ToString();
        }
        private void ShowUserAccount_Load(object sender, EventArgs e)
        {
            this.customTextBoxFullName.StringPattern = "^[" + Resources.VNCharacters + "A-Za-z'\\ ]{1,30}$";
            this.customTextBoxFullName.isRequired = false;
            this.customTextBoxLastLogin.isRequired = false;
            this.customTextBoxGroupName.isRequired = false;
            this.Text = this._userInfo["FullName"].ToString();
            this.userDetailTableAdapter.Fill(userDataset.UserDetail);
            this._userDetailTable = userDataset.UserDetail;
            this.groupUserTableAdapter.Fill(userDataset.GroupUser);
            this._groupTable = userDataset.GroupUser;

            this.simpleButtonBrowse.Visible = false;
            this.comboBoxGroupName.Visible = false;
            this.customTextBoxFullName.Enabled = false;
            //this.customTextBoxDateOfBirth.Enabled = false;
            this.textEditDateOfBirth.Enabled = false;
            this.customTextBoxGroupName.Enabled = false;
            this.customTextBoxLastLogin.Enabled = false;
            this.simpleButtonOK.Visible = false;
            this.dateTimePickerDateOfBirth.Visible = false;

            this.simpleButtonOK.Enabled = false;
            this.customTextBoxFullName.Text = this._userInfo["FullName"].ToString();
            this.textEditDateOfBirth.Text = ((DateTime)this._userInfo["DateOfBirth"]).ToString("dd/MM/yyyy");
            this.customTextBoxGroupName.Text = (this.groupUserTableAdapter.GetGroupName(Convert.ToInt32(this._userInfo["Username"]))).ToString();
            if (this._userInfo["LastLogin"].ToString() != "")
                this.customTextBoxLastLogin.Text = ((DateTime)this._userInfo["LastLogin"]).ToString("dd/MM/yyyy");
            else
                this.customTextBoxLastLogin.Text = "Unknown";
            if (File.Exists(this._userInfo["Avatar"].ToString()))
            {
                this.pictureEditUserAvatar.Image = Image.FromFile(this._userInfo["Avatar"].ToString());
            }
            this.temp = this.pictureEditUserAvatar.Image;
            this.textEditCurrentPass.Enabled = false;
            this.textEditNewPass.Enabled = false;
            this.checkBoxChangePassword.Checked = false;
            this.checkBoxChangePassword.Enabled = false; 
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            this.customTextBoxLastLogin.Enabled = false;
            this.labelControlLastLogin.Enabled = true;
            this.customTextBoxGroupName.Visible = false;
            this.simpleButtonEdit.Visible = false;
            this.simpleButtonOK.Visible = true;
            this.simpleButtonOK.Enabled = true;
            this.comboBoxGroupName.Visible = true;
            this.customTextBoxFullName.Enabled = true;
            this.checkBoxChangePassword.Enabled = true;
            this.customTextBoxFullName.isRequired = true;
            this.customTextBoxLastLogin.isRequired = true;
            //this.customTextBoxDateOfBirth.Enabled = true;
           // this.customTextBoxDateOfBirth.Visible = false;
            this.textEditDateOfBirth.Visible = false;
            this.dateTimePickerDateOfBirth.Visible = true;
            //this.simpleButtonEdit.Text = "OK";
            this.simpleButtonBrowse.Visible = true;
            this.dateTimePickerDateOfBirth.Text = this.textEditDateOfBirth.Text;
            foreach (DataRow i in this._groupTable)
            {
                this.comboBoxGroupName.Items.Add(i["GroupName"]);
            }
            foreach (var item in this.comboBoxGroupName.Items)
            {
                if (customTextBoxGroupName.Text == item.ToString())
                    this.comboBoxGroupName.SelectedItem = customTextBoxGroupName.Text;
            }

        }

        private void simpleButtonBrowse_Click(object sender, EventArgs e)
        {
            this.pictureEditUserAvatar.LoadImage();
            this.pictureEditUserAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckInput()
        {
            if (this.customTextBoxFullName.CheckCodition())
                return true;
            else
                return false;
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            Encryption encrypt = new Encryption();
            
            string path = @"Image\Speciallist";
            this.simpleButtonOK.Enabled = true;
            DataRow[] _editRow = userDataset.Tables["UserDetail"].Select(string.Format("CONVERT({0},System.String) LIKE '%{1}'","Username", this._userInfo["Username"].ToString()));
            _editRow[0].BeginEdit();
            _editRow[0]["FullName"] = this.customTextBoxFullName.Text;
            _editRow[0]["DateOfBirth"] = this.dateTimePickerDateOfBirth.Value;
            DataRow[] _groupList = userDataset.Tables["GroupUser"].Select(string.Format("CONVERT({0},System.String) LIKE '%{1}'", "GroupName", comboBoxGroupName.SelectedItem.ToString()));
            _editRow[0]["GroupId"] = _groupList[0]["GroupId"];
            if (_editRow[0]["Avatar"].ToString() == "")
                _editRow[0]["Avatar"] = path + @"\" + _editRow[0]["Username"].ToString() + ".jpg";
            if (this.checkBoxChangePassword.Checked)
            {
                
                if (this.textEditCurrentPass.Text != "")
                {
                    encrypt.Password = this.textEditCurrentPass.Text;
                    if (_editRow[0]["Password"].ToString() == encrypt.Encrypt())
                    {
                        encrypt.Password = this.textEditNewPass.Text;
                        _editRow[0]["Password"] = encrypt.Encrypt();
                    }
                    else
                    {
                        MessageBox.Show("Current password is incorrect!", "Error", MessageBoxButtons.OK);
                        _editRow[0].CancelEdit();
                        return;
                    }
                }
                
                
            }
            _editRow[0].EndEdit();
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (this.pictureEditUserAvatar.Image != null)
            {
                if (!object.ReferenceEquals(this.temp, this.pictureEditUserAvatar.Image))
                {
                    if (this.temp != null)
                        this.temp.Dispose();
                    this.pictureEditUserAvatar.Image.Save(_editRow[0]["Avatar"].ToString());
                }
            }
                //userDetailTableAdapter.Update(_editRow[0]);
                //userDataset.AcceptChanges();
                this.CheckException();
                this.formState = true;
                

        }
        private void CheckException()
        {
            try
            {
                this.userDetailTableAdapter.Update(this.userDataset);
                this.userDataset.AcceptChanges();
                this.Close();
            }
            catch (SqlException ex)
            {
                this.userDataset.RejectChanges();
                DialogResult dresult = 0;
                foreach (var error in ex.Errors)
                {
                    switch ((error as SqlError).Number)
                    {
                        case 547:
                            {
                                if ((error as SqlError).Message.Contains("CHECK_DateOfBirth"))
                                {
                                    dresult = this.Exception_CHECK_DateOfBirth((error as SqlError).Message);
                                    break;
                                }
                            }
                            break;
                    }
                }
                if (dresult != System.Windows.Forms.DialogResult.Retry)
                    this.Close();
            }
        }
        //CHECK_DateOfBirth
        private DialogResult Exception_CHECK_DateOfBirth(string p)
        {
            string msg = "Invalid Date of Birth. Age of user must be older than 22";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel);
        }
        private void customTextBoxFullName_xTextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBoxDateOfBirth_xTextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBoxGroupName_xTextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBoxLastLogin_xTextChanged(object sender, EventArgs e)
        {

        }
        private bool isValid()
        {
            if (!this.customTextBoxFullName.CheckCodition())
                return false;
            if (this.comboBoxGroupName.SelectedIndex == -1)
                return false;
            if (this.checkBoxChangePassword.Checked)
            {
                if (this.textEditNewPass.Text == "")
                    return false;
                if (this.textEditCurrentPass.Text == "")
                    return false;
            }
            return true;
        }
        private void ShowUserAccount_Paint(object sender, PaintEventArgs e)
        {
            //this.simpleButtonOK.Enabled = true;
            if (this.simpleButtonEdit.Visible == false)
            {
                this.simpleButtonOK.Enabled = true;
                if (this.isValid() == false)
                    this.simpleButtonOK.Enabled = false;
            }
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            string path = this._userInfo["Avatar"].ToString();
            if (File.Exists(path))
                File.Delete(path);
            //this._userInfo.Delete();
            DataRow deleteRow = this.userDataset.UserDetail.FindByUsername(Convert.ToInt32(this._userInfo["Username"]));
            deleteRow.Delete();
            this.userDetailTableAdapter.Update(this.userDataset);
            this.userDataset.AcceptChanges();
            this.formState = true;
            this.Close();
        }

        private void ShowUserAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.formState == true)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            if(this.pictureEditUserAvatar.Image!= null)
                this.pictureEditUserAvatar.Image.Dispose();
        }

        private void checkBoxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxChangePassword.Checked)
            {
                this.textEditCurrentPass.Enabled = true;
                this.textEditNewPass.Enabled = true;
            }
            else
            {
                this.textEditCurrentPass.Enabled = false;
                this.textEditNewPass.Enabled = false;
            }
        }
    }
}