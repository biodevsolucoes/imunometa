using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class PontoVacinacaoConfig : IEntityTypeConfiguration<PontoVacinacao>
    {
        public void Configure(EntityTypeBuilder<PontoVacinacao> builder)
        {
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.UF)
                .IsRequired()
                .HasColumnType("varchar(2)");
        }
    }
}
