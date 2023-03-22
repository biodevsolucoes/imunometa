using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class DenunciaConfig : IEntityTypeConfiguration<Denuncia>
    {
        public void Configure(EntityTypeBuilder<Denuncia> builder)
        {
            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(x => x.UrlDenunciada)
                .IsRequired(false)
                .HasColumnType("varchar(500)");

            builder.HasOne(x => x.Usuario);
        }
    }
}
