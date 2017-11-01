using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShare.MVC.Models
{
    public class EditoraViewModel
    {
        [Key]
        public int EditoraId { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Nome da Editora")]
        public string Nome { get; set; }
        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}