using _02_WineProject.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using WineProject.API;
//using WineProject.API.Mutations;
using WineProject.API.Types;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
var connectionString = Environment.GetEnvironmentVariable("DefaultConnection");
builder.Services.CreateDatabase(connectionString);

builder.Services.CreateGraphQLConfig(); // Configuração do GraphQL

 
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Configuração do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
    {
        builder.AllowAnyOrigin() // Permite qualquer origem. Substitua por .WithOrigins("https://example.com") para restringir.
               .AllowAnyMethod() // Permite qualquer método HTTP (GET, POST, PUT, etc.).
               .AllowAnyHeader(); // Permite qualquer cabeçalho.
                                  //.AllowCredentials(); // Descomente esta linha se precisar permitir cookies ou autenticação baseada em credenciais.
    });
});

var app = builder.Build();

// cria o middleware
app.UseCors("MyCorsPolicy"); 

app.UseRouting();  
app.UseAuthorization();  

app.MapGraphQL();  
app.UseHttpsRedirection(); 

app.Run();
