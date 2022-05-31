using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OpenUp.EFCore.Autores;
using OpenUp.WebApp.Data;
using OpenUp.WebApp.Models;

namespace OpenUp.WebApp.Controllers;

public class HomeController : Controller
{

    private readonly ApplicationDbContext _db;

    public HomeController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        Autor autor = new(){ Nome = "João", Apelido = "Cabete"};

        _db.Add(autor);
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
