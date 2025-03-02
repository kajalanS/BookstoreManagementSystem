
using BookstoreManagementSystemLibrary.Database.Core;
using BookstoreManagementSystemLibrary.Database.EF.Contexts;
using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagementSystemLibrary.Database.EF
{
    public class EFDataConnector : IDataConnector
    {
        protected readonly BaseDbContext context;
        protected readonly string databaseName;
        protected readonly string connectionString;

        public EFDataConnector(EFConnectionType connectionType)
        {
            if (connectionType == EFConnectionType.MSql)
            {
                var optionsBuilder = new DbContextOptionsBuilder<SqlDBContext>();
                context = new SqlDBContext(optionsBuilder.Options);
            }
            else if (connectionType == EFConnectionType.Mysql)
            {
                var optionsBuilder = new DbContextOptionsBuilder<MySQLDBContext>();
                context = new MySQLDBContext(optionsBuilder.Options);
            }
            else
            {
                var optionsBuilder = new DbContextOptionsBuilder<MemoryDBContext>();
                context = new MemoryDBContext(optionsBuilder.Options);
            }
        }

        public EFDataConnector(string databaseName) : this(EFConnectionType.Memory)
        {
            this.databaseName = databaseName;
        }

        public EFDataConnector(string connectionString, EFConnectionType connectionType) : this(connectionType)
        {
            this.connectionString = connectionString;
        }

        public User CreateUser(User user)
        {
            user.UserID = context.Users.Count() + 1;
            context.Users.Add(user);
            return user;
        }
    }
}
