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
            
            
        }

        private void ListAll_Click(object sender, EventArgs e)
        {
            SearchResults SR = new SearchResults();
            SR.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NewClientData ncd = new NewClientData();
            ncd.Show();

        }

        private void custNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void busNameBox_TextChanged(object sender, EventArgs e)
        {

        }




    }
}