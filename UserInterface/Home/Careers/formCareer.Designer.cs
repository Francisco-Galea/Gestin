using Gestin.UI.Custom;
using static Gestin.Properties.Resources;

namespace Gestin.UI.Home.Careers


{
    partial class formCareer
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtResolutionNumber = new TextBox();
            txtName = new TextBox();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbbTurn = new ComboBox();
            lbl4 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            careerBindingSource = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            resolutionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            degreeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BindingSourceCareers = new BindingSource(components);
            lblqcyo = new Label();
            lblcarreraaqui = new Label();
            chkActiveCareer = new BigCheckBox();
            panelInfo = new Panel();
            labelActive = new Label();
            btnSchedule = new Button();
            lblResult = new Label();
            label5 = new Label();
            panelGrid = new Panel();
            dataGridViewCareers = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resolutionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            degreeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            turnDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            TotalAmountSubjects = new DataGridViewTextBoxColumn();
            activeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            labelTimer = new System.Windows.Forms.Timer(components);
            toolTip = new ToolTip(components);
            contextMenuCareers = new ContextMenuStrip(components);
            matriculaToolStripMenuItem = new ToolStripMenuItem();
            promediosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)careerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceCareers).BeginInit();
            panelInfo.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCareers).BeginInit();
            contextMenuCareers.SuspendLayout();
            SuspendLayout();
            // 
            // txtResolutionNumber
            // 
            txtResolutionNumber.BackColor = Color.FromArgb(44, 47, 51);
            txtResolutionNumber.BorderStyle = BorderStyle.FixedSingle;
            txtResolutionNumber.Font = new Font("Segoe UI", 12F);
            txtResolutionNumber.ForeColor = Color.White;
            txtResolutionNumber.Location = new Point(954, 48);
            txtResolutionNumber.Name = "txtResolutionNumber";
            txtResolutionNumber.Size = new Size(125, 34);
            txtResolutionNumber.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(44, 47, 51);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(104, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(724, 34);
            txtName.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(44, 47, 51);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(104, 92);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(560, 34);
            txtTitle.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(835, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 3;
            label1.Text = "Resolución:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 49);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 92);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 5;
            label3.Text = "Titulo:";
            // 
            // cbbTurn
            // 
            cbbTurn.BackColor = Color.FromArgb(44, 47, 51);
            cbbTurn.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTurn.FlatStyle = FlatStyle.Flat;
            cbbTurn.Font = new Font("Segoe UI", 10F);
            cbbTurn.ForeColor = Color.White;
            cbbTurn.FormattingEnabled = true;
            cbbTurn.Items.AddRange(new object[] { "Mañana", "Tarde", "Vespertino" });
            cbbTurn.Location = new Point(745, 95);
            cbbTurn.Name = "cbbTurn";
            cbbTurn.Size = new Size(162, 31);
            cbbTurn.TabIndex = 3;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl4.ForeColor = Color.White;
            lbl4.Location = new Point(672, 93);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(72, 28);
            lbl4.TabIndex = 7;
            lbl4.Text = "Turno:";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(0, 150, 136);
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 12F);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(13, 172);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(103, 40);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Crear Carrera";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(122, 172);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Actualizar Carrera";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // careerBindingSource
            // 
            careerBindingSource.DataSource = typeof(Model.Career);
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            resolutionDataGridViewTextBoxColumn.HeaderText = "Resolución";
            resolutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            resolutionDataGridViewTextBoxColumn.Width = 180;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 225;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            degreeDataGridViewTextBoxColumn.HeaderText = "Titulo";
            degreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            degreeDataGridViewTextBoxColumn.Width = 299;
            // 
            // turnDataGridViewTextBoxColumn
            // 
            turnDataGridViewTextBoxColumn.DataPropertyName = "Turn";
            turnDataGridViewTextBoxColumn.HeaderText = "Turno";
            turnDataGridViewTextBoxColumn.MinimumWidth = 6;
            turnDataGridViewTextBoxColumn.Name = "turnDataGridViewTextBoxColumn";
            turnDataGridViewTextBoxColumn.Width = 449;
            // 
            // lblqcyo
            // 
            lblqcyo.AutoSize = true;
            lblqcyo.ForeColor = Color.White;
            lblqcyo.Location = new Point(1142, 36);
            lblqcyo.Name = "lblqcyo";
            lblqcyo.Size = new Size(150, 20);
            lblqcyo.TabIndex = 15;
            lblqcyo.Text = "Carrera seleccionada:";
            // 
            // lblcarreraaqui
            // 
            lblcarreraaqui.AutoSize = true;
            lblcarreraaqui.ForeColor = Color.White;
            lblcarreraaqui.Location = new Point(371, 36);
            lblcarreraaqui.Name = "lblcarreraaqui";
            lblcarreraaqui.Size = new Size(41, 20);
            lblcarreraaqui.TabIndex = 18;
            lblcarreraaqui.Text = "        ";
            // 
            // chkActiveCareer
            // 
            chkActiveCareer.BackColor = Color.FromArgb(44, 47, 51);
            chkActiveCareer.Checked = true;
            chkActiveCareer.CheckState = CheckState.Checked;
            chkActiveCareer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            chkActiveCareer.ForeColor = Color.White;
            chkActiveCareer.Location = new Point(954, 95);
            chkActiveCareer.Name = "chkActiveCareer";
            chkActiveCareer.Size = new Size(31, 31);
            chkActiveCareer.TabIndex = 4;
            chkActiveCareer.Text = "Approved";
            chkActiveCareer.TextAlign = ContentAlignment.MiddleRight;
            chkActiveCareer.UseVisualStyleBackColor = false;
            chkActiveCareer.MouseHover += chkActivo_MouseHover;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(44, 47, 51);
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(labelActive);
            panelInfo.Controls.Add(btnSchedule);
            panelInfo.Controls.Add(lblResult);
            panelInfo.Controls.Add(cbbTurn);
            panelInfo.Controls.Add(txtResolutionNumber);
            panelInfo.Controls.Add(chkActiveCareer);
            panelInfo.Controls.Add(txtName);
            panelInfo.Controls.Add(label5);
            panelInfo.Controls.Add(txtTitle);
            panelInfo.Controls.Add(label1);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(label3);
            panelInfo.Controls.Add(lbl4);
            panelInfo.Controls.Add(btnInsert);
            panelInfo.Controls.Add(btnUpdate);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(0, 527);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1265, 222);
            panelInfo.TabIndex = 22;
            // 
            // labelActive
            // 
            labelActive.AutoSize = true;
            labelActive.BackColor = Color.FromArgb(44, 47, 51);
            labelActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelActive.ForeColor = Color.White;
            labelActive.Location = new Point(991, 99);
            labelActive.Name = "labelActive";
            labelActive.Size = new Size(144, 28);
            labelActive.TabIndex = 59;
            labelActive.Text = "Carrera activa";
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(0, 150, 136);
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 12F);
            btnSchedule.ForeColor = Color.White;
            btnSchedule.Location = new Point(273, 172);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(169, 40);
            btnSchedule.TabIndex = 58;
            btnSchedule.Text = "Ver Cronograma";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Segoe UI", 18F);
            lblResult.ForeColor = Color.FromArgb(255, 152, 0);
            lblResult.Location = new Point(449, 169);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(182, 41);
            lblResult.TabIndex = 57;
            lblResult.Text = "Success Text";
            lblResult.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(255, 152, 0);
            label5.Location = new Point(2, 9);
            label5.Name = "label5";
            label5.Size = new Size(200, 28);
            label5.TabIndex = 21;
            label5.Text = "Carrera seleccionada: ";
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.FromArgb(44, 47, 51);
            panelGrid.Controls.Add(dataGridViewCareers);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 0);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1265, 527);
            panelGrid.TabIndex = 23;
            // 
            // dataGridViewCareers
            // 
            dataGridViewCareers.AllowUserToAddRows = false;
            dataGridViewCareers.AllowUserToDeleteRows = false;
            dataGridViewCareers.AllowUserToResizeRows = false;
            dataGridViewCareers.AutoGenerateColumns = false;
            dataGridViewCareers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCareers.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewCareers.BorderStyle = BorderStyle.None;
            dataGridViewCareers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCareers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCareers.ColumnHeadersHeight = 54;
            dataGridViewCareers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCareers.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, resolutionDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, degreeDataGridViewTextBoxColumn1, turnDataGridViewTextBoxColumn1, TotalAmountSubjects, activeDataGridViewCheckBoxColumn });
            dataGridViewCareers.DataSource = careerBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewCareers.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCareers.Dock = DockStyle.Fill;
            dataGridViewCareers.EnableHeadersVisualStyles = false;
            dataGridViewCareers.GridColor = Color.FromArgb(0, 150, 136);
            dataGridViewCareers.Location = new Point(0, 0);
            dataGridViewCareers.MultiSelect = false;
            dataGridViewCareers.Name = "dataGridViewCareers";
            dataGridViewCareers.ReadOnly = true;
            dataGridViewCareers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCareers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCareers.RowHeadersVisible = false;
            dataGridViewCareers.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCareers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCareers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCareers.ShowCellToolTips = false;
            dataGridViewCareers.Size = new Size(1265, 527);
            dataGridViewCareers.TabIndex = 14;
            dataGridViewCareers.CellClick += dataGridViewCareers_CellClick;
            dataGridViewCareers.SelectionChanged += dataGridViewCareers_SelectionChanged;
            dataGridViewCareers.KeyDown += dataGridViewCareers_KeyDown;
            dataGridViewCareers.MouseClick += dataGridViewCareers_MouseClick;
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
            // resolutionDataGridViewTextBoxColumn1
            // 
            resolutionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resolutionDataGridViewTextBoxColumn1.DataPropertyName = "Resolution";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            resolutionDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            resolutionDataGridViewTextBoxColumn1.FillWeight = 18F;
            resolutionDataGridViewTextBoxColumn1.HeaderText = " Resolución";
            resolutionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            resolutionDataGridViewTextBoxColumn1.Name = "resolutionDataGridViewTextBoxColumn1";
            resolutionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.FillWeight = 75F;
            nameDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 112;
            // 
            // degreeDataGridViewTextBoxColumn1
            // 
            degreeDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            degreeDataGridViewTextBoxColumn1.DataPropertyName = "Degree";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            degreeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            degreeDataGridViewTextBoxColumn1.FillWeight = 57.32122F;
            degreeDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            degreeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            degreeDataGridViewTextBoxColumn1.Name = "degreeDataGridViewTextBoxColumn1";
            degreeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // turnDataGridViewTextBoxColumn1
            // 
            turnDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            turnDataGridViewTextBoxColumn1.DataPropertyName = "Turn";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            turnDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            turnDataGridViewTextBoxColumn1.FillWeight = 19.10707F;
            turnDataGridViewTextBoxColumn1.HeaderText = "Turno";
            turnDataGridViewTextBoxColumn1.MinimumWidth = 6;
            turnDataGridViewTextBoxColumn1.Name = "turnDataGridViewTextBoxColumn1";
            turnDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TotalAmountSubjects
            // 
            TotalAmountSubjects.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalAmountSubjects.DataPropertyName = "TotalAmountSubjects";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TotalAmountSubjects.DefaultCellStyle = dataGridViewCellStyle5;
            TotalAmountSubjects.FillWeight = 24.59893F;
            TotalAmountSubjects.HeaderText = "Cantidad de Materias";
            TotalAmountSubjects.MinimumWidth = 4;
            TotalAmountSubjects.Name = "TotalAmountSubjects";
            TotalAmountSubjects.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            activeDataGridViewCheckBoxColumn.FillWeight = 9.553537F;
            activeDataGridViewCheckBoxColumn.FlatStyle = FlatStyle.Flat;
            activeDataGridViewCheckBoxColumn.HeaderText = "Activa";
            activeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            activeDataGridViewCheckBoxColumn.ReadOnly = true;
            activeDataGridViewCheckBoxColumn.ToolTipText = "Indica si una carrera se encuentra activa para su inscripción";
            // 
            // labelTimer
            // 
            labelTimer.Tick += labelTimer_Tick;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 0;
            toolTip.ForeColor = Color.Black;
            toolTip.IsBalloon = true;
            // 
            // contextMenuCareers
            // 
            contextMenuCareers.BackColor = Color.FromArgb(44, 47, 51);
            contextMenuCareers.Font = new Font("Segoe UI", 10.2F);
            contextMenuCareers.ImageScalingSize = new Size(20, 20);
            contextMenuCareers.Items.AddRange(new ToolStripItem[] { matriculaToolStripMenuItem, promediosToolStripMenuItem });
            contextMenuCareers.Name = "contextMenuStrip1";
            contextMenuCareers.RenderMode = ToolStripRenderMode.Professional;
            contextMenuCareers.Size = new Size(162, 60);
            contextMenuCareers.ItemClicked += contextMenuCareers_ItemClicked;
            // 
            // matriculaToolStripMenuItem
            // 
            matriculaToolStripMenuItem.ForeColor = Color.White;
            matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            matriculaToolStripMenuItem.Size = new Size(161, 28);
            matriculaToolStripMenuItem.Text = "Matricula";
            // 
            // promediosToolStripMenuItem
            // 
            promediosToolStripMenuItem.ForeColor = Color.White;
            promediosToolStripMenuItem.Name = "promediosToolStripMenuItem";
            promediosToolStripMenuItem.Size = new Size(161, 28);
            promediosToolStripMenuItem.Text = "Promedios";
            // 
            // formCareer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(1265, 749);
            Controls.Add(panelGrid);
            Controls.Add(lblqcyo);
            Controls.Add(lblcarreraaqui);
            Controls.Add(panelInfo);
            Name = "formCareer";
            Text = "Gestin - Carreras";
            Load += formCareer_Load;
            ((System.ComponentModel.ISupportInitialize)careerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceCareers).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCareers).EndInit();
            contextMenuCareers.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResolutionNumber;
        private TextBox txtName;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbbTurn;
        private Label lbl4;
        private Button btnInsert;
        private Button btnUpdate;
        private BindingSource BindingSourceCareers;
        private BindingSource careerBindingSource;
        private Label lblqcyo;
        private Label lblcarreraaqui;
        private BigCheckBox chkActiveCareer;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnDataGridViewTextBoxColumn;
        private Panel panelInfo;
        private Panel panelGrid;
        private System.Windows.Forms.Timer labelTimer;
        private ToolTip toolTip;
        private Label lblResult;
        private DataGridView dataGridViewCareers;
        private Label label5;
        private Button btnSchedule;
        private Label labelActive;
        private ContextMenuStrip contextMenuCareers;
        private ToolStripMenuItem matriculaToolStripMenuItem;
        private ToolStripMenuItem promediosToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn turnDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TotalAmountSubjects;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}