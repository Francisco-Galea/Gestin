namespace Gestin.UI.Home
{
    partial class formBestAverages
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
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label1 = new Label();
            lblCantidadMaterias = new Label();
            label2 = new Label();
            chkOnlyGraduated = new CheckBox();
            lblCarrera = new Label();
            cbbCareers = new ComboBox();
            dgvAverages = new DataGridView();
            nya = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            materiasAprobadas = new DataGridViewTextBoxColumn();
            porcentajeCarrera = new DataGridViewTextBoxColumn();
            promedio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAverages).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAverages);
            splitContainer1.Size = new Size(1348, 721);
            splitContainer1.SplitterDistance = 196;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblCantidadMaterias);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chkOnlyGraduated);
            panel1.Controls.Add(lblCarrera);
            panel1.Controls.Add(cbbCareers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 196);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(403, 60);
            label1.TabIndex = 5;
            label1.Text = "Mejores Promedios";
            // 
            // lblCantidadMaterias
            // 
            lblCantidadMaterias.AutoSize = true;
            lblCantidadMaterias.BorderStyle = BorderStyle.FixedSingle;
            lblCantidadMaterias.Font = new Font("Segoe UI", 12F);
            lblCantidadMaterias.Location = new Point(341, 150);
            lblCantidadMaterias.Name = "lblCantidadMaterias";
            lblCantidadMaterias.Size = new Size(53, 30);
            lblCantidadMaterias.TabIndex = 4;
            lblCantidadMaterias.Text = "Nro ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 150);
            label2.Name = "label2";
            label2.Size = new Size(318, 28);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de materias de la carrera: ";
            // 
            // chSoloEgresados
            // 
            chkOnlyGraduated.AutoSize = true;
            chkOnlyGraduated.FlatStyle = FlatStyle.Flat;
            chkOnlyGraduated.Font = new Font("Segoe UI", 18F);
            chkOnlyGraduated.Location = new Point(1059, 92);
            chkOnlyGraduated.Name = "chSoloEgresados";
            chkOnlyGraduated.Size = new Size(239, 45);
            chkOnlyGraduated.TabIndex = 2;
            chkOnlyGraduated.Text = "Solo Egresados";
            chkOnlyGraduated.TextAlign = ContentAlignment.MiddleCenter;
            chkOnlyGraduated.UseVisualStyleBackColor = true;
            chkOnlyGraduated.CheckedChanged += chkOnlyGraduated_CheckedChanged;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI", 18F);
            lblCarrera.Location = new Point(17, 92);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(113, 41);
            lblCarrera.TabIndex = 1;
            lblCarrera.Text = "Carrera";
            // 
            // cbbCareers
            // 
            cbbCareers.Font = new Font("Segoe UI", 13.8F);
            cbbCareers.FormattingEnabled = true;
            cbbCareers.Location = new Point(136, 95);
            cbbCareers.Name = "cbbCareers";
            cbbCareers.Size = new Size(908, 39);
            cbbCareers.TabIndex = 0;
            cbbCareers.SelectedIndexChanged += cbbCareers_SelectedIndexChanged;
            // 
            // dgvPromedios
            // 
            dgvAverages.AllowUserToAddRows = false;
            dgvAverages.AllowUserToDeleteRows = false;
            dgvAverages.AllowUserToResizeColumns = false;
            dgvAverages.AllowUserToResizeRows = false;
            dgvAverages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAverages.BackgroundColor = Color.FromArgb(44, 47, 51);
            dgvAverages.BorderStyle = BorderStyle.None;
            dgvAverages.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAverages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAverages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAverages.Columns.AddRange(new DataGridViewColumn[] { nya, dni, materiasAprobadas, porcentajeCarrera, promedio });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAverages.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAverages.EnableHeadersVisualStyles = false;
            dgvAverages.GridColor = Color.FromArgb(0, 150, 136);
            dgvAverages.Location = new Point(0, 0);
            dgvAverages.MultiSelect = false;
            dgvAverages.Name = "dgvPromedios";
            dgvAverages.ReadOnly = true;
            dgvAverages.RowHeadersVisible = false;
            dgvAverages.RowHeadersWidth = 51;
            dgvAverages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAverages.Size = new Size(1348, 521);
            dgvAverages.TabIndex = 0;
            // 
            // nya
            // 
            nya.HeaderText = "Nombre y Apellido";
            nya.MinimumWidth = 6;
            nya.Name = "nya";
            nya.ReadOnly = true;
            // 
            // dni
            // 
            dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dni.HeaderText = "D.N.I";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // materiasAprobadas
            // 
            materiasAprobadas.HeaderText = "Materias Aprobadas";
            materiasAprobadas.MinimumWidth = 6;
            materiasAprobadas.Name = "materiasAprobadas";
            materiasAprobadas.ReadOnly = true;
            // 
            // porcentajeCarrera
            // 
            porcentajeCarrera.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            porcentajeCarrera.HeaderText = "Porcentaje de Carrera";
            porcentajeCarrera.MinimumWidth = 6;
            porcentajeCarrera.Name = "porcentajeCarrera";
            porcentajeCarrera.ReadOnly = true;
            porcentajeCarrera.Width = 180;
            // 
            // promedio
            // 
            promedio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            promedio.HeaderText = "Promedio";
            promedio.MinimumWidth = 6;
            promedio.Name = "promedio";
            promedio.ReadOnly = true;
            promedio.Width = 150;
            // 
            // FrmBestAverages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1348, 721);
            Controls.Add(splitContainer1);
            ForeColor = Color.White;
            Name = "FrmBestAverages";
            Text = "Gestin - Promedios";
            Load += formBestAverages_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAverages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
        private Label lblCantidadMaterias;
        private Label label2;
        private CheckBox chkOnlyGraduated;
        private Label lblCarrera;
        private ComboBox cbbCareers;
        private DataGridView dgvAverages;
        private DataGridViewTextBoxColumn nya;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn materiasAprobadas;
        private DataGridViewTextBoxColumn porcentajeCarrera;
        private DataGridViewTextBoxColumn promedio;
    }
}