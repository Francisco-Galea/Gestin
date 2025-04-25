using Gestin.Controllers;
using Gestin.LocalFiles;
using Gestin.UI.EventHandlers;

namespace Gestin.UI.Login
{
    public partial class formLogin : Form
    {
        securityController securityController = securityController.getInstance();
        sessionController sessionController = sessionController.getInstance();
        LocalGestinSettings LocalSettings = LocalGestinSettings.Instance;

        public event EventHandler<ResponseEventHandler> returnCheckedSession;

        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cbbUserType.SelectedIndex = 0;
            checkForRemembered();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void attemptLogin()
        {
            btnLogin.Text = "Cargando...";
            btnLogin.Enabled = false;
            

            if (checkInputs())
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string? selectedType = Convert.ToString(cbbUserType.SelectedItem);
                try
                {
                    if (securityController.verifyUserLogin(email, password, selectedType))
                    {
                        bool sessionCreation = sessionController.createUserSession(email, selectedType);
                        ResponseEventHandler sessionCheckEvent = new ResponseEventHandler(sessionCreation);
                        returnCheckedSession?.Invoke(this, sessionCheckEvent);

                        if (chkRemember.Checked) 
                        {
                            LocalSettings.editFileSection("SavedLogin", [email, selectedType]); 
                        }
                        else { LocalSettings.deleteByFileSection("SavedLogin"); }

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            resetLogin();
        }

        private bool checkInputs()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { lblEmailVacio.Visible = true; return false;  }

            if (string.IsNullOrWhiteSpace(txtPassword.Text)) { lblPasswordVacio.Visible = true; return false; }

            if (string.IsNullOrEmpty(Convert.ToString(cbbUserType.SelectedItem))) { return false; };

            return true;
        }

        private void checkForRemembered()
        {
            List<string> rememberedData = LocalGestinSettings.Instance.readFileDataBySection("SavedLogin");

            try
            {
                if (rememberedData.Any())
                {
                    if (rememberedData[0] != string.Empty) //Email
                    {
                        txtEmail.Text = rememberedData[0];
                    }
                    if (rememberedData[1] != string.Empty) //UserType
                    {
                        if(cbbUserType.Items.Contains(rememberedData[1]))
                        {
                            cbbUserType.Text = rememberedData[1];
                        }
                    }
                    chkRemember.Checked = true;
                }
            }
            catch (ArgumentOutOfRangeException) { LocalGestinSettings.Instance.deleteByFileSection("SavedLogin"); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            attemptLogin();
        }

        private void resetLogin()
        {
            btnLogin.Text = "Login";
            lblSessionCheck.Visible = true;
            btnLogin.Enabled = true;
            StartLableRemovalTimer();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formLogin_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //formStudentEnroment formRegistroAlumno = new formStudentEnroment();
            //formRegistroAlumno.ShowDialog();
        }

        private void linkRecuperarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //formRecoverPass formRecuperarPassword = new formRecoverPass();
            //formRecuperarPassword.ShowDialog();
        }

        private void StartLableRemovalTimer()
        {
            timerHideError.Interval = 3000; // 3 segundos
            timerHideError.Tick += timerHideError_Tick;
            timerHideError.Start();
        }

        private void timerHideError_Tick(object sender, EventArgs e)
        {
            lblSessionCheck.Visible = false;
            lblEmailVacio.Visible = false;
            lblPasswordVacio.Visible = false;
            //btnLogin.Enabled = true;
            timerHideError.Stop();
        }
        private void formLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Enter
                attemptLogin();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Enter
            {
                e.Handled = true;
                attemptLogin();
            }
            if (e.KeyChar == (char)9) //Tab
            {
                e.Handled = true;
                attemptLogin();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Enter
            {
                e.Handled = true;
                attemptLogin();
            }
            if (e.KeyChar == (char)9) //Tab
            {
                e.Handled = true;
                attemptLogin();
            }
        }
    }
}
