namespace Gestin.UI.Home.Subjects
{
    partial class formSubjectTeachers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSubjectTeachers));
            lblmateriaName = new Label();
            label1 = new Label();
            dataGridViewTeachers = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            teacherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            Active = new DataGridViewCheckBoxColumn();
            DateSince = new DataGridViewTextBoxColumn();
            DateUntil = new DataGridViewTextBoxColumn();
            teacherSubjectBindingSource = new BindingSource(components);
            teacherBindingSource = new BindingSource(components);
            bindingSourceTeachersSubject = new BindingSource(components);
            bindingSourceTeachers = new BindingSource(components);
            txtSearchbar = new TextBox();
            label3 = new Label();
            lblteachername = new Label();
            ListboxSearchResults = new ListBox();
            cmbCondition = new ComboBox();
            btnInsert = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnModifyUntil = new Button();
            dateTimePickerSince = new DateTimePicker();
            dateTimePickerUntil = new DateTimePicker();
            label8 = new Label();
            InfoPanel = new Panel();
            chkInactive = new CheckBox();
            panelSearchBack = new Panel();
            GridPanel = new Panel();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherSubjectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachersSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachers).BeginInit();
            InfoPanel.SuspendLayout();
            panelSearchBack.SuspendLayout();
            GridPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblmateriaName
            // 
            lblmateriaName.AutoSize = true;
            lblmateriaName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblmateriaName.ForeColor = Color.FromArgb(255, 152, 0);
            lblmateriaName.Location = new Point(610, 18);
            lblmateriaName.Name = "lblmateriaName";
            lblmateriaName.Size = new Size(117, 25);
            lblmateriaName.TabIndex = 57;
            lblmateriaName.Text = "MateriaAqui";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(406, 15);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 56;
            label1.Text = "Materia Seleccionada: ";
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.AllowUserToAddRows = false;
            dataGridViewTeachers.AllowUserToDeleteRows = false;
            dataGridViewTeachers.AllowUserToResizeColumns = false;
            dataGridViewTeachers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(54, 57, 63);
            dataGridViewTeachers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTeachers.AutoGenerateColumns = false;
            dataGridViewTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeachers.BackgroundColor = Color.FromArgb(35, 39, 42);
            dataGridViewTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTeachers.ColumnHeadersHeight = 54;
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewTeachers.Columns.AddRange(new DataGridViewColumn[] { Id, teacherDataGridViewTextBoxColumn, Condition, Active, DateSince, DateUntil });
            dataGridViewTeachers.DataSource = teacherSubjectBindingSource;
            dataGridViewTeachers.Dock = DockStyle.Fill;
            dataGridViewTeachers.EnableHeadersVisualStyles = false;
            dataGridViewTeachers.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewTeachers.Location = new Point(0, 0);
            dataGridViewTeachers.MultiSelect = false;
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.ReadOnly = true;
            dataGridViewTeachers.RowHeadersVisible = false;
            dataGridViewTeachers.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 39, 42);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewTeachers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTeachers.RowTemplate.Height = 60;
            dataGridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTeachers.ShowCellToolTips = false;
            dataGridViewTeachers.Size = new Size(1306, 448);
            dataGridViewTeachers.TabIndex = 7;
            dataGridViewTeachers.CellContentClick += dataGridViewTeachers_CellContentClick;
            dataGridViewTeachers.SelectionChanged += dataGridViewTeachers_SelectionChanged;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            teacherDataGridViewTextBoxColumn.FillWeight = 140F;
            teacherDataGridViewTextBoxColumn.HeaderText = "Docente";
            teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            teacherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Condition
            // 
            Condition.DataPropertyName = "Condition";
            Condition.HeaderText = "Condición";
            Condition.MinimumWidth = 6;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            // 
            // Active
            // 
            Active.DataPropertyName = "Active";
            Active.FillWeight = 80F;
            Active.HeaderText = "Activo";
            Active.MinimumWidth = 6;
            Active.Name = "Active";
            Active.ReadOnly = true;
            // 
            // DateSince
            // 
            DateSince.DataPropertyName = "DateSince";
            DateSince.FillWeight = 90F;
            DateSince.HeaderText = "Fecha Desde";
            DateSince.MinimumWidth = 6;
            DateSince.Name = "DateSince";
            DateSince.ReadOnly = true;
            // 
            // DateUntil
            // 
            DateUntil.DataPropertyName = "DateUntil";
            DateUntil.FillWeight = 90F;
            DateUntil.HeaderText = "Fecha Hasta";
            DateUntil.MinimumWidth = 6;
            DateUntil.Name = "DateUntil";
            DateUntil.ReadOnly = true;
            // 
            // teacherSubjectBindingSource
            // 
            teacherSubjectBindingSource.DataSource = typeof(Model.TeacherSubject);
            // 
            // teacherBindingSource
            // 
            teacherBindingSource.DataSource = typeof(Model.Teacher);
            // 
            // txtSearchbar
            // 
            txtSearchbar.BackColor = Color.FromArgb(35, 39, 42);
            txtSearchbar.ForeColor = Color.White;
            txtSearchbar.Location = new Point(10, 38);
            txtSearchbar.Name = "txtSearchbar";
            txtSearchbar.Size = new Size(348, 27);
            txtSearchbar.TabIndex = 1;
            txtSearchbar.TextChanged += txtSearchbar_TextChanged;
            txtSearchbar.KeyDown += txtSearchbar_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(406, 83);
            label3.Name = "label3";
            label3.Size = new Size(160, 18);
            label3.TabIndex = 61;
            label3.Text = "Docente seleccionado:";
            // 
            // lblteachername
            // 
            lblteachername.BackColor = Color.FromArgb(35, 39, 42);
            lblteachername.ForeColor = Color.White;
            lblteachername.Location = new Point(586, 76);
            lblteachername.Name = "lblteachername";
            lblteachername.Size = new Size(150, 28);
            lblteachername.TabIndex = 62;
            lblteachername.Text = " ";
            // 
            // ListboxSearchResults
            // 
            ListboxSearchResults.BackColor = Color.FromArgb(35, 39, 42);
            ListboxSearchResults.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ListboxSearchResults.ForeColor = Color.White;
            ListboxSearchResults.FormattingEnabled = true;
            ListboxSearchResults.ItemHeight = 18;
            ListboxSearchResults.Location = new Point(-2, -2);
            ListboxSearchResults.Name = "ListboxSearchResults";
            ListboxSearchResults.Size = new Size(348, 148);
            ListboxSearchResults.TabIndex = 2;
            ListboxSearchResults.Click += ListboxSearchResults_Click;
            ListboxSearchResults.KeyDown += ListboxSearchResults_KeyDown;
            // 
            // cmbCondition
            // 
            cmbCondition.BackColor = Color.FromArgb(35, 39, 42);
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.FlatStyle = FlatStyle.Flat;
            cmbCondition.ForeColor = Color.White;
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Items.AddRange(new object[] { "Titular", "Suplente", "Provisional" });
            cmbCondition.Location = new Point(586, 134);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(150, 28);
            cmbCondition.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(0, 150, 136);
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(534, 192);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(202, 34);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Activar Nuevo Docente";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(406, 138);
            label4.Name = "label4";
            label4.Size = new Size(146, 18);
            label4.TabIndex = 66;
            label4.Text = "Situación de Revista:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(789, 83);
            label5.Name = "label5";
            label5.Size = new Size(95, 18);
            label5.TabIndex = 68;
            label5.Text = "Fecha Inicio: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(789, 138);
            label6.Name = "label6";
            label6.Size = new Size(92, 18);
            label6.TabIndex = 69;
            label6.Text = "Fecha Cese:";
            // 
            // btnModifyUntil
            // 
            btnModifyUntil.BackColor = Color.FromArgb(0, 150, 136);
            btnModifyUntil.FlatStyle = FlatStyle.Flat;
            btnModifyUntil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifyUntil.ForeColor = Color.White;
            btnModifyUntil.Location = new Point(902, 192);
            btnModifyUntil.Name = "btnModifyUntil";
            btnModifyUntil.Size = new Size(155, 34);
            btnModifyUntil.TabIndex = 6;
            btnModifyUntil.Text = "Modificar Fechas";
            btnModifyUntil.UseVisualStyleBackColor = false;
            btnModifyUntil.Click += btnModifyDates_Click;
            // 
            // dateTimePickerSince
            // 
            dateTimePickerSince.Format = DateTimePickerFormat.Short;
            dateTimePickerSince.Location = new Point(907, 74);
            dateTimePickerSince.Name = "dateTimePickerSince";
            dateTimePickerSince.Size = new Size(150, 27);
            dateTimePickerSince.TabIndex = 74;
            dateTimePickerSince.Value = new DateTime(2022, 10, 27, 18, 45, 8, 0);
            // 
            // dateTimePickerUntil
            // 
            dateTimePickerUntil.Format = DateTimePickerFormat.Short;
            dateTimePickerUntil.Location = new Point(907, 132);
            dateTimePickerUntil.Name = "dateTimePickerUntil";
            dateTimePickerUntil.Size = new Size(150, 27);
            dateTimePickerUntil.TabIndex = 75;
            dateTimePickerUntil.Value = new DateTime(2022, 10, 27, 18, 45, 8, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 15);
            label8.Name = "label8";
            label8.Size = new Size(231, 20);
            label8.TabIndex = 76;
            label8.Text = "Ingrese el nombre de un docente:";
            // 
            // InfoPanel
            // 
            InfoPanel.BackColor = Color.FromArgb(44, 47, 51);
            InfoPanel.BorderStyle = BorderStyle.FixedSingle;
            InfoPanel.Controls.Add(chkInactive);
            InfoPanel.Controls.Add(panelSearchBack);
            InfoPanel.Controls.Add(btnModifyUntil);
            InfoPanel.Controls.Add(txtSearchbar);
            InfoPanel.Controls.Add(btnInsert);
            InfoPanel.Controls.Add(dateTimePickerUntil);
            InfoPanel.Controls.Add(dateTimePickerSince);
            InfoPanel.Controls.Add(label8);
            InfoPanel.Controls.Add(cmbCondition);
            InfoPanel.Controls.Add(label6);
            InfoPanel.Controls.Add(label3);
            InfoPanel.Controls.Add(label5);
            InfoPanel.Controls.Add(lblteachername);
            InfoPanel.Controls.Add(label4);
            InfoPanel.Controls.Add(label1);
            InfoPanel.Controls.Add(lblmateriaName);
            InfoPanel.Dock = DockStyle.Bottom;
            InfoPanel.Location = new Point(0, 448);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(1306, 260);
            InfoPanel.TabIndex = 78;
            // 
            // chkInactive
            // 
            chkInactive.AutoSize = true;
            chkInactive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkInactive.ForeColor = Color.White;
            chkInactive.Location = new Point(1100, 107);
            chkInactive.Name = "chkInactive";
            chkInactive.Size = new Size(162, 24);
            chkInactive.TabIndex = 78;
            chkInactive.Text = "Docentes inactivos";
            chkInactive.UseVisualStyleBackColor = true;
            chkInactive.CheckStateChanged += chkInactive_CheckStateChanged;
            // 
            // panelSearchBack
            // 
            panelSearchBack.BackColor = Color.FromArgb(35, 39, 42);
            panelSearchBack.BorderStyle = BorderStyle.Fixed3D;
            panelSearchBack.Controls.Add(ListboxSearchResults);
            panelSearchBack.Location = new Point(10, 83);
            panelSearchBack.Name = "panelSearchBack";
            panelSearchBack.Size = new Size(348, 143);
            panelSearchBack.TabIndex = 77;
            // 
            // GridPanel
            // 
            GridPanel.Controls.Add(dataGridViewTeachers);
            GridPanel.Dock = DockStyle.Fill;
            GridPanel.Location = new Point(0, 0);
            GridPanel.Name = "GridPanel";
            GridPanel.Size = new Size(1306, 448);
            GridPanel.TabIndex = 79;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 0;
            toolTip.ForeColor = Color.Black;
            toolTip.IsBalloon = true;
            // 
            // formSubjectTeachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1306, 708);
            Controls.Add(GridPanel);
            Controls.Add(InfoPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formSubjectTeachers";
            Text = "Gestin - Materia Docentes";
            FormClosing += formSubjectTeachers_FormClosing;
            Load += formSubjectTeachers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherSubjectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachersSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachers).EndInit();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            panelSearchBack.ResumeLayout(false);
            GridPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblmateriaName;
        private Label label1;
        private DataGridView dataGridViewTeachers;
        private BindingSource teacherBindingSource;
        private BindingSource bindingSourceTeachersSubject;
        private BindingSource bindingSourceTeachers;
        private TextBox txtSearchbar;
        private Label label3;
        private Label lblteachername;
        private ListBox ListboxSearchResults;
        private BindingSource teacherSubjectBindingSource;
        private ComboBox cmbCondition;
        private Button btnInsert;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnModifyUntil;
        private DateTimePicker dateTimePickerSince;
        private DateTimePicker dateTimePickerUntil;
        private Label label8;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Condition;
        private DataGridViewCheckBoxColumn Active;
        private DataGridViewTextBoxColumn DateSince;
        private DataGridViewTextBoxColumn DateUntil;
        private Panel InfoPanel;
        private Panel GridPanel;
        private Panel panelSearchBack;
        private ToolTip toolTip;
        private CheckBox chkInactive;
    }
}