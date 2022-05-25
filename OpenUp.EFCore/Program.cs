using OpenUp.EFCore.Autores;
using OpenUp.EFCore.EFContext;
using OpenUp.EFCore.Livros;



LivroContext ctx = new();

ctx.Add(
    new Livro
    {
        Autor = new Autor
        {
            Nome = "Ele",
            WebUrl = "www.blogdele.com"            
        },

        Titulo = "Aquele livro"
    }
);

//ctx.SaveChanges();

Console.WriteLine($"{ctx.Livros.FirstOrDefault().Titulo}");