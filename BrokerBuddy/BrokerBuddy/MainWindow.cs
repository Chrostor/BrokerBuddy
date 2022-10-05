namespace BrokerBuddy
{
    public partial class MainWindow : Form
    {
        public List<ClientData> _clientData;

        public MainWindow(List<ClientData> cd)
        {
            InitializeComponent();
            _clientData = cd;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ListAll_Click(object sender, EventArgs e)
        {
            SearchResults SR = new SearchResults(_clientData);
            SR.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NewClientData ncd = new NewClientData(_clientData);
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