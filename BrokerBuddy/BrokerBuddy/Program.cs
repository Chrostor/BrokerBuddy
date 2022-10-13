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
            FileHandler.JSONFileCheck();
            //TODO: Sample data for now.  Goal is to load from file
            var clientData = FileHandler.LoadContactsJSON();
            //var clientData = SampleData.createSamples();
            //FileHandler.SaveContactsJSON(clientData);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow(clientData));
        }
    }
}