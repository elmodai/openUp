using System.Collections.ObjectModel;
using OpenUp.LibrarySys.Livros;

namespace OpenUp.LibrarySys.Autores
{
    public abstract class AAutor
    {
        public string ? Name { get; set; }

        public IEnumerable<ALivro> ? Livros { get; set; } = new HashSet<LivroBiografia>();

        public int Idade { get; set; }
    }
}