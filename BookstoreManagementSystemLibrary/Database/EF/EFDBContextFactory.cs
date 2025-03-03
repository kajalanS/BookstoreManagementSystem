using BookstoreManagementSystemLibrary.Database.EF.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookstoreManagementSystemLibrary.Database.EF
{
    public partial class EFDBContext
    {
        public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
        {
            public EFDBContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();

                // Set your connection string for design time
                string connString = "server=localhost;database=BookstoreManagementSystem;user=root;password=core2dueZ@123;Connection Timeout=60";

                // Choose the connection type you want (e.g., Mysql)
                var connectionType = EFConnectionType.Mysql;

                // Create an instance of your context with options
                var context = new EFDBContext(optionsBuilder.Options);

                context.SetConnectionType(connectionType);
                context.SetConnectionList(new Dictionary<EFConnectionType, string>
                {
                    {EFConnectionType.Mysql,connString }
                });

                return context;
            }
        }
    }
}