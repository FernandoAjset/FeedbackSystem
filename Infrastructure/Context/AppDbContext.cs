using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>().ToTable("Feedbacks");
            modelBuilder.Entity<Feedback>().HasKey(f => f.Id);
            modelBuilder.Entity<Feedback>().Property(f => f.Description).IsRequired().HasMaxLength(1000);
            modelBuilder.Entity<Feedback>().Property(f => f.Type).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
