using Microsoft.AspNetCore.Mvc.ViewEngines;
using static System.Net.WebRequestMethods;
using System.Reflection;
using System;

var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekleme
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Statik dosyalar�n kullan�m�n� belirtme
app.UseStaticFiles();

//Routing yap�land�rmas�
app.UseRouting();

// Varsay�lan Routing
app.MapControllerRoute(
    name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();

//Controller:

//Tan�m: HTTP isteklerini i�leyen s�n�flard�r. �� mant���n� uygular ve uygun bir View'e y�nlendirir.
//�rnek: HomeController s�n�f�, istekleri Index action'�na y�nlendirir.

//Action:
//Tan�m: Controller i�inde tan�ml� y�ntemlerdir ve belirli HTTP isteklerini i�lemek i�in kullan�l�r.
//�rnek: Index() action'�, ana sayfan�n g�sterilmesi i�in kullan�l�r.

//Model:
//Tan�m: Veritaban� ile etkile�imde bulunur ve i� mant���n� temsil eder. Veriyi saklar ve i�lemek i�in kullan�l�r.
//�rnek: Product s�n�f�, �r�n bilgilerini temsil eder.

//View:
//Tan�m: Kullan�c�ya sunulan g�rsel i�erikleri olu�turur. HTML ve Razor kodlar� i�erir.
//�rnek: Index.cshtml dosyas�, �r�nleri listeleyen bir HTML sayfas�d�r.

//Razor:
//Tan�m: ASP.NET Core'da dinamik HTML i�eriklerini olu�turmak i�in kullan�lan bir view engine'dir.
//�rnek: @model direktifi ile model verilerini View'de kullan�r.

//RazorView:
//Tan�m: Razor taraf�ndan i�lenen ve kullan�c�ya g�nderilen HTML �ablonlar�d�r.
//�rnek: Views / Home / Index.cshtml dosyas�, HomeController'�n Index action'� taraf�ndan d�nd�r�l�r.
//wwwroot:

//Tan�m: Statik dosyalar�n(CSS, JavaScript, resimler vb.) sakland��� klas�rd�r.
//�rnek: wwwroot / css / site.css dosyas�, stil sayfalar�n� i�erir ve HTML sayfalar�nda kullan�l�r.