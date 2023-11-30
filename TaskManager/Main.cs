using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.ChatApp;

namespace TaskManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void schedulingAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form taskManager = new Form2();
            this.Hide();
            taskManager.ShowDialog();
            this.Show();
        }

        private void OpenTaskManager(object sender, EventArgs e)
        {
            Form taskManager = new Form1();
            this.Hide();
            taskManager.ShowDialog();
            this.Show();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
