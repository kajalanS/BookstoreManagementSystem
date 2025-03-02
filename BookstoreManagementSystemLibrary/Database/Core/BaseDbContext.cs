using BookstoreManagementSystemLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace BookstoreManagementSystemLibrary.Database.Core
{
    public abstract class BaseDbContext : DbContext
    {
        protected BaseDbContext() { }

        protected BaseDbContext(DbContextOptions options) : base(options) { }

        // Common DbSets used across multiple contexts
        // For Example:
        public DbSet<User> Users { get; set; }


        //// You can also centralize common model configurations here.
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // For example:
        //    // modelBuilder.Entity<Book>().HasKey(b => b.Id);
        //}
    }
}
