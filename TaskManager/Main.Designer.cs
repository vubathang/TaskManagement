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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chapter01ToolStripMenuItem, chapter02ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(945, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chapter01ToolStripMenuItem
            // 
            chapter01ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { taskManagerToolStripMenuItem });
            chapter01ToolStripMenuItem.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chapter01ToolStripMenuItem.Name = "chapter01ToolStripMenuItem";
            chapter01ToolStripMenuItem.Size = new Size(156, 31);
            chapter01ToolStripMenuItem.Text = "Chapter 01";
            // 
            // taskManagerToolStripMenuItem
            // 
            taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            taskManagerToolStripMenuItem.Size = new Size(254, 32);
            taskManagerToolStripMenuItem.Text = "Task Manager";
            taskManagerToolStripMenuItem.Click += OpenTaskManager;
            // 
            // chapter02ToolStripMenuItem
            // 
            chapter02ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { schedulingAlgorithmToolStripMenuItem, chatToolStripMenuItem });
            chapter02ToolStripMenuItem.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            chapter02ToolStripMenuItem.Name = "chapter02ToolStripMenuItem";
            chapter02ToolStripMenuItem.Size = new Size(156, 31);
            chapter02ToolStripMenuItem.Text = "Chapter 02";
            // 
            // schedulingAlgorithmToolStripMenuItem
            // 
            schedulingAlgorithmToolStripMenuItem.Name = "schedulingAlgorithmToolStripMenuItem";
            schedulingAlgorithmToolStripMenuItem.Size = new Size(371, 32);
            schedulingAlgorithmToolStripMenuItem.Text = "Scheduling Algorithms";
            schedulingAlgorithmToolStripMenuItem.Click += schedulingAlgorithmToolStripMenuItem_Click;
            // 
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(945, 122);
            label1.TabIndex = 1;
            label1.Text = "Operating System Project";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TLU_image;
            pictureBox1.Location = new Point(373, 170);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 33);
            label3.TabIndex = 4;
            label3.Text = "Vũ Bá Thắng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 99);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(285, 33);
            label4.TabIndex = 4;
            label4.Text = "Trịnh Phương Huyền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 149);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(255, 33);
            label5.TabIndex = 4;
            label5.Text = "Nguyễn Duy Hoàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(35, 200);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(225, 33);
            label6.TabIndex = 4;
            label6.Text = "Phạm Quốc Toản";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Consolas", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 157);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(366, 491);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Team 01 - 63TH3";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.CSE;
            pictureBox2.Location = new Point(25, 261);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(308, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 648);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Cursor = Cursors.Hand;
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 5, 5, 5);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operating System Project";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
    }
}