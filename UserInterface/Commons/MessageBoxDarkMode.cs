using Gestin.UI.EventHandlers;

namespace Gestin.UI.Custom
{
    public partial class MessageBoxDarkMode : Form
    {
        #pragma warning disable CS8618
        public event EventHandler<ResponseEventHandler> ResponseEvent; //Subscribe to this event if using OkCancel
        ResponseEventHandler response = new ResponseEventHandler();
        string _Caption;
        string _Message;
        string _Buttons;
        Image _Image;
        bool _UserAttention;

        public MessageBoxDarkMode(string message, string caption, string buttons, Image image, bool userAttention)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            checkNulls(message, caption, buttons, image, userAttention);
        }

        public MessageBoxDarkMode(string message, string caption, string buttons, Image image)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            checkNulls(message, caption, buttons, image, false);
        }

        public MessageBoxDarkMode(string message, string caption, string buttons, Image image, bool userAttention, Color backColor)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            setBackColorForm(backColor);
            checkNulls(message, caption, buttons, image, userAttention);
        }

        public void checkNulls(string message, string caption, string buttons, Image image, bool userAttention)
        {
            if (message != null && caption != null && buttons != null && image != null)
            {
                _Message = message;
                _Caption = caption;
                _Buttons = buttons;
                _Image = image;
                _UserAttention = userAttention;
                setUI();
            }
            else
            {
                throw new InvalidOperationException("One or more of the message box attributes are null");
            }
        }

        public void setUI()
        {
            this.Text = _Caption;
            lblMessage.Text = _Message;
            pictureBoxImage.BackgroundImage = _Image;

            if (_Buttons.Equals("Ok") || _Buttons.Equals("Yes"))
            {
                btnConfirm.Location = new Point(240, 15);
                btnConfirm.Visible = true;
                if (_UserAttention)
                {
                    ShowDialog();
                }
                else
                {
                    Show();
                }
            }
            //Boton Ok/Cancel
            else if (_Buttons.Equals("OkCancel"))
            {
                btnConfirm.Visible = true;
                btnCancel.Visible = true;
                btnCancel.Text = "Cancelar";
            }
            //Boton Si/No
            else if (_Buttons.Equals("YesNo"))
            {
                btnConfirm.Text = "Si";
                btnCancel.Text = "No";
                btnConfirm.Visible = true;
                btnCancel.Visible = true;
            }
            //Boton Retry/Exit
            else if (_Buttons.Equals("RetryExit"))
            {
                btnConfirm.Text = "Reintentar";
                btnCancel.Text = "Salir";
                btnConfirm.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                throw new InvalidOperationException("Incorrect Message Box Buttons Parameters");
            }
        }
        private void setBackColorForm(Color color)
        {
            panel1.BackColor = color;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ResponseEvent != null)
            {
                response.status = true;
                ResponseEvent.Invoke(this, response);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ResponseEvent != null)
            {
                response.status = false;
                ResponseEvent.Invoke(this, response);
            }
            this.Close();
        }
    }
}
