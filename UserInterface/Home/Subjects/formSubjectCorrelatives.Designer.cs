namespace Gestin.UI.Home.Subjects
{
    partial class formSubjectCorrelatives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSubjectCorrelatives));
            dataGridViewCorrelatives = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            correlativeSubjectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CorrelativeFinal = new DataGridViewCheckBoxColumn();
            correlativeBindingSource = new BindingSource(components);
            correlativeFinalDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            btnAddCorrelativas = new Button();
            cbbCorrelativas = new ComboBox();
            bindingSourceCorrelativasExceptSame = new BindingSource(components);
            btnRemoveCorrelative = new Button();
            lblsubjectName = new Label();
            chkEstado = new CheckBox();
            checkBoxSpecial = new CheckBox();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblmateriaName2 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCorrelatives).BeginInit();
            ((System.ComponentModel.ISupportInitialize)correlativeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCorrelativasExceptSame).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCorrelatives
            // 
            dataGridViewCorrelatives.AllowUserToAddRows = false;
            dataGridViewCorrelatives.AllowUserToDeleteRows = false;
            dataGridViewCorrelatives.AutoGenerateColumns = false;
            dataGridViewCorrelatives.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCorrelatives.BackgroundColor = Color.FromArgb(44, 47, 51);
            dataGridViewCorrelatives.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCorrelatives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCorrelatives.ColumnHeadersHeight = 54;
            dataGridViewCorrelatives.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCorrelatives.Columns.AddRange(new DataGridViewColumn[] { Id, correlativeSubjectDataGridViewTextBoxColumn, CorrelativeFinal });
            dataGridViewCorrelatives.DataSource = correlativeBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCorrelatives.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCorrelatives.Dock = DockStyle.Fill;
            dataGridViewCorrelatives.EnableHeadersVisualStyles = false;
            dataGridViewCorrelatives.GridColor = SystemColors.WindowFrame;
            dataGridViewCorrelatives.Location = new Point(0, 0);
            dataGridViewCorrelatives.MultiSelect = false;
            dataGridViewCorrelatives.Name = "dataGridViewCorrelatives";
            dataGridViewCorrelatives.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(44, 47, 51);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCorrelatives.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCorrelatives.RowHeadersVisible = false;
            dataGridViewCorrelatives.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 77, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 223, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 77, 64);
            dataGridViewCorrelatives.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCorrelatives.RowTemplate.Height = 29;
            dataGridViewCorrelatives.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCorrelatives.ShowCellToolTips = false;
            dataGridViewCorrelatives.Size = new Size(1242, 249);
            dataGridViewCorrelatives.TabIndex = 6;
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
            // correlativeSubjectDataGridViewTextBoxColumn
            // 
            correlativeSubjectDataGridViewTextBoxColumn.DataPropertyName = "CorrelativeSubject";
            correlativeSubjectDataGridViewTextBoxColumn.HeaderText = "Materias correlativas actuales";
            correlativeSubjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            correlativeSubjectDataGridViewTextBoxColumn.Name = "correlativeSubjectDataGridViewTextBoxColumn";
            correlativeSubjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CorrelativeFinal
            // 
            CorrelativeFinal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CorrelativeFinal.DataPropertyName = "CorrelativeFinal";
            CorrelativeFinal.HeaderText = "Requiere final";
            CorrelativeFinal.MinimumWidth = 6;
            CorrelativeFinal.Name = "CorrelativeFinal";
            CorrelativeFinal.ReadOnly = true;
            CorrelativeFinal.Width = 134;
            // 
            // correlativeBindingSource
            // 
            correlativeBindingSource.DataSource = typeof(Model.Correlative);
            // 
            // correlativeFinalDataGridViewCheckBoxColumn
            // 
            correlativeFinalDataGridViewCheckBoxColumn.DataPropertyName = "CorrelativeFinal";
            correlativeFinalDataGridViewCheckBoxColumn.HeaderText = "CorrelativeFinal";
            correlativeFinalDataGridViewCheckBoxColumn.MinimumWidth = 6;
            correlativeFinalDataGridViewCheckBoxColumn.Name = "correlativeFinalDataGridViewCheckBoxColumn";
            correlativeFinalDataGridViewCheckBoxColumn.Width = 143;
            // 
            // btnAddCorrelativas
            // 
            btnAddCorrelativas.BackColor = Color.FromArgb(0, 150, 136);
            btnAddCorrelativas.FlatAppearance.BorderSize = 0;
            btnAddCorrelativas.FlatStyle = FlatStyle.Flat;
            btnAddCorrelativas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCorrelativas.ForeColor = Color.WhiteSmoke;
            btnAddCorrelativas.Location = new Point(3, 220);
            btnAddCorrelativas.Name = "btnAddCorrelativas";
            btnAddCorrelativas.Size = new Size(186, 40);
            btnAddCorrelativas.TabIndex = 4;
            btnAddCorrelativas.Text = "Agregar Correlatividad";
            btnAddCorrelativas.UseVisualStyleBackColor = false;
            btnAddCorrelativas.Click += btnAddCorrelativas_Click;
            // 
            // cbbCorrelativas
            // 
            cbbCorrelativas.BackColor = Color.FromArgb(35, 39, 42);
            cbbCorrelativas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCorrelativas.FlatStyle = FlatStyle.Flat;
            cbbCorrelativas.ForeColor = Color.White;
            cbbCorrelativas.FormattingEnabled = true;
            cbbCorrelativas.Location = new Point(384, 148);
            cbbCorrelativas.Name = "cbbCorrelativas";
            cbbCorrelativas.Size = new Size(221, 28);
            cbbCorrelativas.TabIndex = 1;
            // 
            // btnRemoveCorrelative
            // 
            btnRemoveCorrelative.BackColor = Color.FromArgb(244, 67, 54);
            btnRemoveCorrelative.FlatAppearance.BorderSize = 0;
            btnRemoveCorrelative.FlatStyle = FlatStyle.Flat;
            btnRemoveCorrelative.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveCorrelative.ForeColor = Color.WhiteSmoke;
            btnRemoveCorrelative.Location = new Point(3, 5);
            btnRemoveCorrelative.Name = "btnRemoveCorrelative";
            btnRemoveCorrelative.Size = new Size(289, 40);
            btnRemoveCorrelative.TabIndex = 5;
            btnRemoveCorrelative.Text = "Remover correlatividad seleccionada";
            btnRemoveCorrelative.UseVisualStyleBackColor = false;
            btnRemoveCorrelative.Click += btnRemoveCorrelative_Click;
            // 
            // lblsubjectName
            // 
            lblsubjectName.AutoSize = true;
            lblsubjectName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblsubjectName.ForeColor = Color.FromArgb(255, 152, 0);
            lblsubjectName.Location = new Point(258, 105);
            lblsubjectName.Name = "lblsubjectName";
            lblsubjectName.Size = new Size(120, 28);
            lblsubjectName.TabIndex = 48;
            lblsubjectName.Text = "MateriaAqui";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkEstado.ForeColor = Color.White;
            chkEstado.Location = new Point(15, 181);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(708, 32);
            chkEstado.TabIndex = 2;
            chkEstado.Text = "Se requiere la acreditación final de la materia seleccionada para poder cursar :";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // checkBoxEspecial
            // 
            checkBoxSpecial.AutoSize = true;
            checkBoxSpecial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSpecial.Location = new Point(613, 146);
            checkBoxSpecial.Name = "checkBoxEspecial";
            checkBoxSpecial.Size = new Size(316, 32);
            checkBoxSpecial.TabIndex = 3;
            checkBoxSpecial.Text = "Mostrar materias del mismo año";
            checkBoxSpecial.UseVisualStyleBackColor = true;
            checkBoxSpecial.CheckStateChanged += checkBoxSpecial_CheckStateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 152, 0);
            label3.Location = new Point(3, 105);
            label3.Name = "label3";
            label3.Size = new Size(256, 28);
            label3.TabIndex = 52;
            label3.Text = "Agregar correlatividades a : ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 47, 51);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblmateriaName2);
            panel1.Controls.Add(btnRemoveCorrelative);
            panel1.Controls.Add(checkBoxSpecial);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblsubjectName);
            panel1.Controls.Add(btnAddCorrelativas);
            panel1.Controls.Add(chkEstado);
            panel1.Controls.Add(cbbCorrelativas);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 272);
            panel1.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(3, 148);
            label2.Name = "label2";
            label2.Size = new Size(375, 28);
            label2.TabIndex = 54;
            label2.Text = "Seleccione una nueva materia correlativa :";
            // 
            // lblmateriaName2
            // 
            lblmateriaName2.AutoSize = true;
            lblmateriaName2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblmateriaName2.ForeColor = Color.FromArgb(255, 152, 0);
            lblmateriaName2.Location = new Point(720, 182);
            lblmateriaName2.Name = "lblmateriaName2";
            lblmateriaName2.Size = new Size(120, 28);
            lblmateriaName2.TabIndex = 53;
            lblmateriaName2.Text = "MateriaAqui";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewCorrelatives);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1242, 249);
            panel2.TabIndex = 54;
            // 
            // formSubjectCorrelatives
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(1242, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formSubjectCorrelatives";
            Text = "Gestin - Correlativas Materia";
            FormClosing += formSubjectCorrelatives_FormClosing;
            Load += formSubjectCorrelatives_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCorrelatives).EndInit();
            ((System.ComponentModel.ISupportInitialize)correlativeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCorrelativasExceptSame).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewCorrelatives;
        private Button btnAddCorrelativas;
        private ComboBox cbbCorrelativas;
        private BindingSource bindingSourceCorrelativasExceptSame;
        private Button btnRemoveCorrelative;
        private Label lblsubjectName;
        private CheckBox chkEstado;
        private DataGridViewCheckBoxColumn correlativeFinalDataGridViewCheckBoxColumn;
        private CheckBox checkBoxSpecial;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn CorrelativeFinal;
        private Label label2;
        private Label lblmateriaName2;
        private DataGridViewTextBoxColumn correlativeSubjectDataGridViewTextBoxColumn;
        private BindingSource correlativeBindingSource;
    }
}