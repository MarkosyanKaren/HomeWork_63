using HomeWork_63.DAL;
using HomeWork_63.DAL.Interfaces;
using HomeWork_63.DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolDBContext>();

builder.Services.AddTransient<IStaffRepo, StaffRepo>();
builder.Services.AddTransient<IStudentRepo, StudentRepo>();
builder.Services.AddTransient<IPropertyRepo, PropertyRepo>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
