using Gestin.Model.Model_Internal;
using Gestin.Controllers;
using Gestin.Interfaces;
using Gestin.Properties;
using Gestin.UI.Custom;
using Gestin.UI.EventHandlers;
using Gestin.UI.Home.Careers;
using Gestin.UI.Home.Enrolments;
using Gestin.UI.Home.ExamEnrolment;
using Gestin.UI.Home.Exams;
using Gestin.UI.Home.Schedules;
using Gestin.UI.Home.Students;
using Gestin.UI.Home.Subjects;
using Gestin.UI.Home.Users;
using Gestin.UI.Home.Reportes;
using Gestin.UI.Login;
using Gestin.UI.Settings;
using Gestin.Validators;

namespace Gestin.UI.Home
{
    public partial class formHome : Form
    {
#pragma warning disable CS4014 //remove async warnings
        private Form? formActive;
        sessionController sessionController = sessionController.getInstance();
        IUserType? sessionedUser;
        List<Control> listButtonsMenu;
        bool debugIgnoreLogin = false;

        public formHome()
        {
            InitializeComponent();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            setMenuButtonsList();
            loadDataAsync();
        }

        private void formHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async Task loadDataAsync()
        {
            await insertFormIndex();

            await Task.Delay(500);

            await checkOnlineDataBaseStatus();
        }

        private async Task checkOnlineDataBaseStatus()
        {
            if (generalValidator.testContextConnection())
            {
                if (!debugIgnoreLogin) { updateSessionUserData(); }

                else { debugMode(); }
            }
            else
            {
                new formConnectionSetter().ShowDialog();
            }
        }

        private void updateSessionUserData() //For recently logged in User
        {
            if (sessionController.checkExistingUserSession() || sessionController.verifySession())
            {
                sessionedUser = sessionController.getSessionedUser();
            }
            else
            {
                createLoginForm();
            }
            checkLoginStatus();
            invokeBtnSession();
        }

        private void debugMode()
        {
            isLoggedIn();
            btnSession.Text = "     DEBUG MODE";
            btnSession.Enabled = true;
            btnSession.ForeColor = Color.Red;
        }

        private void createLoginForm()
        {
            formLogin login = new formLogin();
            login.returnCheckedSession += checkformLogin;
            login.ShowDialog();
        }

        private void checkLoginStatus()
        {
            changeLoginStatus(sessionedUser != null);
        }

        private void isLoggedIn()
        {
            btnSession.Text = "     Cerrar Sesion";
            lblUsername.Text = sessionedUser != null ? sessionedUser.getUserFullName() : "";
            lblCharge.Text = sessionedUser != null ? sessionedUser.getUserRoleType() : "";
            chkOnlineStatus.BackColor = Color.DarkGreen;
            changeButtonStatus(true);
            setInactivityTimer();
        }

        private void isLoggedOff()
        {
            btnSession.Text = "     Iniciar Sesion";
            lblUsername.Text = "Nombre Apellido";
            lblCharge.Text = "Cargo";
            chkOnlineStatus.BackColor = Color.DarkRed;
            changeButtonStatus(false);
        }

        private void changeLoginStatus(bool logged)
        {
            if (!logged) { isLoggedOff(); }

            else { isLoggedIn(); }
        }

        private void invokeBtnSession()
        {
            BeginInvoke(new Action(() =>
            {
                btnSession.Enabled = true;
            }));
        }

        private void setMenuButtonsList()
        {
            listButtonsMenu = new List<Control>();

            foreach (Control control in panelMenuLateral.Controls)
            {
                if (control.GetType() == typeof(Button) &&
                    control != btnIndex &&
                    control != btnConnections &&
                    control != btnSession)
                {
                    listButtonsMenu.Add(control);
                }
            }
        }

        private void changeButtonStatus(bool status)
        {
            listButtonsMenu.ForEach(x => x.Enabled = status);
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            if (!debugIgnoreLogin)
            {
                if (sessionedUser != null)
                {
                    insertFormIndex();
                    closeActiveForm();
                    nullifySessionedUser();
                }
                else
                {
                    createLoginForm();
                }
                checkLoginStatus();
            }
        }

        private void nullifySessionedUser()
        {
            if (sessionedUser != null)
            {
                string email = sessionedUser.getUserEmail();
                sessionController.closeUserSession(email);
                sessionedUser = null;
                lblCharge.Text = "";
                hideSubmenus();
                resetButtonColors();
            }
        }

        private void checkformLogin(object sender, ResponseEventHandler e)
        {
            if (e.status) //user has logged in
            {
                updateSessionUserData();
                checkLoginStatus();
            }
        }

        private void munuBtnClick(object sender)
        {
            changeButtonColor(sender);
            hideSubmenus();
        }

