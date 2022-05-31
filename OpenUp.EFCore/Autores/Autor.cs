using System.ComponentModel.DataAnnotations;
using OpenUp.EFCore.Livros;

namespace OpenUp.EFCore.Autores
{
    public class Autor
    {
        public int Id { get; set; }

        public int Idade { get; set; }

        public string ?  Nome { get; set; }

        public string ? Apelido { get; set; }
        public string ? Email { get; set; }

        public IEnumerable<Livro> ? Livros { get; set; }
    }
}