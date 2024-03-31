using EFCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class HeroiContext: DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas{ get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Treinamentos\\Udemy\\EFCore\\EFCore\\EFCore.Data\\DataBase\\HeroiDb.mdf;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
        }



    }
}
