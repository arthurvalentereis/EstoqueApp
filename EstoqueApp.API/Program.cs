using EstoqueApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerDoc();
builder.Services.AddCorsPolicy();
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddMediatR(); // MediatR tem que ficar ap�s service sen�o ele n�o consegue ser constru�do

var app = builder.Build();

app.UseSwaggerDoc();
app.UseCorsPolicy();
app.UseAuthorization();
app.MapControllers();

app.Run();
