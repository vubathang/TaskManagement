using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TaskManager
{
    public partial class Form2 : Form
    {
        List<Process> processes = new List<Process>();
        List<int> cpu = new List<int>();
        public class Process
        {
            public int id { get; set; }
            public int arrivalTime { get; set; }
            public int burstTime { get; set; }
            public int remainingTime { get; set; }
            public int waitingTime { get; set; }
            public int turnAroundTime { get; set; }
            public int completedTime { get; set; }
            public Color color { get; set; }

            public Process(int id, int arrivalTime, int burstTime)
            {
                this.id = id;
                this.arrivalTime = arrivalTime;
                this.burstTime = burstTime;
                this.remainingTime = burstTime;
                Random rand = new Random();
                this.color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }
            public void useCpu()
            {
                this.remainingTime--;
            }
            public void end(int timeCount)
            {
                this.completedTime = timeCount;
                calTurnAroundTime();
                calWaitingTime();
            }
            public void calTurnAroundTime()
            {
                this.turnAroundTime = this.completedTime - this.arrivalTime;
            }
            public void calWaitingTime()
            {
                this.waitingTime = this.turnAroundTime - this.burstTime;
            }
        }

        public Form2()
        {
            InitializeComponent();
            renderCb();
        }

        private void renderCb()
        {
            cbAlgorithm.Items.Add("FCFS");
            cbAlgorithm.Items.Add("RR");
            cbAlgorithm.Items.Add("SJF");
            cbAlgorithm.Items.Add("SRTN");

            cbAlgorithm.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int index = dataGridView1.Rows.Count + 1;
            int arrivalTime = rand.Next(1, 10);
            int burstTime = rand.Next(1, 10);
            dataGridView1.Rows.Add(index, arrivalTime, burstTime);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            pnlTurnAroundTime.Controls.Clear();
            txtAvgWaitingTime.Text = "";
            //txtAvgTurnAroundTime.Text = "";
            processes.Clear();
            cpu.Clear();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            init();
            int choose = cbAlgorithm.SelectedIndex;
            switch (choose)
            {
                //FCFS
                case 0:
                    FCFS();
                    break;
                //RR
                case 1:
                    if (Convert.ToInt32(nupQuantum.Value) > 0)
                    {
                        RR();
                    }
                    else
                    {
                        MessageBox.Show("Please input quantum", "Notification", MessageBoxButtons.OK);
                    }
                    break;
                //SJF
                case 2:
                    SJF();
                    break;
                //SRTN
                case 3:
                    SRTN();
                    break;
            }
            DisplayProcesses();
            DisplayResult();
        }
        private void init()
        {
            processes.Clear();
            cpu.Clear();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                int id = Convert.ToInt32(row.Cells[0].Value);
                int arrivalTime = Convert.ToInt32(row.Cells[1].Value);
                int burstTime = Convert.ToInt32(row.Cells[2].Value);
                processes.Add(new Process(id, arrivalTime, burstTime));
            }
            txtAvgWaitingTime.Text = "";
        }

        private void FCFS()
        {
            int timeCount = 0;
            int pr = 0;
            int quantity = processes.Count;
            while (true)
            {
                if (processes[pr].remainingTime == 0)
                {
                    processes[pr].end(timeCount);
                    pr++;
                    // Nếu sai thì sửa ở đây
                };
                if (pr == quantity) break;
                processes[pr].useCpu();
                cpu.Add(pr);
                timeCount++;
            }
        }

        private void RR()
        {
            List<Process> queue = new List<Process>();
            int quantum = Convert.ToInt32(nupQuantum.Value);
            int r = quantum;
            int index = 0;
            int timeCount = 0;
            int processesLength = processes.Count;
            while (true)
            {
                // Add process to queue
                foreach (Process process in processes)
                {
                    if (process.arrivalTime == timeCount)
                    {
                        queue.Add(process);
                        processesLength--;
                    }
                }

                int queueLength = queue.Count;

                if (queueLength == 0 && processesLength == 0)
                {
                    break;
                }
                if (queueLength > 0)
                {
                    if (queue[index].remainingTime <= 0)
                    {
                        // Nếu sai thì sửa ở đây
                        queue[index].end(timeCount);
                        r = quantum;
                        queue.Remove(queue[index]);
                        queueLength = queue.Count;
                        if (queueLength == 0)
                        {
                            index = 0;
                            continue;
                        }
                        if (index >= queueLength)
                        {
                            index = queueLength - 1;
                        }
                    }

                    if (r == 0)
                    {
                        r = quantum;
                        index = (index + 1) % queueLength;
                        Console.WriteLine($"=> Round");
                    }

                    queue[index].useCpu();
                    cpu.Add(queue[index].id - 1);
                    r--;
                }
                timeCount++;
            }
        }
        private void SJF()
        {
            int timeCount = 0;
            List<Process> queue = new List<Process>();
            int lengthProcesses = processes.Count;
            int index = -1;
            while (true)
            {
                // Add process to queue
                foreach (Process process in processes)
                {
                    if (process.arrivalTime == timeCount)
                    {
                        queue.Add(process);
                        lengthProcesses--;
                    }
                }
                if (queue.Count != 0 && index == -1)
                {
                    double min = Double.PositiveInfinity;
                    foreach (Process process in queue)
                    {
                        if (process.remainingTime < min && process.remainingTime > 0)
                        {
                            index = process.id - 1;
                            min = process.remainingTime;
                        }
                    }
                }
                if (index == -1 && lengthProcesses == 0) break;

                if (index != -1)
                {
                    cpu.Add(index);
                    processes[index].useCpu();
                    if (processes[index].remainingTime == 0)
                    {
                        // Nếu sai thì sửa ở đây
                        processes[index].end(timeCount + 1);
                        index = -1;
                    }
                }
                timeCount++;
            }
        }
        private void SRTN()
        {
            int timeCount = 0;
            List<Process> queue = new List<Process>();
            int lengthProcesses = processes.Count;
            while (true)
            {
                // Add process to queue
                foreach (Process process in processes)
                {
                    if (process.arrivalTime == timeCount)
                    {
                        queue.Add(process);
                        lengthProcesses--;
                    }
                }
                double min = Double.PositiveInfinity;
                int index = -1;
                foreach (Process p in queue)
                {
                    if (p.remainingTime > 0 && p.remainingTime < min)
                    {
                        index = p.id;
                        min = p.remainingTime;
                    }
                }

                if (index == -1 && lengthProcesses == 0) break;
                if (index != -1)
                {
                    processes[index - 1].useCpu();
                    cpu.Add(index - 1);
                    if (processes[index - 1].remainingTime == 0)
                    {
                        processes[index - 1].end(timeCount + 1);
                    }
                }

                timeCount++;
            }
        }
        // Draw Gantt Chart
        private void DisplayProcesses()
        {
            pnlTurnAroundTime.Controls.Clear();

            int x = 0;
            int y = 0;
            int height = 50;
            foreach (int i in cpu)
            {
                Panel processPanel = new Panel();
                processPanel.Location = new Point(x, y);
                processPanel.Size = new Size(40, height);
                processPanel.BackColor = processes[i].color;
                processPanel.BorderStyle = BorderStyle.FixedSingle;

                Label processLabel = new Label();
                processLabel.Text = $"P{processes[i].id}";
                processLabel.Font = new Font("Arial", 10);
                processLabel.ForeColor = Color.Black;
                processLabel.TextAlign = ContentAlignment.MiddleCenter;
                processLabel.Dock = DockStyle.Fill;

                processPanel.Controls.Add(processLabel);
                pnlTurnAroundTime.Controls.Add(processPanel);

                x += 40;
            }
        }

        private void DisplayResult()
        {
            processes = processes.OrderBy(process => process.arrivalTime).ToList();
            int totalWaitingTime = 0;
            foreach (Process p in processes)
            {
                int index = p.id;
                int arrivalTime = p.arrivalTime;
                int burstTime = p.burstTime;
                int completedTime = p.completedTime;
                int turnAroundTime = p.turnAroundTime;
                int waitingTime = p.waitingTime;
                totalWaitingTime += waitingTime;
                dataGridView2.Rows.Add(index, arrivalTime, burstTime, completedTime, turnAroundTime, waitingTime);
            }
            txtAvgWaitingTime.Text = Math.Round(totalWaitingTime * 1.0 / processes.Count, 4).ToString();
        }
    }
}
