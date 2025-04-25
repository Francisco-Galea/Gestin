namespace Gestin.UserInterface.Home.Assistance
{
    partial class formAssistanceTemplate
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
            lblYearInCourse = new Label();
            lblCareerName = new Label();
            lblEnrolmentYears = new Label();
            cbbSubjectEnrolmentYear = new ComboBox();
            cbbTeacherSubject = new ComboBox();
            lblTeacherSubject = new Label();
            lblInstitute = new Label();
            txtInstitute = new TextBox();
            btnSave = new Button();
            txtCourseYear = new TextBox();
            label7 = new Label();
            lblPresential = new Label();
            label3 = new Label();
            lblSelfStudy = new Label();
            label5 = new Label();
            lblTotal = new Label();
            label1 = new Label();
            pictureBoxLogo = new PictureBox();
            btnModifyImage = new Button();
            cbbSubjectCareer = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblYearInCourse
            // 
            lblYearInCourse.AutoSize = true;
            lblYearInCourse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblYearInCourse.ForeColor = Color.White;
            lblYearInCourse.Location = new Point(257, 204);
            lblYearInCourse.Name = "lblYearInCourse";
            lblYearInCourse.Size = new Size(53, 20);
            lblYearInCourse.TabIndex = 0;
            lblYearInCourse.Text = "Curso:";
            // 
            // lblCareerName
            // 
            lblCareerName.AutoSize = true;
            lblCareerName.Font = new Font("Segoe UI", 12F);
            lblCareerName.ForeColor = Color.FromArgb(255, 152, 0);
            lblCareerName.Location = new Point(35, 9);
            lblCareerName.Name = "lblCareerName";
            lblCareerName.Size = new Size(120, 28);
            lblCareerName.TabIndex = 5;
            lblCareerName.Text = "CareerName";
            // 
            // lblEnrolmentYears
            // 
            lblEnrolmentYears.AutoSize = true;
            lblEnrolmentYears.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEnrolmentYears.ForeColor = Color.White;
            lblEnrolmentYears.Location = new Point(257, 320);
            lblEnrolmentYears.Name = "lblEnrolmentYears";
            lblEnrolmentYears.Size = new Size(46, 20);
            lblEnrolmentYears.TabIndex = 4;
            lblEnrolmentYears.Text = "Ciclo:";
            // 
            // cbbSubjectEnrolmentYear
            // 
            cbbSubjectEnrolmentYear.BackColor = Color.FromArgb(44, 47, 51);
            cbbSubjectEnrolmentYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSubjectEnrolmentYear.FlatStyle = FlatStyle.Flat;
            cbbSubjectEnrolmentYear.ForeColor = Color.White;
            cbbSubjectEnrolmentYear.FormattingEnabled = true;
            cbbSubjectEnrolmentYear.Location = new Point(390, 318);
            cbbSubjectEnrolmentYear.Name = "cbbSubjectEnrolmentYear";
            cbbSubjectEnrolmentYear.Size = new Size(234, 26);
            cbbSubjectEnrolmentYear.TabIndex = 6;
            cbbSubjectEnrolmentYear.SelectedIndexChanged += cbbSubjectEnrolmentYear_SelectedIndexChanged;
            // 
            // cbbTeacherSubject
            // 
            cbbTeacherSubject.BackColor = Color.FromArgb(44, 47, 51);
            cbbTeacherSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTeacherSubject.FlatStyle = FlatStyle.Flat;
            cbbTeacherSubject.ForeColor = Color.White;
            cbbTeacherSubject.FormattingEnabled = true;
            cbbTeacherSubject.Location = new Point(390, 261);
            cbbTeacherSubject.Name = "cbbTeacherSubject";
            cbbTeacherSubject.Size = new Size(234, 26);
            cbbTeacherSubject.TabIndex = 8;
            // 
            // lblTeacherSubject
            // 
            lblTeacherSubject.AutoSize = true;
            lblTeacherSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTeacherSubject.ForeColor = Color.White;
            lblTeacherSubject.Location = new Point(257, 264);
            lblTeacherSubject.Name = "lblTeacherSubject";
            lblTeacherSubject.Size = new Size(71, 20);
            lblTeacherSubject.TabIndex = 7;
            lblTeacherSubject.Text = "Docente:";
            // 
            // lblInstitute
            // 
            lblInstitute.AutoSize = true;
            lblInstitute.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInstitute.ForeColor = Color.White;
            lblInstitute.Location = new Point(257, 146);
            lblInstitute.Name = "lblInstitute";
            lblInstitute.Size = new Size(74, 20);
            lblInstitute.TabIndex = 9;
            lblInstitute.Text = "Instituto:";
            // 
            // txtInstitute
            // 
            txtInstitute.BackColor = Color.FromArgb(44, 47, 51);
            txtInstitute.ForeColor = Color.White;
            txtInstitute.Location = new Point(390, 144);
            txtInstitute.Name = "txtInstitute";
            txtInstitute.Size = new Size(234, 24);
            txtInstitute.TabIndex = 10;
            txtInstitute.Text = "ISFT N° 194";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(390, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(234, 35);
            btnSave.TabIndex = 59;
            btnSave.Text = "Generar Documento";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtCourseYear
            // 
            txtCourseYear.BackColor = Color.FromArgb(44, 47, 51);
            txtCourseYear.ForeColor = Color.White;
            txtCourseYear.Location = new Point(390, 202);
            txtCourseYear.Name = "txtCourseYear";
            txtCourseYear.ReadOnly = true;
            txtCourseYear.Size = new Size(234, 24);
            txtCourseYear.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(708, 306);
            label7.Name = "label7";
            label7.Size = new Size(45, 18);
            label7.TabIndex = 61;
            label7.Text = "Total:";
            // 
            // lblPresential
            // 
            lblPresential.AutoSize = true;
            lblPresential.BorderStyle = BorderStyle.FixedSingle;
            lblPresential.ForeColor = Color.White;
            lblPresential.Location = new Point(772, 205);
            lblPresential.Name = "lblPresential";
            lblPresential.Size = new Size(50, 20);
            lblPresential.TabIndex = 62;
            lblPresential.Text = "--------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(672, 207);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 63;
            label3.Text = "Presencial:";
            // 
            // lblSelfStudy
            // 
            lblSelfStudy.AutoSize = true;
            lblSelfStudy.BorderStyle = BorderStyle.FixedSingle;
            lblSelfStudy.ForeColor = Color.White;
            lblSelfStudy.Location = new Point(772, 255);
            lblSelfStudy.Name = "lblSelfStudy";
            lblSelfStudy.Size = new Size(50, 20);
            lblSelfStudy.TabIndex = 64;
            lblSelfStudy.Text = "--------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(708, 255);
            label5.Name = "label5";
            label5.Size = new Size(44, 18);
            label5.TabIndex = 65;
            label5.Text = "Libre:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(772, 306);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 66;
            lblTotal.Text = "--------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(710, 144);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 67;
            label1.Text = "Estudiantes";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxLogo.Location = new Point(35, 147);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(180, 180);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 89;
            pictureBoxLogo.TabStop = false;
            // 
            // btnModifyImage
            // 
            btnModifyImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModifyImage.BackColor = Color.FromArgb(0, 150, 136);
            btnModifyImage.FlatStyle = FlatStyle.Flat;
            btnModifyImage.Font = new Font("Segoe UI", 10.2F);
            btnModifyImage.ForeColor = Color.WhiteSmoke;
            btnModifyImage.Location = new Point(124, 333);
            btnModifyImage.Name = "btnModifyImage";
            btnModifyImage.Size = new Size(91, 35);
            btnModifyImage.TabIndex = 90;
            btnModifyImage.Text = "Modificar";
            btnModifyImage.UseVisualStyleBackColor = false;
            btnModifyImage.Click += btnModifyImage_Click;
            // 
            // cbbSubjectCareer
            // 
            cbbSubjectCareer.BackColor = Color.FromArgb(44, 47, 51);
            cbbSubjectCareer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSubjectCareer.FlatStyle = FlatStyle.Flat;
            cbbSubjectCareer.ForeColor = Color.FromArgb(255, 152, 0);
            cbbSubjectCareer.FormattingEnabled = true;
            cbbSubjectCareer.Location = new Point(35, 76);
            cbbSubjectCareer.Name = "cbbSubjectCareer";
            cbbSubjectCareer.Size = new Size(796, 26);
            cbbSubjectCareer.TabIndex = 91;
            cbbSubjectCareer.SelectedIndexChanged += cbbSubjectCareer_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.FromArgb(255, 152, 0);
            label2.Location = new Point(35, 54);
            label2.Name = "label2";
            label2.Size = new Size(318, 19);
            label2.TabIndex = 92;
            label2.Text = "Seleccione materia a generar plantilla de asistencia:";
            // 
            // formAssistanceTemplate
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(928, 462);
            Controls.Add(label2);
            Controls.Add(cbbSubjectCareer);
            Controls.Add(btnModifyImage);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(lblSelfStudy);
            Controls.Add(label3);
            Controls.Add(lblPresential);
            Controls.Add(label7);
            Controls.Add(txtCourseYear);
            Controls.Add(btnSave);
            Controls.Add(txtInstitute);
            Controls.Add(lblInstitute);
            Controls.Add(cbbTeacherSubject);
            Controls.Add(lblTeacherSubject);
            Controls.Add(cbbSubjectEnrolmentYear);
            Controls.Add(lblCareerName);
            Controls.Add(lblEnrolmentYears);
            Controls.Add(lblYearInCourse);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "formAssistanceTemplate";
            Text = "Gestin - Plantilla de Asistencias";
            Load += formAssistanceTemplate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblYearInCourse;
        private Label lblCareerName;
        private Label lblEnrolmentYears;
        private ComboBox cbbSubjectEnrolmentYear;
        private ComboBox cbbTeacherSubject;
        private Label lblTeacherSubject;
        private Label lblInstitute;
        private TextBox txtInstitute;
        private Button btnSave;
        private TextBox txtCourseYear;
        private Label label7;
        private Label lblPresential;
        private Label label3;
        private Label lblSelfStudy;
        private Label label5;
        private Label lblTotal;
        private Label label1;
        private PictureBox pictureBoxLogo;
        private Button btnModifyImage;
        private ComboBox cbbSubjectCareer;
        private Label label2;
    }
}