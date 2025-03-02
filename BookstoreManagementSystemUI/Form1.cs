using System;
using System.Configuration;
using BookstoreManagementSystemLibrary.Helpers;
using System.Windows.Forms;

namespace BookstoreManagementSystemUI
{
    public partial class Form1 : Form
    {
        // Declare a field to hold the salt value.
        private readonly string salt;

        public Form1(System.Collections.Specialized.NameValueCollection appSettings)
        {
            salt = appSettings["HashSalt"] ?? throw new ArgumentNullException("HashSalt", "The HashSalt configuration is missing.");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Example usage with the HashHelper class.
            string password = "UserPassword";
            string hashedPassword = HashHelper.GetHash(password, salt);

            bool isMatch = HashHelper.CompareHash("UserPassword", hashedPassword, salt);
            Console.WriteLine(isMatch ? "Password is correct!" : "Password is incorrect!");
        }
    }
}
