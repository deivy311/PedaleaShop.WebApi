using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services;
using PedaleaShop.WebApi.Infrastructure.UnitRepository;
using PedaleaShop.WebApi.Infrastructure.Context;
using PedaleaShop.WebApi.Infrastructure.Repository;
using Microsoft.Data.SqlClient;

namespace PedaleaShop.WebApi.Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private const string CorsPolicyName = "CorsPolicyTest";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //// Add services to the container.

            // services.AddControllers();
            services.AddTransient<IProductsServices, ProductsServices>();
            services.AddTransient<IProductsCategoriesServices, ProductsCategoriesServices>();
            services.AddTransient<IProductsColorsServices, ProductsColorsServices>();
            services.AddTransient<IProductsSizesServices, ProductsSizesServices>();
            services.AddTransient<IShoppingCartsItemsServices, ShoppingCartsItemsServices>();
            services.AddTransient<IUnitRepository, UnitRepository>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            //services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultDBConnection")), ServiceLifetime.Transient);
            //SqlConnection sqlConnection = new SqlConnection(_configuration.GetConnectionString("DefaultDBConnection"))
            //services.AddConnections(new SqlConnection(Configuration.GetConnectionString("DefaultDBConnection")));
            services.AddCors(options =>
            {
                options.AddPolicy(name: CorsPolicyName,
                       policy =>
                       {
                           policy.WithOrigins("http://localhost:4200",
                                               "http://20.127.121.227:8082");
                       });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => true) // allow any origin
            .AllowCredentials()); // allow credentials
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(CorsPolicyName);

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
