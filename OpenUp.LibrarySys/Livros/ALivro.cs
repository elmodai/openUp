using System;
using OpenUp.LibrarySys.Autores;

namespace OpenUp.LibrarySys.Livros
{
    public abstract class ALivro
    {
        public string ? Titulo { get; set; }

        public IEnumerable<AAutor> ? Autors { get; set; }

        public int NumeroPaginas { get; set; }

        public DateTime DataPublicacao { get; set; }

        public decimal Preco { get; set; }

    }
}