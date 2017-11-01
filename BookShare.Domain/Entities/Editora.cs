using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Entities
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Livro> Livros { get; set; }
    }
}
