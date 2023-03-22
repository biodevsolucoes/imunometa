using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class PontuacaoConfig : IEntityTypeConfiguration<Pontuacao>
    {
        public void Configure(EntityTypeBuilder<Pontuacao> builder)
        {
            builder.HasOne(x => x.Usuario);
            builder.HasOne(x => x.TipoPontuacao);
        }
    }
}
