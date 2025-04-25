using Gestin.UI.Custom;

namespace Gestin.UI.Home.Users
{
    partial class formUser
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
            userBindingSource = new BindingSource(components);
            bindingSourceTeachers = new BindingSource(components);
            bindingSourceStudents = new BindingSource(components);
            label3 = new Label();
            lableTimer = new System.Windows.Forms.Timer(components);
            cbbUserRole = new ComboBox();
            lblResult = new Label();
            panelUser = new Panel();
            panelEnrolonment = new Panel();
            btnSaveCareerEnrolment = new Button();
            lblcareerEntolment = new Label();
            cbbListCareer = new ComboBox();
            panelSelectedUser = new Panel();
            btnSoftDelete = new Button();
            txtUserResult = new TextBox();
            lblUserSelected = new Label();
            btnBuscarSinCargos = new Button();
            panelRole = new Panel();
            lblRole = new Label();
            btnAssignRole = new Button();
            panelStatisticsInfo = new Panel();
            lblLastStudent = new Label();
            lblLastTeacher = new Label();
            label13 = new Label();
            label9 = new Label();
            lblLastUser = new Label();
            label2 = new Label();
            panelStatistics = new Panel();
            lblUserCount = new Label();
            label20 = new Label();
            label5 = new Label();
            label11 = new Label();
            lblTeacherCount = new Label();
            lblStudentCount = new Label();
            panelSearchBack = new Panel();
            listBoxSearchResults = new ListBox();
            textBoxSearchBar = new TextBox();
            panelTop = new Panel();
            panelMain = new Panel();
            panelInfo = new Panel();
            panel2 = new Panel();
            btnSave = new Button();
            btnClear = new Button();
            label21 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label7 = new Label();
            txtUserDni = new TextBox();
            label15 = new Label();
            txtUserLastName = new TextBox();
            label6 = new Label();
            txtUserName = new TextBox();
            label8 = new Label();
            txtUserPhoneNumber = new TextBox();
            label10 = new Label();
            UserDateBirth = new DateTimePicker();
            label16 = new Label();
            txtUserBirthPlace = new TextBox();
            label17 = new Label();
            txtUserEmergencyContact = new TextBox();
            label18 = new Label();
            cbbGender = new ComboBox();
            label19 = new Label();
            panelRadio = new Panel();
            label14 = new Label();
            label12 = new Label();
            checkBoxDocente = new CheckBox();
            checkBoxEstudiante = new CheckBox();
            panel1 = new Panel();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceStudents).BeginInit();
            panelUser.SuspendLayout();
            panelEnrolonment.SuspendLayout();
            panelSelectedUser.SuspendLayout();
            panelRole.SuspendLayout();
            panelStatisticsInfo.SuspendLayout();
            panelStatistics.SuspendLayout();
            panelSearchBack.SuspendLayout();
            panelMain.SuspendLayout();
            panelInfo.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelRadio.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(54, 57, 63);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(369, -5);
            label3.Name = "label3";
            label3.Size = new Size(150, 27);
            label3.TabIndex = 43;
            label3.Text = "Documentación";
            // 
            // cbbUserRole
            // 
            cbbUserRole.BackColor = Color.FromArgb(35, 39, 42);
            cbbUserRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUserRole.FlatStyle = FlatStyle.Flat;
            cbbUserRole.Font = new Font("Segoe UI", 12F);
            cbbUserRole.ForeColor = Color.White;
            cbbUserRole.FormattingEnabled = true;
            cbbUserRole.Items.AddRange(new object[] { "Estudiante", "Docente" });
            cbbUserRole.Location = new Point(8, 40);
            cbbUserRole.Name = "cbbUserRole";
            cbbUserRole.Size = new Size(420, 36);
            cbbUserRole.TabIndex = 65;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Crimson;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(43, 603);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(117, 28);
            lblResult.TabIndex = 56;
            lblResult.Text = "Success Text";
            lblResult.Visible = false;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(44, 47, 51);
            panelUser.Controls.Add(panelEnrolonment);
            panelUser.Controls.Add(panelSelectedUser);
            panelUser.Controls.Add(btnBuscarSinCargos);
            panelUser.Controls.Add(panelRole);
            panelUser.Controls.Add(panelStatisticsInfo);
            panelUser.Controls.Add(panelStatistics);
            panelUser.Controls.Add(lblResult);
            panelUser.Controls.Add(panelSearchBack);
            panelUser.Controls.Add(textBoxSearchBar);
            panelUser.Dock = DockStyle.Fill;
            panelUser.Location = new Point(348, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(710, 905);
            panelUser.TabIndex = 63;
            panelUser.Paint += panelUser_Paint;
            // 
            // panelEnrolonment
            // 
            panelEnrolonment.Controls.Add(btnSaveCareerEnrolment);
            panelEnrolonment.Controls.Add(lblcareerEntolment);
            panelEnrolonment.Controls.Add(cbbListCareer);
            panelEnrolonment.Enabled = false;
            panelEnrolonment.Location = new Point(42, 495);
            panelEnrolonment.Name = "panelEnrolonment";
            panelEnrolonment.Size = new Size(639, 91);
            panelEnrolonment.TabIndex = 75;
            // 
            // btnSaveCareerEnrolment
            // 
            btnSaveCareerEnrolment.BackColor = Color.FromArgb(0, 150, 136);
            btnSaveCareerEnrolment.FlatAppearance.BorderSize = 0;
            btnSaveCareerEnrolment.FlatStyle = FlatStyle.Flat;
            btnSaveCareerEnrolment.Font = new Font("Segoe UI", 12F);
            btnSaveCareerEnrolment.ForeColor = Color.White;
            btnSaveCareerEnrolment.Location = new Point(502, 35);
            btnSaveCareerEnrolment.Name = "btnSaveCareerEnrolment";
            btnSaveCareerEnrolment.Size = new Size(130, 40);
            btnSaveCareerEnrolment.TabIndex = 77;
            btnSaveCareerEnrolment.Text = "Inscribir";
            btnSaveCareerEnrolment.UseVisualStyleBackColor = false;
            btnSaveCareerEnrolment.Click += btnSaveCareerEnrolment_Click;
            // 
            // lblcareerEntolment
            // 
            lblcareerEntolment.AutoSize = true;
            lblcareerEntolment.Font = new Font("Segoe UI", 12F);
            lblcareerEntolment.ForeColor = Color.White;
            lblcareerEntolment.Location = new Point(5, 7);
            lblcareerEntolment.Margin = new Padding(3, 13, 3, 0);
            lblcareerEntolment.Name = "lblcareerEntolment";
            lblcareerEntolment.Size = new Size(466, 28);
            lblcareerEntolment.TabIndex = 76;
            lblcareerEntolment.Text = "Seleccione una carrera para inscribir a un estudiante:";
            // 
            // cbbListCareer
            // 
            cbbListCareer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbbListCareer.BackColor = Color.FromArgb(35, 39, 42);
            cbbListCareer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbListCareer.FlatStyle = FlatStyle.Flat;
            cbbListCareer.Font = new Font("Segoe UI", 10.2F);
            cbbListCareer.ForeColor = Color.White;
            cbbListCareer.FormattingEnabled = true;
            cbbListCareer.Location = new Point(7, 37);
            cbbListCareer.Name = "cbbListCareer";
            cbbListCareer.Size = new Size(484, 31);
            cbbListCareer.TabIndex = 75;
            cbbListCareer.Tag = "Seleccione una carrera";
            // 
            // panelSelectedUser
            // 
            panelSelectedUser.Controls.Add(btnSoftDelete);
            panelSelectedUser.Controls.Add(txtUserResult);
            panelSelectedUser.Controls.Add(lblUserSelected);
            panelSelectedUser.Enabled = false;
            panelSelectedUser.Location = new Point(43, 305);
            panelSelectedUser.Name = "panelSelectedUser";
            panelSelectedUser.Size = new Size(638, 88);
            panelSelectedUser.TabIndex = 74;
            // 
            // btnSoftDelete
            // 
            btnSoftDelete.BackColor = Color.FromArgb(0, 150, 136);
            btnSoftDelete.FlatAppearance.BorderSize = 0;
            btnSoftDelete.FlatStyle = FlatStyle.Flat;
            btnSoftDelete.Font = new Font("Segoe UI", 12F);
            btnSoftDelete.ForeColor = Color.White;
            btnSoftDelete.Location = new Point(501, 37);
            btnSoftDelete.Name = "btnSoftDelete";
            btnSoftDelete.Size = new Size(130, 40);
            btnSoftDelete.TabIndex = 73;
            btnSoftDelete.Text = "Dar de Baja";
            btnSoftDelete.UseVisualStyleBackColor = false;
            btnSoftDelete.Click += btnSoftDelete_Click;
            // 
            // txtUserResult
            // 
            txtUserResult.BackColor = Color.FromArgb(35, 39, 42);
            txtUserResult.BorderStyle = BorderStyle.FixedSingle;
            txtUserResult.Font = new Font("Segoe UI", 12F);
            txtUserResult.ForeColor = Color.FromArgb(255, 152, 0);
            txtUserResult.Location = new Point(7, 39);
            txtUserResult.Name = "txtUserResult";
            txtUserResult.ReadOnly = true;
            txtUserResult.Size = new Size(483, 34);
            txtUserResult.TabIndex = 65;
            // 
            // lblUserSelected
            // 
            lblUserSelected.AutoSize = true;
            lblUserSelected.Font = new Font("Segoe UI", 12F);
            lblUserSelected.Location = new Point(3, 4);
            lblUserSelected.Name = "lblUserSelected";
            lblUserSelected.Size = new Size(209, 28);
            lblUserSelected.TabIndex = 61;
            lblUserSelected.Text = "Usuario Seleccionado: ";
            // 
            // btnBuscarSinCargos
            // 
            btnBuscarSinCargos.BackColor = Color.FromArgb(0, 150, 136);
            btnBuscarSinCargos.FlatAppearance.BorderSize = 0;
            btnBuscarSinCargos.FlatStyle = FlatStyle.Flat;
            btnBuscarSinCargos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarSinCargos.ForeColor = Color.White;
            btnBuscarSinCargos.Location = new Point(563, 863);
            btnBuscarSinCargos.Name = "btnBuscarSinCargos";
            btnBuscarSinCargos.Size = new Size(135, 43);
            btnBuscarSinCargos.TabIndex = 66;
            btnBuscarSinCargos.Text = "Usuarios sin rol";
            btnBuscarSinCargos.UseVisualStyleBackColor = false;
            btnBuscarSinCargos.Click += btnBuscarSinCargos_Click;
            // 
            // panelRole
            // 
            panelRole.Controls.Add(lblRole);
            panelRole.Controls.Add(btnAssignRole);
            panelRole.Controls.Add(cbbUserRole);
            panelRole.Enabled = false;
            panelRole.Location = new Point(42, 397);
            panelRole.Name = "panelRole";
            panelRole.Size = new Size(635, 91);
            panelRole.TabIndex = 70;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 12F);
            lblRole.Location = new Point(8, 9);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(418, 28);
            lblRole.TabIndex = 74;
            lblRole.Text = "Seleccione un rol para editarlo o darlo de baja:";
            // 
            // btnAssignRole
            // 
            btnAssignRole.BackColor = Color.FromArgb(0, 150, 136);
            btnAssignRole.FlatAppearance.BorderSize = 0;
            btnAssignRole.FlatStyle = FlatStyle.Flat;
            btnAssignRole.Font = new Font("Segoe UI", 12F);
            btnAssignRole.ForeColor = Color.White;
            btnAssignRole.Location = new Point(434, 39);
            btnAssignRole.Name = "btnAssignRole";
            btnAssignRole.Size = new Size(199, 40);
            btnAssignRole.TabIndex = 68;
            btnAssignRole.Text = "Editar o dar de baja";
            btnAssignRole.UseVisualStyleBackColor = false;
            btnAssignRole.Click += btnAssignRole_Click;
            // 
            // panelStatisticsInfo
            // 
            panelStatisticsInfo.BackColor = Color.FromArgb(35, 39, 42);
            panelStatisticsInfo.BorderStyle = BorderStyle.FixedSingle;
            panelStatisticsInfo.Controls.Add(lblLastStudent);
            panelStatisticsInfo.Controls.Add(lblLastTeacher);
            panelStatisticsInfo.Controls.Add(label13);
            panelStatisticsInfo.Controls.Add(label9);
            panelStatisticsInfo.Controls.Add(lblLastUser);
            panelStatisticsInfo.Controls.Add(label2);
            panelStatisticsInfo.Location = new Point(43, 635);
            panelStatisticsInfo.Name = "panelStatisticsInfo";
            panelStatisticsInfo.Size = new Size(655, 121);
            panelStatisticsInfo.TabIndex = 60;
            // 
            // lblLastStudent
            // 
            lblLastStudent.AutoSize = true;
            lblLastStudent.BackColor = Color.FromArgb(64, 64, 64);
            lblLastStudent.Font = new Font("Segoe UI", 12F);
            lblLastStudent.ForeColor = Color.FromArgb(255, 152, 0);
            lblLastStudent.Location = new Point(312, 43);
            lblLastStudent.Name = "lblLastStudent";
            lblLastStudent.Size = new Size(27, 28);
            lblLastStudent.TabIndex = 72;
            lblLastStudent.Text = "   ";
            // 
            // lblLastTeacher
            // 
            lblLastTeacher.AutoSize = true;
            lblLastTeacher.BackColor = Color.FromArgb(64, 64, 64);
            lblLastTeacher.Font = new Font("Segoe UI", 12F);
            lblLastTeacher.ForeColor = Color.FromArgb(255, 152, 0);
            lblLastTeacher.Location = new Point(288, 80);
            lblLastTeacher.Name = "lblLastTeacher";
            lblLastTeacher.Size = new Size(27, 28);
            lblLastTeacher.TabIndex = 71;
            lblLastTeacher.Text = "   ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(5, 80);
            label13.Name = "label13";
            label13.Size = new Size(308, 28);
            label13.TabIndex = 70;
            label13.Text = "Último rol de docente asignado a:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(5, 43);
            label9.Name = "label9";
            label9.Size = new Size(333, 28);
            label9.TabIndex = 69;
            label9.Text = "Último rol de estudiante asignado a: ";
            // 
            // lblLastUser
            // 
            lblLastUser.AutoSize = true;
            lblLastUser.BackColor = Color.FromArgb(64, 64, 64);
            lblLastUser.Font = new Font("Segoe UI", 12F);
            lblLastUser.ForeColor = Color.FromArgb(255, 152, 0);
            lblLastUser.Location = new Point(237, 7);
            lblLastUser.Margin = new Padding(2, 0, 3, 0);
            lblLastUser.Name = "lblLastUser";
            lblLastUser.Size = new Size(27, 28);
            lblLastUser.TabIndex = 69;
            lblLastUser.Text = "   ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(5, 7);
            label2.Name = "label2";
            label2.Size = new Size(250, 28);
            label2.TabIndex = 0;
            label2.Text = "Último usuario modificado:";
            // 
            // panelStatistics
            // 
            panelStatistics.BackColor = Color.FromArgb(35, 39, 42);
            panelStatistics.BorderStyle = BorderStyle.FixedSingle;
            panelStatistics.Controls.Add(lblUserCount);
            panelStatistics.Controls.Add(label20);
            panelStatistics.Controls.Add(label5);
            panelStatistics.Controls.Add(label11);
            panelStatistics.Controls.Add(lblTeacherCount);
            panelStatistics.Controls.Add(lblStudentCount);
            panelStatistics.Location = new Point(37, 792);
            panelStatistics.Name = "panelStatistics";
            panelStatistics.Size = new Size(661, 66);
            panelStatistics.TabIndex = 67;
            // 
            // lblUserCount
            // 
            lblUserCount.AutoSize = true;
            lblUserCount.BackColor = Color.FromArgb(64, 64, 64);
            lblUserCount.Font = new Font("Segoe UI", 12F);
            lblUserCount.ForeColor = Color.FromArgb(255, 152, 0);
            lblUserCount.Location = new Point(157, 21);
            lblUserCount.Name = "lblUserCount";
            lblUserCount.Size = new Size(27, 28);
            lblUserCount.TabIndex = 68;
            lblUserCount.Text = "   ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(5, 21);
            label20.Name = "label20";
            label20.Size = new Size(156, 28);
            label20.TabIndex = 67;
            label20.Text = "Usuarios Totales:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(214, 21);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 46;
            label5.Text = "Estudiantes Totales:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(448, 21);
            label11.Name = "label11";
            label11.Size = new Size(162, 28);
            label11.TabIndex = 47;
            label11.Text = "Docentes Totales:";
            // 
            // lblTeacherCount
            // 
            lblTeacherCount.AutoSize = true;
            lblTeacherCount.BackColor = Color.FromArgb(64, 64, 64);
            lblTeacherCount.Font = new Font("Segoe UI", 12F);
            lblTeacherCount.ForeColor = Color.FromArgb(255, 152, 0);
            lblTeacherCount.Location = new Point(609, 21);
            lblTeacherCount.Name = "lblTeacherCount";
            lblTeacherCount.Size = new Size(27, 28);
            lblTeacherCount.TabIndex = 49;
            lblTeacherCount.Text = "   ";
            // 
            // lblStudentCount
            // 
            lblStudentCount.AutoSize = true;
            lblStudentCount.BackColor = Color.FromArgb(64, 64, 64);
            lblStudentCount.Font = new Font("Segoe UI", 12F);
            lblStudentCount.ForeColor = Color.FromArgb(255, 152, 0);
            lblStudentCount.Location = new Point(392, 21);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(27, 28);
            lblStudentCount.TabIndex = 48;
            lblStudentCount.Text = "   ";
            // 
            // panelSearchBack
            // 
            panelSearchBack.BackColor = Color.FromArgb(35, 39, 42);
            panelSearchBack.BorderStyle = BorderStyle.FixedSingle;
            panelSearchBack.Controls.Add(listBoxSearchResults);
            panelSearchBack.Location = new Point(43, 69);
            panelSearchBack.Name = "panelSearchBack";
            panelSearchBack.Size = new Size(632, 230);
            panelSearchBack.TabIndex = 63;
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.BackColor = Color.FromArgb(35, 39, 42);
            listBoxSearchResults.BorderStyle = BorderStyle.None;
            listBoxSearchResults.Dock = DockStyle.Fill;
            listBoxSearchResults.Font = new Font("Segoe UI", 12F);
            listBoxSearchResults.ForeColor = Color.White;
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.ItemHeight = 28;
            listBoxSearchResults.Location = new Point(0, 0);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(630, 228);
            listBoxSearchResults.TabIndex = 59;
            listBoxSearchResults.Visible = false;
            listBoxSearchResults.Click += listBoxSearchResults_Click;
            listBoxSearchResults.KeyDown += listBoxSearchResults_KeyDown;
            // 
            // textBoxSearchBar
            // 
            textBoxSearchBar.BackColor = Color.FromArgb(35, 39, 42);
            textBoxSearchBar.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchBar.Font = new Font("Segoe UI", 12F);
            textBoxSearchBar.ForeColor = Color.White;
            textBoxSearchBar.Location = new Point(42, 27);
            textBoxSearchBar.Name = "textBoxSearchBar";
            textBoxSearchBar.PlaceholderText = "Ingrese nombre o dni de usuario";
            textBoxSearchBar.Size = new Size(632, 34);
            textBoxSearchBar.TabIndex = 58;
            textBoxSearchBar.TextChanged += textBoxSearchBar_TextChanged;
            textBoxSearchBar.KeyDown += textBoxSearchBar_KeyDown;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(44, 47, 51);
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1058, 66);
            panelTop.TabIndex = 77;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelUser);
            panelMain.Controls.Add(panelInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 66);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1058, 905);
            panelMain.TabIndex = 79;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(44, 47, 51);
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(panel2);
            panelInfo.Controls.Add(label21);
            panelInfo.Controls.Add(flowLayoutPanel1);
            panelInfo.Dock = DockStyle.Left;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(348, 905);
            panelInfo.TabIndex = 62;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnClear);
            panel2.Location = new Point(6, 820);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 37);
            panel2.TabIndex = 76;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.Dock = DockStyle.Left;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 37);
            btnSave.TabIndex = 12;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 150, 136);
            btnClear.Dock = DockStyle.Right;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(224, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 37);
            btnClear.TabIndex = 52;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 13.8F);
            label21.Location = new Point(5, 19);
            label21.Name = "label21";
            label21.Size = new Size(192, 31);
            label21.TabIndex = 75;
            label21.Text = "Datos del usuario";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(txtUserDni);
            flowLayoutPanel1.Controls.Add(label15);
            flowLayoutPanel1.Controls.Add(txtUserLastName);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtUserName);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(txtUserPhoneNumber);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(UserDateBirth);
            flowLayoutPanel1.Controls.Add(label16);
            flowLayoutPanel1.Controls.Add(txtUserBirthPlace);
            flowLayoutPanel1.Controls.Add(label17);
            flowLayoutPanel1.Controls.Add(txtUserEmergencyContact);
            flowLayoutPanel1.Controls.Add(label18);
            flowLayoutPanel1.Controls.Add(cbbGender);
            flowLayoutPanel1.Controls.Add(label19);
            flowLayoutPanel1.Controls.Add(panelRadio);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(2, 55);
            flowLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(321, 749);
            flowLayoutPanel1.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 13);
            label7.Margin = new Padding(3, 13, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 28);
            label7.TabIndex = 5;
            label7.Text = "DNI :";
            // 
            // txtUserDni
            // 
            txtUserDni.BackColor = Color.FromArgb(35, 39, 42);
            txtUserDni.BorderStyle = BorderStyle.FixedSingle;
            txtUserDni.Dock = DockStyle.Top;
            txtUserDni.Font = new Font("Segoe UI", 12F);
            txtUserDni.ForeColor = Color.White;
            txtUserDni.Location = new Point(3, 44);
            txtUserDni.Name = "txtUserDni";
            txtUserDni.Size = new Size(305, 34);
            txtUserDni.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Top;
            label15.Font = new Font("Segoe UI", 12F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(3, 81);
            label15.Name = "label15";
            label15.Padding = new Padding(3, 8, 3, 0);
            label15.Size = new Size(101, 36);
            label15.TabIndex = 57;
            label15.Text = "Apellido :";
            // 
            // txtUserLastName
            // 
            txtUserLastName.BackColor = Color.FromArgb(35, 39, 42);
            txtUserLastName.BorderStyle = BorderStyle.FixedSingle;
            txtUserLastName.Dock = DockStyle.Top;
            txtUserLastName.Font = new Font("Segoe UI", 12F);
            txtUserLastName.ForeColor = Color.White;
            txtUserLastName.Location = new Point(3, 120);
            txtUserLastName.Name = "txtUserLastName";
            txtUserLastName.Size = new Size(305, 34);
            txtUserLastName.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 157);
            label6.Name = "label6";
            label6.Padding = new Padding(3, 13, 3, 0);
            label6.Size = new Size(100, 41);
            label6.TabIndex = 26;
            label6.Text = "Nombre :";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(35, 39, 42);
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Dock = DockStyle.Top;
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(3, 201);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(305, 34);
            txtUserName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 251);
            label8.Margin = new Padding(3, 13, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 28);
            label8.TabIndex = 9;
            label8.Text = "Teléfono :";
            // 
            // txtUserPhoneNumber
            // 
            txtUserPhoneNumber.BackColor = Color.FromArgb(35, 39, 42);
            txtUserPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtUserPhoneNumber.Dock = DockStyle.Top;
            txtUserPhoneNumber.Font = new Font("Segoe UI", 12F);
            txtUserPhoneNumber.ForeColor = Color.White;
            txtUserPhoneNumber.Location = new Point(3, 282);
            txtUserPhoneNumber.Name = "txtUserPhoneNumber";
            txtUserPhoneNumber.Size = new Size(305, 34);
            txtUserPhoneNumber.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 332);
            label10.Margin = new Padding(3, 13, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(200, 28);
            label10.TabIndex = 28;
            label10.Text = "Fecha de nacimiento :";
            // 
            // UserDateBirth
            // 
            UserDateBirth.CalendarMonthBackground = Color.FromArgb(35, 39, 42);
            UserDateBirth.Dock = DockStyle.Top;
            UserDateBirth.Format = DateTimePickerFormat.Short;
            UserDateBirth.Location = new Point(3, 363);
            UserDateBirth.Name = "UserDateBirth";
            UserDateBirth.Size = new Size(305, 27);
            UserDateBirth.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Segoe UI", 12F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(3, 406);
            label16.Margin = new Padding(3, 13, 3, 0);
            label16.Name = "label16";
            label16.Size = new Size(199, 28);
            label16.TabIndex = 38;
            label16.Text = "Lugar de nacimiento :";
            // 
            // txtUserBirthPlace
            // 
            txtUserBirthPlace.BackColor = Color.FromArgb(35, 39, 42);
            txtUserBirthPlace.BorderStyle = BorderStyle.FixedSingle;
            txtUserBirthPlace.Dock = DockStyle.Top;
            txtUserBirthPlace.Font = new Font("Segoe UI", 12F);
            txtUserBirthPlace.ForeColor = Color.White;
            txtUserBirthPlace.Location = new Point(3, 437);
            txtUserBirthPlace.Name = "txtUserBirthPlace";
            txtUserBirthPlace.Size = new Size(305, 34);
            txtUserBirthPlace.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Top;
            label17.Font = new Font("Segoe UI", 12F);
            label17.ForeColor = Color.White;
            label17.Location = new Point(3, 487);
            label17.Margin = new Padding(3, 13, 3, 0);
            label17.Name = "label17";
            label17.Size = new Size(228, 28);
            label17.TabIndex = 37;
            label17.Text = "Teléfono de emergencia :";
            // 
            // txtUserEmergencyContact
            // 
            txtUserEmergencyContact.BackColor = Color.FromArgb(35, 39, 42);
            txtUserEmergencyContact.BorderStyle = BorderStyle.FixedSingle;
            txtUserEmergencyContact.Dock = DockStyle.Top;
            txtUserEmergencyContact.Font = new Font("Segoe UI", 12F);
            txtUserEmergencyContact.ForeColor = Color.White;
            txtUserEmergencyContact.Location = new Point(3, 518);
            txtUserEmergencyContact.Name = "txtUserEmergencyContact";
            txtUserEmergencyContact.Size = new Size(305, 34);
            txtUserEmergencyContact.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Top;
            label18.Font = new Font("Segoe UI", 12F);
            label18.ForeColor = Color.White;
            label18.Location = new Point(3, 568);
            label18.Margin = new Padding(3, 13, 3, 0);
            label18.Name = "label18";
            label18.Size = new Size(85, 28);
            label18.TabIndex = 40;
            label18.Text = "Género :";
            // 
            // cbbGender
            // 
            cbbGender.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbbGender.BackColor = Color.FromArgb(35, 39, 42);
            cbbGender.Dock = DockStyle.Top;
            cbbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGender.FlatStyle = FlatStyle.Flat;
            cbbGender.Font = new Font("Segoe UI", 12F);
            cbbGender.ForeColor = Color.White;
            cbbGender.FormattingEnabled = true;
            cbbGender.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cbbGender.Location = new Point(3, 599);
            cbbGender.Name = "cbbGender";
            cbbGender.Size = new Size(305, 36);
            cbbGender.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(3, 651);
            label19.Margin = new Padding(3, 13, 3, 0);
            label19.Name = "label19";
            label19.Size = new Size(155, 28);
            label19.TabIndex = 72;
            label19.Text = "Roles asignados:";
            // 
            // panelRadio
            // 
            panelRadio.BackColor = Color.FromArgb(35, 39, 42);
            panelRadio.Controls.Add(label14);
            panelRadio.Controls.Add(label12);
            panelRadio.Controls.Add(checkBoxDocente);
            panelRadio.Controls.Add(checkBoxEstudiante);
            panelRadio.Location = new Point(3, 682);
            panelRadio.Name = "panelRadio";
            panelRadio.Size = new Size(305, 48);
            panelRadio.TabIndex = 71;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(222, 7);
            label14.Name = "label14";
            label14.Size = new Size(85, 28);
            label14.TabIndex = 3;
            label14.Text = "Docente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(32, 7);
            label12.Name = "label12";
            label12.Size = new Size(103, 28);
            label12.TabIndex = 2;
            label12.Text = "Estudiante";
            // 
            // checkBoxDocente
            // 
            checkBoxDocente.Appearance = Appearance.Button;
            checkBoxDocente.AutoCheck = false;
            checkBoxDocente.FlatAppearance.BorderColor = Color.Gray;
            checkBoxDocente.FlatStyle = FlatStyle.Flat;
            checkBoxDocente.Font = new Font("Microsoft Sans Serif", 18F);
            checkBoxDocente.Location = new Point(192, 8);
            checkBoxDocente.Name = "checkBoxDocente";
            checkBoxDocente.Size = new Size(23, 27);
            checkBoxDocente.TabIndex = 1;
            checkBoxDocente.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstudiante
            // 
            checkBoxEstudiante.Appearance = Appearance.Button;
            checkBoxEstudiante.AutoCheck = false;
            checkBoxEstudiante.FlatAppearance.BorderColor = Color.Gray;
            checkBoxEstudiante.FlatStyle = FlatStyle.Flat;
            checkBoxEstudiante.Font = new Font("Microsoft Sans Serif", 18F);
            checkBoxEstudiante.Location = new Point(8, 8);
            checkBoxEstudiante.Name = "checkBoxEstudiante";
            checkBoxEstudiante.Size = new Size(23, 27);
            checkBoxEstudiante.TabIndex = 0;
            checkBoxEstudiante.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 736);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 0);
            panel1.TabIndex = 73;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 0;
            toolTip.IsBalloon = true;
            // 
            // formUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1058, 971);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(label3);
            ForeColor = Color.White;
            Name = "formUser";
            Text = "Gestin - Usuarios";
            Load += formUser_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceStudents).EndInit();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panelEnrolonment.ResumeLayout(false);
            panelEnrolonment.PerformLayout();
            panelSelectedUser.ResumeLayout(false);
            panelSelectedUser.PerformLayout();
            panelRole.ResumeLayout(false);
            panelRole.PerformLayout();
            panelStatisticsInfo.ResumeLayout(false);
            panelStatisticsInfo.PerformLayout();
            panelStatistics.ResumeLayout(false);
            panelStatistics.PerformLayout();
            panelSearchBack.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelRadio.ResumeLayout(false);
            panelRadio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSourceTeachers;
        private BindingSource bindingSourceStudents;
        private BindingSource userBindingSource;
        private Label label3;
        private System.Windows.Forms.Timer lableTimer;
        private Label lblResult;
        private Panel panelUser;
        private Label lblStudentCount;
        private Panel panelSearchBack;
        private ListBox listBoxSearchResults;
        private TextBox textBoxSearchBar;
        private Label lblTeacherCount;
        private Label lblUserSelected;
        private Label label11;
        private Label label5;
        private ComboBox cbbUserRole;
        private TextBox txtUserResult;
        private Panel panelStatistics;
        private Button btnBuscarSinCargos;
        private Button btnAssignRole;
        private Panel panelStatisticsInfo;
        private Label lblLastStudent;
        private Label lblLastTeacher;
        private Label label13;
        private Label label9;
        private Label lblLastUser;
        private Label label2;
        private Panel panelRole;
        private Button btnSoftDelete;
        private Label lblUserCount;
        private Label label20;
        private Label lblRole;
        private Panel panelSelectedUser;
        private Panel panelEnrolonment;
        private Button btnSaveCareerEnrolment;
        private Label lblcareerEntolment;
        private ComboBox cbbListCareer;
        private Panel panelTop;
        private Panel panelMain;
        private Panel panelInfo;
        private Label label21;
        private Button btnClear;
        private Button btnSave;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label7;
        private TextBox txtUserDni;
        private Label label15;
        private TextBox txtUserLastName;
        private Label label6;
        private TextBox txtUserName;
        private Label label8;
        private TextBox txtUserPhoneNumber;
        private Label label10;
        private DateTimePicker UserDateBirth;
        private Label label16;
        private TextBox txtUserBirthPlace;
        private Label label17;
        private TextBox txtUserEmergencyContact;
        private Label label18;
        private ComboBox cbbGender;
        private Label label19;
        private Panel panelRadio;
        private Label label14;
        private Label label12;
        private CheckBox checkBoxDocente;
        private CheckBox checkBoxEstudiante;
        private Panel panel1;
        private Panel panel2;
        private ToolTip toolTip;
    }
}