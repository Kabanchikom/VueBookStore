using Microsoft.EntityFrameworkCore;
using VueBookStore.Server.Areas.Product.Services;
using VueBookStore.Server.EF;
using VueBookStore.Server.EF.Seeders;

var corsPolicy = "frontend";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicy,
        policy  =>
        {
            policy.WithOrigins("http://localhost:8080");
        });
});

builder.Services.AddDbContext<BookStoreDbContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Host.UseDefaultServiceProvider(options => options.ValidateScopes = false);
builder.Services.AddControllers().AddNewtonsoftJson();;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddProducts();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(corsPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var bookStoreSeeder = new BookStoreSeeder();
await bookStoreSeeder.SeedAsync(app, builder);

app.Run();