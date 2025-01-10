using Microsoft.EntityFrameworkCore;
using studentList.Context;
using studentList.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// We are letting our webapp know that we can access our StudentListServices
builder.Services.AddScoped<StudentListServices>();

//We are getting our Connection string from our appsettings.json and storing into a Variable
var connectionString = builder.Configuration.GetConnectionString("DatabaseConnections");

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

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
