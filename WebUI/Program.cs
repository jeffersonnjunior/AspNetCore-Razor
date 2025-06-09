using Application.DependencyInjection;
using Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

bool isRunningInContainer = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true";

builder.WebHost.ConfigureKestrel(options =>
{
    if (isRunningInContainer)
    {
        options.ListenAnyIP(5000);
    }
    else
    {
        options.ListenAnyIP(5001, listenOptions =>
        {
            listenOptions.UseHttps();
        });
    }
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); 
builder.Services.AddEndpointsApiExplorer();

builder.Services.DependencyInjectionApplication(configuration);
builder.Services.DependencyInjectionInfrastructure(configuration);

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); 

app.Run();