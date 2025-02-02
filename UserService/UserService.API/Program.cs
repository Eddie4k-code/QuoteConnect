using UserService.Infrastructure;
using UserService.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//add infra services
builder.Services.AddInfraServices(builder.Configuration);
builder.Services.RegisterApplicationServices();





builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
