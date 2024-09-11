using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pratico.Models;

namespace pratico.Data.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PaisMap : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("pais");

            builder.HasKey(p => p.Id)
                   .HasName("pk_pais_id");

            builder.Property(p => p.Id)
                   .HasColumnName("id")
                   .ValueGeneratedOnAdd();

            builder.Property(p => p.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("VARCHAR(60)")
                   .IsRequired();

            builder.Property(p => p.Codigo)
                   .HasColumnName("codigo")
                   .HasColumnType("VARCHAR(20)")
                   .IsRequired();

            // Relacionamento um-para-muitos com Estados
            builder.HasMany(p => p.Estados)
                   .WithOne(e => e.Pais)
                   .HasForeignKey(e => e.PaisId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
