using Microsoft.EntityFrameworkCore;

namespace DAWA_Transacciones.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Cantante> Cantante{ get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Musica> Musica { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-AI06HEJ8;Database=MusicaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
