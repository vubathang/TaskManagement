namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnEnd = new Button();
            btnStart = new Button();
            txtName = new TextBox();
            btnPriority = new Button();
            comboBox1 = new ComboBox();
            txtSearch = new TextBox();
            btnCPU = new Button();
            btnRemory = new Button();
            btnDisk = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(477, 513);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 53.4759369F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 146.524063F;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnEnd
            // 
            btnEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEnd.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnd.Location = new Point(642, 268);
            btnEnd.Margin = new Padding(4, 3, 4, 3);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(109, 50);
            btnEnd.TabIndex = 3;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStart.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(517, 268);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(109, 48);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(3, 35);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 39);
            txtName.TabIndex = 1;
            // 
            // btnPriority
            // 
            btnPriority.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPriority.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnPriority.Location = new Point(517, 332);
            btnPriority.Margin = new Padding(4, 3, 4, 3);
            btnPriority.Name = "btnPriority";
            btnPriority.Size = new Size(237, 48);
            btnPriority.TabIndex = 4;
            btnPriority.Text = "Set priority";
            btnPriority.UseVisualStyleBackColor = true;
            btnPriority.Click += btnPriority_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Realtime", "High", "AboveNormal", "Normal", "BelowNormal", "Low", "Idle" });
            comboBox1.Location = new Point(517, 396);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 35);
            comboBox1.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(3, 35);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(231, 39);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnCPU
            // 
            btnCPU.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCPU.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCPU.Location = new Point(569, 447);
            btnCPU.Margin = new Padding(4, 3, 4, 3);
            btnCPU.Name = "btnCPU";
            btnCPU.Size = new Size(137, 48);
            btnCPU.TabIndex = 6;
            btnCPU.Text = "CPU";
            btnCPU.UseVisualStyleBackColor = true;
            btnCPU.Click += btnCPU_Click;
            // 
            // btnRemory
            // 
            btnRemory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemory.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemory.Location = new Point(566, 575);
            btnRemory.Margin = new Padding(4, 3, 4, 3);
            btnRemory.Name = "btnRemory";
            btnRemory.Size = new Size(140, 48);
            btnRemory.TabIndex = 8;
            btnRemory.Text = "Memory";
            btnRemory.UseVisualStyleBackColor = true;
            btnRemory.Click += btnMemory_Click;
            // 
            // btnDisk
            // 
            btnDisk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDisk.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisk.Location = new Point(569, 511);
            btnDisk.Margin = new Padding(4, 3, 4, 3);
            btnDisk.Name = "btnDisk";
            btnDisk.Size = new Size(136, 48);
            btnDisk.TabIndex = 7;
            btnDisk.Text = "Disk";
            btnDisk.UseVisualStyleBackColor = true;
            btnDisk.Click += btnDisk_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(517, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 79);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(txtName);
            groupBox2.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(517, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(237, 79);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "File name";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(777, 78);
            label1.TabIndex = 9;
            label1.Text = "Task Management";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(483, 551);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Processes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 644);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnDisk);
            Controls.Add(btnRemory);
            Controls.Add(btnCPU);
            Controls.Add(comboBox1);
            Controls.Add(btnPriority);
            Controls.Add(btnStart);
            Controls.Add(btnEnd);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEnd;
        private Button btnStart;
        private TextBox txtName;
        private Button btnPriority;
        private ComboBox comboBox1;
        private TextBox txtSearch;
        private Button btnCPU;
        private Button btnRemory;
        private Button btnDisk;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox3;
    }
}