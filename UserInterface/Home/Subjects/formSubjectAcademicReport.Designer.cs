using Gestin.UI.Custom;

namespace Gestin.UI.Home.Subjects
{
    partial class formSubjectAcademicReport
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSubjectAcademicReport));
            lbAcademicReport = new Label();
            lbCareer = new Label();
            lbSubject = new Label();
            dgvAcademicReport = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            approved = new DataGridViewCheckBoxColumn();
            Libre = new DataGridViewCheckBoxColumn();
            btnSave = new Button();
            lbYear = new Label();
            gpSearchByYear = new GroupBox();
            btnSearchByYear = new Button();
            lbSearchYear = new Label();
            toggSearchByYear = new ToggleButton();
            txtSearchYear = new TextBox();
            lblTotal = new Label();
            label7 = new Label();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAcademicReport).BeginInit();
            gpSearchByYear.SuspendLayout();
            SuspendLayout();
            // 
            // lbAcademicReport
            // 
            lbAcademicReport.BackColor = Color.DimGray;
            lbAcademicReport.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbAcademicReport.ForeColor = Color.FromArgb(255, 152, 0);
            lbAcademicReport.Location = new Point(363, 11);
            lbAcademicReport.Name = "lbAcademicReport";
            lbAcademicReport.Size = new Size(461, 33);
            lbAcademicReport.TabIndex = 59;
            lbAcademicReport.Text = "INFORME DE CÁTEDRA - Ciclo Lectivo";
            // 
            // lbCareer
            // 
            lbCareer.BackColor = Color.DimGray;
            lbCareer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbCareer.ForeColor = Color.FromArgb(255, 152, 0);
            lbCareer.Location = new Point(14, 73);
            lbCareer.Name = "lbCareer";
            lbCareer.Size = new Size(841, 33);
            lbCareer.TabIndex = 60;
            lbCareer.Text = "Carrera";
            // 
            // lbSubject
            // 
            lbSubject.BackColor = Color.DimGray;
            lbSubject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbSubject.ForeColor = Color.FromArgb(255, 152, 0);
            lbSubject.Location = new Point(779, 73);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(431, 33);
            lbSubject.TabIndex = 61;
            lbSubject.Text = "Materia";
            // 
            // dgvAcademicReport
            // 
            dgvAcademicReport.AllowUserToAddRows = false;
            dgvAcademicReport.AllowUserToDeleteRows = false;
            dgvAcademicReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAcademicReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAcademicReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAcademicReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAcademicReport.BackgroundColor = Color.DimGray;
            dgvAcademicReport.BorderStyle = BorderStyle.None;
            dgvAcademicReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAcademicReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAcademicReport.ColumnHeadersHeight = 30;
            dgvAcademicReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAcademicReport.Columns.AddRange(new DataGridViewColumn[] { dni, name, lastname, approved, Libre });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAcademicReport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAcademicReport.EnableHeadersVisualStyles = false;
            dgvAcademicReport.GridColor = Color.FromArgb(0, 150, 136);
            dgvAcademicReport.Location = new Point(14, 204);
            dgvAcademicReport.MultiSelect = false;
            dgvAcademicReport.Name = "dgvAcademicReport";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAcademicReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAcademicReport.RowHeadersVisible = false;
            dgvAcademicReport.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAcademicReport.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvAcademicReport.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAcademicReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAcademicReport.ShowCellToolTips = false;
            dgvAcademicReport.Size = new Size(1270, 533);
            dgvAcademicReport.TabIndex = 62;
            dgvAcademicReport.RowPostPaint += dgvAcademicReport_RowPostPaint;
            dgvAcademicReport.RowsAdded += dgvAcademicReport_RowsAdded;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 15;
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // lastname
            // 
            lastname.HeaderText = "Apellido";
            lastname.MinimumWidth = 8;
            lastname.Name = "lastname";
            lastname.ReadOnly = true;
            // 
            // approved
            // 
            approved.HeaderText = "¿Aprobó la cursada?";
            approved.MinimumWidth = 8;
            approved.Name = "approved";
            // 
            // Libre
            // 
            Libre.HeaderText = "Libre";
            Libre.MinimumWidth = 6;
            Libre.Name = "Libre";
            Libre.ReadOnly = true;
            Libre.Resizable = DataGridViewTriState.True;
            Libre.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1112, 132);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 65);
            btnSave.TabIndex = 63;
            btnSave.Text = "Guardar Informe";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.BackColor = Color.DimGray;
            lbYear.BorderStyle = BorderStyle.FixedSingle;
            lbYear.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbYear.ForeColor = Color.LightCyan;
            lbYear.Location = new Point(818, 11);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(57, 37);
            lbYear.TabIndex = 64;
            lbYear.Text = "----";
            // 
            // gpSearchByYear
            // 
            gpSearchByYear.Controls.Add(btnSearchByYear);
            gpSearchByYear.Controls.Add(lbSearchYear);
            gpSearchByYear.Controls.Add(toggSearchByYear);
            gpSearchByYear.Controls.Add(txtSearchYear);
            gpSearchByYear.ForeColor = Color.WhiteSmoke;
            gpSearchByYear.Location = new Point(395, 111);
            gpSearchByYear.Margin = new Padding(3, 4, 3, 4);
            gpSearchByYear.Name = "gpSearchByYear";
            gpSearchByYear.Padding = new Padding(3, 4, 3, 4);
            gpSearchByYear.Size = new Size(497, 73);
            gpSearchByYear.TabIndex = 65;
            gpSearchByYear.TabStop = false;
            gpSearchByYear.Text = "Buscar por año";
            // 
            // btnSearchByYear
            // 
            btnSearchByYear.BackColor = Color.FromArgb(0, 150, 136);
            btnSearchByYear.FlatAppearance.BorderSize = 0;
            btnSearchByYear.FlatStyle = FlatStyle.Flat;
            btnSearchByYear.Font = new Font("Microsoft Sans Serif", 12F);
            btnSearchByYear.ForeColor = Color.White;
            btnSearchByYear.Location = new Point(385, 21);
            btnSearchByYear.Name = "btnSearchByYear";
            btnSearchByYear.Size = new Size(95, 40);
            btnSearchByYear.TabIndex = 54;
            btnSearchByYear.Text = "Buscar";
            btnSearchByYear.UseVisualStyleBackColor = false;
            btnSearchByYear.Click += btnSearchByYear_Click;
            // 
            // lbSearchYear
            // 
            lbSearchYear.AutoSize = true;
            lbSearchYear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSearchYear.ForeColor = Color.White;
            lbSearchYear.Location = new Point(14, 25);
            lbSearchYear.Margin = new Padding(5, 0, 5, 0);
            lbSearchYear.Name = "lbSearchYear";
            lbSearchYear.Size = new Size(73, 28);
            lbSearchYear.TabIndex = 52;
            lbSearchYear.Text = "Actual";
            // 
            // toggSearchByYear
            // 
            toggSearchByYear.AutoSize = true;
            toggSearchByYear.FlatStyle = FlatStyle.Flat;
            toggSearchByYear.Location = new Point(123, 25);
            toggSearchByYear.Margin = new Padding(3, 4, 3, 4);
            toggSearchByYear.MinimumSize = new Size(51, 29);
            toggSearchByYear.Name = "toggSearchByYear";
            toggSearchByYear.OffBackColor = Color.Gray;
            toggSearchByYear.OffToggleColor = Color.Gainsboro;
            toggSearchByYear.OnBackColor = Color.FromArgb(0, 150, 136);
            toggSearchByYear.OnToggleColor = Color.WhiteSmoke;
            toggSearchByYear.Size = new Size(51, 29);
            toggSearchByYear.TabIndex = 53;
            toggSearchByYear.UseVisualStyleBackColor = true;
            toggSearchByYear.CheckedChanged += toggSearchByYear_CheckedChanged;
            // 
            // txtSearchYear
            // 
            txtSearchYear.BackColor = Color.FromArgb(44, 47, 51);
            txtSearchYear.BorderStyle = BorderStyle.FixedSingle;
            txtSearchYear.Enabled = false;
            txtSearchYear.Font = new Font("Segoe UI", 12F);
            txtSearchYear.ForeColor = Color.White;
            txtSearchYear.Location = new Point(181, 23);
            txtSearchYear.Margin = new Padding(2, 1, 2, 1);
            txtSearchYear.Name = "txtSearchYear";
            txtSearchYear.PlaceholderText = "  ingrese un año";
            txtSearchYear.Size = new Size(188, 34);
            txtSearchYear.TabIndex = 27;
            txtSearchYear.KeyPress += txtSearchSubject_KeyPress;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(168, 179);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(23, 22);
            lblTotal.TabIndex = 68;
            lblTotal.Text = "--";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 152, 0);
            label7.Location = new Point(14, 181);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 67;
            label7.Text = "Estudiantes Totales:";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(0, 150, 136);
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 12F);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(934, 132);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(171, 65);
            btnExport.TabIndex = 69;
            btnExport.Text = "Exportar Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // formSubjectAcademicReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DimGray;
            ClientSize = new Size(1295, 749);
            Controls.Add(btnExport);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(gpSearchByYear);
            Controls.Add(lbYear);
            Controls.Add(btnSave);
            Controls.Add(dgvAcademicReport);
            Controls.Add(lbSubject);
            Controls.Add(lbCareer);
            Controls.Add(lbAcademicReport);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "formSubjectAcademicReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestin - Informe de Cátedra";
            Load += formSubjectAcademicReport_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAcademicReport).EndInit();
            gpSearchByYear.ResumeLayout(false);
            gpSearchByYear.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAcademicReport;
        private Label lbCareer;
        private Label lbSubject;
        private DataGridView dgvAcademicReport;
        private Button btnSave;
        private Label lbYear;
        private GroupBox gpSearchByYear;
        private Label lbSearchYear;
        private ToggleButton toggSearchByYear;
        private TextBox txtSearchYear;
        private Button btnSearchByYear;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewCheckBoxColumn approved;
        private DataGridViewCheckBoxColumn Libre;
        private Label lblTotal;
        private Label label7;
        private Button btnExport;
    }
}