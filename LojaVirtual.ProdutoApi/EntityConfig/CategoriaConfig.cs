using LojaVirtual.ProdutoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaVirtual.ProdutoApi.EntityConfig
{
    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();

            builder.HasMany(c => c.Produtos)
                .WithOne(c => c.Categoria)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
             new Categoria{ Id = 1, Nome = "Material Escolar"},
             new Categoria{ Id = 2, Nome = "Acessórios" }
          
            );
        }
    }
}
