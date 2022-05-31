using System;
using System.ComponentModel.DataAnnotations;
using OpenUp.EFCore.Autores;
using OpenUp.EFCore.Editoras;

namespace OpenUp.EFCore.Livros
{
    public class Livro
    {
        public int Id { get; set; }

        public string ? Titulo { get; set; }

        public DateTime DataPublicacao { get; set; }

        public int EditoraId { get; set; }

        public Editora ? Editora { get; set; }

        public int AutorId { get; set; }

        public Autor ? Autor { get; set; }

        public string ? Obs { get; set; }
    }
}