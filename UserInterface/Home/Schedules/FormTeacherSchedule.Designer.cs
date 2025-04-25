namespace Gestin.UI.Home.Schedules
{
    partial class formTeacherSchedule
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelCenter = new Panel();
            panel2 = new Panel();
            panelSearchBack = new Panel();
            listBoxSearchResults = new ListBox();
            pictureBoxError = new PictureBox();
            textBoxSearchBar = new TextBox();
            dgvTeacherSchedule = new DataGridView();
            Day = new DataGridViewTextBoxColumn();
            startingTime = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            panelLeft = new Panel();
            panel1 = new Panel();
            lbTeacherName = new Label();
            lbTeacher = new Label();
            bndSrcSchedule = new BindingSource(components);
            panelCenter.SuspendLayout();
            panel2.SuspendLayout();
            panelSearchBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherSchedule).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bndSrcSchedule).BeginInit();
            SuspendLayout();
            // 
            // panelCenter
            // 
            panelCenter.BackColor = SystemColors.InactiveCaption;
            panelCenter.Controls.Add(panel2);
            panelCenter.Controls.Add(panel1);
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(0, 0);
            panelCenter.Margin = new Padding(3, 4, 3, 4);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(1282, 652);
            panelCenter.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelSearchBack);
            panel2.Controls.Add(pictureBoxError);
            panel2.Controls.Add(textBoxSearchBar);
            panel2.Controls.Add(dgvTeacherSchedule);
            panel2.Controls.Add(panelLeft);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 41);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1282, 611);
            panel2.TabIndex = 8;
            // 
            // panelSearchBack
            // 
            panelSearchBack.BackColor = Color.FromArgb(35, 39, 42);
            panelSearchBack.BorderStyle = BorderStyle.FixedSingle;
            panelSearchBack.Controls.Add(listBoxSearchResults);
            panelSearchBack.Location = new Point(5, 49);
            panelSearchBack.Name = "panelSearchBack";
            panelSearchBack.Size = new Size(356, 230);
            panelSearchBack.TabIndex = 65;
            // 
            // listBoxSearchResults
            // 
            listBoxSearchResults.BackColor = Color.FromArgb(35, 39, 42);
            listBoxSearchResults.BorderStyle = BorderStyle.None;
            listBoxSearchResults.Dock = DockStyle.Fill;
            listBoxSearchResults.Font = new Font("Segoe UI", 12F);
            listBoxSearchResults.ForeColor = Color.White;
            listBoxSearchResults.FormattingEnabled = true;
            listBoxSearchResults.ItemHeight = 28;
            listBoxSearchResults.Location = new Point(0, 0);
            listBoxSearchResults.Name = "listBoxSearchResults";
            listBoxSearchResults.Size = new Size(354, 228);
            listBoxSearchResults.TabIndex = 59;
            listBoxSearchResults.Visible = false;
            listBoxSearchResults.SelectedIndexChanged += listBoxSearchResults_SelectedIndexChanged;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Anchor = AnchorStyles.None;
            pictureBoxError.BackColor = Color.FromArgb(44, 47, 51);
            pictureBoxError.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxError.Location = new Point(1358, 517);
            pictureBoxError.Margin = new Padding(3, 4, 3, 4);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(343, 399);
            pictureBoxError.TabIndex = 7;
            pictureBoxError.TabStop = false;
            pictureBoxError.Visible = false;
            // 
            // textBoxSearchBar
            // 
            textBoxSearchBar.BackColor = Color.FromArgb(35, 39, 42);
            textBoxSearchBar.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchBar.Font = new Font("Segoe UI", 12F);
            textBoxSearchBar.ForeColor = Color.White;
            textBoxSearchBar.Location = new Point(3, 7);
            textBoxSearchBar.Name = "textBoxSearchBar";
            textBoxSearchBar.PlaceholderText = "Ingrese nombre o dni de usuario";
            textBoxSearchBar.Size = new Size(357, 34);
            textBoxSearchBar.TabIndex = 64;
            textBoxSearchBar.TextChanged += textBoxSearchBar_TextChanged;
            // 
            // dgvTeacherSchedule
            // 
            dgvTeacherSchedule.AllowDrop = true;
            dgvTeacherSchedule.AllowUserToDeleteRows = false;
            dgvTeacherSchedule.AllowUserToResizeColumns = false;
            dgvTeacherSchedule.AllowUserToResizeRows = false;
            dgvTeacherSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTeacherSchedule.BackgroundColor = Color.FromArgb(44, 47, 51);
            dgvTeacherSchedule.BorderStyle = BorderStyle.None;
            dgvTeacherSchedule.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvTeacherSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTeacherSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTeacherSchedule.ColumnHeadersHeight = 30;
            dgvTeacherSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTeacherSchedule.Columns.AddRange(new DataGridViewColumn[] { Day, startingTime, Subject });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTeacherSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTeacherSchedule.Dock = DockStyle.Fill;
            dgvTeacherSchedule.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvTeacherSchedule.EnableHeadersVisualStyles = false;
            dgvTeacherSchedule.GridColor = Color.FromArgb(0, 150, 136);
            dgvTeacherSchedule.Location = new Point(365, 0);
            dgvTeacherSchedule.Margin = new Padding(3, 4, 3, 4);
            dgvTeacherSchedule.Name = "dgvTeacherSchedule";
            dgvTeacherSchedule.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTeacherSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTeacherSchedule.RowHeadersWidth = 80;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTeacherSchedule.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTeacherSchedule.RowTemplate.Height = 30;
            dgvTeacherSchedule.RowTemplate.ReadOnly = true;
            dgvTeacherSchedule.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTeacherSchedule.Size = new Size(917, 611);
            dgvTeacherSchedule.TabIndex = 1;
            // 
            // Day
            // 
            Day.HeaderText = "Dia";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            Day.ReadOnly = true;
            // 
            // startingTime
            // 
            startingTime.HeaderText = "Horario";
            startingTime.MinimumWidth = 6;
            startingTime.Name = "startingTime";
            startingTime.ReadOnly = true;
            // 
            // Subject
            // 
            Subject.HeaderText = "Materia";
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(44, 47, 51);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(365, 611);
            panelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 47, 51);
            panel1.Controls.Add(lbTeacherName);
            panel1.Controls.Add(lbTeacher);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 41);
            panel1.TabIndex = 7;
            // 
            // lbTeacherName
            // 
            lbTeacherName.AutoSize = true;
            lbTeacherName.Font = new Font("Segoe UI", 12F);
            lbTeacherName.ForeColor = Color.FromArgb(255, 152, 0);
            lbTeacherName.Location = new Point(90, 5);
            lbTeacherName.Name = "lbTeacherName";
            lbTeacherName.Size = new Size(117, 28);
            lbTeacherName.TabIndex = 7;
            lbTeacherName.Text = "--Profesor--";
            lbTeacherName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTeacher
            // 
            lbTeacher.Font = new Font("Segoe UI", 12F);
            lbTeacher.ForeColor = Color.FromArgb(255, 152, 0);
            lbTeacher.Location = new Point(14, 0);
            lbTeacher.Name = "lbTeacher";
            lbTeacher.Size = new Size(90, 37);
            lbTeacher.TabIndex = 6;
            lbTeacher.Text = "Profesor: ";
            lbTeacher.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // formTeacherSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 652);
            Controls.Add(panelCenter);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formTeacherSchedule";
            Text = "FormTeacherSchedule";
            panelCenter.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelSearchBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherSchedule).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bndSrcSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCenter;
        private Panel panel2;
        private PictureBox pictureBoxError;
        private DataGridView dgvTeacherSchedule;
        private Panel panelLeft;
        private Panel panel1;
        private Label lbTeacher;
        private Label lbTeacherName;
        private Label lblShowTit;
        private ComboBox cbbTeachers;
        private Label lblTenured;
        private Panel panelSearchBack;
        private ListBox listBoxSearchResults;
        private TextBox textBoxSearchBar;
        private BindingSource bndSrcSchedule;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn startingTime;
        private DataGridViewTextBoxColumn Subject;
    }
}