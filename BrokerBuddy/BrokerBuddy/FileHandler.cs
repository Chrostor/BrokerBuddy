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
    }
}

