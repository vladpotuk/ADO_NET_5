using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GameDbContext
{
    public class GameContext : DbContext
    {
        public DbSet<GameLibrary.Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GameDatabase;Trusted_Connection=True;");
        }
    }
}
