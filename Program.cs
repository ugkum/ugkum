using Microsoft.EntityFrameworkCore;
using UGKUM.Innovation.Data;
using UGKUM.Innovation.Services;
using UGKUM.Innovation.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// ─── Servicios MVC ───────────────────────────────────────────────────────────
builder.Services.AddControllersWithViews();

// ─── Servicios de dominio ────────────────────────────────────────────────────
builder.Services.AddScoped<IContactService, ContactService>();

// ─── SQL Server + EF Core (descomentar al conectar base de datos) ────────────
// builder.Services.AddDbContext<ApplicationDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ─── Módulos futuros: Blog, Portafolio, Portal Clientes, Catálogo ───────────
// builder.Services.AddScoped<IBlogService, BlogService>();
// builder.Services.AddScoped<IPortfolioService, PortfolioService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// ─── Rutas actuales ──────────────────────────────────────────────────────────
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// ─── Rutas futuras (descomentar al implementar módulos) ─────────────────────
// app.MapControllerRoute(name: "blog", pattern: "blog/{action=Index}/{id?}", defaults: new { controller = "Blog" });
// app.MapControllerRoute(name: "portfolio", pattern: "portafolio/{action=Index}/{id?}", defaults: new { controller = "Portfolio" });
// app.MapControllerRoute(name: "portal", pattern: "portal/{action=Index}", defaults: new { controller = "Portal" });
// app.MapControllerRoute(name: "products", pattern: "productos/{action=Index}/{id?}", defaults: new { controller = "Products" });

app.Run();
