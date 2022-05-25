// See https://aka.ms/new-console-template for more information

using OpenUp.LibrarySys.Autores;
using OpenUp.LibrarySys.Livros;

var bdLivros = new List<ALivro>();

var bdAutoresBiografia = new HashSet<AutorBiografia>();

var livroPoesia = new LivroPoesia()
{
    Titulo = "Esta Sopa da Maria Jacinta",
    Autors = new List<AutorPoesia>()
    {
        new AutorPoesia()
        {
            Name = "Lunay",

            Idade = 59

        }
    },

    Preco = 11
};

var livroPoesia3 = new LivroPoesia()
{
    Titulo = "A Caldeirada da Kethlin",
    Autors = new List<AutorPoesia>()
    {
        new AutorPoesia()
        {
            Name = "Maria",

            Idade = 34

        }
    },

    Preco = 13
};

var livroFixao = new LivroFixao()
{
    Titulo = "As Aventuras do Diogo Sousa",
    Autors = new List<AAutor>()
    {
        new AutorPoesia()
        {
            Name = "Gércia",

            Idade = 29
        }
    },

    Preco = 8,

    NumeroPaginas = 10,

};

var livroFixao2 = new LivroFixao()
{
    Titulo = "As Aventuras do Diogo Sousa 2",
    Autors = new List<AAutor>()
    {
        new AutorPoesia()
        {
            Name = "Diogo",

            Idade = 21
        }
    },

    Preco = 8,

    NumeroPaginas = 10,

};



bdLivros.Add(livroPoesia);

bdLivros.Add(livroPoesia3);

bdLivros.Add(livroFixao);

bdLivros.Add(livroFixao2);


// Console.WriteLine("-----------------LISTA DE LIVROS CUJO AUTORES SAO MAIORES DE 29-------------------------");
// Console.WriteLine("TITULO | NOME |IDADE DO AUTOR");

IEnumerable<LivroPoesia> somenteLivrosPoesia = new List<LivroPoesia>();

foreach (var l in bdLivros)
{
    var s = l is LivroPoesia;
    //     INSERIR LIVROS NA LISTA somenteLivrosPoesia QUE SAO DO TIPO LivroPoesia 
    //     USANDO O METODO WHERE DA COLLECTION
}

//SGBD: Relacional e Documentada (NoSQL)



string[] names = new[] { "João", "Kethlin", "Gércia", "Tobias",
  "Angela", "Maria", "Lunay", "Diogo" };

var query = names
  .Where(name => name.Length > 4)
  .OrderBy(name => name.Length)
   .Take(4);

foreach (var item in query)
{
    Console.WriteLine($"{item}");
}
