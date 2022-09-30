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
        private int _Con1PN = 1;
        public int _Con2PN = 1;
        public int _Con3PN = 1;
        public TextBox FirstNameData2;
        public TextBox LastNameData2;
        public Label ContactListNumber2;
        public TextBox TitleData2;
        public TextBox EmailData2;

        public NewClientData()
        {
            InitializeComponent();
        }

        private void EditContactBTN_Click(object sender, EventArgs e)
        {

        }

        private void AddContactBtn_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddPN1_Click(object sender, EventArgs e)
        {

        }

        private void AddContact() 
        {
            if (_NumOfContacts >= 3)
            {
                return;
            }
            else 
            {
                //_NumOfContacts++;
                moveLowerLabels(100);
                CreateContactLabels();
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
            if (this.Controls.Contains(NotesGeneralLabel)) 
            {
                NotesLabel.Text = "Yes, this works";
            }
            
        }

        private void CreateContactLabels() 
        {
            
            int moveDistY = 280;
            FirstNameData2 = new TextBox
                {
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(31, moveDistY), //160 before change
                    Name = "FirstNameData2",
                    Size = new System.Drawing.Size(105, 29),
                    TabIndex = 8
                };

            LastNameData2 = new TextBox
                {
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(142, moveDistY),
                    Name = "LastNameData2",
                    Size = new System.Drawing.Size(105, 29),
                    TabIndex = 9
                };
            
            ContactListNumber2 = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(10, moveDistY+3),
                    Name = "ContactListNumber2",
                    Size = new System.Drawing.Size(19, 21),
                    TabIndex = 20,
                    Text = "2"
                };

            TitleData2 = new TextBox
                {
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(253, moveDistY),
                    Name = "TitleData2",
                    Size = new System.Drawing.Size(205, 29),
                    TabIndex = 10
                };

            EmailData2 = new TextBox
                {
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(463, moveDistY),
                    Name = "EmailData2",
                    Size = new System.Drawing.Size(312, 29),
                    TabIndex = 11
                };
            
            Controls.Add(FirstNameData2);
            Controls.Add(LastNameData2);
            Controls.Add(ContactListNumber2);
            Controls.Add(TitleData2);
            Controls.Add(EmailData2);
            
            if (Controls.Contains(FirstNameData2))
            {
                NotesLabel.Text = "works";
            }
        }
    }
}
