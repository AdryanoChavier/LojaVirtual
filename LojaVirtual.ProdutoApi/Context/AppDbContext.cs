using LojaVirtual.ProdutoApi.EntityConfig;
using LojaVirtual.ProdutoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.ProdutoApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.ApplyConfiguration(new CategoriaConfig());
        mb.ApplyConfiguration(new ProdutoConfig());
    }

}
