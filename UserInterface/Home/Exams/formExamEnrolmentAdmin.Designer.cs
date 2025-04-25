namespace Gestin.UI.Home.ExamEnrolment
{
    partial class formExamEnrolmentAdmin
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
            searchBox = new TextBox();
            lbSearch = new ListBox();
            dgvExams = new DataGridView();
            ExamId = new DataGridViewTextBoxColumn();
            CareerId = new DataGridViewTextBoxColumn();
            SubjectId = new DataGridViewTextBoxColumn();
            Career = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Llamado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblStudent = new Label();
            label3 = new Label();
            lblDni = new Label();
            btnEnrol = new Button();
            label5 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(35, 39, 42);
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Segoe UI", 12F);
            searchBox.ForeColor = Color.White;
            searchBox.Location = new Point(21, 10);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "  Buscar estudiante";
            searchBox.Size = new Size(415, 34);
            searchBox.TabIndex = 33;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.KeyDown += searchBox_KeyDown;
            // 
            // lbSearch
            // 
            lbSearch.BackColor = Color.FromArgb(32, 32, 32);
            lbSearch.BorderStyle = BorderStyle.FixedSingle;
            lbSearch.Font = new Font("Segoe UI", 12F);
            lbSearch.ForeColor = Color.White;
            lbSearch.FormattingEnabled = true;
            lbSearch.ItemHeight = 28;
            lbSearch.Location = new Point(21, 43);
            lbSearch.Margin = new Padding(3, 2, 3, 2);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(415, 86);
            lbSearch.TabIndex = 34;
            lbSearch.Visible = false;
            lbSearch.Click += lbSearch_Click;
            lbSearch.KeyDown += lbSearch_KeyDown;
            // 
            // dgvExams
            // 
            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dgvExams.AllowUserToResizeRows = false;
            dgvExams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExams.BackgroundColor = Color.FromArgb(44, 47, 51);
            dgvExams.BorderStyle = BorderStyle.None;
            dgvExams.CausesValidation = false;
            dgvExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Columns.AddRange(new DataGridViewColumn[] { ExamId, CareerId, SubjectId, Career, Subject, Date, Llamado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.GridColor = Color.FromArgb(0, 150, 136);
            dgvExams.Location = new Point(21, 111);
            dgvExams.Margin = new Padding(3, 2, 3, 2);
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvExams.RowHeadersVisible = false;
            dgvExams.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(54, 57, 63);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(1167, 597);
            dgvExams.TabIndex = 35;
            // 
            // ExamId
            // 
            ExamId.HeaderText = "ExamId";
            ExamId.MinimumWidth = 6;
            ExamId.Name = "ExamId";
            ExamId.ReadOnly = true;
            ExamId.Visible = false;
            // 
            // CareerId
            // 
            CareerId.HeaderText = "CareerId";
            CareerId.MinimumWidth = 6;
            CareerId.Name = "CareerId";
            CareerId.ReadOnly = true;
            CareerId.Visible = false;
            // 
            // SubjectId
            // 
            SubjectId.HeaderText = "SubjectId";
            SubjectId.MinimumWidth = 6;
            SubjectId.Name = "SubjectId";
            SubjectId.ReadOnly = true;
            SubjectId.Visible = false;
            // 
            // Career
            // 
            Career.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Career.HeaderText = "Carrera";
            Career.MinimumWidth = 6;
            Career.Name = "Career";
            Career.ReadOnly = true;
            // 
            // Subject
            // 
            Subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Subject.HeaderText = "Materia";
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.FillWeight = 35F;
            Date.HeaderText = "Fecha";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Llamado
            // 
            Llamado.FillWeight = 20F;
            Llamado.HeaderText = "Llamado";
            Llamado.MinimumWidth = 6;
            Llamado.Name = "Llamado";
            Llamado.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(469, 12);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 36;
            label1.Text = "Estudiante seleccionado:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 10F);
            lblStudent.ForeColor = Color.FromArgb(255, 152, 0);
            lblStudent.Location = new Point(688, 16);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(73, 23);
            lblStudent.TabIndex = 37;
            lblStudent.Text = "---------";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1024, 12);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 38;
            label3.Text = "Dni:";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F);
            lblDni.ForeColor = Color.FromArgb(255, 152, 0);
            lblDni.Location = new Point(1067, 16);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(73, 23);
            lblDni.TabIndex = 39;
            lblDni.Text = "---------";
            // 
            // btnEnrol
            // 
            btnEnrol.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnrol.BackColor = Color.FromArgb(0, 150, 136);
            btnEnrol.FlatAppearance.BorderSize = 0;
            btnEnrol.FlatStyle = FlatStyle.Flat;
            btnEnrol.Font = new Font("Segoe UI", 12F);
            btnEnrol.ForeColor = Color.White;
            btnEnrol.Location = new Point(21, 708);
            btnEnrol.Margin = new Padding(3, 2, 3, 2);
            btnEnrol.Name = "btnEnrol";
            btnEnrol.Size = new Size(302, 54);
            btnEnrol.TabIndex = 40;
            btnEnrol.Text = "Inscribir";
            btnEnrol.UseVisualStyleBackColor = false;
            btnEnrol.Click += btnEnrol_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(255, 152, 0);
            label5.Location = new Point(363, 721);
            label5.Name = "label5";
            label5.Size = new Size(482, 28);
            label5.TabIndex = 41;
            label5.Text = "Puede inscribir a múltiples exámenes al mismo tiempo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(255, 152, 0);
            label2.Location = new Point(21, 85);
            label2.Name = "label2";
            label2.Size = new Size(229, 28);
            label2.TabIndex = 42;
            label2.Text = "Inscripciones disponibles";
            // 
            // formExamEnrolmentAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(1200, 773);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(btnEnrol);
            Controls.Add(lblDni);
            Controls.Add(label3);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Controls.Add(dgvExams);
            Controls.Add(searchBox);
            Controls.Add(lbSearch);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "formExamEnrolmentAdmin";
            Text = "formExamEnrolmentAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private ListBox lbSearch;
        private DataGridView dgvExams;
        private Label label1;
        private Label lblStudent;
        private Label label3;
        private Label lblDni;
        private Button btnEnrol;
        private Label label5;
        private Label label2;
        private DataGridViewTextBoxColumn ExamId;
        private DataGridViewTextBoxColumn CareerId;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn Career;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Llamado;
    }
}