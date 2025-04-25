using Gestin.Controllers;
using Gestin.Interfaces;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;

namespace Gestin.UI.Home.Users
{
    public partial class formUserRole : Form
    {
        formUser parentFormSubject;
        userController userController = userController.getInstance();
        sessionController sessionController = sessionController.getInstance();
        IUserTypeController userTypeController;
        object receivedUser;
        string receivedUserRole;
        static string? originalEmail;
        bool isStudentType;

        public formUserRole(object sentUser, string sentUserRole, formUser sentformUser)
        {
            InitializeComponent();
            parentFormSubject = sentformUser;
            receivedUser = sentUser;
            receivedUserRole = sentUserRole;
        }

        private void formUserRole_Load(object sender, EventArgs e)
        {
            setForm();
            setUserRoleValues();
        }

        private void formUserType_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentFormSubject.Show();
        }

        private void setForm()
        {
            if (receivedUserRole.Equals("Estudiante"))
            {
                userTypeController = studentController.getInstance();
                hideTeacherElements();
                isStudentType = true;
            }
            else
            {
                userTypeController = teacherController.getInstance();
                hideStudentElements();
                isStudentType = false;
            }
            lblUserName.Text = userController.getUser(receivedUser).fullName();
            lblUserRole.Text = receivedUserRole;
        }

        private void setUserRoleValues()
        {
            checkUserTypeStatus();
            List<dynamic?> userRoleValues;

            if (checkIfUserHasRequiredRole())
            {
                if (isStudentType)
                {
                    userRoleValues = userTypeController.getUserTypeValues(receivedUser);
                    txtUserEmail.Text = userRoleValues[0];
                    txtPassword.Text = userRoleValues[1];
                    txtOcupation.Text = userRoleValues[2];
                    txtWorkHours.Text = userRoleValues[3];
                    txtHealthcare.Text = userRoleValues[4];
                    chkAnalitic.Checked = userRoleValues[5];
                    chkBirthCertificate.Checked = userRoleValues[6];
                    chkCUIL.Checked = userRoleValues[7];
                    chkDNI.Checked = userRoleValues[8];
                    chkMedicalCertificate.Checked = userRoleValues[9];
                    chkPhoto.Checked = userRoleValues[10];
                    chkCooperative.Checked = userRoleValues[11];
                }
                else
                {
                    userRoleValues = userTypeController.getUserTypeValues(receivedUser);
                    txtUserEmail.Text = userRoleValues[0];
                    txtPassword.Text = userRoleValues[1];
                    txtTitle.Text = userRoleValues[2];
                    txtCuil.Text = userRoleValues[3];
                }
                txtPasswordConfirm.ResetText();
                originalEmail = txtUserEmail.Text;
            }
        }

        private void clearScreen()
        {
            checkUserTypeStatus();
            txtUserEmail.ResetText();
            txtOcupation.ResetText();
            txtWorkHours.ResetText();
            txtHealthcare.ResetText();
            txtPassword.ResetText();
            txtPasswordConfirm.ResetText();
            chkAnalitic.Checked = false;
            chkBirthCertificate.Checked = false;
            chkCUIL.Checked = false;
            chkDNI.Checked = false;
            chkMedicalCertificate.Checked = false;
            chkPhoto.Checked = false;
            chkCooperative.Checked = false;
            txtTitle.ResetText();
            txtCuil.ResetText();
            startLableRemovalTimer();
            checkUserTypeStatus();
        }

        private bool checkIfUserHasRequiredRole()
        {
            return userTypeController.findUserType(receivedUser) != null;
        }

        private void hideStudentElements()
        {
            lblOcupation.Visible = false;
            lblWorkHours.Visible = false;
            lblHealthcare.Visible = false;
            txtOcupation.Visible = false;
            txtWorkHours.Visible = false;
            txtHealthcare.Visible = false;
            chkAnalitic.Visible = false;
            chkBirthCertificate.Visible = false;
            chkCUIL.Visible = false;
            chkDNI.Visible = false;
            chkMedicalCertificate.Visible = false;
            chkPhoto.Visible = false;
            chkCooperative.Visible = false;
        }

