using Gestin.Controllers;

namespace Gestin.Deprecated
{
    public partial class formStudentEnroment : Form
    {
        userController userController = userController.getInstance();
        public formStudentEnroment()
        {
            InitializeComponent();
        }

        #region "Minimizar,cerrar y arrastrar"
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formRegistroAlumno_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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


        #region Verificaciones
        bool verifyAll()
        {
            if (validEmail() == false)
            {
                updateErrorLbl("         Email invalido");
                return false;
            }
            if (validPassword() == false)
            {
                updateErrorLbl("         La contraseña debe tener al menos 7 caracteres");
                return false;
            }
            if (validConfirPass() == false)
            {
                updateErrorLbl("         Las contraseñas deben coincidir");
                return false;
            }
            if (validName() == false)
            {
                updateErrorLbl("         Nombre invalido");
                return false;
            }
            if (validSurame() == false)
            {
                updateErrorLbl("         Apellido invalido");
                return false;
            }
            if (validDni() == false)
            {
                updateErrorLbl("         DNI invalido");
                return false;
            }
            if (validBirthplace() == false)
            {
                updateErrorLbl("         Lugar de nacimiento invalido");
                return false;
            }
            if (validBirthday() == false)
            {
                updateErrorLbl("         Fecha de nacimiento invalido");
                return false;
            }
            if (validGenre() == false)
            {
                updateErrorLbl("         Seleccione un sexo");
                return false;
            }
            if (validPhoneNumber() == false)
            {
                updateErrorLbl("         Celular invalido");
                return false;
            }
            if (validEmergencyPhoneNumber() == false)
            {
                updateErrorLbl("         Celular de emergencia invalido");
                return false;
            }
            if (validWorking() == false)
            {
                updateErrorLbl("         Seleccione si trabaja");
                return false;
            }
            lblError.Visible = false;
            return true;

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
            if (txtPassword.Text.Length > 6) { return true; }
            return false;
        }
        bool validConfirPass()
        {
            if (txtConfirPassword.Text.Equals(txtPassword.Text)) { return true; }
            return false;
        }
        bool validName()
        {
            if (txtNombre.Text.Length > 1) { return true; }
            return false;
        }
        bool validSurame()
        {
            if (txtApellido.Text.Length > 1) { return true; }
            return false;
        }
        bool validDni()
        {
            if (txtDni.Text.Length > 1 && int.TryParse(txtDni.Text, out _)) { return true; }
            return false;
        }
        bool validBirthplace()
        {
            if (txtLugarDeNacimiento.Text.Length > 1) { return true; }
            return false;
        }
        bool validBirthday()
        {
            if (DateOnly.TryParse(txtFechaDeNacimiento.Text, out _)) { return true; }
            return false;
        }
        bool validGenre()
        {
            if (cbSexo.SelectedIndex > -1) { return true; }
            return false;
        }
        bool validPhoneNumber()
        {
            if (txtCelular.Text.Length > 1) { return true; }
            return false;
        }
        bool validEmergencyPhoneNumber()
        {
            if (txtCelularDeEmergencia.Text.Length > 1) { return true; }
            return false;
        }
        bool validWorking()
        {
            if (cbTrabaja.SelectedIndex > -1) { return true; }
            return false;
        }
        bool validWorkactivity()
        {
            if (txtActividadLaboral.Text.Length > 1) { return true; }
            return false;
        }
        bool validworkinghours()
        {
            if (txtHorarioLaboral.Text.Length > 1) { return true; }
            return false;
        }
        #endregion
        private void picInfo_MouseHover(object sender, EventArgs e)
        {
            toolTipFechaDeNacimiento.Show("   El formato correcto es: dd/mm/aaaa", picInfo);
        }
        void updateErrorLbl(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }
        void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (verifyAll())
            {
                //String pass = System.Web.Helpers.Crypto.HashPassword(txtPassword.Text);
                DateTime fecha = DateTime.Parse(txtFechaDeNacimiento.Text);
                /* Re add on a later date when passwords have been added
                if (userController.enrolStudent(Int32.Parse(txtDni.Text), txtEmail.Text, pass, txtNombre.Text, txtApellido.Text,
                                                    fecha, txtLugarDeNacimiento.Text, cbSexo.Text, txtCelular.Text, txtCelularDeEmergencia.Text,txtObraSocial.Text,
                                                    txtActividadLaboral.Text,txtHorarioLaboral.Text))
                {
                
                formShowInfo formBienvenido = new formShowInfo("¡Bienvenido!", Resources.Done);
                formBienvenido.ShowDialog();
                this.Close();
                }
                else {
                    updateErrorLbl("     Error, por favor intentelo nuevamente");
                }
                */
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            txtEmail.Focus();
        }
        void clear()
        {
            txtDni.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirPassword.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaDeNacimiento.Text = "";
            txtLugarDeNacimiento.Text = "";
            txtCelular.Text = "";
            txtCelularDeEmergencia.Text = "";
            txtObraSocial.Text = "";
            txtActividadLaboral.Text = "";
            txtHorarioLaboral.Text = "";
            cbSexo.SelectedIndex = -1;
            cbTrabaja.SelectedIndex = -1;
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

        private void btnViewConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtConfirPassword.UseSystemPasswordChar)
            {
                txtConfirPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirPassword.UseSystemPasswordChar = true;
            }
        }

        private void formRegistroAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
