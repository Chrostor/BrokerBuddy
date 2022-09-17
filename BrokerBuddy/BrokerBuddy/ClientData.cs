using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBuddy
{
    internal class ClientData
    {
        public int ID { get; set; }
        public bool Customer { get; set; }
        public bool Site { get; set; }
        public string CustomerName { get; set; }
        public string BusinessName { get; set; }
        public List<Contact> Contacts { get; set; }
        public bool FCFSBA { get; set; }
        public string notes1 { get; set; }
        public string notes2 { get; set; }
        public string notes3 { get; set; }
    }
}
