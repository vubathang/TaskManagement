namespace TaskManager.Chat
{
    partial class ServerForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txbServerChat = new TextBox();
            txbServerMess = new TextBox();
            btnServerSend = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 21);
            label1.Name = "label1";
            label1.Size = new Size(131, 40);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbServerChat);
            groupBox1.Controls.Add(txbServerMess);
            groupBox1.Controls.Add(btnServerSend);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 450);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Messages";
            // 
            // txbServerChat
            // 
            txbServerChat.Location = new Point(12, 38);
            txbServerChat.Multiline = true;
            txbServerChat.Name = "txbServerChat";
            txbServerChat.Size = new Size(567, 336);
            txbServerChat.TabIndex = 3;
            // 
            // txbServerMess
            // 
            txbServerMess.Location = new Point(23, 395);
            txbServerMess.Name = "txbServerMess";
            txbServerMess.Size = new Size(398, 39);
            txbServerMess.TabIndex = 3;
            // 
            // btnServerSend
            // 
            btnServerSend.Location = new Point(443, 390);
            btnServerSend.Name = "btnServerSend";
            btnServerSend.Size = new Size(136, 48);
            btnServerSend.TabIndex = 1;
            btnServerSend.Text = "Send";
            btnServerSend.UseVisualStyleBackColor = true;
            btnServerSend.Click += btnServerSend_Click;
            // 
            // ServerForm
            // 
            AcceptButton = btnServerSend;
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 532);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "ServerForm";
            Text = "Server";
            Load += ServerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txbServerMess;
        private Button btnServerSend;
        private TextBox txbServerChat;
    }
}