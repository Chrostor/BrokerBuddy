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
    public partial class DataWindow : Form
    {
        public int ID;
        public ClientData cd;
        public List<ClientData> data;
        public SearchResults sr;


        public Label ContactListNumber2;
        public TextBox FirstNameData2;
        public TextBox LastNameData2;
        public TextBox TitleData2;
        public TextBox EmailData2;
        public Label CNT2_PN_Type_Label;
        public Label CNT2_Number_Label;
        public Label CNT2_Ext_Label;
        public Label CNT2_PN1_Label;
        public Label CNT2_PN2_Label;
        public TextBox CNT2_PN1_Type_TB;
        public TextBox CNT2_PN1_Num_TB;
        public TextBox CNT2_PN1_Ext_TB;
        public TextBox CNT2_PN2_Type_TB;
        public TextBox CNT2_PN2_Num_TB;
        public TextBox CNT2_PN2_Ext_TB;
        public Label ContactListNumber3;
        public TextBox FirstNameData3;
        public TextBox LastNameData3;
        public TextBox TitleData3;
        public TextBox EmailData3;
        public Label CNT3_PN_Type_Label;
        public Label CNT3_Number_Label;
        public Label CNT3_Ext_Label;
        public Label CNT3_PN1_Label;
        public Label CNT3_PN2_Label;
        public TextBox CNT3_PN1_Type_TB;
        public TextBox CNT3_PN1_Num_TB;
        public TextBox CNT3_PN1_Ext_TB;
        public TextBox CNT3_PN2_Type_TB;
        public TextBox CNT3_PN2_Num_TB;
        public TextBox CNT3_PN2_Ext_TB;

        public DataWindow(ClientData CD, List<ClientData> data, SearchResults SR)
        {
            sr = SR;
            cd = CD;
            InitializeComponent();
            this.Text = cd.businessName;
            this.IDNumData.Text = (cd.ID).ToString();
            this.CustNameData.Text = cd.customerName;
            this.BusNameData.Text = cd.businessName;
            this.LocationData.Text = cd.location;
            this.CustCheckBox.Checked = cd.customer ? true : false;
            this.SiteCheckBox.Checked = cd.site ? true : false;
            this.FCFSData.Text = cd.FCFS ? "Yes" : "No";
            this.BAData.Text = cd.BA ? "Yes" : "No";
            this.NotesGeneralData.Text = cd.notesGeneral;
            this.NotesEquipmentData.Text = cd.notesEquipment;
            this.NotesSpecialRequirementsData.Text = cd.notesSpecialRequirements;
            this.FirstNameData1.Text = cd.contacts[0].FirstName;
            this.LastNameData1.Text = cd.contacts[0].LastName;
            this.EmailData1.Text = cd.contacts[0].Email;
            this.TitleData1.Text = cd.contacts[0].Title;
            this.CNT1_PN1_Type_TB.Text = cd.contacts[0].PhoneNumbers[0].NumberType;
            this.CNT1_PN1_Num_TB.Text = (cd.contacts[0].PhoneNumbers[0].PhoneNumber == "") ? "" : cd.contacts[0].PhoneNumbers[0].PhoneNumber;
            this.CNT1_PN1_Ext_TB.Text = (cd.contacts[0].PhoneNumbers[0].Ext == "") ? "" : (cd.contacts[0].PhoneNumbers[0].Ext).ToString();
            this.CNT1_PN2_Type_TB.Text = cd.contacts[0].PhoneNumbers[1].NumberType;
            this.CNT1_PN2_Num_TB.Text = (cd.contacts[0].PhoneNumbers[1].PhoneNumber == "") ? "" : cd.contacts[0].PhoneNumbers[1].PhoneNumber;
            this.CNT1_PN2_Ext_TB.Text = (cd.contacts[0].PhoneNumbers[1].Ext == "") ? "" : cd.contacts[0].PhoneNumbers[1].Ext;
            if (cd.contacts[1].FirstName == "" && cd.contacts[2].FirstName == "")
            {

            }
            else if (cd.contacts[1].FirstName != "" && cd.contacts[2].FirstName == "")
            {
                //Show second contact data
                moveLowerLabels(140);
                this.Height = this.Height + 10;
                createLabels1Contact();

            }
            else if (cd.contacts[1].FirstName != "" && cd.contacts[2].FirstName != "")
            {
                //Show second and third contact data
                moveLowerLabels(280);
                this.Height = (this.Height) + 10;
                createLabels1Contact();
                createLabels2Contact();
                
            }
            this.Show();
            this.data = data;
        }

        private void EditContactBTN_Click(object sender, EventArgs e)
        {
            NewClientData NCD = new NewClientData(data, cd, sr);
            this.Close();
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup(this);
            
            popup.Show();

        }

        public void deleteContact() 
        {
            data.Remove(data.Find(i => i.ID.Equals(cd.ID)));
            ListView lv = sr.SearchResultView;
            lv.Items.Clear();
            foreach (var item in data)
            {
                var row = new string[] { (item.ID).ToString(), item.customerName, item.businessName, item.location };
                var li = lv.Items.Add(new ListViewItem(row));
            }
            FileHandler.SaveContactsJSON(data);
            this.Close();
        }

        private Label CreateLabel(int px, int py, string name, int ti, string txt)
        {
            Label LB = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                Location = new System.Drawing.Point(px, py),
                Name = name,
                Size = new System.Drawing.Size(19, 21),
                TabIndex = ti,
                Text = txt
            };
            return LB;
        }

        private TextBox CreateTextBox(int px, int py, int sl, int sw, string name, int ti)
        {
            TextBox TB = new TextBox
            {
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                Location = new System.Drawing.Point(px, py), //160 before change
                Name = name,
                Size = new System.Drawing.Size(sl, sw),
                TabIndex = ti,
                ReadOnly = true
            };
            return TB;
        }

        private void moveLowerLabels(int amount)
        {
            NotesLabel.Top += amount;
            NotesGeneralLabel.Top += amount;
            NotesGeneralData.Top += amount;
            NotesEQPLabel.Top += amount;
            NotesEquipmentData.Top += amount;
            NotesSPCREQLabel.Top += amount;
            NotesSpecialRequirementsData.Top += amount;
        }

        private void createLabels1Contact() 
        {
            int moveDistY = 300;
            FirstNameData2 = CreateTextBox(31, moveDistY, 105, 29, "FirstNameData2", 18);
            LastNameData2 = CreateTextBox(142, moveDistY, 105, 29, "LastNameData2", 19);
            ContactListNumber2 = CreateLabel(10, moveDistY + 3, "ContactListNumber2", 20, "2");
            TitleData2 = CreateTextBox(253, moveDistY, 205, 29, "TitleData2", 21);
            EmailData2 = CreateTextBox(463, moveDistY, 312, 29, "EmailData2", 22);
            CNT2_PN_Type_Label = CreateLabel(447, moveDistY + 36, "CNT2_PN_Type_Label", 25, "Type");
            CNT2_Number_Label = CreateLabel(558, moveDistY + 36, "CNT2_Number_Label", 25, "Number");
            CNT2_Ext_Label = CreateLabel(669, moveDistY + 36, "CNT2_Ext_Label", 25, "Ext (if any)");
            CNT2_PN1_Label = CreateLabel(422, moveDistY + 63, "CNT2_PN1_Label", 25, "1");
            CNT2_PN2_Label = CreateLabel(422, moveDistY + 98, "CNT2_PN2_Label", 25, "2");
            CNT2_PN1_Type_TB = CreateTextBox(447, moveDistY + 60, 105, 29, "CNT2_PN1_Type_TB", 23);
            CNT2_PN1_Num_TB = CreateTextBox(558, moveDistY + 60, 105, 29, "CNT2_PN1_Num_TB", 24);
            CNT2_PN1_Ext_TB = CreateTextBox(669, moveDistY + 60, 105, 29, "CNT2_PN1_Num_TB", 25);
            CNT2_PN2_Type_TB = CreateTextBox(447, moveDistY + 95, 105, 29, "CNT2_PN2_Type_TB", 26);
            CNT2_PN2_Num_TB = CreateTextBox(558, moveDistY + 95, 105, 29, "CNT2_PN2_Num_TB", 27);
            CNT2_PN2_Ext_TB = CreateTextBox(669, moveDistY + 95, 105, 29, "CNT2_PN2_Ext_TB", 28);
            FirstNameData2.Text = cd.contacts[1].FirstName;
            LastNameData2.Text = cd.contacts[1].LastName;
            TitleData2.Text = cd.contacts[1].Title;
            EmailData2.Text = cd.contacts[1].Email;

            CNT2_PN1_Type_TB.Text = cd.contacts[1].PhoneNumbers[0].NumberType;
            CNT2_PN1_Num_TB.Text = cd.contacts[1].PhoneNumbers[0].PhoneNumber;
            CNT2_PN1_Ext_TB.Text = cd.contacts[1].PhoneNumbers[0].Ext;
            CNT2_PN2_Type_TB.Text = cd.contacts[1].PhoneNumbers[1].NumberType;
            CNT2_PN2_Num_TB.Text = cd.contacts[1].PhoneNumbers[1].PhoneNumber;
            CNT2_PN2_Ext_TB.Text = cd.contacts[1].PhoneNumbers[1].Ext;

            this.Controls.AddRange(new Control[] {
                    FirstNameData2, LastNameData2, ContactListNumber2, TitleData2, EmailData2,
                    CNT2_PN_Type_Label, CNT2_Number_Label, CNT2_Ext_Label, CNT2_PN1_Label, CNT2_PN2_Label,
                    CNT2_PN1_Type_TB, CNT2_PN1_Num_TB, CNT2_PN1_Ext_TB, CNT2_PN2_Type_TB, CNT2_PN2_Num_TB,
                    CNT2_PN2_Ext_TB
            });
        }

        private void createLabels2Contact() 
        {
            int moveDistY = 440;
            FirstNameData3 = CreateTextBox(31, moveDistY, 105, 29, "FirstNameData3", 29);
            LastNameData3 = CreateTextBox(142, moveDistY, 105, 29, "LastNameData3", 30);
            ContactListNumber3 = CreateLabel(10, moveDistY + 3, "ContactListNumber3", 31, "3");
            TitleData3 = CreateTextBox(253, moveDistY, 205, 29, "TitleData3", 32);
            EmailData3 = CreateTextBox(463, moveDistY, 312, 29, "EmailData3", 33);
            CNT3_PN_Type_Label = CreateLabel(447, moveDistY + 36, "CNT3_PN_Type_Label", 25, "Type");
            CNT3_Number_Label = CreateLabel(558, moveDistY + 36, "CNT3_Number_Label", 25, "Number");
            CNT3_Ext_Label = CreateLabel(669, moveDistY + 36, "CNT3_Ext_Label", 25, "Ext (if any)");
            CNT3_PN1_Label = CreateLabel(422, moveDistY + 63, "CNT3_PN1_Label", 25, "1");
            CNT3_PN2_Label = CreateLabel(422, moveDistY + 98, "CNT3_PN2_Label", 25, "2");
            CNT3_PN1_Type_TB = CreateTextBox(447, moveDistY + 60, 105, 29, "CNT3_PN1_Type_TB", 34);
            CNT3_PN1_Num_TB = CreateTextBox(558, moveDistY + 60, 105, 29, "CNT3_PN1_Num_TB", 35);
            CNT3_PN1_Ext_TB = CreateTextBox(669, moveDistY + 60, 105, 29, "CNT3_PN1_Num_TB", 36);
            CNT3_PN2_Type_TB = CreateTextBox(447, moveDistY + 95, 105, 29, "CNT3_PN2_Type_TB", 37);
            CNT3_PN2_Num_TB = CreateTextBox(558, moveDistY + 95, 105, 29, "CNT3_PN2_Num_TB", 38);
            CNT3_PN2_Ext_TB = CreateTextBox(669, moveDistY + 95, 105, 29, "CNT3_PN2_Ext_TB", 39);
            FirstNameData3.Text = cd.contacts[2].FirstName;
            LastNameData3.Text = cd.contacts[2].LastName;
            TitleData3.Text = cd.contacts[2].Title;
            EmailData3.Text = cd.contacts[2].Email;

            CNT3_PN1_Type_TB.Text = cd.contacts[2].PhoneNumbers[0].NumberType;
            CNT3_PN1_Num_TB.Text = cd.contacts[2].PhoneNumbers[0].PhoneNumber;
            CNT3_PN1_Ext_TB.Text = cd.contacts[2].PhoneNumbers[0].Ext;
            CNT3_PN2_Type_TB.Text = cd.contacts[2].PhoneNumbers[1].NumberType;
            CNT3_PN2_Num_TB.Text = cd.contacts[2].PhoneNumbers[1].PhoneNumber;
            CNT3_PN2_Ext_TB.Text = cd.contacts[2].PhoneNumbers[1].Ext;

            this.Controls.AddRange(new Control[] {
                    FirstNameData3, LastNameData3, ContactListNumber3, TitleData3, EmailData3,
                    CNT3_PN_Type_Label, CNT3_Number_Label, CNT3_Ext_Label, CNT3_PN1_Label, CNT3_PN2_Label,
                    CNT3_PN1_Type_TB, CNT3_PN1_Num_TB, CNT3_PN1_Ext_TB, CNT3_PN2_Type_TB, CNT3_PN2_Num_TB,
                    CNT3_PN2_Ext_TB
            });
        }
    }
}
