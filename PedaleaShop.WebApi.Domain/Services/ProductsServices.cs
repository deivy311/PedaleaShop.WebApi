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
using PedaleaShop.WebApi.Domain.Extensions;

namespace PedaleaShop.WebApi.Domain.Services
{
    public class ProductsServices: IProductsServices
    {
        public IUnitRepository _repository;


        public ProductsServices(IUnitRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> GetEntities()
        {
            return (await _repository.ProductsRepository.GetAllAsync("dbo.AllProductsView")).ConvertToProductDto();
        }

        public async Task<ProductDto> GetEntity(int Id)
        {
            return (await _repository.ProductsRepository.GetByIdAsync("dbo.AllProductsView", Id)).ConvertToProductDto().FirstOrDefault();
        }
        public async Task<IEnumerable<ProductDto>> GetEntitiesByCategory(int categoryId)
        {
            return (await _repository.ProductsRepository.GetByIdAsync("dbo.AllProductsView","CategoryId", categoryId)).ConvertToProductDto();
        }

    }
}
