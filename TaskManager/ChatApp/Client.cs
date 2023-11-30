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
            //this.KeyDown += new KeyEventHandler(Client_KeyDown);
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

        //private void Client_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        // Xử lý sự kiện khi nhấn Enter
        //        // Ở đây bạn có thể thực hiện các thao tác mong muốn với PictureBox
        //        pictureBox2.Image = Properties.Resources.Send;// Đặt hình ảnh mới hoặc thực hiện hành động mong muốn
        //        e.SuppressKeyPress = true;
        //    }
        //    richTextBox1.Text += $"Me\t: \"{txbMessage.Text}\"\n";
        //    txbMessage.Text = "";
        //}

        private void btnSend_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"Me\t: \"{txbMessage.Text}\"\n";
            txbMessage.Text = "";
        }
    }
}
