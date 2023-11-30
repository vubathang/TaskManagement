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
    public partial class Client : Form
    {
        Dictionary<string, string> messages = new Dictionary<string, string>();

        public Client(string name, string port)
        {
            InitializeComponent();
            lbName.Text = name;
            lbPort.Text = port;
            RenderChat();
        }

        private void RenderChat()
        {
            addElemToDict();
            foreach (KeyValuePair<string, string> m in messages)
            {
                richTextBox1.Text += $"{m.Key}\t: \"{m.Value}\"\n";
            }
        }

        private void addElemToDict()
        {
            messages.Add("Thang", "Hello");
            messages.Add("Huyen", "Good Morning");
            messages.Add("Huy", "Good Morning");

        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"me\t: \"{txbMessage.Text}\"\n";
            txbMessage.Text = "";
        }
    }
}
