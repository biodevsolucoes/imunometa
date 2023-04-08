using BFBlog.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BFBlog.Data.Config
{
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Titulo)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Resumo)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(x => x.Texto)
                .IsRequired()
                .HasColumnType("text");

            builder.Property(x => x.ImagemCapaUrl)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(x => x.DataPublicacao)
                .IsRequired(true)
                .HasColumnType("datetime2")
                .HasDefaultValue("getdate()");
        }
    }
}
