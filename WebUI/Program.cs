using Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

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

builder.Services.DependencyInjectionInfrastructure();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

app.Run();