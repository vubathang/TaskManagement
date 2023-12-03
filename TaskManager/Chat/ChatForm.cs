namespace TaskManager.Chat
{
    public partial class ChatForm : Form
    {
        private Thread serverThread;
        private ServerForm serverForm;

        public ChatForm()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (serverForm == null || serverForm.IsDisposed)
                {
                    serverThread = new Thread(StartServer);
                    serverThread.Start();
                }
                else
                    MessageBox.Show("Server is already running.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting server: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartServer()
        {
            try
            {
                serverForm = new ServerForm();
                serverForm.Show(); 
                Application.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in server operation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (serverForm == null || serverForm.IsDisposed)
                {
                    MessageBox.Show("Server is not running.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                using LoginForm loginForm = new();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    string username = loginForm.Username;
                    ClientForm clientForm = new(serverForm, username);
                    clientForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
