using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShare.MVC.Models
{
    public class CategoriaViewModel
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Nome da Categoria")]
        public string Nome { get; set; }
        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}