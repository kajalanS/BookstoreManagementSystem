using System;
using System.Data.Common;
using BookstoreManagementSystemLibrary.Database.Core;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookstoreManagementSystemLibrary.Database.EF.Contexts
{
    public class SqlDBContext : BaseDbContext
    {
        private readonly string _connectionString;

        //public SqlDBContext(DbContextOptions<SqlDBContext> options, string connectionString) : base(options)
        //{
        //    _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        //}

        public SqlDBContext(DbContextOptions<SqlDBContext> options) : base(options)
        {
            // In production, consider getting the connection string from configuration.
            // Using Windows Authentication, so no username or password is required.
            _connectionString = "Server=localhost;Database=BookstoreManagementSystem;Trusted_Connection=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Create a SqlConnector using the provided connection string.
                SqlConnection dbConnection = new SqlConnection(_connectionString);

                // Use the SQL Server provider with the established connection.
                optionsBuilder.UseSqlServer(dbConnection);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
