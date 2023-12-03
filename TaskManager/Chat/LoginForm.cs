using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.Chat
{
    public partial class LoginForm : Form
    {
        public string Username { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txbUsername.Text))
            {
                // Lưu username và đặt DialogResult là OK
                Username = txbUsername.Text;
                DialogResult = DialogResult.OK;
                Close(); // Đóng LoginForm
            }
            else
            {
                MessageBox.Show("Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
