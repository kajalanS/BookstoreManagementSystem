using BookstoreManagementSystemLibrary.Database.Core;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagementSystemLibrary.Database.EF.Contexts
{
    public class MemoryDBContext : BaseDbContext
    {
        private readonly string _databaseName;

        //// Constructor that accepts a database name for the in-memory store.
        //public MemoryDBContext(DbContextOptions<MemoryDBContext> options, string databaseName) : base(options)
        //{
        //    _databaseName = databaseName;
        //}

        // Parameterless constructor that uses a default database name.
        public MemoryDBContext(DbContextOptions<MemoryDBContext> options) : base(options)
        {
            _databaseName = "MemoryBookstoreManagementSystem";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase(_databaseName);
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
