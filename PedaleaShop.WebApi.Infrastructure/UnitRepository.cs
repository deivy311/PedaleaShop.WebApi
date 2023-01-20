using Microsoft.Extensions.Configuration;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Context;
using PedaleaShop.WebApi.Infrastructure.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;


namespace PedaleaShop.WebApi.Infrastructure.UnitRepository
{
    public class UnitRepository : IUnitRepository
    {
        protected readonly ApplicationDbContext _dbContext;

        protected IProductsRepository _productsRepository;
        protected IProductsCategoriesRepository _productsCategoriesRepository;
        protected IProductsColorsRepository _productsColorsRepository;
        protected IProductsSizesRepository _productsSizesRepository;
        protected IUsersRepository _usersRepository;
        protected string _sqlConnectionString;
        IConfiguration _configuration;

        public UnitRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public IProductsRepository ProductsRepository
        {
            get { return _productsRepository = _productsRepository ?? new ProductsRepository(_configuration); }
        }
        public IProductsCategoriesRepository ProductsCategoriesRepository
        {
            get { return _productsCategoriesRepository = _productsCategoriesRepository ?? new ProductsCategoriesRepository(_configuration); }
        }
        public IProductsColorsRepository ProductsColorsRepository
        {
            get { return _productsColorsRepository = _productsColorsRepository ?? new ProductsColorsRepository(_configuration); }
        }
        public IProductsSizesRepository ProductsSizesRepository
        {
            get { return _productsSizesRepository = _productsSizesRepository ?? new ProductsSizesRepository(_configuration); }
        }

        public IUsersRepository UsersRepository
        {
            get { return _usersRepository = _usersRepository ?? new UsersRepository(_configuration); }
        }

    }
}
