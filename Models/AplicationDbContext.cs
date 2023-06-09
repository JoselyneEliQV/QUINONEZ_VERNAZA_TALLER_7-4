using Microsoft.EntityFrameworkCore;

namespace QUIÑONEZ_VERNAZA_TALLER_7_4.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<HistorialAcceso> HistorialAcceso { get; set; }

    }

}
