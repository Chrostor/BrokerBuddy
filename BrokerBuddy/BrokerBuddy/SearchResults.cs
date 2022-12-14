using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrokerBuddy
{
    public partial class SearchResults : Form
    {
        List<ClientData> _clientData;
        public List<ClientData> _results;
        //All result list
        public SearchResults(List<ClientData> CD)
        {
            _clientData = CD;
            InitializeComponent();

            ListView lv = SearchResultView;
            lv.Items.Clear();
            foreach (var item in _clientData)
            {
                var row = new string[] { (item.ID).ToString(), item.customerName, item.businessName, item.location };
                var li = lv.Items.Add(new ListViewItem(row));
            }
        }

        //Results of specified search
        public SearchResults(List<ClientData> MWSR, List<ClientData> CD) 
        {
            _clientData = CD; // Full client list
            _results = MWSR; // Search Result smaller client list
            InitializeComponent();

            ListView lv = SearchResultView;
            lv.Items.Clear();
            foreach (var item in _results)
            {
                var row = new string[] { (item.ID).ToString(), item.customerName, item.businessName, item.location };
                var li = lv.Items.Add(new ListViewItem(row));
            }
        }

        private void SearchResultView_Click(object sender, EventArgs e)
        {
            try
            {   
                //var sd = SampleData.createSamples();
                //Target gets the ID of the data object
                var target = int.Parse(SearchResultView.SelectedItems[0].Text);

                ClientData cd = _clientData.Find(i => i.ID.Equals(target));
                DataWindow dw = new DataWindow(cd, _clientData, this);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
