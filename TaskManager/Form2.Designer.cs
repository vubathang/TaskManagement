namespace TaskManager
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            cbAlgorithm = new ComboBox();
            dataGridView1 = new DataGridView();
            PID = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            BurstTime = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnReset = new Button();
            btnRun = new Button();
            label4 = new Label();
            txtAvgWaitingTime = new TextBox();
            pnlTurnAroundTime = new Panel();
            nupQuantum = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantum).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1129, 78);
            label1.TabIndex = 0;
            label1.Text = "Scheduling Algorithms";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbAlgorithm
            // 
            cbAlgorithm.Dock = DockStyle.Fill;
            cbAlgorithm.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbAlgorithm.FormattingEnabled = true;
            cbAlgorithm.Location = new Point(3, 30);
            cbAlgorithm.Name = "cbAlgorithm";
            cbAlgorithm.Size = new Size(237, 40);
            cbAlgorithm.TabIndex = 0;
            cbAlgorithm.SelectedIndexChanged += cbAlgorithm_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PID, ArrivalTime, BurstTime });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(649, 244);
            dataGridView1.TabIndex = 2;
            // 
            // PID
            // 
            PID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PID.FillWeight = 48.12834F;
            PID.HeaderText = "PID";
            PID.MinimumWidth = 6;
            PID.Name = "PID";
            PID.Width = 65;
            // 
            // ArrivalTime
            // 
            ArrivalTime.FillWeight = 125.935829F;
            ArrivalTime.HeaderText = "Arrival Time";
            ArrivalTime.MinimumWidth = 6;
            ArrivalTime.Name = "ArrivalTime";
            // 
            // BurstTime
            // 
            BurstTime.FillWeight = 125.935829F;
            BurstTime.HeaderText = "Burst Time";
            BurstTime.MinimumWidth = 6;
            BurstTime.Name = "BurstTime";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(750, 170);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(750, 236);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(136, 52);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRun.Location = new Point(750, 302);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(136, 52);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(308, 305);
            label4.Name = "label4";
            label4.Size = new Size(272, 27);
            label4.TabIndex = 4;
            label4.Text = "Average Waiting Time";
            // 
            // txtAvgWaitingTime
            // 
            txtAvgWaitingTime.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAvgWaitingTime.Location = new Point(586, 301);
            txtAvgWaitingTime.Name = "txtAvgWaitingTime";
            txtAvgWaitingTime.ReadOnly = true;
            txtAvgWaitingTime.Size = new Size(158, 34);
            txtAvgWaitingTime.TabIndex = 6;
            // 
            // pnlTurnAroundTime
            // 
            pnlTurnAroundTime.AutoScroll = true;
            pnlTurnAroundTime.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnAroundTime.Dock = DockStyle.Fill;
            pnlTurnAroundTime.Location = new Point(3, 30);
            pnlTurnAroundTime.Name = "pnlTurnAroundTime";
            pnlTurnAroundTime.Size = new Size(1070, 113);
            pnlTurnAroundTime.TabIndex = 7;
            // 
            // nupQuantum
            // 
            nupQuantum.Dock = DockStyle.Fill;
            nupQuantum.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nupQuantum.Location = new Point(3, 30);
            nupQuantum.Margin = new Padding(3, 5, 3, 5);
            nupQuantum.Name = "nupQuantum";
            nupQuantum.Size = new Size(122, 34);
            nupQuantum.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pnlTurnAroundTime);
            groupBox1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(25, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1076, 146);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gantt Chart";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAvgWaitingTime);
            groupBox2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(25, 537);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1079, 350);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView2.Dock = DockStyle.Top;
            dataGridView2.Location = new Point(3, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1073, 251);
            dataGridView2.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column1.FillWeight = 85.6272659F;
            Column1.HeaderText = "PID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 65;
            // 
            // Column2
            // 
            Column2.FillWeight = 89.6232F;
            Column2.HeaderText = "Arrival Time";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 89.6232F;
            Column3.HeaderText = "Burst Time";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 89.6232F;
            Column4.HeaderText = "Completed Time";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 89.6232F;
            Column5.HeaderText = "Turn Around Time";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 89.6232F;
            Column6.HeaderText = "Waiting Time";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbAlgorithm);
            groupBox3.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(750, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(243, 75);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Choose algorithm";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(nupQuantum);
            groupBox4.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(937, 283);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(128, 75);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Quantum";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(25, 81);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(655, 277);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Processes";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1129, 899);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnRun);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scheduling Algorithms";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantum).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cbAlgorithm;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnReset;
        private Button btnRun;
        private Label label4;
        private TextBox txtAvgWaitingTime;
        private Panel pnlTurnAroundTime;
        private NumericUpDown nupQuantum;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn BurstTime;
    }
}