using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using MaterialSkin;
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

            ConnectionSetup();

            ThemeSetup();

            Application.Run(new frm_login());
        }

        private static void ThemeSetup()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            ColorScheme colorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            materialSkinManager.ColorScheme = colorScheme;
        }

        private static void ConnectionSetup()
        {
            // init the settings
            string mysqlConn = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            string sqlConn = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
            string salt = ConfigurationManager.AppSettings["HashSalt"] ?? "WRlNzJmYmU3MDh";

            var connectionStringList = new Dictionary<EFConnectionType, string>
            {
                { EFConnectionType.Mysql, mysqlConn },
                { EFConnectionType.MSql, sqlConn }
            };

            // init the database 
            GlobalConfig.InitilizeConnection([EFConnectionType.Mysql], connectionStringList, salt);
        }
    }
}