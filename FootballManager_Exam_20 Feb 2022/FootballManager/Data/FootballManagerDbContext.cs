﻿namespace FootballManager.Data
{
    using FootballManager.Data.Models;
    using Microsoft.EntityFrameworkCore;
    public class FootballManagerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfiguration.ConnectionString);
            }
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<UserPlayer> UserPlayers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPlayer>()
                .HasKey(x => new { x.UserId, x.PlayerId });
        }
    }
}
