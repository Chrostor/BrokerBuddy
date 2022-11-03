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

            List<ClientData> results = new List<ClientData>();
            foreach (var item in _clientData) 
            {
                if (custNameBox.Text != "" && item.customerName.ToLower().Contains(custNameBox.Text.ToLower()))
                {
                    results.Add(item);
                }
                else if (busNameBox.Text != "" && item.businessName.ToLower().Contains(busNameBox.Text.ToLower()))
                {
                    results.Add(item);
                }
                else if (conFirstNameBox.Text != "" &&
                    (
                    item.contacts[0].FirstName.ToLower().Contains(conFirstNameBox.Text.ToLower()) ||
                    item.contacts[1].FirstName.ToLower().Contains(conFirstNameBox.Text.ToLower()) ||
                    item.contacts[2].FirstName.ToLower().Contains(conFirstNameBox.Text.ToLower())
                    )
                    )
                {
                    results.Add(item);
                }
                else if (conLastNameBox.Text != "" &&
                        (
                            item.contacts[0].LastName.ToLower().Contains(conLastNameBox.Text.ToLower()) ||
                            item.contacts[1].LastName.ToLower().Contains(conLastNameBox.Text.ToLower()) ||
                            item.contacts[2].LastName.ToLower().Contains(conLastNameBox.Text.ToLower())
                        ))
                {
                    results.Add(item);
                }
                else if (busLocationBox.Text != "" && item.location.ToLower().Contains(busLocationBox.Text.ToLower())) 
                {
                    results.Add(item);
                }
            }
            SearchResults SR = new SearchResults(results, _clientData);
            SR.Show();
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

        private void custNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownHandler(e);
        }

        private void keyDownHandler(KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Search_Click(null, null);
            }
        }

        private void busNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownHandler(e);
        }

        private void conFirstNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownHandler(e);
        }

        private void conLastNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownHandler(e);
        }

        private void busLocationBox_KeyDown(object sender, KeyEventArgs e)
        {
            keyDownHandler(e);
        }
    }
}