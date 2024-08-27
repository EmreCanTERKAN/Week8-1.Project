using Microsoft.AspNetCore.Mvc.ViewEngines;
using static System.Net.WebRequestMethods;
using System.Reflection;
using System;

var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekleme
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Statik dosyalarýn kullanýmýný belirtme
app.UseStaticFiles();

//Routing yapýlandýrmasý
app.UseRouting();

// Varsayýlan Routing
app.MapControllerRoute(
    name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();

//Controller:

//Taným: HTTP isteklerini iþleyen sýnýflardýr. Ýþ mantýðýný uygular ve uygun bir View'e yönlendirir.
//Örnek: HomeController sýnýfý, istekleri Index action'ýna yönlendirir.

//Action:
//Taným: Controller içinde tanýmlý yöntemlerdir ve belirli HTTP isteklerini iþlemek için kullanýlýr.
//Örnek: Index() action'ý, ana sayfanýn gösterilmesi için kullanýlýr.

//Model:
//Taným: Veritabaný ile etkileþimde bulunur ve iþ mantýðýný temsil eder. Veriyi saklar ve iþlemek için kullanýlýr.
//Örnek: Product sýnýfý, ürün bilgilerini temsil eder.

//View:
//Taným: Kullanýcýya sunulan görsel içerikleri oluþturur. HTML ve Razor kodlarý içerir.
//Örnek: Index.cshtml dosyasý, ürünleri listeleyen bir HTML sayfasýdýr.

//Razor:
//Taným: ASP.NET Core'da dinamik HTML içeriklerini oluþturmak için kullanýlan bir view engine'dir.
//Örnek: @model direktifi ile model verilerini View'de kullanýr.

//RazorView:
//Taným: Razor tarafýndan iþlenen ve kullanýcýya gönderilen HTML þablonlarýdýr.
//Örnek: Views / Home / Index.cshtml dosyasý, HomeController'ýn Index action'ý tarafýndan döndürülür.
//wwwroot:

//Taným: Statik dosyalarýn(CSS, JavaScript, resimler vb.) saklandýðý klasördür.
//Örnek: wwwroot / css / site.css dosyasý, stil sayfalarýný içerir ve HTML sayfalarýnda kullanýlýr.