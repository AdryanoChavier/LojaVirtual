using LojaVirtual.ProdutoApi.Models;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.ProdutoApi.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(200)]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O estoque é obrigatório")]
        [Range(1,9999)]
        public long Estoque { get; set; }

        public string? ImagemURL { get; set; }

        public Categoria? Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
