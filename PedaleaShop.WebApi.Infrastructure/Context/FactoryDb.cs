using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedaleaShop.WebApi.Infrastructure.Context
{
    public class FactoryDb : IFactoryDb
    {
        private ApplicationDbContext dataContext;
        private readonly IConfiguration _configuration;
        private string _connectionString;
        DbContextOptionsBuilder<ApplicationDbContext> _optionsBuilder;
        public FactoryDb(IConfiguration configuration)
        {
            _configuration = configuration;
            _optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            _connectionString = _configuration.GetConnectionString("DBConnection");
            _optionsBuilder.UseSqlServer(_connectionString);
        }
        public ApplicationDbContext GetContext()
        {
            dataContext = new ApplicationDbContext(_optionsBuilder.Options);
            return dataContext;
        }
        public void Dispose()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
