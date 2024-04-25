using EstudioAnime.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;

namespace EstudioAnime.Persistencia
{


    public class OracleFIAPDbContext : DbContext
    {
        public DbSet<Animadores> Animadores { get; set; }
        public DbSet<Animes> Animes { get; set; }

        public DbSet<EstudioAnime.Models.Diretores> Diretores { get; set; } = default!;

        public DbSet<EstudioAnime.Models.Estudios> Estudios { get; set; } = default!;

        public DbSet<EstudioAnime.Models.Funcionarios> Funcionarios { get; set; } = default!;

        public OracleFIAPDbContext(DbContextOptions<OracleFIAPDbContext> options) : base(options)
        {

        }

    }

}