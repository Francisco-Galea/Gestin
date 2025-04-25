namespace Gestin.UI.Home.Subjects
{
    partial class formSubjectEnrolments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSubjectEnrolments));
            searchBox = new TextBox();
            lbSearch = new ListBox();
            label4 = new Label();
            cbbCareer = new ComboBox();
            panel1 = new Panel();
            dgvSubjects = new DataGridView();
            idSubject = new DataGridViewTextBoxColumn();
            subjectsYearInCareer = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            EnrolmentYear = new DataGridViewTextBoxColumn();
            enrolmentCondition = new DataGridViewCheckBoxColumn();
            approved = new DataGridViewCheckBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            txtStudent = new TextBox();
            label7 = new Label();
            txtStudentDni = new TextBox();
            lblPersonalData = new Label();
            btnEnrol = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            explanation = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(35, 39, 42);
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(5, 15);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "  Buscar estudiante";
            searchBox.Size = new Size(260, 30);
            searchBox.TabIndex = 39;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.KeyDown += searchBox_KeyDown;
            // 
            // lbSearch
            // 
            lbSearch.BackColor = Color.FromArgb(54, 57, 63);
            lbSearch.BorderStyle = BorderStyle.FixedSingle;
            lbSearch.Font = new Font("Segoe UI", 10F);
            lbSearch.ForeColor = Color.White;
            lbSearch.FormattingEnabled = true;
            lbSearch.ItemHeight = 23;
            lbSearch.Location = new Point(5, 51);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(260, 623);
            lbSearch.TabIndex = 40;
            lbSearch.Visible = false;
            lbSearch.MouseDoubleClick += lbSearch_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(54, 57, 63);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(290, 17);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 42;
            label4.Text = "Carrera :";
            // 
            // cbbCareer
            // 
            cbbCareer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbbCareer.BackColor = Color.FromArgb(44, 47, 51);
            cbbCareer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCareer.FlatStyle = FlatStyle.Flat;
            cbbCareer.Font = new Font("Segoe UI", 10F);
            cbbCareer.ForeColor = Color.White;
            cbbCareer.FormattingEnabled = true;
            cbbCareer.Location = new Point(390, 17);
            cbbCareer.Margin = new Padding(5);
            cbbCareer.MinimumSize = new Size(171, 0);
            cbbCareer.Name = "cbbCareer";
            cbbCareer.Size = new Size(937, 31);
            cbbCareer.Sorted = true;
            cbbCareer.TabIndex = 41;
            cbbCareer.SelectedIndexChanged += cbbCareer_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSubjects);
            panel1.Location = new Point(290, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 627);
            panel1.TabIndex = 43;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AllowUserToResizeRows = false;
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubjects.BackgroundColor = Color.FromArgb(44, 47, 51);
            dgvSubjects.BorderStyle = BorderStyle.None;
            dgvSubjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Columns.AddRange(new DataGridViewColumn[] { idSubject, subjectsYearInCareer, subject, EnrolmentYear, enrolmentCondition, approved });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSubjects.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSubjects.EnableHeadersVisualStyles = false;
            dgvSubjects.GridColor = Color.FromArgb(0, 150, 136);
            dgvSubjects.Location = new Point(0, 0);
            dgvSubjects.Margin = new Padding(0);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSubjects.RowHeadersVisible = false;
            dgvSubjects.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dgvSubjects.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSubjects.RowTemplate.Height = 24;
            dgvSubjects.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSubjects.Size = new Size(1035, 627);
            dgvSubjects.TabIndex = 1;
            dgvSubjects.MouseDown += dgvSubjects_MouseDown;
            dgvSubjects.MouseUp += dgvSubjects_MouseUp;
            // 
            // idSubject
            // 
            idSubject.HeaderText = "idMateria";
            idSubject.MinimumWidth = 6;
            idSubject.Name = "idSubject";
            idSubject.Visible = false;
            // 
            // subjectsYearInCareer
            // 
            subjectsYearInCareer.FillWeight = 21F;
            subjectsYearInCareer.HeaderText = "Año";
            subjectsYearInCareer.MinimumWidth = 13;
            subjectsYearInCareer.Name = "subjectsYearInCareer";
            // 
            // subject
            // 
            subject.FillWeight = 179.660156F;
            subject.HeaderText = "Materia";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // EnrolmentYear
            // 
            EnrolmentYear.FillWeight = 58F;
            EnrolmentYear.HeaderText = "Año de matriculación";
            EnrolmentYear.MinimumWidth = 6;
            EnrolmentYear.Name = "EnrolmentYear";
            // 
            // enrolmentCondition
            // 
            enrolmentCondition.HeaderText = "Presencial";
            enrolmentCondition.MinimumWidth = 6;
            enrolmentCondition.Name = "enrolmentCondition";
            // 
            // approved
            // 
            approved.HeaderText = "Cursada aprobada";
            approved.MinimumWidth = 6;
            approved.Name = "approved";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtStudent);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(txtStudentDni);
            flowLayoutPanel1.Location = new Point(5, 83);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(277, 197);
            flowLayoutPanel1.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(187, 28);
            label6.TabIndex = 26;
            label6.Text = "Apellido y nombre";
            // 
            // txtStudent
            // 
            txtStudent.BackColor = Color.FromArgb(44, 47, 51);
            txtStudent.BorderStyle = BorderStyle.FixedSingle;
            txtStudent.Font = new Font("Segoe UI", 10F);
            txtStudent.ForeColor = Color.White;
            txtStudent.Location = new Point(3, 31);
            txtStudent.Name = "txtStudent";
            txtStudent.ReadOnly = true;
            txtStudent.Size = new Size(253, 30);
            txtStudent.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 77);
            label7.Margin = new Padding(3, 13, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 28);
            label7.TabIndex = 5;
            label7.Text = "Dni :";
            // 
            // txtStudentDni
            // 
            txtStudentDni.BackColor = Color.FromArgb(44, 47, 51);
            txtStudentDni.BorderStyle = BorderStyle.FixedSingle;
            txtStudentDni.Font = new Font("Segoe UI", 10F);
            txtStudentDni.ForeColor = Color.White;
            txtStudentDni.Location = new Point(3, 108);
            txtStudentDni.Name = "txtStudentDni";
            txtStudentDni.ReadOnly = true;
            txtStudentDni.Size = new Size(253, 30);
            txtStudentDni.TabIndex = 11;
            // 
            // lblPersonalData
            // 
            lblPersonalData.AutoSize = true;
            lblPersonalData.BackColor = Color.Transparent;
            lblPersonalData.FlatStyle = FlatStyle.Flat;
            lblPersonalData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPersonalData.ForeColor = Color.White;
            lblPersonalData.Location = new Point(5, 48);
            lblPersonalData.Name = "lblPersonalData";
            lblPersonalData.Size = new Size(174, 28);
            lblPersonalData.TabIndex = 44;
            lblPersonalData.Text = "Datos personales";
            // 
            // btnEnrol
            // 
            btnEnrol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnrol.BackColor = Color.FromArgb(0, 150, 136);
            btnEnrol.FlatAppearance.BorderSize = 0;
            btnEnrol.FlatStyle = FlatStyle.Flat;
            btnEnrol.Font = new Font("Segoe UI", 12F);
            btnEnrol.ForeColor = Color.White;
            btnEnrol.Location = new Point(290, 685);
            btnEnrol.Name = "btnEnrol";
            btnEnrol.Size = new Size(120, 44);
            btnEnrol.TabIndex = 46;
            btnEnrol.Text = "Matricular";
            btnEnrol.UseVisualStyleBackColor = false;
            btnEnrol.Click += btnEnrol_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(explanation);
            flowLayoutPanel2.ForeColor = SystemColors.ControlLightLight;
            flowLayoutPanel2.Location = new Point(8, 283);
            flowLayoutPanel2.Margin = new Padding(5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(253, 415);
            flowLayoutPanel2.TabIndex = 46;
            // 
            // explanation
            // 
            explanation.AutoSize = true;
            explanation.Font = new Font("Segoe UI", 12F);
            explanation.Location = new Point(3, 0);
            explanation.Name = "explanation";
            explanation.Size = new Size(245, 392);
            explanation.TabIndex = 0;
            explanation.Text = resources.GetString("explanation.Text");
            // 
            // formSubjectEnrolments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(1366, 737);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(btnEnrol);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblPersonalData);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(cbbCareer);
            Controls.Add(lbSearch);
            Controls.Add(searchBox);
            Name = "formSubjectEnrolments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSubjectsEnrolments";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchBox;
        private ListBox lbSearch;
        private Label label4;
        private ComboBox cbbCareer;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label6;
        private TextBox txtStudent;
        private Label label7;
        private TextBox txtStudentDni;
        private Label lblPersonalData;
        private Button btnEnrol;
        private DataGridView dgvSubjects;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label explanation;
        private DataGridViewTextBoxColumn idSubject;
        private DataGridViewTextBoxColumn subjectsYearInCareer;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn EnrolmentYear;
        private DataGridViewCheckBoxColumn enrolmentCondition;
        private DataGridViewCheckBoxColumn approved;
    }
}