using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using LeagueManagement_DX.Properties;

namespace WindowsFormsControlLibrary
{
    /// <summary>
    /// CustomTextBox có thể kiểm tra điều kiện của chuổi nhập vào.
    /// </summary>
    public partial class CustomTextBox : XtraUserControl
    {
        private TextBox textBox;
        private Color borderColor;
        private Padding textboxPadding;
        private ToolTip balloonToolTip;

        //Check Text Input
        //https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex%28v=vs.110%29.aspx
        private string inputText;

        public CustomTextBox()
        {
            textBox = new TextBox();
            textBox.BorderStyle = BorderStyle.None;
            textboxPadding = new Padding(5,3,5,3);
            textBox.TextChanged += this.CustomTextBox_TextChanged;
            textBox.Leave += this.CustomTextBox_Leave;

            this.Controls.Add(textBox);
            this.Paint += this.CustomTextBox_Paint;
            this.Resize += this.CustomTextBox_Resize;
            this.FontChanged += this.CustomTextBox_FontChanged;
            this.AutoSize = true;
            this.Padding = new Padding(0);
            this.BackColor = Color.White;

            this.NormalBorderColor = Color.Silver;
            this.ErrorBorderColor = Color.FromArgb(255, 231, 90, 67);
            this.HoverBorderColor = Color.Cyan;
            this.ValidBorderColor = Color.LightGreen;

            this.BorderColor = NormalBorderColor;

            //this.StringPattern = "^[a-zA-Z ]*$";
            //Nhận kí tự VN
            this.StringPattern = Resources.VNPattern;

            this.TextPanelMessage = "This is an error message.";
            this.PanelBackgroundColor = Color.FromArgb(255, 231, 90, 67);
            this.TextPanelMessageColor = Color.White;
            
            textBox.BackColor = this.BackColor;

            InvalidateSize();

            this.isRequired = true;

            balloonToolTip = new ToolTip();
            balloonToolTip.IsBalloon = false;
            balloonToolTip.OwnerDraw = true;
            balloonToolTip.Draw += balloonToolTip_Draw;
            balloonToolTip.Popup += balloonToolTip_Popup;
            balloonToolTip.ForeColor = this.TextPanelMessageColor;
            balloonToolTip.AutoPopDelay = 5000;
            balloonToolTip.InitialDelay = 500;

            InitializeComponent();

            textBox.TextChanged += textBox_TextChanged;
            textBox.Click += textBox_Click;
            textBox.DoubleClick += textBox_DoubleClick;
            textBox.GotFocus += textBox_GotFocus;
        }

        

        void textBox_GotFocus(object sender, EventArgs e)
        {
            this.OnGotFocus(new EventArgs());
        }

        void textBox_DoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(new EventArgs());
        }

        void textBox_Click(object sender, EventArgs e)
        {
            this.OnClick(new EventArgs());
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var onXTextChanged = this.xTextChanged;
            if (onXTextChanged != null) onXTextChanged(sender, e);
        }

        void balloonToolTip_Popup(object sender, PopupEventArgs e)
        {
           
        }

