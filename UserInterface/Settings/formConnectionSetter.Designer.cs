namespace Gestin.UI.Settings
{
    partial class formConnectionSetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConnectionSetter));
            btnSelectedConnection = new Button();
            lblSelected = new Label();
            cbbConnections = new ComboBox();
            txtServer = new TextBox();
            txtDatabase = new TextBox();
            label2 = new Label();
            label3 = new Label();
            chkTrustedSource = new CheckBox();
            cbbTimeout = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            lblExistingConnection = new Label();
            lblWarning = new Label();
            label5 = new Label();
            txtUserId = new TextBox();
            lblUserID = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtPort = new TextBox();
            btnCopy = new Button();
            toolTip = new ToolTip(components);
            chkEncrypt = new CheckBox();
            cbbInstance = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnSelectedConnection
            // 
            btnSelectedConnection.BackColor = Color.FromArgb(0, 150, 136);
            btnSelectedConnection.FlatStyle = FlatStyle.Flat;
            btnSelectedConnection.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSelectedConnection.ForeColor = Color.White;
            btnSelectedConnection.Location = new Point(404, 525);
            btnSelectedConnection.Name = "btnSelectedConnection";
            btnSelectedConnection.Size = new Size(107, 59);
            btnSelectedConnection.TabIndex = 8;
            btnSelectedConnection.Text = "Conectar";
            btnSelectedConnection.UseVisualStyleBackColor = false;
            btnSelectedConnection.Click += btnSelectedConnection_Click;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblSelected.ForeColor = Color.White;
            lblSelected.Location = new Point(29, 112);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(601, 20);
            lblSelected.TabIndex = 1;
            lblSelected.Text = "Seleccione una conexión predefinida o ingrese valores en los campos:";
            // 
            // cbbConnections
            // 
            cbbConnections.BackColor = Color.FromArgb(44, 47, 51);
            cbbConnections.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbConnections.FlatStyle = FlatStyle.Flat;
            cbbConnections.Font = new Font("Microsoft Sans Serif", 10.2F);
            cbbConnections.ForeColor = Color.White;
            cbbConnections.FormattingEnabled = true;
            cbbConnections.Location = new Point(29, 135);
            cbbConnections.Name = "cbbConnections";
            cbbConnections.Size = new Size(869, 28);
            cbbConnections.TabIndex = 1;
            cbbConnections.SelectedIndexChanged += cbbConnections_SelectedIndexChanged;
            // 
            // txtServer
            // 
            txtServer.BackColor = Color.FromArgb(44, 47, 51);
            txtServer.BorderStyle = BorderStyle.FixedSingle;
            txtServer.Font = new Font("Segoe UI", 12F);
            txtServer.ForeColor = Color.White;
            txtServer.Location = new Point(225, 219);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(624, 34);
            txtServer.TabIndex = 2;
            // 
            // txtDatabase
            // 
            txtDatabase.BackColor = Color.FromArgb(44, 47, 51);
            txtDatabase.BorderStyle = BorderStyle.FixedSingle;
            txtDatabase.Font = new Font("Segoe UI", 12F);
            txtDatabase.ForeColor = Color.White;
            txtDatabase.Location = new Point(225, 385);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(220, 34);
            txtDatabase.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 225);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 8;
            label2.Text = "Servidor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 389);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 9;
            label3.Text = "Base de Datos:";
            // 
            // chkTrustedSource
            // 
            chkTrustedSource.AutoSize = true;
            chkTrustedSource.Font = new Font("Microsoft Sans Serif", 12F);
            chkTrustedSource.ForeColor = Color.White;
            chkTrustedSource.Location = new Point(225, 259);
            chkTrustedSource.Name = "chkTrustedSource";
            chkTrustedSource.Size = new Size(211, 29);
            chkTrustedSource.TabIndex = 7;
            chkTrustedSource.Text = "Seguridad Integrada";
            chkTrustedSource.UseVisualStyleBackColor = true;
            // 
            // cbbTimeout
            // 
            cbbTimeout.BackColor = Color.FromArgb(44, 47, 51);
            cbbTimeout.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimeout.FlatStyle = FlatStyle.Flat;
            cbbTimeout.Font = new Font("Microsoft Sans Serif", 12F);
            cbbTimeout.ForeColor = Color.White;
            cbbTimeout.FormattingEnabled = true;
            cbbTimeout.Items.AddRange(new object[] { "0", "3", "5", "10", "15", "30", "60" });
            cbbTimeout.Location = new Point(629, 389);
            cbbTimeout.Name = "cbbTimeout";
            cbbTimeout.Size = new Size(220, 33);
            cbbTimeout.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(485, 391);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 13;
            label1.Text = "Timeout:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 41);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 15;
            label4.Text = "Conexión Actual:";
            // 
            // lblExistingConnection
            // 
            lblExistingConnection.BorderStyle = BorderStyle.Fixed3D;
            lblExistingConnection.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblExistingConnection.ForeColor = Color.FromArgb(255, 128, 128);
            lblExistingConnection.Location = new Point(29, 61);
            lblExistingConnection.Name = "lblExistingConnection";
            lblExistingConnection.Size = new Size(828, 28);
            lblExistingConnection.TabIndex = 16;
            lblExistingConnection.Text = "                                                                     ";
            lblExistingConnection.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            lblWarning.ForeColor = Color.White;
            lblWarning.Location = new Point(1, 600);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(408, 34);
            lblWarning.TabIndex = 17;
            lblWarning.Text = "*Gestin se reiniciara si la conexión fue modificada exitosamente.\r\n\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(485, 467);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 21;
            label5.Text = "Contraseña:";
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.FromArgb(44, 47, 51);
            txtUserId.BorderStyle = BorderStyle.FixedSingle;
            txtUserId.Font = new Font("Segoe UI", 12F);
            txtUserId.ForeColor = Color.White;
            txtUserId.Location = new Point(225, 461);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(220, 34);
            txtUserId.TabIndex = 5;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserID.ForeColor = Color.White;
            lblUserID.Location = new Point(55, 463);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(89, 28);
            lblUserID.TabIndex = 19;
            lblUserID.Text = "Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(44, 47, 51);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(629, 465);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 34);
            txtPassword.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(56, 314);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 23;
            label6.Text = "Puerto:";
            // 
            // txtPort
            // 
            txtPort.BackColor = Color.FromArgb(44, 47, 51);
            txtPort.BorderStyle = BorderStyle.FixedSingle;
            txtPort.Font = new Font("Segoe UI", 12F);
            txtPort.ForeColor = Color.White;
            txtPort.Location = new Point(225, 316);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(220, 34);
            txtPort.TabIndex = 24;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(0, 150, 136);
            btnCopy.BackgroundImage = Properties.Resources.LeftArrowIcon;
            btnCopy.BackgroundImageLayout = ImageLayout.Stretch;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.ForeColor = Color.FromArgb(0, 150, 136);
            btnCopy.Location = new Point(863, 55);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(35, 35);
            btnCopy.TabIndex = 25;
            toolTip.SetToolTip(btnCopy, "Copiar conexión actual");
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // toolTip
            // 
            toolTip.AutomaticDelay = 0;
            toolTip.IsBalloon = true;
            // 
            // chkEncrypt
            // 
            chkEncrypt.AutoSize = true;
            chkEncrypt.Font = new Font("Microsoft Sans Serif", 12F);
            chkEncrypt.ForeColor = Color.White;
            chkEncrypt.Location = new Point(674, 259);
            chkEncrypt.Name = "chkEncrypt";
            chkEncrypt.Size = new Size(111, 29);
            chkEncrypt.TabIndex = 28;
            chkEncrypt.Text = "Encriptar";
            toolTip.SetToolTip(chkEncrypt, "Destildar si hubo un error SSL (Autoridad no segura)");
            chkEncrypt.UseVisualStyleBackColor = true;
            // 
            // cbbInstance
            // 
            cbbInstance.BackColor = Color.FromArgb(44, 47, 51);
            cbbInstance.FlatStyle = FlatStyle.Flat;
            cbbInstance.Font = new Font("Microsoft Sans Serif", 12F);
            cbbInstance.ForeColor = Color.White;
            cbbInstance.FormattingEnabled = true;
            cbbInstance.Items.AddRange(new object[] { "", "\\SQLEXPRESS" });
            cbbInstance.Location = new Point(629, 309);
            cbbInstance.Name = "cbbInstance";
            cbbInstance.Size = new Size(220, 33);
            cbbInstance.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(485, 316);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 27;
            label7.Text = "Instancia:";
            // 
            // formConnectionSetter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(930, 621);
            Controls.Add(chkEncrypt);
            Controls.Add(label7);
            Controls.Add(cbbInstance);
            Controls.Add(btnCopy);
            Controls.Add(txtPort);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtUserId);
            Controls.Add(lblUserID);
            Controls.Add(lblWarning);
            Controls.Add(lblExistingConnection);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cbbTimeout);
            Controls.Add(chkTrustedSource);
            Controls.Add(txtServer);
            Controls.Add(txtDatabase);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(cbbConnections);
            Controls.Add(lblSelected);
            Controls.Add(btnSelectedConnection);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "formConnectionSetter";
            Text = "Gestin - Conexión";
            FormClosed += formConnectionSetter_FormClosed;
            Load += formConnectionSetter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectedConnection;
        private Label lblSelected;
        private ComboBox cbbConnections;
        private TextBox txtServer;
        private TextBox txtDatabase;
        private Label label2;
        private Label label3;
        private CheckBox chkTrustedSource;
        private ComboBox cbbTimeout;
        private Label label1;
        private Label label4;
        private Label lblExistingConnection;
        private Label lblWarning;
        private Label label5;
        private TextBox txtUserId;
        private Label lblUserID;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtPort;
        private Button btnCopy;
        private ToolTip toolTip;
        private ComboBox cbbInstance;
        private Label label7;
        private CheckBox chkEncrypt;
    }
}