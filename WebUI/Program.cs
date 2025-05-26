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


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.DependencyInjectionInfrastructure(configuration);


var app = builder.Build();


app.UseAuthorization();
app.MapControllers();
app.Run();