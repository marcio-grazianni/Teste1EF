using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pratico.Models;

namespace pratico.Data.Mappings
{
    public class PaisMap : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("pais");

            builder.HasKey(x => x.Id)
                   .HasName("pk_pais_id");

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(60);

            builder.Property(x => x.Codigo)
                .IsRequired()
                .HasColumnName("codigo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);

            // builder.HasIndex(x => x.Codigo, "idx_pais_codigo")
            //     .IsUnique();
        }
    }
}