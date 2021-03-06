﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Model
{
    public class KolokwiumDBContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Champoionship> Champoionship { get; set; }
        public DbSet<Player_Team> Player_Team { get; set; }
        public DbSet<Champiosnship_Team> Champiosnship_Team { get; set; }

        public KolokwiumDBContext() { }

        public KolokwiumDBContext(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Champiosnship_Team>()
                         .HasKey(e => new { e.IdChampiosnship, e.IdTeam });
            modelBuilder.Entity<Player_Team>()
             .HasKey(e => new { e.IdPlayer, e.IdTeam });
        }
    }
}
