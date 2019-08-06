using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salvo1.Models
{
    public partial class MinHubContext : DbContext
    {
        public virtual DbSet<Player> Player { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("player");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
        public MinHubContext()
        { }
        public MinHubContext(DbContextOptions<MinHubContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=Ecotech-PC\\SQLEXPRESS;Database=MinHub;Trusted_Connection=True;");
            }
        }
    }
}
