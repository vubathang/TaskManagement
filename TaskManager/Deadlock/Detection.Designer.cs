namespace TaskManager.Deadlock
{
    partial class Detection
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
            dgvProcess = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            listBox1 = new ListBox();
            btnAdd = new Button();
            label1 = new Label();
            btnRun = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProcess).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProcess
            // 
            dgvProcess.AllowUserToAddRows = false;
            dgvProcess.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProcess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcess.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvProcess.Dock = DockStyle.Fill;
            dgvProcess.Location = new Point(3, 35);
            dgvProcess.Name = "dgvProcess";
            dgvProcess.RowHeadersWidth = 51;
            dgvProcess.RowTemplate.Height = 29;
            dgvProcess.Size = new Size(763, 335);
            dgvProcess.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Process";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Hold";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Wait";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(3, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(941, 165);
            listBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(815, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(998, 78);
            label1.TabIndex = 3;
            label1.Text = "Deadlock Detection Algorithm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(815, 313);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(144, 54);
            btnRun.TabIndex = 2;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(15, 462);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(947, 203);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Result";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvProcess);
            groupBox2.Location = new Point(18, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(769, 373);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Processes and Resources";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(815, 235);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(144, 54);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Detection
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 700);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnRun);
            Controls.Add(btnAdd);
            Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Detection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deadlock Detection Algorithm";
            ((System.ComponentModel.ISupportInitialize)dgvProcess).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProcess;
        private ListBox listBox1;
        private Button btnAdd;
        private Label label1;
        private Button btnRun;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnReset;
    }
}