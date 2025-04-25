using Gestin.Controllers;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.Validators;
using Color = System.Drawing.Color;

namespace Gestin.UI.Home.Users
{
    public partial class formUser : Form
    {
        userController userController = userController.getInstance();
        careerEnrolmentController careerEnrolmentController = careerEnrolmentController.getInstance();
        studentController studentController = studentController.getInstance();
        teacherController teacherController = teacherController.getInstance();
        object? selectedUser;

        public formUser()
        {
            InitializeComponent();
        }

        private void formUser_Load(object sender, EventArgs e)
        {
            nullCheck();
            cbbUserRole.SelectedIndex = 0;
        }

        private void nullCheck()
        {
            if (userController.countUsers() != 0)
            {
                refreshUserStatistics();
            }
        }

        private void cbbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUserRole.SelectedIndex != 0)
            {
                nullifySearchResults();
                clearScreen();
            }
        }

        private bool validateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUserDni.Text) || string.IsNullOrWhiteSpace(txtUserLastName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                new MessageBoxDarkMode("Complete todos los campos obligatorios [DNI | Apellido | Nombre]", "Error", "Ok", Resources.BigErrorIcon, true);
                return false;
            }
            if (!txtUserDni.Text.All(char.IsDigit))
            {
                toolTip.Show("", txtUserDni, 1);
                toolTip.Show("El dni debe tener solamente digitos", txtUserDni, 3000);
                return false;
            }
            if (cbbGender.SelectedItem == null)
            {
                toolTip.Show("", cbbGender, 1);
                toolTip.Show("Debe seleccionar un Género para este estudiante!", cbbGender, 3000);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtUserPhoneNumber.Text) && !txtUserPhoneNumber.Text.All((char.IsDigit)))
            {
                toolTip.Show("", txtUserPhoneNumber, 1);
                toolTip.Show("El numero de telefono debe tener solamente digitos!", txtUserPhoneNumber, 3000);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtUserEmergencyContact.Text) && !txtUserEmergencyContact.Text.All((char.IsDigit)))
            {
                toolTip.Show("", txtUserEmergencyContact, 1);
                toolTip.Show("El numero de emergecia debe tener solamente digitos!", txtUserEmergencyContact, 3000);
                return false;
            }
            if (UserDateBirth.Value.Date.Equals(DateTime.Now) || DateTime.Now < UserDateBirth.Value.Date)
            {
                toolTip.Show("", UserDateBirth, 1);
                toolTip.Show("Fecha incorrecta!", UserDateBirth, 3000);
                return false;
            }
            return true;
        }

        private void clearScreen()
        {
            startLableRemovalTimer();
            refreshUserStatistics();
            txtUserBirthPlace.ResetText();
            txtUserDni.ResetText();
            txtUserEmergencyContact.ResetText();
            txtUserLastName.ResetText();
            txtUserName.ResetText();
            txtUserPhoneNumber.ResetText();
            UserDateBirth.ResetText();
            txtUserResult.ResetText();
            textBoxSearchBar.ResetText();
            resetUserValues();
        }

        private void refreshUserStatistics()
        {
            lblStudentCount.Text = studentController.countUserType().ToString();
            lblTeacherCount.Text = teacherController.countUserType().ToString();
            lblUserCount.Text = userController.countUsers().ToString();

            object? lastCreatedUser = userController.findLastCreatedUser();
            object? lastCreatedStudent = studentController.findLastCreatedUserType();
            object? lastCreatedTeacher = teacherController.findLastCreatedUserType();

            if (lastCreatedUser != null)
            {
                lblLastUser.Text = userController.getUserFullName(lastCreatedUser);
            }
            if (lastCreatedStudent != null)
            {
                lblLastStudent.Text = studentController.getUserTypeFullName(lastCreatedStudent);
            }
            if (lastCreatedTeacher != null)
            {
                lblLastTeacher.Text = teacherController.getUserTypeFullName(lastCreatedTeacher);
            }
        }

        private void nullifySearchResults()
        {
            listBoxSearchResults.DataSource = null;
            listBoxSearchResults.ResetText();
        }

        private void setUserValues(object user)
        {
            List<string?> selectedUserValues = userController.getUserValues(user);

            txtUserDni.Text = selectedUserValues[0];
            txtUserLastName.Text = selectedUserValues[1];
            txtUserName.Text = selectedUserValues[2];
            txtUserPhoneNumber.Text = selectedUserValues[3];
            UserDateBirth.Text = selectedUserValues[4];
            txtUserBirthPlace.Text = selectedUserValues[5];
            txtUserEmergencyContact.Text = selectedUserValues[6];
            cbbGender.SelectedItem = selectedUserValues[7]; //este estaba en selectedValue por eso traia null
            setCbbListCareers();

        }

        private void setCbbListCareers()
        {
            if (txtUserDni.Text != string.Empty)
            {
                int dni = Convert.ToInt32(txtUserDni.Text);
                cbbListCareer.DataSource = careerEnrolmentController.searchEnrollableCareers(dni);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedUser == null) { creatingUser(); } else { updatingUser(); }
        }

        private void creatingUser()
        {
            if (validateInputs())
            {
                MessageBoxDarkMode messageBox = new MessageBoxDarkMode($"¿Crear usuario: {txtUserName.Text} {txtUserLastName.Text} ?", "Crear Usuario", "OkCancel", Resources.advertencia, true);

                if (generalValidator.messageBoxDialogResult(messageBox))
                {
                    if (userController.createUser(Int32.Parse(txtUserDni.Text), txtUserName.Text, txtUserLastName.Text, UserDateBirth.Value.Date,
                    txtUserBirthPlace.Text, txtUserPhoneNumber.Text, txtUserEmergencyContact.Text, Convert.ToString(cbbGender.SelectedItem)))
                    {
                        lblResult.Text = "Usuario creado";
                        lblResult.Visible = true;
                        clearScreen();
                    }
                }
            }
        }

        private void updatingUser()
        {
            if (validateInputs())
            {
                MessageBoxDarkMode messageBox = new MessageBoxDarkMode($"¿Modificar usuario {txtUserName.Text} {txtUserLastName.Text} ?", "Modificar Usuario", "OkCancel", Resources.advertencia, true);
                if (generalValidator.messageBoxDialogResult(messageBox))
                {
                    if (userController.updateUser(selectedUser, Int32.Parse(txtUserDni.Text), txtUserName.Text, txtUserLastName.Text, UserDateBirth.Value.Date,
                            txtUserBirthPlace.Text, txtUserPhoneNumber.Text, txtUserEmergencyContact.Text, Convert.ToString(cbbGender.SelectedItem)))
                    {
                        lblResult.Text = "Usuario modificado";
                        lblResult.Visible = true;
                        clearScreen();
                    }
                }
            }
        }

        private void btnSoftDelete_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                if (!studentController.doesUserTypeExist(selectedUser) && !teacherController.doesUserTypeExist(selectedUser))
                {
                    MessageBoxDarkMode messageBox = new MessageBoxDarkMode($"¿Dar de baja a {txtUserName.Text} {txtUserLastName.Text} ?", "Dar de Baja", "OkCancel", Resources.Error, true);

                    if (generalValidator.messageBoxDialogResult(messageBox) && userController.softDeleteUser(selectedUser))
                    {
                        lblResult.Visible = true;
                        lblResult.Text = "Usuario dado de baja";
                        clearScreen();
                    }
                }
                else { new MessageBoxDarkMode("El usuario no puede tener asignado un rol", "Error", "Ok", Resources.Error, true); }
            }
            else { new MessageBoxDarkMode("Seleccione a un usuario", "Error", "Ok", Resources.Error, true); }
        }

        public void startLableRemovalTimer()
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

        public void refreshSelectedUserItems(string name)
        {
            txtUserResult.Text = name;
            panelSelectedUser.Enabled = true;
            panelRole.Enabled = true;
        }


        private void loadSearchResults()
        {
            bool checkState = Int32.TryParse(textBoxSearchBar.Text, out _);

            if (checkState)
            {
                listBoxSearchResults.DataSource = userController.searchBoxUserWithInt(Int32.Parse(textBoxSearchBar.Text));
            }
            else
            {
                listBoxSearchResults.DataSource = userController.searchBoxUserWithString(textBoxSearchBar.Text);
            }
        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchBar.Text.Length == 0)
            {
                listBoxSearchResults.Visible = false;
                selectedUser = null;
                clearScreen();
            }
            else
            {
                listBoxSearchResults.Visible = true;
                loadSearchResults();
            }
        }

        private void textBoxSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxSearchResults.Focus();
            }
            if (e.KeyCode == Keys.Enter && listBoxSearchResults.SelectedIndex >= 0)
            {
                loadUser();
            }
        }

        private void listBoxSearchResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && listBoxSearchResults.SelectedIndex <= 0)
            {
                textBoxSearchBar.Focus();
            }
            if (e.KeyCode == Keys.Enter && listBoxSearchResults.SelectedIndex >= 0)
            {
                loadUser();
            }
        }

        private void listBoxSearchResults_Click(object sender, EventArgs e)
        {
            if (listBoxSearchResults.SelectedIndex >= 0)
            {
                loadUser();
            }
        }

        private void loadUser()
        {
            selectedUser = listBoxSearchResults.SelectedItem;
            refreshUser();
        }

        private void refreshUser()
        {
            if (selectedUser != null)
            {
                refreshSelectedUserItems(userController.getUser(selectedUser).fullName());
                setUserValues(selectedUser);
                checkUserHasType();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void resetUserValues()
        {
            uncheckAllItems();
            panelSelectedUser.Enabled = false;
            panelRole.Enabled = false;
            panelEnrolonment.Enabled = false;
        }

        private void checkUserHasType()
        {
            uncheckAllItems();

            if (selectedUser != null)
            {
                if (studentController.findUserType(selectedUser) != null)
                {
                    checkBoxEstudiante.Checked = true;
                    checkBoxEstudiante.BackColor = Color.FromArgb(118, 255, 3);
                    panelEnrolonment.Enabled = true;

                }
                if (teacherController.findUserType(selectedUser) != null)
                {
                    checkBoxDocente.Checked = true;
                    checkBoxDocente.BackColor = Color.FromArgb(118, 255, 3);
                }
            }
        }

        private void uncheckAllItems()
        {
            checkBoxEstudiante.Checked = false;
            checkBoxDocente.Checked = false;
            checkBoxEstudiante.BackColor = Color.DimGray;
            checkBoxDocente.BackColor = Color.DimGray;
        }

        private void btnBuscarSinCargos_Click(object sender, EventArgs e)
        {
            formUserRoleless childForm = new formUserRoleless();
            childForm.ShowDialog();
        }

        private void btnAssignRole_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                Visible = false;
                string? userRole = cbbUserRole.SelectedItem != null ? Convert.ToString(cbbUserRole.SelectedItem) : "";
                formUserRole childForm = new formUserRole(selectedUser, userRole, this);
                clearScreen();
                childForm.ShowDialog();
            }
            else
            {
                new MessageBoxDarkMode("Primero seleccione un usuario", "Error", "Ok", Resources.Error, true);
            }
        }

        private void btnSaveCareerEnrolment_Click(object sender, EventArgs e)
        {
            if (selectedUser != null && checkBoxEstudiante.Checked)
            {
                var student = studentController.findUserType(selectedUser);
                object? selectedCareer = cbbListCareer.SelectedItem;

                if (student != null && selectedCareer != null)
                {
                    if (careerEnrolmentController.enrolStudent(student, selectedCareer, DateTime.Today.Year))
                    {
                        //lblResult.Text = $"El estudiante se matriculo a la carrera {cbbListCareer.SelectedText} correctamente";
                        new MessageBoxDarkMode($"El estudiante fue inscrito a la carrera {cbbListCareer.Text} exitosamente!", "Éxito", "Ok", Resources.Done, true);
                        clearScreen();
                    }
                }
            }
            else
            {
                new MessageBoxDarkMode("El usuario debe tener el rol de estudiante antes de inscribirse a una carrera", "Error", "Ok", Resources.Error, true);
            }
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
