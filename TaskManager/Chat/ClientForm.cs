using System.Net.Sockets;
using System.Text;

namespace TaskManager.Chat
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread clientReceiveThread;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", 8888);

                stream = client.GetStream();

                clientReceiveThread = new Thread(ClientReceive);
                clientReceiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientReceive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.Unicode.GetString(buffer, 0, bytesRead);

                    DisplayMessage($"Server: {message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
                Invoke(new Action<string>(DisplayMessage), message);
            else
                txbClientChat.AppendText(message + Environment.NewLine);
        }

        private void btnClientSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbClientMess.Text))
                {
                    MessageBox.Show("Please enter a message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string message = txbClientMess.Text;
                byte[] buffer = Encoding.Unicode.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);

                DisplayMessage($"Me: {message}");

                txbClientMess.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
