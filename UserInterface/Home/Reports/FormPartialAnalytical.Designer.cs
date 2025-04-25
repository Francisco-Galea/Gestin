namespace Gestin.UI.Home.Students
{
    partial class FormPartialAnalytical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartialAnalytical));
            txtCantOfApprovedSubjects = new TextBox();
            lblAccreditedSubjects = new Label();
            txtResolution = new TextBox();
            lblResolution = new Label();
            label1 = new Label();
            ptbLogo = new PictureBox();
            modifyLogo = new Button();
            btnSave = new Button();
            cbbSpecialty = new ComboBox();
            txtNumberInsti = new TextBox();
            txtCity = new TextBox();
            txtDni = new TextBox();
            txtStudent = new TextBox();
            lblSpecialty = new Label();
            lblNumberInsti = new Label();
            lblCity = new Label();
            dniStudent = new Label();
            lblStudent = new Label();
            lblLogo = new Label();
            pnlTopBar = new Panel();
            label2 = new Label();
            btnSalir = new PictureBox();
            ptbSalir = new PictureBox();
            btnClose = new PictureBox();
            cbbCourse = new ComboBox();
            txtPercentageOfSubjects = new TextBox();
            lblPercentageOfSubjects = new Label();
            lblCourse = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // txtCantOfApprovedSubjects
            // 
            txtCantOfApprovedSubjects.BackColor = Color.FromArgb(44, 47, 51);
            txtCantOfApprovedSubjects.BorderStyle = BorderStyle.FixedSingle;
            txtCantOfApprovedSubjects.Font = new Font("Segoe UI", 12F);
            txtCantOfApprovedSubjects.ForeColor = Color.White;
            txtCantOfApprovedSubjects.Location = new Point(989, 422);
            txtCantOfApprovedSubjects.Name = "txtCantOfApprovedSubjects";
            txtCantOfApprovedSubjects.ReadOnly = true;
            txtCantOfApprovedSubjects.Size = new Size(82, 34);
            txtCantOfApprovedSubjects.TabIndex = 93;
            // 
            // lblAccreditedSubjects
            // 
            lblAccreditedSubjects.AutoSize = true;
            lblAccreditedSubjects.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccreditedSubjects.ForeColor = Color.White;
            lblAccreditedSubjects.Location = new Point(648, 422);
            lblAccreditedSubjects.Name = "lblAccreditedSubjects";
            lblAccreditedSubjects.Size = new Size(333, 28);
            lblAccreditedSubjects.TabIndex = 92;
            lblAccreditedSubjects.Text = "Cantidad de materias acreditadas:";
            // 
            // txtResolution
            // 
            txtResolution.BackColor = Color.FromArgb(44, 47, 51);
            txtResolution.BorderStyle = BorderStyle.FixedSingle;
            txtResolution.Font = new Font("Segoe UI", 12F);
            txtResolution.ForeColor = Color.White;
            txtResolution.Location = new Point(441, 416);
            txtResolution.Multiline = true;
            txtResolution.Name = "txtResolution";
            txtResolution.Size = new Size(193, 36);
            txtResolution.TabIndex = 91;
            // 
            // lblResolution
            // 
            lblResolution.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResolution.AutoSize = true;
            lblResolution.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResolution.ForeColor = Color.White;
            lblResolution.Location = new Point(315, 418);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(120, 28);
            lblResolution.TabIndex = 90;
            lblResolution.Text = "Resolución:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(571, 124);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 89;
            label1.Text = "El logo tiene que tener 480x180";
            // 
            // ptbLogo
            // 
            ptbLogo.BorderStyle = BorderStyle.FixedSingle;
            ptbLogo.Location = new Point(536, 147);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(285, 112);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 88;
            ptbLogo.TabStop = false;
            // 
            // modifyLogo
            // 
            modifyLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            modifyLogo.BackColor = Color.FromArgb(0, 150, 136);
            modifyLogo.FlatStyle = FlatStyle.Flat;
            modifyLogo.Font = new Font("Segoe UI", 10.2F);
            modifyLogo.ForeColor = Color.WhiteSmoke;
            modifyLogo.Location = new Point(873, 181);
            modifyLogo.Name = "modifyLogo";
            modifyLogo.Size = new Size(176, 39);
            modifyLogo.TabIndex = 87;
            modifyLogo.Text = "Modificar imagen";
            modifyLogo.UseVisualStyleBackColor = false;
            modifyLogo.Click += modifyLogo_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(436, 577);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(198, 41);
            btnSave.TabIndex = 86;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbbSpecialty
            // 
            cbbSpecialty.BackColor = Color.FromArgb(44, 47, 51);
            cbbSpecialty.FlatStyle = FlatStyle.Flat;
            cbbSpecialty.Font = new Font("Segoe UI", 12F);
            cbbSpecialty.ForeColor = Color.White;
            cbbSpecialty.FormattingEnabled = true;
            cbbSpecialty.Location = new Point(174, 76);
            cbbSpecialty.Name = "cbbSpecialty";
            cbbSpecialty.Size = new Size(876, 36);
            cbbSpecialty.TabIndex = 85;
            cbbSpecialty.SelectedIndexChanged += cbbSpecialty_SelectedIndexChanged;
            // 
            // txtNumberInsti
            // 
            txtNumberInsti.BackColor = Color.FromArgb(44, 47, 51);
            txtNumberInsti.BorderStyle = BorderStyle.FixedSingle;
            txtNumberInsti.Font = new Font("Segoe UI", 12F);
            txtNumberInsti.ForeColor = Color.White;
            txtNumberInsti.Location = new Point(989, 303);
            txtNumberInsti.Name = "txtNumberInsti";
            txtNumberInsti.Size = new Size(82, 34);
            txtNumberInsti.TabIndex = 84;
            txtNumberInsti.Text = "194";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(44, 47, 51);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 12F);
            txtCity.ForeColor = Color.White;
            txtCity.Location = new Point(111, 416);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 34);
            txtCity.TabIndex = 83;
            txtCity.Text = "Miramar";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(44, 47, 51);
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI", 12F);
            txtDni.ForeColor = Color.White;
            txtDni.Location = new Point(580, 303);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(235, 36);
            txtDni.TabIndex = 82;
            // 
            // txtStudent
            // 
            txtStudent.BackColor = Color.FromArgb(44, 47, 51);
            txtStudent.BorderStyle = BorderStyle.FixedSingle;
            txtStudent.Font = new Font("Segoe UI", 12F);
            txtStudent.ForeColor = Color.White;
            txtStudent.Location = new Point(146, 303);
            txtStudent.Multiline = true;
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(341, 36);
            txtStudent.TabIndex = 81;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSpecialty.ForeColor = Color.White;
            lblSpecialty.Location = new Point(23, 79);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(134, 28);
            lblSpecialty.TabIndex = 80;
            lblSpecialty.Text = "Especialidad:";
            // 
            // lblNumberInsti
            // 
            lblNumberInsti.AutoSize = true;
            lblNumberInsti.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumberInsti.ForeColor = Color.White;
            lblNumberInsti.Location = new Point(841, 305);
            lblNumberInsti.Name = "lblNumberInsti";
            lblNumberInsti.Size = new Size(140, 28);
            lblNumberInsti.TabIndex = 79;
            lblNumberInsti.Text = "Nro Instituto:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCity.ForeColor = Color.White;
            lblCity.Location = new Point(23, 418);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(82, 28);
            lblCity.TabIndex = 78;
            lblCity.Text = "Ciudad:";
            // 
            // dniStudent
            // 
            dniStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dniStudent.AutoSize = true;
            dniStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dniStudent.ForeColor = Color.White;
            dniStudent.Location = new Point(524, 305);
            dniStudent.Name = "dniStudent";
            dniStudent.Size = new Size(50, 28);
            dniStudent.TabIndex = 77;
            dniStudent.Text = "Dni:";
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStudent.ForeColor = Color.White;
            lblStudent.Location = new Point(23, 305);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(117, 28);
            lblStudent.TabIndex = 76;
            lblStudent.Text = "Estudiante:";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(23, 184);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(467, 28);
            lblLogo.TabIndex = 75;
            lblLogo.Text = "Logo Dirección General de Cultura y Educación: ";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(114, 137, 218);
            pnlTopBar.Controls.Add(label2);
            pnlTopBar.Controls.Add(btnSalir);
            pnlTopBar.Controls.Add(ptbSalir);
            pnlTopBar.Controls.Add(btnClose);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Margin = new Padding(3, 4, 3, 4);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1107, 39);
            pnlTopBar.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(453, 4);
            label2.Name = "label2";
            label2.Size = new Size(203, 28);
            label2.TabIndex = 94;
            label2.Text = "ANALITICO PARCIAL";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(1072, 4);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(23, 27);
            btnSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSalir.TabIndex = 5;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // ptbSalir
            // 
            ptbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ptbSalir.Cursor = Cursors.Hand;
            ptbSalir.Image = (Image)resources.GetObject("ptbSalir.Image");
            ptbSalir.Location = new Point(1980, 8);
            ptbSalir.Margin = new Padding(3, 4, 3, 4);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(23, 0);
            ptbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbSalir.TabIndex = 4;
            ptbSalir.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(2478, -58);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 27);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            // 
            // cbbCourse
            // 
            cbbCourse.BackColor = Color.FromArgb(44, 47, 51);
            cbbCourse.FlatStyle = FlatStyle.Flat;
            cbbCourse.Font = new Font("Segoe UI", 12F);
            cbbCourse.ForeColor = Color.White;
            cbbCourse.FormattingEnabled = true;
            cbbCourse.Items.AddRange(new object[] { "1ero", "2do", "3ro" });
            cbbCourse.Location = new Point(730, 495);
            cbbCourse.Name = "cbbCourse";
            cbbCourse.Size = new Size(99, 36);
            cbbCourse.TabIndex = 97;
            // 
            // txtPercentageOfSubjects
            // 
            txtPercentageOfSubjects.BackColor = Color.FromArgb(44, 47, 51);
            txtPercentageOfSubjects.BorderStyle = BorderStyle.FixedSingle;
            txtPercentageOfSubjects.Font = new Font("Segoe UI", 12F);
            txtPercentageOfSubjects.ForeColor = Color.White;
            txtPercentageOfSubjects.Location = new Point(441, 496);
            txtPercentageOfSubjects.Name = "txtPercentageOfSubjects";
            txtPercentageOfSubjects.ReadOnly = true;
            txtPercentageOfSubjects.Size = new Size(82, 34);
            txtPercentageOfSubjects.TabIndex = 96;
            // 
            // lblPercentageOfSubjects
            // 
            lblPercentageOfSubjects.AutoSize = true;
            lblPercentageOfSubjects.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPercentageOfSubjects.ForeColor = Color.White;
            lblPercentageOfSubjects.Location = new Point(201, 499);
            lblPercentageOfSubjects.Name = "lblPercentageOfSubjects";
            lblPercentageOfSubjects.Size = new Size(234, 28);
            lblPercentageOfSubjects.TabIndex = 95;
            lblPercentageOfSubjects.Text = "Porcentaje de materias:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCourse.ForeColor = Color.White;
            lblCourse.Location = new Point(648, 495);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(76, 28);
            lblCourse.TabIndex = 94;
            lblCourse.Text = "Curso: ";
            // 
            // FormPartialAnalytical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 45, 48);
            ClientSize = new Size(1107, 643);
            Controls.Add(cbbCourse);
            Controls.Add(txtPercentageOfSubjects);
            Controls.Add(lblPercentageOfSubjects);
            Controls.Add(lblCourse);
            Controls.Add(txtCantOfApprovedSubjects);
            Controls.Add(lblAccreditedSubjects);
            Controls.Add(txtResolution);
            Controls.Add(lblResolution);
            Controls.Add(label1);
            Controls.Add(ptbLogo);
            Controls.Add(modifyLogo);
            Controls.Add(btnSave);
            Controls.Add(cbbSpecialty);
            Controls.Add(txtNumberInsti);
            Controls.Add(txtCity);
            Controls.Add(txtDni);
            Controls.Add(txtStudent);
            Controls.Add(lblSpecialty);
            Controls.Add(lblNumberInsti);
            Controls.Add(lblCity);
            Controls.Add(dniStudent);
            Controls.Add(lblStudent);
            Controls.Add(lblLogo);
            Controls.Add(pnlTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPartialAnalytical";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPartialAnalytical";
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantOfApprovedSubjects;
        private Label lblAccreditedSubjects;
        private TextBox txtResolution;
        private Label lblResolution;
        private Label label1;
        private PictureBox ptbLogo;
        private Button modifyLogo;
        private Button btnSave;
        private ComboBox cbbSpecialty;
        private TextBox txtNumberInsti;
        private TextBox txtCity;
        private TextBox txtDni;
        private TextBox txtStudent;
        private Label lblSpecialty;
        private Label lblNumberInsti;
        private Label lblCity;
        private Label dniStudent;
        private Label lblStudent;
        private Label lblLogo;
        private Panel pnlTopBar;
        private PictureBox ptbSalir;
        private PictureBox btnClose;
        private PictureBox btnSalir;
        private Label label2;
        private ComboBox cbbCourse;
        private TextBox txtPercentageOfSubjects;
        private Label lblPercentageOfSubjects;
        private Label lblCourse;
    }
}