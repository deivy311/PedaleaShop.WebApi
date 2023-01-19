//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Context;
using PedaleaShop.WebApi.Infrastructure.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PedaleaShop.WebApi.Infrastructure.UnitRepository
{
    public class UnitRepository : IUnitRepository
    {
        protected readonly ApplicationDbContext _dbContext;

        protected IProductsRepository _productsRepository;
        //protected IFilesRepository _FilesRepository;
        protected IUsersRepository _usersRepository;
        protected string _sqlConnectionString;
        IConfiguration _configuration;
        //public UnitRepository(ApplicationDbContext dbContext)
        //{
        //    _dbContext = dbContext;

        //}
        public UnitRepository(IConfiguration configuration)
        {
            //_sqlConnectionString = configuration.GetConnectionString("DefaultDBConnection");
            _configuration = configuration;
        }


        public IProductsRepository ProductsRepository
        {
            get { return _productsRepository = _productsRepository ?? new ProductsRepository(_configuration); }
        }
        //public IFilesRepository FilesRepository
        //{
        //    get { return _filesRepository = _filesRepository ?? new FilesRepository(_dbContext); }
        //}

        public IUsersRepository UsersRepository
        {
            get { return _usersRepository = _usersRepository ?? new UsersRepository(_configuration); }
        }

        //public void Commit()
        //    => _dbContext.SaveChanges();

        //public async Task CommitAsync()
        //    => await _dbContext.SaveChangesAsync();

        //public IEnumerable<Product> GetProductByCompanyId(int id)
        //{
        //    try
        //    {
        //        return _dbContext.Products.Where(x => x.CompanyId == id).ToList();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
            
        //}
        //public AspNetUsers GetByName(string Name)
        //{
        //    return _dbContext.Users.Where(x => x.UserName == Name).FirstOrDefault();
        //}

    }
}
