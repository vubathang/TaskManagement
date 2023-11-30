using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.ChatApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OpenClient()
        {
            Form f = new Client(txbUsername.Text, txbPort.Text);
            f.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(OpenClient);
            t.Start();
            //Form f = new Client(txbUsername.Text, txbPort.Text);
            //f.Show();

        }
    }
}
