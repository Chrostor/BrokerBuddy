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
            FileHandler.SQLFileCheck();
            //TODO: Sample data for now.  Goal is to load from file
            var sampleData = SampleData.createSamples();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow(sampleData));
        }
    }
}