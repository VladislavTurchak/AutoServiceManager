namespace AutoServiceManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.ThreadException += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine("ThreadException: " + e.Exception);
                MessageBox.Show(e.Exception.ToString(), "ThreadException");
            };
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine("UnhandledException: " + e.ExceptionObject);
            };

            Application.Run(new Form1());
        }
    }
}