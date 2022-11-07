namespace BrokerBuddy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            List<ClientData> clientData = new List<ClientData>();
            FileHandler.JSONFileCheck();
            //TODO: Sample data for now.  Goal is to load from file
            try
            {
                clientData = FileHandler.LoadContactsJSON();
            }
            catch (System.Text.Json.JsonException e) 
            {
                
            }
            
            clientData.Sort((x, y) => x.ID.CompareTo(y.ID));
            //clientData.AddRange(SampleData.createSamples());
            //FileHandler.SaveContactsJSON(clientData);
            //var clientData = SampleData.createSamples();
            //FileHandler.SaveContactsJSON(clientData);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow(clientData));
        }
    }
}