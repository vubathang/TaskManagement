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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chapter01ToolStripMenuItem, chapter02ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chapter01ToolStripMenuItem
            // 
            chapter01ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taskManagerToolStripMenuItem });
            chapter01ToolStripMenuItem.Name = "chapter01ToolStripMenuItem";
            chapter01ToolStripMenuItem.Size = new Size(95, 24);
            chapter01ToolStripMenuItem.Text = "Chapter 01";
            // 
            // taskManagerToolStripMenuItem
            // 
            taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            taskManagerToolStripMenuItem.Size = new Size(224, 26);
            taskManagerToolStripMenuItem.Text = "Task Manager";
            taskManagerToolStripMenuItem.Click += OpenTaskManager;
            // 
            // chapter02ToolStripMenuItem
            // 
            chapter02ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { schedulingAlgorithmToolStripMenuItem, chatToolStripMenuItem });
            chapter02ToolStripMenuItem.Name = "chapter02ToolStripMenuItem";
            chapter02ToolStripMenuItem.Size = new Size(95, 24);
            chapter02ToolStripMenuItem.Text = "Chapter 02";
            // 
            // schedulingAlgorithmToolStripMenuItem
            // 
            schedulingAlgorithmToolStripMenuItem.Name = "schedulingAlgorithmToolStripMenuItem";
            schedulingAlgorithmToolStripMenuItem.Size = new Size(242, 26);
            schedulingAlgorithmToolStripMenuItem.Text = "Scheduling Algorithms";
            schedulingAlgorithmToolStripMenuItem.Click += schedulingAlgorithmToolStripMenuItem_Click;
            // 
            // chatToolStripMenuItem
            // 
            chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            chatToolStripMenuItem.Size = new Size(242, 26);
            chatToolStripMenuItem.Text = "Chat";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}