using Microsoft.EntityFrameworkCore;
using ToDo.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

//Register DbContext
builder.Services.AddDbContext<ToDoDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoConnectionStr"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
