using Microsoft.EntityFrameworkCore;
using pratico.Models;

namespace pratico.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("Host=127.0.0.1;Port=5439;Database=praticonfe;Username=postgres;Password=Mpvpr@8@8282@1@RCPNMGPOVP");
        }
    }
}