        private void hideTeacherElements()
        {
            lblTitle.Visible = false;
            lblCuil.Visible = false;
            txtTitle.Visible = false;
            txtCuil.Visible = false;
        }

        private void checkUserTypeStatus()
        {
            if (checkIfUserHasRequiredRole())
            {
                chkStatus.Checked = true;
                chkStatus.BackColor = Color.FromArgb(118, 255, 3);
            }
            else
            {
                chkStatus.Checked = false;
                chkStatus.BackColor = Color.DimGray;
            }
            deactivateControlsIfDeletedTypeDetected();
        }

        private bool validateEmail() //more things need to be added later
        {
            string enteredMail = txtUserEmail.Text;

            if (emailValidator.isNull(enteredMail))
            {
                toolTip.Show("", txtUserEmail, 1); //Quick reset
                toolTip.Show("El correo no puede ser nulo!", txtUserEmail, 3000);
                return false;
            }
            if (!emailValidator.IsValidEmail(enteredMail))
            {
                toolTip.Show("", txtUserEmail, 1);
                toolTip.Show($"{enteredMail} no es un correo valido", txtUserEmail, 3000);
                return false;
            }
            if (!userTypeController.isUserTypeEmailUnique(receivedUser, enteredMail))
            {
                toolTip.Show("", txtUserEmail, 1);
                toolTip.Show($"Ya existe un usuario de rol de {receivedUserRole} con ese email", txtUserEmail, 3000);
                return false;
            }
            /*if (!sessionController.IsSessionedUserChangeDetected(receivedUser)) //revise later //No longer necessary
            {
                new MessageBoxDarkMode("No se puede modificar un usuario en sesion", "Error", "Ok", Resources.Error, true);
                return false;
            }
            */
            return true;
        }

        private bool validatePassword()
        {
            string password = txtPassword.Text;
            string confirmPassword = txtPasswordConfirm.Text;

            if (passwordValidator.arePasswordsNull(password, confirmPassword))
            {
                txtPassword.Text = string.Empty;
                return true; //Allow changes without changing password
            }
            if (passwordValidator.isNull(password))
            {
                toolTip.Show("", txtPassword, 1);
                toolTip.Show("La contraseña no puede ser nula!", txtPassword, 3000);
                return false;
            }
            if (passwordValidator.obfuscatedPasswordExists(password))
            {
                toolTip.Show("", txtPassword, 1);
                toolTip.Show("Existe una contraseña para este usuario, por favor ingrese una nueva o existente contraseña!", txtPassword, 3000);
                return false;
            }
            if (!passwordValidator.arePasswordsMinimumLength(password, confirmPassword))
            {
                toolTip.Show("", txtPassword, 1);
                toolTip.Show("La contraseña debe tener como minimo 8 caracteres", txtPassword, 3000);
                return false;
            }
            if (!passwordValidator.arePasswordsSame(password, confirmPassword))
            {
                toolTip.Show("", txtPasswordConfirm, 1);
                toolTip.Show("Las contraseñas deben coincidir!", txtPasswordConfirm, 3000);
                return false;
            }
            return true;
        }

