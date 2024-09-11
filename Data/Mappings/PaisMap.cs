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

                     builder.HasKey(p => p.Id)
                            .HasName("pk_pais_id");

                     builder.Property(p => p.Id)
                            .IsRequired()
                            .HasColumnName("id")
                            .HasColumnType("INTEGER")
                            .ValueGeneratedOnAdd();

                     builder.Property(p => p.Nome)
                            .IsRequired()
                            .HasColumnName("nome")
                            .HasColumnType("VARCHAR")
                            .HasMaxLength(60);

                     builder.Property(p => p.Codigo)
                            .IsRequired()
                            .HasColumnName("codigo")
                            .HasColumnType("VARCHAR")
                            .HasMaxLength(20);

                     // Relacionamento um-para-muitos com Estados
                     // Desnecessário, pois o relacionamento ja foi
                     // criado no mapeamento da tabela estado
                     // builder.HasMany(p => p.Estados)
                     //        .WithOne(e => e.Pais)
                     //        .HasForeignKey(e => e.PaisId)
                     //        .OnDelete(DeleteBehavior.NoAction);
              }
       }
}
