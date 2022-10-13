using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Text.Json;

namespace BrokerBuddy
{
    internal class FileHandler
    {
        static string FileNameJSON = "ContactDatabase.json";

        static public void JSONFileCheck()
        {
            if (!File.Exists(FileNameJSON))
            {
                File.Create(FileNameJSON);
            }
        }

        static public List<ClientData> LoadContactsJSON()
        {
            string readInString = File.ReadAllText(FileNameJSON);
            List<ClientData> conts = JsonSerializer.Deserialize<List<ClientData>>(readInString);
            return conts;
        }

        static public void SaveContactsJSON(List<ClientData> conts)
        {
            string jsonString = JsonSerializer.Serialize(conts);
            File.WriteAllText(FileNameJSON, jsonString);
        }

        //public void saveContacts(List<Contact> contacts)
        //{
        //    using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + FileNameSQL + ";Version=3;"))
        //    {
        //        m_dbConnection.Open();
        //        SQLiteCommand cmd;
        //        cmd = m_dbConnection.CreateCommand();
        //        cmd.CommandText = "DELETE FROM Contacts";
        //        cmd.ExecuteNonQuery();
        //        foreach (Contact contact in contacts)
        //        {

        //            try
        //            {
        //                cmd.CommandText = $"INSERT INTO Contacts (FirstName, LastName, Number) VALUES ('{contact.FirstName}','{contact.LastName}',{contact.Number})";
        //                cmd.ExecuteNonQuery();
        //            }
        //            catch (Exception e)
        //            {
        //                Console.WriteLine(e);
        //            }

        //        }
        //        m_dbConnection.Close();
        //    }
        //}

        //public list<contact> loadcontacts()
        //{
        //    list<contact> contacts = new list<contact>();
        //    using (sqliteconnection m_dbconnection = new sqliteconnection("data source=" + filenamesql + ";version=3;"))
        //    {
        //        m_dbconnection.open();
        //        sqlitedatareader reader;
        //        sqlitecommand cmd;
        //        cmd = m_dbconnection.createcommand();
        //        cmd.commandtext = "select * from contacts";
        //        reader = cmd.executereader();
        //        while (reader.read())
        //        {
        //            long numreader = reader.getint64(2);
        //            string first = reader.getstring(0);
        //            string last = reader.getstring(1);
        //            contacts.add(new contact(first, last, numreader));
        //        }
        //        m_dbconnection.close();
        //    }


        //    return contacts;
        //}
    }
}

