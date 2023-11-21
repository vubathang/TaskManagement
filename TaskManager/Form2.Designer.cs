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
            label1 = new Label();
            cbAlgorithm = new ComboBox();
            dataGridView1 = new DataGridView();
            PID = new DataGridViewTextBoxColumn();
            ArrivalTime = new DataGridViewTextBoxColumn();
            BurstTime = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnRun = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAvgWaitingTime = new TextBox();
            txtAvgTurnAroundTime = new TextBox();
            pnlTurnAroundTime = new Panel();
            nupQuantum = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(947, 67);
            label1.TabIndex = 0;
            label1.Text = "Scheduling Algorithm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbAlgorithm
            // 
            cbAlgorithm.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbAlgorithm.FormattingEnabled = true;
            cbAlgorithm.Location = new Point(126, 70);
            cbAlgorithm.Name = "cbAlgorithm";
            cbAlgorithm.Size = new Size(111, 31);
            cbAlgorithm.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PID, ArrivalTime, BurstTime });
            dataGridView1.Location = new Point(257, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(419, 242);
            dataGridView1.TabIndex = 2;
            // 
            // PID
            // 
            PID.HeaderText = "PID";
            PID.MinimumWidth = 6;
            PID.Name = "PID";
            // 
            // ArrivalTime
            // 
            ArrivalTime.HeaderText = "Arrival Time";
            ArrivalTime.MinimumWidth = 6;
            ArrivalTime.Name = "ArrivalTime";
            // 
            // BurstTime
            // 
            BurstTime.HeaderText = "Burst Time";
            BurstTime.MinimumWidth = 6;
            BurstTime.Name = "BurstTime";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(705, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 52);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Process";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(705, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 52);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Process";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(705, 260);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(135, 52);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRun.Location = new Point(126, 122);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(111, 52);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(55, 341);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 4;
            label2.Text = "Gantt Chart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(55, 465);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(86, 502);
            label4.Name = "label4";
            label4.Size = new Size(193, 23);
            label4.TabIndex = 4;
            label4.Text = "Average Waiting Time :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(86, 543);
            label5.Name = "label5";
            label5.Size = new Size(228, 23);
            label5.TabIndex = 4;
            label5.Text = "Average Stay in CPU Time : ";
            // 
            // txtAvgWaitingTime
            // 
            txtAvgWaitingTime.Location = new Point(331, 501);
            txtAvgWaitingTime.Name = "txtAvgWaitingTime";
            txtAvgWaitingTime.ReadOnly = true;
            txtAvgWaitingTime.Size = new Size(158, 27);
            txtAvgWaitingTime.TabIndex = 6;
            // 
            // txtAvgTurnAroundTime
            // 
            txtAvgTurnAroundTime.Location = new Point(331, 542);
            txtAvgTurnAroundTime.Name = "txtAvgTurnAroundTime";
            txtAvgTurnAroundTime.ReadOnly = true;
            txtAvgTurnAroundTime.Size = new Size(158, 27);
            txtAvgTurnAroundTime.TabIndex = 6;
            // 
            // pnlTurnAroundTime
            // 
            pnlTurnAroundTime.AutoScroll = true;
            pnlTurnAroundTime.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnAroundTime.Location = new Point(55, 367);
            pnlTurnAroundTime.Name = "pnlTurnAroundTime";
            pnlTurnAroundTime.Size = new Size(840, 95);
            pnlTurnAroundTime.TabIndex = 7;
            // 
            // nupQuantum
            // 
            nupQuantum.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nupQuantum.Location = new Point(180, 190);
            nupQuantum.Name = "nupQuantum";
            nupQuantum.Size = new Size(57, 30);
            nupQuantum.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(87, 197);
            label6.Name = "label6";
            label6.Size = new Size(83, 23);
            label6.TabIndex = 9;
            label6.Text = "Quantum";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 594);
            Controls.Add(label6);
            Controls.Add(nupQuantum);
            Controls.Add(pnlTurnAroundTime);
            Controls.Add(txtAvgTurnAroundTime);
            Controls.Add(txtAvgWaitingTime);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRun);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(cbAlgorithm);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scheduling Algorithm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbAlgorithm;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnReset;
        private Button btnRun;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAvgWaitingTime;
        private TextBox txtAvgTurnAroundTime;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn BurstTime;
        private Panel pnlTurnAroundTime;
        private NumericUpDown nupQuantum;
        private Label label6;
    }
}