using Controle_Entrada.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Controle_Entrada.Data.Mapeamento
{
    public class LoginMapeamento : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.ToTable("Login");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Usuario).HasColumnType("varchar(15)");
            builder.Property(t => t.Senha).HasColumnType("varchar(15)");
        }
    }
}
