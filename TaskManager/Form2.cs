using System;
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

            public Process()
            {
                Random rand = new Random();
                this.color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
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
            int choose = cbAlgorithm.SelectedIndex;

            switch (choose)
            {
                //FCFS
                case 0:
                    FCFS();
                    break;
                //RR
                case 1:
                    // RR();
                    break;
                //SJF
                case 2:
                    // SJF();
                    break;
                //SRTN
                case 3:
                    // SRTN();
                    break;
            }
        }

        // FCFS Algorithm
        private void FCFS()
        {
            List<Process> processes = new List<Process>();
            int count = dataGridView1.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                Process process = new Process();
                process.id = i + 1;
                process.arrivalTime = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                process.burstTime = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                process.remainingTime = process.burstTime;
                processes.Add(process);
            }

            processes = processes.OrderBy(process => process.arrivalTime).ToList();

            int time = 0;
            int totalWaitingTime = 0;
            int averageWaitingTime = 0;
            int totalTurnAroundTime = 0;
            int averageTurnAroundTime = 0;

            foreach (Process process in processes)
            {
                process.waitingTime = time - process.arrivalTime;
                totalWaitingTime += process.waitingTime;
                time += process.burstTime;
                process.turnAroundTime = process.waitingTime + process.burstTime;
                totalTurnAroundTime += process.turnAroundTime;
            }

            averageWaitingTime = totalWaitingTime / count;
            averageTurnAroundTime = totalTurnAroundTime / count;

            txtAvgWaitingTime.Text = averageWaitingTime.ToString();
            txtAvgTurnAroundTime.Text = averageTurnAroundTime.ToString();

            DisplayProcesses(processes);
        }

        // Draw Gantt Chart
        private void DisplayProcesses(List<Process> processes)
        {
            pnlTurnAroundTime.Controls.Clear();

            int x = 0;
            int y = 0;
            int height = 60; 

            foreach (Process process in processes)
            {
                Panel processPanel = new Panel();
                processPanel.Location = new Point(x, y);
                processPanel.Size = new Size(process.burstTime * 40, height);
                processPanel.BackColor = process.color;

                Label processLabel = new Label();
                processLabel.Text = $"P{process.id}";
                processLabel.Font = new Font("Arial", 10);
                processLabel.ForeColor = Color.Black;
                processLabel.TextAlign = ContentAlignment.MiddleCenter;
                processLabel.Dock = DockStyle.Fill;

                processPanel.Controls.Add(processLabel);
                pnlTurnAroundTime.Controls.Add(processPanel);

                x += process.burstTime * 40; 
            }
        }
    }
}
