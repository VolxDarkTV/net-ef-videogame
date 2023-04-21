using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    internal class VideogameContext : DbContext
    {
        public DbSet<VideoGame> VideoGame { get; set; }
        public DbSet<Software_house> Software_House { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=VideoGameNetwork5;Integrated Security=True; TrustServerCertificate=True");
        }
    }

}
