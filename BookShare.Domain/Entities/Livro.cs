using System;
using System.Collections.Generic;

namespace BookShare.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public string SituacaoConserva { get; set; }
        public DateTime DataCadastro { get; set; }
        public int AutorId{ get; set; }
        public int CategoriaId { get; set; }
        public int EditoraId { get; set; }
        public virtual Autor Autor { get; set;}
        public virtual Categoria Categoria { get; set;}
        public virtual Editora Editora { get; set; }
    }
}
