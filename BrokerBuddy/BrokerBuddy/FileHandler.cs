using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BrokerBuddy
{
    internal class FileHandler
    {
        static string FileNameSQL = "ContactDatabase.sqlite";

        static public void SQLFileCheck()
        {
            if (!File.Exists(FileNameSQL))
            {
                SQLiteConnection.CreateFile(FileNameSQL);
                //using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + FileNameSQL + ";Version=3;"))
                //{
                //    conn.Open();
                //    SQLiteCommand cmd = conn.CreateCommand();
                //    cmd.CommandText = "CREATE TABLE Contacts (FirstName TEXT, LastName TEXT, Number INTEGER)";
                //    cmd.ExecuteNonQuery();
                //    conn.Close();
                //}

            }
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

        //public List<Contact> loadContacts()
        //{
        //    List<Contact> contacts = new List<Contact>();
        //    using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + FileNameSQL + ";Version=3;"))
        //    {
        //        m_dbConnection.Open();
        //        SQLiteDataReader reader;
        //        SQLiteCommand cmd;
        //        cmd = m_dbConnection.CreateCommand();
        //        cmd.CommandText = "SELECT * FROM Contacts";
        //        reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            long numReader = reader.GetInt64(2);
        //            string first = reader.GetString(0);
        //            string last = reader.GetString(1);
        //            contacts.Add(new Contact(first, last, numReader));
        //        }
        //        m_dbConnection.Close();
        //    }
        //    //SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + FileNameSQL + ";Version=3;");

        //    return contacts;
        //}
    }
}

