namespace TaskManager.Chat
{
    partial class ClientForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            groupBox1 = new GroupBox();
            txbClientChat = new TextBox();
            txbClientMess = new TextBox();
            btnClientSend = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblUsername);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 82);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(89, 26);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 33);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Client";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txbClientChat);
            groupBox1.Controls.Add(txbClientMess);
            groupBox1.Controls.Add(btnClientSend);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 450);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chat ";
            // 
            // txbClientChat
            // 
            txbClientChat.Location = new Point(12, 38);
            txbClientChat.Multiline = true;
            txbClientChat.Name = "txbClientChat";
            txbClientChat.ReadOnly = true;
            txbClientChat.Size = new Size(567, 336);
            txbClientChat.TabIndex = 4;
            // 
            // txbClientMess
            // 
            txbClientMess.Location = new Point(12, 395);
            txbClientMess.Name = "txbClientMess";
            txbClientMess.Size = new Size(409, 39);
            txbClientMess.TabIndex = 0;
            // 
            // btnClientSend
            // 
            btnClientSend.Location = new Point(443, 390);
            btnClientSend.Name = "btnClientSend";
            btnClientSend.Size = new Size(136, 48);
            btnClientSend.TabIndex = 1;
            btnClientSend.Text = "Send";
            btnClientSend.UseVisualStyleBackColor = true;
            btnClientSend.Click += btnClientSend_Click;
            // 
            // ClientForm
            // 
            AcceptButton = btnClientSend;
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 532);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "ClientForm";
            Text = "Chat application";
            FormClosing += ClientForm_FormClosing;
            Load += ClientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblUsername;
        private GroupBox groupBox1;
        private TextBox txbClientMess;
        private Button btnClientSend;
        private TextBox txbClientChat;
        private PictureBox pictureBox1;
    }
}