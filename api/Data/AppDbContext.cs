using api.models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<UsuarioModel> Usuarios { get; set; } // model espelho da tabela
        public DbSet<HotelModel> Hoteis { get; set; }
        public DbSet<ImagemModel> Imagens { get; set; }
        public DbSet<QuartoModel> Quartos { get; set; }
        public DbSet<ReservaModel> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=booking-bd;Username=postgres;Password=aquitem");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}