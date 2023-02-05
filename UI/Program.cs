using BLL;
using DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ************************************************************
// ******** FOLLOWING SERVICES ARE CUSTOM REGISTERED **********
// ************************************************************
//builder.Services.AddScoped<ICategoryDb, CategoryDb>();
builder.Services.AddTransient<ICategoryDb, CategoryDb>();
builder.Services.AddTransient<ICategoryBs, CategoryBs>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    @"server=DESKTOP-MAE99H0; database=MultiLayerDb; trusted_connection=true; encrypt=false; TrustServerCertificate=true;"
));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
