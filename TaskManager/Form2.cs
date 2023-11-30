using System.Data;

namespace TaskManager
{
    public partial class Form2 : Form
    {
        List<Process> processes = new();
        readonly List<int> cpu = new();
        public class Process
        {
            public int Id { get; set; }
            public int ArrivalTime { get; set; }
            public int BurstTime { get; set; }
            public int RemainingTime { get; set; }
            public int WaitingTime { get; set; }
            public int TurnAroundTime { get; set; }
            public int CompletedTime { get; set; }
            public Color Color { get; set; }

            public Process(int id, int arrivalTime, int burstTime)
            {
                Id = id;
                ArrivalTime = arrivalTime;
                BurstTime = burstTime;
                RemainingTime = burstTime;
                Random rand = new();
                Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }
            public void UseCpu()
            {
                RemainingTime--;
            }
            public void End(int timeCount)
            {
                CompletedTime = timeCount;
                CalTurnAroundTime();
                CalWaitingTime();
            }
            public void CalTurnAroundTime()
            {
                TurnAroundTime = CompletedTime - ArrivalTime;
            }
            public void CalWaitingTime()
            {
                WaitingTime = TurnAroundTime - BurstTime;
            }
        }

        public Form2()
        {
            InitializeComponent();
            RenderCb();
        }

        private void RenderCb()
        {
            cbAlgorithm.Items.Add("FCFS");
            cbAlgorithm.Items.Add("RR");
            cbAlgorithm.Items.Add("SJF");
            cbAlgorithm.Items.Add("SRTN");

            cbAlgorithm.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rand = new();
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
            txtAvgWaitingTime.Clear();
            processes.Clear();
            cpu.Clear();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Init();
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
                        RR();
                    else
                        MessageBox.Show("Please input quantum", "Notification", MessageBoxButtons.OK);
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
            DisplayGanttChart();
            DisplayResult();
        }

        private void cbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlgorithm.SelectedIndex == 1)
                groupBox4.Show();
            else
                groupBox4.Hide();
        }

        private void Init()
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
            txtAvgWaitingTime.Clear();
        }

        private void FCFS()
        {
            int timeCount = 0;
            int pr = 0;
            int quantity = processes.Count;
            while (true)
            {
                if (processes[pr].RemainingTime == 0)
                {
                    processes[pr].End(timeCount);
                    pr++;
                }
                if (pr == quantity) break;
                processes[pr].UseCpu();
                cpu.Add(pr);
                timeCount++;
            }
        }

        private void RR()
        {
            List<Process> queue = new();
            int quantum = Convert.ToInt32(nupQuantum.Value);
            int r = quantum;
            int index = 0;
            int timeCount = 0;
            int processesLength = processes.Count;
            while (true)
            {
                foreach (Process process in processes)
                {
                    if (process.ArrivalTime == timeCount)
                    {
                        queue.Add(process);
                        processesLength--;
                    }
                }

                int queueLength = queue.Count;

                if (queueLength == 0 && processesLength == 0) break;
                if (queueLength > 0)
                {
                    if (queue[index].RemainingTime <= 0)
                    {
                        queue[index].End(timeCount);
                        r = quantum;
                        queue.Remove(queue[index]);
                        queueLength = queue.Count;
                        if (queueLength == 0)
                        {
                            index = 0;
                            continue;
                        }
                        if (index >= queueLength)
                            index = queueLength - 1;
                    }

                    if (r == 0)
                    {
                        r = quantum;
                        index = (index + 1) % queueLength;
                        Console.WriteLine($"=> Round");
                    }

                    queue[index].UseCpu();
                    cpu.Add(queue[index].Id - 1);
                    r--;
                }
                timeCount++;
            }
        }

        private void SJF()
        {
            int timeCount = 0;
            List<Process> queue = new();
            int lengthProcesses = processes.Count;
            int index = -1;
            while (true)
            {
                foreach (Process process in processes)
                {
                    if (process.ArrivalTime == timeCount)
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
                        if (process.RemainingTime < min && process.RemainingTime > 0)
                        {
                            index = process.Id - 1;
                            min = process.RemainingTime;
                        }
                    }
                }
                if (index == -1 && lengthProcesses == 0) break;

                if (index != -1)
                {
                    cpu.Add(index);
                    processes[index].UseCpu();
                    if (processes[index].RemainingTime == 0)
                    {
                        processes[index].End(timeCount + 1);
                        index = -1;
                    }
                }
                timeCount++;
            }
        }

        private void SRTN()
        {
            int timeCount = 0;
            List<Process> queue = new();
            int lengthProcesses = processes.Count;
            while (true)
            {
                foreach (Process process in processes)
                {
                    if (process.ArrivalTime == timeCount)
                    {
                        queue.Add(process);
                        lengthProcesses--;
                    }
                }
                double min = Double.PositiveInfinity;
                int index = -1;
                foreach (Process p in queue)
                {
                    if (p.RemainingTime > 0 && p.RemainingTime < min)
                    {
                        index = p.Id;
                        min = p.RemainingTime;
                    }
                }

                if (index == -1 && lengthProcesses == 0) break;
                if (index != -1)
                {
                    processes[index - 1].UseCpu();
                    cpu.Add(index - 1);
                    if (processes[index - 1].RemainingTime == 0)
                        processes[index - 1].End(timeCount + 1);
                }
                timeCount++;
            }
        }

        private void DisplayGanttChart()
        {
            pnlTurnAroundTime.Controls.Clear();
            int x = 0;
            int y = 0;
            int height = 50;
            foreach (int i in cpu)
            {
                Panel processPanel = new()
                {
                    Location = new Point(x, y),
                    Size = new Size(50, height),
                    BackColor = processes[i].Color,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label processLabel = new()
                {
                    Text = $"P{processes[i].Id}",
                    Font = new Font("Consolas", 13),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };

                processPanel.Controls.Add(processLabel);
                pnlTurnAroundTime.Controls.Add(processPanel);

                x += 50;
            }
        }

        private void DisplayResult()
        {
            processes = processes.OrderBy(process => process.ArrivalTime).ToList();
            int totalWaitingTime = 0;
            foreach (Process p in processes)
            {
                int index = p.Id;
                int arrivalTime = p.ArrivalTime;
                int burstTime = p.BurstTime;
                int completedTime = p.CompletedTime;
                int turnAroundTime = p.TurnAroundTime;
                int waitingTime = p.WaitingTime;
                totalWaitingTime += waitingTime;
                dataGridView2.Rows.Add(index, arrivalTime, burstTime, completedTime, turnAroundTime, waitingTime);
            }
            txtAvgWaitingTime.Text = Math.Round(totalWaitingTime * 1.0 / processes.Count, 4).ToString();
        }
    }
}
