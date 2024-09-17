using Controle_Entrada.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Controle_Entrada.Data.Mapeamento
{
    public class EntradaSaidaMapeamento : IEntityTypeConfiguration<EntradaSaida>
    {
        
            public void Configure(EntityTypeBuilder<EntradaSaida> builder)
            {
                builder.ToTable("EntradaSaida");

                builder.HasKey(t => t.Id);

                builder.Property(t => t.VisitanteId).HasColumnType("varchar(30)");
                //builder.Property(t => t.Visitante).HasColumnType("varchar(20)");
                builder.Property(t => t.DataEntrada).HasColumnType("DateTime");
                builder.Property(t => t.DataSaida).HasColumnType("DateTime");

            }
        }
    }

//public class EntradaSaida
//{
//    public int Id { get; set; }
//    public int VisitanteId { get; set; }
//    public Visitante Visitante { get; set; }

//    public DateTime DataEntrada { get; set; }
//    public DateTime? DataSaida { get; set; } // Pode ser nulo até que a saída seja registrada
//}

//}

