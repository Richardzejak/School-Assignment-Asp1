ASP .NET Core

ASP.NET är ett ramverk skapat av microsoft som gör det lättare att bygga webbappar,
och APIer, det finns två tillvägagångssätt för att strukturera upp allting,
dessa kan samspela tillsamman. Razorpages och MVC.

Razor Pages

Razor Pages består av ett par olika delar, Program.cs som är starten av applikationen, 
Startup.cs som innehåller kod hur webbapplikationen ska fungera, Appsettings.json
är en konfigurationsfil där man lägger in connection strings, wwwroot håller olika
sorters filer, HTML, CSS och javascript bland annat, och sen har vi pages
som håller cshtml filer och cshtml.cs, den första (Content Page) har en blandning av html och c#
kod, den sistnämnda håller c# kod (Page Model) som sköter all logik i bakgrunden.

MVC

MVC består av tre delar: Model, View och Controller därav namnet, Model som håller logik för appen, och som håller datan likt
EF Core, view är som det låter vad användaren kan se, frontend delen skulle man nästan kunna säga, och controller som
fungerar som en mellanhand, den tar användarens input och skickar vidare till model.