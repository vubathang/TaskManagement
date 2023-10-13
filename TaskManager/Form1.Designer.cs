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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnEnd = new Button();
            btnStart = new Button();
            txtName = new TextBox();
            btnPriority = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            btnCPU = new Button();
            btnRemory = new Button();
            btnDisk = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(24, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(491, 440);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnEnd
            // 
            btnEnd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnd.Location = new Point(541, 289);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(145, 51);
            btnEnd.TabIndex = 1;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(541, 220);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(145, 51);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(541, 168);
            txtName.Name = "txtName";
            txtName.Size = new Size(145, 34);
            txtName.TabIndex = 2;
            // 
            // btnPriority
            // 
            btnPriority.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPriority.Location = new Point(541, 358);
            btnPriority.Name = "btnPriority";
            btnPriority.Size = new Size(145, 51);
            btnPriority.TabIndex = 3;
            btnPriority.Text = "Set priority";
            btnPriority.UseVisualStyleBackColor = true;
            btnPriority.Click += btnPriority_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Realtime", "High", "AboveNormal", "Normal", "BelowNormal", "Low", "Idle" });
            comboBox1.Location = new Point(541, 427);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 36);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(541, 122);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 5;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(541, 24);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 5;
            label2.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(541, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(145, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnCPU
            // 
            btnCPU.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCPU.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCPU.Location = new Point(24, 482);
            btnCPU.Name = "btnCPU";
            btnCPU.Size = new Size(145, 51);
            btnCPU.TabIndex = 6;
            btnCPU.Text = "CPU";
            btnCPU.UseVisualStyleBackColor = true;
            btnCPU.Click += btnCPU_Click;
            // 
            // btnRemory
            // 
            btnRemory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemory.Location = new Point(197, 482);
            btnRemory.Name = "btnRemory";
            btnRemory.Size = new Size(145, 51);
            btnRemory.TabIndex = 6;
            btnRemory.Text = "Memory";
            btnRemory.UseVisualStyleBackColor = true;
            btnRemory.Click += btnMemory_Click;
            // 
            // btnDisk
            // 
            btnDisk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDisk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisk.Location = new Point(370, 482);
            btnDisk.Name = "btnDisk";
            btnDisk.Size = new Size(145, 51);
            btnDisk.TabIndex = 6;
            btnDisk.Text = "Disk";
            btnDisk.UseVisualStyleBackColor = true;
            btnDisk.Click += btnDisk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 558);
            Controls.Add(btnDisk);
            Controls.Add(btnRemory);
            Controls.Add(btnCPU);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnPriority);
            Controls.Add(txtSearch);
            Controls.Add(txtName);
            Controls.Add(btnStart);
            Controls.Add(btnEnd);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnEnd;
        private Button btnStart;
        private TextBox txtName;
        private Button btnPriority;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox txtSearch;
        private Button btnCPU;
        private Button btnRemory;
        private Button btnDisk;
    }
}