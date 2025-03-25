using LojaVirtual.ProdutoApi.Models;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.ProdutoApi.DTOs
{
    public class CategoriaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Nome { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
    }
}
