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
using System.IO;
using LeagueManagement_DX.CustomControlLibrary;
using WindowsFormsControlLibrary;
using LeagueManagement_DX.Properties;
using System.Data.SqlClient;
namespace LeagueManagement_DX.Forms
{
    public partial class CreateAccount : DevExpress.XtraEditors.XtraForm
    {
        UserDataset.GroupUserDataTable _groupUserTable;
        bool formState;
        
        public CreateAccount()
        {
            InitializeComponent();
            formState = false;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            this.customTextBoxFullname.StringPattern = "^[" + Resources.VNCharacters + "A-Za-z'\\ ]{1,30}$";
            this.customTextBoxFullname.TextBox.Clear();
            this.customTextBoxUsername.TextBox.Clear();
            this.textEditPassword.Text = "";
            this.dateTimePickerDateofbirth.Value = DateTime.Now;
            this.comboBoxEditSelectGroup.Properties.Items.Clear();
            this.pictureEditUserAvatar.Image = null;
            
            groupTableAdapter.Fill(userDataset.GroupUser);
            _groupUserTable = userDataset.GroupUser;
            userDetailTableAdapter.Fill(userDataset.UserDetail);
            this.simpleButtonCreate.Enabled = true;
            foreach (DataRow i in _groupUserTable.Rows)
            {
                this.comboBoxEditSelectGroup.Properties.Items.Add(i["GroupName"]);
            }
            this.pictureEditUserAvatar.ContextMenuStrip = new ContextMenuStrip();
            this.comboBoxEditSelectGroup.SelectedIndex = 0;


        }
        private DialogResult Exception_CHECK_DateOfBirth(string p)
        {
            string msg = "Invalid Date of Birth. Age of user must be older than 22";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel);
        }
        private bool CheckException()
        {
            try
            {
                this.userDetailTableAdapter.Update(this.userDataset);
                this.userDataset.AcceptChanges();
                return true;
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
                return false;
            }
        }
        private void simpleButtonCreate_Click(object sender, EventArgs e)
        {
            
            Encryption _encryptionInstance = new Encryption(this.textEditPassword.Text);
            DataRow[] _userRecord;
            _userRecord = userDataset.Tables["GroupUser"].Select(string.Format("CONVERT({0},System.String) LIKE '%{1}'", "GroupName", comboBoxEditSelectGroup.SelectedItem.ToString()));
            DataRow newRow = this.userDataset.UserDetail.NewRow();
            int username = Convert.ToInt32(this.customTextBoxUsername.Text);
            string path = @"Image\Speciallist\";
            newRow.BeginEdit();
            newRow["Username"] = this.customTextBoxUsername.Text;
            newRow["Password"] = _encryptionInstance.Encrypt();
            newRow["FullName"] = this.customTextBoxFullname.Text;
            newRow["DateOfBirth"] = this.dateTimePickerDateofbirth.Value;
            newRow["GroupId"] = Convert.ToInt32(_userRecord[0]["GroupId"]);
            newRow["Avatar"] = path + this.customTextBoxUsername.Text + ".jpg";
            newRow.EndEdit();
            try
            {
                this.userDataset.UserDetail.Rows.Add(newRow);
            }
            catch
            {
                DialogResult dresult= MessageBox.Show("Username has already existed", "Error", MessageBoxButtons.RetryCancel);
                if (dresult == System.Windows.Forms.DialogResult.Retry)
                {
                    this.userDataset.RejectChanges();
                    return;
                }
                else
                {
                    this.formState = false;
                    this.Close();
                }
            }
            bool isAdded= this.CheckException();
            if (isAdded == true)
            {
                DataRow editRow = this.userDataset.UserDetail.FindByUsername(username);

                if (!Directory.Exists(@"Image\Speciallist"))
                {
                    Directory.CreateDirectory(@"Image\Speciallist");

                }
                if (this.pictureEditUserAvatar.Image != null)
                    pictureEditUserAvatar.Image.Save(editRow["Avatar"].ToString());

                this.formState = true;
                this.Close();
            }
            else
                return;
        }

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (this.formState == true)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
           
            this.formState = false;
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pictureEditUserAvatar.LoadImage();
            pictureEditUserAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
        }

        private void CreateAccount_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private bool CheckPasswordTextBox()
        {
            if (this.textEditPassword.Text == "" || this.textEditPassword.Text.Length <4 || this.textEditPassword.Text.Length >16)
                return false;
            return true;
        }
        private void customTextBoxUsername_Paint(object sender, PaintEventArgs e)
        {
            this.simpleButtonCreate.Enabled = true;
            foreach (var control in this.groupControl1.Controls)
            {
                if (control is CustomTextBox)
                {
                    if (!(control as CustomTextBox).CheckCodition() || !this.CheckPasswordTextBox() || this.comboBoxEditSelectGroup.SelectedIndex == -1)
                    {
                        this.simpleButtonCreate.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void customTextBoxFullname_Paint(object sender, PaintEventArgs e)
        {
            this.simpleButtonCreate.Enabled = true;
            foreach (var control in this.groupControl1.Controls)
            {
                if (control is CustomTextBox)
                {
                    if (!(control as CustomTextBox).CheckCodition() || !this.CheckPasswordTextBox() || this.comboBoxEditSelectGroup.SelectedIndex == -1)
                    {
                        this.simpleButtonCreate.Enabled = false;
                        return;
                    }
                }
            }
        }
    }
}