using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
using System.Data;

namespace PedaleaShop.WebApi.Domain.Services
{
    public class ProductsServices: IProductsServices
    {
        public IUnitRepository _repository;


        public ProductsServices(IUnitRepository repository)
        {
            _repository = repository;
        }
        //public async Task AddEntity(Product entity)
        //{
        //    _repository.ProductsRepository.Add(entity);
        //    await _repository.CommitAsync();
        //}
        //public async Task AddEntities(IEnumerable<Product> entities)
        //{
        //    _repository.ProductsRepository.Add(entities);
        //    await _repository.CommitAsync();
        //}

        //public Product GetEntity(int Id) => _repository.ProductsRepository.GetById(Id);


        public async Task<DataTable> GetEntities()=> await _repository.ProductsRepository.GetAllAsync();
        //public async Task<IEnumerable<Product>> GetEntities(int q) => await _repository.ProductsRepository.GetAllAsync(q);
        ////public async Task<IEnumerable<Product>> GetEntities(int CompanyId) => await _repository.ProductsRepository.GetAllAsync(int CompanyId);

        //public async Task UpdateEntity(Product entity)
        //{
        //    _repository.ProductsRepository.Update(entity);
        //    await _repository.CommitAsync();
        //}
        //public async Task UpdateEntity(IEnumerable<Product> entities)
        //{
        //    _repository.ProductsRepository.Update(entities);
        //    await _repository.CommitAsync();
        //}
        //public async Task DeleteEntity(Product entity)
        //{
        //    _repository.ProductsRepository.Delete(entity);
        //    await _repository.CommitAsync();
        //}

        //public async Task DeleteEntity(IEnumerable<Product> entities)
        //{
        //    _repository.ProductsRepository.Delete(entities);
        //    await _repository.CommitAsync();
        //}

    }
}
