namespace PageFlowInstaller
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GettingInfo nextstep = new GettingInfo();
            nextstep.Show();
            this.Hide();
        }
    }
}
