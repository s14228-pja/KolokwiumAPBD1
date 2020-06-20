using Microsoft.EntityFrameworkCore;
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

        public KolokwiumDBContext() { }

        public KolokwiumDBContext(DbContextOptions options)
        : base(options){ 
        
        }
    }
}
