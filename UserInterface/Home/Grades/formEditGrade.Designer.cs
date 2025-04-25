using Gestin.UI.Custom;

namespace Gestin.UI.Home.Grades
{
    partial class formEditGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditGrade));
            lblAcreditationType = new Label();
            cbbAccType = new ComboBox();
            txtEnrolmentYear = new TextBox();
            chkPresential = new BigCheckBox();
            lblPresential = new Label();
            label10 = new Label();
            label9 = new Label();
            txtBookRecord = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtGrade = new TextBox();
            label4 = new Label();
            label1 = new Label();
            lblStudent = new Label();
            lblSubject = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnClose = new PictureBox();
            btnSave = new Button();
            panel2 = new Panel();
            dtAccreditationDate = new DateTimePicker();
            lbCourseState = new Label();
            chkApproved = new BigCheckBox();
            label3 = new Label();
            lblError = new Label();
            pbDone = new PictureBox();
            btnDeleteGrade = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDone).BeginInit();
            SuspendLayout();
            // 
            // lblAcreditationType
            // 
            lblAcreditationType.AutoSize = true;
            lblAcreditationType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAcreditationType.ForeColor = Color.White;
            lblAcreditationType.Location = new Point(14, 424);
            lblAcreditationType.Margin = new Padding(11, 0, 0, 0);
            lblAcreditationType.Name = "lblAcreditationType";
            lblAcreditationType.Size = new Size(217, 28);
            lblAcreditationType.TabIndex = 45;
            lblAcreditationType.Text = "Tipo de acreditacion :";
            // 
            // cbbAccType
            // 
            cbbAccType.BackColor = Color.FromArgb(44, 47, 51);
            cbbAccType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbAccType.FlatStyle = FlatStyle.Flat;
            cbbAccType.Font = new Font("Segoe UI", 12F);
            cbbAccType.ForeColor = Color.White;
            cbbAccType.FormattingEnabled = true;
            cbbAccType.Items.AddRange(new object[] { "Presencial", "Libre", "Equivalencia", "Pase" });
            cbbAccType.Location = new Point(242, 421);
            cbbAccType.Margin = new Padding(11, 0, 0, 0);
            cbbAccType.Name = "cbbAccType";
            cbbAccType.Size = new Size(147, 36);
            cbbAccType.TabIndex = 36;
            // 
            // txtEnrolmentYear
            // 
            txtEnrolmentYear.BackColor = Color.FromArgb(44, 47, 51);
            txtEnrolmentYear.BorderStyle = BorderStyle.FixedSingle;
            txtEnrolmentYear.Font = new Font("Segoe UI", 12F);
            txtEnrolmentYear.ForeColor = Color.White;
            txtEnrolmentYear.Location = new Point(240, 171);
            txtEnrolmentYear.Margin = new Padding(3, 4, 3, 4);
            txtEnrolmentYear.Name = "txtEnrolmentYear";
            txtEnrolmentYear.Size = new Size(149, 34);
            txtEnrolmentYear.TabIndex = 30;
            // 
            // chkPresential
            // 
            chkPresential.Checked = true;
            chkPresential.CheckState = CheckState.Checked;
            chkPresential.Font = new Font("Segoe UI", 12F);
            chkPresential.ForeColor = Color.White;
            chkPresential.Location = new Point(634, 168);
            chkPresential.Margin = new Padding(3, 4, 3, 4);
            chkPresential.Name = "chkPresential";
            chkPresential.Size = new Size(31, 31);
            chkPresential.TabIndex = 31;
            chkPresential.Text = "Approved";
            chkPresential.TextAlign = ContentAlignment.MiddleRight;
            chkPresential.UseVisualStyleBackColor = true;
            // 
            // lblPresential
            // 
            lblPresential.AutoSize = true;
            lblPresential.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPresential.ForeColor = Color.White;
            lblPresential.Location = new Point(425, 173);
            lblPresential.Name = "lblPresential";
            lblPresential.Size = new Size(189, 28);
            lblPresential.TabIndex = 44;
            lblPresential.Text = "Cursada presencial";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(14, 173);
            label10.Name = "label10";
            label10.Size = new Size(220, 28);
            label10.TabIndex = 43;
            label10.Text = "Año de matriculación:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(5, 125);
            label9.Name = "label9";
            label9.Size = new Size(106, 32);
            label9.TabIndex = 42;
            label9.Text = "Cursada";
            // 
            // txtBookRecord
            // 
            txtBookRecord.BackColor = Color.FromArgb(44, 47, 51);
            txtBookRecord.BorderStyle = BorderStyle.FixedSingle;
            txtBookRecord.Font = new Font("Segoe UI", 12F);
            txtBookRecord.ForeColor = Color.White;
            txtBookRecord.Location = new Point(242, 302);
            txtBookRecord.Margin = new Padding(11, 0, 0, 0);
            txtBookRecord.Name = "txtBookRecord";
            txtBookRecord.Size = new Size(147, 34);
            txtBookRecord.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 365);
            label6.Margin = new Padding(11, 0, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(229, 28);
            label6.TabIndex = 39;
            label6.Text = "Fecha de acreditacion :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(165, 308);
            label5.Margin = new Padding(11, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 37;
            label5.Text = "Acta :";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtGrade
            // 
            txtGrade.BackColor = Color.FromArgb(44, 47, 51);
            txtGrade.BorderStyle = BorderStyle.FixedSingle;
            txtGrade.Font = new Font("Segoe UI", 12F);
            txtGrade.ForeColor = Color.White;
            txtGrade.Location = new Point(82, 306);
            txtGrade.Margin = new Padding(11, 0, 0, 0);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(49, 34);
            txtGrade.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 308);
            label4.Margin = new Padding(11, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 32;
            label4.Text = "Nota :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(255, 152, 0);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(103, 32);
            label1.TabIndex = 24;
            label1.Text = "Alumno:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 14F);
            lblStudent.ForeColor = Color.FromArgb(255, 152, 0);
            lblStudent.Location = new Point(104, 5);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(252, 32);
            lblStudent.TabIndex = 47;
            lblStudent.Text = "--StudentNameHere--";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 14F);
            lblSubject.ForeColor = Color.FromArgb(255, 152, 0);
            lblSubject.Location = new Point(298, 57);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(248, 32);
            lblSubject.TabIndex = 49;
            lblSubject.Text = "--SubjectNameHere--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 252);
            label2.Name = "label2";
            label2.Size = new Size(290, 32);
            label2.TabIndex = 50;
            label2.Text = "Acreditación de examen";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 39);
            panel1.TabIndex = 51;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(663, 4);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 27);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(14, 641);
            btnSave.Margin = new Padding(5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 40);
            btnSave.TabIndex = 52;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_ClickAsync;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(dtAccreditationDate);
            panel2.Controls.Add(lbCourseState);
            panel2.Controls.Add(chkApproved);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblError);
            panel2.Controls.Add(pbDone);
            panel2.Controls.Add(cbbAccType);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(chkPresential);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtGrade);
            panel2.Controls.Add(lblSubject);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblStudent);
            panel2.Controls.Add(txtBookRecord);
            panel2.Controls.Add(lblAcreditationType);
            panel2.Controls.Add(txtEnrolmentYear);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblPresential);
            panel2.Location = new Point(14, 47);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(675, 585);
            panel2.TabIndex = 53;
            // 
            // dtAccreditationDate
            // 
            dtAccreditationDate.CustomFormat = "dd/MM/yyyy";
            dtAccreditationDate.Font = new Font("Segoe UI", 12F);
            dtAccreditationDate.Format = DateTimePickerFormat.Custom;
            dtAccreditationDate.Location = new Point(245, 360);
            dtAccreditationDate.Margin = new Padding(2, 3, 2, 3);
            dtAccreditationDate.Name = "dtAccreditationDate";
            dtAccreditationDate.Size = new Size(144, 34);
            dtAccreditationDate.TabIndex = 59;
            dtAccreditationDate.Value = new DateTime(2024, 3, 28, 0, 0, 0, 0);
            // 
            // lbCourseState
            // 
            lbCourseState.AutoSize = true;
            lbCourseState.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbCourseState.ForeColor = Color.White;
            lbCourseState.Location = new Point(425, 215);
            lbCourseState.Name = "lbCourseState";
            lbCourseState.Size = new Size(75, 28);
            lbCourseState.TabIndex = 58;
            lbCourseState.Text = "Estado";
            // 
            // chkApproved
            // 
            chkApproved.AutoCheck = false;
            chkApproved.Checked = true;
            chkApproved.CheckState = CheckState.Checked;
            chkApproved.Font = new Font("Segoe UI", 12F);
            chkApproved.ForeColor = Color.White;
            chkApproved.Location = new Point(634, 212);
            chkApproved.Margin = new Padding(3, 4, 3, 4);
            chkApproved.Name = "chkApproved";
            chkApproved.Size = new Size(31, 31);
            chkApproved.TabIndex = 57;
            chkApproved.Text = "Approved";
            chkApproved.TextAlign = ContentAlignment.MiddleRight;
            chkApproved.UseVisualStyleBackColor = true;
            chkApproved.CheckedChanged += chkApproved_CheckedChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(255, 152, 0);
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(297, 39);
            label3.TabIndex = 55;
            label3.Text = "Editando datos de la materia ";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F);
            lblError.ForeColor = Color.IndianRed;
            lblError.Image = (Image)resources.GetObject("lblError.Image");
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(142, 515);
            lblError.Margin = new Padding(23, 0, 0, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(132, 28);
            lblError.TabIndex = 54;
            lblError.Text = "         --Error--";
            lblError.Visible = false;
            // 
            // pbDone
            // 
            pbDone.Image = (Image)resources.GetObject("pbDone.Image");
            pbDone.Location = new Point(495, 267);
            pbDone.Margin = new Padding(3, 4, 3, 4);
            pbDone.Name = "pbDone";
            pbDone.Size = new Size(144, 144);
            pbDone.SizeMode = PictureBoxSizeMode.AutoSize;
            pbDone.TabIndex = 53;
            pbDone.TabStop = false;
            pbDone.Visible = false;
            // 
            // btnDeleteGrade
            // 
            btnDeleteGrade.BackColor = Color.FromArgb(0, 150, 136);
            btnDeleteGrade.FlatAppearance.BorderSize = 0;
            btnDeleteGrade.FlatStyle = FlatStyle.Flat;
            btnDeleteGrade.Font = new Font("Segoe UI", 12F);
            btnDeleteGrade.ForeColor = Color.White;
            btnDeleteGrade.Location = new Point(136, 642);
            btnDeleteGrade.Margin = new Padding(5);
            btnDeleteGrade.Name = "btnDeleteGrade";
            btnDeleteGrade.Size = new Size(112, 40);
            btnDeleteGrade.TabIndex = 54;
            btnDeleteGrade.Text = "Borrar";
            btnDeleteGrade.UseVisualStyleBackColor = false;
            btnDeleteGrade.Click += btnDeleteGrade_Click;
            // 
            // formEditGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(698, 696);
            Controls.Add(btnDeleteGrade);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formEditGrade";
            StartPosition = FormStartPosition.CenterParent;
            Text = "formEditGrade";
            Load += formEditGrade_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAcreditationType;
        private ComboBox cbbAccType;
        private TextBox txtEnrolmentYear;
        private BigCheckBox chkPresential;
        private Label lblPresential;
        private Label label10;
        private Label label9;
        private TextBox txtBookRecord;
        private Label label6;
        private Label label5;
        private TextBox txtGrade;
        private Label label4;
        private Label label1;
        private Label lblStudent;
        private Label lblSubject;
        private Label label2;
        private Panel panel1;
        private PictureBox btnClose;
        private Button btnSave;
        private Panel panel2;
        private PictureBox pbDone;
        private Label lblError;
        private Label label3;
        private BigCheckBox chkApproved;
        private Label lbCourseState;
        private DateTimePicker dtAccreditationDate;
        private Button btnDeleteGrade;
    }
}