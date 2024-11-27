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
    


    // HttpGet
    // Post 

    // Post ve get ile çalışır!!

    // Get : sayfanın hiç bir parametreye bağlı olmadan talep edilmesi

    // Post : Sayfaya bir parametre vererek sayfanın gönderilmesi!!! 
    
    [HttpGet]
    public IActionResult SaveUser(){

        SaveUser user = new SaveUser();
        return View(user);
    }

    [HttpPost]
    public IActionResult SaveUser(SaveUser model){
        
        return View();
    }


    public IActionResult MyPage(){

        // kendi mvc sayfamızı yapalım!!

        // sayfa oluşturmak için bir action birde view'a ihtiyacımız var!!

        // eğer, return view dediğinizde view adı vermezseniz, action'ın adında bir view arayacaktır sistem!!!!
        return View();
    }
    
    public IActionResult Index()
    {
        // ekranda gösterilecek olan veriler burada hazırlanır,!!
        // bir veri kaynağından veriler çekilebilir

        // hazırlanan veri model denen yapıların içerisine yerleştirilir

        // model view'a transfer edilir!!

        // Ogrenci isminde hazırlanan modal'in içerisini dolduralım

        //kontroller kısmında, model kısmında oluşturulan tipin içerisi doldurulup, view 'a gönderildi
   
        List<Ogrenci> ogrencis = new List<Ogrenci>(){

            new Ogrenci { Name = "Ahmet", Id=1},
            new Ogrenci { Name = "Mehmet", Id=2},
            new Ogrenci{ Name = "Veli", Id=3},
        };

        // action : return view komutu ile , 1. parametre view'in adı
        // 2. parametre ise hazırlamış olduğu modeli gönderir!!

        //return view ifadesi ise, hazırlanan verileri view'a göndermektir. Aynı zamanda view'i çağırmaktır

        // istek önce controller'a gelir
        // controller view a döneceği veriyi hazırlar ve sonrasında view'i çağırır!!

        
        return View("Index1", ogrencis);
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
