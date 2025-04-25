namespace Gestin.UI.Home.Schedules
{
    partial class formSchedule
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSchedule));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelLeft = new Panel();
            btnInfo = new Button();
            lblAnio = new Label();
            dataGridViewSubjects = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subjectBindingSource = new BindingSource(components);
            comboBoxYear = new ComboBox();
            labelCareerName = new Label();
            panelCenter = new Panel();
            panel2 = new Panel();
            pictureBoxError = new PictureBox();
            dataGridViewSchedules = new DataGridView();
            txtLunes = new DataGridViewTextBoxColumn();
            txtMartes = new DataGridViewTextBoxColumn();
            txtMiercoles = new DataGridViewTextBoxColumn();
            txtJueves = new DataGridViewTextBoxColumn();
            txtViernes = new DataGridViewTextBoxColumn();
            txtSabado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            bindingSourceSubjects = new BindingSource(components);
            bindingSourceSchedule = new BindingSource(components);
            toolTipGeneral = new ToolTip(components);
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).BeginInit();
            panelCenter.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedules).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSchedule).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(44, 47, 51);
            panelLeft.Controls.Add(btnInfo);
            panelLeft.Controls.Add(lblAnio);
            panelLeft.Controls.Add(dataGridViewSubjects);
            panelLeft.Controls.Add(comboBoxYear);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(319, 730);
            panelLeft.TabIndex = 0;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.White;
            btnInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInfo.Location = new Point(281, 9);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(30, 30);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "?";
            toolTipGeneral.SetToolTip(btnInfo, resources.GetString("btnInfo.ToolTip"));
            btnInfo.UseVisualStyleBackColor = false;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblAnio.ForeColor = Color.Transparent;
            lblAnio.Location = new Point(12, 13);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(157, 23);
            lblAnio.TabIndex = 4;
            lblAnio.Text = "Seleccione un año:";
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.AllowDrop = true;
            dataGridViewSubjects.AllowUserToAddRows = false;
            dataGridViewSubjects.AllowUserToDeleteRows = false;
            dataGridViewSubjects.AllowUserToResizeColumns = false;
            dataGridViewSubjects.AutoGenerateColumns = false;
            dataGridViewSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubjects.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewSubjects.BorderStyle = BorderStyle.None;
            dataGridViewSubjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewSubjects.DataSource = subjectBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSubjects.EnableHeadersVisualStyles = false;
            dataGridViewSubjects.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewSubjects.Location = new Point(12, 42);
            dataGridViewSubjects.MultiSelect = false;
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSubjects.RowHeadersVisible = false;
            dataGridViewSubjects.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSubjects.RowTemplate.Height = 50;
            dataGridViewSubjects.ShowCellToolTips = false;
            dataGridViewSubjects.Size = new Size(299, 660);
            dataGridViewSubjects.TabIndex = 1;
            dataGridViewSubjects.MouseMove += dataGridViewSubjectsByYear_MouseMove;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Materias";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectBindingSource
            // 
            subjectBindingSource.DataSource = typeof(Model.Subject);
            // 
            // comboBoxYear
            // 
            comboBoxYear.BackColor = Color.FromArgb(44, 47, 51);
            comboBoxYear.FlatStyle = FlatStyle.Flat;
            comboBoxYear.Font = new Font("Segoe UI", 12F);
            comboBoxYear.ForeColor = Color.WhiteSmoke;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBoxYear.Location = new Point(172, 3);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(103, 36);
            comboBoxYear.TabIndex = 0;
            comboBoxYear.SelectedValueChanged += comboBoxYear_SelectedValueChanged;
            // 
            // labelCareerName
            // 
            labelCareerName.Font = new Font("Segoe UI", 12F);
            labelCareerName.ForeColor = Color.FromArgb(255, 152, 0);
            labelCareerName.Location = new Point(12, 0);
            labelCareerName.Name = "labelCareerName";
            labelCareerName.Size = new Size(870, 28);
            labelCareerName.TabIndex = 6;
            labelCareerName.Text = "Carrera";
            labelCareerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCenter
            // 
            panelCenter.BackColor = SystemColors.InactiveCaption;
            panelCenter.Controls.Add(panel2);
            panelCenter.Controls.Add(panel1);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 0);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(1582, 761);
            panelCenter.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBoxError);
            panel2.Controls.Add(dataGridViewSchedules);
            panel2.Controls.Add(panelLeft);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(1582, 730);
            panel2.TabIndex = 8;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Anchor = AnchorStyles.None;
            pictureBoxError.BackColor = Color.FromArgb(44, 47, 51);
            pictureBoxError.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxError.Location = new Point(842, 217);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(300, 300);
            pictureBoxError.TabIndex = 7;
            pictureBoxError.TabStop = false;
            toolTipGeneral.SetToolTip(pictureBoxError, "Si una carrera no tiene un turno, no es posible modificar el\r\nCronograma");
            pictureBoxError.Visible = false;
            // 
            // dataGridViewSchedules
            // 
            dataGridViewSchedules.AllowDrop = true;
            dataGridViewSchedules.AllowUserToDeleteRows = false;
            dataGridViewSchedules.AllowUserToResizeColumns = false;
            dataGridViewSchedules.AllowUserToResizeRows = false;
            dataGridViewSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSchedules.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewSchedules.BorderStyle = BorderStyle.None;
            dataGridViewSchedules.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewSchedules.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSchedules.ColumnHeadersHeight = 30;
            dataGridViewSchedules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSchedules.Columns.AddRange(new DataGridViewColumn[] { txtLunes, txtMartes, txtMiercoles, txtJueves, txtViernes, txtSabado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 7.8F);
            dataGridViewCellStyle6.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedules.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewSchedules.Dock = DockStyle.Fill;
            dataGridViewSchedules.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewSchedules.EnableHeadersVisualStyles = false;
            dataGridViewSchedules.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewSchedules.Location = new Point(319, 0);
            dataGridViewSchedules.Name = "dataGridViewSchedules";
            dataGridViewSchedules.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle7.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewSchedules.RowHeadersWidth = 100;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedules.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewSchedules.RowTemplate.Height = 200;
            dataGridViewSchedules.RowTemplate.ReadOnly = true;
            dataGridViewSchedules.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewSchedules.ShowCellToolTips = false;
            dataGridViewSchedules.Size = new Size(1263, 730);
            dataGridViewSchedules.TabIndex = 1;
            dataGridViewSchedules.DragDrop += dataGridViewSchedules_DragDrop;
            dataGridViewSchedules.DragEnter += dataGridViewSchedules_DragEnter;
            dataGridViewSchedules.KeyDown += dataGridViewSchedules_KeyDown;
            // 
            // txtLunes
            // 
            txtLunes.HeaderText = "Lunes";
            txtLunes.MinimumWidth = 6;
            txtLunes.Name = "txtLunes";
            // 
            // txtMartes
            // 
            txtMartes.HeaderText = "Martes";
            txtMartes.MinimumWidth = 6;
            txtMartes.Name = "txtMartes";
            // 
            // txtMiercoles
            // 
            txtMiercoles.HeaderText = "Miercoles";
            txtMiercoles.MinimumWidth = 6;
            txtMiercoles.Name = "txtMiercoles";
            // 
            // txtJueves
            // 
            txtJueves.HeaderText = "Jueves";
            txtJueves.MinimumWidth = 6;
            txtJueves.Name = "txtJueves";
            // 
            // txtViernes
            // 
            txtViernes.HeaderText = "Viernes";
            txtViernes.MinimumWidth = 6;
            txtViernes.Name = "txtViernes";
            // 
            // txtSabado
            // 
            txtSabado.HeaderText = "Sabado";
            txtSabado.MinimumWidth = 6;
            txtSabado.Name = "txtSabado";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 47, 51);
            panel1.Controls.Add(labelCareerName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1582, 31);
            panel1.TabIndex = 7;
            // 
            // toolTipGeneral
            // 
            toolTipGeneral.AutomaticDelay = 0;
            toolTipGeneral.AutoPopDelay = 0;
            toolTipGeneral.InitialDelay = 0;
            toolTipGeneral.IsBalloon = true;
            toolTipGeneral.ReshowDelay = 100;
            // 
            // formSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 761);
            Controls.Add(panelCenter);
            Font = new Font("Segoe UI", 9F);
            Name = "formSchedule";
            Text = "Gestin - Cronograma";
            FormClosing += formSchedule_FormClosing;
            Load += formSchedule_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).EndInit();
            panelCenter.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedules).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelCenter;
        private DataGridView dataGridViewSubjects;
        private ComboBox comboBoxYear;
        private DataGridView dataGridViewSchedules;
        private BindingSource bindingSourceSubjects;
        private BindingSource bindingSourceSchedule;
        private BindingSource subjectBindingSource;
        private DataGridViewTextBoxColumn txtLunes;
        private DataGridViewTextBoxColumn txtMartes;
        private DataGridViewTextBoxColumn txtMiercoles;
        private DataGridViewTextBoxColumn txtJueves;
        private DataGridViewTextBoxColumn txtViernes;
        private DataGridViewTextBoxColumn txtSabado;
        private Label lblAnio;
        private Button btnInfo;
        private ToolTip toolTipGeneral;
        private Label labelCareerName;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBoxError;
    }
}