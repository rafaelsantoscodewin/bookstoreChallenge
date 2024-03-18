using bookstoreChallenge.app.Configuration;
using bookstoreChallenge.app.Hubs;
using bookstoreChallenge.business.Core.Configuration;
using bookstoreChallenge.business.Services.Book;
using bookstoreChallenge.sql;
using bookstoreChallenge.sql.Configuration;
using bookstoreChallenge.sql.Data.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR().AddJsonProtocol();
builder.Services.AddUseCases();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddAutoMapper(typeof(SQLAutoMapperProfile));
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddDbContext<BookContext>(
    options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

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

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
    endpoints.MapHub<BookHub>("/books");
});

app.UseHttpsRedirection();

app.MapControllers();

await app.RunAsync();
