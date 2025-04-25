namespace Gestin.Deprecated
{
    partial class formRecoverPass
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbViewConfPass = new System.Windows.Forms.PictureBox();
            this.pbViewPass = new System.Windows.Forms.PictureBox();
            this.pbViewCod = new System.Windows.Forms.PictureBox();
            this.lblError2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVerifyNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodVerificacion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewConfPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewCod)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(506, 55);
            this.label5.TabIndex = 13;
            this.label5.Text = "Recuperar contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 39);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picClose
            // 
            this.picClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::Gestin.Properties.Resources.Close;
            this.picClose.Location = new System.Drawing.Point(502, 4);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(23, 27);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 15;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.lblError1);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Location = new System.Drawing.Point(33, 193);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 244);
            this.panel3.TabIndex = 15;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblError1.Image = global::Gestin.Properties.Resources.Error;
            this.lblError1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError1.Location = new System.Drawing.Point(58, 155);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(317, 20);
            this.lblError1.TabIndex = 25;
            this.lblError1.Text = "          Datos invalidos, intente nuevamente";
            this.lblError1.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(179, 181);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 39);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Recuperar contraseña";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese su email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(34, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 33);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pbViewConfPass);
            this.panel2.Controls.Add(this.pbViewPass);
            this.panel2.Controls.Add(this.pbViewCod);
            this.panel2.Controls.Add(this.lblError2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtVerifyNewPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNewPass);
            this.panel2.Controls.Add(this.btnChangePass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCodVerificacion);
            this.panel2.Location = new System.Drawing.Point(33, 174);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 456);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // pbViewConfPass
            // 
            this.pbViewConfPass.Image = global::Gestin.Properties.Resources.Eye;
            this.pbViewConfPass.Location = new System.Drawing.Point(429, 281);
            this.pbViewConfPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbViewConfPass.Name = "pbViewConfPass";
            this.pbViewConfPass.Size = new System.Drawing.Size(24, 24);
            this.pbViewConfPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewConfPass.TabIndex = 28;
            this.pbViewConfPass.TabStop = false;
            this.pbViewConfPass.Click += new System.EventHandler(this.pbViewConfPass_Click);
            // 
            // pbViewPass
            // 
            this.pbViewPass.Image = global::Gestin.Properties.Resources.Eye;
            this.pbViewPass.Location = new System.Drawing.Point(429, 169);
            this.pbViewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbViewPass.Name = "pbViewPass";
            this.pbViewPass.Size = new System.Drawing.Size(24, 24);
            this.pbViewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewPass.TabIndex = 27;
            this.pbViewPass.TabStop = false;
            this.pbViewPass.Click += new System.EventHandler(this.pbViewPass_Click);
            // 
            // pbViewCod
            // 
            this.pbViewCod.Image = global::Gestin.Properties.Resources.Eye;
            this.pbViewCod.Location = new System.Drawing.Point(429, 73);
            this.pbViewCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbViewCod.Name = "pbViewCod";
            this.pbViewCod.Size = new System.Drawing.Size(24, 24);
            this.pbViewCod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbViewCod.TabIndex = 26;
            this.pbViewCod.TabStop = false;
            this.pbViewCod.Click += new System.EventHandler(this.pbViewCod_Click);
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblError2.Image = global::Gestin.Properties.Resources.Error;
            this.lblError2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError2.Location = new System.Drawing.Point(80, 336);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(317, 20);
            this.lblError2.TabIndex = 25;
            this.lblError2.Text = "          Datos invalidos, intente nuevamente";
            this.lblError2.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirmar su contraseña";
            // 
            // txtVerifyNewPass
            // 
            this.txtVerifyNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerifyNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtVerifyNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerifyNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVerifyNewPass.ForeColor = System.Drawing.Color.White;
            this.txtVerifyNewPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtVerifyNewPass.Location = new System.Drawing.Point(34, 281);
            this.txtVerifyNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVerifyNewPass.Multiline = true;
            this.txtVerifyNewPass.Name = "txtVerifyNewPass";
            this.txtVerifyNewPass.PasswordChar = '*';
            this.txtVerifyNewPass.Size = new System.Drawing.Size(383, 33);
            this.txtVerifyNewPass.TabIndex = 16;
            this.txtVerifyNewPass.WordWrap = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingresar una contraseña nueva";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPass.ForeColor = System.Drawing.Color.White;
            this.txtNewPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNewPass.Location = new System.Drawing.Point(34, 175);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(387, 33);
            this.txtNewPass.TabIndex = 14;
            this.txtNewPass.WordWrap = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(113, 400);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(230, 39);
            this.btnChangePass.TabIndex = 13;
            this.btnChangePass.Text = "Cambiar contraseña";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingresar codigo de verificacion";
            // 
            // txtCodVerificacion
            // 
            this.txtCodVerificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodVerificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtCodVerificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodVerificacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodVerificacion.ForeColor = System.Drawing.Color.White;
            this.txtCodVerificacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodVerificacion.Location = new System.Drawing.Point(34, 72);
            this.txtCodVerificacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodVerificacion.Multiline = true;
            this.txtCodVerificacion.Name = "txtCodVerificacion";
            this.txtCodVerificacion.PasswordChar = '*';
            this.txtCodVerificacion.Size = new System.Drawing.Size(387, 33);
            this.txtCodVerificacion.TabIndex = 1;
            this.txtCodVerificacion.WordWrap = false;
            // 
            // formRecoverPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(529, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formRecoverPass";
            this.Text = "formRecuperarPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formRecuperarPassword_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewConfPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Panel panel1;
        private PictureBox picClose;
        private Panel panel3;
        private Label label1;
        private TextBox txtEmail;
        private Button btnLogin;
        private Panel panel2;
        private Button btnChangePass;
        private Label label2;
        private TextBox txtCodVerificacion;
        private Label label4;
        private TextBox txtVerifyNewPass;
        private Label label3;
        private TextBox txtNewPass;
        private Label lblError1;
        private Label lblError2;
        private PictureBox pbViewConfPass;
        private PictureBox pbViewPass;
        private PictureBox pbViewCod;
    }
}