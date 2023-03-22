using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class NoticiaConfig : IEntityTypeConfiguration<Noticia>
    {
        public void Configure(EntityTypeBuilder<Noticia> builder)
        {
            builder.Property(x => x.Titulo)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Resumo)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.Property(x => x.Texto)
                .IsRequired()
                .HasColumnType("varchar(max)");
        }
    }
}
