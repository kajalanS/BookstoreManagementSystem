using BookstoreManagementSystemLibrary;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Services;
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

            MailConfigAsync();

            Application.Run(new frmLogin());
        }

        private static void MailConfigAsync()
        {
            string clientId = ConfigurationManager.AppSettings["ClientId"]!;
            string clientSecret = ConfigurationManager.AppSettings["ClientSecret"]!;
            string userEmail = ConfigurationManager.AppSettings["UserEmail"]!;
            string refreshToken = ConfigurationManager.AppSettings["RefreshToken"]!;

            if (clientId != null && clientSecret != null && userEmail != null)
            {
                GmailService.Initialize(clientId, clientSecret, userEmail, refreshToken);
            }


            ////  emailTest
            //GlobalConfig.Process((process, salt) =>
            //{
            //    process.ResetPasswordAsync("info.ksoftm@gmail.com");
            //});
        }

        private static void ThemeSetup()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //ColorScheme colorScheme = new ColorScheme(
            //    Primary.Orange800,
            //    Primary.Orange900,
            //    Primary.Orange500,
            //    Accent.Orange200,
            //    TextShade.WHITE
            //);
            //ColorScheme colorScheme = new ColorScheme(
            //    Primary.Blue800,
            //    Primary.Blue900,
            //    Primary.Blue500,
            //    Accent.Red200,
            //    TextShade.WHITE
            //);
            //ColorScheme colorScheme = new ColorScheme(
            //    Primary.Red800,
            //    Primary.Red900,
            //    Primary.Red500,
            //    Accent.Red200,
            //    TextShade.WHITE
            //);

            //ColorScheme colorScheme = new ColorScheme(
            //    Primary.BlueGrey800,
            //    Primary.BlueGrey900,
            //    Primary.BlueGrey500,
            //    Accent.LightBlue200,
            //    TextShade.WHITE
            //);

            //ColorScheme colorScheme = new ColorScheme(
            //    Primary.DeepPurple800,
            //    Primary.DeepPurple900,
            //    Primary.DeepPurple500,
            //    Accent.Amber200,
            //    TextShade.WHITE
            //);

            ColorScheme colorScheme = new ColorScheme(
                Primary.Blue900,
                Primary.Blue800,
                Primary.Blue500,
                Accent.LightBlue700,
                TextShade.WHITE
            );

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

            ////SeederBuild
            //GlobalConfig.Process((process, salt) =>
            //{
            //    //var adminUser = new BookstoreManagementSystemLibrary.Models.User
            //    //{
            //    //    UserId = 1,
            //    //    Email = "info.ksoftm@gmail.com",
            //    //    PasswordHash = "J8ZhtRzGgmjE0Owwm06aMWt/uV0HYDmUSqED6n1Yk5Y=", //password
            //    //    Username = "admin",
            //    //    Role = BookstoreManagementSystemLibrary.Database.Core.Enum.UserRole.Admin,
            //    //    Status = BookstoreManagementSystemLibrary.Database.Core.Enum.UserStatus.Active,
            //    //};
            //    //process.CreateUser(adminUser);

            //    //process.ResetPassword("info.ksoftm@gmail.com");
            //});
        }
    }
}