using JsonTestAPI.Core.Entities;
using JsonTestAPI.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace JsonTestAPI.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<JsonDataTest1> JsonDataTest1 { get; set; }
        public DbSet<JsonDataTest2> JsonDataTest2 { get; set; }

        public DbSet<JsonDataTest2Query> JsonDataTest2Query { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new JsonDataTest1Configuration());
            modelBuilder.ApplyConfiguration(new JsonDataTest2Configuration());
            modelBuilder.ApplyConfiguration(new JsonDataTest2QueryConfiguration());
        }
    }
}

