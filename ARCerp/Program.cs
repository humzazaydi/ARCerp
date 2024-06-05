using ARCerp.Data;
using ARCerp.Data.Account;
using ARCerp.Data.Order;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorBootstrap();

builder.Services.AddDbContext<ARCerpContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("AppDBConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => {
options.Password.RequireDigit = false;
options.Password.RequiredLength = 5;
options.Password.RequireLowercase = false;
options.Password.RequireUppercase = false;
options.Password.RequireNonAlphanumeric = false;
options.SignIn.RequireConfirmedEmail = false;

}).AddEntityFrameworkStores<ARCerpContext>();

builder.Services.AddSingleton<MockupDatasets>();
builder.Services.AddSingleton<OrderService>();
builder.Services.AddSingleton<AccountService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
