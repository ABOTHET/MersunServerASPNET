using Microsoft.EntityFrameworkCore;

namespace MersunServer.Database
{
    public class AppDatabase : DbContext
    {
        public AppDatabase() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Mersun;Username=Mersunka;Password=DeNahui");
    }
}