        private bool validateInputs()
        {
            if (isStudentType)
            {
                if (!string.IsNullOrWhiteSpace(txtWorkHours.Text) && !txtWorkHours.Text.All(char.IsDigit))
                {
                    toolTip.Show("", txtWorkHours, 1);
                    toolTip.Show("Horas de trabajo en forma numerica", txtWorkHours, 3000);
                    return false;
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtCuil.Text) && !txtCuil.Text.All(char.IsDigit))
                {
                    toolTip.Show("", txtCuil, 1);
                    toolTip.Show("El CUIL debe tener solamente digitos", txtCuil, 3000);
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateInputs() && validateEmail() && validatePassword())
                {
                    if (isStudentType) //Student
                    {
                        userTypeController.saveUserType(receivedUser, originalEmail, txtUserEmail.Text, txtPassword.Text, txtOcupation.Text, txtWorkHours.Text, txtHealthcare.Text,
                        chkAnalitic.Checked, chkDNI.Checked, chkBirthCertificate.Checked, chkMedicalCertificate.Checked, chkPhoto.Checked, chkCUIL.Checked, chkCooperative.Checked);
                    }
                    else //Teacher
                    {
                        userTypeController.saveUserType(receivedUser, originalEmail, txtUserEmail.Text, txtPassword.Text, txtCuil.Text, txtTitle.Text);
                    }
                    setUserRoleValues();
                    changeLable();
                    lblResult.Text += " guardado";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (sessionController.IsSessionedUserChangeDetected(receivedUser))
            {
                MessageBoxDarkMode messageBox = new MessageBoxDarkMode($"¿Dar de baja a {userController.getUser(receivedUser).fullName()} del rol de {receivedUserRole}?", "Dar de Baja de rol", "OkCancel", Resources.advertencia, true);
                bool confirmResponse = generalValidator.messageBoxDialogResult(messageBox);

                if (userTypeController.findUserType(receivedUser) != null)
                {
                    if (isStudentType) //Student
                    {
                        if (confirmResponse)
                        {
                            userTypeController.softDeleteUserType(receivedUser);
                            uponDeletion();
                        }
                    }
                    else //Teacher
                    {
                        if (confirmResponse)
                        {
                            messageBox = new MessageBoxDarkMode($"Este docente sera dado de baja de todas las materias asignadas, esta seguro que desea continuar?", "Dar de Baja rol docente", "OkCancel", Resources.advertencia, true);
                            bool confirm = generalValidator.messageBoxDialogResult(messageBox);
                            if (confirm)
                            {
                                userTypeController.softDeleteUserType(receivedUser);
                                uponDeletion();
                            }
                        }
                    }
                }
                else
                {
                    new MessageBoxDarkMode("No se puede dar de baja al rol de un usuario que previamente no tuvo", "Error", "Ok", Resources.Error, true);
                }
            }
            else
            {
                new MessageBoxDarkMode("No se puede dar de baja a un usuario en sesion", "Error", "Ok", Resources.Error, true);
            }

        }

        private void btnReactivate_Click(object sender, EventArgs e)
        {
            MessageBoxDarkMode messageBox = new MessageBoxDarkMode($"Estas seguro en reactivar a {userController.getUser(receivedUser).fullName()} del rol de {receivedUserRole} ?", "Reactivar", "OkCancel", Resources.info, true);
            bool confirmResponse = generalValidator.messageBoxDialogResult(messageBox);

            if (confirmResponse)
            {
                userTypeController.reactivateDeletedUserType(receivedUser);
                uponReactivation();
            }
        }

        private void deactivateControlsIfDeletedTypeDetected()
        {
            if (isStudentType && userTypeController.isUserTypeDeleted(receivedUser))
            {
                deactivateControls();
            }
            else if (!isStudentType && userTypeController.isUserTypeDeleted(receivedUser))
            {
                deactivateControls();
            }
        }

        private void uponDeletion()
        {
            reactivateControls();
            changeLable();
            clearScreen();
            lblResult.Text += " dado de baja";
        }

        private void uponReactivation()
        {
            reactivateControls();
            lblResult.Text += " reactivado";
        }

        private void reactivateControls()
        {
            labelHidden.Visible = false;
            RolePanel.Enabled = true;
            panelLogin.Enabled = true;
            btnSave.Visible = true;
            btnDelete.Visible = true;
            btnReactivate.Visible = false;
            setUserRoleValues();
        }

        private void deactivateControls()
        {
            labelHidden.Visible = true;
            btnReactivate.Visible = true;
            RolePanel.Enabled = false;
            panelLogin.Enabled = false;
            btnSave.Visible = false;
            btnDelete.Visible = false;
        }

        private void changeLable()
        {
            lblResult.Text = isStudentType ? "Estudiante" : "Docente";
            lblResult.Visible = true;
            startLableRemovalTimer();
        }

        private void startLableRemovalTimer()
        {
            lableTimer.Interval = 2500; // 2.5 segundos
            lableTimer.Tick += lableTimer_Tick;
            lableTimer.Start();
        }

        private void lableTimer_Tick(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            lableTimer.Stop();
        }

        private void btnSeePasswords_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar && txtPasswordConfirm.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPasswordConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
