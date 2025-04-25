using Gestin.Properties;
using Gestin.UI.Commons;

namespace Gestin.Deprecated
{
    public partial class formRecoverPass : Form
    {
        mailKitController cntMail = mailKitController.getInstance();
        public formRecoverPass()
        {
            InitializeComponent();
        }
        #region "Minimizar,cerrar y arrastrar"
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formRecuperarPassword_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validEmail())
            {
                if (cntMail.sendPasswordRecoverEmail(txtEmail.Text))
                {
                    lblError1.Visible = false;
                    MessageBox.Show("Hemos enviado un codigo para recuperar su contraseña a su mail");
                    panel3.Visible = false;
                    panel2.Visible = true;
                }
                else
                {
                    lblError1.Visible = true;
                    lblError1.Text = "        Error. Por favor, intentelo nuevamente mas tarde";
                }
            }
            else
            {
                lblError1.Visible = true;
                lblError1.Text = "        Error. Email invalido";
            }
        }


        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (validAuthenticationCod() == false)
            {
                lblError2.Visible = true;
                lblError2.Text = "        Error. El codigo es incorrecto";
            }
            else if (validPassword() == false)
            {
                lblError2.Visible = true;
                lblError2.Text = "        Error. La contraseña no es valida";
            }
            else if (validConfirPass() == false)
            {
                lblError2.Visible = true;
                lblError2.Text = "        Error. Las contraseñas no coinciden";
            }
            else
            {
                //cntMail.changePass(txtEmail.Text, System.Web.Helpers.Crypto.HashPassword(txtNewPass.Text));
                formShowInfo formBienvenido = new formShowInfo("¡Contraseña cambiada con exito!", Resources.Done);
                formBienvenido.ShowDialog();
                this.Close();
            }

        }
        bool validEmail()
        {
            var trimmedEmail = txtEmail.Text.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        bool validPassword()
        {
            if (txtNewPass.Text.Length > 6) { return true; }
            return false;
        }
        bool validConfirPass()
        {
            if (txtNewPass.Text.Equals(txtVerifyNewPass.Text)) { return true; }
            return false;
        }
        bool validAuthenticationCod()
        {
            return cntMail.verifyCode(txtCodVerificacion.Text);
        }

        private void pbViewCod_Click(object sender, EventArgs e)
        {
            if (txtCodVerificacion.UseSystemPasswordChar)
            {
                txtCodVerificacion.UseSystemPasswordChar = false;
            }
            else
            {
                txtCodVerificacion.UseSystemPasswordChar = true;
            }
        }

        private void pbViewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.UseSystemPasswordChar)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void pbViewConfPass_Click(object sender, EventArgs e)
        {
            if (txtVerifyNewPass.UseSystemPasswordChar)
            {
                txtVerifyNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtVerifyNewPass.UseSystemPasswordChar = true;
            }
        }
    }
}
