using OpenUp.EFCore.Autores;
using OpenUp.EFCore.Editoras;
using OpenUp.EFCore.EFContext;
using OpenUp.EFCore.Livros;

// LivroContext ctx = new();

// Autor autor1 = new() { Nome = "Eça", Apelido = "Queirós", WebUrl = "www.ecaqueiros.com"};


// Autor autor2 = new() { Nome = "Cristiano", Apelido = "Ronaldo", WebUrl = "www.ronaldo.com"};

// Editora editora1 = new Editora() { Nome = "Porto Ediotra", Capital = 10000 };

// Editora editora2 = new Editora() { Nome = "Lisboa Ediotra", Capital = 20000 };

// Editora editora3 = new Editora() { Nome = "Lisboa de Braga", Capital = 30000 };



// ctx.AddRange(editora1, editora2, editora3, autor2, autor1);

Autor autor3 = new() { Idade = 16, Nome = "Maria", Apelido = "José", Email = "www.ecaqueiros.com"};

// ctx.Add(autor3);
// ctx.SaveChanges();
Console.WriteLine($"Autors gravados");


// var editora = ctx.Editoras.Where(x => x.Capital < 20000).FirstOrDefault();

// var autor = ctx.Autors.FirstOrDefault();

// Livro livro1 = new Livro() { Titulo = "O SQLServer", Autor = autor, Editora = editora  };

// ctx.AddRange(livro1);


// ctx.SaveChanges();
// Console.WriteLine($"Livro: {livro1.Titulo} foi gravado");



// Console.WriteLine($"----LISTA DE AUTORES | {ctx.Autors.Count()}");
// foreach (var item in ctx.Autors)
// {
//     Console.WriteLine($"{item.Apelido}, {item.Nome}");

//     Console.WriteLine($"----LISTA DE LIVROS DE {item.Apelido} | {item.Livros.Count()}");

//     foreach (var l in item.Livros)
//     {
//         Console.WriteLine($"{l.Titulo}");
//     }
// }

// Console.WriteLine($"----LISTA DE LIVROS | {ctx.Livros.Count()}");
// foreach (var item in ctx.Livros)
// {
//     Console.WriteLine($"{item.Titulo}, {item.DataPublicacao}");    
// }
// Console.WriteLine($"----LISTA DE EDITORAS | {ctx.Editoras.Count()}");
// foreach (var item in ctx.Editoras)
// {
//     Console.WriteLine($"{item.Nome}, {item.Capital}");

//     Console.WriteLine($"----LISTA DE LIVROS DE {item.Nome} | {item.Livros.Count()}");

//     foreach (var l in item.Livros)
//     {
//         Console.WriteLine($"{l.Titulo}");
//     }

// }

