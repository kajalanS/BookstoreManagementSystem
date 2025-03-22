using BookstoreManagementSystemLibrary.Database.EF.Enum;
using BookstoreManagementSystemLibrary.Helpers;
using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BookstoreManagementSystemLibrary.Database.EF
{
  public partial class EFDBContext : DbContext
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
          var serverVersion = new MySqlServerVersion(new Version(8, 0, 41));
          Console.WriteLine(serverVersion.ToString());
          Console.WriteLine(connectionString);
          Console.WriteLine(connectionType);
          optionsBuilder.UseMySql(connectionString, serverVersion);
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Book>()
          .HasOne(b => b.Category)
          .WithMany(c => c.Books)
          .HasForeignKey(b => b.CategoryId)
          .OnDelete(DeleteBehavior.Restrict);

      modelBuilder.Entity<Order>()
          .HasOne(o => o.Customer)
          .WithMany(c => c.Orders)
          .HasForeignKey(o => o.CustomerId);

      modelBuilder.Entity<User>()
         .HasMany(u => u.Orders)
         .WithOne(o => o.User)
         .HasForeignKey(o => o.UserId);

      modelBuilder.Entity<OrderDetail>()
          .HasOne(od => od.Order)
          .WithMany(o => o.OrderDetails)
          .HasForeignKey(od => od.OrderId);

      modelBuilder.Entity<OrderDetail>()
          .HasOne(od => od.Book)
          .WithMany(b => b.OrderDetails)
          .HasForeignKey(od => od.BookId);

      modelBuilder.Entity<Receipt>()
          .HasOne(r => r.Order)
          .WithOne(o => o.Receipt)
          .HasForeignKey<Receipt>(r => r.OrderId);

      base.OnModelCreating(modelBuilder);
    }

    #endregion

    #region Models

    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Receipt> Receipts { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<SystemSetting> SystemSettings { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }


    #endregion
  }
}
