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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAvgWaitingTime = new TextBox();
            pnlTurnAroundTime = new Panel();
            nupQuantum = new NumericUpDown();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            rPID = new DataGridViewTextBoxColumn();
            rArrivalTime = new DataGridViewTextBoxColumn();
            rBurstTime = new DataGridViewTextBoxColumn();
            rCompleteTime = new DataGridViewTextBoxColumn();
            rTurnAroundTime = new DataGridViewTextBoxColumn();
            rWaitingTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Cascadia Mono SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1073, 65);
            label1.TabIndex = 0;
            label1.Text = "Scheduling Algorithm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbAlgorithm
            // 
            cbAlgorithm.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbAlgorithm.FormattingEnabled = true;
            cbAlgorithm.Location = new Point(67, 119);
            cbAlgorithm.Margin = new Padding(3, 2, 3, 2);
            cbAlgorithm.Name = "cbAlgorithm";
            cbAlgorithm.Size = new Size(165, 33);
            cbAlgorithm.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PID, ArrivalTime, BurstTime });
            dataGridView1.Location = new Point(308, 84);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(483, 198);
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
            btnAdd.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(880, 115);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 39);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Process";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(880, 179);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 39);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRun.Location = new Point(880, 243);
            btnRun.Margin = new Padding(3, 2, 3, 2);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(118, 39);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 323);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 4;
            label2.Text = "Gantt Chart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 424);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(599, 674);
            label4.Name = "label4";
            label4.Size = new Size(254, 25);
            label4.TabIndex = 4;
            label4.Text = "Average Waiting Time :";
            // 
            // txtAvgWaitingTime
            // 
            txtAvgWaitingTime.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAvgWaitingTime.Location = new Point(859, 671);
            txtAvgWaitingTime.Margin = new Padding(3, 2, 3, 2);
            txtAvgWaitingTime.Name = "txtAvgWaitingTime";
            txtAvgWaitingTime.ReadOnly = true;
            txtAvgWaitingTime.Size = new Size(139, 30);
            txtAvgWaitingTime.TabIndex = 6;
            // 
            // pnlTurnAroundTime
            // 
            pnlTurnAroundTime.AutoScroll = true;
            pnlTurnAroundTime.BorderStyle = BorderStyle.FixedSingle;
            pnlTurnAroundTime.Location = new Point(67, 350);
            pnlTurnAroundTime.Margin = new Padding(3, 2, 3, 2);
            pnlTurnAroundTime.Name = "pnlTurnAroundTime";
            pnlTurnAroundTime.Size = new Size(931, 56);
            pnlTurnAroundTime.TabIndex = 7;
            // 
            // nupQuantum
            // 
            nupQuantum.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nupQuantum.Location = new Point(175, 184);
            nupQuantum.Margin = new Padding(3, 2, 3, 2);
            nupQuantum.Name = "nupQuantum";
            nupQuantum.Size = new Size(57, 30);
            nupQuantum.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 186);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 9;
            label6.Text = "Quantum";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { rPID, rArrivalTime, rBurstTime, rCompleteTime, rTurnAroundTime, rWaitingTime });
            dataGridView2.Location = new Point(67, 462);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(931, 204);
            dataGridView2.TabIndex = 10;
            // 
            // rPID
            // 
            rPID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            rPID.HeaderText = "PID";
            rPID.Name = "rPID";
            rPID.Width = 62;
            // 
            // rArrivalTime
            // 
            rArrivalTime.HeaderText = "Arrival Time";
            rArrivalTime.Name = "rArrivalTime";
            // 
            // rBurstTime
            // 
            rBurstTime.HeaderText = "Burst Time";
            rBurstTime.Name = "rBurstTime";
            // 
            // rCompleteTime
            // 
            rCompleteTime.HeaderText = "Complete Time";
            rCompleteTime.Name = "rCompleteTime";
            // 
            // rTurnAroundTime
            // 
            rTurnAroundTime.HeaderText = "Turn Around Time";
            rTurnAroundTime.Name = "rTurnAroundTime";
            // 
            // rWaitingTime
            // 
            rWaitingTime.HeaderText = "Waiting Time";
            rWaitingTime.Name = "rWaitingTime";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 713);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(nupQuantum);
            Controls.Add(pnlTurnAroundTime);
            Controls.Add(txtAvgWaitingTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRun);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(cbAlgorithm);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scheduling Algorithm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupQuantum).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbAlgorithm;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnReset;
        private Button btnRun;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAvgWaitingTime;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn ArrivalTime;
        private DataGridViewTextBoxColumn BurstTime;
        private Panel pnlTurnAroundTime;
        private NumericUpDown nupQuantum;
        private Label label6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn rPID;
        private DataGridViewTextBoxColumn rArrivalTime;
        private DataGridViewTextBoxColumn rBurstTime;
        private DataGridViewTextBoxColumn rCompleteTime;
        private DataGridViewTextBoxColumn rTurnAroundTime;
        private DataGridViewTextBoxColumn rWaitingTime;
    }
}