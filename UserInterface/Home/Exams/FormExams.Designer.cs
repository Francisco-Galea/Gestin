using Gestin.UI.Custom;

namespace Gestin.UI.Home.Exams
{
    partial class formExams
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formExams));
            dgvExams = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            carrer = new DataGridViewTextBoxColumn();
            subjectsYear = new DataGridViewTextBoxColumn();
            subject = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            Llamado = new DataGridViewTextBoxColumn();
            enrollments = new DataGridViewTextBoxColumn();
            SubjectId = new DataGridViewTextBoxColumn();
            CareerId = new DataGridViewTextBoxColumn();
            lblCarrer = new Label();
            lblSubject = new Label();
            label1 = new Label();
            dtDate = new DateTimePicker();
            lblTime = new Label();
            lblTenured = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDeleteExam = new Button();
            btnSave = new Button();
            btnUpdateExam = new Button();
            gbNewExam = new GroupBox();
            lblExamCode = new Label();
            label6 = new Label();
            btnSaveUpdate = new Button();
            lblShowThird = new Label();
            lblShowFirst = new Label();
            lblShowPlace = new Label();
            lblShowSec = new Label();
            lblShowTit = new Label();
            lblShowTime = new Label();
            lblShowDate = new Label();
            lblShowSubject = new Label();
            lblShowCareer = new Label();
            btnCancel = new Button();
            txtPlace = new TextBox();
            label2 = new Label();
            dtTime = new DateTimePicker();
            cbb3Vowel = new ComboBox();
            cbb1Vowel = new ComboBox();
            cbb2Vowel = new ComboBox();
            cbbTitular = new ComboBox();
            cbbSubject = new ComboBox();
            cbbCareer = new ComboBox();
            lblError = new Label();
            btnNewExam = new Button();
            panelOptions = new Panel();
            btnUnrol = new Button();
            btnOptions = new Button();
            lblMode = new Label();
            panelMoreOptions = new Panel();
            BtnGenerarActasLibresFecha = new Button();
            BtnGenerarActasPresencialesFecha = new Button();
            btnGenerateActaVolante = new Button();
            btnGenerateExams = new Button();
            panelHeader = new Panel();
            groupBox2 = new GroupBox();
            labelSearchSubject = new Label();
            toggSearchBySubject = new ToggleButton();
            txtSearchSubject = new TextBox();
            groupBoxStudentsFilters = new GroupBox();
            txtSearchStudent = new TextBox();
            labelOpcionTodos = new Label();
            toggSearchByStudent = new ToggleButton();
            lblDni = new Label();
            label13 = new Label();
            lblStudent = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            cbbToFilterExamsByCareer = new ComboBox();
            label9 = new Label();
            lbSearchBySubject = new ListBox();
            lbSearchByStudent = new ListBox();
            txtSearchCode = new TextBox();
            dtSearchDate = new DateTimePicker();
            toggDate = new ToggleButton();
            labelDate = new Label();
            btnSearchExam = new Button();
            panelMoreOptionsButtons = new Panel();
            groupBox3 = new GroupBox();
            lblActiveSearch = new Label();
            btnGenerateActaVolanteLibre = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExams).BeginInit();
            gbNewExam.SuspendLayout();
            panelOptions.SuspendLayout();
            panelMoreOptions.SuspendLayout();
            panelHeader.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxStudentsFilters.SuspendLayout();
            groupBox1.SuspendLayout();
            panelMoreOptionsButtons.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvExams
            // 
            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dgvExams.AllowUserToResizeRows = false;
            dgvExams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExams.BackgroundColor = Color.FromArgb(44, 47, 51);
            dgvExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle5.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvExams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExams.Columns.AddRange(new DataGridViewColumn[] { id, carrer, subjectsYear, subject, date, Llamado, enrollments, SubjectId, CareerId });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvExams.DefaultCellStyle = dataGridViewCellStyle6;
            dgvExams.Dock = DockStyle.Fill;
            dgvExams.EnableHeadersVisualStyles = false;
            dgvExams.GridColor = Color.FromArgb(0, 150, 136);
            dgvExams.Location = new Point(0, 0);
            dgvExams.Margin = new Padding(5, 0, 5, 0);
            dgvExams.Name = "dgvExams";
            dgvExams.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvExams.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvExams.RowHeadersVisible = false;
            dgvExams.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dgvExams.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExams.Size = new Size(1202, 187);
            dgvExams.TabIndex = 0;
            dgvExams.SelectionChanged += dgvExams_SelectionChanged;
            dgvExams.KeyDown += dgvExams_KeyDown;
            dgvExams.MouseDoubleClick += dgvExams_MouseDoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.FillWeight = 9.395772F;
            id.HeaderText = "Código";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // carrer
            // 
            carrer.DataPropertyName = "SubjectEnrolmentCareerName";
            carrer.FillWeight = 78.8680344F;
            carrer.HeaderText = "Carrera";
            carrer.MinimumWidth = 6;
            carrer.Name = "carrer";
            carrer.ReadOnly = true;
            // 
            // subjectsYear
            // 
            subjectsYear.DataPropertyName = "SubjectEnrolmentYearInCareer";
            subjectsYear.FillWeight = 5F;
            subjectsYear.HeaderText = "Año";
            subjectsYear.MinimumWidth = 100;
            subjectsYear.Name = "subjectsYear";
            subjectsYear.ReadOnly = true;
            // 
            // subject
            // 
            subject.DataPropertyName = "SubjectEnrolmentName";
            subject.FillWeight = 78.8680344F;
            subject.HeaderText = "Materia";
            subject.MinimumWidth = 6;
            subject.Name = "subject";
            subject.ReadOnly = true;
            // 
            // date
            // 
            date.DataPropertyName = "Date";
            date.FillWeight = 23.6604118F;
            date.HeaderText = "Fecha";
            date.MinimumWidth = 10;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // Llamado
            // 
            Llamado.DataPropertyName = "Call";
            Llamado.FillWeight = 9.395772F;
            Llamado.HeaderText = "Llamado";
            Llamado.MinimumWidth = 8;
            Llamado.Name = "Llamado";
            Llamado.ReadOnly = true;
            // 
            // enrollments
            // 
            enrollments.FillWeight = 3.943401F;
            enrollments.HeaderText = "Inscriptos";
            enrollments.MinimumWidth = 100;
            enrollments.Name = "enrollments";
            enrollments.ReadOnly = true;
            // 
            // SubjectId
            // 
            SubjectId.FillWeight = 1F;
            SubjectId.HeaderText = "SubjectId";
            SubjectId.MinimumWidth = 6;
            SubjectId.Name = "SubjectId";
            SubjectId.ReadOnly = true;
            SubjectId.Visible = false;
            // 
            // CareerId
            // 
            CareerId.FillWeight = 1F;
            CareerId.HeaderText = "CarrerId";
            CareerId.MinimumWidth = 6;
            CareerId.Name = "CareerId";
            CareerId.ReadOnly = true;
            CareerId.Visible = false;
            // 
            // lblCarrer
            // 
            lblCarrer.AutoSize = true;
            lblCarrer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarrer.ForeColor = Color.White;
            lblCarrer.Location = new Point(8, 22);
            lblCarrer.Margin = new Padding(4, 0, 4, 0);
            lblCarrer.Name = "lblCarrer";
            lblCarrer.Size = new Size(73, 21);
            lblCarrer.TabIndex = 2;
            lblCarrer.Text = "Carrera :";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSubject.ForeColor = Color.White;
            lblSubject.Location = new Point(5, 55);
            lblSubject.Margin = new Padding(4, 0, 4, 0);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(77, 21);
            lblSubject.TabIndex = 4;
            lblSubject.Text = "Materia :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(441, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 5;
            label1.Text = "Fecha :";
            // 
            // dtDate
            // 
            dtDate.CalendarForeColor = Color.Cyan;
            dtDate.CalendarMonthBackground = Color.FromArgb(35, 39, 42);
            dtDate.CalendarTitleBackColor = Color.Lime;
            dtDate.CalendarTitleForeColor = Color.Red;
            dtDate.CalendarTrailingForeColor = Color.Yellow;
            dtDate.CustomFormat = "dd/MM/yyyy";
            dtDate.Format = DateTimePickerFormat.Custom;
            dtDate.Location = new Point(509, 88);
            dtDate.Margin = new Padding(4);
            dtDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtDate.MinimumSize = new Size(100, 4);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(130, 23);
            dtDate.TabIndex = 3;
            dtDate.Value = new DateTime(2022, 11, 4, 9, 34, 25, 0);
            dtDate.Visible = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(427, 121);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(76, 21);
            lblTime.TabIndex = 7;
            lblTime.Text = "Horario :";
            // 
            // lblTenured
            // 
            lblTenured.AutoSize = true;
            lblTenured.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTenured.ForeColor = Color.White;
            lblTenured.Location = new Point(15, 88);
            lblTenured.Margin = new Padding(4, 0, 4, 0);
            lblTenured.Name = "lblTenured";
            lblTenured.Size = new Size(68, 21);
            lblTenured.TabIndex = 11;
            lblTenured.Text = "Titular :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 13;
            label3.Text = "1° vocal :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 15;
            label4.Text = "2° vocal :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 187);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 17;
            label5.Text = "3° vocal :";
            // 
            // btnDeleteExam
            // 
            btnDeleteExam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteExam.BackColor = Color.FromArgb(244, 67, 54);
            btnDeleteExam.FlatAppearance.BorderSize = 0;
            btnDeleteExam.FlatStyle = FlatStyle.Flat;
            btnDeleteExam.Font = new Font("Segoe UI", 12F);
            btnDeleteExam.ForeColor = Color.White;
            btnDeleteExam.Image = (Image)resources.GetObject("btnDeleteExam.Image");
            btnDeleteExam.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteExam.Location = new Point(941, 12);
            btnDeleteExam.Margin = new Padding(4);
            btnDeleteExam.Name = "btnDeleteExam";
            btnDeleteExam.Size = new Size(259, 30);
            btnDeleteExam.TabIndex = 20;
            btnDeleteExam.Text = "Eliminar examen seleccionado";
            btnDeleteExam.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteExam.UseVisualStyleBackColor = false;
            btnDeleteExam.Click += btnDeleteExam_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(887, 185);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 30);
            btnSave.TabIndex = 10;
            btnSave.Text = "Crear";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdateExam
            // 
            btnUpdateExam.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdateExam.FlatAppearance.BorderSize = 0;
            btnUpdateExam.FlatStyle = FlatStyle.Flat;
            btnUpdateExam.Font = new Font("Segoe UI", 12F);
            btnUpdateExam.ForeColor = Color.White;
            btnUpdateExam.Location = new Point(136, 12);
            btnUpdateExam.Margin = new Padding(4);
            btnUpdateExam.Name = "btnUpdateExam";
            btnUpdateExam.Size = new Size(241, 30);
            btnUpdateExam.TabIndex = 22;
            btnUpdateExam.Text = "Modificar examen seleccionado";
            btnUpdateExam.UseVisualStyleBackColor = false;
            btnUpdateExam.Click += btnUpdateExam_Click;
            // 
            // gbNewExam
            // 
            gbNewExam.BackColor = Color.FromArgb(44, 47, 51);
            gbNewExam.Controls.Add(lblExamCode);
            gbNewExam.Controls.Add(label6);
            gbNewExam.Controls.Add(btnSaveUpdate);
            gbNewExam.Controls.Add(lblShowThird);
            gbNewExam.Controls.Add(lblShowFirst);
            gbNewExam.Controls.Add(lblShowPlace);
            gbNewExam.Controls.Add(lblShowSec);
            gbNewExam.Controls.Add(lblShowTit);
            gbNewExam.Controls.Add(lblShowTime);
            gbNewExam.Controls.Add(lblShowDate);
            gbNewExam.Controls.Add(lblShowSubject);
            gbNewExam.Controls.Add(lblShowCareer);
            gbNewExam.Controls.Add(btnCancel);
            gbNewExam.Controls.Add(txtPlace);
            gbNewExam.Controls.Add(label2);
            gbNewExam.Controls.Add(dtTime);
            gbNewExam.Controls.Add(cbb3Vowel);
            gbNewExam.Controls.Add(cbb1Vowel);
            gbNewExam.Controls.Add(cbb2Vowel);
            gbNewExam.Controls.Add(cbbTitular);
            gbNewExam.Controls.Add(cbbSubject);
            gbNewExam.Controls.Add(cbbCareer);
            gbNewExam.Controls.Add(lblCarrer);
            gbNewExam.Controls.Add(btnSave);
            gbNewExam.Controls.Add(lblSubject);
            gbNewExam.Controls.Add(label1);
            gbNewExam.Controls.Add(label5);
            gbNewExam.Controls.Add(dtDate);
            gbNewExam.Controls.Add(lblTime);
            gbNewExam.Controls.Add(label4);
            gbNewExam.Controls.Add(label3);
            gbNewExam.Controls.Add(lblTenured);
            gbNewExam.Dock = DockStyle.Bottom;
            gbNewExam.FlatStyle = FlatStyle.Flat;
            gbNewExam.ForeColor = Color.White;
            gbNewExam.Location = new Point(4, 364);
            gbNewExam.Margin = new Padding(4);
            gbNewExam.Name = "gbNewExam";
            gbNewExam.Padding = new Padding(4);
            gbNewExam.Size = new Size(1202, 223);
            gbNewExam.TabIndex = 23;
            gbNewExam.TabStop = false;
            // 
            // lblExamCode
            // 
            lblExamCode.AutoSize = true;
            lblExamCode.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblExamCode.ForeColor = Color.White;
            lblExamCode.Location = new Point(511, 190);
            lblExamCode.Margin = new Padding(4, 0, 4, 0);
            lblExamCode.Name = "lblExamCode";
            lblExamCode.Size = new Size(33, 17);
            lblExamCode.TabIndex = 68;
            lblExamCode.Text = "-----";
            lblExamCode.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(434, 186);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 21);
            label6.TabIndex = 67;
            label6.Text = "Codigo:";
            label6.Visible = false;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Anchor = AnchorStyles.Right;
            btnSaveUpdate.BackColor = Color.FromArgb(0, 150, 136);
            btnSaveUpdate.FlatAppearance.BorderSize = 0;
            btnSaveUpdate.FlatStyle = FlatStyle.Flat;
            btnSaveUpdate.Font = new Font("Segoe UI", 12F);
            btnSaveUpdate.ForeColor = Color.WhiteSmoke;
            btnSaveUpdate.Location = new Point(887, 187);
            btnSaveUpdate.Margin = new Padding(4);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(118, 30);
            btnSaveUpdate.TabIndex = 10;
            btnSaveUpdate.Text = "Actualizar";
            btnSaveUpdate.UseVisualStyleBackColor = false;
            btnSaveUpdate.Visible = false;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // lblShowThird
            // 
            lblShowThird.AutoSize = true;
            lblShowThird.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblShowThird.ForeColor = Color.White;
            lblShowThird.Location = new Point(91, 189);
            lblShowThird.Margin = new Padding(4, 0, 4, 0);
            lblShowThird.Name = "lblShowThird";
            lblShowThird.Size = new Size(33, 17);
            lblShowThird.TabIndex = 65;
            lblShowThird.Text = "-----";
            // 
            // lblShowFirst
            // 
            lblShowFirst.AutoSize = true;
            lblShowFirst.Font = new Font("Segoe UI", 10F);
            lblShowFirst.ForeColor = Color.White;
            lblShowFirst.Location = new Point(92, 122);
            lblShowFirst.Margin = new Padding(4, 0, 4, 0);
            lblShowFirst.Name = "lblShowFirst";
            lblShowFirst.Size = new Size(39, 19);
            lblShowFirst.TabIndex = 64;
            lblShowFirst.Text = "-----";
            // 
            // lblShowPlace
            // 
            lblShowPlace.AutoSize = true;
            lblShowPlace.Font = new Font("Segoe UI", 10F);
            lblShowPlace.ForeColor = Color.White;
            lblShowPlace.Location = new Point(511, 157);
            lblShowPlace.Margin = new Padding(4, 0, 4, 0);
            lblShowPlace.Name = "lblShowPlace";
            lblShowPlace.Size = new Size(39, 19);
            lblShowPlace.TabIndex = 63;
            lblShowPlace.Text = "-----";
            // 
            // lblShowSec
            // 
            lblShowSec.AutoSize = true;
            lblShowSec.Font = new Font("Segoe UI", 10F);
            lblShowSec.ForeColor = Color.White;
            lblShowSec.Location = new Point(91, 155);
            lblShowSec.Margin = new Padding(4, 0, 4, 0);
            lblShowSec.Name = "lblShowSec";
            lblShowSec.Size = new Size(39, 19);
            lblShowSec.TabIndex = 62;
            lblShowSec.Text = "-----";
            // 
            // lblShowTit
            // 
            lblShowTit.AutoSize = true;
            lblShowTit.Font = new Font("Segoe UI", 10F);
            lblShowTit.ForeColor = Color.White;
            lblShowTit.Location = new Point(91, 89);
            lblShowTit.Margin = new Padding(4, 0, 4, 0);
            lblShowTit.Name = "lblShowTit";
            lblShowTit.Size = new Size(39, 19);
            lblShowTit.TabIndex = 61;
            lblShowTit.Text = "-----";
            // 
            // lblShowTime
            // 
            lblShowTime.AutoSize = true;
            lblShowTime.Font = new Font("Segoe UI", 10F);
            lblShowTime.ForeColor = Color.White;
            lblShowTime.Location = new Point(511, 123);
            lblShowTime.Margin = new Padding(4, 0, 4, 0);
            lblShowTime.Name = "lblShowTime";
            lblShowTime.Size = new Size(39, 19);
            lblShowTime.TabIndex = 60;
            lblShowTime.Text = "-----";
            // 
            // lblShowDate
            // 
            lblShowDate.AutoSize = true;
            lblShowDate.Font = new Font("Segoe UI", 10F);
            lblShowDate.ForeColor = Color.White;
            lblShowDate.Location = new Point(511, 90);
            lblShowDate.Margin = new Padding(4, 0, 4, 0);
            lblShowDate.Name = "lblShowDate";
            lblShowDate.Size = new Size(39, 19);
            lblShowDate.TabIndex = 59;
            lblShowDate.Text = "-----";
            // 
            // lblShowSubject
            // 
            lblShowSubject.AutoSize = true;
            lblShowSubject.Font = new Font("Segoe UI", 10F);
            lblShowSubject.ForeColor = Color.White;
            lblShowSubject.Location = new Point(91, 56);
            lblShowSubject.Margin = new Padding(4, 0, 4, 0);
            lblShowSubject.Name = "lblShowSubject";
            lblShowSubject.Size = new Size(39, 19);
            lblShowSubject.TabIndex = 58;
            lblShowSubject.Text = "-----";
            // 
            // lblShowCareer
            // 
            lblShowCareer.AutoSize = true;
            lblShowCareer.Font = new Font("Segoe UI", 10F);
            lblShowCareer.ForeColor = Color.White;
            lblShowCareer.Location = new Point(90, 23);
            lblShowCareer.Margin = new Padding(4, 0, 4, 0);
            lblShowCareer.Name = "lblShowCareer";
            lblShowCareer.Size = new Size(39, 19);
            lblShowCareer.TabIndex = 57;
            lblShowCareer.Text = "-----";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(244, 67, 54);
            btnCancel.Enabled = false;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1083, 186);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 30);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPlace
            // 
            txtPlace.BackColor = Color.FromArgb(44, 47, 51);
            txtPlace.BorderStyle = BorderStyle.FixedSingle;
            txtPlace.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtPlace.ForeColor = Color.White;
            txtPlace.Location = new Point(509, 154);
            txtPlace.Margin = new Padding(3, 2, 3, 2);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(130, 24);
            txtPlace.TabIndex = 7;
            txtPlace.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(442, 154);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 28;
            label2.Text = "Lugar :";
            // 
            // dtTime
            // 
            dtTime.CalendarMonthBackground = Color.FromArgb(35, 39, 42);
            dtTime.CustomFormat = "HH:mm";
            dtTime.Font = new Font("Microsoft Sans Serif", 10F);
            dtTime.Format = DateTimePickerFormat.Custom;
            dtTime.Location = new Point(509, 121);
            dtTime.Margin = new Padding(3, 2, 3, 2);
            dtTime.Name = "dtTime";
            dtTime.ShowUpDown = true;
            dtTime.Size = new Size(130, 23);
            dtTime.TabIndex = 4;
            dtTime.Visible = false;
            // 
            // cbb3Vowel
            // 
            cbb3Vowel.BackColor = Color.FromArgb(44, 47, 51);
            cbb3Vowel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb3Vowel.FlatStyle = FlatStyle.Flat;
            cbb3Vowel.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbb3Vowel.ForeColor = Color.White;
            cbb3Vowel.FormattingEnabled = true;
            cbb3Vowel.Location = new Point(88, 185);
            cbb3Vowel.Margin = new Padding(4);
            cbb3Vowel.MinimumSize = new Size(150, 0);
            cbb3Vowel.Name = "cbb3Vowel";
            cbb3Vowel.Size = new Size(330, 25);
            cbb3Vowel.Sorted = true;
            cbb3Vowel.TabIndex = 9;
            cbb3Vowel.Visible = false;
            // 
            // cbb1Vowel
            // 
            cbb1Vowel.BackColor = Color.FromArgb(44, 47, 51);
            cbb1Vowel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb1Vowel.FlatStyle = FlatStyle.Flat;
            cbb1Vowel.Font = new Font("Segoe UI", 10F);
            cbb1Vowel.ForeColor = Color.White;
            cbb1Vowel.FormattingEnabled = true;
            cbb1Vowel.Location = new Point(88, 119);
            cbb1Vowel.Margin = new Padding(4);
            cbb1Vowel.MinimumSize = new Size(150, 0);
            cbb1Vowel.Name = "cbb1Vowel";
            cbb1Vowel.Size = new Size(330, 25);
            cbb1Vowel.Sorted = true;
            cbb1Vowel.TabIndex = 8;
            cbb1Vowel.Visible = false;
            // 
            // cbb2Vowel
            // 
            cbb2Vowel.BackColor = Color.FromArgb(44, 47, 51);
            cbb2Vowel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb2Vowel.FlatStyle = FlatStyle.Flat;
            cbb2Vowel.Font = new Font("Segoe UI", 10F);
            cbb2Vowel.ForeColor = Color.White;
            cbb2Vowel.FormattingEnabled = true;
            cbb2Vowel.Location = new Point(88, 152);
            cbb2Vowel.Margin = new Padding(4);
            cbb2Vowel.MinimumSize = new Size(150, 0);
            cbb2Vowel.Name = "cbb2Vowel";
            cbb2Vowel.Size = new Size(330, 25);
            cbb2Vowel.Sorted = true;
            cbb2Vowel.TabIndex = 6;
            cbb2Vowel.Visible = false;
            // 
            // cbbTitular
            // 
            cbbTitular.BackColor = Color.FromArgb(44, 47, 51);
            cbbTitular.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTitular.FlatStyle = FlatStyle.Flat;
            cbbTitular.Font = new Font("Segoe UI", 10F);
            cbbTitular.ForeColor = Color.White;
            cbbTitular.FormattingEnabled = true;
            cbbTitular.IntegralHeight = false;
            cbbTitular.Location = new Point(88, 86);
            cbbTitular.Margin = new Padding(4);
            cbbTitular.MinimumSize = new Size(150, 0);
            cbbTitular.Name = "cbbTitular";
            cbbTitular.Size = new Size(330, 25);
            cbbTitular.Sorted = true;
            cbbTitular.TabIndex = 5;
            cbbTitular.Visible = false;
            // 
            // cbbSubject
            // 
            cbbSubject.BackColor = Color.FromArgb(44, 47, 51);
            cbbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSubject.FlatStyle = FlatStyle.Flat;
            cbbSubject.Font = new Font("Segoe UI", 10F);
            cbbSubject.ForeColor = Color.White;
            cbbSubject.FormattingEnabled = true;
            cbbSubject.Location = new Point(88, 53);
            cbbSubject.Margin = new Padding(4);
            cbbSubject.MinimumSize = new Size(150, 0);
            cbbSubject.Name = "cbbSubject";
            cbbSubject.Size = new Size(815, 25);
            cbbSubject.Sorted = true;
            cbbSubject.TabIndex = 2;
            cbbSubject.Visible = false;
            cbbSubject.SelectedValueChanged += cbbSubject_SelectedValueChanged;
            // 
            // cbbCareer
            // 
            cbbCareer.BackColor = Color.FromArgb(44, 47, 51);
            cbbCareer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCareer.FlatStyle = FlatStyle.Flat;
            cbbCareer.Font = new Font("Segoe UI", 10F);
            cbbCareer.ForeColor = Color.White;
            cbbCareer.FormattingEnabled = true;
            cbbCareer.Location = new Point(88, 20);
            cbbCareer.Margin = new Padding(4);
            cbbCareer.MinimumSize = new Size(150, 0);
            cbbCareer.Name = "cbbCareer";
            cbbCareer.Size = new Size(815, 25);
            cbbCareer.Sorted = true;
            cbbCareer.TabIndex = 1;
            cbbCareer.Visible = false;
            cbbCareer.SelectedValueChanged += cbbCareer_SelectedValueChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.FromArgb(44, 47, 51);
            lblError.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Firebrick;
            lblError.Image = Properties.Resources.ErrorSmall;
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(427, 17);
            lblError.Name = "lblError";
            lblError.Size = new Size(151, 17);
            lblError.TabIndex = 55;
            lblError.Text = "          --ErrorMessage--";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // btnNewExam
            // 
            btnNewExam.BackColor = Color.FromArgb(0, 150, 136);
            btnNewExam.FlatAppearance.BorderSize = 0;
            btnNewExam.FlatStyle = FlatStyle.Flat;
            btnNewExam.Font = new Font("Segoe UI", 12F);
            btnNewExam.ForeColor = Color.White;
            btnNewExam.Location = new Point(5, 12);
            btnNewExam.Margin = new Padding(4);
            btnNewExam.Name = "btnNewExam";
            btnNewExam.Size = new Size(123, 30);
            btnNewExam.TabIndex = 25;
            btnNewExam.Text = "Crear examen";
            btnNewExam.UseVisualStyleBackColor = false;
            btnNewExam.Click += btnNewExam_Click;
            // 
            // panelOptions
            // 
            panelOptions.BackColor = Color.FromArgb(44, 47, 51);
            panelOptions.Controls.Add(btnUnrol);
            panelOptions.Controls.Add(btnOptions);
            panelOptions.Controls.Add(lblMode);
            panelOptions.Controls.Add(btnNewExam);
            panelOptions.Controls.Add(btnDeleteExam);
            panelOptions.Controls.Add(btnUpdateExam);
            panelOptions.Controls.Add(lblError);
            panelOptions.Dock = DockStyle.Bottom;
            panelOptions.Location = new Point(4, 314);
            panelOptions.Margin = new Padding(3, 2, 3, 2);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1202, 50);
            panelOptions.TabIndex = 26;
            // 
            // btnUnrol
            // 
            btnUnrol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUnrol.BackColor = Color.FromArgb(244, 67, 54);
            btnUnrol.FlatAppearance.BorderSize = 0;
            btnUnrol.FlatStyle = FlatStyle.Flat;
            btnUnrol.Font = new Font("Segoe UI", 12F);
            btnUnrol.ForeColor = Color.White;
            btnUnrol.Location = new Point(811, 12);
            btnUnrol.Margin = new Padding(4);
            btnUnrol.Name = "btnUnrol";
            btnUnrol.Size = new Size(120, 30);
            btnUnrol.TabIndex = 56;
            btnUnrol.Text = "Dar de baja estudiante";
            btnUnrol.UseVisualStyleBackColor = false;
            btnUnrol.Click += btnUnrol_Click;
            // 
            // btnOptions
            // 
            btnOptions.Anchor = AnchorStyles.Left;
            btnOptions.BackColor = Color.FromArgb(0, 150, 136);
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Segoe UI", 12F);
            btnOptions.ForeColor = Color.White;
            btnOptions.Location = new Point(385, 12);
            btnOptions.Margin = new Padding(4);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(37, 30);
            btnOptions.TabIndex = 27;
            btnOptions.Text = "+";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            // 
            // lblMode
            // 
            lblMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 12F);
            lblMode.ForeColor = Color.White;
            lblMode.Location = new Point(731, 17);
            lblMode.Margin = new Padding(4, 0, 4, 0);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(74, 21);
            lblMode.TabIndex = 26;
            lblMode.Text = "--Mode--";
            lblMode.Visible = false;
            // 
            // panelMoreOptions
            // 
            panelMoreOptions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelMoreOptions.Controls.Add(btnGenerateActaVolanteLibre);
            panelMoreOptions.Controls.Add(BtnGenerarActasLibresFecha);
            panelMoreOptions.Controls.Add(BtnGenerarActasPresencialesFecha);
            panelMoreOptions.Controls.Add(btnGenerateActaVolante);
            panelMoreOptions.Controls.Add(btnGenerateExams);
            panelMoreOptions.Location = new Point(365, -5);
            panelMoreOptions.Margin = new Padding(2, 1, 2, 1);
            panelMoreOptions.Name = "panelMoreOptions";
            panelMoreOptions.Padding = new Padding(4);
            panelMoreOptions.Size = new Size(372, 189);
            panelMoreOptions.TabIndex = 28;
            panelMoreOptions.Visible = false;
            // 
            // BtnGenerarActasLibresFecha
            // 
            BtnGenerarActasLibresFecha.BackColor = Color.FromArgb(0, 150, 136);
            BtnGenerarActasLibresFecha.FlatAppearance.BorderSize = 0;
            BtnGenerarActasLibresFecha.FlatStyle = FlatStyle.Flat;
            BtnGenerarActasLibresFecha.Font = new Font("Segoe UI", 10F);
            BtnGenerarActasLibresFecha.ForeColor = Color.White;
            BtnGenerarActasLibresFecha.Location = new Point(20, 151);
            BtnGenerarActasLibresFecha.Margin = new Padding(3, 2, 3, 2);
            BtnGenerarActasLibresFecha.Name = "BtnGenerarActasLibresFecha";
            BtnGenerarActasLibresFecha.Size = new Size(332, 32);
            BtnGenerarActasLibresFecha.TabIndex = 26;
            BtnGenerarActasLibresFecha.Text = "Generar actas libres del día seleccionado";
            BtnGenerarActasLibresFecha.UseVisualStyleBackColor = false;
            BtnGenerarActasLibresFecha.Click += BtnGenerarActasLibresFecha_Click;
            // 
            // BtnGenerarActasPresencialesFecha
            // 
            BtnGenerarActasPresencialesFecha.BackColor = Color.FromArgb(0, 150, 136);
            BtnGenerarActasPresencialesFecha.FlatAppearance.BorderSize = 0;
            BtnGenerarActasPresencialesFecha.FlatStyle = FlatStyle.Flat;
            BtnGenerarActasPresencialesFecha.Font = new Font("Segoe UI", 10F);
            BtnGenerarActasPresencialesFecha.ForeColor = Color.White;
            BtnGenerarActasPresencialesFecha.Location = new Point(20, 114);
            BtnGenerarActasPresencialesFecha.Margin = new Padding(3, 2, 3, 2);
            BtnGenerarActasPresencialesFecha.Name = "BtnGenerarActasPresencialesFecha";
            BtnGenerarActasPresencialesFecha.Size = new Size(332, 32);
            BtnGenerarActasPresencialesFecha.TabIndex = 25;
            BtnGenerarActasPresencialesFecha.Text = "Generar actas presenciales del día seleccionado";
            BtnGenerarActasPresencialesFecha.UseVisualStyleBackColor = false;
            BtnGenerarActasPresencialesFecha.Click += BtnGenerarActasPresencialesFecha_Click;
            // 
            // btnGenerateActaVolante
            // 
            btnGenerateActaVolante.BackColor = Color.FromArgb(0, 150, 136);
            btnGenerateActaVolante.FlatAppearance.BorderSize = 0;
            btnGenerateActaVolante.FlatStyle = FlatStyle.Flat;
            btnGenerateActaVolante.Font = new Font("Segoe UI", 9F);
            btnGenerateActaVolante.ForeColor = Color.White;
            btnGenerateActaVolante.Location = new Point(20, 46);
            btnGenerateActaVolante.Margin = new Padding(3, 2, 3, 2);
            btnGenerateActaVolante.Name = "btnGenerateActaVolante";
            btnGenerateActaVolante.Size = new Size(332, 28);
            btnGenerateActaVolante.TabIndex = 24;
            btnGenerateActaVolante.Text = "Generar acta volante presencial del examen seleccionado";
            btnGenerateActaVolante.UseVisualStyleBackColor = false;
            btnGenerateActaVolante.Click += btnGenerateActaVolante_Click;
            // 
            // btnGenerateExams
            // 
            btnGenerateExams.BackColor = Color.FromArgb(0, 150, 136);
            btnGenerateExams.FlatAppearance.BorderSize = 0;
            btnGenerateExams.FlatStyle = FlatStyle.Flat;
            btnGenerateExams.Font = new Font("Segoe UI", 10F);
            btnGenerateExams.ForeColor = Color.White;
            btnGenerateExams.Location = new Point(20, 14);
            btnGenerateExams.Margin = new Padding(4);
            btnGenerateExams.Name = "btnGenerateExams";
            btnGenerateExams.Size = new Size(332, 26);
            btnGenerateExams.TabIndex = 23;
            btnGenerateExams.Text = "Generar multiples examenes";
            btnGenerateExams.UseVisualStyleBackColor = false;
            btnGenerateExams.Click += btnGenerateExams_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(44, 47, 51);
            panelHeader.Controls.Add(groupBox2);
            panelHeader.Controls.Add(groupBoxStudentsFilters);
            panelHeader.Controls.Add(groupBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = Color.WhiteSmoke;
            panelHeader.Location = new Point(4, 4);
            panelHeader.Margin = new Padding(2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1202, 123);
            panelHeader.TabIndex = 29;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelSearchSubject);
            groupBox2.Controls.Add(toggSearchBySubject);
            groupBox2.Controls.Add(txtSearchSubject);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(749, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(438, 55);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar por nombre de materia";
            // 
            // labelSearchSubject
            // 
            labelSearchSubject.AutoSize = true;
            labelSearchSubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelSearchSubject.ForeColor = Color.White;
            labelSearchSubject.Location = new Point(7, 20);
            labelSearchSubject.Margin = new Padding(4, 0, 4, 0);
            labelSearchSubject.Name = "labelSearchSubject";
            labelSearchSubject.Size = new Size(54, 21);
            labelSearchSubject.TabIndex = 52;
            labelSearchSubject.Text = "Todas";
            // 
            // toggSearchBySubject
            // 
            toggSearchBySubject.AutoSize = true;
            toggSearchBySubject.FlatStyle = FlatStyle.Flat;
            toggSearchBySubject.Location = new Point(77, 21);
            toggSearchBySubject.MinimumSize = new Size(45, 22);
            toggSearchBySubject.Name = "toggSearchBySubject";
            toggSearchBySubject.OffBackColor = Color.Gray;
            toggSearchBySubject.OffToggleColor = Color.Gainsboro;
            toggSearchBySubject.OnBackColor = Color.FromArgb(0, 150, 136);
            toggSearchBySubject.OnToggleColor = Color.WhiteSmoke;
            toggSearchBySubject.Size = new Size(45, 22);
            toggSearchBySubject.TabIndex = 53;
            toggSearchBySubject.UseVisualStyleBackColor = true;
            toggSearchBySubject.CheckedChanged += toggSearchBySubject_CheckedChanged;
            // 
            // txtSearchSubject
            // 
            txtSearchSubject.BackColor = Color.FromArgb(44, 47, 51);
            txtSearchSubject.BorderStyle = BorderStyle.FixedSingle;
            txtSearchSubject.Enabled = false;
            txtSearchSubject.Font = new Font("Segoe UI", 12F);
            txtSearchSubject.ForeColor = Color.White;
            txtSearchSubject.Location = new Point(136, 19);
            txtSearchSubject.Margin = new Padding(2, 1, 2, 1);
            txtSearchSubject.Name = "txtSearchSubject";
            txtSearchSubject.PlaceholderText = " ingrese nombre de la materia";
            txtSearchSubject.Size = new Size(295, 29);
            txtSearchSubject.TabIndex = 27;
            txtSearchSubject.TextChanged += txtSearchSubject_TextChanged;
            txtSearchSubject.KeyDown += txtSearchSubject_KeyDown;
            // 
            // groupBoxStudentsFilters
            // 
            groupBoxStudentsFilters.Controls.Add(txtSearchStudent);
            groupBoxStudentsFilters.Controls.Add(labelOpcionTodos);
            groupBoxStudentsFilters.Controls.Add(toggSearchByStudent);
            groupBoxStudentsFilters.Controls.Add(lblDni);
            groupBoxStudentsFilters.Controls.Add(label13);
            groupBoxStudentsFilters.Controls.Add(lblStudent);
            groupBoxStudentsFilters.Controls.Add(label12);
            groupBoxStudentsFilters.FlatStyle = FlatStyle.Flat;
            groupBoxStudentsFilters.ForeColor = Color.WhiteSmoke;
            groupBoxStudentsFilters.Location = new Point(2, 60);
            groupBoxStudentsFilters.Margin = new Padding(2);
            groupBoxStudentsFilters.Name = "groupBoxStudentsFilters";
            groupBoxStudentsFilters.Size = new Size(735, 55);
            groupBoxStudentsFilters.TabIndex = 51;
            groupBoxStudentsFilters.TabStop = false;
            groupBoxStudentsFilters.Text = "Buscar por estudiante inscripto";
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.BackColor = Color.FromArgb(44, 47, 51);
            txtSearchStudent.BorderStyle = BorderStyle.FixedSingle;
            txtSearchStudent.Enabled = false;
            txtSearchStudent.Font = new Font("Segoe UI", 12F);
            txtSearchStudent.ForeColor = Color.White;
            txtSearchStudent.Location = new Point(160, 19);
            txtSearchStudent.Margin = new Padding(3, 2, 3, 2);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.PlaceholderText = " ingrese nombre o dni del estudiante";
            txtSearchStudent.Size = new Size(331, 29);
            txtSearchStudent.TabIndex = 37;
            txtSearchStudent.TextChanged += searchBox_TextChanged;
            txtSearchStudent.KeyDown += txtSearchSubject_KeyDown;
            // 
            // labelOpcionTodos
            // 
            labelOpcionTodos.AutoSize = true;
            labelOpcionTodos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelOpcionTodos.ForeColor = Color.White;
            labelOpcionTodos.Location = new Point(65, 20);
            labelOpcionTodos.Margin = new Padding(4, 0, 4, 0);
            labelOpcionTodos.Name = "labelOpcionTodos";
            labelOpcionTodos.Size = new Size(55, 21);
            labelOpcionTodos.TabIndex = 49;
            labelOpcionTodos.Text = "Todos";
            // 
            // toggSearchByStudent
            // 
            toggSearchByStudent.AutoSize = true;
            toggSearchByStudent.FlatStyle = FlatStyle.Flat;
            toggSearchByStudent.Location = new Point(13, 21);
            toggSearchByStudent.MinimumSize = new Size(45, 22);
            toggSearchByStudent.Name = "toggSearchByStudent";
            toggSearchByStudent.OffBackColor = Color.Gray;
            toggSearchByStudent.OffToggleColor = Color.Gainsboro;
            toggSearchByStudent.OnBackColor = Color.FromArgb(0, 150, 136);
            toggSearchByStudent.OnToggleColor = Color.WhiteSmoke;
            toggSearchByStudent.Size = new Size(45, 22);
            toggSearchByStudent.TabIndex = 48;
            toggSearchByStudent.UseVisualStyleBackColor = true;
            toggSearchByStudent.CheckedChanged += toggSearchByStudent_CheckedChanged;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            lblDni.ForeColor = Color.FromArgb(255, 152, 0);
            lblDni.Location = new Point(534, 32);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(59, 13);
            lblDni.TabIndex = 47;
            lblDni.Text = "-------------";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(500, 14);
            label13.Name = "label13";
            label13.Size = new Size(63, 13);
            label13.TabIndex = 44;
            label13.Text = "Estudiante:";
            // 
            // lblStudent
            // 
            lblStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStudent.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            lblStudent.ForeColor = Color.FromArgb(255, 152, 0);
            lblStudent.Location = new Point(575, 14);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(127, 13);
            lblStudent.TabIndex = 45;
            lblStudent.Text = "-------------------------";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(500, 32);
            label12.Name = "label12";
            label12.Size = new Size(27, 13);
            label12.TabIndex = 46;
            label12.Text = "Dni:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbToFilterExamsByCareer);
            groupBox1.Controls.Add(label9);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(2, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(500, 55);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por carrera";
            // 
            // cbbToFilterExamsByCareer
            // 
            cbbToFilterExamsByCareer.BackColor = Color.FromArgb(44, 47, 51);
            cbbToFilterExamsByCareer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbToFilterExamsByCareer.FlatStyle = FlatStyle.Flat;
            cbbToFilterExamsByCareer.Font = new Font("Segoe UI", 10F);
            cbbToFilterExamsByCareer.ForeColor = Color.White;
            cbbToFilterExamsByCareer.FormattingEnabled = true;
            cbbToFilterExamsByCareer.Location = new Point(84, 21);
            cbbToFilterExamsByCareer.Margin = new Padding(3, 2, 3, 2);
            cbbToFilterExamsByCareer.MinimumSize = new Size(106, 0);
            cbbToFilterExamsByCareer.Name = "cbbToFilterExamsByCareer";
            cbbToFilterExamsByCareer.Size = new Size(407, 25);
            cbbToFilterExamsByCareer.Sorted = true;
            cbbToFilterExamsByCareer.TabIndex = 29;
            cbbToFilterExamsByCareer.SelectedIndexChanged += cbbToFilterExamsByCareer_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(9, 21);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 30;
            label9.Text = "Carrera:";
            // 
            // lbSearchBySubject
            // 
            lbSearchBySubject.BackColor = Color.FromArgb(33, 33, 33);
            lbSearchBySubject.BorderStyle = BorderStyle.FixedSingle;
            lbSearchBySubject.Font = new Font("Segoe UI", 9.75F);
            lbSearchBySubject.ForeColor = Color.WhiteSmoke;
            lbSearchBySubject.FormattingEnabled = true;
            lbSearchBySubject.ItemHeight = 17;
            lbSearchBySubject.Location = new Point(1011, -23);
            lbSearchBySubject.Margin = new Padding(3, 4, 3, 4);
            lbSearchBySubject.Name = "lbSearchBySubject";
            lbSearchBySubject.Size = new Size(297, 19);
            lbSearchBySubject.TabIndex = 51;
            lbSearchBySubject.Visible = false;
            lbSearchBySubject.Click += lbSearchBySubject_Click;
            lbSearchBySubject.KeyDown += lbSearchBySubject_KeyDown;
            // 
            // lbSearchByStudent
            // 
            lbSearchByStudent.BackColor = Color.FromArgb(33, 33, 33);
            lbSearchByStudent.BorderStyle = BorderStyle.FixedSingle;
            lbSearchByStudent.Font = new Font("Segoe UI", 12F);
            lbSearchByStudent.ForeColor = Color.WhiteSmoke;
            lbSearchByStudent.FormattingEnabled = true;
            lbSearchByStudent.ItemHeight = 21;
            lbSearchByStudent.Location = new Point(185, -22);
            lbSearchByStudent.Margin = new Padding(3, 4, 3, 4);
            lbSearchByStudent.Name = "lbSearchByStudent";
            lbSearchByStudent.Size = new Size(333, 65);
            lbSearchByStudent.TabIndex = 38;
            lbSearchByStudent.Visible = false;
            lbSearchByStudent.Click += lbSearch_Click;
            lbSearchByStudent.KeyDown += lbSearch_KeyDown;
            // 
            // txtSearchCode
            // 
            txtSearchCode.BackColor = Color.FromArgb(44, 47, 51);
            txtSearchCode.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCode.Font = new Font("Segoe UI", 12F);
            txtSearchCode.ForeColor = Color.White;
            txtSearchCode.Location = new Point(94, 22);
            txtSearchCode.Margin = new Padding(2, 1, 2, 1);
            txtSearchCode.Name = "txtSearchCode";
            txtSearchCode.Size = new Size(100, 29);
            txtSearchCode.TabIndex = 8;
            // 
            // dtSearchDate
            // 
            dtSearchDate.CustomFormat = "dd/MM/yyyy";
            dtSearchDate.Enabled = false;
            dtSearchDate.Font = new Font("Segoe UI", 12F);
            dtSearchDate.Format = DateTimePickerFormat.Custom;
            dtSearchDate.Location = new Point(94, 22);
            dtSearchDate.Margin = new Padding(2);
            dtSearchDate.Name = "dtSearchDate";
            dtSearchDate.Size = new Size(114, 29);
            dtSearchDate.TabIndex = 25;
            dtSearchDate.Value = new DateTime(2024, 3, 28, 0, 0, 0, 0);
            dtSearchDate.Visible = false;
            // 
            // toggDate
            // 
            toggDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            toggDate.AutoSize = true;
            toggDate.FlatStyle = FlatStyle.Flat;
            toggDate.Font = new Font("Segoe UI", 9F);
            toggDate.Location = new Point(410, 27);
            toggDate.MinimumSize = new Size(32, 13);
            toggDate.Name = "toggDate";
            toggDate.OffBackColor = Color.Gray;
            toggDate.OffToggleColor = Color.Gainsboro;
            toggDate.OnBackColor = Color.FromArgb(0, 150, 136);
            toggDate.OnToggleColor = Color.WhiteSmoke;
            toggDate.Size = new Size(32, 13);
            toggDate.TabIndex = 0;
            toggDate.TextAlign = ContentAlignment.TopLeft;
            toggDate.UseVisualStyleBackColor = true;
            toggDate.CheckedChanged += toggDate_CheckedChanged;
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(311, 20);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(93, 21);
            labelDate.TabIndex = 9;
            labelDate.Text = "por código";
            // 
            // btnSearchExam
            // 
            btnSearchExam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchExam.BackColor = Color.FromArgb(0, 150, 136);
            btnSearchExam.FlatAppearance.BorderSize = 0;
            btnSearchExam.FlatStyle = FlatStyle.Flat;
            btnSearchExam.Font = new Font("Microsoft Sans Serif", 12F);
            btnSearchExam.ForeColor = Color.White;
            btnSearchExam.Location = new Point(222, 17);
            btnSearchExam.Margin = new Padding(3, 2, 3, 2);
            btnSearchExam.Name = "btnSearchExam";
            btnSearchExam.Size = new Size(83, 30);
            btnSearchExam.TabIndex = 23;
            btnSearchExam.Text = "Buscar";
            btnSearchExam.UseVisualStyleBackColor = false;
            btnSearchExam.Click += btnSearchExam_Click;
            // 
            // panelMoreOptionsButtons
            // 
            panelMoreOptionsButtons.BackColor = Color.FromArgb(44, 47, 51);
            panelMoreOptionsButtons.Controls.Add(lbSearchByStudent);
            panelMoreOptionsButtons.Controls.Add(panelMoreOptions);
            panelMoreOptionsButtons.Controls.Add(lbSearchBySubject);
            panelMoreOptionsButtons.Controls.Add(dgvExams);
            panelMoreOptionsButtons.Dock = DockStyle.Fill;
            panelMoreOptionsButtons.Location = new Point(4, 127);
            panelMoreOptionsButtons.Margin = new Padding(2);
            panelMoreOptionsButtons.Name = "panelMoreOptionsButtons";
            panelMoreOptionsButtons.Size = new Size(1202, 187);
            panelMoreOptionsButtons.TabIndex = 30;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblActiveSearch);
            groupBox3.Controls.Add(btnSearchExam);
            groupBox3.Controls.Add(dtSearchDate);
            groupBox3.Controls.Add(txtSearchCode);
            groupBox3.Controls.Add(toggDate);
            groupBox3.Controls.Add(labelDate);
            groupBox3.ForeColor = Color.WhiteSmoke;
            groupBox3.Location = new Point(513, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 55);
            groupBox3.TabIndex = 55;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar por fecha o código";
            // 
            // lblActiveSearch
            // 
            lblActiveSearch.AutoSize = true;
            lblActiveSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblActiveSearch.ForeColor = Color.White;
            lblActiveSearch.Location = new Point(5, 23);
            lblActiveSearch.Name = "lblActiveSearch";
            lblActiveSearch.Size = new Size(73, 21);
            lblActiveSearch.TabIndex = 26;
            lblActiveSearch.Text = "Código :";
            // 
            // btnGenerateActaVolanteLibre
            // 
            btnGenerateActaVolanteLibre.BackColor = Color.FromArgb(0, 150, 136);
            btnGenerateActaVolanteLibre.FlatAppearance.BorderSize = 0;
            btnGenerateActaVolanteLibre.FlatStyle = FlatStyle.Flat;
            btnGenerateActaVolanteLibre.Font = new Font("Segoe UI", 9F);
            btnGenerateActaVolanteLibre.ForeColor = Color.White;
            btnGenerateActaVolanteLibre.Location = new Point(20, 80);
            btnGenerateActaVolanteLibre.Margin = new Padding(3, 2, 3, 2);
            btnGenerateActaVolanteLibre.Name = "btnGenerateActaVolanteLibre";
            btnGenerateActaVolanteLibre.Size = new Size(332, 28);
            btnGenerateActaVolanteLibre.TabIndex = 27;
            btnGenerateActaVolanteLibre.Text = "Generar acta volante libre del examen seleccionado";
            btnGenerateActaVolanteLibre.UseVisualStyleBackColor = false;
            btnGenerateActaVolanteLibre.Click += btnGenerateActaVolanteLibre_Click;
            // 
            // formExams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(1210, 591);
            Controls.Add(groupBox3);
            Controls.Add(panelMoreOptionsButtons);
            Controls.Add(panelHeader);
            Controls.Add(panelOptions);
            Controls.Add(gbNewExam);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "formExams";
            Padding = new Padding(4);
            Text = "Exámenes";
            Load += formExams_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExams).EndInit();
            gbNewExam.ResumeLayout(false);
            gbNewExam.PerformLayout();
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            panelMoreOptions.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxStudentsFilters.ResumeLayout(false);
            groupBoxStudentsFilters.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelMoreOptionsButtons.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvExams;
        private Label lblCarrer;
        private Label lblSubject;
        private Label label1;
        private DateTimePicker dtDate;
        private Label lblTime;
        private Label lblTenured;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnDeleteExam;
        private Button btnUpdateExam;
        private Button btnSave;
        private GroupBox gbNewExam;
        private Button btnNewExam;
        private Panel panelOptions;
        private ComboBox cbb3Vowel;
        private ComboBox cbb1Vowel;
        private ComboBox cbb2Vowel;
        private ComboBox cbbTitular;
        private ComboBox cbbSubject;
        private ComboBox cbbCareer;
        private DateTimePicker dtTime;
        private Label label2;
        private TextBox txtPlace;
        private Label lblError;
        private Label lblMode;
        private Button btnCancel;
        private Label lblShowThird;
        private Label lblShowFirst;
        private Label lblShowPlace;
        private Label lblShowSec;
        private Label lblShowTit;
        private Label lblShowTime;
        private Label lblShowDate;
        private Label lblShowSubject;
        private Label lblShowCareer;
        private Button btnSaveUpdate;
        private Label lblExamCode;
        private Label label6;
        private Button btnOptions;
        private Panel panelMoreOptions;
        private Button btnGenerateExams;
        private Panel panelHeader;
        private Panel panelMoreOptionsButtons;
        private ToggleButton toggDate;
        private DateTimePicker dtSearchDate;
        private Button btnSearchExam;
        private Label labelDate;
        private TextBox txtSearchCode;
        private Button btnGenerateActaVolante;
        private TextBox txtSearchSubject;
        private TextBox txtSearchStudent;
        private ListBox lbSearchByStudent;
        private Label labelOpcionTodos;
        private ToggleButton toggSearchByStudent;
        private Label lblDni;
        private Label label12;
        private Label lblStudent;
        private Label label13;
        private GroupBox groupBox1;
        private GroupBox groupBoxStudentsFilters;
        private ComboBox cbbToFilterExamsByCareer;
        private Label label9;
        private Button btnUnrol;
        private ToggleButton toggSearchBySubject;
        private Label labelSearchSubject;
        private ListBox lbSearchBySubject;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblActiveSearch;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn carrer;
        private DataGridViewTextBoxColumn subjectsYear;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Llamado;
        private DataGridViewTextBoxColumn enrollments;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn CareerId;
        private Button BtnGenerarActasPresencialesFecha;
        private Button BtnGenerarActasLibresFecha;
        private Button btnGenerateActaVolanteLibre;
    }
}