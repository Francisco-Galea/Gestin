using static Gestin.Properties.Resources;

namespace Gestin.UI.Home.Subjects
{
    partial class formSubject
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            bindingSourceCareers = new BindingSource(components);
            bindingSourceCareerSubjects = new BindingSource(components);
            teacherSubjectBindingSource = new BindingSource(components);
            lableTimer = new System.Windows.Forms.Timer(components);
            dataGridViewSubjects = new DataGridView();
            subjectBindingSource1 = new BindingSource(components);
            subjectBindingSource = new BindingSource(components);
            panelGrid = new Panel();
            panelCombo = new Panel();
            lblSelectedSubjectName = new Label();
            cbbCareerSelector = new ComboBox();
            lblCarrer = new Label();
            lblSelectedSubjectText = new Label();
            lblResult = new Label();
            btnRemove = new Button();
            btnInsert = new Button();
            txtTotalHourCount = new TextBox();
            txtName = new TextBox();
            lbWorkload = new Label();
            lblAnioCarrera = new Label();
            lblNombre = new Label();
            cbbSubjectYear = new ComboBox();
            btnUpdate = new Button();
            dataGridViewTeachers = new DataGridView();
            Condition = new DataGridViewTextBoxColumn();
            txtCupof = new TextBox();
            label1 = new Label();
            dataGridViewCorrelatives = new DataGridView();
            correlativeBindingSource = new BindingSource(components);
            panelInfo = new Panel();
            CorrelativeSubject = new DataGridViewTextBoxColumn();
            toolTip = new ToolTip(components);
            Cupof = new DataGridViewTextBoxColumn();
            contextMenuSubjects = new ContextMenuStrip(components);
            informeDeCatedraToolStripMenuItem = new ToolStripMenuItem();
            assistanceToolStripMenuItem = new ToolStripMenuItem();
            correlativasToolStripMenuItem = new ToolStripMenuItem();
            docentesToolStripMenuItem = new ToolStripMenuItem();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnCareerId = new DataGridViewTextBoxColumn();
            yearInCareerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cupofDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumnAnnualHourlyLoad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCareers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCareerSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherSubjectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).BeginInit();
            panelGrid.SuspendLayout();
            panelCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCorrelatives).BeginInit();
            ((System.ComponentModel.ISupportInitialize)correlativeBindingSource).BeginInit();
            panelInfo.SuspendLayout();
            contextMenuSubjects.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CareerId";
            dataGridViewTextBoxColumn2.HeaderText = "CareerId";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 144;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            dataGridViewTextBoxColumn3.HeaderText = "Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 181;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "YearInCareer";
            dataGridViewTextBoxColumn4.HeaderText = "YearInCareer";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 241;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "AnnualHourlyLoad";
            dataGridViewTextBoxColumn5.HeaderText = "AnnualHourlyLoad";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 360;
            // 
            // lableTimer
            // 
            lableTimer.Tick += labelTimer_Tick;
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.AllowUserToAddRows = false;
            dataGridViewSubjects.AllowUserToDeleteRows = false;
            dataGridViewSubjects.AllowUserToResizeRows = false;
            dataGridViewSubjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSubjects.ColumnHeadersHeight = 30;
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSubjects.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataGridViewTextBoxColumnCareerId, yearInCareerDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, cupofDataGridViewTextBoxColumn, dataGridViewTextBoxColumnAnnualHourlyLoad });
            dataGridViewSubjects.DataSource = subjectBindingSource1;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewSubjects.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSubjects.EnableHeadersVisualStyles = false;
            dataGridViewSubjects.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewSubjects.Location = new Point(-4, 124);
            dataGridViewSubjects.Margin = new Padding(4);
            dataGridViewSubjects.MultiSelect = false;
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewSubjects.RowHeadersVisible = false;
            dataGridViewSubjects.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewSubjects.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubjects.ShowCellToolTips = false;
            dataGridViewSubjects.Size = new Size(1924, 506);
            dataGridViewSubjects.TabIndex = 31;
            dataGridViewSubjects.CellContentClick += dataGridViewSubjects_CellContentClick;
            dataGridViewSubjects.ColumnHeaderMouseClick += dataGridViewSubjects_ColumnOrderByClick;
            dataGridViewSubjects.SelectionChanged += dataGridViewSubjects_SelectionChanged;
            dataGridViewSubjects.KeyDown += dataGridViewSubjects_KeyDown;
            dataGridViewSubjects.MouseClick += dataGridViewSubjects_MouseClick;
            // 
            // subjectBindingSource1
            // 
            subjectBindingSource1.DataSource = typeof(Model.Subject);
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(panelCombo);
            panelGrid.Controls.Add(dataGridViewSubjects);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 0);
            panelGrid.Margin = new Padding(4);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1924, 642);
            panelGrid.TabIndex = 40;
            // 
            // panelCombo
            // 
            panelCombo.BackColor = Color.FromArgb(44, 47, 51);
            panelCombo.Controls.Add(lblSelectedSubjectName);
            panelCombo.Controls.Add(cbbCareerSelector);
            panelCombo.Controls.Add(lblCarrer);
            panelCombo.Controls.Add(lblSelectedSubjectText);
            panelCombo.Dock = DockStyle.Top;
            panelCombo.Font = new Font("Segoe UI", 10F);
            panelCombo.ForeColor = SystemColors.ControlDarkDark;
            panelCombo.Location = new Point(0, 0);
            panelCombo.Margin = new Padding(4);
            panelCombo.Name = "panelCombo";
            panelCombo.Size = new Size(1924, 131);
            panelCombo.TabIndex = 30;
            // 
            // lblSelectedSubjectName
            // 
            lblSelectedSubjectName.BackColor = Color.FromArgb(44, 47, 51);
            lblSelectedSubjectName.Font = new Font("Segoe UI", 12F);
            lblSelectedSubjectName.ForeColor = Color.FromArgb(255, 152, 0);
            lblSelectedSubjectName.Location = new Point(278, 79);
            lblSelectedSubjectName.Margin = new Padding(4, 0, 4, 0);
            lblSelectedSubjectName.Name = "lblSelectedSubjectName";
            lblSelectedSubjectName.Size = new Size(930, 41);
            lblSelectedSubjectName.TabIndex = 58;
            // 
            // cbbCareerSelector
            // 
            cbbCareerSelector.BackColor = Color.FromArgb(44, 47, 51);
            cbbCareerSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCareerSelector.FlatStyle = FlatStyle.Flat;
            cbbCareerSelector.Font = new Font("Segoe UI", 10F);
            cbbCareerSelector.ForeColor = Color.White;
            cbbCareerSelector.FormattingEnabled = true;
            cbbCareerSelector.Location = new Point(302, 21);
            cbbCareerSelector.Margin = new Padding(4);
            cbbCareerSelector.Name = "cbbCareerSelector";
            cbbCareerSelector.Size = new Size(928, 36);
            cbbCareerSelector.TabIndex = 0;
            cbbCareerSelector.SelectedIndexChanged += cbbCareerSelector_SelectedIndexChanged;
            // 
            // lblCarrer
            // 
            lblCarrer.AutoSize = true;
            lblCarrer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCarrer.ForeColor = Color.WhiteSmoke;
            lblCarrer.Location = new Point(18, 21);
            lblCarrer.Margin = new Padding(4, 0, 4, 0);
            lblCarrer.Name = "lblCarrer";
            lblCarrer.Size = new Size(265, 31);
            lblCarrer.TabIndex = 29;
            lblCarrer.Text = "Seleccione una carrera :";
            // 
            // lblSelectedSubjectText
            // 
            lblSelectedSubjectText.AutoSize = true;
            lblSelectedSubjectText.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblSelectedSubjectText.ForeColor = Color.WhiteSmoke;
            lblSelectedSubjectText.Location = new Point(18, 79);
            lblSelectedSubjectText.Margin = new Padding(4, 0, 4, 0);
            lblSelectedSubjectText.Name = "lblSelectedSubjectText";
            lblSelectedSubjectText.Size = new Size(245, 31);
            lblSelectedSubjectText.TabIndex = 37;
            lblSelectedSubjectText.Text = "Materia seleccionada:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Crimson;
            lblResult.Font = new Font("Microsoft Sans Serif", 16F);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(600, 242);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(207, 37);
            lblResult.TabIndex = 57;
            lblResult.Text = "Success Text";
            lblResult.Visible = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(244, 67, 54);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(389, 231);
            btnRemove.Margin = new Padding(4, 5, 4, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(186, 50);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Dar de baja materia";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(0, 150, 136);
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 12F);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(219, 231);
            btnInsert.Margin = new Padding(4, 5, 4, 5);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(164, 50);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Crear Materia";
            toolTip.SetToolTip(btnInsert, "Este botón crea una nueva materia con los datos visualizados");
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtTotalHourCount
            // 
            txtTotalHourCount.BackColor = Color.FromArgb(44, 47, 51);
            txtTotalHourCount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalHourCount.Font = new Font("Segoe UI", 10F);
            txtTotalHourCount.ForeColor = Color.White;
            txtTotalHourCount.Location = new Point(254, 69);
            txtTotalHourCount.Margin = new Padding(4, 5, 4, 5);
            txtTotalHourCount.Name = "txtTotalHourCount";
            txtTotalHourCount.Size = new Size(100, 34);
            txtTotalHourCount.TabIndex = 3;
            txtTotalHourCount.KeyPress += txtTotalHourCount_KeyPress;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(44, 47, 51);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(134, 9);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(641, 34);
            txtName.TabIndex = 1;
            // 
            // lbWorkload
            // 
            lbWorkload.AutoSize = true;
            lbWorkload.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lbWorkload.ForeColor = Color.WhiteSmoke;
            lbWorkload.Location = new Point(6, 74);
            lbWorkload.Margin = new Padding(4, 0, 4, 0);
            lbWorkload.Name = "lbWorkload";
            lbWorkload.Size = new Size(235, 31);
            lbWorkload.TabIndex = 21;
            lbWorkload.Text = "Carga horaria anual :";
            // 
            // lblAnioCarrera
            // 
            lblAnioCarrera.AutoSize = true;
            lblAnioCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblAnioCarrera.ForeColor = Color.WhiteSmoke;
            lblAnioCarrera.Location = new Point(4, 134);
            lblAnioCarrera.Margin = new Padding(4, 0, 4, 0);
            lblAnioCarrera.Name = "lblAnioCarrera";
            lblAnioCarrera.Size = new Size(188, 31);
            lblAnioCarrera.TabIndex = 20;
            lblAnioCarrera.Text = "Año en carrera : ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.WhiteSmoke;
            lblNombre.Location = new Point(6, 16);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 31);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre : ";
            // 
            // cbbSubjectYear
            // 
            cbbSubjectYear.BackColor = Color.FromArgb(44, 47, 51);
            cbbSubjectYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSubjectYear.FlatStyle = FlatStyle.Flat;
            cbbSubjectYear.Font = new Font("Segoe UI", 10F);
            cbbSubjectYear.ForeColor = Color.White;
            cbbSubjectYear.FormattingEnabled = true;
            cbbSubjectYear.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbbSubjectYear.Location = new Point(219, 134);
            cbbSubjectYear.Margin = new Padding(4);
            cbbSubjectYear.Name = "cbbSubjectYear";
            cbbSubjectYear.Size = new Size(99, 36);
            cbbSubjectYear.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(6, 231);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(204, 50);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Actualizar Materia";
            toolTip.SetToolTip(btnUpdate, "Actualiza los datos en la materia seleccionada");
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.AllowUserToAddRows = false;
            dataGridViewTeachers.AllowUserToDeleteRows = false;
            dataGridViewTeachers.AllowUserToResizeColumns = false;
            dataGridViewTeachers.AutoGenerateColumns = false;
            dataGridViewTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeachers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewTeachers.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewTeachers.BorderStyle = BorderStyle.None;
            dataGridViewTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.Columns.AddRange(new DataGridViewColumn[] { Condition });
            dataGridViewTeachers.DataSource = teacherSubjectBindingSource;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle9.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewTeachers.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTeachers.EnableHeadersVisualStyles = false;
            dataGridViewTeachers.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewTeachers.Location = new Point(1382, 4);
            dataGridViewTeachers.Margin = new Padding(4);
            dataGridViewTeachers.MultiSelect = false;
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewTeachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTeachers.RowHeadersVisible = false;
            dataGridViewTeachers.RowHeadersWidth = 51;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle11.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle11.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridViewTeachers.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTeachers.ShowCellToolTips = false;
            dataGridViewTeachers.Size = new Size(401, 225);
            dataGridViewTeachers.TabIndex = 39;
            // 
            // Condition
            // 
            Condition.DataPropertyName = "Condition";
            Condition.FillWeight = 65F;
            Condition.HeaderText = "Condición";
            Condition.MinimumWidth = 6;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            // 
            // txtCupof
            // 
            txtCupof.BackColor = Color.FromArgb(44, 47, 51);
            txtCupof.BorderStyle = BorderStyle.FixedSingle;
            txtCupof.Font = new Font("Segoe UI", 10F);
            txtCupof.ForeColor = Color.White;
            txtCupof.Location = new Point(499, 68);
            txtCupof.Margin = new Padding(4, 5, 4, 5);
            txtCupof.Name = "txtCupof";
            txtCupof.Size = new Size(276, 34);
            txtCupof.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(389, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 42;
            label1.Text = "Cupof : ";
            // 
            // dataGridViewCorrelatives
            // 
            dataGridViewCorrelatives.AllowUserToAddRows = false;
            dataGridViewCorrelatives.AllowUserToDeleteRows = false;
            dataGridViewCorrelatives.AllowUserToResizeColumns = false;
            dataGridViewCorrelatives.AutoGenerateColumns = false;
            dataGridViewCorrelatives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCorrelatives.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCorrelatives.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewCorrelatives.BorderStyle = BorderStyle.None;
            dataGridViewCorrelatives.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle12.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewCorrelatives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCorrelatives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCorrelatives.DataSource = correlativeBindingSource;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle13.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle13.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridViewCorrelatives.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCorrelatives.EnableHeadersVisualStyles = false;
            dataGridViewCorrelatives.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewCorrelatives.Location = new Point(799, 4);
            dataGridViewCorrelatives.Margin = new Padding(4);
            dataGridViewCorrelatives.MultiSelect = false;
            dataGridViewCorrelatives.Name = "dataGridViewCorrelatives";
            dataGridViewCorrelatives.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle14.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle14.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridViewCorrelatives.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCorrelatives.RowHeadersVisible = false;
            dataGridViewCorrelatives.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle15.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle15.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridViewCorrelatives.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCorrelatives.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCorrelatives.ShowCellToolTips = false;
            dataGridViewCorrelatives.Size = new Size(576, 225);
            dataGridViewCorrelatives.TabIndex = 43;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(44, 47, 51);
            panelInfo.Controls.Add(dataGridViewCorrelatives);
            panelInfo.Controls.Add(lblResult);
            panelInfo.Controls.Add(label1);
            panelInfo.Controls.Add(txtCupof);
            panelInfo.Controls.Add(btnRemove);
            panelInfo.Controls.Add(dataGridViewTeachers);
            panelInfo.Controls.Add(btnUpdate);
            panelInfo.Controls.Add(cbbSubjectYear);
            panelInfo.Controls.Add(lblNombre);
            panelInfo.Controls.Add(lblAnioCarrera);
            panelInfo.Controls.Add(lbWorkload);
            panelInfo.Controls.Add(txtName);
            panelInfo.Controls.Add(txtTotalHourCount);
            panelInfo.Controls.Add(btnInsert);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            panelInfo.Location = new Point(0, 642);
            panelInfo.Margin = new Padding(4);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1924, 294);
            panelInfo.TabIndex = 39;
            // 
            // CorrelativeSubject
            // 
            CorrelativeSubject.DataPropertyName = "CorrelativeSubject";
            CorrelativeSubject.HeaderText = "Materias Correlativas";
            CorrelativeSubject.MinimumWidth = 6;
            CorrelativeSubject.Name = "CorrelativeSubject";
            CorrelativeSubject.Width = 30;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 0;
            toolTip.AutoPopDelay = 0;
            toolTip.ForeColor = Color.Black;
            toolTip.InitialDelay = 0;
            toolTip.IsBalloon = true;
            toolTip.ReshowDelay = 100;
            // 
            // Cupof
            // 
            Cupof.DataPropertyName = "Cupof";
            Cupof.FillWeight = 14F;
            Cupof.HeaderText = "Cupof";
            Cupof.MinimumWidth = 6;
            Cupof.Name = "Cupof";
            Cupof.Width = 11;
            // 
            // contextMenuSubjects
            // 
            contextMenuSubjects.BackColor = Color.FromArgb(44, 47, 51);
            contextMenuSubjects.Font = new Font("Segoe UI", 10.2F);
            contextMenuSubjects.ImageScalingSize = new Size(20, 20);
            contextMenuSubjects.Items.AddRange(new ToolStripItem[] { informeDeCatedraToolStripMenuItem, assistanceToolStripMenuItem, correlativasToolStripMenuItem, docentesToolStripMenuItem });
            contextMenuSubjects.Name = "contextMenuStrip1";
            contextMenuSubjects.RenderMode = ToolStripRenderMode.Professional;
            contextMenuSubjects.Size = new Size(267, 148);
            contextMenuSubjects.ItemClicked += contextMenuSubjects_ItemClicked;
            // 
            // informeDeCatedraToolStripMenuItem
            // 
            informeDeCatedraToolStripMenuItem.ForeColor = Color.White;
            informeDeCatedraToolStripMenuItem.Name = "informeDeCatedraToolStripMenuItem";
            informeDeCatedraToolStripMenuItem.Size = new Size(266, 36);
            informeDeCatedraToolStripMenuItem.Text = "Informe de Cátedra";
            // 
            // assistanceToolStripMenuItem
            // 
            assistanceToolStripMenuItem.ForeColor = Color.White;
            assistanceToolStripMenuItem.Name = "assistanceToolStripMenuItem";
            assistanceToolStripMenuItem.Size = new Size(266, 36);
            assistanceToolStripMenuItem.Text = "Asistencias";
            // 
            // correlativasToolStripMenuItem
            // 
            correlativasToolStripMenuItem.ForeColor = Color.White;
            correlativasToolStripMenuItem.Name = "correlativasToolStripMenuItem";
            correlativasToolStripMenuItem.Size = new Size(266, 36);
            correlativasToolStripMenuItem.Text = "Correlativas";
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.ForeColor = Color.White;
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(266, 36);
            docentesToolStripMenuItem.Text = "Docentes";
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
            // dataGridViewTextBoxColumnCareerId
            // 
            dataGridViewTextBoxColumnCareerId.DataPropertyName = "Careerld";
            dataGridViewTextBoxColumnCareerId.HeaderText = "CareerId";
            dataGridViewTextBoxColumnCareerId.MinimumWidth = 6;
            dataGridViewTextBoxColumnCareerId.Name = "dataGridViewTextBoxColumnCareerId";
            dataGridViewTextBoxColumnCareerId.ReadOnly = true;
            dataGridViewTextBoxColumnCareerId.Visible = false;
            // 
            // yearInCareerDataGridViewTextBoxColumn
            // 
            yearInCareerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            yearInCareerDataGridViewTextBoxColumn.DataPropertyName = "YearInCareer";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            yearInCareerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            yearInCareerDataGridViewTextBoxColumn.FillWeight = 0.0129032694F;
            yearInCareerDataGridViewTextBoxColumn.HeaderText = "Año";
            yearInCareerDataGridViewTextBoxColumn.MinimumWidth = 8;
            yearInCareerDataGridViewTextBoxColumn.Name = "yearInCareerDataGridViewTextBoxColumn";
            yearInCareerDataGridViewTextBoxColumn.ReadOnly = true;
            yearInCareerDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            yearInCareerDataGridViewTextBoxColumn.Width = 91;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 0.103030764F;
            nameDataGridViewTextBoxColumn.HeaderText = "Materia";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupofDataGridViewTextBoxColumn
            // 
            cupofDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cupofDataGridViewTextBoxColumn.DataPropertyName = "Cupof";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cupofDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            cupofDataGridViewTextBoxColumn.FillWeight = 270.22995F;
            cupofDataGridViewTextBoxColumn.HeaderText = "Cupof";
            cupofDataGridViewTextBoxColumn.MinimumWidth = 8;
            cupofDataGridViewTextBoxColumn.Name = "cupofDataGridViewTextBoxColumn";
            cupofDataGridViewTextBoxColumn.ReadOnly = true;
            cupofDataGridViewTextBoxColumn.Width = 113;
            // 
            // dataGridViewTextBoxColumnAnnualHourlyLoad
            // 
            dataGridViewTextBoxColumnAnnualHourlyLoad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumnAnnualHourlyLoad.DataPropertyName = "AnnualHourlyLoad";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTextBoxColumnAnnualHourlyLoad.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumnAnnualHourlyLoad.FillWeight = 38.4883423F;
            dataGridViewTextBoxColumnAnnualHourlyLoad.HeaderText = "Carga Horaria Anual";
            dataGridViewTextBoxColumnAnnualHourlyLoad.MinimumWidth = 6;
            dataGridViewTextBoxColumnAnnualHourlyLoad.Name = "dataGridViewTextBoxColumnAnnualHourlyLoad";
            dataGridViewTextBoxColumnAnnualHourlyLoad.ReadOnly = true;
            dataGridViewTextBoxColumnAnnualHourlyLoad.Width = 261;
            // 
            // formSubject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(1924, 936);
            Controls.Add(panelGrid);
            Controls.Add(panelInfo);
            Margin = new Padding(4);
            Name = "formSubject";
            Text = "Gestin - Materias";
            Load += formSubject_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCareers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCareerSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherSubjectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).EndInit();
            panelGrid.ResumeLayout(false);
            panelCombo.ResumeLayout(false);
            panelCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCorrelatives).EndInit();
            ((System.ComponentModel.ISupportInitialize)correlativeBindingSource).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            contextMenuSubjects.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSourceCareers;
        private BindingSource bindingSourceCareerSubjects;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource subjectBindingSource;
        private BindingSource teacherSubjectBindingSource;
        private System.Windows.Forms.Timer lableTimer;
        private DataGridView dataGridViewSubjects;
        private Panel panelGrid;
        private Label lblCarrer;
        private ComboBox cbbCareerSelector;
        private Panel panelCombo;
        private BindingSource correlativeBindingSource;
        private Label lblResult;
        private Button btnInsert;
        private TextBox txtTotalHourCount;
        private TextBox txtName;
        private Label lbWorkload;
        private Label lblSelectedSubjectText;
        private Label lblAnioCarrera;
        private Label lblNombre;
        private ComboBox cbbSubjectYear;
        private Button btnUpdate;
        private DataGridView dataGridViewTeachers;
        private Button btnRemove;
        private TextBox txtCupof;
        private Label label1;
        private DataGridView dataGridViewCorrelatives;
        private Panel panelInfo;
        private DataGridViewTextBoxColumn CorrelativeSubject;
        private Label lblSelectedSubjectName;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn correlativeSubjectDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn correlativeFinalDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn Cupof;
        private DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Condition;
        private ContextMenuStrip contextMenuSubjects;
        private ToolStripMenuItem informeDeCatedra;
        private ToolStripMenuItem correlativasToolStrip;
        private ToolStripMenuItem docentesToolStripMenuItem;
        private ToolStripMenuItem informeDeCatedraToolStripMenuItem;
        private ToolStripMenuItem correlativasToolStripMenuItem;
        private ToolStripMenuItem assistanceToolStripMenuItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnYearInCareer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumnCupOf;
        private BindingSource subjectBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCareerId;
        private DataGridViewTextBoxColumn yearInCareerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cupofDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnAnnualHourlyLoad;
    }
}