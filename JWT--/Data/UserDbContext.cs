using JWT__.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT__.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                  .Property(x => x.Email)
                  .IsRequired()
                  .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(a => a.Password)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
