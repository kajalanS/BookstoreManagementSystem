using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagementSystemLibrary.Database.EF
{
    public class EFDBContext : DbContext
    {
        #region Property

        protected string connectionString = "";
        protected string databaseName = "BookstoreManagementSystem";
        protected EFConnectionType connectionType;

        #endregion

        #region Core

        public EFDBContext() : base()
        {
            SetConnectionType(EFConnectionType.Mysql);
        }
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {
            SetConnectionType(EFConnectionType.Mysql);
        }

        public void SetConnectionType(EFConnectionType connectionType)
        {
            this.connectionType = connectionType;
        }
        public void SetConnectionList(Dictionary<EFConnectionType, string> connectionStringList)
        {
            if (connectionStringList.TryGetValue(connectionType, out var connection))
            {
                connectionString = connection;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (connectionType == EFConnectionType.Mysql)
                {
                    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                }
                else if (connectionType == EFConnectionType.MSql)
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
                else if (connectionType == EFConnectionType.Memory)
                {
                    optionsBuilder.UseInMemoryDatabase(databaseName);
                }
            }
            base.OnConfiguring(optionsBuilder);
        }


        #endregion

        #region Models

        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<User> Users { get; set; }


        #endregion
    }
}