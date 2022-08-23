using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBuddy
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        List<PhoneContacts> PhoneNumbers { get; set; }
    }
}
