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
    public partial class NewClientData : Form
    {
        private int _NumOfContacts = 1;
        private int _currentID = 0;
        List<ClientData> _contacts;
        ClientData Client;
        private bool _editClient = false;
        SearchResults SR;

        public Label ContactListNumber2;
        public TextBox FirstNameData2 = new TextBox();
        public TextBox LastNameData2 = new TextBox();
        public TextBox TitleData2 = new TextBox();
        public TextBox EmailData2 = new TextBox();
        public Label CNT2_PN_Type_Label; 
        public Label CNT2_Number_Label;
        public Label CNT2_Ext_Label;
        public Label CNT2_PN1_Label;
        public Label CNT2_PN2_Label;
        public TextBox CNT2_PN1_Type_TB = new TextBox();
        public TextBox CNT2_PN1_Num_TB = new TextBox();
        public TextBox CNT2_PN1_Ext_TB = new TextBox();
        public TextBox CNT2_PN2_Type_TB = new TextBox();
        public TextBox CNT2_PN2_Num_TB = new TextBox();
        public TextBox CNT2_PN2_Ext_TB = new TextBox();
        public Label ContactListNumber3;
        public TextBox FirstNameData3 = new TextBox();
        public TextBox LastNameData3 = new TextBox();
        public TextBox TitleData3 = new TextBox();
        public TextBox EmailData3 = new TextBox();
        public Label CNT3_PN_Type_Label;
        public Label CNT3_Number_Label;
        public Label CNT3_Ext_Label;
        public Label CNT3_PN1_Label;
        public Label CNT3_PN2_Label;
        public TextBox CNT3_PN1_Type_TB = new TextBox();
        public TextBox CNT3_PN1_Num_TB = new TextBox();
        public TextBox CNT3_PN1_Ext_TB = new TextBox();
        public TextBox CNT3_PN2_Type_TB = new TextBox();
        public TextBox CNT3_PN2_Num_TB = new TextBox();
        public TextBox CNT3_PN2_Ext_TB = new TextBox();

        //Fresh new addition
        public NewClientData(List<ClientData> CD)
        {
            _contacts = CD;
            if (_contacts.Count == 0)
            {
                _currentID = 0;
            }
            else 
            {
                _currentID = _contacts[_contacts.Count - 1].ID + 1;
            }
            
            InitializeComponent();
            IDNumData.Text = _currentID.ToString();
            FCFSData.Text = "N/A";
            BAData.Text = "N/A";
        }

        //Edit existing data
        public NewClientData(List<ClientData> CD, ClientData client, SearchResults sr) 
        {
            _contacts = CD;
            Client = client;
            _editClient = true;
            SR = sr;
            InitializeComponent();
            //Check for number of contacts, expand window as needed
            if (client.contacts[1].FirstName == "" && client.contacts[2].FirstName == "")
            {
                FillDataWindowsContact1(client);
            }
            else if (client.contacts[1].FirstName != "" && client.contacts[2].FirstName == "")
            {
                //Show second contact data
                AddContact();
                FillDataWindowsContact1(client);
                FillDataWindowsContact2(client);
            }
            else if (client.contacts[1].FirstName != "" && client.contacts[2].FirstName != "")
            {
                //Show second and third contact data
                AddContact();
                AddContact();
                FillDataWindowsContact1(client);
                FillDataWindowsContact2(client);
                FillDataWindowsContact3(client);
            }
            //Fill all data windows
            
            this.Show();
        }

        private void AddContactBtn_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustNameData.Text == "" || BusNameData.Text == "" || LocationData.Text == "") 
            {
                Popup PU = new Popup();
                PU.Show();
                return;
            }
            if (FCFSData.Text == "N/A" || BAData.Text == "N/A") 
            {
                Popup PU = new Popup("Please select 'Yes' or 'No' \r\nfor FCFS and BA before saving.");
                PU.Show();
                return;
            }
            ClientData NCD = new ClientData();
            NCD.ID = Convert.ToInt16(IDNumData.Text);
            NCD.customerName = CustNameData.Text;
            NCD.businessName = BusNameData.Text;
            NCD.location = LocationData.Text;
            NCD.customer = CustCheckBox.Checked;
            NCD.site = SiteCheckBox.Checked;
            NCD.FCFS = FCFSData.Text == "Yes" ? true : false;
            NCD.BA = BAData.Text == "Yes" ? true : false;
            NCD.contacts = new List<Contact>
                        {
                            //Contact 1
                            new Contact
                            {
                                FirstName = FirstNameData1.Text,
                                LastName = LastNameData1.Text,
                                Title = TitleData1.Text,
                                Email = EmailData1.Text,
                                PhoneNumbers = new List<PhoneContacts>
                                {
                                    new PhoneContacts
                                    {
                                        NumberType = CNT1_PN1_Type_TB.Text,
                                        PhoneNumber = CNT1_PN1_Num_TB.Text,
                                        Ext = CNT1_PN1_Ext_TB.Text
                                    },
                                    new PhoneContacts
                                    {
                                        NumberType = CNT1_PN2_Type_TB.Text,
                                        PhoneNumber = CNT1_PN2_Num_TB.Text,
                                        Ext = CNT1_PN2_Ext_TB.Text
                                    }
                                }
                            },
                            // Contact 2
                            new Contact
                            {
                                FirstName = FirstNameData2.Text,
                                LastName = LastNameData2.Text,
                                Title = TitleData2.Text,
                                Email = EmailData2.Text,
                                PhoneNumbers = new List<PhoneContacts>
                                {
                                    new PhoneContacts
                                    {
                                        NumberType = CNT2_PN1_Type_TB.Text,
                                        PhoneNumber = CNT2_PN1_Num_TB.Text,
                                        Ext = CNT2_PN1_Ext_TB.Text
                                    },
                                    new PhoneContacts
                                    {
                                        NumberType = CNT2_PN2_Type_TB.Text,
                                        PhoneNumber = CNT2_PN2_Num_TB.Text,
                                        Ext = CNT2_PN2_Ext_TB.Text
                                    }
                                }
                            },
                            //Contact 3
                            new Contact
                            {
                                FirstName = FirstNameData3.Text,
                                LastName = LastNameData3.Text,
                                Title = TitleData3.Text,
                                Email = EmailData3.Text,
                                PhoneNumbers = new List<PhoneContacts>
                                {
                                    new PhoneContacts
                                    {
                                        NumberType = CNT3_PN1_Type_TB.Text,
                                        PhoneNumber = CNT3_PN1_Num_TB.Text,
                                        Ext = CNT3_PN1_Ext_TB.Text
                                    },
                                    new PhoneContacts
                                    {
                                        NumberType = CNT3_PN2_Type_TB.Text,
                                        PhoneNumber = CNT3_PN2_Num_TB.Text,
                                        Ext = CNT3_PN2_Ext_TB.Text
                                    }
                                }
                            }
                        };

            NCD.notesGeneral = NotesGeneralData.Text;
            NCD.notesEquipment = NotesEquipmentData.Text;
            NCD.notesSpecialRequirements = NotesSpecialRequirementsData.Text;

            if (_editClient)
            {
                var contactIndex = _contacts.IndexOf(_contacts.Find(i => i.ID.Equals(NCD.ID)));
                _contacts.RemoveAt(contactIndex);
                _contacts.Insert(contactIndex, NCD);
                RefreshSearchResults();
            }
            else 
            {
                _contacts.Add(NCD);
            }
            FileHandler.SaveContactsJSON(_contacts);
            this.Hide();
        }

        public void RefreshSearchResults()
        {
            List<ClientData> tempContacts;
            if (SR._results is null)
            {
                tempContacts = _contacts;
            }
            else
            { 
                tempContacts = SR._results;
            }
            
            ListView lv = SR.SearchResultView;
            lv.Items.Clear();
            foreach (var item in tempContacts)
            {
                var row = new string[] { (item.ID).ToString(), item.customerName, item.businessName, item.location };
                var li = lv.Items.Add(new ListViewItem(row));
            }
        }

        private void AddContact() 
        {
            if (_NumOfContacts >= 3)
            {
                return;
            }
            else 
            {
                moveLowerLabels(140);
                this.Height = this.Height + 10;
                CreateContactLabels();
                _NumOfContacts++;
            }
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

        private void CreateContactLabels() 
        {
            if (_NumOfContacts == 1) 
            {
                int moveDistY = 300;
                FirstNameData2 = CreateTextBox(31, moveDistY, 105, 29, "FirstNameData2", 18);
                LastNameData2 = CreateTextBox(142, moveDistY, 105, 29, "LastNameData2", 19);
                ContactListNumber2 = CreateLabel(10, moveDistY + 3, "ContactListNumber2", 41, "2");
                TitleData2 = CreateTextBox(253, moveDistY, 205, 29, "TitleData2", 20);
                EmailData2 = CreateTextBox(463, moveDistY, 312, 29, "EmailData2", 21);
                CNT2_PN_Type_Label = CreateLabel(397, moveDistY + 36, "CNT2_PN_Type_Label", 41, "Type");
                CNT2_Number_Label = CreateLabel(508, moveDistY + 36, "CNT2_Number_Label", 42, "Number");
                CNT2_Ext_Label = CreateLabel(669, moveDistY + 36, "CNT2_Ext_Label", 25, "Ext (if any)");
                CNT2_PN1_Label = CreateLabel(372, moveDistY + 63, "CNT2_PN1_Label", 25, "1");
                CNT2_PN2_Label = CreateLabel(372, moveDistY + 98, "CNT2_PN2_Label", 25, "2");
                CNT2_PN1_Type_TB = CreateTextBox(397, moveDistY + 60, 105, 29, "CNT2_PN1_Type_TB", 22);
                CNT2_PN1_Num_TB = CreateTextBox(508, moveDistY + 60, 155, 29, "CNT2_PN1_Num_TB", 23);
                CNT2_PN1_Ext_TB = CreateTextBox(669, moveDistY + 60, 105, 29, "CNT2_PN1_Num_TB", 24);
                CNT2_PN2_Type_TB = CreateTextBox(397, moveDistY + 95, 105, 29, "CNT2_PN2_Type_TB", 25);
                CNT2_PN2_Num_TB = CreateTextBox(508, moveDistY + 95, 155, 29, "CNT2_PN2_Num_TB", 26);
                CNT2_PN2_Ext_TB = CreateTextBox(669, moveDistY + 95, 105, 29, "CNT2_PN2_Ext_TB", 27);

                this.Controls.AddRange(new Control[] { 
                    FirstNameData2, LastNameData2, ContactListNumber2, TitleData2, EmailData2, 
                    CNT2_PN_Type_Label, CNT2_Number_Label, CNT2_Ext_Label, CNT2_PN1_Label, CNT2_PN2_Label, 
                    CNT2_PN1_Type_TB, CNT2_PN1_Num_TB, CNT2_PN1_Ext_TB, CNT2_PN2_Type_TB, CNT2_PN2_Num_TB, 
                    CNT2_PN2_Ext_TB
                });
            }

            
            if (_NumOfContacts == 2) 
            {
                moveLowerLabels(10);
                this.Height = this.Height + 10;
                int moveDistY = 450;
                FirstNameData3 = CreateTextBox(31, moveDistY, 105, 29, "FirstNameData3", 28);
                LastNameData3 = CreateTextBox(142, moveDistY, 105, 29, "LastNameData3", 29);
                ContactListNumber3 = CreateLabel(10, moveDistY + 3, "ContactListNumber3", 20, "3");
                TitleData3 = CreateTextBox(253, moveDistY, 205, 29, "TitleData3", 30);
                EmailData3 = CreateTextBox(463, moveDistY, 312, 29, "EmailData3", 31);
                CNT3_PN_Type_Label = CreateLabel(397, moveDistY + 36, "CNT3_PN_Type_Label", 25, "Type");
                CNT3_Number_Label = CreateLabel(508, moveDistY + 36, "CNT3_Number_Label", 25, "Number");
                CNT3_Ext_Label = CreateLabel(669, moveDistY + 36, "CNT3_Ext_Label", 25, "Ext (if any)");
                CNT3_PN1_Label = CreateLabel(372, moveDistY + 63, "CNT3_PN1_Label", 25, "1");
                CNT3_PN2_Label = CreateLabel(372, moveDistY + 98, "CNT3_PN2_Label", 25, "2");
                CNT3_PN1_Type_TB = CreateTextBox(397, moveDistY + 60, 105, 29, "CNT3_PN1_Type_TB", 32);
                CNT3_PN1_Num_TB = CreateTextBox(508, moveDistY + 60, 155, 29, "CNT3_PN1_Num_TB", 33);
                CNT3_PN1_Ext_TB = CreateTextBox(669, moveDistY + 60, 105, 29, "CNT3_PN1_Num_TB", 34);
                CNT3_PN2_Type_TB = CreateTextBox(397, moveDistY + 95, 105, 29, "CNT3_PN2_Type_TB", 35);
                CNT3_PN2_Num_TB = CreateTextBox(508, moveDistY + 95, 155, 29, "CNT3_PN2_Num_TB", 36);
                CNT3_PN2_Ext_TB = CreateTextBox(669, moveDistY + 95, 105, 29, "CNT3_PN2_Ext_TB", 37);

                this.Controls.AddRange(new Control[] {
                    FirstNameData3, LastNameData3, ContactListNumber3, TitleData3, EmailData3,
                    CNT3_PN_Type_Label, CNT3_Number_Label, CNT3_Ext_Label, CNT3_PN1_Label, CNT3_PN2_Label,
                    CNT3_PN1_Type_TB, CNT3_PN1_Num_TB, CNT3_PN1_Ext_TB, CNT3_PN2_Type_TB, CNT3_PN2_Num_TB,
                    CNT3_PN2_Ext_TB
                });
            }
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
                TabIndex = ti
            };
            return TB;
        }

        private void FillDataWindowsContact1(ClientData cd) 
        {
            IDNumData.Text = (cd.ID).ToString();
            CustNameData.Text = cd.customerName;
            BusNameData.Text = cd.businessName;
            LocationData.Text = cd.location;
            CustCheckBox.Checked = cd.customer ? true : false;
            SiteCheckBox.Checked = cd.site ? true : false;
            FCFSData.Text = cd.FCFS ? "Yes" : "No";
            BAData.Text = cd.BA ? "Yes" : "No";
            NotesGeneralData.Text = cd.notesGeneral;
            NotesEquipmentData.Text = cd.notesEquipment;
            NotesSpecialRequirementsData.Text = cd.notesSpecialRequirements;
            
            FirstNameData1.Text = cd.contacts[0].FirstName;
            LastNameData1.Text = cd.contacts[0].LastName;
            EmailData1.Text = cd.contacts[0].Email;
            TitleData1.Text = cd.contacts[0].Title;
            CNT1_PN1_Type_TB.Text = cd.contacts[0].PhoneNumbers[0].NumberType;
            CNT1_PN1_Num_TB.Text = cd.contacts[0].PhoneNumbers[0].PhoneNumber;
            CNT1_PN1_Ext_TB.Text = cd.contacts[0].PhoneNumbers[0].Ext;
            CNT1_PN2_Type_TB.Text = cd.contacts[0].PhoneNumbers[1].NumberType;
            CNT1_PN2_Num_TB.Text = cd.contacts[0].PhoneNumbers[1].PhoneNumber;
            CNT1_PN2_Ext_TB.Text = cd.contacts[0].PhoneNumbers[1].Ext;
        }

        private void FillDataWindowsContact2(ClientData cd) 
        {
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
        }

        private void FillDataWindowsContact3(ClientData cd)
        {
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
        }

    }
}
