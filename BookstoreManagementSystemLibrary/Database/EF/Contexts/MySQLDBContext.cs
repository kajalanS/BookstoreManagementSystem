using System.Data.Common;
using BookstoreManagementSystemLibrary.Database.Core;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace BookstoreManagementSystemLibrary.Database.EF.Contexts
{
    public class MySQLDBContext : BaseDbContext
    {
        private readonly string _connectionString;

        //public MySQLDBContext(DbContextOptions<MySQLDBContext> options, string connectionString) : base(options)
        //{
        //    _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        //}

        public MySQLDBContext(DbContextOptions<MySQLDBContext> options) : base(options)
        {
            // In production, consider getting the connection string from configuration.
            _connectionString = "server=localhost;database=BookstoreManagementSystem;user=root;password=password;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Create a MySqlConnection using the provided connection string.
                MySqlConnection dbConnection = new(_connectionString);


                // Use the MySQL provider with the established connection.
                optionsBuilder.UseMySQL(dbConnection);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
