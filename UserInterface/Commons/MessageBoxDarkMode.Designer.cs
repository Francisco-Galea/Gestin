namespace Gestin.UI.Custom
{
    partial class MessageBoxDarkMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxDarkMode));
            panel1 = new Panel();
            btnCancel = new Button();
            btnConfirm = new Button();
            pictureBoxImage = new PictureBox();
            lblMessage = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 47, 51);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnConfirm);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 80);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(35, 39, 42);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(369, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(35, 39, 42);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnConfirm.Location = new Point(102, 15);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(100, 50);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Ok";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Visible = false;
            btnConfirm.Click += btnOk_Click;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxImage.Location = new Point(12, 35);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(100, 100);
            pictureBoxImage.TabIndex = 1;
            pictureBoxImage.TabStop = false;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblMessage.Location = new Point(140, 28);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(402, 111);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Message";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 39, 42);
            panel2.Controls.Add(lblMessage);
            panel2.Controls.Add(pictureBoxImage);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 164);
            panel2.TabIndex = 3;
            // 
            // MessageBoxDarkMode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 42);
            ClientSize = new Size(582, 244);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MessageBoxDarkMode";
            Text = "MessageBoxDarkMode";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnConfirm;
        private PictureBox pictureBoxImage;
        private Label lblMessage;
        private Button btnCancel;
        private Panel panel2;
    }
}