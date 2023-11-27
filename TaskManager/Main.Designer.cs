namespace TaskManager
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            chapter01ToolStripMenuItem = new ToolStripMenuItem();
            taskManagerToolStripMenuItem = new ToolStripMenuItem();
            chapter02ToolStripMenuItem = new ToolStripMenuItem();
            schedulingAlgorithmToolStripMenuItem = new ToolStripMenuItem();
            chatToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Cascadia Mono SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chapter01ToolStripMenuItem, chapter02ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(738, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chapter01ToolStripMenuItem
            // 
            chapter01ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taskManagerToolStripMenuItem });
            chapter01ToolStripMenuItem.Name = "chapter01ToolStripMenuItem";
            chapter01ToolStripMenuItem.Size = new Size(134, 28);
            chapter01ToolStripMenuItem.Text = "Chapter 01";
            // 
            // taskManagerToolStripMenuItem
            // 
            taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            taskManagerToolStripMenuItem.Size = new Size(226, 28);
            taskManagerToolStripMenuItem.Text = "Task Manager";
            taskManagerToolStripMenuItem.Click += OpenTaskManager;
            // 
            // chapter02ToolStripMenuItem
            // 
            chapter02ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { schedulingAlgorithmToolStripMenuItem, chatToolStripMenuItem });
            chapter02ToolStripMenuItem.Name = "chapter02ToolStripMenuItem";
            chapter02ToolStripMenuItem.Size = new Size(134, 28);
            chapter02ToolStripMenuItem.Text = "Chapter 02";
            // 
            // schedulingAlgorithmToolStripMenuItem
            // 
            schedulingAlgorithmToolStripMenuItem.Name = "schedulingAlgorithmToolStripMenuItem";
            schedulingAlgorithmToolStripMenuItem.Size = new Size(325, 28);
            schedulingAlgorithmToolStripMenuItem.Text = "Scheduling Algorithms";
            schedulingAlgorithmToolStripMenuItem.Click += schedulingAlgorithmToolStripMenuItem_Click;
            // 
            // chatToolStripMenuItem
            // 
            chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            chatToolStripMenuItem.Size = new Size(325, 28);
            chatToolStripMenuItem.Text = "Chat";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Cascadia Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 32);
            label1.Name = "label1";
            label1.Size = new Size(738, 66);
            label1.TabIndex = 1;
            label1.Text = "NGUYÊN LÝ HỆ ĐIỀU HÀNH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 98);
            label2.Name = "label2";
            label2.Size = new Size(738, 33);
            label2.TabIndex = 2;
            label2.Text = "Nhóm 01 - 63TH3";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.TLU_image;
            pictureBox1.Location = new Point(0, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(738, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 400);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            Font = new Font("Cascadia Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NLHDH - Group 01 - 63Th3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chapter01ToolStripMenuItem;
        private ToolStripMenuItem taskManagerToolStripMenuItem;
        private ToolStripMenuItem chapter02ToolStripMenuItem;
        private ToolStripMenuItem schedulingAlgorithmToolStripMenuItem;
        private ToolStripMenuItem chatToolStripMenuItem;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}