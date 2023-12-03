using System.Net.Sockets;
using System.Text;

namespace TaskManager.Chat
{
    public partial class ClientForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread clientReceiveThread;
        private readonly ServerForm serverForm;
        private readonly string username;

        public ClientForm(ServerForm server, string username)
        {
            InitializeComponent();
            serverForm = server;
            this.username = username;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsername.Text = username;
                client = new TcpClient("127.0.0.1", 8888);
                stream = client.GetStream();

                // Create a separate thread to listen for messages from the server
                clientReceiveThread = new Thread(ClientReceive);
                clientReceiveThread.Start();

                serverForm.DisplayClients($"'{username}' connected.");
                serverForm.AddClient(username, clientReceiveThread.ManagedThreadId, Environment.ProcessId, Thread.CurrentThread.Priority, Thread.CurrentThread.ThreadState);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DisplayMessage(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error receiving message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
                Invoke(new Action<string>(DisplayMessage), message);
            else if (!IsDisposed)
                txbClientChat.AppendText(message + Environment.NewLine);
        }

        private void btnClientSend_Click(object sender, EventArgs e)
        {
            string message = $"{username}: {txbClientMess.Text}";
            SendMessageToServer(message);
            txbClientMess.Clear();
        }

        private void SendMessageToServer(string message)
        {
            try
            {
                byte[] buffer = Encoding.Unicode.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message to server: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverForm.DisplayClients($"'{username}' disconnected.");
            serverForm.RemoveClient(clientReceiveThread.ManagedThreadId);
        }
    }
}
