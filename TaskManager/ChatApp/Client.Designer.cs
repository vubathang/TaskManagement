namespace TaskManager.ChatApp
{
    partial class Client
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
            lbPort = new Label();
            lbName = new Label();
            richTextBox1 = new RichTextBox();
            txbMessage = new TextBox();
            btnSend = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbPort);
            panel1.Controls.Add(lbName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 74);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user1;
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbPort
            // 
            lbPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbPort.AutoSize = true;
            lbPort.Location = new Point(395, 18);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(70, 32);
            lbPort.TabIndex = 1;
            lbPort.Text = "Port";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(73, 18);
            lbName.Name = "lbName";
            lbName.Size = new Size(70, 32);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(15, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(450, 386);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // txbMessage
            // 
            txbMessage.Location = new Point(12, 519);
            txbMessage.Name = "txbMessage";
            txbMessage.Size = new Size(327, 35);
            txbMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(350, 518);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 40);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Client
            // 
            AcceptButton = btnSend;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 573);
            Controls.Add(btnSend);
            Controls.Add(txbMessage);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Client";
            Text = "Client";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbPort;
        private Label lbName;
        private RichTextBox richTextBox1;
        private TextBox txbMessage;
        private Button btnSend;
        private PictureBox pictureBox1;
    }
}