using api.data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers(); // this will add the controllers to the services container
builder.Services.AddEndpointsApiExplorer(); // this will add the endpoint api explorer to the services container
builder.Services.AddSwaggerGen(); // this will add the swagger generator to the services container

// Add services to the container. / Add the database context to the container
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    // options.UseSqlServer("Server=localhost;Database=StocksDB;User Id=sa;Password=Password123!;");
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();// this will add the swagger to the application
    app.UseSwaggerUI();// this will add the swagger UI to the application
}

app.UseHttpsRedirection();

app.MapControllers(); // this will map all the controllers in the application

app.Run();

