using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBuddy
{
    public class ClientData
    {
        public int ID { get; set; }
        public bool customer { get; set; }
        public bool site { get; set; }
        public string customerName { get; set; }
        public string businessName { get; set; }
        public string location { get; set; }
        public List<Contact> contacts { get; set; }
        public bool FCFS { get; set; }
        public bool BA { get; set; }
        public string notesGeneral { get; set; }
        public string notesEquipment { get; set; }
        public string notesSpecialRequirements { get; set; }
    }
}
