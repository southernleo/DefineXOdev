var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // MVC i�in gerekli servis

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
     
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Controller'lara y�nlendirme yapacak olan yap�
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ogrenci}/{action=Index}/{id?}");

app.Run();
