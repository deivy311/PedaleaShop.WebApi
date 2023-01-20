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
