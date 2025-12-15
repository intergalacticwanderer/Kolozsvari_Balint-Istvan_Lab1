var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "metoda1",
    pattern: "{controller=Metoda1}/{action=Index2}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "NameAge",
    pattern: "{controller=NameAge}/{action=Greet}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "ViewBag",
    pattern: "{controller=Viewb}/{action=Exer2}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "StudentInfo",
    pattern: "{controller=Student}/{action=info}/{id?}")
    .WithStaticAssets();


app.Run();
