namespace TaskManager.Chat
{
    partial class ChatForm
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
            btnServer = new Button();
            btnClient = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnServer
            // 
            btnServer.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnServer.Location = new Point(61, 137);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(161, 66);
            btnServer.TabIndex = 0;
            btnServer.Text = "Server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // btnClient
            // 
            btnClient.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClient.Location = new Point(261, 137);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(161, 66);
            btnClient.TabIndex = 0;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 53);
            label1.Name = "label1";
            label1.Size = new Size(339, 43);
            label1.TabIndex = 1;
            label1.Text = "Chat Application";
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(label1);
            Controls.Add(btnClient);
            Controls.Add(btnServer);
            Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "ChatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnServer;
        private Button btnClient;
        private Label label1;
    }
}