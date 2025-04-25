using Gestin.Properties;

namespace Gestin.UI.Home.Users
{
    partial class formUserRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUserRole));
            MainPanel = new Panel();
            label6 = new Label();
            panelMain = new Panel();
            chkStatus = new CheckBox();
            lblUserRole = new Label();
            RolePanel = new Panel();
            txtCuil = new TextBox();
            lblOcupation = new Label();
            lblCuil = new Label();
            lblWorkHours = new Label();
            txtTitle = new TextBox();
            lblTitle = new Label();
            chkMedicalCertificate = new CheckBox();
            txtWorkHours = new TextBox();
            chkCooperative = new CheckBox();
            lblHealthcare = new Label();
            chkCUIL = new CheckBox();
            txtOcupation = new TextBox();
            chkPhoto = new CheckBox();
            txtHealthcare = new TextBox();
            chkBirthCertificate = new CheckBox();
            chkAnalitic = new CheckBox();
            chkDNI = new CheckBox();
            label9 = new Label();
            txtUserEmail = new TextBox();
            panel1 = new Panel();
            label10 = new Label();
            panelLogin = new Panel();
            btnSeePasswords = new Button();
            txtPasswordConfirm = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtPassword = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            btnInfo = new Button();
            panel5 = new Panel();
            labelHidden = new Label();
            btnReactivate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            lblResult = new Label();
            label8 = new Label();
            panelDisplay = new Panel();
            lblUserName = new Label();
            lableTimer = new System.Windows.Forms.Timer(components);
            toolTip = new ToolTip(components);
            MainPanel.SuspendLayout();
            panelMain.SuspendLayout();
            RolePanel.SuspendLayout();
            panel1.SuspendLayout();
            panelLogin.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panelDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(54, 57, 63);
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(panelMain);
            MainPanel.Controls.Add(RolePanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(350, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(936, 408);
            MainPanel.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(54, 8);
            label6.Name = "label6";
            label6.Size = new Size(117, 18);
            label6.TabIndex = 76;
            label6.Text = "Tipo de Usuario:";
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.Fixed3D;
            panelMain.Controls.Add(chkStatus);
            panelMain.Controls.Add(lblUserRole);
            panelMain.Location = new Point(54, 29);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(450, 125);
            panelMain.TabIndex = 75;
            // 
            // chkStatus
            // 
            chkStatus.Appearance = Appearance.Button;
            chkStatus.BackColor = Color.White;
            chkStatus.Dock = DockStyle.Right;
            chkStatus.Location = new Point(401, 0);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(45, 121);
            chkStatus.TabIndex = 72;
            chkStatus.UseVisualStyleBackColor = false;
            // 
            // lblUserRole
            // 
            lblUserRole.Dock = DockStyle.Fill;
            lblUserRole.Font = new Font("Microsoft Sans Serif", 16.2F);
            lblUserRole.Location = new Point(0, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(446, 121);
            lblUserRole.TabIndex = 71;
            lblUserRole.Text = "UserRole";
            lblUserRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RolePanel
            // 
            RolePanel.BackColor = Color.FromArgb(54, 57, 63);
            RolePanel.BorderStyle = BorderStyle.FixedSingle;
            RolePanel.Controls.Add(txtCuil);
            RolePanel.Controls.Add(lblOcupation);
            RolePanel.Controls.Add(lblCuil);
            RolePanel.Controls.Add(lblWorkHours);
            RolePanel.Controls.Add(txtTitle);
            RolePanel.Controls.Add(lblTitle);
            RolePanel.Controls.Add(chkMedicalCertificate);
            RolePanel.Controls.Add(txtWorkHours);
            RolePanel.Controls.Add(chkCooperative);
            RolePanel.Controls.Add(lblHealthcare);
            RolePanel.Controls.Add(chkCUIL);
            RolePanel.Controls.Add(txtOcupation);
            RolePanel.Controls.Add(chkPhoto);
            RolePanel.Controls.Add(txtHealthcare);
            RolePanel.Controls.Add(chkBirthCertificate);
            RolePanel.Controls.Add(chkAnalitic);
            RolePanel.Controls.Add(chkDNI);
            RolePanel.Location = new Point(21, 170);
            RolePanel.Name = "RolePanel";
            RolePanel.Size = new Size(496, 229);
            RolePanel.TabIndex = 72;
            // 
            // txtCuil
            // 
            txtCuil.BackColor = Color.FromArgb(35, 39, 42);
            txtCuil.ForeColor = Color.White;
            txtCuil.Location = new Point(102, 133);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(305, 27);
            txtCuil.TabIndex = 5;
            // 
            // lblOcupation
            // 
            lblOcupation.AutoSize = true;
            lblOcupation.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblOcupation.Location = new Point(8, 26);
            lblOcupation.Name = "lblOcupation";
            lblOcupation.Size = new Size(89, 20);
            lblOcupation.TabIndex = 64;
            lblOcupation.Text = "Ocupación";
            // 
            // lblCuil
            // 
            lblCuil.AutoSize = true;
            lblCuil.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblCuil.Location = new Point(105, 111);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(38, 20);
            lblCuil.TabIndex = 19;
            lblCuil.Text = "Cuil";
            // 
            // lblWorkHours
            // 
            lblWorkHours.AutoSize = true;
            lblWorkHours.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblWorkHours.Location = new Point(8, 92);
            lblWorkHours.Name = "lblWorkHours";
            lblWorkHours.Size = new Size(140, 20);
            lblWorkHours.TabIndex = 64;
            lblWorkHours.Text = "Ocupación Horas";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(35, 39, 42);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(102, 68);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(305, 27);
            txtTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblTitle.Location = new Point(102, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Titulo";
            // 
            // chkMedicalCertificate
            // 
            chkMedicalCertificate.AutoSize = true;
            chkMedicalCertificate.Font = new Font("Microsoft Sans Serif", 9F);
            chkMedicalCertificate.Location = new Point(297, 103);
            chkMedicalCertificate.Name = "chkMedicalCertificate";
            chkMedicalCertificate.Size = new Size(154, 22);
            chkMedicalCertificate.TabIndex = 70;
            chkMedicalCertificate.Text = "Certificado Medico";
            chkMedicalCertificate.UseVisualStyleBackColor = true;
            // 
            // txtWorkHours
            // 
            txtWorkHours.BackColor = Color.FromArgb(35, 39, 42);
            txtWorkHours.ForeColor = Color.White;
            txtWorkHours.Location = new Point(8, 115);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(265, 27);
            txtWorkHours.TabIndex = 2;
            // 
            // chkCooperative
            // 
            chkCooperative.AutoSize = true;
            chkCooperative.Font = new Font("Microsoft Sans Serif", 9F);
            chkCooperative.Location = new Point(297, 194);
            chkCooperative.Name = "chkCooperative";
            chkCooperative.Size = new Size(110, 22);
            chkCooperative.TabIndex = 67;
            chkCooperative.Text = "Cooperativa";
            chkCooperative.UseVisualStyleBackColor = true;
            // 
            // lblHealthcare
            // 
            lblHealthcare.AutoSize = true;
            lblHealthcare.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblHealthcare.Location = new Point(8, 156);
            lblHealthcare.Name = "lblHealthcare";
            lblHealthcare.Size = new Size(97, 20);
            lblHealthcare.TabIndex = 64;
            lblHealthcare.Text = "Obra Social";
            // 
            // chkCUIL
            // 
            chkCUIL.AutoSize = true;
            chkCUIL.Font = new Font("Microsoft Sans Serif", 9F);
            chkCUIL.Location = new Point(297, 163);
            chkCUIL.Name = "chkCUIL";
            chkCUIL.Size = new Size(63, 22);
            chkCUIL.TabIndex = 67;
            chkCUIL.Text = "CUIL";
            chkCUIL.UseVisualStyleBackColor = true;
            // 
            // txtOcupation
            // 
            txtOcupation.BackColor = Color.FromArgb(35, 39, 42);
            txtOcupation.ForeColor = Color.White;
            txtOcupation.Location = new Point(8, 47);
            txtOcupation.Name = "txtOcupation";
            txtOcupation.Size = new Size(265, 27);
            txtOcupation.TabIndex = 1;
            // 
            // chkPhoto
            // 
            chkPhoto.AutoSize = true;
            chkPhoto.Font = new Font("Microsoft Sans Serif", 9F);
            chkPhoto.Location = new Point(297, 133);
            chkPhoto.Name = "chkPhoto";
            chkPhoto.Size = new Size(69, 22);
            chkPhoto.TabIndex = 69;
            chkPhoto.Text = "Fotos";
            chkPhoto.UseVisualStyleBackColor = true;
            // 
            // txtHealthcare
            // 
            txtHealthcare.BackColor = Color.FromArgb(35, 39, 42);
            txtHealthcare.ForeColor = Color.White;
            txtHealthcare.Location = new Point(8, 179);
            txtHealthcare.Name = "txtHealthcare";
            txtHealthcare.Size = new Size(265, 27);
            txtHealthcare.TabIndex = 3;
            // 
            // chkBirthCertificate
            // 
            chkBirthCertificate.AutoSize = true;
            chkBirthCertificate.Font = new Font("Microsoft Sans Serif", 9F);
            chkBirthCertificate.Location = new Point(297, 74);
            chkBirthCertificate.Name = "chkBirthCertificate";
            chkBirthCertificate.Size = new Size(197, 22);
            chkBirthCertificate.TabIndex = 68;
            chkBirthCertificate.Text = "Certificado de nacimiento";
            chkBirthCertificate.UseVisualStyleBackColor = true;
            // 
            // chkAnalitic
            // 
            chkAnalitic.AutoSize = true;
            chkAnalitic.Font = new Font("Microsoft Sans Serif", 9F);
            chkAnalitic.Location = new Point(297, 15);
            chkAnalitic.Name = "chkAnalitic";
            chkAnalitic.Size = new Size(164, 22);
            chkAnalitic.TabIndex = 66;
            chkAnalitic.Text = "Analitico Secundario";
            chkAnalitic.UseVisualStyleBackColor = true;
            // 
            // chkDNI
            // 
            chkDNI.AutoSize = true;
            chkDNI.Font = new Font("Microsoft Sans Serif", 9F);
            chkDNI.Location = new Point(297, 43);
            chkDNI.Name = "chkDNI";
            chkDNI.Size = new Size(55, 22);
            chkDNI.TabIndex = 67;
            chkDNI.Text = "DNI";
            chkDNI.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(13, 20);
            label9.Margin = new Padding(3, 13, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(157, 20);
            label9.TabIndex = 22;
            label9.Text = "Correo electrónico :";
            // 
            // txtUserEmail
            // 
            txtUserEmail.BackColor = Color.FromArgb(35, 39, 42);
            txtUserEmail.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtUserEmail.ForeColor = Color.White;
            txtUserEmail.Location = new Point(13, 43);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(305, 29);
            txtUserEmail.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(panelLogin);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(886, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 408);
            panel1.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.Location = new Point(67, 9);
            label10.Name = "label10";
            label10.Size = new Size(121, 18);
            label10.TabIndex = 76;
            label10.Text = "Datos de logueo:";
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(btnSeePasswords);
            panelLogin.Controls.Add(label9);
            panelLogin.Controls.Add(txtPasswordConfirm);
            panelLogin.Controls.Add(txtUserEmail);
            panelLogin.Controls.Add(label7);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Location = new Point(17, 171);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(362, 229);
            panelLogin.TabIndex = 29;
            // 
            // btnSeePasswords
            // 
            btnSeePasswords.FlatStyle = FlatStyle.Popup;
            btnSeePasswords.ForeColor = Color.FromArgb(54, 57, 63);
            btnSeePasswords.Image = (Image)resources.GetObject("btnSeePasswords.Image");
            btnSeePasswords.Location = new Point(288, 143);
            btnSeePasswords.Name = "btnSeePasswords";
            btnSeePasswords.Size = new Size(30, 30);
            btnSeePasswords.TabIndex = 29;
            btnSeePasswords.UseVisualStyleBackColor = true;
            btnSeePasswords.Click += btnSeePasswords_Click;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.BackColor = Color.FromArgb(35, 39, 42);
            txtPasswordConfirm.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtPasswordConfirm.ForeColor = Color.White;
            txtPasswordConfirm.Location = new Point(13, 179);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.Size = new Size(305, 29);
            txtPasswordConfirm.TabIndex = 8;
            txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 156);
            label7.Margin = new Padding(3, 13, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 28;
            label7.Text = "Repetir Contraseña :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 88);
            label5.Margin = new Padding(3, 13, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 26;
            label5.Text = "Contraseña :";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(35, 39, 42);
            txtPassword.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(13, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(305, 29);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(67, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 24;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 121);
            label2.TabIndex = 23;
            label2.Text = "Login Information";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnInfo);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(panelDisplay);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 408);
            panel3.TabIndex = 71;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.White;
            btnInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInfo.ForeColor = Color.Black;
            btnInfo.Location = new Point(307, 125);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(30, 29);
            btnInfo.TabIndex = 78;
            btnInfo.Text = "?";
            toolTip.SetToolTip(btnInfo, "Ingrese los datos correspondientes del rol para el Usuario.\r\n\r\nLa contraseña debe como minimo 8 caracters.\r\n\r\nSi previamente se dio de baja al rol de un usuario, se puede\r\nreactivar.\r\n\r\n");
            btnInfo.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(labelHidden);
            panel5.Controls.Add(btnReactivate);
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(lblResult);
            panel5.Location = new Point(11, 171);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 229);
            panel5.TabIndex = 77;
            // 
            // labelHidden
            // 
            labelHidden.AutoSize = true;
            labelHidden.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            labelHidden.Location = new Point(8, 15);
            labelHidden.Name = "labelHidden";
            labelHidden.Size = new Size(295, 20);
            labelHidden.TabIndex = 78;
            labelHidden.Text = "Rol fue previamente desactivado: ";
            labelHidden.Visible = false;
            // 
            // btnReactivate
            // 
            btnReactivate.BackColor = Color.Crimson;
            btnReactivate.FlatStyle = FlatStyle.Flat;
            btnReactivate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReactivate.Location = new Point(26, 64);
            btnReactivate.Name = "btnReactivate";
            btnReactivate.Size = new Size(277, 71);
            btnReactivate.TabIndex = 77;
            btnReactivate.Text = "Reactivar";
            btnReactivate.UseVisualStyleBackColor = false;
            btnReactivate.Visible = false;
            btnReactivate.Click += btnReactivate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 150, 136);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(171, 87);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 71);
            btnDelete.TabIndex = 76;
            btnDelete.Text = "Baja";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(35, 87);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 71);
            btnSave.TabIndex = 9;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Crimson;
            lblResult.Dock = DockStyle.Bottom;
            lblResult.Font = new Font("Segoe UI", 18F);
            lblResult.Location = new Point(0, 186);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(323, 41);
            lblResult.TabIndex = 73;
            lblResult.Text = "Success Text";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(47, 9);
            label8.Name = "label8";
            label8.Size = new Size(139, 18);
            label8.TabIndex = 75;
            label8.Text = "Nombre de usuario:";
            // 
            // panelDisplay
            // 
            panelDisplay.BorderStyle = BorderStyle.Fixed3D;
            panelDisplay.Controls.Add(lblUserName);
            panelDisplay.Location = new Point(48, 29);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(250, 125);
            panelDisplay.TabIndex = 74;
            // 
            // lblUserName
            // 
            lblUserName.Dock = DockStyle.Fill;
            lblUserName.Font = new Font("Microsoft Sans Serif", 12F);
            lblUserName.Location = new Point(0, 0);
            lblUserName.MaximumSize = new Size(250, 125);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(246, 121);
            lblUserName.TabIndex = 72;
            lblUserName.Text = "UserName";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 0;
            toolTip.AutoPopDelay = 0;
            toolTip.InitialDelay = 0;
            toolTip.IsBalloon = true;
            toolTip.ReshowDelay = 0;
            // 
            // formUserRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1286, 408);
            Controls.Add(panel1);
            Controls.Add(MainPanel);
            Controls.Add(panel3);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formUserRole";
            Text = "Gestin - Tipo de Usuario";
            FormClosing += formUserType_FormClosing;
            Load += formUserRole_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            panelMain.ResumeLayout(false);
            RolePanel.ResumeLayout(false);
            RolePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelDisplay.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private CheckBox chkMedicalCertificate;
        private CheckBox chkCooperative;
        private CheckBox chkCUIL;
        private CheckBox chkPhoto;
        private CheckBox chkBirthCertificate;
        private CheckBox chkDNI;
        private CheckBox chkAnalitic;
        private TextBox txtHealthcare;
        private TextBox txtOcupation;
        private Label lblHealthcare;
        private TextBox txtWorkHours;
        private Label lblOcupation;
        private Label lblWorkHours;
        private Label label9;
        private TextBox txtUserEmail;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Label lblUserName;
        private Button btnSave;
        private Panel RolePanel;
        private Label lblResult;
        private Panel panelDisplay;
        private Panel panel4;
        private Panel panelMain;
        private Label lblUserRole;
        private TextBox txtPasswordConfirm;
        private Label label7;
        private TextBox txtPassword;
        private Label label5;
        private System.Windows.Forms.Timer lableTimer;
        private Panel panelLogin;
        private Label label6;
        private Label label10;
        private Label label8;
        private TextBox txtCuil;
        private Label lblCuil;
        private TextBox txtTitle;
        private Label lblTitle;
        private Button btnDelete;
        private Panel panel5;
        private CheckBox chkStatus;
        private Button btnInfo;
        private ToolTip toolTip;
        private Button btnReactivate;
        private Label labelHidden;
        private Button btnSeePasswords;
    }
}