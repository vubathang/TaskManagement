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

        //private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Color backgroundColor = Color.FromArgb(0x4f, 0x5b, 0x62);
        //    Form loginForm = new Login(backgroundColor);

        //    // Ẩn form hiện tại trước khi hiển thị form đăng nhập
        //    this.Hide();

        //    // Hiển thị form đăng nhập dưới dạng dialog
        //    loginForm.ShowDialog();

        //    // Hiện lại form sau khi form đăng nhập đóng lại
        //    this.Show();
        //}
    }
}
