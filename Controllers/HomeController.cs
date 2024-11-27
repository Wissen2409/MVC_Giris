using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Giris.Models;

namespace MVC_Giris.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // ekranda gösterilecek olan veriler burada hazırlanır,!!
        // bir veri kaynağından veriler çekilebilir

        // hazırlanan veri model denen yapıların içerisine yerleştirilir

        // model view'a transfer edilir!!

        // Ogrenci isminde hazırlanan modal'in içerisini dolduralım

       GeneralModel model = new GeneralModel();
        model.Ogrenci = new List<Ogrenci>(){

            new Ogrenci { Name = "Ahmet", Id=1},
            new Ogrenci { Name = "Mehmet", Id=2},
            new Ogrenci{ Name = "Veli", Id=3},
        };


        return View("Index1",model);
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
