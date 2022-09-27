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
        public SearchResults()
        {
            InitializeComponent();

            var sd = SampleData.createSamples();
            ListView lv = SearchResultView;
            lv.Items.Clear();
            foreach (var item in sd)
            {
                var row = new string[] { (item.ID).ToString(), item.customerName, item.businessName };
                var li = lv.Items.Add(new ListViewItem(row));
                
                
            }
        }

        private void ResultsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchResultView_Click(object sender, EventArgs e)
        {
            try
            {
                var target = SearchResultView.SelectedItems[0].Text;
                DataWindow dw = new DataWindow();
                dw.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
