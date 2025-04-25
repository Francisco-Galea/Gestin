namespace Gestin.UI.Home.Exams
{
    partial class formGenerateMultipleExams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGenerateMultipleExams));
            panel1 = new Panel();
            btnClose = new PictureBox();
            panel2 = new Panel();
            pbFail = new PictureBox();
            pbSuccess = new PictureBox();
            lblError = new Label();
            label3 = new Label();
            label2 = new Label();
            dtTime = new DateTimePicker();
            dtDate = new DateTimePicker();
            label1 = new Label();
            cbbCareer = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            btnGenerate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSuccess).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(114, 137, 218);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 39);
            panel1.TabIndex = 52;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(114, 137, 218);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(710, 8);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 27);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 3;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 47, 51);
            panel2.Controls.Add(pbFail);
            panel2.Controls.Add(pbSuccess);
            panel2.Controls.Add(lblError);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtTime);
            panel2.Controls.Add(dtDate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbbCareer);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(11, 47);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(723, 411);
            panel2.TabIndex = 54;
            // 
            // pbFail
            // 
            pbFail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbFail.Image = (Image)resources.GetObject("pbFail.Image");
            pbFail.Location = new Point(436, 209);
            pbFail.Margin = new Padding(3, 4, 3, 4);
            pbFail.Name = "pbFail";
            pbFail.Size = new Size(144, 144);
            pbFail.SizeMode = PictureBoxSizeMode.AutoSize;
            pbFail.TabIndex = 71;
            pbFail.TabStop = false;
            pbFail.Visible = false;
            // 
            // pbSuccess
            // 
            pbSuccess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbSuccess.Image = (Image)resources.GetObject("pbSuccess.Image");
            pbSuccess.Location = new Point(436, 209);
            pbSuccess.Margin = new Padding(3, 4, 3, 4);
            pbSuccess.Name = "pbSuccess";
            pbSuccess.Size = new Size(144, 144);
            pbSuccess.SizeMode = PictureBoxSizeMode.AutoSize;
            pbSuccess.TabIndex = 70;
            pbSuccess.TabStop = false;
            pbSuccess.Visible = false;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 12F);
            lblError.ForeColor = Color.IndianRed;
            lblError.Image = (Image)resources.GetObject("lblError.Image");
            lblError.ImageAlign = ContentAlignment.MiddleLeft;
            lblError.Location = new Point(17, 361);
            lblError.Name = "lblError";
            lblError.Size = new Size(137, 28);
            lblError.TabIndex = 69;
            lblError.Text = "          --Error--";
            lblError.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 209);
            label3.Name = "label3";
            label3.Size = new Size(329, 28);
            label3.TabIndex = 66;
            label3.Text = "Horario para todos los exámenes:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 160);
            label2.Name = "label2";
            label2.Size = new Size(311, 28);
            label2.TabIndex = 65;
            label2.Text = "Fecha para todos los exámenes:";
            // 
            // dtTime
            // 
            dtTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtTime.CustomFormat = "HH:mm";
            dtTime.Font = new Font("Segoe UI", 12F);
            dtTime.Format = DateTimePickerFormat.Custom;
            dtTime.Location = new Point(336, 209);
            dtTime.Name = "dtTime";
            dtTime.ShowUpDown = true;
            dtTime.Size = new Size(78, 34);
            dtTime.TabIndex = 64;
            // 
            // dtDate
            // 
            dtDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtDate.CalendarForeColor = Color.Cyan;
            dtDate.CalendarMonthBackground = Color.Blue;
            dtDate.CalendarTitleBackColor = Color.Lime;
            dtDate.CalendarTitleForeColor = Color.Red;
            dtDate.CalendarTrailingForeColor = Color.Yellow;
            dtDate.Font = new Font("Segoe UI", 12F);
            dtDate.Location = new Point(336, 160);
            dtDate.Margin = new Padding(5);
            dtDate.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(382, 34);
            dtDate.TabIndex = 62;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 108);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 54;
            label1.Text = "Carrera :";
            // 
            // cbbCareer
            // 
            cbbCareer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbbCareer.BackColor = Color.FromArgb(44, 47, 51);
            cbbCareer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCareer.FlatStyle = FlatStyle.Flat;
            cbbCareer.Font = new Font("Segoe UI", 12F);
            cbbCareer.ForeColor = Color.White;
            cbbCareer.FormattingEnabled = true;
            cbbCareer.Location = new Point(96, 108);
            cbbCareer.Margin = new Padding(5);
            cbbCareer.MinimumSize = new Size(171, 0);
            cbbCareer.Name = "cbbCareer";
            cbbCareer.Size = new Size(622, 36);
            cbbCareer.Sorted = true;
            cbbCareer.TabIndex = 53;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(255, 152, 0);
            label4.Location = new Point(3, 43);
            label4.Name = "label4";
            label4.Size = new Size(713, 39);
            label4.TabIndex = 40;
            label4.Text = "(Luego puede editarlos individualmente desde el formulario de\"Exámenes\")";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.FromArgb(255, 152, 0);
            label7.Location = new Point(1, 4);
            label7.Name = "label7";
            label7.Size = new Size(715, 39);
            label7.TabIndex = 40;
            label7.Text = "Seleccione una carrera para generar todos sus exámenes";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenerate.BackColor = Color.FromArgb(0, 150, 136);
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 12F);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(11, 467);
            btnGenerate.Margin = new Padding(5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(165, 40);
            btnGenerate.TabIndex = 67;
            btnGenerate.Text = "Generar";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // formGenerateMultipleExams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(749, 519);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGenerate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formGenerateMultipleExams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGenerateMultipleExams";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSuccess).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private Panel panel2;
        private Label label7;
        private Label label1;
        private ComboBox cbbCareer;
        private Label label3;
        private Label label2;
        private DateTimePicker dtTime;
        private DateTimePicker dtDate;
        private Button btnGenerate;
        private Label lblError;
        private PictureBox pbFail;
        private PictureBox pbSuccess;
        private Label label4;
    }
}