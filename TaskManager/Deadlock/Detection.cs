namespace TaskManager.Deadlock
{
    public partial class Detection : Form
    {
        public Detection()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rand = new();
            string process = ((char)rand.Next(65, 91)).ToString();
            dgvProcess.Rows.Add(process, "", "");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvProcess.Rows.Clear();
        }
    }
}
