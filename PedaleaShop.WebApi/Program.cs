using Microsoft.EntityFrameworkCore;
using PedaleaShop.WebApi.Domain.Services;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Infrastructure.Context;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.WebApi.Infrastructure.UnitRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;

namespace PedaleaShop.WebApi.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception exception)
            {
                //NLog: catch setup errors
                throw;
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddTransient<IProductsServices, ProductsServices>();
//builder.Services.AddTransient<IUnitRepository, UnitRepository>();

//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")), ServiceLifetime.Transient);

//var app = builder.Build();
// app.UseCors(x => x
//             .AllowAnyMethod()
//             .AllowAnyHeader()
//             .SetIsOriginAllowed(origin => true) // allow any origin
//             .AllowCredentials()); // allow credentials
// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

//app.MapControllers();

// app.Run();
