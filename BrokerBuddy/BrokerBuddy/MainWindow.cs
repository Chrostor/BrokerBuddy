namespace BrokerBuddy
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Greeting.Text = this.custNameBox.Text;
            
        }

        private void ListAll_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            DataWindow form2 = new DataWindow();
            form2.Show();
        }

        private void custNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void busNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void conNameBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}