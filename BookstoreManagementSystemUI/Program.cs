using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.EF;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using MaterialSkin;
using Microsoft.Identity.Client.NativeInterop;
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

            Application.Run(new frmLogin());
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

            // SeederBuild
            //GlobalConfig.Process((process, salt) =>
            //{
            //    var adminUser = new BookstoreManagementSystemLibrary.Models.User
            //    {
            //        UserId = 1,
            //        Email = "info.ksoftm@gmail.com",
            //        PasswordHash = "J8ZhtRzGgmjE0Owwm06aMWt/uV0HYDmUSqED6n1Yk5Y=",
            //        Username = "admin",
            //        Role = BookstoreManagementSystemLibrary.Database.Core.Enum.UserRole.Admin,
            //        Status = BookstoreManagementSystemLibrary.Database.Core.Enum.UserStatus.Active,
            //    };
            //    process.CreateUser(adminUser);
            //});
        }
    }
}