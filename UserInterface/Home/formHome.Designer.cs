namespace Gestin.UI.Home
{
    partial class formHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            panelMenuLateral = new Panel();
            btnReportes = new Button();
            panelSchedules = new Panel();
            btnTeacherSchedule = new Button();
            btnSchedules = new Button();
            panelSubMenuSubjectsEnrolment = new Panel();
            btnSubjectEnrolls = new Button();
            btnCareerStatistics = new Button();
            btnMatriculations = new Button();
            panelSubmenuEnrolments = new Panel();
            btnExamEnrolment = new Button();
            btnSubjectsEnrolment = new Button();
            btnEnrolments = new Button();
            btnUsers = new Button();
            btnExams = new Button();
            btnStudents = new Button();
            btnSubjects = new Button();
            btnSession = new Button();
            panelSeparador2 = new Panel();
            panelUser = new Panel();
            btnConnections = new Button();
            chkOnlineStatus = new CheckBox();
            lblCharge = new Label();
            lblUsername = new Label();
            pictureBoxUser = new PictureBox();
            btnCareers = new Button();
            btnIndex = new Button();
            panelSeparador1 = new Panel();
            panelContainer = new Panel();
            toolTip = new ToolTip(components);
            InactiveTimer = new System.Windows.Forms.Timer(components);
            panelMenuLateral.SuspendLayout();
            panelSchedules.SuspendLayout();
            panelSubMenuSubjectsEnrolment.SuspendLayout();
            panelSubmenuEnrolments.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.FromArgb(33, 33, 33);
            panelMenuLateral.Controls.Add(btnReportes);
            panelMenuLateral.Controls.Add(panelSchedules);
            panelMenuLateral.Controls.Add(btnSchedules);
            panelMenuLateral.Controls.Add(panelSubMenuSubjectsEnrolment);
            panelMenuLateral.Controls.Add(btnMatriculations);
            panelMenuLateral.Controls.Add(panelSubmenuEnrolments);
            panelMenuLateral.Controls.Add(btnEnrolments);
            panelMenuLateral.Controls.Add(btnUsers);
            panelMenuLateral.Controls.Add(btnExams);
            panelMenuLateral.Controls.Add(btnStudents);
            panelMenuLateral.Controls.Add(btnSubjects);
            panelMenuLateral.Controls.Add(btnSession);
            panelMenuLateral.Controls.Add(panelSeparador2);
            panelMenuLateral.Controls.Add(panelUser);
            panelMenuLateral.Controls.Add(btnCareers);
            panelMenuLateral.Controls.Add(btnIndex);
            panelMenuLateral.Controls.Add(panelSeparador1);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(3, 4, 3, 4);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(281, 817);
            panelMenuLateral.TabIndex = 5;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(33, 33, 33);
            btnReportes.Dock = DockStyle.Top;
            btnReportes.Enabled = false;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = Properties.Resources.reporte;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 1169);
            btnReportes.Margin = new Padding(3, 5, 3, 5);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(3, 9, 7, 9);
            btnReportes.Size = new Size(260, 80);
            btnReportes.TabIndex = 18;
            btnReportes.Text = "        Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelSchedules
            // 
            panelSchedules.BackColor = Color.FromArgb(33, 33, 33);
            panelSchedules.Controls.Add(btnTeacherSchedule);
            panelSchedules.Dock = DockStyle.Top;
            panelSchedules.Location = new Point(0, 1091);
            panelSchedules.Margin = new Padding(3, 4, 3, 4);
            panelSchedules.Name = "panelSchedules";
            panelSchedules.Padding = new Padding(0, 9, 0, 9);
            panelSchedules.Size = new Size(260, 78);
            panelSchedules.TabIndex = 17;
            panelSchedules.Visible = false;
            // 
            // btnTeacherSchedule
            // 
            btnTeacherSchedule.BackColor = Color.FromArgb(33, 33, 33);
            btnTeacherSchedule.Dock = DockStyle.Top;
            btnTeacherSchedule.FlatAppearance.BorderSize = 0;
            btnTeacherSchedule.FlatStyle = FlatStyle.Flat;
            btnTeacherSchedule.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnTeacherSchedule.ForeColor = Color.White;
            btnTeacherSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeacherSchedule.Location = new Point(0, 9);
            btnTeacherSchedule.Margin = new Padding(3, 4, 3, 4);
            btnTeacherSchedule.Name = "btnTeacherSchedule";
            btnTeacherSchedule.Padding = new Padding(46, 9, 7, 9);
            btnTeacherSchedule.Size = new Size(260, 71);
            btnTeacherSchedule.TabIndex = 12;
            btnTeacherSchedule.Text = "Por docente";
            btnTeacherSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnTeacherSchedule.UseVisualStyleBackColor = false;
            btnTeacherSchedule.Click += btnTeacherSchedule_Click;
            // 
            // btnSchedules
            // 
            btnSchedules.BackColor = Color.FromArgb(33, 33, 33);
            btnSchedules.Dock = DockStyle.Top;
            btnSchedules.Enabled = false;
            btnSchedules.FlatAppearance.BorderSize = 0;
            btnSchedules.FlatStyle = FlatStyle.Flat;
            btnSchedules.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnSchedules.ForeColor = Color.White;
            btnSchedules.Image = (Image)resources.GetObject("btnSchedules.Image");
            btnSchedules.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedules.Location = new Point(0, 1011);
            btnSchedules.Margin = new Padding(3, 5, 3, 5);
            btnSchedules.Name = "btnSchedules";
            btnSchedules.Padding = new Padding(3, 9, 7, 9);
            btnSchedules.Size = new Size(260, 80);
            btnSchedules.TabIndex = 16;
            btnSchedules.Text = "        Horarios";
            btnSchedules.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedules.UseVisualStyleBackColor = false;
            btnSchedules.Click += btnSchedules_Click;
            // 
            // panelSubMenuSubjectsEnrolment
            // 
            panelSubMenuSubjectsEnrolment.BackColor = Color.FromArgb(33, 33, 33);
            panelSubMenuSubjectsEnrolment.Controls.Add(btnSubjectEnrolls);
            panelSubMenuSubjectsEnrolment.Controls.Add(btnCareerStatistics);
            panelSubMenuSubjectsEnrolment.Dock = DockStyle.Top;
            panelSubMenuSubjectsEnrolment.Location = new Point(0, 842);
            panelSubMenuSubjectsEnrolment.Margin = new Padding(3, 4, 3, 4);
            panelSubMenuSubjectsEnrolment.Name = "panelSubMenuSubjectsEnrolment";
            panelSubMenuSubjectsEnrolment.Padding = new Padding(0, 9, 0, 9);
            panelSubMenuSubjectsEnrolment.Size = new Size(260, 169);
            panelSubMenuSubjectsEnrolment.TabIndex = 15;
            panelSubMenuSubjectsEnrolment.Visible = false;
            // 
            // btnSubjectEnrolls
            // 
            btnSubjectEnrolls.BackColor = Color.FromArgb(33, 33, 33);
            btnSubjectEnrolls.Dock = DockStyle.Bottom;
            btnSubjectEnrolls.FlatAppearance.BorderSize = 0;
            btnSubjectEnrolls.FlatStyle = FlatStyle.Flat;
            btnSubjectEnrolls.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnSubjectEnrolls.ForeColor = Color.White;
            btnSubjectEnrolls.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubjectEnrolls.Location = new Point(0, 80);
            btnSubjectEnrolls.Margin = new Padding(3, 4, 3, 4);
            btnSubjectEnrolls.Name = "btnSubjectEnrolls";
            btnSubjectEnrolls.Padding = new Padding(46, 9, 7, 9);
            btnSubjectEnrolls.Size = new Size(260, 80);
            btnSubjectEnrolls.TabIndex = 13;
            btnSubjectEnrolls.Text = "Por materia";
            btnSubjectEnrolls.TextAlign = ContentAlignment.MiddleLeft;
            btnSubjectEnrolls.UseVisualStyleBackColor = false;
            // 
            // btnCareerStatistics
            // 
            btnCareerStatistics.BackColor = Color.FromArgb(33, 33, 33);
            btnCareerStatistics.Dock = DockStyle.Top;
            btnCareerStatistics.FlatAppearance.BorderSize = 0;
            btnCareerStatistics.FlatStyle = FlatStyle.Flat;
            btnCareerStatistics.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnCareerStatistics.ForeColor = Color.White;
            btnCareerStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnCareerStatistics.Location = new Point(0, 9);
            btnCareerStatistics.Margin = new Padding(3, 4, 3, 4);
            btnCareerStatistics.Name = "btnCareerStatistics";
            btnCareerStatistics.Padding = new Padding(46, 9, 7, 9);
            btnCareerStatistics.Size = new Size(260, 71);
            btnCareerStatistics.TabIndex = 12;
            btnCareerStatistics.Text = "Por carrera";
            btnCareerStatistics.TextAlign = ContentAlignment.MiddleLeft;
            btnCareerStatistics.UseVisualStyleBackColor = false;
            btnCareerStatistics.Click += btnCareerStatistics_Click;
            // 
            // btnMatriculations
            // 
            btnMatriculations.BackColor = Color.FromArgb(33, 33, 33);
            btnMatriculations.Dock = DockStyle.Top;
            btnMatriculations.Enabled = false;
            btnMatriculations.FlatAppearance.BorderSize = 0;
            btnMatriculations.FlatStyle = FlatStyle.Flat;
            btnMatriculations.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnMatriculations.ForeColor = Color.White;
            btnMatriculations.Image = (Image)resources.GetObject("btnMatriculations.Image");
            btnMatriculations.ImageAlign = ContentAlignment.MiddleLeft;
            btnMatriculations.Location = new Point(0, 762);
            btnMatriculations.Margin = new Padding(3, 5, 3, 5);
            btnMatriculations.Name = "btnMatriculations";
            btnMatriculations.Padding = new Padding(3, 9, 7, 9);
            btnMatriculations.Size = new Size(260, 80);
            btnMatriculations.TabIndex = 14;
            btnMatriculations.Text = "        Matrícula";
            btnMatriculations.TextAlign = ContentAlignment.MiddleLeft;
            btnMatriculations.UseVisualStyleBackColor = false;
            btnMatriculations.Visible = false;
            btnMatriculations.Click += btnMatriculations_Click;
            // 
            // panelSubmenuEnrolments
            // 
            panelSubmenuEnrolments.BackColor = Color.FromArgb(33, 33, 33);
            panelSubmenuEnrolments.Controls.Add(btnExamEnrolment);
            panelSubmenuEnrolments.Controls.Add(btnSubjectsEnrolment);
            panelSubmenuEnrolments.Dock = DockStyle.Top;
            panelSubmenuEnrolments.Location = new Point(0, 593);
            panelSubmenuEnrolments.Margin = new Padding(3, 4, 3, 4);
            panelSubmenuEnrolments.Name = "panelSubmenuEnrolments";
            panelSubmenuEnrolments.Padding = new Padding(0, 9, 0, 9);
            panelSubmenuEnrolments.Size = new Size(260, 169);
            panelSubmenuEnrolments.TabIndex = 13;
            panelSubmenuEnrolments.Visible = false;
            // 
            // btnExamEnrolment
            // 
            btnExamEnrolment.BackColor = Color.FromArgb(33, 33, 33);
            btnExamEnrolment.Dock = DockStyle.Bottom;
            btnExamEnrolment.FlatAppearance.BorderSize = 0;
            btnExamEnrolment.FlatStyle = FlatStyle.Flat;
            btnExamEnrolment.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnExamEnrolment.ForeColor = Color.White;
            btnExamEnrolment.ImageAlign = ContentAlignment.MiddleLeft;
            btnExamEnrolment.Location = new Point(0, 80);
            btnExamEnrolment.Margin = new Padding(3, 4, 3, 4);
            btnExamEnrolment.Name = "btnExamEnrolment";
            btnExamEnrolment.Padding = new Padding(46, 9, 7, 9);
            btnExamEnrolment.Size = new Size(260, 80);
            btnExamEnrolment.TabIndex = 13;
            btnExamEnrolment.Text = "A exámenes";
            btnExamEnrolment.TextAlign = ContentAlignment.MiddleLeft;
            btnExamEnrolment.UseVisualStyleBackColor = false;
            btnExamEnrolment.Click += btnExamEnrolment_Click;
            // 
            // btnSubjectsEnrolment
            // 
            btnSubjectsEnrolment.BackColor = Color.FromArgb(33, 33, 33);
            btnSubjectsEnrolment.Dock = DockStyle.Top;
            btnSubjectsEnrolment.FlatAppearance.BorderSize = 0;
            btnSubjectsEnrolment.FlatStyle = FlatStyle.Flat;
            btnSubjectsEnrolment.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnSubjectsEnrolment.ForeColor = Color.White;
            btnSubjectsEnrolment.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubjectsEnrolment.Location = new Point(0, 9);
            btnSubjectsEnrolment.Margin = new Padding(3, 4, 3, 4);
            btnSubjectsEnrolment.Name = "btnSubjectsEnrolment";
            btnSubjectsEnrolment.Padding = new Padding(46, 9, 7, 9);
            btnSubjectsEnrolment.Size = new Size(260, 71);
            btnSubjectsEnrolment.TabIndex = 12;
            btnSubjectsEnrolment.Text = "A cursadas";
            btnSubjectsEnrolment.TextAlign = ContentAlignment.MiddleLeft;
            btnSubjectsEnrolment.UseVisualStyleBackColor = false;
            btnSubjectsEnrolment.Click += btnSubjectsEnrolment_Click;
            // 
            // btnEnrolments
            // 
            btnEnrolments.BackColor = Color.FromArgb(33, 33, 33);
            btnEnrolments.Dock = DockStyle.Top;
            btnEnrolments.Enabled = false;
            btnEnrolments.FlatAppearance.BorderSize = 0;
            btnEnrolments.FlatStyle = FlatStyle.Flat;
            btnEnrolments.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnEnrolments.ForeColor = Color.White;
            btnEnrolments.Image = (Image)resources.GetObject("btnEnrolments.Image");
            btnEnrolments.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnrolments.Location = new Point(0, 513);
            btnEnrolments.Margin = new Padding(3, 4, 3, 4);
            btnEnrolments.Name = "btnEnrolments";
            btnEnrolments.Padding = new Padding(3, 9, 7, 9);
            btnEnrolments.Size = new Size(260, 80);
            btnEnrolments.TabIndex = 12;
            btnEnrolments.Text = "        Inscripción";
            btnEnrolments.TextAlign = ContentAlignment.MiddleLeft;
            btnEnrolments.UseVisualStyleBackColor = false;
            btnEnrolments.Click += btnEnrolments_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(33, 33, 33);
            btnUsers.Dock = DockStyle.Top;
            btnUsers.Enabled = false;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 433);
            btnUsers.Margin = new Padding(3, 5, 3, 5);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(3, 9, 7, 9);
            btnUsers.Size = new Size(260, 80);
            btnUsers.TabIndex = 12;
            btnUsers.Text = "        Usuarios";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnExams
            // 
            btnExams.BackColor = Color.FromArgb(33, 33, 33);
            btnExams.Dock = DockStyle.Top;
            btnExams.Enabled = false;
            btnExams.FlatAppearance.BorderSize = 0;
            btnExams.FlatStyle = FlatStyle.Flat;
            btnExams.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnExams.ForeColor = Color.White;
            btnExams.Image = (Image)resources.GetObject("btnExams.Image");
            btnExams.ImageAlign = ContentAlignment.MiddleLeft;
            btnExams.Location = new Point(0, 353);
            btnExams.Margin = new Padding(3, 5, 3, 5);
            btnExams.Name = "btnExams";
            btnExams.Padding = new Padding(3, 9, 7, 9);
            btnExams.Size = new Size(260, 80);
            btnExams.TabIndex = 10;
            btnExams.Text = "        Examenes";
            btnExams.TextAlign = ContentAlignment.MiddleLeft;
            btnExams.UseVisualStyleBackColor = false;
            btnExams.Click += btnExams_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.FromArgb(33, 33, 33);
            btnStudents.Dock = DockStyle.Top;
            btnStudents.Enabled = false;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnStudents.ForeColor = Color.White;
            btnStudents.Image = (Image)resources.GetObject("btnStudents.Image");
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(0, 273);
            btnStudents.Margin = new Padding(3, 4, 3, 4);
            btnStudents.Name = "btnStudents";
            btnStudents.Padding = new Padding(3, 9, 7, 9);
            btnStudents.Size = new Size(260, 80);
            btnStudents.TabIndex = 11;
            btnStudents.Text = "        Estudiantes";
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.BackColor = Color.FromArgb(33, 33, 33);
            btnSubjects.Dock = DockStyle.Top;
            btnSubjects.Enabled = false;
            btnSubjects.FlatAppearance.BorderSize = 0;
            btnSubjects.FlatStyle = FlatStyle.Flat;
            btnSubjects.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnSubjects.ForeColor = Color.White;
            btnSubjects.Image = (Image)resources.GetObject("btnSubjects.Image");
            btnSubjects.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubjects.Location = new Point(0, 193);
            btnSubjects.Margin = new Padding(3, 4, 3, 4);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Padding = new Padding(3, 9, 7, 9);
            btnSubjects.Size = new Size(260, 80);
            btnSubjects.TabIndex = 10;
            btnSubjects.Text = "        Materias";
            btnSubjects.TextAlign = ContentAlignment.MiddleLeft;
            btnSubjects.UseVisualStyleBackColor = false;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnSession
            // 
            btnSession.BackColor = Color.FromArgb(33, 33, 33);
            btnSession.Dock = DockStyle.Bottom;
            btnSession.Enabled = false;
            btnSession.FlatAppearance.BorderSize = 0;
            btnSession.FlatStyle = FlatStyle.Flat;
            btnSession.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnSession.ForeColor = Color.White;
            btnSession.Image = (Image)resources.GetObject("btnSession.Image");
            btnSession.ImageAlign = ContentAlignment.MiddleLeft;
            btnSession.Location = new Point(0, 1249);
            btnSession.Margin = new Padding(3, 5, 3, 5);
            btnSession.Name = "btnSession";
            btnSession.Padding = new Padding(3, 9, 7, 9);
            btnSession.Size = new Size(260, 80);
            btnSession.TabIndex = 8;
            btnSession.Text = "     Iniciar Sesión";
            btnSession.TextAlign = ContentAlignment.MiddleLeft;
            btnSession.UseVisualStyleBackColor = false;
            btnSession.Click += btnSession_Click;
            // 
            // panelSeparador2
            // 
            panelSeparador2.Dock = DockStyle.Bottom;
            panelSeparador2.Location = new Point(0, 1329);
            panelSeparador2.Margin = new Padding(3, 4, 3, 4);
            panelSeparador2.Name = "panelSeparador2";
            panelSeparador2.Size = new Size(260, 32);
            panelSeparador2.TabIndex = 7;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(btnConnections);
            panelUser.Controls.Add(chkOnlineStatus);
            panelUser.Controls.Add(lblCharge);
            panelUser.Controls.Add(lblUsername);
            panelUser.Controls.Add(pictureBoxUser);
            panelUser.Dock = DockStyle.Bottom;
            panelUser.Location = new Point(0, 1361);
            panelUser.Margin = new Padding(3, 4, 3, 4);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(260, 144);
            panelUser.TabIndex = 6;
            // 
            // btnConnections
            // 
            btnConnections.BackColor = Color.FromArgb(44, 47, 51);
            btnConnections.BackgroundImage = Properties.Resources.gearIcon;
            btnConnections.BackgroundImageLayout = ImageLayout.Stretch;
            btnConnections.FlatStyle = FlatStyle.Flat;
            btnConnections.ForeColor = Color.DarkGray;
            btnConnections.Location = new Point(198, 69);
            btnConnections.Name = "btnConnections";
            btnConnections.Size = new Size(50, 51);
            btnConnections.TabIndex = 9;
            btnConnections.UseVisualStyleBackColor = false;
            btnConnections.Click += btnConnections_Click;
            // 
            // chkOnlineStatus
            // 
            chkOnlineStatus.Appearance = Appearance.Button;
            chkOnlineStatus.AutoCheck = false;
            chkOnlineStatus.BackColor = Color.Firebrick;
            chkOnlineStatus.Cursor = Cursors.Help;
            chkOnlineStatus.FlatStyle = FlatStyle.Flat;
            chkOnlineStatus.Location = new Point(14, 81);
            chkOnlineStatus.Margin = new Padding(3, 4, 3, 4);
            chkOnlineStatus.Name = "chkOnlineStatus";
            chkOnlineStatus.Size = new Size(25, 25);
            chkOnlineStatus.TabIndex = 8;
            chkOnlineStatus.UseVisualStyleBackColor = false;
            // 
            // lblCharge
            // 
            lblCharge.AutoSize = true;
            lblCharge.Cursor = Cursors.Hand;
            lblCharge.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblCharge.ForeColor = Color.White;
            lblCharge.Location = new Point(73, 83);
            lblCharge.Name = "lblCharge";
            lblCharge.Size = new Size(64, 22);
            lblCharge.TabIndex = 7;
            lblCharge.Text = "Cargo";
            // 
            // lblUsername
            // 
            lblUsername.Cursor = Cursors.Hand;
            lblUsername.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(73, 16);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(218, 91);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Nombre Apellido";
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(-1, 0);
            pictureBoxUser.Margin = new Padding(3, 4, 3, 4);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(48, 48);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxUser.TabIndex = 5;
            pictureBoxUser.TabStop = false;
            // 
            // btnCareers
            // 
            btnCareers.BackColor = Color.FromArgb(33, 33, 33);
            btnCareers.Dock = DockStyle.Top;
            btnCareers.Enabled = false;
            btnCareers.FlatAppearance.BorderSize = 0;
            btnCareers.FlatStyle = FlatStyle.Flat;
            btnCareers.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnCareers.ForeColor = Color.White;
            btnCareers.Image = (Image)resources.GetObject("btnCareers.Image");
            btnCareers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCareers.Location = new Point(0, 113);
            btnCareers.Margin = new Padding(3, 5, 3, 5);
            btnCareers.Name = "btnCareers";
            btnCareers.Padding = new Padding(3, 9, 7, 9);
            btnCareers.Size = new Size(260, 80);
            btnCareers.TabIndex = 3;
            btnCareers.Text = "        Carreras";
            btnCareers.TextAlign = ContentAlignment.MiddleLeft;
            btnCareers.UseVisualStyleBackColor = false;
            btnCareers.Click += btnCarreras_Click;
            // 
            // btnIndex
            // 
            btnIndex.BackColor = Color.FromArgb(33, 33, 33);
            btnIndex.Dock = DockStyle.Top;
            btnIndex.FlatAppearance.BorderSize = 0;
            btnIndex.FlatStyle = FlatStyle.Flat;
            btnIndex.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnIndex.ForeColor = Color.White;
            btnIndex.Image = (Image)resources.GetObject("btnIndex.Image");
            btnIndex.ImageAlign = ContentAlignment.MiddleLeft;
            btnIndex.Location = new Point(0, 33);
            btnIndex.Margin = new Padding(3, 5, 3, 5);
            btnIndex.Name = "btnIndex";
            btnIndex.Padding = new Padding(3, 9, 7, 9);
            btnIndex.Size = new Size(260, 80);
            btnIndex.TabIndex = 1;
            btnIndex.Text = "        Inicio";
            btnIndex.TextAlign = ContentAlignment.MiddleLeft;
            btnIndex.UseVisualStyleBackColor = false;
            btnIndex.Click += btnInicio_Click;
            // 
            // panelSeparador1
            // 
            panelSeparador1.BackColor = Color.FromArgb(33, 33, 33);
            panelSeparador1.Dock = DockStyle.Top;
            panelSeparador1.Location = new Point(0, 0);
            panelSeparador1.Margin = new Padding(3, 4, 3, 4);
            panelSeparador1.Name = "panelSeparador1";
            panelSeparador1.Size = new Size(260, 33);
            panelSeparador1.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(44, 47, 51);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(281, 0);
            panelContainer.Margin = new Padding(3, 5, 3, 5);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1068, 817);
            panelContainer.TabIndex = 6;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 0;
            toolTip.InitialDelay = 0;
            toolTip.IsBalloon = true;
            toolTip.ReshowDelay = 100;
            // 
            // InactiveTimer
            // 
            InactiveTimer.Interval = 60000;
            InactiveTimer.Tick += InactiveTimer_Tick;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 817);
            Controls.Add(panelContainer);
            Controls.Add(panelMenuLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MinimumSize = new Size(1235, 720);
            Name = "formHome";
            Text = "Gestin";
            WindowState = FormWindowState.Maximized;
            FormClosing += formHome_FormClosing;
            Load += formHome_Load;
            panelMenuLateral.ResumeLayout(false);
            panelSchedules.ResumeLayout(false);
            panelSubMenuSubjectsEnrolment.ResumeLayout(false);
            panelSubmenuEnrolments.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenuLateral;
        private Button btnIndex;
        private Panel panelSeparador1;
        private Button btnCareers;
        private Panel panelUser;
        private Label lblUsername;
        private PictureBox pictureBoxUser;
        private Label lblCharge;
        private Panel panelContainer;
        private Button btnSession;
        private Panel panelSeparador2;
        private Button btnStudents;
        private Button btnExams;
        private Button btnSubjects;
        private Panel panelSubmenuEnrolments;
        private Button btnExamEnrolment;
        private Button btnSubjectsEnrolment;
        private Button btnEnrolments;
        private Button btnUsers;
        private Button btnMatriculations;
        private Panel panelSubMenuSubjectsEnrolment;
        private Button btnSubjectEnrolls;
        private Button btnCareerStatistics;
        private CheckBox chkOnlineStatus;
        private ToolTip toolTip;
        private Panel panelSchedules;
        private Button btnTeacherSchedule;
        private Button btnSchedules;
        private Button btnConnections;
        private System.Windows.Forms.Timer InactiveTimer;
        private Button btnReportes;
    }
}