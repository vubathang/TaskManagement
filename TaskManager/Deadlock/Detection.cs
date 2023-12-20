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
            listBox1.Items.Clear();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Deadlock d = new Deadlock();
            for (int i = 0; i < dgvProcess.Rows.Count; i++)
            {
                string pr = dgvProcess.Rows[i].Cells[0].Value.ToString();
                string ro = dgvProcess.Rows[i].Cells[1].Value.ToString();
                string rr = dgvProcess.Rows[i].Cells[2].Value.ToString();
                d.input(pr, ro, rr);
            }
            d.run();
            foreach (List<object> dl in Deadlock.deadlockList)
            {
                string item = string.Join("->", dl);
                listBox1.Items.Add(item);
            }
        }
    }
}
