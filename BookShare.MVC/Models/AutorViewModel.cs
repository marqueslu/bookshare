using BookShare.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShare.MVC.Models
{
    public class AutorViewModel
    {
        [Key]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "Preencha O campo Nome do Autor:")]
        [DisplayName("Nome do Autor:")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
