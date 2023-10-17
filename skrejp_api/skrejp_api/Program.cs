using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using skrejp_api;
using skrejp_api.Data;
using System.Web.Http;
using System.Web.Http.Cors;
namespace skrejp_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable CORS for the specified URL
            var corsPolicy = new EnableCorsAttribute("https://housekey-nine.vercel.app", "*", "*");
            config.EnableCors(corsPolicy);

            // Other configuration and route setup code...
        }
    }
}
//var builder = WebApplication.CreateBuilder(args);

//var config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json", false)
//    .Build();
//// Add services to the container.
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//      options.UseSqlite(config.GetConnectionString("db1")));

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
