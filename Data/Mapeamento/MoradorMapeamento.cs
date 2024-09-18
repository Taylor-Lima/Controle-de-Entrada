using Controle_Entrada.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Controle_Entrada.Data.Mapeamento
{
    public class MoradorMapeamento : IEntityTypeConfiguration<Morador>
    {
        public void Configure(EntityTypeBuilder<Morador> builder)
        {
            builder.ToTable("Morador");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(30)");
            builder.Property(t => t.Unidade).HasColumnType("varchar(20)");
            builder.Property(t => t.PlacaVeiculo).HasColumnType("varchar(7)");
            builder.Property(t => t.Telefone).HasColumnType("varchar(11)");
            builder.Property(t => t.Hora).HasColumnType("DateOnly");

        }
    }
}
//public class Morador
//{
//    public int Id { get; set; }
//    public string Nome { get; set; }
//    public string Unidade { get; set; }
//    public string PlacaVeiculo { get; set; }
//    public string Telefone { get; set; }
//}
//    }
