using DevExpress.XtraEditors;
using LeagueManagement_DX.CustomControlLibrary;
using LeagueManagement_DX.LeagueDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsControlLibrary;

namespace LeagueManagement_DX.Forms
{
    public partial class AddTour : DevExpress.XtraEditors.XtraForm
    {
        ToursTableAdapter tourTableAdapter;
        LeagueDatabaseDataSet dataset;
        LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow tourRow;
        bool ismodify;
        ControlList controllist;
        public LeagueManagement_DX.LeagueDatabaseDataSet.ToursRow TourRow
        {
            get
            {
                return tourRow;
            }
            set { tourRow = value; }
        }
        Image oldImage;
        public AddTour(ControlList _controlList)
        {
            InitializeComponent();

            this.pictureEdit_Logo.Properties.ContextMenuStrip = new ContextMenuStrip();
            this.pictureEdit_Logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;

            //data
            this.controllist = _controlList;
            this.dataset = _controlList.leagueDatabaseDataSet;
            this.tourTableAdapter = _controlList.tableAdapterManager.ToursTableAdapter;

            dataset.Tours.TableNewRow +=Tours_RowChanged;

            //transform
            this.pictureEdit_Logo.ContextMenuStrip = new ContextMenuStrip();

        }

        #region Event Implement
        private void AddTour_Load(object sender, EventArgs e)
        {
            if (this.TourRow != null)
            {
                this.loadToForm(this.TourRow);
                this.Size = new Size(480, 575);
                this.oldImage = pictureEdit_Logo.Image;
            }
            else
            {
                this.pictureEdit_Logo.Image = null;
                this.nameTextBox.Appearance.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
                this.nameTextBox.ForeColor = Color.Gray;
                this.dateTimePicker_Begindate.Value = DateTime.Now;
                this.dateTimePicker_Enddate.Value = DateTime.Now.AddMonths(8);
                this.checkEdit_advanced.Checked = false;
                this.checkEdit_advanced.Enabled = true;
                this.group_setting.Visible = false;
                this.Size = new Size(480, 235);
                this.nameTextBox.Text = "New Tournament";
            }
            ismodify = false;
            this.CenterToScreen();
        }

        private void Tours_RowChanged(object sender, DataTableNewRowEventArgs e)
        {
            controllist.LoadDataFromTable();
        }

        private void TextBox_Paint(object sender, PaintEventArgs e)
        {
            this.Okbutton.Enabled = true;
            foreach (var control in this.group_general.Controls)
            {
                if (control is CustomTextBox)
                {
                    if ((control as CustomTextBox).CheckCodition() == false)
                    {
                        this.Okbutton.Enabled = false;
                        return;
                    }
                }
            }
            if (this.checkEdit_advanced.Checked == false)
                return;
            foreach (var control in this.group_setting.Controls)
            {
                if (control is CustomTextBox)
                {
                    if ((control as CustomTextBox).CheckCodition() == false)
                    {
                        this.Okbutton.Enabled = false;
                        return;
                    }//if
                }//if
            }//foreach

        }

        private void customTextBox_Win_Leave(object sender, EventArgs e)
        {
            this.customTextBox_Win.TextPanelMessage = "Sai roi ne";
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (TourRow == null) 
            {
                //trường hợp thêm mới
                TourRow = this.dataset.Tours.NewToursRow();
                this.bindMethod();
                TourRow.EndEdit();
                dataset.Tours.Rows.Add(TourRow);
            }
            else
            {
                //trường hợp sửa
                if (this.ismodify == true)
                {
                    TourRow.BeginEdit();
                    this.bindMethod();
                    TourRow.EndEdit();
                }
            }
            
            bool isHide = this.endEdit();
            this.saveImage();
            TourRow = null;
            if (dataset.GetChanges() != null)
                dataset.RejectChanges();
            if (isHide ==true)
            {
                this.Hide();
            }
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            //this.nameTextBox.ResetText();   
        }

