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
        Random rand = new Random();
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
            int index = dataGridView1.Rows.Count + 1;
            int arrivalTime = rand.Next(0, 10);
            int burstTime = rand.Next(0, 10);
            dataGridView1.Rows.Add(index, arrivalTime, burstTime);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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

                //RR

                //SJF

                //SRTN
            }
        }
    }
}
