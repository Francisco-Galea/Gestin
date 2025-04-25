namespace Gestin
{
    partial class formTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTest));
            btnLoadCareer = new Button();
            btnLoadSubjects = new Button();
            btnLoadStudents = new Button();
            btnLoadCareerEnrolment = new Button();
            btnUpdatePhone = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnLoadCareer
            // 
            btnLoadCareer.BackColor = Color.FromArgb(0, 150, 136);
            btnLoadCareer.FlatAppearance.BorderSize = 0;
            btnLoadCareer.FlatStyle = FlatStyle.Flat;
            btnLoadCareer.Font = new Font("Segoe UI", 10F);
            btnLoadCareer.ForeColor = Color.WhiteSmoke;
            btnLoadCareer.Location = new Point(14, 464);
            btnLoadCareer.Name = "btnLoadCareer";
            btnLoadCareer.Size = new Size(269, 40);
            btnLoadCareer.TabIndex = 0;
            btnLoadCareer.Text = "Cargar carreras";
            btnLoadCareer.UseVisualStyleBackColor = false;
            btnLoadCareer.Click += btnLoadCareer_Click;
            // 
            // btnLoadSubjects
            // 
            btnLoadSubjects.BackColor = Color.FromArgb(0, 150, 136);
            btnLoadSubjects.FlatAppearance.BorderSize = 0;
            btnLoadSubjects.FlatStyle = FlatStyle.Flat;
            btnLoadSubjects.Font = new Font("Segoe UI", 10F);
            btnLoadSubjects.ForeColor = Color.WhiteSmoke;
            btnLoadSubjects.Location = new Point(289, 464);
            btnLoadSubjects.Name = "btnLoadSubjects";
            btnLoadSubjects.Size = new Size(269, 40);
            btnLoadSubjects.TabIndex = 1;
            btnLoadSubjects.Text = "Cargar materias";
            btnLoadSubjects.UseVisualStyleBackColor = false;
            btnLoadSubjects.Click += btnLoadSubjects_Click;
            // 
            // btnLoadStudents
            // 
            btnLoadStudents.BackColor = Color.FromArgb(0, 150, 136);
            btnLoadStudents.FlatAppearance.BorderSize = 0;
            btnLoadStudents.FlatStyle = FlatStyle.Flat;
            btnLoadStudents.Font = new Font("Segoe UI", 10F);
            btnLoadStudents.ForeColor = Color.WhiteSmoke;
            btnLoadStudents.Location = new Point(14, 509);
            btnLoadStudents.Name = "btnLoadStudents";
            btnLoadStudents.Size = new Size(269, 40);
            btnLoadStudents.TabIndex = 2;
            btnLoadStudents.Text = "Cargar alumnos";
            btnLoadStudents.UseVisualStyleBackColor = false;
            btnLoadStudents.Click += btnLoadStudents_Click;
            // 
            // btnLoadCareerEnrolment
            // 
            btnLoadCareerEnrolment.BackColor = Color.FromArgb(0, 150, 136);
            btnLoadCareerEnrolment.FlatAppearance.BorderSize = 0;
            btnLoadCareerEnrolment.FlatStyle = FlatStyle.Flat;
            btnLoadCareerEnrolment.Font = new Font("Segoe UI", 10F);
            btnLoadCareerEnrolment.ForeColor = Color.WhiteSmoke;
            btnLoadCareerEnrolment.Location = new Point(289, 509);
            btnLoadCareerEnrolment.Name = "btnLoadCareerEnrolment";
            btnLoadCareerEnrolment.Size = new Size(269, 40);
            btnLoadCareerEnrolment.TabIndex = 3;
            btnLoadCareerEnrolment.Text = "Agregar incripcion a carrera";
            btnLoadCareerEnrolment.UseVisualStyleBackColor = false;
            btnLoadCareerEnrolment.Click += btnLoadCareerEnrolment_Click;
            // 
            // btnUpdatePhone
            // 
            btnUpdatePhone.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdatePhone.FlatAppearance.BorderSize = 0;
            btnUpdatePhone.FlatStyle = FlatStyle.Flat;
            btnUpdatePhone.Font = new Font("Segoe UI", 10F);
            btnUpdatePhone.ForeColor = Color.WhiteSmoke;
            btnUpdatePhone.Location = new Point(14, 555);
            btnUpdatePhone.Name = "btnUpdatePhone";
            btnUpdatePhone.Size = new Size(269, 40);
            btnUpdatePhone.TabIndex = 4;
            btnUpdatePhone.Text = "Actualizar telefonos";
            btnUpdatePhone.UseVisualStyleBackColor = false;
            btnUpdatePhone.Click += btnUpdatePhone_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(54, 57, 63);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 14F);
            richTextBox1.ForeColor = Color.WhiteSmoke;
            richTextBox1.Location = new Point(18, 16);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(537, 164);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(54, 57, 63);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            richTextBox2.ForeColor = Color.FromArgb(239, 83, 80);
            richTextBox2.Location = new Point(14, 209);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(542, 67);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "- Revisar que la planilla de cálculos a leer tenga el formato correcto y los nombres de columnas estén bien definidos.";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(54, 57, 63);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            richTextBox3.ForeColor = Color.FromArgb(239, 83, 80);
            richTextBox3.Location = new Point(14, 284);
            richTextBox3.Margin = new Padding(3, 4, 3, 4);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(542, 65);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "- Realizar una prueba de carga en una base de datos gemela de Gestin.";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(244, 67, 54);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.Location = new Point(289, 555);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(269, 40);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // formTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(569, 612);
            Controls.Add(btnSalir);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(btnUpdatePhone);
            Controls.Add(btnLoadCareerEnrolment);
            Controls.Add(btnLoadStudents);
            Controls.Add(btnLoadSubjects);
            Controls.Add(btnLoadCareer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formTest";
            Text = "test";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadCareer;
        private Button btnLoadSubjects;
        private Button btnLoadStudents;
        private Button btnLoadCareerEnrolment;
        private Button btnUpdatePhone;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button btnSalir;
    }
}