        private void checkEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            if ((sender as CheckEdit).CheckState == CheckState.Checked)
            {
                this.group_setting.Visible = true;
            }
            else
            {
                this.group_setting.Visible = false;
            }
            this.CenterToScreen();
        }

        private void groupControl2_VisibleChanged(object sender, EventArgs e)
        {
            if (this.TourRow != null)
                return;
            if ((sender as GroupControl).Visible == true)
            {
                this.Size = new Size(480, 575);
                this.customTextBox_NumberMin.Text = "15";
                this.customTextBox_NumberPlayerMax.Text = "22";
                this.customTextBox_AgeMax.Text = "40";
                this.customTextBox_AgeMin.Text = "16";
                this.customTextBox_ForeignMax.Text = "3";
                this.customTextBox_ForeignMin.Text = "0";
                this.customTextBox_Win.Text = "3";
                this.customTextBox_Draw.Text = "1";
                this.customTextBox_Lose.Text = "0";
                this.customTextBox_Round.Text = "2";
                this.customTextBox_MatchTime.Text = "90";
                this.customTextBox_MaxSub.Text = "7";
                this.customTextBox_MaxSwitch.Text = "3";
            }
            else
            {
                this.Size = new Size(480, 235);
            }
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if ((sender as CustomTextBox).Text == "New Tournament")
            {
                (sender as CustomTextBox).ResetText();
                (sender as CustomTextBox).Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            }
        }

        private void trackBar_matchtime_Scroll(object sender, EventArgs e)
        {
            this.customTextBox_MatchTime.Text = (sender as TrackBar).Value.ToString();
        }

