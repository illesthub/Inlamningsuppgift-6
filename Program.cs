using Inlamningsuppgift_6.Contexts;
using Inlamningsuppgift_6.Helpers.Repositories;
using Inlamningsuppgift_6.Helpers.Services;
using Inlamningsuppgift_6.Models.Entities;
using Inlamningsuppgift_6.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<UserAdminService>();

// contexts
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

//authentication
builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();

//repositories
builder.Services.AddScoped<AddressRepo>();
builder.Services.AddScoped<UserAddressRepo>();
builder.Services.AddScoped<ContactFormRepo>();
builder.Services.AddScoped<ProductRepo>();
builder.Services.AddScoped<ProductCategoryRepo>();
builder.Services.AddScoped<CategoryRepo>();

builder.Services.AddTransient<CollectionItemViewModel>();
builder.Services.AddTransient<ProductEntity>();
builder.Services.AddTransient<ProductCategoryEntity>();






var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
