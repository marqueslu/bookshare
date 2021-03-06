﻿using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Interfaces
{
    public interface ILivroRepository : IRepositoryBase<Livro>
    {
        IEnumerable<Livro> GetByName(string nome);
        IEnumerable<Livro> LivroPorAutor(Autor autor);
    }
}
