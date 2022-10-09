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
        public SearchResults(List<ClientData> CD)
        {
            _clientData = CD;
            InitializeComponent();

            //var sd = SampleData.createSamples();
            ListView lv = SearchResultView;
            lv.Items.Clear();
            foreach (var item in _clientData)
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
                //var sd = SampleData.createSamples();
                //Target gets the ID of the data object
                var target = int.Parse(SearchResultView.SelectedItems[0].Text);
                DataWindow dw = new DataWindow();
                ClientData cd = _clientData.Find(i => i.ID.Equals(target));
                dw.IDNumData.Text = (cd.ID).ToString();
                dw.CustNameData.Text = cd.customerName;
                dw.BusNameData.Text = cd.businessName;
                dw.LocationData.Text = cd.location;
                dw.CustCheckBox.Checked = cd.customer ? true : false;
                dw.SiteCheckBox.Checked = cd.site ? true : false;
                dw.FCFSData.Text = cd.FCFS ? "Yes" : "No";
                dw.BAData.Text = cd.BA ? "Yes" : "No";
                dw.NotesGeneralData.Text = cd.notesGeneral;
                dw.NotesEquipmentData.Text = cd.notesEquipment;
                dw.NotesSpecialRequirementsData.Text = cd.notesSpecialRequirements;
                dw.FirstNameData1.Text = cd.contacts[0].FirstName;
                dw.LastNameData1.Text = cd.contacts[0].LastName;
                dw.EmailData1.Text = cd.contacts[0].Email;
                dw.TitleData1.Text = cd.contacts[0].Title;
                dw.CNT1_PN1_Type_TB.Text = (cd.contacts[0].PhoneNumbers[0].NumberType).ToString();
                dw.CNT1_PN1_Num_TB.Text = (cd.contacts[0].PhoneNumbers[0].PhoneNumber).ToString(); 
                dw.CNT1_PN1_Ext_TB.Text = (cd.contacts[0].PhoneNumbers[0].Ext).ToString() == "0" ? "None" : (cd.contacts[0].PhoneNumbers[0].Ext).ToString();
                dw.ClientData = cd;
                dw.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
