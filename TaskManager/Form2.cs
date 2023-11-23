using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            public int endTime { get; set; }
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
                this.burstTime--;
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
            int arrivalTime = rand.Next(0, 10);
            int burstTime = rand.Next(0, 10);
            dataGridView1.Rows.Add(index, arrivalTime, burstTime);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            pnlTurnAroundTime.Controls.Clear();
            txtAvgWaitingTime.Text = "";
            txtAvgTurnAroundTime.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);

            // Reset index in dtgv
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //init();
            int choose = cbAlgorithm.SelectedIndex;

            switch (choose)
            {
                //FCFS
                case 0:
                    FCFS();
                    break;
                //RR
                case 1:
                    RR();
                    break;
                //SJF
                case 2:
                    // SJF();
                    break;
                //SRTN
                case 3:
                    //SRTN();
                    break;
            }
            DisplayProcesses();
        }

        // FCFS Algorithm
        //private void FCFS()
        //{
        //    List<Process> processes = new List<Process>();
        //    int count = dataGridView1.Rows.Count;

        //    for (int i = 0; i < count; i++)
        //    {
        //        Process process = new Process();
        //        process.id = i + 1;
        //        process.arrivalTime = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
        //        process.burstTime = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
        //        process.remainingTime = process.burstTime;
        //        processes.Add(process);
        //    }

        //    processes = processes.OrderBy(process => process.arrivalTime).ToList();

        //    int time = 0;
        //    int totalWaitingTime = 0;
        //    int averageWaitingTime = 0;
        //    int totalTurnAroundTime = 0;
        //    int averageTurnAroundTime = 0;

        //    foreach (Process process in processes)
        //    {
        //        process.waitingTime = time - process.arrivalTime;
        //        totalWaitingTime += process.waitingTime;
        //        time += process.burstTime;
        //        process.turnAroundTime = process.waitingTime + process.burstTime;
        //        totalTurnAroundTime += process.turnAroundTime;
        //    }

        //    averageWaitingTime = totalWaitingTime / count;
        //    averageTurnAroundTime = totalTurnAroundTime / count;

        //    txtAvgWaitingTime.Text = averageWaitingTime.ToString();
        //    txtAvgTurnAroundTime.Text = averageTurnAroundTime.ToString();

        //    DisplayProcesses(processes);
        //}


        private void init()
        {
            for(int i = 0; i < dataGridView1.Rows.Count;i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                int id = Convert.ToInt32(row.Cells[0].Value);
                int arrivalTime = Convert.ToInt32(row.Cells[1].Value);
                int burstTime = Convert.ToInt32(row.Cells[2].Value);
                processes.Add(new Process(id, arrivalTime, burstTime));
            }
        }

        private void FCFS()
        {
            init();
            int timeCount = 0;
            int pr = 0;
            int quantity = processes.Count;
            while (true)
            {
                if (processes[pr].burstTime == 0) pr++;
                if (pr == quantity) break;
                processes[pr].useCpu();
                cpu.Add(pr);
                timeCount++;
            }
        }

        private void RR()
        {
            init();
            int timeCount = 0;
            int quantity = processes.Count;
            int pr = 0;
            while (timeCount < 20)
            {
                int i = 0;
                if (processes[pr].burstTime == 0)
                {
                    i = 0;
                    pr++;
                }
                else if (i == 2)
                {
                    i = 0;
                }
                else {
                    i++;
                } ;

                pr = pr % quantity;
                processes[pr].useCpu();
                
                cpu.Add(pr);
                timeCount++;
            }

        }

        // Draw Gantt Chart
        private void DisplayProcesses()
        {
            //pnlTurnAroundTime.Controls.Clear();

            //int panelWidth = 20;
            //int height = pnlTurnAroundTime.Height - 5;

            //for (int i = 0; i < cpu.Count; i++)
            //{
            //    int index = cpu[i];
            //    Label processLabel = new Label
            //    {
            //        Size = new Size(panelWidth, height),
            //        Text = $"{processes[index].id}",
            //        Font = new Font("Arial", 10),
            //        ForeColor = Color.Black,
            //        BackColor = processes[index].color,
            //        TextAlign = ContentAlignment.MiddleCenter,
            //        //Dock = DockStyle.Right
            //    };

            //    pnlTurnAroundTime.Controls.Add(processLabel);
            //}
            pnlTurnAroundTime.Controls.Clear();

            int x = 0;
            int y = 0;
            int height = 60;
            foreach (int i in cpu)
            {
                Panel processPanel = new Panel();
                processPanel.Location = new Point(x, y);
                processPanel.Size = new Size(40, height);
                processPanel.BackColor = processes[i].color;

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
    }
}
