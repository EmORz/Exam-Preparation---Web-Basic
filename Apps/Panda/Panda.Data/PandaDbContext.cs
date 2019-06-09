using Microsoft.EntityFrameworkCore;
using Panda.Models;

namespace Panda.Data
{
    public class PandaDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        public DbSet<Package> Packages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabaseConfiguration.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .HasKey(user => user.Id);

            //modelBuilder.Entity<Track>()
            //    .HasKey(track => track.Id);

            //modelBuilder.Entity<Album>()
            //    .HasKey(album => album.Id);
            //modelBuilder.Entity<Album>()
            //    .HasMany(album => album.Tracks);

            base.OnModelCreating(modelBuilder);
        }
    }
}
