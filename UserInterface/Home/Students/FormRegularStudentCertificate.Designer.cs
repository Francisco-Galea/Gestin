namespace Gestin.UI.Home.Students
{
    partial class formRegularStudentCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegularStudentCertificate));
            pnlTopBar = new Panel();
            ptbSalir = new PictureBox();
            btnClose = new PictureBox();
            lblLogo = new Label();
            lblStudent = new Label();
            dniStudent = new Label();
            lblCourse = new Label();
            lblCity = new Label();
            lblNumberInsti = new Label();
            lblSpecialty = new Label();
            txtStudent = new TextBox();
            txtDni = new TextBox();
            txtCity = new TextBox();
            txtNumberInsti = new TextBox();
            cbbCourse = new ComboBox();
            cbbSpecialty = new ComboBox();
            btnSave = new Button();
            modifyLogo = new Button();
            ptbLogo = new PictureBox();
            label1 = new Label();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(114, 137, 218);
            pnlTopBar.Controls.Add(ptbSalir);
            pnlTopBar.Controls.Add(btnClose);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Margin = new Padding(3, 4, 3, 4);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1060, 39);
            pnlTopBar.TabIndex = 52;
            // 
            // ptbSalir
            // 
            ptbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ptbSalir.Cursor = Cursors.Hand;
            ptbSalir.Image = (Image)resources.GetObject("ptbSalir.Image");
            ptbSalir.Location = new Point(1030, 8);
            ptbSalir.Margin = new Padding(3, 4, 3, 4);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(23, 27);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 4;
            ptbSalir.TabStop = false;
            ptbSalir.Click += ptbSalir_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1528, -27);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 27);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(27, 178);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(467, 28);
            lblLogo.TabIndex = 53;
            lblLogo.Text = "Logo Dirección General de Cultura y Educación: ";
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudent.ForeColor = Color.White;
            lblStudent.Location = new Point(101, 299);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(117, 28);
            lblStudent.TabIndex = 54;
            lblStudent.Text = "Estudiante:";
            // 
            // dniStudent
            // 
            dniStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dniStudent.AutoSize = true;
            dniStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dniStudent.ForeColor = Color.White;
            dniStudent.Location = new Point(623, 299);
            dniStudent.Name = "dniStudent";
            dniStudent.Size = new Size(50, 28);
            dniStudent.TabIndex = 55;
            dniStudent.Text = "Dni:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCourse.ForeColor = Color.White;
            lblCourse.Location = new Point(713, 391);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(76, 28);
            lblCourse.TabIndex = 56;
            lblCourse.Text = "Curso: ";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCity.ForeColor = Color.White;
            lblCity.Location = new Point(101, 391);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(82, 28);
            lblCity.TabIndex = 57;
            lblCity.Text = "Ciudad:";
            // 
            // lblNumberInsti
            // 
            lblNumberInsti.AutoSize = true;
            lblNumberInsti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumberInsti.ForeColor = Color.White;
            lblNumberInsti.Location = new Point(404, 390);
            lblNumberInsti.Name = "lblNumberInsti";
            lblNumberInsti.Size = new Size(140, 28);
            lblNumberInsti.TabIndex = 58;
            lblNumberInsti.Text = "Nro Instituto:";
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpecialty.ForeColor = Color.White;
            lblSpecialty.Location = new Point(12, 74);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(134, 28);
            lblSpecialty.TabIndex = 59;
            lblSpecialty.Text = "Especialidad:";
            // 
            // txtStudent
            // 
            txtStudent.BackColor = Color.FromArgb(44, 47, 51);
            txtStudent.BorderStyle = BorderStyle.FixedSingle;
            txtStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudent.ForeColor = Color.White;
            txtStudent.Location = new Point(224, 297);
            txtStudent.Multiline = true;
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(341, 36);
            txtStudent.TabIndex = 60;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(44, 47, 51);
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.White;
            txtDni.Location = new Point(691, 297);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(235, 36);
            txtDni.TabIndex = 61;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(44, 47, 51);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(189, 387);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 34);
            txtCity.TabIndex = 62;
            txtCity.Text = "Miramar";
            // 
            // txtNumberInsti
            // 
            txtNumberInsti.BackColor = Color.FromArgb(44, 47, 51);
            txtNumberInsti.BorderStyle = BorderStyle.FixedSingle;
            txtNumberInsti.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumberInsti.ForeColor = Color.White;
            txtNumberInsti.Location = new Point(560, 388);
            txtNumberInsti.Name = "txtNumberInsti";
            txtNumberInsti.Size = new Size(82, 34);
            txtNumberInsti.TabIndex = 63;
            txtNumberInsti.Text = "194";
            // 
            // cbbCourse
            // 
            cbbCourse.BackColor = Color.FromArgb(44, 47, 51);
            cbbCourse.FlatStyle = FlatStyle.Flat;
            cbbCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCourse.ForeColor = Color.White;
            cbbCourse.FormattingEnabled = true;
            cbbCourse.Items.AddRange(new object[] { "1ero", "2do", "3ro" });
            cbbCourse.Location = new Point(827, 388);
            cbbCourse.Name = "cbbCourse";
            cbbCourse.Size = new Size(99, 36);
            cbbCourse.TabIndex = 64;
            // 
            // cbbSpecialty
            // 
            cbbSpecialty.BackColor = Color.FromArgb(44, 47, 51);
            cbbSpecialty.FlatStyle = FlatStyle.Flat;
            cbbSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSpecialty.ForeColor = Color.White;
            cbbSpecialty.FormattingEnabled = true;
            cbbSpecialty.Location = new Point(163, 71);
            cbbSpecialty.Name = "cbbSpecialty";
            cbbSpecialty.Size = new Size(876, 36);
            cbbSpecialty.TabIndex = 65;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(444, 476);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(198, 41);
            btnSave.TabIndex = 66;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // modifyLogo
            // 
            modifyLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            modifyLogo.BackColor = Color.FromArgb(0, 150, 136);
            modifyLogo.FlatStyle = FlatStyle.Flat;
            modifyLogo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            modifyLogo.ForeColor = Color.WhiteSmoke;
            modifyLogo.Location = new Point(841, 175);
            modifyLogo.Name = "modifyLogo";
            modifyLogo.Size = new Size(176, 39);
            modifyLogo.TabIndex = 67;
            modifyLogo.Text = "Modificar imagen";
            modifyLogo.UseVisualStyleBackColor = false;
            modifyLogo.Click += modifyLogo_Click_1;
            // 
            // ptbLogo
            // 
            ptbLogo.BorderStyle = BorderStyle.FixedSingle;
            ptbLogo.Location = new Point(525, 141);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(285, 112);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 68;
            ptbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(560, 118);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 69;
            label1.Text = "El logo tiene que tener 480x180";
            // 
            // FormRegularStudentCertificate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 45, 48);
            ClientSize = new Size(1060, 553);
            Controls.Add(label1);
            Controls.Add(ptbLogo);
            Controls.Add(modifyLogo);
            Controls.Add(btnSave);
            Controls.Add(cbbSpecialty);
            Controls.Add(cbbCourse);
            Controls.Add(txtNumberInsti);
            Controls.Add(txtCity);
            Controls.Add(txtDni);
            Controls.Add(txtStudent);
            Controls.Add(lblSpecialty);
            Controls.Add(lblNumberInsti);
            Controls.Add(lblCity);
            Controls.Add(lblCourse);
            Controls.Add(dniStudent);
            Controls.Add(lblStudent);
            Controls.Add(lblLogo);
            Controls.Add(pnlTopBar);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegularStudentCertificate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegularStudentCertifiicate";
            pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTopBar;
        private PictureBox btnClose;
        private PictureBox ptbSalir;
        private Label lblLogo;
        private Label lblStudent;
        private Label dniStudent;
        private Label lblCourse;
        private Label lblCity;
        private Label lblNumberInsti;
        private Label lblSpecialty;
        private TextBox txtStudent;
        private TextBox txtDni;
        private TextBox txtCity;
        private TextBox txtNumberInsti;
        private ComboBox cbbCourse;
        private ComboBox cbbSpecialty;
        private Button btnSave;
        private Button modifyLogo;
        private PictureBox ptbLogo;
        private Label label1;
    }
}