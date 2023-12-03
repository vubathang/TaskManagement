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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txbClientChat = new TextBox();
            txbClientMess = new TextBox();
            btnClientSend = new Button();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 21);
            label1.Name = "label1";
            label1.Size = new Size(131, 40);
            label1.TabIndex = 0;
            label1.Text = "Client";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbClientChat);
            groupBox1.Controls.Add(txbClientMess);
            groupBox1.Controls.Add(btnClientSend);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 450);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Messages";
            // 
            // txbClientChat
            // 
            txbClientChat.Location = new Point(12, 38);
            txbClientChat.Multiline = true;
            txbClientChat.Name = "txbClientChat";
            txbClientChat.Size = new Size(567, 316);
            txbClientChat.TabIndex = 4;
            // 
            // txbClientMess
            // 
            txbClientMess.Location = new Point(23, 395);
            txbClientMess.Name = "txbClientMess";
            txbClientMess.Size = new Size(273, 39);
            txbClientMess.TabIndex = 3;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            Load += ClientForm_Load;
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
        private TextBox txbClientMess;
        private Button btnClientSend;
        private TextBox txbClientChat;
    }
}