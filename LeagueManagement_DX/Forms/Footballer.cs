using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LeagueManagement_DX;
using LeagueManagement_DX.Forms;
using LeagueManagement_DX.Properties;
using System.Drawing.Imaging;
using WindowsFormsControlLibrary;
using System.Data.SqlClient;
using LeagueManagement_DX.CustomControlLibrary;
namespace LeagueManagement_DX.Forms
{
    public partial class Footballer : DevExpress.XtraEditors.XtraForm
    {
        LeagueDatabaseDataSet.FootballerDataTable footballerTable;
        private ControlList _controlList;
        bool dialogState;
        Image temp;
        public Footballer()
        {
            InitializeComponent();
            pictureEditFootballerAvatar.Properties.ContextMenuStrip = new ContextMenuStrip();

            //VINH THEM VO DUNG CHO PLAYER GRID
            this.leagueDatabaseDataSet.Footballer.TableNewRow += Footballer_RowChanged;
            this.dialogState = false;
        }
        public Footballer(ControlList controlList)
        {
            InitializeComponent();
            pictureEditFootballerAvatar.Properties.ContextMenuStrip = new ContextMenuStrip();
            this._controlList = controlList;
            this.leagueDatabaseDataSet = this._controlList.leagueDatabaseDataSet;
            this.leagueDatabaseDataSet.Footballer.TableNewRow += Footballer_RowChanged;
            this.dialogState = false;
        }
        private void Footballer_Load(object sender, EventArgs e)
        {
            footballerTableAdapter.Fill(leagueDatabaseDataSet.Footballer);
            footballerTable = leagueDatabaseDataSet.Footballer;
            
            this.dateTimePickerDateOfBirth.Value = this.dateTimePickerDateOfBirth.Value.AddDays(1.0f);
            this.simpleButtonAdd.Enabled = false;
            this.temp = pictureEditFootballerAvatar.Image;
            

            //Vinh Edit
            customTextBoxName.StringPattern = "^[" + Resources.VNCharacters + "A-Za-z' ]{1,20}$";
            //customTextBoxNation.StringPattern = "^[" + Resources.VNCharacters + "A-Za-z ]{1,15}$";
        }
        private void Footballer_RowChanged(object sender, DataTableNewRowEventArgs e)
        {
        }
        private void Footballer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (this.dialogState == true)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void simpleButtonBrowse_Click(object sender, EventArgs e)
        {
            
            pictureEditFootballerAvatar.LoadImage();
            //pictureEditFootballerAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        }


        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            DataRow _newRow = this.leagueDatabaseDataSet.Footballer.NewRow();
            _newRow.BeginEdit();
            _newRow["Name"] = this.customTextBoxName.Text;
            _newRow["Birth"] = this.dateTimePickerDateOfBirth.Value;
            _newRow["Nation"] = this.customTextBoxNation.Text;
            _newRow.EndEdit();
            this.leagueDatabaseDataSet.Footballer.Rows.Add(_newRow);
            bool isAdded=this.checkException();
            if (isAdded == true)
            {
                DataRow lastrow = this.leagueDatabaseDataSet.Footballer.Last();
                lastrow.BeginEdit();
                lastrow["Avatar"] = @"Image\Footballer\" + lastrow["Id"].ToString() + ".jpg";
                lastrow.EndEdit();
                this.footballerTableAdapter.Update(lastrow);
                this.leagueDatabaseDataSet.AcceptChanges();
                if (!Directory.Exists(@"Image\Footballer"))
                    Directory.CreateDirectory(@"Image\Footballer");
                if (pictureEditFootballerAvatar.Image != null)
                    pictureEditFootballerAvatar.Image.Save(lastrow["Avatar"].ToString());
                this.customTextBoxName.ResetText();
                this.customTextBoxNation.ResetText();
            }
            else
                return;
                
        }
        private bool checkException()
        {
            try
            {
                this.footballerTableAdapter.Update(this.leagueDatabaseDataSet);
                this.leagueDatabaseDataSet.AcceptChanges();
                this.footballerTableAdapter.Fill(this.leagueDatabaseDataSet.Footballer);
                this.labelControlStatus.ForeColor = Color.Green;
                this.labelControlStatus.Text = "Added sucessfully";
                this.dialogState = true;
                return true;
            }
            catch (SqlException ex)
            {
                this.leagueDatabaseDataSet.RejectChanges();
                this.footballerTableAdapter.Fill(this.leagueDatabaseDataSet.Footballer);
                foreach (var error in ex.Errors)
                {
                    if ((error as SqlError).Number == 547)
                    {
                        this.labelControlStatus.ForeColor = Color.Red;
                        string message = "Invalid Footballer's Date of Birth\n The Date of Bitrth must be smaller than the current Date";
                        this.labelControlStatus.Text = message;
                    }
                }
                return false;
            }
        }
        private DialogResult Exception_CK_FOOTBALLER_BIRTH(string p)
        {
            string message = "Invalid Footballer's Date of Birth\n The Date of Bitrth must be smaller than the current Date";
            return MessageBox.Show(message, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

        }
    
        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void customTextBoxName_Paint(object sender, PaintEventArgs e)
        {
            this.simpleButtonAdd.Enabled = true;
            foreach (var control in this.groupControl1.Controls)
            {
                if (control is CustomTextBox)
                {
                    if ((control as CustomTextBox).CheckCodition() == false)
                    {
                        this.simpleButtonAdd.Enabled = false;
                        return;
                    }
                }
            }
        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            this.labelControlStatus.Text = "";
        }

        private void customTextBoxName_Click(object sender, EventArgs e)
        {
            this.labelControlStatus.Text = "";
        }

        private void customTextBoxNation_Click(object sender, EventArgs e)
        {
            this.labelControlStatus.Text = "";
        }
    }
}