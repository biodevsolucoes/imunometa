using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class UsuarioVacinaConfig : IEntityTypeConfiguration<UsuarioVacina>
    {
        public void Configure(EntityTypeBuilder<UsuarioVacina> builder)
        {
            builder.HasOne(x => x.Usuario);
            builder.HasOne(x => x.Vacina);
        }
    }
}