        void balloonToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(this.PanelBackgroundColor), e.Bounds);
   
            // Specify custom text formatting flags.
            TextFormatFlags sf = TextFormatFlags.VerticalCenter |
                                 TextFormatFlags.HorizontalCenter |
                                 TextFormatFlags.NoFullWidthCharacterBreak;

            // Draw the standard text with customized formatting options.
            e.DrawText(sf);
        }


        #region Properties
        // Exposed properties of the textbox
        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public TextBox TextBox
        {
            get { return textBox; }
            set { textBox = value; }
        }

        public bool ReadOnly
        {
            get { return textBox.ReadOnly; }
            set
            {
                textBox.ReadOnly = value;
            }
        }
        public ControlBindingsCollection DataBindings
        {
            get { return textBox.DataBindings; }
            private set { }
        }

        // The border color property
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        /// <summary>
        /// Sets and gets normal border color CustomTextBox
        /// </summary>
        public Color NormalBorderColor { get; set; }
        /// <summary>
        /// Sets and gets hover border color CustomTextBox
        /// </summary>
        public Color HoverBorderColor { get; set; }
        /// <summary>
        /// Sets and gets error border color CustomTextBox
        /// </summary>
        public Color ErrorBorderColor { get; set; }
        /// <summary>
        /// Sets and gets valid border color CustomTextBox
        /// </summary>
        public Color ValidBorderColor { get; set; }

        /// <summary>
        /// Sets and gets error message CustomTextBox
        /// </summary>
        public string TextPanelMessage { get; set; }
        /// <summary>
        /// Sets and gets background message color CustomTextBox
        /// </summary>
        public Color PanelBackgroundColor { get; set; }
        /// <summary>
        /// Sets and gets error text message color CustomTextBox
        /// </summary>
        public Color TextPanelMessageColor { get; set; }
        /// <summary>
        /// Sets and gets String Pattern CustomTextBox (Regular Expression)
        /// </summary>
        public string StringPattern { get; set; }
        /// <summary>
        /// Sets and gets status string input CustomTextBox
        /// </summary>
        public bool IsValid {
            get { return this.CheckCodition();}
            private set { } 
        }
        /// <summary>
        /// Sets and gets required text input CustomTextBox
        /// </summary>
        public bool isRequired { get; set; }

        /// <summary>
        /// Sets and gets Multi Line CustomTextBox
        /// </summary>
        public bool Multiline
        {
            get { return textBox.Multiline; }
            set { textBox.Multiline = value; InvalidateSize(); }
        }
        /// <summary>
        /// Sets and gets Direction Panel CustomTextBox
        /// </summary>
        /// 
        public Padding TextPadding {
            get { return textboxPadding; }
            set { textboxPadding = value; }
        }

        #endregion

        private void CustomTextBox_Resize(object sender, EventArgs e)
        {
            InvalidateSize();
        }

        private void CustomTextBox_FontChanged(object sender, EventArgs e)
        {
            InvalidateSize();
        }

        private void CustomTextBox_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
            Rectangle borderRect = new Rectangle(textBox.Location.X - this.textboxPadding.Left, textBox.Location.Y - this.textboxPadding.Top, textBox.Width + this.textboxPadding.Horizontal - 1, textBox.Height + this.textboxPadding.Vertical - 1);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), borderRect);
            e.Graphics.DrawRectangle(new Pen(this.borderColor), borderRect);
            
        }

        private void CustomTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isClosing) 
                return;

            CheckCodition();
            if (this.Text == "")
            {
                if (this.isRequired)
                {
                    if (this.borderColor != this.ErrorBorderColor)
                        this.BorderColor = this.ErrorBorderColor;
                    balloonToolTip.Hide(textBox);
                    balloonToolTip.Show("Required!", textBox, new Point(textBox.Width / 2, textBox.Height / 2), 2000);

                }
                else
                {
                    if (this.borderColor != this.ValidBorderColor)
                        this.BorderColor = this.ValidBorderColor;
                }
            }
        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            if (_isClosing) 
                return;

            if(this.textBox.Text == "" && this.isRequired)
            {
                if (this.borderColor != this.ErrorBorderColor)
                    this.BorderColor = this.ErrorBorderColor;
                
                balloonToolTip.Hide(textBox);
                balloonToolTip.Show("Required!", textBox, new Point(textBox.Width / 2, textBox.Height / 2), 2000);
            }
        }

        private void InvalidateSize()
        {
            if (this.Multiline == false && textBox != null)
            {
                textBox.Location = new Point(textboxPadding.Left, textboxPadding.Top);
                this.Size = new Size(this.Size.Width, textBox.Height + textboxPadding.Vertical);
                textBox.Size = new Size(this.Size.Width - textboxPadding.Horizontal, textBox.Height);
            }
            else
            {
                if (textBox != null)
                {
                    textBox.Size = new Size(this.Size.Width - textboxPadding.Horizontal, this.Size.Height - textboxPadding.Vertical);
                    textBox.Location = new Point(textboxPadding.Left, textboxPadding.Top);
                }
            }
        }

        #region Override Fuctions
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            InvalidateSize();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
        #endregion

        #region Fuction for Check Input
        public bool CheckCodition()
        {
            if (_isClosing) 
                return true;

            if (ReadOnly) 
                return true;

            inputText = this.Text;
            if(inputText == "" && this.isRequired)
            {
                return false;
            }

            if (this.StringPattern == null || this.StringPattern.IsEmpty())
            {
                this.StringPattern = ".*"; //Match Any Characters.
            }

            Regex regex = new Regex(this.StringPattern, RegexOptions.IgnoreCase);
            
            if(regex.IsMatch(inputText))
            {
                balloonToolTip.Hide(textBox);
                
                if(this.borderColor != this.ValidBorderColor && this.Text != "")
                    this.BorderColor = this.ValidBorderColor;
                
                return true;
            }
            else
            {
                if (this.borderColor != this.ErrorBorderColor && this.Text != "")
                    this.BorderColor = this.ErrorBorderColor;

                balloonToolTip.Hide(textBox);
                balloonToolTip.Show(this.TextPanelMessage, textBox, new Point(textBox.Width / 2, textBox.Height / 2), 2000);

                return false;
            }
        }

        #endregion

        public event EventHandler xTextChanged;

        public void ShowBallonToolTip(string message)
        {
            if(_isClosing) 
                return;

            balloonToolTip.Hide(textBox);
            balloonToolTip.Show(message, textBox, new Point(textBox.Width / 2, textBox.Height / 2), 2000);
        }

        private void CustomTextBox_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible == false)
                balloonToolTip.Hide(textBox);
        }

        private void CustomTextBox_EnabledChanged(object sender, EventArgs e)
        {
            if(this.Enabled == false)
            {
                this.BorderColor = Color.Gainsboro;
                balloonToolTip.Hide(textBox);
            }
            else
            {
                this.CheckCodition();
            }
        }

        private bool _isClosing;

        private void CustomTextBox_Load(object sender, EventArgs e)
        {
            if (ParentForm == null) 
                return;

            ParentForm.Closing += ParentFormOnClosing;
            ParentForm.Activated += ParentFormOnActivated;
        }

        private void ParentFormOnActivated(object sender, EventArgs eventArgs)
        {
            _isClosing = false;
            BorderColor = NormalBorderColor;
        }

        private void ParentFormOnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            //balloonToolTip.Dispose();
            balloonToolTip.Hide(textBox);
            _isClosing = true;
        }

    }
}
