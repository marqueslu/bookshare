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

        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(50, ErrorMessage = "Mínimo {0} caracteres")]
        public string Sinopse { get; set; }

        [Required(ErrorMessage = "Preencha o campo ISBN")]
        [DisplayName("ISBN")]
        [MaxLength(200, ErrorMessage ="Máximo de {0} caracters")]
        public String isbn { get; set; }

        //[ScaffoldColumn(false)]
        [Required(ErrorMessage = "Preencha o campo Ano de Lançamento")]
        [DisplayName("Ano de Lançamento")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido" )]
        public DateTime AnoLancamento { get; set; }
        [DisplayName("Nome do Autor")]
        public int AutorId { get; set; }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }

        [DisplayName("Editora")]
        public int EditoraId { get; set; }
        public virtual AutorViewModel Autor { get; set; }
        public virtual CategoriaViewModel Categoria { get; set; }
        public virtual EditoraViewModel Editora { get; set; }

    }
}