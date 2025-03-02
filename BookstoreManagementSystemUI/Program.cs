using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using System.Configuration;

namespace BookstoreManagementSystemUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // init the app settings
            System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;

            // init the database 
            GlobalConfig.InitilizeConnection([EFConnectionType.Memory]);


            Application.Run(new Form1(appSettings));
        }
    }
}