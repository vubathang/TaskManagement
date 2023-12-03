using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TaskManager.Chat
{ 
    public partial class ServerForm : Form
    {
        private TcpListener server;
        private readonly List<TcpClient> clients = new();
        private readonly List<NetworkStream> streams = new();
        private readonly List<Thread> clientReceiveThreads = new();
        private bool closing = false;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8888);
                server.Start();
                ThreadPool.QueueUserWorkItem(new WaitCallback(ListenForClients)); // Wait and connect multiple clients
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in server operation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListenForClients(object state)
        {
            try
            {
                while (!closing)
                {
                    TcpClient client = server.AcceptTcpClient();
                    clients.Add(client);
                    NetworkStream stream = client.GetStream();
                    streams.Add(stream);
                    Thread clientReceiveThread = new(ClientReceive);
                    clientReceiveThreads.Add(clientReceiveThread);
                    clientReceiveThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                if (!closing)
                    MessageBox.Show($"Error accepting clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientReceive(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            int clientIndex = clients.IndexOf(client);
            try
            {
                while (!closing)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = streams[clientIndex].Read(buffer, 0, buffer.Length);
                    string message = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                    SendToClients(message);
                }
            }
            catch (Exception ex)
            {
                if (!closing)
                    MessageBox.Show($"Error receiving message from client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SendToClients(string message)
        {
            try
            {
                byte[] buffer = Encoding.Unicode.GetBytes(message);
                for (int i = 0; i < clients.Count; i++)
                    streams[i].Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message to clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddClient(string username, int threadId, int processId, ThreadPriority priority, ThreadState state)
        {
            if (InvokeRequired)
                Invoke(new Action<string, int, int, ThreadPriority, ThreadState>(AddClient), username, threadId, processId, priority, state);
            else
                dgvClients.Rows.Add(username, threadId, processId, priority, state);
        }

        public void RemoveClient(int threadId)
        {
            if (InvokeRequired)
                Invoke(new Action<int>(RemoveClient), threadId);
            else
            {
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    if (row.Cells[1].Value.ToString() == threadId.ToString())
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                if (rowIndex != -1)
                    dgvClients.Rows.RemoveAt(rowIndex);
                int clientIndex = -1;
                foreach (Thread thread in clientReceiveThreads)
                {
                    if (thread.ManagedThreadId == threadId)
                    {
                        clientIndex = clientReceiveThreads.IndexOf(thread);
                        break;
                    }
                }
                if (clientIndex != -1)
                {
                    streams[clientIndex].Close();
                    streams.RemoveAt(clientIndex);
                    clients[clientIndex].Close();
                    clients.RemoveAt(clientIndex);
                    clientReceiveThreads[clientIndex].Join();
                    clientReceiveThreads.RemoveAt(clientIndex);
                }
            }
        }

        public void DisplayClients(string message)
        {
            if (InvokeRequired)
                Invoke(new Action<string>(DisplayClients), message);
            else if (!IsDisposed)
                txbClients.AppendText(message + Environment.NewLine);
        }

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            for (int i = 0; i < clients.Count; i++)
            {
                streams[i].Close();
                clients[i].Close();
                clientReceiveThreads[i].Join();
            }
            server.Stop();
        }
    }
}
