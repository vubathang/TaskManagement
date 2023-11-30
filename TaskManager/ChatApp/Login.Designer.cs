namespace TaskManager.ChatApp
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txbUsername = new TextBox();
            label3 = new Label();
            txbPort = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 129);
            label1.Name = "label1";
            label1.Size = new Size(553, 38);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 204);
            label2.Name = "label2";
            label2.Size = new Size(161, 37);
            label2.TabIndex = 2;
            label2.Text = "Username ";
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(230, 201);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(299, 40);
            txbUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 268);
            label3.Name = "label3";
            label3.Size = new Size(81, 37);
            label3.TabIndex = 2;
            label3.Text = "Port";
            // 
            // txbPort
            // 
            txbPort.Location = new Point(230, 265);
            txbPort.Name = "txbPort";
            txbPort.Size = new Size(299, 40);
            txbPort.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(194, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 60);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 129);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_chat1;
            pictureBox1.Location = new Point(219, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(553, 429);
            Controls.Add(btnLogin);
            Controls.Add(txbPort);
            Controls.Add(txbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Cascadia Mono", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbUsername;
        private Label label3;
        private TextBox txbPort;
        private Button btnLogin;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}