        private async Task insertFormIndex()
        {
            await Task.Run(() =>
            {
                BeginInvoke(() =>
                {
                    if (formActive == null || formActive.GetType() != typeof(formIndex))
                    {
                        openChildForm(new formIndex());
                        btnIndex.BackColor = Color.FromArgb(92, 107, 192); //revise later
                    }
                });
            });
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            openChildForm(new formIndex());
        }
        private void btnCarreras_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            openChildForm(new formCareer());
        }
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            openChildForm(new formSubject());
        }
        private void btnExams_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            openChildForm(new formExams());
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            openChildForm(new formAcademicRecord());
        }
        private void btnEnrolments_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender);
            subMenuToggle(panelSubmenuEnrolments);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender);
            openChildForm(new formUser());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender);
            openChildForm(new formReportes());
        }

        private void openChildForm(Form formChild)
        {
            hideSubmenus();

            if (formActive != null)
            {
                if (formChild.GetType() != formActive.GetType()) //only fire once
                {
                    formActive.Dispose();
                    insertFormChild(formChild);
                }
            }
            else
            {
                insertFormChild(formChild);
            }
        }

        private bool checkSessionedUser(Form form)
        {
            if (form != null && form.GetType() != typeof(formIndex))
            {
                if (sessionedUser == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void insertFormChild(Form formChild)
        {
            if (checkSessionedUser(formChild) || debugIgnoreLogin)
            {
                formActive = formChild;
                formChild.TopLevel = false;
                formChild.FormBorderStyle = FormBorderStyle.None;
                formChild.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(formChild);
                panelContainer.Tag = formChild;
                formChild.BringToFront();
                formChild.Show();
            }
            else
            {
                changeButtonStatus(false);
            }
        }

        private void closeActiveForm()
        {
            if (formActive != null && formActive.GetType() != typeof(formIndex))
            {
                formActive.Dispose();
            }
        }

        private void changeButtonColor(object sender)
        {
            btnCareers.BackColor = Color.FromArgb(33, 33, 33);
            btnSubjects.BackColor = Color.FromArgb(33, 33, 33);
            btnIndex.BackColor = Color.FromArgb(33, 33, 33);
            btnStudents.BackColor = Color.FromArgb(33, 33, 33);
            btnExams.BackColor = Color.FromArgb(33, 33, 33);
            btnEnrolments.BackColor = Color.FromArgb(33, 33, 33);
            btnUsers.BackColor = Color.FromArgb(33, 33, 33);
            btnMatriculations.BackColor = Color.FromArgb(33, 33, 33);
            btnSchedules.BackColor = Color.FromArgb(33, 33, 33);
            btnReportes.BackColor = Color.FromArgb(33, 33, 33);
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            b.BackColor = Color.FromArgb(92, 107, 192);
        }

        private void resetButtonColors()
        {
            listButtonsMenu.ForEach(x => x.BackColor = Color.FromArgb(33, 33, 33));
        }

        //Agregar futuros submenus aca
        private void hideSubmenus()
        {
            panelSubmenuEnrolments.Visible = false;
            panelSubMenuSubjectsEnrolment.Visible = false;
            panelSchedules.Visible = false;
        }

        private void subMenuToggle(Panel panel)
        {
            if (!panel.Visible)
            {
                hideSubmenus();
                panel.Visible = true;
            }
        }
        private void setInactivityTimer()
        {
            if (sessionedUser != null)
            {
                InactiveTimer.Start();
                InactiveTimer.Interval = InactiveTime.inactiveTime; //30 minutos
                InactiveTimer.Tick += InactiveTimer_Tick;
            }
            else { InactiveTimer.Stop(); };
        }

        private void InactiveTimer_Tick(object sender, EventArgs e)
        {
            if (InactiveTime.getIdleTime() >= InactiveTimer.Interval)
            {
                InactiveTimer.Stop();
                isLoggedOff();
                nullifySessionedUser();
                new MessageBoxDarkMode("Sesión caducada", "Login Expired", "Ok", Resources.advertencia);
            }
        }


        private void btnExamEnrolment_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openChildForm(new formExamEnrolmentAdmin());
        }

        private void btnMatriculations_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender);
            subMenuToggle(panelSubMenuSubjectsEnrolment);
        }

        private void btnSubjectsEnrolment_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openChildForm(new formSubjectEnrolments());
        }

        private void btnCareerStatistics_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openChildForm(new formCareerEnrolmentStatistics());
        }


        private void btnSchedules_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender);
            subMenuToggle(panelSchedules);
        }

        private void btnTeacherSchedule_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            openChildForm(new formTeacherSchedule());
        }

        private void btnConnections_Click(object sender, EventArgs e)
        {
            new formSettings().ShowDialog();
        }

    }
}