        private void pictureEdit_Logo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.pictureEdit_Logo.Image != null)
            this.pictureEdit_Logo.Image.Dispose();
            this.pictureEdit_Logo.LoadImage();
        }

        #endregion

        #region Private Method

        /// <summary>
        /// Save hình được chọn lại. Theo Id
        /// </summary>
        private void saveImage()
        {
            if (this.pictureEdit_Logo.Image != null)
            {
                var lastrow = dataset.Tours.Last(); //để tạm. đúng ra không được để last, vì trường hợp sửa bị sai.
                int id = this.dataset.Tours.Last().Id;
                string avt = @"Image\Tour\" + id.ToString() + ".jpg";
                lastrow.BeginEdit();
                lastrow.Avatar = avt;
                lastrow.EndEdit();
                try
                {
                    this.tourTableAdapter.Update(dataset);
                    this.dataset.AcceptChanges();
                }
                catch (SqlException sqle)
                {

                }
               // this.tourTableAdapter.Fill(dataset.Tours);
                this.controllist.LoadDataFromTable();
                if (Directory.Exists(@"Image\Tour") == false)
                    Directory.CreateDirectory(@"Image\Tour");
                lastrow = dataset.Tours.Last();
                if (object.ReferenceEquals(this.oldImage, this.pictureEdit_Logo.Image) == false)
                {
                    this.oldImage = null;
                    this.pictureEdit_Logo.Image.Save(avt);
                }
            }
        }
        /// <summary>
        /// Kết thúc quá trình edit dữ liệu và kiểm tra lỗi
        /// </summary>
        /// <returns></returns>
        private bool endEdit()
        {
            try
            {
                this.tourTableAdapter.Update(dataset);
                this.dataset.AcceptChanges();
                //this.tourTableAdapter.Fill(dataset.Tours);
                this.controllist.LoadDataFromTable();
                return true;
            }
            catch (SqlException sqle)
            {
                DialogResult rs = 0;
                foreach (var error in sqle.Errors)
                {
                    switch ((error as SqlError).Number)
                    {
                        case 2627:
                            rs = this.Exception_Duplicate_TourName((error as SqlError).Message);
                            break;
                        case 547:
                            if ((error as SqlError).Message.Contains("CK_TOURS_BeginD_EndD"))
                            {
                                rs = this.Exception_Check_BeginEndDate((error as SqlError).Message);
                                break;
                            }
                            if ((error as SqlError).Message.Contains("CK_Tours_Player"))
                            {
                                rs = this.Exception_Check_PLayer((error as SqlError).Message);
                                break;
                            }
                            if ((error as SqlError).Message.Contains("CK_Tours_Age"))
                            {
                                rs = this.Exception_Check_Tour_Age((error as SqlError).Message);
                                break;
                            }
                            if ((error as SqlError).Message.Contains("CK_Tours_Foreign"))
                            {
                                rs = this.Exception_Check_Foreign((error as SqlError).Message);
                                break;
                            }
                            if ((error as SqlError).Message.Contains("CK_Tours_Ratio"))
                            {
                                rs = this.Exception_Check_WDL_Ratio((error as SqlError).Message);
                                break;
                            }
                            if ((error as SqlError).Message.Contains("CK_Tours_Rounds"))
                            {
                                rs = this.Exception_Check_Tours_Rounds((error as SqlError).Message);
                                break;
                            }
                            break;
                        case 50000:
                            this.Exception_Trigger_Raiserror((error as SqlError).Message);
                            this.dataset.RejectChanges();
                            return true;
                        default:
                            break;
                    }//switch
                    this.dataset.RejectChanges();
                }
                if (rs == System.Windows.Forms.DialogResult.Retry)
                    return false;
                return true;
            }

        }



        private void loadToForm(LeagueDatabaseDataSet.ToursRow _toursRow)
        {
            this.checkEdit_advanced.Checked = true;
            this.checkEdit_advanced.Enabled = false;
            this.nameTextBox.Text = _toursRow.TourName;
            this.dateTimePicker_Begindate.Value = _toursRow.BeginDate;
            this.dateTimePicker_Enddate.Value = _toursRow.EndDate;
            this.customTextBox_NumberPlayerMax.Text = _toursRow.PlayerMax.ToString();
            this.customTextBox_NumberMin.Text = _toursRow.PlayerMin.ToString();
            this.customTextBox_AgeMax.Text = _toursRow.PlayerAgeMax.ToString();
            this.customTextBox_AgeMin.Text = _toursRow.PlayerAgeMin.ToString();
            this.customTextBox_ForeignMax.Text = _toursRow.ForeignMax.ToString();
            this.customTextBox_ForeignMin.Text = _toursRow.ForeignMin.ToString();
            this.customTextBox_Win.Text = _toursRow.WinRatio.ToString();
            this.customTextBox_Lose.Text = _toursRow.LoseRatio.ToString();
            this.customTextBox_Draw.Text = _toursRow.DrawRatio.ToString();
            this.customTextBox_Round.Text = _toursRow.Rounds.ToString();
            this.customTextBox_MatchTime.Text = _toursRow.TimeMatch.ToString();
            this.customTextBox_MaxSub.Text = _toursRow.SubPlayerMax.ToString();
            this.customTextBox_MaxSwitch.Text = _toursRow.SwitchMax.ToString();

            switch (_toursRow.Priority)
            {
                case "PADV": this.comboBoxEdit_priority.SelectedItem = 0; break;
                case "PVAD": this.comboBoxEdit_priority.SelectedItem = 1; break;
                case "PVDA": this.comboBoxEdit_priority.SelectedItem = 2; break;
                case "PDVA": this.comboBoxEdit_priority.SelectedItem = 3; break;
                default:
                    break;
            }
            string path = _toursRow.Avatar;
            if (File.Exists(path))
                this.pictureEdit_Logo.Image = Image.FromFile(path);
        }

        /// <summary>
        /// dùng để gán dữ liệu
        /// </summary>
        private void bindMethod()
        {
            if (this.checkEdit_advanced.Checked == true)
            {
                TourRow.TourName = this.nameTextBox.Text;
                TourRow.BeginDate = this.dateTimePicker_Begindate.Value;
                TourRow.EndDate = this.dateTimePicker_Enddate.Value;
                TourRow.PlayerMax = Convert.ToByte(this.customTextBox_NumberPlayerMax.Text);
                TourRow.PlayerMin = Convert.ToByte(this.customTextBox_NumberMin.Text);
                TourRow.PlayerAgeMax = Convert.ToByte(this.customTextBox_AgeMax.Text);
                TourRow.PlayerAgeMin = Convert.ToByte(this.customTextBox_AgeMin.Text);
                TourRow.ForeignMax = Convert.ToByte(this.customTextBox_ForeignMax.Text);
                TourRow.ForeignMin = Convert.ToByte(this.customTextBox_ForeignMin.Text);
                TourRow.WinRatio = Convert.ToByte(this.customTextBox_Win.Text);
                TourRow.LoseRatio = Convert.ToByte(this.customTextBox_Lose.Text);
                TourRow.DrawRatio = Convert.ToByte(this.customTextBox_Draw.Text);
                TourRow.Rounds = Convert.ToByte(this.customTextBox_Round.Text);
                TourRow.TimeMatch = Convert.ToByte(this.customTextBox_MatchTime.Text);
                TourRow.SubPlayerMax = Convert.ToByte(this.customTextBox_MaxSub.Text);
                TourRow.SwitchMax = Convert.ToByte(this.customTextBox_MaxSwitch.Text);
                switch (this.comboBoxEdit_priority.SelectedIndex)
                {
                    case 0: TourRow.Priority = "PADV"; break;
                    case 1: TourRow.Priority = "PVAD"; break;
                    case 2: TourRow.Priority = "PVDA"; break;
                    case 3: TourRow.Priority = "PDVA"; break;
                    default:
                        break;
                }
                TourRow.Avatar = String.Empty;
            }
            else
            {
                TourRow.TourName = this.nameTextBox.Text;
                TourRow.BeginDate = this.dateTimePicker_Begindate.Value;
                TourRow.EndDate = this.dateTimePicker_Enddate.Value;
            }
        }
        #region #Context Exception
        private DialogResult Exception_Check_Tours_Rounds(string p)
        {
            string msg = "Invalid rounds. Round must not be equal zero\n";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_Check_Tour_Age(string p)
        {
            string msg = "Invalid max age and min age.\nMax age must great than min age";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_Check_WDL_Ratio(string p)
        {
            string msg = "Invalid win - draw - lose ratio\n.";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_Check_Foreign(string p)
        {
            string msg = "Invalid max foreign player and min foreing player\nMax foreign player must great than min foreign player.";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_Check_PLayer(string p)
        {
            string msg = "Invalid max player and min player\nMax player must great than min player.";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_Check_BeginEndDate(string _errmsg)
        {
            string msg = "Invalid begin date and end date\nBegin date must less than end date.";
            return MessageBox.Show(msg, Settings.Default.StringCaptionInvalidValue, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private DialogResult Exception_Duplicate_TourName(string _errmsg)
        {
            string msgerror = "Can not create two tour with the same name.\nCheck tour: ";
            var str = _errmsg.IndexOf("The duplicate key value is ");
            msgerror += _errmsg.Substring(str + "The duplicate key value is ".Length);
            return MessageBox.Show(msgerror, Settings.Default.StringCaptionAddtour, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }
        private void Exception_Trigger_Raiserror(string p)
        {
            MessageBox.Show(p, Settings.Default.StringCaptionTransactionUnsuccess, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        #endregion

        private void nameTextBox_xTextChanged(object sender, EventArgs e)
        {
            //if ((sender as CustomTextBox).ForeColor == Color.Gray)
            //{
            //    (sender as CustomTextBox).ForeColor = Color.Black;
            //    (sender as CustomTextBox).Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            //}//sai từ từ sửa
            if (ismodify == false)
                ismodify = true;
        }
        #endregion

        private void AddTour_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (this.pictureEdit_Logo.Image != null)
                this.pictureEdit_Logo.Image.Dispose();
            tourRow = null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.pictureEdit_Logo.Image != null)
                this.pictureEdit_Logo.Image.Dispose();
            tourRow = null;
        }

        private void comboBoxEdit1_TextChanged(object sender, EventArgs e)
        {
            if (ismodify == false)
                ismodify = true;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ismodify == false)
                ismodify = true;
        }


    }
}
