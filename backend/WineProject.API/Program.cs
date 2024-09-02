using _01_WineProject.Business.Interfaces;
using _01_WineProject.Business.Services;
using _02_WineProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using _02_WineProject.Data.Repositories;
using WineProject.API.GraphQL.Mutations;
using WineProject.API.GraphQL.Queries;
using _02_WineProject.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer(); 

builder.Services.AddDbContextFactory<WineDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")
   // m=>m.MigrationsAssembly("02-WineProject.Data")
));
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<ProdutoQuery>()       
    .AddMutationType<ProdutoMutation>()
    .AddMutationConventions()
    .AddInMemorySubscriptions();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(); 
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

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true));

//app.UseAuthorization();

app.MapGraphQL("/");

app.Run();
