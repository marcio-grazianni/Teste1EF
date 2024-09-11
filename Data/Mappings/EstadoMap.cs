using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pratico.Models;

namespace pratico.Data.Mappings
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("estado");

            builder.HasKey(e => e.Id)
                   .HasName("estado_pkey");

            builder.Property(e => e.Id)
                   .HasColumnName("id")
                   .HasColumnType("BIGINT")
                   .ValueGeneratedOnAdd();

            builder.Property(e => e.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("VARCHAR(40)")
                   .IsRequired();

            builder.Property(e => e.Sigla)
                   .HasColumnName("sigla")
                   .HasColumnType("VARCHAR(2)")
                   .IsRequired();

            builder.Property(e => e.CodigoIbge)
                   .HasColumnName("codigo_ibge")
                   .HasColumnType("INTEGER");

            builder.Property(e => e.DataCadastro)
                   .HasColumnName("data_cadastro")
                   .HasColumnType("DATE")
                   .HasDefaultValueSql("now()")
                   .IsRequired();

            builder.Property(e => e.HoraCadastro)
                   .HasColumnName("hora_cadastro")
                   .HasColumnType("TIME WITHOUT TIME ZONE")
                   .HasDefaultValueSql("now()")
                   .IsRequired();

            builder.Property(e => e.PaisId)
                   .HasColumnName("pais_id")
                   .HasColumnType("BIGINT")
                   .IsRequired();

            // Relacionamento com a tabela Pais
            builder.HasOne(e => e.Pais)
                   .WithMany(p => p.Estados)
                   .HasForeignKey(e => e.PaisId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
