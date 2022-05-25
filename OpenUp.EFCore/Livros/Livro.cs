using System;
using OpenUp.EFCore.Autores;

namespace OpenUp.EFCore.Livros
{
    public class Livro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime DataPublicacao { get; set; }

        public int AutorID { get; set; }

        public Autor Autor { get; set; }
    }
}