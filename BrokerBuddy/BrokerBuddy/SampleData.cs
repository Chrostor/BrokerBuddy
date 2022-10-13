using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBuddy
{
    internal class SampleData
    {
        

        static public List<ClientData> createSamples() 
        {
            var samples = new List<ClientData>();
            var sam1 = new ClientData
            {
                ID = 1,
                customer = true,
                site = false,
                customerName = "Big Ricks",
                businessName = "None",
                location = "Fort Worth, Texas",
                contacts = new List<Contact>
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
                                PhoneNumber = "8175468795",
                                NumberType = "Cell",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            }
                        }
                    },
                    new Contact
                    {
                        FirstName = "",
                        LastName = "",
                        Email = "",
                        Title = "",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            }
                        }
                    },
                    new Contact
                    {
                        FirstName = "",
                        LastName = "",
                        Email = "",
                        Title = "",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            }
                        }
                    }
                },
                FCFS = true,
                BA = false,
                notesGeneral = "Fast workers",
                notesEquipment = "None",
                notesSpecialRequirements = "None"
            };
            var sam2 = new ClientData
            {
                ID = 2,
                customer = false,
                site = true,
                customerName = "None",
                businessName = "Warehouse 51",
                location = "Atlanta, Georgia",
                contacts = new List<Contact>
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
                                PhoneNumber = "6825468792",
                                NumberType = "Office",
                                Ext = "3084"
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
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
                                PhoneNumber = "6828574652",
                                NumberType = "Office",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            }
                        }
                    },
                    new Contact
                    {
                        FirstName = "",
                        LastName = "",
                        Email = "",
                        Title = "",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            }
                        }
                    }
                },
                FCFS = true,
                BA = false,
                notesGeneral = "Must call before 10 am",
                notesEquipment = "Dock closes at 4 pm",
                notesSpecialRequirements = "None"
            };
            var sam3 = new ClientData
            {
                ID = 3,
                customer = true,
                site = true,
                customerName = "Cagene Manufacturing",
                businessName = "Cagene Manufacturing",
                location = "Portland, Oregon",
                contacts = new List<Contact>
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
                                PhoneNumber = "7928416481",
                                NumberType = "Work",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "7921597582",
                                NumberType = "Cell",
                                Ext = ""
                            }
                        }
                    },
                    new Contact
                    {
                        FirstName = "Bill",
                        LastName = "Snyde",
                        Email = "bsnyde@cageneman.com",
                        Title = "Dock Supervisor",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = "5221348547",
                                NumberType = "Cell",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            }
                        }
                    },
                    new Contact
                    {
                        FirstName = "Joques",
                        LastName = "Coulliby",
                        Email = "jcoulliby@cageneman.com",
                        Title = "Asst Dock Supervisor",
                        PhoneNumbers = new List<PhoneContacts>
                        {
                            new PhoneContacts
                            {
                                PhoneNumber = "8176882248",
                                NumberType = "Cell",
                                Ext = ""
                            },
                            new PhoneContacts
                            {
                                PhoneNumber = "",
                                NumberType = "",
                                Ext = ""
                            }
                        }
                    }
                },
                FCFS = false,
                BA = true,
                notesGeneral = "Don't call on cell unless ABSOLUTELY NECESSARY",
                notesEquipment = "Dock opens at 10, closes at 6",
                notesSpecialRequirements = "They usually don't answer last two hours of the day"
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
