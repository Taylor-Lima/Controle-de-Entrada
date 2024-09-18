using Controle_Entrada.Data.Mapeamento;
using Controle_Entrada.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle_Entrada.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            //modelBuilder.ApplyConfiguration(new EntradaSaidaMapeamento());
            modelBuilder.ApplyConfiguration(new MoradorMapeamento());
            modelBuilder.ApplyConfiguration(new VisitanteMapeamento());
        }

        //public DbSet<EntradaSaida> EntradaSaida { get; set; }
        public DbSet<Morador> Morador { get; set; }
        public DbSet<Visitante> Visitante { get; set; }
    }
}

