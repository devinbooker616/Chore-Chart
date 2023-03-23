using BaseCamp.Chores.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseCamp.Chores.Infrastructure.Context
{
    public class ChoreDbContext : DbContext
    {
        public ChoreDbContext(DbContextOptions<ChoreDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Chore> Chore { get; set; }
        public virtual DbSet<AssignedChore> AssignedChore { get; set; }
        public virtual DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase(databaseName: "ChoreDb");

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:sql-msbs-llc-dev.database.windows.net,1433;Initial Catalog=basecamp2023;Persist Security Info=False;User ID=BaseCampers;Password=Campers!2023!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
