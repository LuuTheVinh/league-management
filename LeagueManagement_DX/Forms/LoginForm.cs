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

namespace LeagueManagement_DX.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        UserDataset.UserDetailDataTable _userTable;
        DataRow _userRecord;
        int _countAttemp;
        int _countDown;
        //int _userLevel;
        //Encryption _encryptionIstance;
        bool _loginState;
        //public int TransferLevel
        //{
        //    get { return this._userLevel; }
        //}
        public DataRow TransferUserInfo
        {
            get { return this._userRecord; }
        }
        public LoginForm()
        {
            InitializeComponent();
            //_encryptionIstance = new Encryption();
            this._loginState = false;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            userDetailTableAdapter.Fill(userDataset.UserDetail);
            _userTable = userDataset.UserDetail;
            _userRecord = null;
            _countAttemp = 0;
            _countDown = 180000;
            this.textEditPassword.Properties.MaxLength = 16;
            this.textEditUsername.Properties.MaxLength = 10;
            this.labelControlNotify.Text = "";
        }

       

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            if (_countAttemp <= 5)
            {
                if (textEditUsername.Text == "" || textEditPassword.Text == "")
                {
                    this.labelControlNotify.Text = "Please enter fully information your account";
                }
                else
                {
                    _userRecord = _userTable.FindByUsername(Convert.ToInt32(textEditUsername.Text));
                    if (_userRecord != null)
                    {
                        Encryption _encryptPassword = new Encryption(this.textEditPassword.Text);
                        //if (Convert.ToString(_userRecord["Password"]) == textEditPassword.Text)
                        //Sau khi hoàn chỉnh CSDL thì mới dùng đối tượng mã hóa này để kiểm tra password
                        if(_encryptPassword.Encrypt() == this._userRecord["Password"].ToString())
                        {
                            DataRow[] _updateRow;
                            _updateRow = userDataset.Tables["UserDetail"].Select("Username=" + textEditUsername.Text);
                            _updateRow[0].BeginEdit();
                            _updateRow[0]["LastLogin"]= System.DateTime.Now;
                            _updateRow[0].EndEdit();
                            this.userDetailTableAdapter.Update(this.userDataset.UserDetail);
                            this.userDataset.UserDetail.AcceptChanges();
                            UserAccessLevel.Instance.SetAccessLevel = Convert.ToInt32(permissionTableAdapter.GetLevelPermission(Convert.ToInt32(this.textEditUsername.Text)));
                            //this._userLevel =Convert.ToInt32(permissionTableAdapter.GetLevelPermission(Convert.ToInt32(this.textEditUsername.Text)));
                            this._loginState = true;
                            this.Close();
                            
                        }
                        else
                        {
                            this.labelControlNotify.Text = "Invalid password. Please try again!";
                            this.textEditPassword.Text = "";
                            this._countAttemp++;
                        }
                    }
                    else
                    {
                        this.labelControlNotify.Text = "Invalid Username. Please try again!";
                        this.textEditUsername.Text = "";
                        this.textEditPassword.Text = "";
                        this._countAttemp++;
                    }
                }
            }
            else
            {
                
                MessageBox.Show("You have entered invalid information too many times. This application will pending until pending time out!", "WARNING", MessageBoxButtons.OK);
                this.textEditPassword.Enabled = false;
                this.textEditUsername.Enabled = false;
                this.simpleButtonCancel.Enabled = false;
                this.simpleButtonLogin.Enabled = false;
                this.ControlBox = false;
                this._countAttemp = 0;
                this.timer.Start();
        
            }

        }
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.timer.Interval = 1000;
            this.labelControlNotify.Text = "Pending time remain: " + Convert.ToString(this._countDown / 1000) + " seconds";
            _countDown -= 1000;
            if (_countDown == 0)
            {
                this.timer.Stop();
                this.labelControlNotify.Text = "";
                this.textEditPassword.Enabled = true;
                this.textEditUsername.Enabled = true;
                this.simpleButtonCancel.Enabled = true;
                this.simpleButtonLogin.Enabled = true;
                this.ControlBox = true;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._loginState)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}