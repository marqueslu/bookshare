using System.Collections.Generic;

namespace BookShare.Domain.Entities
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
