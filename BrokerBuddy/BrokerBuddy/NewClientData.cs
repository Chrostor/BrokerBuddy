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

        public NewClientData(List<ClientData> CD)
        {
            _contacts = CD;
            _currentID = _contacts[_contacts.Count - 1].ID + 1;
            InitializeComponent();
            IDNumData.Text = _currentID.ToString();
            FCFSData.Text = "N/A";
            BAData.Text = "N/A";
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
            ClientData NCD = new ClientData();
            NCD.ID = Convert.ToInt16(IDNumData.Text);
            NCD.customerName = CustNameData.Text;
            NCD.businessName = BusNameData.Text;
            NCD.location = LocationData.Text;
            NCD.customer = CustCheckBox.Checked;
            NCD.site = SiteCheckBox.Checked;
            NCD.FCFS = FCFSData.Text == "Yes" ? true : false;
            NCD.BA = BAData.Text == "Yes" ? true : false;
            long CNT1_PN1 = (CNT1_PN1_Num_TB.Text == "") ? 0 : long.Parse(CNT1_PN1_Num_TB.Text);
            long CNT1_PN2 = (CNT1_PN2_Num_TB.Text == "") ? 0 : long.Parse(CNT1_PN2_Num_TB.Text);
            int CNT1_PN1_E = (CNT1_PN1_Ext_TB.Text == "") ? 0 : int.Parse(CNT1_PN1_Ext_TB.Text);
            int CNT1_PN2_E = (CNT1_PN2_Ext_TB.Text == "") ? 0 : int.Parse(CNT1_PN2_Ext_TB.Text);
            long CNT2_PN1 = (CNT2_PN1_Num_TB.Text == "") ? 0 : long.Parse(CNT2_PN1_Num_TB.Text);
            long CNT2_PN2 = (CNT2_PN2_Num_TB.Text == "") ? 0 : long.Parse(CNT2_PN2_Num_TB.Text);
            int CNT2_PN1_E = (CNT2_PN1_Ext_TB.Text == "") ? 0 : int.Parse(CNT2_PN1_Ext_TB.Text);
            int CNT2_PN2_E = (CNT2_PN2_Ext_TB.Text == "") ? 0 : int.Parse(CNT2_PN2_Ext_TB.Text);
            long CNT3_PN1 = (CNT3_PN1_Num_TB.Text == "") ? 0 : long.Parse(CNT3_PN1_Num_TB.Text);
            long CNT3_PN2 = (CNT3_PN2_Num_TB.Text == "") ? 0 : long.Parse(CNT3_PN2_Num_TB.Text);
            int CNT3_PN1_E = (CNT3_PN1_Ext_TB.Text == "") ? 0 : int.Parse(CNT3_PN1_Ext_TB.Text);
            int CNT3_PN2_E = (CNT3_PN2_Ext_TB.Text == "") ? 0 : int.Parse(CNT3_PN2_Ext_TB.Text);
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
                                        PhoneNumber = CNT1_PN1,
                                        Ext = CNT1_PN1_E
                                    },
                                    new PhoneContacts
                                    {
                                        NumberType = CNT1_PN2_Type_TB.Text,
                                        PhoneNumber = CNT1_PN2,
                                        Ext = CNT1_PN2_E
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
                                        PhoneNumber = CNT2_PN1,
                                        Ext = CNT2_PN1_E
                                    },
                                    new PhoneContacts
                                    {
                                        NumberType = CNT2_PN2_Type_TB.Text,
                                        PhoneNumber = CNT2_PN2,
                                        Ext = CNT2_PN2_E
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
                                        PhoneNumber = CNT3_PN1,
                                        Ext = CNT3_PN1_E
                                    },
                                    new PhoneContacts
                                    {
                                        NumberType = CNT3_PN2_Type_TB.Text,
                                        PhoneNumber = CNT3_PN2,
                                        Ext = CNT3_PN2_E
                                    }
                                }
                            }
                        };

            NCD.notesGeneral = NotesGeneralData.Text;
            NCD.notesEquipment = NotesEquipmentData.Text;
            NCD.notesSpecialRequirements = NotesSpecialRequirementsData.Text;

            _contacts.Add(NCD);
            this.Hide();
            //TODO: Check how many contact numbers
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
                FirstNameData2 = CreateTextBox(31, moveDistY, 105, 29, "FirstNameData2", 8);
                LastNameData2 = CreateTextBox(142, moveDistY, 105, 29, "LastNameData2", 9);
                ContactListNumber2 = CreateLabel(10, moveDistY + 3, "ContactListNumber2", 20, "2");
                TitleData2 = CreateTextBox(253, moveDistY, 205, 29, "TitleData2", 10);
                EmailData2 = CreateTextBox(463, moveDistY, 312, 29, "EmailData2", 11);
                CNT2_PN_Type_Label = CreateLabel(447, moveDistY + 36, "CNT2_PN_Type_Label", 25, "Type");
                CNT2_Number_Label = CreateLabel(558, moveDistY + 36, "CNT2_Number_Label", 25, "Number");
                CNT2_Ext_Label = CreateLabel(669, moveDistY + 36, "CNT2_Ext_Label", 25, "Ext (if any)");
                CNT2_PN1_Label = CreateLabel(422, moveDistY + 63, "CNT2_PN1_Label", 25, "1");
                CNT2_PN2_Label = CreateLabel(422, moveDistY + 98, "CNT2_PN2_Label", 25, "2");
                CNT2_PN1_Type_TB = CreateTextBox(447, moveDistY + 60, 105, 29, "CNT2_PN1_Type_TB", 25);
                CNT2_PN1_Num_TB = CreateTextBox(558, moveDistY + 60, 105, 29, "CNT2_PN1_Num_TB", 25);
                CNT2_PN1_Ext_TB = CreateTextBox(669, moveDistY + 60, 105, 29, "CNT2_PN1_Num_TB", 25);
                CNT2_PN2_Type_TB = CreateTextBox(447, moveDistY + 95, 105, 29, "CNT2_PN2_Type_TB", 25);
                CNT2_PN2_Num_TB = CreateTextBox(558, moveDistY + 95, 105, 29, "CNT2_PN2_Num_TB", 25);
                CNT2_PN2_Ext_TB = CreateTextBox(669, moveDistY + 95, 105, 29, "CNT2_PN2_Ext_TB", 25);

                this.Controls.AddRange(new Control[] { 
                    FirstNameData2, LastNameData2, ContactListNumber2, TitleData2, EmailData2, 
                    CNT2_PN_Type_Label, CNT2_Number_Label, CNT2_Ext_Label, CNT2_PN1_Label, CNT2_PN2_Label, 
                    CNT2_PN1_Type_TB, CNT2_PN1_Num_TB, CNT2_PN1_Ext_TB, CNT2_PN2_Type_TB, CNT2_PN2_Num_TB, 
                    CNT2_PN2_Ext_TB
                });
            }

            
            if (_NumOfContacts == 2) 
            {
                this.Location = new System.Drawing.Point(0, 0);
                moveLowerLabels(10);
                this.Height = this.Height + 10;
                int moveDistY = 450;
                FirstNameData3 = CreateTextBox(31, moveDistY, 105, 29, "FirstNameData3", 8);
                LastNameData3 = CreateTextBox(142, moveDistY, 105, 29, "LastNameData3", 9);
                ContactListNumber3 = CreateLabel(10, moveDistY + 3, "ContactListNumber3", 20, "3");
                TitleData3 = CreateTextBox(253, moveDistY, 205, 29, "TitleData3", 10);
                EmailData3 = CreateTextBox(463, moveDistY, 312, 29, "EmailData3", 11);
                CNT3_PN_Type_Label = CreateLabel(447, moveDistY + 36, "CNT3_PN_Type_Label", 25, "Type");
                CNT3_Number_Label = CreateLabel(558, moveDistY + 36, "CNT3_Number_Label", 25, "Number");
                CNT3_Ext_Label = CreateLabel(669, moveDistY + 36, "CNT3_Ext_Label", 25, "Ext (if any)");
                CNT3_PN1_Label = CreateLabel(422, moveDistY + 63, "CNT3_PN1_Label", 25, "1");
                CNT3_PN2_Label = CreateLabel(422, moveDistY + 98, "CNT3_PN2_Label", 25, "2");
                CNT3_PN1_Type_TB = CreateTextBox(447, moveDistY + 60, 105, 29, "CNT3_PN1_Type_TB", 25);
                CNT3_PN1_Num_TB = CreateTextBox(558, moveDistY + 60, 105, 29, "CNT3_PN1_Num_TB", 25);
                CNT3_PN1_Ext_TB = CreateTextBox(669, moveDistY + 60, 105, 29, "CNT3_PN1_Num_TB", 25);
                CNT3_PN2_Type_TB = CreateTextBox(447, moveDistY + 95, 105, 29, "CNT3_PN2_Type_TB", 25);
                CNT3_PN2_Num_TB = CreateTextBox(558, moveDistY + 95, 105, 29, "CNT3_PN2_Num_TB", 25);
                CNT3_PN2_Ext_TB = CreateTextBox(669, moveDistY + 95, 105, 29, "CNT3_PN2_Ext_TB", 25);

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
    }
}
