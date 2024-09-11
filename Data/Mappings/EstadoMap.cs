using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pratico.Models;

namespace pratico.Data.Mappings
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("estado");

            builder.HasKey(e => e.Id)
                   .HasName("pk_estado_id");

            builder.Property(e => e.Id)
                   .IsRequired()
                   .HasColumnName("id")
                   .HasColumnType("BIGINT")
                   .ValueGeneratedOnAdd();

            builder.Property(e => e.Nome)
                   .IsRequired()
                   .HasColumnName("nome")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(40);

            builder.Property(e => e.Sigla)
                   .IsRequired()
                   .HasColumnName("sigla")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(2);

            builder.Property(e => e.CodigoIbge)
                   .IsRequired(false)
                   .HasColumnName("codigo_ibge")
                   .HasColumnType("INTEGER");

            builder.Property(e => e.DataCadastro)
                   .IsRequired()
                   .HasColumnName("data_cadastro")
                   .HasColumnType("DATE")
                   .HasDefaultValueSql("now()");

            builder.Property(e => e.HoraCadastro)
                   .IsRequired()
                   .HasColumnName("hora_cadastro")
                   .HasColumnType("TIME WITHOUT TIME ZONE")
                   .HasDefaultValueSql("now()");

            builder.Property(e => e.PaisId)
                   .IsRequired()
                   .HasColumnName("pais_id")
                   .HasColumnType("BIGINT");

            // Relacionamento com a tabela País
            builder.HasOne(e => e.Pais)
                   .WithMany()
                   .HasForeignKey(e => e.PaisId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
