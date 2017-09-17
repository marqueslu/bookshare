using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShare.MVC.Models
{
    public class LivroViewModel
    {
        [Key]
        public int LivroId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Título")]
        [MaxLength(100, ErrorMessage = "Máximo{0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo{0} caracteres")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [MaxLength(500, ErrorMessage = "Máximo{0} caracteres")]
        [MinLength(50, ErrorMessage = "Mínimo{0} caracteres")]
        public string Sinopse { get; set; }
        [DisplayName("Disponível?")]
        public bool Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [DisplayName("Nome do Autor")]
        public int AutorId { get; set; }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }

        public virtual AutorViewModel Autor { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
    }
}