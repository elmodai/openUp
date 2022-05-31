using OpenUp.EFCore.Livros;

namespace OpenUp.EFCore.Editoras
{
    //PARA Gércia ver...
    public class Editora
    {
        public int Id { get; set; }

        public string ? Nome { get; set; }

        public decimal Capital { get; set; }

        public IEnumerable<Livro> ? Livros { get; set; }
    }
}