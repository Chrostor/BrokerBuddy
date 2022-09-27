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
            List<ClientData> testContacts = SampleData.createSamples();
            //NewClientData form2 = new NewClientData();
            //form2.CustNameData.Text = testContacts[1].customerName;
            //form2.BusNameData.Text = testContacts[1].businessName;
            SearchResults SR = new SearchResults();
            SR.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            

        }

        private void custNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void busNameBox_TextChanged(object sender, EventArgs e)
        {

        }




    }
}