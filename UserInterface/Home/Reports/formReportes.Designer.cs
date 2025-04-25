using Gestin.UI.Custom;
using static Gestin.Properties.Resources;

namespace Gestin.UI.Home.Reportes
{
    partial class formReportes
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btnExportTeacherReport = new Button();
            label2 = new Label();
            btnGenerateScheduleReport = new Button();
            label4 = new Label();
            btnGenerateSpreadsheet = new Button();
            label6 = new Label();
            cbbCareerSelector = new ComboBox();
            panel1 = new Panel();
            btnTeachersByCareer = new Button();
            btnTeachersByYear = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridViewSubjects = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearInCareerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lbSearchYear = new Label();
            cbYearInCareer = new ComboBox();
            lbYearInCareer = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            SuspendLayout();
            // 
            // btnExportTeacherReport
            // 
            btnExportTeacherReport.BackColor = Color.FromArgb(0, 150, 136);
            btnExportTeacherReport.FlatAppearance.BorderSize = 0;
            btnExportTeacherReport.FlatStyle = FlatStyle.Flat;
            btnExportTeacherReport.Font = new Font("Segoe UI", 12F);
            btnExportTeacherReport.ForeColor = Color.White;
            btnExportTeacherReport.Location = new Point(8, 84);
            btnExportTeacherReport.Margin = new Padding(3, 2, 3, 2);
            btnExportTeacherReport.Name = "btnExportTeacherReport";
            btnExportTeacherReport.Size = new Size(153, 32);
            btnExportTeacherReport.TabIndex = 1;
            btnExportTeacherReport.Text = "Exportar Listado";
            btnExportTeacherReport.UseVisualStyleBackColor = false;
            btnExportTeacherReport.Click += btnExportTeacherReport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(88, 28);
            label2.Name = "label2";
            label2.Size = new Size(200, 30);
            label2.TabIndex = 2;
            label2.Text = "Listados Docentes";
            // 
            // btnGenerateScheduleReport
            // 
            btnGenerateScheduleReport.BackColor = Color.FromArgb(0, 150, 136);
            btnGenerateScheduleReport.FlatAppearance.BorderSize = 0;
            btnGenerateScheduleReport.FlatStyle = FlatStyle.Flat;
            btnGenerateScheduleReport.Font = new Font("Segoe UI", 12F);
            btnGenerateScheduleReport.ForeColor = Color.White;
            btnGenerateScheduleReport.Location = new Point(181, 84);
            btnGenerateScheduleReport.Margin = new Padding(3, 2, 3, 2);
            btnGenerateScheduleReport.Name = "btnGenerateScheduleReport";
            btnGenerateScheduleReport.Size = new Size(177, 32);
            btnGenerateScheduleReport.TabIndex = 3;
            btnGenerateScheduleReport.Text = "Exportar Horarios";
            btnGenerateScheduleReport.UseVisualStyleBackColor = false;
            btnGenerateScheduleReport.Click += btnGenerateScheduleReport_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(87, 14);
            label4.Name = "label4";
            label4.Size = new Size(224, 30);
            label4.TabIndex = 5;
            label4.Text = "Listados Estudiantes";
            // 
            // btnGenerateSpreadsheet
            // 
            btnGenerateSpreadsheet.BackColor = Color.FromArgb(0, 150, 136);
            btnGenerateSpreadsheet.FlatAppearance.BorderSize = 0;
            btnGenerateSpreadsheet.FlatStyle = FlatStyle.Flat;
            btnGenerateSpreadsheet.Font = new Font("Segoe UI", 12F);
            btnGenerateSpreadsheet.ForeColor = Color.White;
            btnGenerateSpreadsheet.Location = new Point(23, 62);
            btnGenerateSpreadsheet.Margin = new Padding(3, 2, 3, 2);
            btnGenerateSpreadsheet.Name = "btnGenerateSpreadsheet";
            btnGenerateSpreadsheet.Size = new Size(154, 32);
            btnGenerateSpreadsheet.TabIndex = 7;
            btnGenerateSpreadsheet.Text = "Generar Reporte";
            btnGenerateSpreadsheet.UseVisualStyleBackColor = false;
            btnGenerateSpreadsheet.Click += btnGenerateSpreadsheet_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(287, 28);
            label6.Name = "label6";
            label6.Size = new Size(195, 30);
            label6.TabIndex = 8;
            label6.Text = "Listados Materias";
            // 
            // cbbCareerSelector
            // 
            cbbCareerSelector.BackColor = Color.FromArgb(44, 47, 51);
            cbbCareerSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCareerSelector.FlatStyle = FlatStyle.Flat;
            cbbCareerSelector.Font = new Font("Segoe UI", 10F);
            cbbCareerSelector.ForeColor = Color.White;
            cbbCareerSelector.FormattingEnabled = true;
            cbbCareerSelector.Location = new Point(27, 41);
            cbbCareerSelector.Margin = new Padding(3, 2, 3, 2);
            cbbCareerSelector.Name = "cbbCareerSelector";
            cbbCareerSelector.Size = new Size(749, 25);
            cbbCareerSelector.TabIndex = 9;
            cbbCareerSelector.SelectedIndexChanged += cbbCareerSelector_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnTeachersByCareer);
            panel1.Controls.Add(btnTeachersByYear);
            panel1.Controls.Add(btnGenerateScheduleReport);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnExportTeacherReport);
            panel1.Location = new Point(2, 85);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 239);
            panel1.TabIndex = 11;
            // 
            // btnTeachersByCareer
            // 
            btnTeachersByCareer.BackColor = Color.FromArgb(0, 150, 136);
            btnTeachersByCareer.FlatAppearance.BorderSize = 0;
            btnTeachersByCareer.FlatStyle = FlatStyle.Flat;
            btnTeachersByCareer.Font = new Font("Segoe UI", 12F);
            btnTeachersByCareer.ForeColor = Color.White;
            btnTeachersByCareer.Location = new Point(9, 186);
            btnTeachersByCareer.Margin = new Padding(3, 2, 3, 2);
            btnTeachersByCareer.Name = "btnTeachersByCareer";
            btnTeachersByCareer.Size = new Size(349, 32);
            btnTeachersByCareer.TabIndex = 5;
            btnTeachersByCareer.Text = "Exportar Docentes Por Carrera";
            btnTeachersByCareer.UseVisualStyleBackColor = false;
            btnTeachersByCareer.Click += btnTeachersByCareer_Click;
            // 
            // btnTeachersByYear
            // 
            btnTeachersByYear.BackColor = Color.FromArgb(0, 150, 136);
            btnTeachersByYear.FlatAppearance.BorderSize = 0;
            btnTeachersByYear.FlatStyle = FlatStyle.Flat;
            btnTeachersByYear.Font = new Font("Segoe UI", 12F);
            btnTeachersByYear.ForeColor = Color.White;
            btnTeachersByYear.Location = new Point(9, 135);
            btnTeachersByYear.Margin = new Padding(3, 2, 3, 2);
            btnTeachersByYear.Name = "btnTeachersByYear";
            btnTeachersByYear.Size = new Size(349, 32);
            btnTeachersByYear.TabIndex = 4;
            btnTeachersByYear.Text = "Exportar Docentes Por Año de Carrera";
            btnTeachersByYear.UseVisualStyleBackColor = false;
            btnTeachersByYear.Click += btnTeachersByYear_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnGenerateSpreadsheet);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 328);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 142);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dataGridViewSubjects);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(392, 85);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(804, 508);
            panel3.TabIndex = 13;
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.AllowUserToAddRows = false;
            dataGridViewSubjects.AllowUserToDeleteRows = false;
            dataGridViewSubjects.AllowUserToResizeRows = false;
            dataGridViewSubjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubjects.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewSubjects.BorderStyle = BorderStyle.None;
            dataGridViewSubjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle9.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewSubjects.ColumnHeadersHeight = 29;
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSubjects.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, yearInCareerDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle10.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewSubjects.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewSubjects.EnableHeadersVisualStyles = false;
            dataGridViewSubjects.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewSubjects.Location = new Point(33, 84);
            dataGridViewSubjects.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSubjects.MultiSelect = false;
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle11.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewSubjects.RowHeadersVisible = false;
            dataGridViewSubjects.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle12.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewSubjects.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubjects.ShowCellToolTips = false;
            dataGridViewSubjects.Size = new Size(748, 396);
            dataGridViewSubjects.TabIndex = 31;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearInCareerDataGridViewTextBoxColumn
            // 
            yearInCareerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            yearInCareerDataGridViewTextBoxColumn.DataPropertyName = "YearInCareer";
            yearInCareerDataGridViewTextBoxColumn.FillWeight = 0.0129032694F;
            yearInCareerDataGridViewTextBoxColumn.HeaderText = "Año";
            yearInCareerDataGridViewTextBoxColumn.MinimumWidth = 8;
            yearInCareerDataGridViewTextBoxColumn.Name = "yearInCareerDataGridViewTextBoxColumn";
            yearInCareerDataGridViewTextBoxColumn.ReadOnly = true;
            yearInCareerDataGridViewTextBoxColumn.Width = 61;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Materia";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lbSearchYear
            // 
            lbSearchYear.AutoSize = true;
            lbSearchYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSearchYear.ForeColor = Color.White;
            lbSearchYear.Location = new Point(11, 9);
            lbSearchYear.Margin = new Padding(4, 0, 4, 0);
            lbSearchYear.Name = "lbSearchYear";
            lbSearchYear.Size = new Size(808, 21);
            lbSearchYear.TabIndex = 53;
            lbSearchYear.Text = "* Seleccione una carrera para visualizar sus materias ó generar un reporte .xls para exportar sus docentes.";
            // 
            // cbYearInCareer
            // 
            cbYearInCareer.BackColor = Color.FromArgb(44, 47, 51);
            cbYearInCareer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYearInCareer.FlatStyle = FlatStyle.Flat;
            cbYearInCareer.Font = new Font("Segoe UI", 10F);
            cbYearInCareer.ForeColor = Color.White;
            cbYearInCareer.FormattingEnabled = true;
            cbYearInCareer.Location = new Point(850, 41);
            cbYearInCareer.Margin = new Padding(3, 2, 3, 2);
            cbYearInCareer.Name = "cbYearInCareer";
            cbYearInCareer.Size = new Size(224, 25);
            cbYearInCareer.TabIndex = 54;
            cbYearInCareer.Visible = false;
            // 
            // lbYearInCareer
            // 
            lbYearInCareer.AutoSize = true;
            lbYearInCareer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbYearInCareer.ForeColor = Color.White;
            lbYearInCareer.Location = new Point(850, 9);
            lbYearInCareer.Margin = new Padding(4, 0, 4, 0);
            lbYearInCareer.Name = "lbYearInCareer";
            lbYearInCareer.Size = new Size(41, 21);
            lbYearInCareer.TabIndex = 55;
            lbYearInCareer.Text = "Año";
            lbYearInCareer.Visible = false;
            // 
            // formReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(1199, 604);
            Controls.Add(lbYearInCareer);
            Controls.Add(cbYearInCareer);
            Controls.Add(lbSearchYear);
            Controls.Add(panel3);
            Controls.Add(cbbCareerSelector);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formReportes";
            Text = "Gestin - Reportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExportTeacherReport;
        private Label label2;
        private Button btnGenerateScheduleReport;
        private Label label4;
        private Button btnGenerateSpreadsheet;
        private Label label6;
        private ComboBox cbbCareerSelector;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridViewSubjects;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearInCareerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Label lbSearchYear;
        private ComboBox cbYearInCareer;
        private Label lbYearInCareer;
        private Button btnTeachersByYear;
        private Button btnTeachersByCareer;
    }
}