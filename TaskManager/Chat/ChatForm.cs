namespace TaskManager.Chat
{
    public partial class ChatForm : Form
    {
        private Thread serverThread;
        private Thread clientThread;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            try
            {
                serverThread = new Thread(StartServer);
                serverThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartServer()
        {
            try
            {
                Application.Run(new ServerForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in server operation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            try
            {
                clientThread = new Thread(StartClient);
                clientThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartClient()
        {
            try
            {
                Application.Run(new ClientForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in client operation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
