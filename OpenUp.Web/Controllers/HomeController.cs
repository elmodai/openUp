using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OpenUp.EFCore.Autores;
using OpenUp.EFCore.Livros;
using OpenUp.Web.Models;
using OpenUp.Web.EFContext;

namespace OpenUp.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly LivroContext _db;

    public HomeController(ILogger<HomeController> logger, LivroContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        Autor autor = new(){ Nome = "João", Apelido = "Cabete"};

        _db.Add(autor);
        _db.SaveChanges();

        return View();
    }

    public IActionResult NovaView()
    {
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
