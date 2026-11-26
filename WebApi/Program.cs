using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using Repository;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<IUsersRepository,UsersRepository>();
builder.Services.AddTransient<IPasswordsService, PasswordsService>();
builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<IProductsRepository, ProductsRepository>();
builder.Services.AddTransient<IProductsService, ProductsService>();
builder.Services.AddTransient<ICategoriesRepository, CategoryRepository>();
builder.Services.AddTransient<ICategoriesService, CategoriesService>();
builder.Services.AddTransient<IOrdersRepository, OrdersRepository>();
builder.Services.AddTransient<IOrdersService, OrdersService>();
builder.Services.AddOpenApi();
builder.Host.UseNLog();
builder.Services.AddDbContext<storeDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("myConnectionString")),ServiceLifetime.Transient);

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()||app.Environment.IsEnvironment("School")|| app.Environment.IsEnvironment("Home"))
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}


app.UseHttpsRedirection();


app.UseAuthorization();

app.UseStaticFiles();

app.MapControllers();

app.Run();
