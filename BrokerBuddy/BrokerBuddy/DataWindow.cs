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
        public DataWindow()
        {
            InitializeComponent();
        }

        private void EditContactBTN_Click(object sender, EventArgs e)
        {
            TextBox testAdd = new System.Windows.Forms.TextBox 
            {
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                Location = new System.Drawing.Point(31, 200),
                Name = "TestAdd",
                ReadOnly = true,
                Size = new System.Drawing.Size(209, 29),
                TabIndex = 41
            };
            Controls.Add(testAdd);
            NotesGeneralData.Location = new System.Drawing.Point(12, 395);
        }
    }
}
