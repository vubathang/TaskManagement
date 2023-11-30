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
            lbPort = new Label();
            lbName = new Label();
            richTextBox1 = new RichTextBox();
            txbMessage = new TextBox();
            btnSent = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbPort);
            panel1.Controls.Add(lbName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 74);
            panel1.TabIndex = 0;
            // 
            // lbPort
            // 
            lbPort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbPort.AutoSize = true;
            lbPort.Location = new Point(392, 18);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(70, 32);
            lbPort.TabIndex = 1;
            lbPort.Text = "Port";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(15, 18);
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
            richTextBox1.Size = new Size(447, 386);
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
            // btnSent
            // 
            btnSent.Location = new Point(350, 518);
            btnSent.Name = "btnSent";
            btnSent.Size = new Size(112, 40);
            btnSent.TabIndex = 3;
            btnSent.Text = "Sent";
            btnSent.UseVisualStyleBackColor = true;
            btnSent.Click += btnSent_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 573);
            Controls.Add(btnSent);
            Controls.Add(txbMessage);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Client";
            Text = "Client";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbPort;
        private Label lbName;
        private RichTextBox richTextBox1;
        private TextBox txbMessage;
        private Button btnSent;
    }
}