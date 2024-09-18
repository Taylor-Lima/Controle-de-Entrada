using Controle_Entrada.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Controle_Entrada.Data.Mapeamento
{
    public class VisitanteMapeamento : IEntityTypeConfiguration<Visitante>

    {

        public void Configure(EntityTypeBuilder<Visitante> builder)
        {
            builder.ToTable("Visitante");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(30)");
            builder.Property(t => t.Documento).HasColumnType("varchar(20)");
            builder.Property(t => t.Hora).HasColumnType("DateOnly");

        }
    }
}

//public class Visitante
//{
//    public int Id { get; set; }
//    public string Nome { get; set; }

//    public string Documento { get; set; }
//    public DateTime DataEntrada { get; set; }
//    public DateTime DataSaida { get; set; }
//    public int MoradorId { get; set; }
//    public Morador Morador { get; set; }
//}