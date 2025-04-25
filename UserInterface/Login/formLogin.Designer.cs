namespace Gestin.UI.Login
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panel1 = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            panel2 = new Panel();
            linkReportarError = new LinkLabel();
            panel3 = new Panel();
            chkRemember = new CheckBox();
            pictureBox1 = new PictureBox();
            cbbUserType = new ComboBox();
            label3 = new Label();
            lblSessionCheck = new Label();
            btnViewPass = new PictureBox();
            linkRegistrarse = new LinkLabel();
            linkRecuperarPassword = new LinkLabel();
            lblPasswordVacio = new Label();
            lblEmailVacio = new Label();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            timerHideError = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnViewPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 29);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(361, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(20, 20);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(387, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 150, 136);
            panel2.Controls.Add(linkReportarError);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 556);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 18);
            panel2.TabIndex = 10;
            // 
            // linkReportarError
            // 
            linkReportarError.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            linkReportarError.AutoSize = true;
            linkReportarError.DisabledLinkColor = Color.Black;
            linkReportarError.ForeColor = Color.Black;
            linkReportarError.LinkColor = Color.FromArgb(44, 47, 51);
            linkReportarError.Location = new Point(287, -2);
            linkReportarError.Name = "linkReportarError";
            linkReportarError.Size = new Size(123, 20);
            linkReportarError.TabIndex = 6;
            linkReportarError.TabStop = true;
            linkReportarError.Text = "Reportar un error!";
            linkReportarError.VisitedLinkColor = Color.Black;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 47, 51);
            panel3.Controls.Add(chkRemember);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(cbbUserType);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblSessionCheck);
            panel3.Controls.Add(btnViewPass);
            panel3.Controls.Add(linkRegistrarse);
            panel3.Controls.Add(linkRecuperarPassword);
            panel3.Controls.Add(lblPasswordVacio);
            panel3.Controls.Add(lblEmailVacio);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtEmail);
            panel3.Location = new Point(12, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 444);
            panel3.TabIndex = 11;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(252, 117);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(94, 24);
            chkRemember.TabIndex = 29;
            chkRemember.Text = "Recordar?";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // cbbUserType
            // 
            cbbUserType.BackColor = Color.FromArgb(35, 39, 42);
            cbbUserType.Font = new Font("Segoe UI", 12F);
            cbbUserType.ForeColor = Color.White;
            cbbUserType.FormattingEnabled = true;
            cbbUserType.Items.AddRange(new object[] { "Estudiante", "Docente" });
            cbbUserType.Location = new Point(65, 42);
            cbbUserType.Name = "cbbUserType";
            cbbUserType.Size = new Size(281, 36);
            cbbUserType.TabIndex = 27;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 10);
            label3.Name = "label3";
            label3.Size = new Size(186, 29);
            label3.TabIndex = 26;
            label3.Text = "Tipo de Usuario";
            // 
            // lblSessionCheck
            // 
            lblSessionCheck.AutoSize = true;
            lblSessionCheck.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblSessionCheck.ForeColor = Color.DarkGray;
            lblSessionCheck.Image = (Image)resources.GetObject("lblSessionCheck.Image");
            lblSessionCheck.ImageAlign = ContentAlignment.MiddleLeft;
            lblSessionCheck.Location = new Point(17, 378);
            lblSessionCheck.Name = "lblSessionCheck";
            lblSessionCheck.Size = new Size(329, 18);
            lblSessionCheck.TabIndex = 24;
            lblSessionCheck.Text = "          Datos invalidos, intente nuevamente";
            lblSessionCheck.Visible = false;
            // 
            // btnViewPass
            // 
            btnViewPass.Anchor = AnchorStyles.None;
            btnViewPass.BackColor = Color.FromArgb(44, 47, 51);
            btnViewPass.Cursor = Cursors.Hand;
            btnViewPass.Image = (Image)resources.GetObject("btnViewPass.Image");
            btnViewPass.Location = new Point(349, 247);
            btnViewPass.Name = "btnViewPass";
            btnViewPass.Size = new Size(25, 25);
            btnViewPass.SizeMode = PictureBoxSizeMode.StretchImage;
            btnViewPass.TabIndex = 23;
            btnViewPass.TabStop = false;
            btnViewPass.Click += btnViewPass_Click;
            // 
            // linkRegistrarse
            // 
            linkRegistrarse.ActiveLinkColor = Color.DarkGray;
            linkRegistrarse.AutoSize = true;
            linkRegistrarse.ForeColor = Color.Gray;
            linkRegistrarse.LinkColor = Color.Gray;
            linkRegistrarse.Location = new Point(17, 413);
            linkRegistrarse.Name = "linkRegistrarse";
            linkRegistrarse.Size = new Size(119, 20);
            linkRegistrarse.TabIndex = 5;
            linkRegistrarse.TabStop = true;
            linkRegistrarse.Text = "Crear una cuenta";
            linkRegistrarse.LinkClicked += linkRegistrarse_LinkClicked;
            // 
            // linkRecuperarPassword
            // 
            linkRecuperarPassword.ActiveLinkColor = Color.DarkGray;
            linkRecuperarPassword.AutoSize = true;
            linkRecuperarPassword.DisabledLinkColor = Color.Gray;
            linkRecuperarPassword.ForeColor = Color.Gray;
            linkRecuperarPassword.LinkColor = Color.Gray;
            linkRecuperarPassword.Location = new Point(232, 413);
            linkRecuperarPassword.Name = "linkRecuperarPassword";
            linkRecuperarPassword.Size = new Size(145, 20);
            linkRecuperarPassword.TabIndex = 4;
            linkRecuperarPassword.TabStop = true;
            linkRecuperarPassword.Text = "Olvide mi contraseña";
            linkRecuperarPassword.LinkClicked += linkRecuperarPassword_LinkClicked;
            // 
            // lblPasswordVacio
            // 
            lblPasswordVacio.AutoSize = true;
            lblPasswordVacio.Font = new Font("Microsoft Sans Serif", 9F);
            lblPasswordVacio.ForeColor = Color.DarkGray;
            lblPasswordVacio.Image = (Image)resources.GetObject("lblPasswordVacio.Image");
            lblPasswordVacio.ImageAlign = ContentAlignment.MiddleLeft;
            lblPasswordVacio.Location = new Point(34, 281);
            lblPasswordVacio.Name = "lblPasswordVacio";
            lblPasswordVacio.Size = new Size(282, 18);
            lblPasswordVacio.TabIndex = 20;
            lblPasswordVacio.Text = "          La contraseña no puede estar vacia";
            lblPasswordVacio.Visible = false;
            // 
            // lblEmailVacio
            // 
            lblEmailVacio.AutoSize = true;
            lblEmailVacio.Font = new Font("Microsoft Sans Serif", 9F);
            lblEmailVacio.ForeColor = Color.DarkGray;
            lblEmailVacio.Image = (Image)resources.GetObject("lblEmailVacio.Image");
            lblEmailVacio.ImageAlign = ContentAlignment.MiddleLeft;
            lblEmailVacio.Location = new Point(34, 181);
            lblEmailVacio.Name = "lblEmailVacio";
            lblEmailVacio.Size = new Size(241, 18);
            lblEmailVacio.TabIndex = 19;
            lblEmailVacio.Text = "          El email no puede estar vacio";
            lblEmailVacio.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 150, 136);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(97, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(178, 51);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 243);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 210);
            label2.Name = "label2";
            label2.Size = new Size(136, 29);
            label2.TabIndex = 15;
            label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(35, 39, 42);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.ImeMode = ImeMode.NoControl;
            txtPassword.Location = new Point(65, 242);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(281, 35);
            txtPassword.TabIndex = 2;
            txtPassword.WordWrap = false;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 111);
            label1.Name = "label1";
            label1.Size = new Size(74, 29);
            label1.TabIndex = 12;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(35, 39, 42);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.White;
            txtEmail.ImeMode = ImeMode.NoControl;
            txtEmail.Location = new Point(65, 143);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 35);
            txtEmail.TabIndex = 1;
            txtEmail.WordWrap = false;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 26.25F);
            label5.Location = new Point(145, 45);
            label5.Name = "label5";
            label5.Size = new Size(128, 52);
            label5.TabIndex = 12;
            label5.Text = "Login";
            // 
            // timerHideError
            // 
            timerHideError.Tick += timerHideError_Tick;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 40);
            ClientSize = new Size(410, 574);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            Text = "formLogin";
            Load += formLogin_Load;
            KeyPress += formLogin_KeyPress;
            MouseDown += formLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnViewPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private LinkLabel linkRegistrarse;
        private LinkLabel linkRecuperarPassword;
        private Label lblPasswordVacio;
        private Label lblEmailVacio;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtEmail;
        private LinkLabel linkReportarError;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private PictureBox btnViewPass;
        private Label label5;
        private Label lblSessionCheck;
        private PictureBox pictureBox1;
        private ComboBox cbbUserType;
        private Label label3;
        private System.Windows.Forms.Timer timerHideError;
        private CheckBox chkRemember;
    }
}