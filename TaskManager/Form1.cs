namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResourceManager resourceManager = new ResourceManager();
            resourceManager.loadProcessList();
        }
    }
}