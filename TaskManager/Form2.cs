using System.Data;

namespace TaskManager
{
    public partial class Form2 : Form
    {
        List<Process> processes = new();
        List<Process> queue = new();
        readonly List<int> cpu = new();
        int timeCount = 0;
        int processesLength = 0;
        int quantum = 0;
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
                Id = id - 1;
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
            Init();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Init();
            AddProcessToList();
            if (processesLength != 0)
            {
                int choose = cbAlgorithm.SelectedIndex;
                switch (choose)
                {
                    case 0:
                        FCFS();
                        break;
                    case 1:
                        quantum = Convert.ToInt32(nupQuantum.Value);
                        if (quantum == 0)
                        {
                            MessageBox.Show("Please input quantum", "Notification", MessageBoxButtons.OK);
                            return;
                        }
                        RR();
                        break;
                    case 2:
                        SJF();
                        break;
                    case 3:
                        SRTN();
                        break;
                }
                DisplayGanttChart();
                DisplayResult();
            }
            else
                MessageBox.Show("Please input data", "Notification", MessageBoxButtons.OK);
        }

        private void cbAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAlgorithm.SelectedIndex == 1) groupBox4.Show();
            else groupBox4.Hide();
        }

        private void Init()
        {
            processes.Clear();
            queue.Clear();
            cpu.Clear();
            timeCount = 0;
            pnlTurnAroundTime.Controls.Clear();
            dataGridView2.Rows.Clear();
            txtAvgWaitingTime.Clear();
        }
        
        private void AddProcessToList()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                int id = Convert.ToInt32(row.Cells[0].Value);
                int arrivalTime = Convert.ToInt32(row.Cells[1].Value);
                int burstTime = Convert.ToInt32(row.Cells[2].Value);
                processes.Add(new Process(id, arrivalTime, burstTime));
            }
            processesLength = processes.Count;
        }

        private void FCFS()
        {
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
                    queue[0].UseCpu();
                    cpu.Add(queue[0].Id);
                    if (queue[0].RemainingTime == 0)
                    {
                        queue[0].End(timeCount + 1);
                        queue.Remove(queue[0]);
                    }
                }
                timeCount++;
            }
        }

        private void RR()
        {
            int r = (int)nupQuantum.Value;
            while(true)
            {
                foreach (Process process in processes)
                {
                    if (process.ArrivalTime == timeCount)
                    {
                        queue.Add(process);
                        processesLength--;
                    }
                }
                if (queue.Count > 0)
                {
                    if (r == 0)
                    {
                        r = (int)nupQuantum.Value;
                        queue.Add(queue[0]);
                        queue.Remove(queue[0]);
                    }
                    queue[0].UseCpu();
                    cpu.Add(queue[0].Id);
                    if (queue[0].RemainingTime == 0)
                    {
                        queue[0].End(timeCount + 1);
                        queue.Remove(queue[0]);
                        r = (int)nupQuantum.Value;
                    }
                    else r--;
                }
                else if (processesLength == 0) break;
                timeCount++;
            }
        }

        private void SJF()
        {
            bool isFirstArrival = true;
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

                if (queue.Count > 0)
                {
                    if (isFirstArrival)
                    {
                        queue = queue.OrderBy(p => p.BurstTime).ToList();
                        isFirstArrival = false;
                    }
                    queue[0].UseCpu();
                    cpu.Add(queue[0].Id);
                    if (queue[0].RemainingTime == 0)
                    {
                        queue[0].End(timeCount + 1);
                        queue.Remove(queue[0]);
                        if (queue.Count > 0)
                            queue = queue.OrderBy(p => p.BurstTime).ToList();
                    }
                }
                else if (processesLength == 0)
                {
                    break;
                }

                timeCount++;
            }
        }

        private void SRTN()
        {
            while (true)
            {
                foreach (Process process in processes)
                {
                    if (process.ArrivalTime == timeCount)
                    {
                        queue.Add(process);
                        processesLength--;
                        queue = queue.OrderBy(p => p.RemainingTime).ToList();
                    }
                }

                if (queue.Count > 0)
                {
                    queue[0].UseCpu();
                    cpu.Add(queue[0].Id);
                    if (queue[0].RemainingTime == 0)
                    {
                        queue[0].End(timeCount + 1);
                        queue.Remove(queue[0]);

                    }
                }
                else if (processesLength == 0) break;

                timeCount++;
            }
        }

        private void DisplayGanttChart()
        {
            pnlTurnAroundTime.Controls.Clear();
            int x = 0;
            int y = 0;
            int height = 50;
            pnlTurnAroundTime.Padding = new Padding(0, height, 0, 0);
            int previousProcessId = -1;
            int currentTime = processes[cpu[0]].ArrivalTime;

            foreach (int i in cpu)
            {
              // Add panel for the process
              Panel processPanel = new()
              {
                  Location = new Point(x, y),
                  Size = new Size(60, height),
                  BackColor = processes[i].Color,
                  BorderStyle = BorderStyle.None
              };

              // Check if the current process is different from the previous one
              if (previousProcessId != processes[i].Id)
              {
                  // Add label with process name to the process panel
                  Label processLabel = new()
                  {
                      Text = $"P{processes[i].Id + 1}",
                       Font = new Font("Consolas", 15),
                      ForeColor = Color.Black,
                      TextAlign = ContentAlignment.MiddleCenter,
                      Dock = DockStyle.Fill
                  };

                  processPanel.Controls.Add(processLabel);
                  pnlTurnAroundTime.Controls.Add(processPanel);
              }
              else
              {
                  pnlTurnAroundTime.Controls.Add(processPanel);
              }

              // Check if the current process is different from the previous one
              if (previousProcessId != processes[i].Id)
              {
                  // Add a time panel below the process panel
                  Panel timePanel = new()
                  {
                      Location = new Point(x, y + height),
                      Size = new Size(60, height),
                      BackColor = Color.White,
                      BorderStyle = BorderStyle.None
                  };

                  // Add label with execution time to the time panel
                  Label timeLabel = new()
                  {
                      Text = $"{currentTime}",
                      Font = new Font("Consolas", 15),
                      ForeColor = Color.Black,
                      TextAlign = ContentAlignment.TopLeft,
                      Dock = DockStyle.Fill
                  };

                  timePanel.Controls.Add(timeLabel);
                  pnlTurnAroundTime.Controls.Add(timePanel);
              } 

              x += 60;

              // Update the previous process id
              previousProcessId = processes[i].Id;
              currentTime++;                                              
            }

            // Add the final time panel
            Panel finalTimePanel = new()
            {
                Location = new Point(x, y + height),
                Size = new Size(60, height),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Add label with execution time to the final time panel
            Label finalTimeLabel = new()
            {
                Text = $"{timeCount}",
                Font = new Font("Consolas", 15),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Fill
            };

            finalTimePanel.Controls.Add(finalTimeLabel);
            pnlTurnAroundTime.Controls.Add(finalTimePanel);
        }

        private void DisplayResult()
        {
            processes = processes.OrderBy(process => process.ArrivalTime).ToList();
            int totalWaitingTime = 0;
            foreach (Process p in processes)
            {
                int index = p.Id + 1;
                int arrivalTime = p.ArrivalTime;
                int burstTime = p.BurstTime;
                int completedTime = p.CompletedTime;
                int turnAroundTime = p.TurnAroundTime;
                int waitingTime = p.WaitingTime;
                totalWaitingTime += waitingTime;
                dataGridView2.Rows.Add(index, arrivalTime, burstTime, completedTime, $"{completedTime} - {arrivalTime} = {turnAroundTime}", $"{turnAroundTime} - {burstTime} = {waitingTime}");
            }
            txtAvgWaitingTime.Text = Math.Round(totalWaitingTime * 1.0 / processes.Count, 3).ToString();
        }
    }
}