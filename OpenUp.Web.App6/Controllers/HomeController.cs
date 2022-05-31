using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OpenUp.EFCore.Autores;
using OpenUp.EFCore.Editoras;
using OpenUp.EFCore.Livros;
using OpenUp.Web.App6.Data;
using OpenUp.Web.App6.Models;

namespace OpenUp.Web.App6.Controllers;

public class HomeController : Controller
{

    ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db)
    {
        _db = db;
    }


    public IActionResult Index()
    {
        Autor autor = new(){ Nome = "Jorge", Apelido = "Cadete", Idade = 22};

        Editora editora = new() {Nome = "Total", Capital = 20000 };

        Livro livro = new() {Autor = autor, Editora = editora, Titulo = "Sombra de prazeres", DataPublicacao = DateTime.Today.AddDays(-120), Obs = "Best seller"};
        
        _db.Add(livro);

        _db.SaveChanges();

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
