using ImunoMeta.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImunoMeta.Server.Data.Configuration
{
    public class TrofeuConfig : IEntityTypeConfiguration<Trofeu>
    {
        public void Configure(EntityTypeBuilder<Trofeu> builder)
        {
            builder.Property(x => x.ImagemUrl)
                .IsRequired()
                .HasColumnType("varchar(500)");
        }
    }
}
