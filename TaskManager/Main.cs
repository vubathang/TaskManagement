using TaskManager.Chat;
using TaskManager.Deadlock;

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
            Hide();
            taskManager.ShowDialog();
            Show();
        }

        private void OpenTaskManager(object sender, EventArgs e)
        {
            Form taskManager = new Form1();
            Hide();
            taskManager.ShowDialog();
            Show();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form chat = new ChatForm();
            Hide();
            chat.ShowDialog();
            Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form d = new Detection();
            Hide();
            d.ShowDialog();
            Show();
        }
    }
}
