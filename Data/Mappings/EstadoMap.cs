using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pratico.Models;

namespace pratico.Data.Mappings
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("estado");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(40);

            builder.Property(x => x.Sigla)
                .IsRequired()
                .HasColumnName("sigla")
                .HasColumnType("VARCHAR")
                .HasMaxLength(2);

            builder.Property(x => x.CodigoIbge)
                .HasColumnName("codigo_ibge")
                .HasColumnType("INTEGER");

            // builder.Property(x => x.Pais)
            //     .IsRequired()
            //     .HasColumnName("pais_id")
            //     .HasColumnType("INTEGER");

            // builder.HasOne(x => x.Pais)
            //     .WithMany(x => x.Estados)
            //     .HasConstraintName("fk_estado_paisid")
            //     .OnDelete(DeleteBehavior.NoAction);

            // builder.Property(x => x.DataCadastro)
            //     .IsRequired()
            //     .HasColumnName("data_cadastro")
            //     .HasColumnType("DATE")
            //     .HasDefaultValueSql("CURRENT_DATE");

            // builder.Property(x => x.HoraCadastro)
            //     .IsRequired()
            //     .HasColumnName("hora_cadastro")
            //     .HasColumnType("TIME")
            //     .HasDefaultValueSql("CURRENT_TIME");

        }
    }
}