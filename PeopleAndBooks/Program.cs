using AutoMapper;
using PeopleAndBooks.BLL.Service;
using PeopleAndBooks.BLL.Service.Interface;
using PeopleAndBooks.DAL.Repository.Interface;
using PeopleAndBooks.DAL.Reposotory;
using PeopleAndBooks.DAL.Reposotory.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IHumanService, HumanService>();
builder.Services.AddScoped<IHumanReposotory, HumanReposotory>();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<ILibraryCardRepository, LibraryCardRepository>();
builder.Services.AddScoped<ILibraryCardService, LibraryCardService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
