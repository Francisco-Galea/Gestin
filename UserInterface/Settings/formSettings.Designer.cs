namespace Gestin.UI.Settings
{
    partial class formSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            btnLoginDataDelete = new Button();
            btnNetworkDataDelete = new Button();
            btnConnectionSetter = new Button();
            label1 = new Label();
            btnUpdateExams = new Button();
            groupBoxDebug = new GroupBox();
            groupBoxUpdate = new GroupBox();
            deleteDuplicateStudents = new Button();
            groupBoxDatabase = new GroupBox();
            groupBoxDebug.SuspendLayout();
            groupBoxUpdate.SuspendLayout();
            groupBoxDatabase.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoginDataDelete
            // 
            btnLoginDataDelete.BackColor = Color.FromArgb(0, 150, 136);
            btnLoginDataDelete.FlatStyle = FlatStyle.Flat;
            btnLoginDataDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnLoginDataDelete.ForeColor = Color.White;
            btnLoginDataDelete.Location = new Point(14, 23);
            btnLoginDataDelete.Name = "btnLoginDataDelete";
            btnLoginDataDelete.Size = new Size(121, 83);
            btnLoginDataDelete.TabIndex = 9;
            btnLoginDataDelete.Text = "Borrar archivo de logueo";
            btnLoginDataDelete.UseVisualStyleBackColor = false;
            btnLoginDataDelete.Click += btnLoginDataDelete_Click;
            // 
            // btnNetworkDataDelete
            // 
            btnNetworkDataDelete.BackColor = Color.FromArgb(0, 150, 136);
            btnNetworkDataDelete.FlatStyle = FlatStyle.Flat;
            btnNetworkDataDelete.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnNetworkDataDelete.ForeColor = Color.White;
            btnNetworkDataDelete.Location = new Point(163, 23);
            btnNetworkDataDelete.Name = "btnNetworkDataDelete";
            btnNetworkDataDelete.Size = new Size(121, 83);
            btnNetworkDataDelete.TabIndex = 10;
            btnNetworkDataDelete.Text = "Borrar archivo de conexión";
            btnNetworkDataDelete.UseVisualStyleBackColor = false;
            // 
            // btnConnectionSetter
            // 
            btnConnectionSetter.BackColor = Color.FromArgb(44, 50, 60);
            btnConnectionSetter.BackgroundImage = Properties.Resources.databaseIcon;
            btnConnectionSetter.BackgroundImageLayout = ImageLayout.Stretch;
            btnConnectionSetter.FlatStyle = FlatStyle.Flat;
            btnConnectionSetter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnConnectionSetter.ForeColor = Color.White;
            btnConnectionSetter.Location = new Point(33, 36);
            btnConnectionSetter.Name = "btnConnectionSetter";
            btnConnectionSetter.Size = new Size(182, 171);
            btnConnectionSetter.TabIndex = 11;
            btnConnectionSetter.UseVisualStyleBackColor = false;
            btnConnectionSetter.Click += btnConnectionSetter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(221, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 52);
            label1.TabIndex = 12;
            label1.Text = "Configuraciónes";
            // 
            // btnUpdateExams
            // 
            btnUpdateExams.BackColor = Color.FromArgb(0, 150, 136);
            btnUpdateExams.FlatStyle = FlatStyle.Flat;
            btnUpdateExams.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnUpdateExams.ForeColor = Color.White;
            btnUpdateExams.Location = new Point(14, 23);
            btnUpdateExams.Name = "btnUpdateExams";
            btnUpdateExams.Size = new Size(121, 86);
            btnUpdateExams.TabIndex = 13;
            btnUpdateExams.Text = "Actualizar Examenes";
            btnUpdateExams.UseVisualStyleBackColor = false;
            btnUpdateExams.Click += btnUpdateExams_Click;
            // 
            // groupBoxDebug
            // 
            groupBoxDebug.Controls.Add(btnLoginDataDelete);
            groupBoxDebug.Controls.Add(btnNetworkDataDelete);
            groupBoxDebug.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxDebug.ForeColor = Color.White;
            groupBoxDebug.Location = new Point(438, 96);
            groupBoxDebug.Name = "groupBoxDebug";
            groupBoxDebug.Size = new Size(300, 128);
            groupBoxDebug.TabIndex = 15;
            groupBoxDebug.TabStop = false;
            groupBoxDebug.Text = "Debug";
            // 
            // groupBoxUpdate
            // 
            groupBoxUpdate.Controls.Add(deleteDuplicateStudents);
            groupBoxUpdate.Controls.Add(btnUpdateExams);
            groupBoxUpdate.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxUpdate.ForeColor = Color.White;
            groupBoxUpdate.Location = new Point(438, 257);
            groupBoxUpdate.Name = "groupBoxUpdate";
            groupBoxUpdate.Size = new Size(300, 122);
            groupBoxUpdate.TabIndex = 16;
            groupBoxUpdate.TabStop = false;
            groupBoxUpdate.Text = "Actualizar";
            // 
            // deleteDuplicateStudents
            // 
            deleteDuplicateStudents.BackColor = Color.FromArgb(0, 150, 136);
            deleteDuplicateStudents.FlatStyle = FlatStyle.Flat;
            deleteDuplicateStudents.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            deleteDuplicateStudents.ForeColor = Color.White;
            deleteDuplicateStudents.Location = new Point(163, 23);
            deleteDuplicateStudents.Name = "deleteDuplicateStudents";
            deleteDuplicateStudents.Size = new Size(121, 86);
            deleteDuplicateStudents.TabIndex = 14;
            deleteDuplicateStudents.Text = "Eliminar alumnos duplicados";
            deleteDuplicateStudents.UseVisualStyleBackColor = false;
            deleteDuplicateStudents.Click += deleteDuplicateStudents_Click;
            // 
            // groupBoxDatabase
            // 
            groupBoxDatabase.Controls.Add(btnConnectionSetter);
            groupBoxDatabase.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxDatabase.ForeColor = Color.White;
            groupBoxDatabase.Location = new Point(112, 135);
            groupBoxDatabase.Name = "groupBoxDatabase";
            groupBoxDatabase.Size = new Size(251, 231);
            groupBoxDatabase.TabIndex = 17;
            groupBoxDatabase.TabStop = false;
            groupBoxDatabase.Text = "Conexión a Base de Datos";
            // 
            // formSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxDatabase);
            Controls.Add(groupBoxUpdate);
            Controls.Add(groupBoxDebug);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formSettings";
            Text = "Gestin - Configuraciónes";
            groupBoxDebug.ResumeLayout(false);
            groupBoxUpdate.ResumeLayout(false);
            groupBoxDatabase.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginDataDelete;
        private Button btnNetworkDataDelete;
        private Button btnConnectionSetter;
        private Label label1;
        private Button btnUpdateExams;
        private GroupBox groupBoxDebug;
        private GroupBox groupBoxUpdate;
        private GroupBox groupBoxDatabase;
        private Button deleteDuplicateStudents;
    }
}