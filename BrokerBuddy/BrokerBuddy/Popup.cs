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
    public partial class Popup : Form
    {
        Button confirmBTN = new Button();
        DataWindow dw;
        public Popup() 
        {
            InitializeComponent();
        }
        
        public Popup(DataWindow DW)
        {
            InitializeComponent();
            dw = DW;

            ErrorLabel.Text = "Are you sure you want to \r\ndelete this contact?";
            ErrorLabel.Left += 50;
            button1.Text = "Cancel";
            button1.Left -= 50;

            confirmBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            confirmBTN.Location = new System.Drawing.Point(230, 87);
            confirmBTN.Name = "confirmBTN";
            confirmBTN.Size = new System.Drawing.Size(96, 44);
            confirmBTN.TabIndex = 1;
            confirmBTN.Text = "Confirm";
            confirmBTN.UseVisualStyleBackColor = true;
            confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);

            this.Controls.Add(confirmBTN);
            
        }

        public Popup(string str) 
        {
            InitializeComponent();
            ErrorLabel.Text = str;
            ErrorLabel.Left += 50;
            button1.Text = "Cancel";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void confirmBTN_Click(object sender, EventArgs e) 
        {
            dw.deleteContact();
            this.Close();
            this.Dispose();
        }
    }
}
