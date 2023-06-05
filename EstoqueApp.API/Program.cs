using EstoqueApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRouting(map => map.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddSwaggerDoc();
builder.Services.AddCorsPolicy();
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddAutoMapperProfiles();
builder.Services.AddMediatR(); // MediatR tem que ficar ap�s service sen�o ele n�o consegue ser constru�do

var app = builder.Build();

app.UseSwaggerDoc();
app.UseCorsPolicy();
app.UseAuthorization();
app.MapControllers();

app.Run();


//Esse processo � feito para o xUnit poder acessar a program e realizar os testes
public partial class Program { }