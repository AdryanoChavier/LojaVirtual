using LojaVirtual.ProdutoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaVirtual.ProdutoApi.EntityConfig
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(255).IsRequired();
            builder.Property(x => x.ImagemURL).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Preco).HasPrecision(12, 2).IsRequired();

        }
    }
}
