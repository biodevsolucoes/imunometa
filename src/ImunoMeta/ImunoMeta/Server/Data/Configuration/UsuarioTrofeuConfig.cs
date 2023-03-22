using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class UsuarioTrofeuConfig : IEntityTypeConfiguration<UsuarioTrofeu>
    {
        public void Configure(EntityTypeBuilder<UsuarioTrofeu> builder)
        {
            builder.HasOne(x => x.Usuario);
            builder.HasOne(x => x.Trofeu);
        }
    }
}
