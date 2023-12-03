using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TaskManager.Chat
{
    public partial class ServerForm : Form
    {
        private TcpListener server;
        private TcpClient client;
        private NetworkStream stream;
        private Thread serverThread;
        private Thread clientReceiveThread;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            StartServer();
        }

        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8888);
                server.Start();

                client = server.AcceptTcpClient();
                stream = client.GetStream();

                clientReceiveThread = new Thread(ClientReceive);
                clientReceiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in server operation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    DisplayMessage($"Client: {message}");
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
                txbServerChat.AppendText(message + Environment.NewLine);
        }

        private void btnServerSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txbServerMess.Text))
                {
                    MessageBox.Show("Please enter a message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string message = txbServerMess.Text;
                byte[] buffer = Encoding.Unicode.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);

                DisplayMessage($"Server: {message}");

                txbServerMess.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message to client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
