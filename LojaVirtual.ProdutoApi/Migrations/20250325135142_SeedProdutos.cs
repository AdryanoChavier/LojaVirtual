using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaVirtual.ProdutoApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produto(Nome, Preco, Descricao, Estoque, ImagemUrl, CategoriaId)" +
                "Values('Caderno',7.55,'Caderno',10,'caderno1.jpg',1)");
            mb.Sql("Insert into Produto(Nome, Preco, Descricao, Estoque, ImagemUrl, CategoriaId)" +
                "Values('Lápis',3.45,'Lápis Preto',20,'lapis.jpg',1)");
            mb.Sql("Insert into Produto(Nome, Preco, Descricao, Estoque, ImagemUrl, CategoriaId)" +
                "Values('Clips',5.33,'Clips para papel',50,'clips1.jpg',2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Produto");
        }
    }
}
