using Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.DependencyInjectionInfrastructure(configuration);


var app = builder.Build();


app.UseAuthorization();
app.MapControllers();
app.Run();