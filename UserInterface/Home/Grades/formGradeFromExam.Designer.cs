namespace Gestin.UI.Home.ExamEnrolment
{
    partial class formGradeFromExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGradeFromExam));
            MainPanel = new Panel();
            panel2 = new Panel();
            dgvStudents = new DataGridView();
            studentId = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            condition = new DataGridViewTextBoxColumn();
            grade = new DataGridViewTextBoxColumn();
            bottomPanel = new Panel();
            btnAddGrades = new Button();
            txtPresentialBook = new TextBox();
            lblError = new Label();
            txtFreeBook = new TextBox();
            label2 = new Label();
            btnUnrol = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            btnBack = new Button();
            lblExam = new Label();
            MainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            bottomPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(44, 47, 51);
            MainPanel.Controls.Add(panel2);
            MainPanel.Controls.Add(bottomPanel);
            MainPanel.Controls.Add(panel1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(10, 11, 10, 11);
            MainPanel.Size = new Size(1290, 1055);
            MainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 47, 51);
            panel2.Controls.Add(dgvStudents);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 106);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(11, 13, 11, 13);
            panel2.Size = new Size(1270, 789);
            panel2.TabIndex = 4;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(44, 47, 51);
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.CausesValidation = false;
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { studentId, name, condition, grade });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.GridColor = Color.FromArgb(0, 150, 136);
            dgvStudents.Location = new Point(11, 13);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(54, 57, 63);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvStudents.RowTemplate.Height = 29;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1248, 763);
            dgvStudents.TabIndex = 36;
            // 
            // studentId
            // 
            studentId.HeaderText = "studentId";
            studentId.MinimumWidth = 6;
            studentId.Name = "studentId";
            studentId.Visible = false;
            // 
            // name
            // 
            name.HeaderText = "Estudiante";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // condition
            // 
            condition.FillWeight = 20F;
            condition.HeaderText = "Condicion";
            condition.MinimumWidth = 6;
            condition.Name = "condition";
            condition.ReadOnly = true;
            // 
            // grade
            // 
            grade.FillWeight = 10F;
            grade.HeaderText = "Nota";
            grade.MinimumWidth = 6;
            grade.Name = "grade";
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(44, 47, 51);
            bottomPanel.Controls.Add(btnAddGrades);
            bottomPanel.Controls.Add(txtPresentialBook);
            bottomPanel.Controls.Add(lblError);
            bottomPanel.Controls.Add(txtFreeBook);
            bottomPanel.Controls.Add(label2);
            bottomPanel.Controls.Add(btnUnrol);
            bottomPanel.Controls.Add(label1);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(10, 895);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1270, 149);
            bottomPanel.TabIndex = 3;
            // 
            // btnAddGrades
            // 
            btnAddGrades.BackColor = Color.FromArgb(0, 150, 136);
            btnAddGrades.FlatAppearance.BorderSize = 0;
            btnAddGrades.FlatStyle = FlatStyle.Flat;
            btnAddGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddGrades.ForeColor = Color.White;
            btnAddGrades.Location = new Point(352, 95);
            btnAddGrades.Margin = new Padding(5, 5, 5, 5);
            btnAddGrades.Name = "btnAddGrades";
            btnAddGrades.Size = new Size(152, 40);
            btnAddGrades.TabIndex = 57;
            btnAddGrades.Text = "Agregar notas";
            btnAddGrades.TextAlign = ContentAlignment.TopCenter;
            btnAddGrades.UseVisualStyleBackColor = false;
            btnAddGrades.Click += btnAddGrades_Click;
            // 
            // txtPresentialBook
            // 
            txtPresentialBook.BackColor = Color.FromArgb(44, 47, 51);
            txtPresentialBook.BorderStyle = BorderStyle.FixedSingle;
            txtPresentialBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPresentialBook.ForeColor = Color.White;
            txtPresentialBook.Location = new Point(380, 11);
            txtPresentialBook.Name = "txtPresentialBook";
            txtPresentialBook.Size = new Size(124, 34);
            txtPresentialBook.TabIndex = 31;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.FromArgb(244, 67, 54);
            lblError.Image = (Image)resources.GetObject("lblError.Image");
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(647, -28);
            lblError.Name = "lblError";
            lblError.Size = new Size(137, 28);
            lblError.TabIndex = 56;
            lblError.Text = "          --Error--";
            lblError.Visible = false;
            // 
            // txtFreeBook
            // 
            txtFreeBook.BackColor = Color.FromArgb(44, 47, 51);
            txtFreeBook.BorderStyle = BorderStyle.FixedSingle;
            txtFreeBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFreeBook.ForeColor = Color.White;
            txtFreeBook.Location = new Point(325, 53);
            txtFreeBook.Name = "txtFreeBook";
            txtFreeBook.Size = new Size(179, 34);
            txtFreeBook.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 59);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(308, 28);
            label2.TabIndex = 29;
            label2.Text = "Libro/Folio de acta volante LIBRE :";
            // 
            // btnUnrol
            // 
            btnUnrol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUnrol.BackColor = Color.FromArgb(244, 67, 54);
            btnUnrol.FlatAppearance.BorderSize = 0;
            btnUnrol.FlatStyle = FlatStyle.Flat;
            btnUnrol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUnrol.ForeColor = Color.White;
            btnUnrol.Location = new Point(957, 8);
            btnUnrol.Margin = new Padding(5, 5, 5, 5);
            btnUnrol.Name = "btnUnrol";
            btnUnrol.Size = new Size(309, 40);
            btnUnrol.TabIndex = 27;
            btnUnrol.Text = "Dar de baja estudiante seleccionado";
            btnUnrol.UseVisualStyleBackColor = false;
            btnUnrol.Click += btnUnrol_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 13);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(369, 28);
            label1.TabIndex = 28;
            label1.Text = "Libro/Folio de acta volante PRESENCIAL :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 47, 51);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblExam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 11);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 95);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(11, 56);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(708, 32);
            label3.TabIndex = 32;
            label3.Text = "Complete la columna Nota con la notas de examen de la materia";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(44, 47, 51);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(0, 3);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 35);
            btnBack.TabIndex = 27;
            btnBack.Text = " Volver";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblExam
            // 
            lblExam.AutoSize = true;
            lblExam.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblExam.ForeColor = Color.FromArgb(255, 152, 0);
            lblExam.Location = new Point(733, 56);
            lblExam.Margin = new Padding(0);
            lblExam.Name = "lblExam";
            lblExam.Size = new Size(302, 32);
            lblExam.TabIndex = 0;
            lblExam.Text = "-- Nombre de la materia --";
            // 
            // formGradeFromExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 1055);
            Controls.Add(MainPanel);
            Name = "formGradeFromExam";
            Text = "formActaVolante";
            MainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel bottomPanel;
        private Panel panel1;
        private Label lblExam;
        private Panel panel2;
        private Button btnUnrol;
        private Button btnBack;
        private Label lblError;
        private DataGridView dgvStudents;
        private Button btnAddGrades;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn studentId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn condition;
        private DataGridViewTextBoxColumn grade;
        private TextBox txtPresentialBook;
        private TextBox txtFreeBook;
        private Label label3;
    }
}