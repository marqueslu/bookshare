using System.Collections.Generic;

namespace BookShare.Domain.Entities
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        //public int LivroId { get; set; }
        //public virtual Livro Livro { get; set; }
        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
