using Gestin.UI.Custom;

namespace Gestin.UI.Home.Students
{
    partial class formAcademicRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAcademicRecord));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            cbbCareerEnrolment = new ComboBox();
            label2 = new Label();
            lblCarrerResolution = new Label();
            btnEmitRegularStudentCertificate = new Button();
            btnPartialAnalytical = new Button();
            groupBox1 = new GroupBox();
            searchBox = new TextBox();
            lblPersonalData = new Label();
            label1 = new Label();
            lbSearch = new ListBox();
            panel1 = new Panel();
            chkPhotos = new CheckBox();
            chkCuil = new CheckBox();
            chkBirthCert = new CheckBox();
            chkDni = new CheckBox();
            chkMedicCerf = new CheckBox();
            chkAnalitic = new CheckBox();
            panelLeftMenu = new Panel();
            chkCooperative = new CheckBox();
            panelStudentInfoRead = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            txtStudent = new TextBox();
            label7 = new Label();
            txtStudentDni = new TextBox();
            label8 = new Label();
            txtStudentPhoneNumber = new TextBox();
            label9 = new Label();
            txtStudentEmail = new TextBox();
            label10 = new Label();
            txtBirthDate = new TextBox();
            label11 = new Label();
            txtBirthPlace = new TextBox();
            label12 = new Label();
            txtEmergencyContact = new TextBox();
            label13 = new Label();
            txtGender = new TextBox();
            lblStudentId = new Label();
            label3 = new Label();
            panel2 = new Panel();
            gbSeeRegistration = new GroupBox();
            lbSearchRegistration = new Label();
            toggSearchRegistrations = new ToggleButton();
            label4 = new Label();
            btnAddGrade = new Button();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvSubjectsRecord = new DataGridView();
            IdGrade = new DataGridViewTextBoxColumn();
            yearInCarrer = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            SubjectEnrolmentYear = new DataGridViewTextBoxColumn();
            AcreditationType = new DataGridViewTextBoxColumn();
            cursadaAprobada = new DataGridViewCheckBoxColumn();
            approvalDate = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            bookRecord = new DataGridViewTextBoxColumn();
            EnrolmentId = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            gbAcademicStatus = new GroupBox();
            txtPendingSubjects = new TextBox();
            txtAverage = new TextBox();
            txtAccreditedSubjects = new TextBox();
            txtAcademicStatus = new TextBox();
            lbAccreditedSubjects = new Label();
            lbPendingSubjects = new Label();
            lbAverage = new Label();
            lbAcademicStatus = new Label();
            btnDelete = new Button();
            BindingSourceStudentGrades = new BindingSource(components);
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panelLeftMenu.SuspendLayout();
            panelStudentInfoRead.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            gbSeeRegistration.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjectsRecord).BeginInit();
            panel5.SuspendLayout();
            gbAcademicStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BindingSourceStudentGrades).BeginInit();
            SuspendLayout();
            // 
            // cbbCareerEnrolment
            // 
            cbbCareerEnrolment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbCareerEnrolment.BackColor = Color.FromArgb(44, 47, 51);
            cbbCareerEnrolment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCareerEnrolment.FlatStyle = FlatStyle.Flat;
            cbbCareerEnrolment.Font = new Font("Segoe UI", 10F);
            cbbCareerEnrolment.ForeColor = Color.White;
            cbbCareerEnrolment.FormattingEnabled = true;
            cbbCareerEnrolment.Location = new Point(81, 81);
            cbbCareerEnrolment.Margin = new Padding(4, 4, 4, 4);
            cbbCareerEnrolment.MinimumSize = new Size(150, 0);
            cbbCareerEnrolment.Name = "cbbCareerEnrolment";
            cbbCareerEnrolment.Size = new Size(854, 25);
            cbbCareerEnrolment.Sorted = true;
            cbbCareerEnrolment.TabIndex = 14;
            cbbCareerEnrolment.SelectedIndexChanged += cbbCareer_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(960, -159);
            label2.Name = "label2";
            label2.Size = new Size(81, 13);
            label2.TabIndex = 15;
            label2.Text = "Nº Resolución :";
            // 
            // lblCarrerResolution
            // 
            lblCarrerResolution.Anchor = AnchorStyles.Left;
            lblCarrerResolution.AutoSize = true;
            lblCarrerResolution.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblCarrerResolution.ForeColor = Color.White;
            lblCarrerResolution.Location = new Point(960, -182);
            lblCarrerResolution.Name = "lblCarrerResolution";
            lblCarrerResolution.Size = new Size(32, 13);
            lblCarrerResolution.TabIndex = 16;
            lblCarrerResolution.Text = "Res :";
            // 
            // btnEmitRegularStudentCertificate
            // 
            btnEmitRegularStudentCertificate.BackColor = Color.FromArgb(0, 150, 136);
            btnEmitRegularStudentCertificate.FlatAppearance.BorderSize = 0;
            btnEmitRegularStudentCertificate.FlatStyle = FlatStyle.Flat;
            btnEmitRegularStudentCertificate.Font = new Font("Segoe UI", 10F);
            btnEmitRegularStudentCertificate.ForeColor = Color.White;
            btnEmitRegularStudentCertificate.Location = new Point(7, 22);
            btnEmitRegularStudentCertificate.Margin = new Padding(0);
            btnEmitRegularStudentCertificate.Name = "btnEmitRegularStudentCertificate";
            btnEmitRegularStudentCertificate.Size = new Size(123, 26);
            btnEmitRegularStudentCertificate.TabIndex = 17;
            btnEmitRegularStudentCertificate.Text = "Alumno regular";
            btnEmitRegularStudentCertificate.UseVisualStyleBackColor = false;
            btnEmitRegularStudentCertificate.Click += btnEmitRegularStudentCertificate_Click;
            // 
            // btnPartialAnalytical
            // 
            btnPartialAnalytical.BackColor = Color.FromArgb(0, 150, 136);
            btnPartialAnalytical.FlatAppearance.BorderSize = 0;
            btnPartialAnalytical.FlatStyle = FlatStyle.Flat;
            btnPartialAnalytical.Font = new Font("Segoe UI", 10F);
            btnPartialAnalytical.ForeColor = Color.White;
            btnPartialAnalytical.Location = new Point(145, 22);
            btnPartialAnalytical.Margin = new Padding(4, 4, 4, 4);
            btnPartialAnalytical.Name = "btnPartialAnalytical";
            btnPartialAnalytical.Size = new Size(123, 26);
            btnPartialAnalytical.TabIndex = 18;
            btnPartialAnalytical.Text = "Analítico";
            btnPartialAnalytical.UseVisualStyleBackColor = false;
            btnPartialAnalytical.Click += btnPartialAnalytical_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEmitRegularStudentCertificate);
            groupBox1.Controls.Add(btnPartialAnalytical);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(4, 11);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(277, 62);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Emisión de certificados";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(35, 39, 42);
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(4, 11);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "  Buscar estudiante";
            searchBox.Size = new Size(228, 25);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.KeyDown += searchBox_KeyDown;
            // 
            // lblPersonalData
            // 
            lblPersonalData.AutoSize = true;
            lblPersonalData.BackColor = Color.Transparent;
            lblPersonalData.FlatStyle = FlatStyle.Flat;
            lblPersonalData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPersonalData.ForeColor = Color.White;
            lblPersonalData.Location = new Point(4, 0);
            lblPersonalData.Name = "lblPersonalData";
            lblPersonalData.Size = new Size(140, 21);
            lblPersonalData.TabIndex = 27;
            lblPersonalData.Text = "Datos personales";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 30;
            label1.Text = "Documentación presentada";
            // 
            // lbSearch
            // 
            lbSearch.BackColor = Color.FromArgb(54, 57, 63);
            lbSearch.BorderStyle = BorderStyle.FixedSingle;
            lbSearch.Font = new Font("Segoe UI", 10F);
            lbSearch.ForeColor = Color.White;
            lbSearch.FormattingEnabled = true;
            lbSearch.ItemHeight = 17;
            lbSearch.Location = new Point(4, 38);
            lbSearch.Margin = new Padding(3, 2, 3, 2);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(228, 461);
            lbSearch.TabIndex = 32;
            lbSearch.Visible = false;
            lbSearch.KeyDown += lbSearch_KeyDown;
            lbSearch.MouseDoubleClick += lbSearch_MouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(chkPhotos);
            panel1.Controls.Add(chkCuil);
            panel1.Controls.Add(chkBirthCert);
            panel1.Controls.Add(chkDni);
            panel1.Controls.Add(chkMedicCerf);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(chkAnalitic);
            panel1.Location = new Point(3, 514);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 190);
            panel1.TabIndex = 33;
            // 
            // chkPhotos
            // 
            chkPhotos.AutoCheck = false;
            chkPhotos.AutoSize = true;
            chkPhotos.Font = new Font("Segoe UI", 8F);
            chkPhotos.ForeColor = Color.White;
            chkPhotos.Location = new Point(13, 127);
            chkPhotos.Margin = new Padding(3, 2, 3, 2);
            chkPhotos.Name = "chkPhotos";
            chkPhotos.Size = new Size(55, 17);
            chkPhotos.TabIndex = 5;
            chkPhotos.Text = "Fotos";
            chkPhotos.UseVisualStyleBackColor = true;
            // 
            // chkCuil
            // 
            chkCuil.AutoCheck = false;
            chkCuil.AutoSize = true;
            chkCuil.Font = new Font("Segoe UI", 8F);
            chkCuil.ForeColor = Color.White;
            chkCuil.Location = new Point(13, 148);
            chkCuil.Margin = new Padding(3, 2, 3, 2);
            chkCuil.Name = "chkCuil";
            chkCuil.Size = new Size(49, 17);
            chkCuil.TabIndex = 4;
            chkCuil.Text = "CUIL";
            chkCuil.UseVisualStyleBackColor = true;
            // 
            // chkBirthCert
            // 
            chkBirthCert.AutoCheck = false;
            chkBirthCert.AutoSize = true;
            chkBirthCert.Font = new Font("Segoe UI", 8F);
            chkBirthCert.ForeColor = Color.White;
            chkBirthCert.Location = new Point(13, 82);
            chkBirthCert.Margin = new Padding(3, 2, 3, 2);
            chkBirthCert.Name = "chkBirthCert";
            chkBirthCert.Size = new Size(158, 17);
            chkBirthCert.TabIndex = 3;
            chkBirthCert.Text = "Certificado de nacimiento";
            chkBirthCert.UseVisualStyleBackColor = true;
            // 
            // chkDni
            // 
            chkDni.AutoCheck = false;
            chkDni.AutoSize = true;
            chkDni.Font = new Font("Segoe UI", 8F);
            chkDni.ForeColor = Color.White;
            chkDni.Location = new Point(13, 60);
            chkDni.Margin = new Padding(3, 2, 3, 2);
            chkDni.Name = "chkDni";
            chkDni.Size = new Size(45, 17);
            chkDni.TabIndex = 2;
            chkDni.Text = "DNI";
            chkDni.UseVisualStyleBackColor = true;
            // 
            // chkMedicCerf
            // 
            chkMedicCerf.AutoCheck = false;
            chkMedicCerf.AutoSize = true;
            chkMedicCerf.Font = new Font("Segoe UI", 8F);
            chkMedicCerf.ForeColor = Color.White;
            chkMedicCerf.Location = new Point(13, 104);
            chkMedicCerf.Margin = new Padding(3, 2, 3, 2);
            chkMedicCerf.Name = "chkMedicCerf";
            chkMedicCerf.Size = new Size(132, 17);
            chkMedicCerf.TabIndex = 1;
            chkMedicCerf.Text = "Certificados medicos";
            chkMedicCerf.UseVisualStyleBackColor = true;
            // 
            // chkAnalitic
            // 
            chkAnalitic.AutoCheck = false;
            chkAnalitic.AutoSize = true;
            chkAnalitic.Font = new Font("Segoe UI", 8F);
            chkAnalitic.ForeColor = Color.White;
            chkAnalitic.Location = new Point(13, 37);
            chkAnalitic.Margin = new Padding(3, 2, 3, 2);
            chkAnalitic.Name = "chkAnalitic";
            chkAnalitic.Size = new Size(131, 17);
            chkAnalitic.TabIndex = 0;
            chkAnalitic.Text = "Analitico secundario";
            chkAnalitic.UseVisualStyleBackColor = true;
            // 
            // panelLeftMenu
            // 
            panelLeftMenu.BackColor = Color.FromArgb(44, 47, 51);
            panelLeftMenu.Controls.Add(chkCooperative);
            panelLeftMenu.Controls.Add(panelStudentInfoRead);
            panelLeftMenu.Controls.Add(searchBox);
            panelLeftMenu.Controls.Add(lbSearch);
            panelLeftMenu.Dock = DockStyle.Left;
            panelLeftMenu.Location = new Point(0, 0);
            panelLeftMenu.Name = "panelLeftMenu";
            panelLeftMenu.Size = new Size(252, 562);
            panelLeftMenu.TabIndex = 36;
            // 
            // chkCooperative
            // 
            chkCooperative.AutoCheck = false;
            chkCooperative.AutoSize = true;
            chkCooperative.Font = new Font("Segoe UI", 8F);
            chkCooperative.ForeColor = Color.White;
            chkCooperative.Location = new Point(16, 724);
            chkCooperative.Margin = new Padding(3, 2, 3, 2);
            chkCooperative.Name = "chkCooperative";
            chkCooperative.Size = new Size(88, 17);
            chkCooperative.TabIndex = 31;
            chkCooperative.Text = "Cooperativa";
            chkCooperative.UseVisualStyleBackColor = true;
            // 
            // panelStudentInfoRead
            // 
            panelStudentInfoRead.BackColor = Color.FromArgb(44, 47, 51);
            panelStudentInfoRead.Controls.Add(flowLayoutPanel1);
            panelStudentInfoRead.Controls.Add(panel1);
            panelStudentInfoRead.Controls.Add(lblPersonalData);
            panelStudentInfoRead.Location = new Point(0, 41);
            panelStudentInfoRead.Name = "panelStudentInfoRead";
            panelStudentInfoRead.Size = new Size(241, 679);
            panelStudentInfoRead.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtStudent);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(txtStudentDni);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(txtStudentPhoneNumber);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(txtStudentEmail);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(txtBirthDate);
            flowLayoutPanel1.Controls.Add(label11);
            flowLayoutPanel1.Controls.Add(txtBirthPlace);
            flowLayoutPanel1.Controls.Add(label12);
            flowLayoutPanel1.Controls.Add(txtEmergencyContact);
            flowLayoutPanel1.Controls.Add(label13);
            flowLayoutPanel1.Controls.Add(txtGender);
            flowLayoutPanel1.Location = new Point(4, 26);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(237, 482);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(163, 21);
            label6.TabIndex = 26;
            label6.Text = "Apellido y Nombre :";
            // 
            // txtStudent
            // 
            txtStudent.BackColor = Color.FromArgb(44, 47, 51);
            txtStudent.BorderStyle = BorderStyle.FixedSingle;
            txtStudent.Font = new Font("Segoe UI", 10F);
            txtStudent.ForeColor = Color.White;
            txtStudent.Location = new Point(3, 23);
            txtStudent.Margin = new Padding(3, 2, 3, 2);
            txtStudent.Name = "txtStudent";
            txtStudent.ReadOnly = true;
            txtStudent.Size = new Size(222, 25);
            txtStudent.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 60);
            label7.Margin = new Padding(3, 10, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 21);
            label7.TabIndex = 5;
            label7.Text = "Dni :";
            // 
            // txtStudentDni
            // 
            txtStudentDni.BackColor = Color.FromArgb(44, 47, 51);
            txtStudentDni.BorderStyle = BorderStyle.FixedSingle;
            txtStudentDni.Font = new Font("Segoe UI", 10F);
            txtStudentDni.ForeColor = Color.White;
            txtStudentDni.Location = new Point(3, 83);
            txtStudentDni.Margin = new Padding(3, 2, 3, 2);
            txtStudentDni.Name = "txtStudentDni";
            txtStudentDni.ReadOnly = true;
            txtStudentDni.Size = new Size(222, 25);
            txtStudentDni.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 120);
            label8.Margin = new Padding(3, 10, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 21);
            label8.TabIndex = 9;
            label8.Text = "Teléfono :";
            // 
            // txtStudentPhoneNumber
            // 
            txtStudentPhoneNumber.BackColor = Color.FromArgb(44, 47, 51);
            txtStudentPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtStudentPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtStudentPhoneNumber.ForeColor = Color.White;
            txtStudentPhoneNumber.Location = new Point(3, 143);
            txtStudentPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtStudentPhoneNumber.Name = "txtStudentPhoneNumber";
            txtStudentPhoneNumber.ReadOnly = true;
            txtStudentPhoneNumber.Size = new Size(221, 25);
            txtStudentPhoneNumber.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 180);
            label9.Margin = new Padding(3, 10, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(159, 21);
            label9.TabIndex = 22;
            label9.Text = "Correo electrónico :";
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.BackColor = Color.FromArgb(44, 47, 51);
            txtStudentEmail.BorderStyle = BorderStyle.FixedSingle;
            txtStudentEmail.Font = new Font("Segoe UI", 10F);
            txtStudentEmail.ForeColor = Color.White;
            txtStudentEmail.Location = new Point(3, 203);
            txtStudentEmail.Margin = new Padding(3, 2, 3, 2);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.ReadOnly = true;
            txtStudentEmail.Size = new Size(221, 25);
            txtStudentEmail.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 240);
            label10.Margin = new Padding(3, 10, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(176, 21);
            label10.TabIndex = 28;
            label10.Text = "Fecha de nacimiento :";
            // 
            // txtBirthDate
            // 
            txtBirthDate.BackColor = Color.FromArgb(44, 47, 51);
            txtBirthDate.BorderStyle = BorderStyle.FixedSingle;
            txtBirthDate.Font = new Font("Segoe UI", 10F);
            txtBirthDate.ForeColor = Color.White;
            txtBirthDate.Location = new Point(3, 263);
            txtBirthDate.Margin = new Padding(3, 2, 3, 2);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.ReadOnly = true;
            txtBirthDate.Size = new Size(222, 25);
            txtBirthDate.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(3, 300);
            label11.Margin = new Padding(3, 10, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(175, 21);
            label11.TabIndex = 33;
            label11.Text = "Lugar de nacimiento :";
            // 
            // txtBirthPlace
            // 
            txtBirthPlace.BackColor = Color.FromArgb(44, 47, 51);
            txtBirthPlace.BorderStyle = BorderStyle.FixedSingle;
            txtBirthPlace.Font = new Font("Segoe UI", 10F);
            txtBirthPlace.ForeColor = Color.White;
            txtBirthPlace.Location = new Point(3, 323);
            txtBirthPlace.Margin = new Padding(3, 2, 3, 2);
            txtBirthPlace.Name = "txtBirthPlace";
            txtBirthPlace.ReadOnly = true;
            txtBirthPlace.Size = new Size(222, 25);
            txtBirthPlace.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 360);
            label12.Margin = new Padding(3, 10, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(202, 21);
            label12.TabIndex = 32;
            label12.Text = "Teléfono de emergencia :";
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.BackColor = Color.FromArgb(44, 47, 51);
            txtEmergencyContact.BorderStyle = BorderStyle.FixedSingle;
            txtEmergencyContact.Font = new Font("Segoe UI", 10F);
            txtEmergencyContact.ForeColor = Color.White;
            txtEmergencyContact.Location = new Point(3, 383);
            txtEmergencyContact.Margin = new Padding(3, 2, 3, 2);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.ReadOnly = true;
            txtEmergencyContact.Size = new Size(221, 25);
            txtEmergencyContact.TabIndex = 33;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 420);
            label13.Margin = new Padding(3, 10, 3, 0);
            label13.Name = "label13";
            label13.Size = new Size(73, 21);
            label13.TabIndex = 34;
            label13.Text = "Género :";
            // 
            // txtGender
            // 
            txtGender.BackColor = Color.FromArgb(44, 47, 51);
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Font = new Font("Segoe UI", 10F);
            txtGender.ForeColor = Color.White;
            txtGender.Location = new Point(3, 443);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(221, 25);
            txtGender.TabIndex = 35;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.ForeColor = Color.White;
            lblStudentId.Location = new Point(363, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(78, 15);
            lblStudentId.TabIndex = 36;
            lblStudentId.Text = "--StudentId--";
            lblStudentId.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(296, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 35;
            label3.Text = "Student Id";
            label3.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 47, 51);
            panel2.Controls.Add(gbSeeRegistration);
            panel2.Controls.Add(lblStudentId);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(cbbCareerEnrolment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblCarrerResolution);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(252, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(947, 121);
            panel2.TabIndex = 37;
            // 
            // gbSeeRegistration
            // 
            gbSeeRegistration.Anchor = AnchorStyles.Top;
            gbSeeRegistration.Controls.Add(lbSearchRegistration);
            gbSeeRegistration.Controls.Add(toggSearchRegistrations);
            gbSeeRegistration.ForeColor = Color.WhiteSmoke;
            gbSeeRegistration.Location = new Point(530, 19);
            gbSeeRegistration.Name = "gbSeeRegistration";
            gbSeeRegistration.Size = new Size(235, 55);
            gbSeeRegistration.TabIndex = 66;
            gbSeeRegistration.TabStop = false;
            gbSeeRegistration.Text = "Ver matriculaciones";
            gbSeeRegistration.Visible = false;
            // 
            // lbSearchRegistration
            // 
            lbSearchRegistration.AutoSize = true;
            lbSearchRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSearchRegistration.ForeColor = Color.White;
            lbSearchRegistration.Location = new Point(12, 19);
            lbSearchRegistration.Margin = new Padding(4, 0, 4, 0);
            lbSearchRegistration.Name = "lbSearchRegistration";
            lbSearchRegistration.Size = new Size(92, 21);
            lbSearchRegistration.TabIndex = 52;
            lbSearchRegistration.Text = "Año actual";
            // 
            // toggSearchRegistrations
            // 
            toggSearchRegistrations.AutoSize = true;
            toggSearchRegistrations.FlatStyle = FlatStyle.Flat;
            toggSearchRegistrations.Location = new Point(161, 19);
            toggSearchRegistrations.MinimumSize = new Size(45, 22);
            toggSearchRegistrations.Name = "toggSearchRegistrations";
            toggSearchRegistrations.OffBackColor = Color.Gray;
            toggSearchRegistrations.OffToggleColor = Color.Gainsboro;
            toggSearchRegistrations.OnBackColor = Color.FromArgb(0, 150, 136);
            toggSearchRegistrations.OnToggleColor = Color.WhiteSmoke;
            toggSearchRegistrations.Size = new Size(45, 22);
            toggSearchRegistrations.TabIndex = 53;
            toggSearchRegistrations.UseVisualStyleBackColor = true;
            toggSearchRegistrations.CheckedChanged += toggSearchRegistrations_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(54, 57, 63);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 81);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 39;
            label4.Text = "Carrera :";
            // 
            // btnAddGrade
            // 
            btnAddGrade.BackColor = Color.FromArgb(0, 150, 136);
            btnAddGrade.Enabled = false;
            btnAddGrade.FlatAppearance.BorderSize = 0;
            btnAddGrade.FlatStyle = FlatStyle.Flat;
            btnAddGrade.Font = new Font("Segoe UI", 10F);
            btnAddGrade.ForeColor = Color.White;
            btnAddGrade.Image = (Image)resources.GetObject("btnAddGrade.Image");
            btnAddGrade.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddGrade.Location = new Point(11, 17);
            btnAddGrade.Margin = new Padding(4, 4, 4, 4);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(123, 30);
            btnAddGrade.TabIndex = 34;
            btnAddGrade.Text = "Agregar nota";
            btnAddGrade.TextAlign = ContentAlignment.MiddleRight;
            btnAddGrade.UseVisualStyleBackColor = false;
            btnAddGrade.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 47, 51);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(252, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 441);
            panel3.TabIndex = 36;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(44, 47, 51);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.Controls.Add(dgvSubjectsRecord, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(947, 342);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // dgvSubjectsRecord
            // 
            dgvSubjectsRecord.AllowUserToAddRows = false;
            dgvSubjectsRecord.AllowUserToDeleteRows = false;
            dgvSubjectsRecord.AllowUserToResizeRows = false;
            dgvSubjectsRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjectsRecord.BackgroundColor = Color.FromArgb(44, 47, 51);
            dgvSubjectsRecord.BorderStyle = BorderStyle.None;
            dgvSubjectsRecord.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSubjectsRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSubjectsRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjectsRecord.Columns.AddRange(new DataGridViewColumn[] { IdGrade, yearInCarrer, Materia, SubjectEnrolmentYear, AcreditationType, cursadaAprobada, approvalDate, grade, bookRecord, EnrolmentId });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle9.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvSubjectsRecord.DefaultCellStyle = dataGridViewCellStyle9;
            dgvSubjectsRecord.Dock = DockStyle.Fill;
            dgvSubjectsRecord.EnableHeadersVisualStyles = false;
            dgvSubjectsRecord.GridColor = Color.FromArgb(0, 150, 136);
            dgvSubjectsRecord.Location = new Point(0, 0);
            dgvSubjectsRecord.Margin = new Padding(0);
            dgvSubjectsRecord.MultiSelect = false;
            dgvSubjectsRecord.Name = "dgvSubjectsRecord";
            dgvSubjectsRecord.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvSubjectsRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvSubjectsRecord.RowHeadersVisible = false;
            dgvSubjectsRecord.RowHeadersWidth = 51;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dgvSubjectsRecord.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvSubjectsRecord.RowTemplate.Height = 24;
            dgvSubjectsRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubjectsRecord.Size = new Size(928, 342);
            dgvSubjectsRecord.TabIndex = 0;
            dgvSubjectsRecord.CellFormatting += dgvSubjectsRecord_CellFormatting;
            dgvSubjectsRecord.SelectionChanged += dgvSubjectsRecord_SelectionChanged;
            dgvSubjectsRecord.MouseDoubleClick += dgvSubjectsRecord_MouseDoubleClick;
            // 
            // IdGrade
            // 
            IdGrade.DataPropertyName = "GradeId";
            IdGrade.FillWeight = 70F;
            IdGrade.HeaderText = "IdCalificacion";
            IdGrade.MinimumWidth = 6;
            IdGrade.Name = "IdGrade";
            IdGrade.Visible = false;
            // 
            // yearInCarrer
            // 
            yearInCarrer.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            yearInCarrer.DataPropertyName = "SubjectYearInCareer";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            yearInCarrer.DefaultCellStyle = dataGridViewCellStyle2;
            yearInCarrer.FillWeight = 17.2146778F;
            yearInCarrer.HeaderText = "Año";
            yearInCarrer.MaxInputLength = 1;
            yearInCarrer.MinimumWidth = 6;
            yearInCarrer.Name = "yearInCarrer";
            yearInCarrer.ReadOnly = true;
            yearInCarrer.Width = 61;
            // 
            // Materia
            // 
            Materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Materia.DataPropertyName = "Subject";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Materia.DefaultCellStyle = dataGridViewCellStyle3;
            Materia.FillWeight = 131.880829F;
            Materia.HeaderText = "Materia";
            Materia.MinimumWidth = 6;
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // SubjectEnrolmentYear
            // 
            SubjectEnrolmentYear.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SubjectEnrolmentYear.DataPropertyName = "SubjectEnrolmentYear";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Sin cursar";
            SubjectEnrolmentYear.DefaultCellStyle = dataGridViewCellStyle4;
            SubjectEnrolmentYear.FillWeight = 26.8499851F;
            SubjectEnrolmentYear.HeaderText = "Matriculación";
            SubjectEnrolmentYear.MinimumWidth = 6;
            SubjectEnrolmentYear.Name = "SubjectEnrolmentYear";
            SubjectEnrolmentYear.ReadOnly = true;
            SubjectEnrolmentYear.Width = 127;
            // 
            // AcreditationType
            // 
            AcreditationType.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            AcreditationType.DataPropertyName = "GradeAccreditationType";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AcreditationType.DefaultCellStyle = dataGridViewCellStyle5;
            AcreditationType.FillWeight = 26.3761635F;
            AcreditationType.HeaderText = "Condición";
            AcreditationType.MinimumWidth = 6;
            AcreditationType.Name = "AcreditationType";
            AcreditationType.ReadOnly = true;
            AcreditationType.Width = 103;
            // 
            // cursadaAprobada
            // 
            cursadaAprobada.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cursadaAprobada.DataPropertyName = "SubjectEnrolmentApproved";
            cursadaAprobada.FillWeight = 126.737976F;
            cursadaAprobada.HeaderText = "¿Aprobó la cursada?";
            cursadaAprobada.MinimumWidth = 6;
            cursadaAprobada.Name = "cursadaAprobada";
            cursadaAprobada.ReadOnly = true;
            cursadaAprobada.Width = 139;
            // 
            // approvalDate
            // 
            approvalDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            approvalDate.DataPropertyName = "GradeAccreditationDate";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            approvalDate.DefaultCellStyle = dataGridViewCellStyle6;
            approvalDate.FillWeight = 26.3761635F;
            approvalDate.HeaderText = "Acreditación";
            approvalDate.MinimumWidth = 6;
            approvalDate.Name = "approvalDate";
            approvalDate.ReadOnly = true;
            approvalDate.Width = 119;
            // 
            // grade
            // 
            grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grade.DataPropertyName = "Grade";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grade.DefaultCellStyle = dataGridViewCellStyle7;
            grade.FillWeight = 13.1880817F;
            grade.HeaderText = "Nota";
            grade.MinimumWidth = 6;
            grade.Name = "grade";
            grade.ReadOnly = true;
            grade.Width = 67;
            // 
            // bookRecord
            // 
            bookRecord.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookRecord.DataPropertyName = "GradeBookRecord";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Padding = new Padding(2, 0, 2, 0);
            bookRecord.DefaultCellStyle = dataGridViewCellStyle8;
            bookRecord.FillWeight = 26.3761635F;
            bookRecord.HeaderText = "Acta";
            bookRecord.MinimumWidth = 6;
            bookRecord.Name = "bookRecord";
            bookRecord.ReadOnly = true;
            bookRecord.Width = 63;
            // 
            // EnrolmentId
            // 
            EnrolmentId.DataPropertyName = "SubjectEnrolmentId";
            EnrolmentId.HeaderText = "Id cursada";
            EnrolmentId.MinimumWidth = 6;
            EnrolmentId.Name = "EnrolmentId";
            EnrolmentId.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(44, 47, 51);
            panel5.Controls.Add(gbAcademicStatus);
            panel5.Controls.Add(btnAddGrade);
            panel5.Controls.Add(btnDelete);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 342);
            panel5.Name = "panel5";
            panel5.Size = new Size(947, 99);
            panel5.TabIndex = 20;
            // 
            // gbAcademicStatus
            // 
            gbAcademicStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbAcademicStatus.Controls.Add(txtPendingSubjects);
            gbAcademicStatus.Controls.Add(txtAverage);
            gbAcademicStatus.Controls.Add(txtAccreditedSubjects);
            gbAcademicStatus.Controls.Add(txtAcademicStatus);
            gbAcademicStatus.Controls.Add(lbAccreditedSubjects);
            gbAcademicStatus.Controls.Add(lbPendingSubjects);
            gbAcademicStatus.Controls.Add(lbAverage);
            gbAcademicStatus.Controls.Add(lbAcademicStatus);
            gbAcademicStatus.Font = new Font("Segoe UI", 9F);
            gbAcademicStatus.ForeColor = Color.White;
            gbAcademicStatus.Location = new Point(348, 4);
            gbAcademicStatus.Margin = new Padding(4, 4, 4, 4);
            gbAcademicStatus.Name = "gbAcademicStatus";
            gbAcademicStatus.Padding = new Padding(4, 4, 4, 4);
            gbAcademicStatus.Size = new Size(561, 89);
            gbAcademicStatus.TabIndex = 35;
            gbAcademicStatus.TabStop = false;
            gbAcademicStatus.Text = "Estado academico";
            // 
            // txtPendingSubjects
            // 
            txtPendingSubjects.BackColor = Color.FromArgb(44, 47, 51);
            txtPendingSubjects.BorderStyle = BorderStyle.FixedSingle;
            txtPendingSubjects.Font = new Font("Segoe UI", 10F);
            txtPendingSubjects.ForeColor = Color.White;
            txtPendingSubjects.Location = new Point(182, 24);
            txtPendingSubjects.Margin = new Padding(3, 2, 3, 2);
            txtPendingSubjects.Name = "txtPendingSubjects";
            txtPendingSubjects.ReadOnly = true;
            txtPendingSubjects.Size = new Size(52, 25);
            txtPendingSubjects.TabIndex = 42;
            // 
            // txtAverage
            // 
            txtAverage.BackColor = Color.FromArgb(44, 47, 51);
            txtAverage.BorderStyle = BorderStyle.FixedSingle;
            txtAverage.Font = new Font("Segoe UI", 10F);
            txtAverage.ForeColor = Color.White;
            txtAverage.Location = new Point(408, 58);
            txtAverage.Margin = new Padding(3, 2, 3, 2);
            txtAverage.Name = "txtAverage";
            txtAverage.ReadOnly = true;
            txtAverage.Size = new Size(94, 25);
            txtAverage.TabIndex = 41;
            // 
            // txtAccreditedSubjects
            // 
            txtAccreditedSubjects.BackColor = Color.FromArgb(44, 47, 51);
            txtAccreditedSubjects.BorderStyle = BorderStyle.FixedSingle;
            txtAccreditedSubjects.Font = new Font("Segoe UI", 10F);
            txtAccreditedSubjects.ForeColor = Color.White;
            txtAccreditedSubjects.Location = new Point(182, 58);
            txtAccreditedSubjects.Margin = new Padding(3, 2, 3, 2);
            txtAccreditedSubjects.Name = "txtAccreditedSubjects";
            txtAccreditedSubjects.ReadOnly = true;
            txtAccreditedSubjects.Size = new Size(52, 25);
            txtAccreditedSubjects.TabIndex = 40;
            // 
            // txtAcademicStatus
            // 
            txtAcademicStatus.BackColor = Color.FromArgb(44, 47, 51);
            txtAcademicStatus.BorderStyle = BorderStyle.FixedSingle;
            txtAcademicStatus.Font = new Font("Segoe UI", 10F);
            txtAcademicStatus.ForeColor = Color.White;
            txtAcademicStatus.Location = new Point(408, 25);
            txtAcademicStatus.Margin = new Padding(3, 2, 3, 2);
            txtAcademicStatus.Name = "txtAcademicStatus";
            txtAcademicStatus.ReadOnly = true;
            txtAcademicStatus.Size = new Size(132, 25);
            txtAcademicStatus.TabIndex = 39;
            // 
            // lbAccreditedSubjects
            // 
            lbAccreditedSubjects.AutoSize = true;
            lbAccreditedSubjects.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbAccreditedSubjects.ForeColor = Color.White;
            lbAccreditedSubjects.Location = new Point(22, 60);
            lbAccreditedSubjects.Margin = new Padding(3, 10, 3, 0);
            lbAccreditedSubjects.Name = "lbAccreditedSubjects";
            lbAccreditedSubjects.Size = new Size(153, 19);
            lbAccreditedSubjects.TabIndex = 38;
            lbAccreditedSubjects.Text = "Materias acreditadas:";
            // 
            // lbPendingSubjects
            // 
            lbPendingSubjects.AutoSize = true;
            lbPendingSubjects.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbPendingSubjects.ForeColor = Color.White;
            lbPendingSubjects.Location = new Point(22, 27);
            lbPendingSubjects.Margin = new Padding(3, 10, 3, 0);
            lbPendingSubjects.Name = "lbPendingSubjects";
            lbPendingSubjects.Size = new Size(148, 19);
            lbPendingSubjects.TabIndex = 37;
            lbPendingSubjects.Text = "Materias pendientes:";
            // 
            // lbAverage
            // 
            lbAverage.AutoSize = true;
            lbAverage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbAverage.ForeColor = Color.White;
            lbAverage.Location = new Point(270, 60);
            lbAverage.Margin = new Padding(3, 10, 3, 0);
            lbAverage.Name = "lbAverage";
            lbAverage.Size = new Size(128, 19);
            lbAverage.TabIndex = 36;
            lbAverage.Text = "Promedio actual :";
            // 
            // lbAcademicStatus
            // 
            lbAcademicStatus.AutoSize = true;
            lbAcademicStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lbAcademicStatus.ForeColor = Color.White;
            lbAcademicStatus.Location = new Point(264, 26);
            lbAcademicStatus.Margin = new Padding(3, 10, 3, 0);
            lbAcademicStatus.Name = "lbAcademicStatus";
            lbAcademicStatus.Size = new Size(134, 19);
            lbAcademicStatus.TabIndex = 35;
            lbAcademicStatus.Text = "Estado academico:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(11, 60);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(234, 30);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Eliminar registro seleccionado";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // formAcademicRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1199, 562);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelLeftMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formAcademicRecord";
            Text = "Gestin - Registro académico";
            Load += formAcademicRecord_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLeftMenu.ResumeLayout(false);
            panelLeftMenu.PerformLayout();
            panelStudentInfoRead.ResumeLayout(false);
            panelStudentInfoRead.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gbSeeRegistration.ResumeLayout(false);
            gbSeeRegistration.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubjectsRecord).EndInit();
            panel5.ResumeLayout(false);
            gbAcademicStatus.ResumeLayout(false);
            gbAcademicStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BindingSourceStudentGrades).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbbCareerEnrolment;
        private Label label2;
        private Label lblCarrerResolution;
        private Button btnEmitRegularStudentCertificate;
        private Button btnPartialAnalytical;
        private GroupBox groupBox1;
        private TextBox searchBox;
        private Label lblPersonalData;
        private Label label1;
        private ListBox lbSearch;
        private Panel panel1;
        private CheckBox chkPhotos;
        private CheckBox chkCuil;
        private CheckBox chkBirthCert;
        private CheckBox chkDni;
        private CheckBox chkMedicCerf;
        private CheckBox chkAnalitic;
        private Panel panelLeftMenu;
        private Panel panel2;
        private Panel panel3;
        private Button btnAddGrade;
        private Panel panelStudentInfoRead;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private TextBox txtStudent;
        private Label label7;
        private TextBox txtStudentDni;
        private Label label8;
        private TextBox txtStudentPhoneNumber;
        private Label label9;
        private TextBox txtStudentEmail;
        private Label label10;
        private TextBox txtBirthDate;
        private Label label11;
        private TextBox txtBirthPlace;
        private Label label12;
        private TextBox txtEmergencyContact;
        private Label label13;
        private TextBox txtGender;
        private Panel panel5;
        private Label lblStudentId;
        private Label label3;
        private Button btnDelete;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvSubjectsRecord;
        private GroupBox gbAcademicStatus;
        private TextBox txtAcademicStatus;
        private Label lbAccreditedSubjects;
        private Label lbPendingSubjects;
        private Label lbAverage;
        private Label lbAcademicStatus;
        private TextBox txtAccreditedSubjects;
        private TextBox txtPendingSubjects;
        private TextBox txtAverage;
        private GroupBox gbSeeRegistration;
        private Label lbSearchRegistration;
        private ToggleButton toggSearchRegistrations;
        private BindingSource BindingSourceStudentGrades;
        private CheckBox chkCooperative;
        private DataGridViewTextBoxColumn IdGrade;
        private DataGridViewTextBoxColumn yearInCarrer;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn SubjectEnrolmentYear;
        private DataGridViewTextBoxColumn AcreditationType;
        private DataGridViewCheckBoxColumn cursadaAprobada;
        private DataGridViewTextBoxColumn approvalDate;
        private DataGridViewTextBoxColumn grade;
        private DataGridViewTextBoxColumn bookRecord;
        private DataGridViewTextBoxColumn EnrolmentId;
    }
}