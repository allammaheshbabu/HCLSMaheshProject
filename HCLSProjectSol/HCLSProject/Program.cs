using HCLSProject.DataAccess.IRepositories;
using HCLSProject.DataAccess.Repositories;
using HCLSProject.DBContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HCLSDBContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("con_str")));
builder.Services.AddTransient<IAdminTypesRepository, AdminTypesRepository>();
builder.Services.AddTransient<IAdminRepository, AdminRepository>();
builder.Services.AddCors();


var app = builder.Build();

// Configure the HTTP request pipeline.  
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});


app.UseAuthorization();

app.MapControllers();

app.Run();
