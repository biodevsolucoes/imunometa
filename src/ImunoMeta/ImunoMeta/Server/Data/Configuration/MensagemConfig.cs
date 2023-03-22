using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class MensagemConfig : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.Property(x => x.Texto)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.HasOne(x => x.Usuario);

            builder.HasOne(x => x.UsuarioDestino);
        }
    }
}
