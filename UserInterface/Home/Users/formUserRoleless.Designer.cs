namespace Gestin.UI.Home.Users
{
    partial class formUserRoleless
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
            userBindingSource = new BindingSource(components);
            dataGridViewRoleless = new DataGridView();
            btnReactivateUser = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deletedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoleless).BeginInit();
            SuspendLayout();
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Model.User);
            // 
            // dataGridViewRoleless
            // 
            dataGridViewRoleless.AllowUserToAddRows = false;
            dataGridViewRoleless.AllowUserToDeleteRows = false;
            dataGridViewRoleless.AllowUserToResizeColumns = false;
            dataGridViewRoleless.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(54, 57, 63);
            dataGridViewRoleless.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRoleless.AutoGenerateColumns = false;
            dataGridViewRoleless.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoleless.BackgroundColor = Color.FromArgb(35, 39, 42);
            dataGridViewRoleless.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewRoleless.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRoleless.ColumnHeadersHeight = 54;
            dataGridViewRoleless.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewRoleless.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, deletedAtDataGridViewTextBoxColumn });
            dataGridViewRoleless.DataSource = userBindingSource;
            dataGridViewRoleless.Dock = DockStyle.Fill;
            dataGridViewRoleless.EnableHeadersVisualStyles = false;
            dataGridViewRoleless.Location = new Point(0, 0);
            dataGridViewRoleless.MultiSelect = false;
            dataGridViewRoleless.Name = "dataGridViewRoleless";
            dataGridViewRoleless.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 39, 42);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRoleless.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRoleless.RowHeadersVisible = false;
            dataGridViewRoleless.RowHeadersWidth = 51;
            dataGridViewRoleless.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(35, 39, 42);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewRoleless.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewRoleless.RowTemplate.Height = 29;
            dataGridViewRoleless.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoleless.Size = new Size(800, 450);
            dataGridViewRoleless.TabIndex = 0;
            dataGridViewRoleless.ColumnHeaderMouseClick += dataGridViewRoleless_ColumnHeaderMouseClick;
            dataGridViewRoleless.SelectionChanged += dataGridViewRoleless_SelectionChanged;
            // 
            // btnReactivateUser
            // 
            btnReactivateUser.BackColor = Color.FromArgb(0, 150, 136);
            btnReactivateUser.FlatAppearance.BorderSize = 0;
            btnReactivateUser.FlatStyle = FlatStyle.Flat;
            btnReactivateUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReactivateUser.ForeColor = Color.White;
            btnReactivateUser.Location = new Point(602, 398);
            btnReactivateUser.Margin = new Padding(3, 4, 3, 4);
            btnReactivateUser.Name = "btnReactivateUser";
            btnReactivateUser.Size = new Size(143, 52);
            btnReactivateUser.TabIndex = 6;
            btnReactivateUser.Text = "Reactivar Usuario";
            btnReactivateUser.UseVisualStyleBackColor = false;
            btnReactivateUser.Click += btnReactivateUser_Click;
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
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deletedAtDataGridViewTextBoxColumn
            // 
            deletedAtDataGridViewTextBoxColumn.DataPropertyName = "DeletedAt";
            deletedAtDataGridViewTextBoxColumn.HeaderText = "DeletedAt";
            deletedAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            deletedAtDataGridViewTextBoxColumn.Name = "deletedAtDataGridViewTextBoxColumn";
            deletedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formUserRoleless
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(800, 450);
            Controls.Add(btnReactivateUser);
            Controls.Add(dataGridViewRoleless);
            ForeColor = SystemColors.ControlText;
            Name = "formUserRoleless";
            Text = "Gestin - Usuarios sin rol";
            FormClosing += formUserRoleless_FormClosing;
            Load += formUserRoleless_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoleless).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource userBindingSource;
        private DataGridView dataGridViewRoleless;
        private Button btnReactivateUser;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deletedAtDataGridViewTextBoxColumn;
    }
}