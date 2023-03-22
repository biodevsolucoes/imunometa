using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class TipoPontuacaoConfig : IEntityTypeConfiguration<TipoPontuacao>
    {
        public void Configure(EntityTypeBuilder<TipoPontuacao> builder)
        {
            builder.Property(x => x.Valor)
                .IsRequired()
                .HasColumnType("smallint");
        }
    }
}
