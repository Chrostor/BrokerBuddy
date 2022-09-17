using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBuddy
{
    internal class SampleData
    {
        List<ClientData> sampleData = new List<ClientData>();

        private List<ClientData> createSamples() 
        {
            var samples = new List<ClientData>();
            var sam1 = new ClientData
            {
                ID = 1,
                Customer = true,
                Site = false,
                CustomerName = "Big Ricks",
                BusinessName = "None",
                Contacts = new List<Contact> 
                {
                    new Contact
                    {
                        FirstName = "Bill",
                        LastName = "Jones",
                        Email = "bigrick@bigricks.com",
                        Title = "Da Boss",
                        PhoneNumbers = new List<PhoneContacts>
                        { 
                            new PhoneContacts
                            {
                                PhoneNumber = 8175468795,
                                NumberType = "Cell"
                            }
                        }
                    }
                },
                FCFSBA = true,
                notes1 = "Fast workers",
                notes2 = "None",
                notes3 = "None"
            };
            var sam2 = new ClientData
            {
                ID = 2,
                Customer = false,
                Site = true,
                CustomerName = "None",
                BusinessName = "Warehouse 51",
                Contacts = new List<Contact>
                {
                    new Contact
                    {
                        FirstName = "Eric",
                        LastName = "Simpson",
                        Email = "esimps@gmail.com",
                        Title = "Dock Supervisor",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = 6825468792,
                                NumberType = "Office"
                            }
                        }
                    },
                    new Contact
                    {
                        FirstName = "Jake",
                        LastName = "Simpson",
                        Email = "jsimps@gmail.com",
                        Title = "Owner",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = 6828574652,
                                NumberType = "Office"
                            }
                        }
                    }
                },
                FCFSBA = true,
                notes1 = "Must call before 10 am",
                notes2 = "Dock closes at 4 pm",
                notes3 = "None"
            };
            var sam3 = new ClientData
            {
                ID = 3,
                Customer = true,
                Site = true,
                CustomerName = "Cagene Manufacturing",
                BusinessName = "Cagene Manufacturing",
                Contacts = new List<Contact>
                {
                    new Contact
                    {
                        FirstName = "Frank",
                        LastName = "Willard",
                        Email = "fwillar@cageneman.com",
                        Title = "Logistics Manager",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = 7928416481,
                                NumberType = "Work"
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = 7921597582,
                                NumberType = "Cell"
                            }
                        }
                    }
                },
                FCFSBA = false,
                notes1 = "Don't call on cell unless ABSOLUTELY NECESSARY",
                notes2 = "Dock opens at 10, closes at 6",
                notes3 = "They usually don't answer last two hours of the day"
            };
            //var sam4 = new ClientData();
            //var sam5 = new ClientData();
            samples.Add(sam1);
            samples.Add(sam2);
            samples.Add(sam3);
            return samples;
        }
    }
}
