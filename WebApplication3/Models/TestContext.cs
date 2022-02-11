using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().OwnsOne(m => m.Contact);
        }
    }
}
