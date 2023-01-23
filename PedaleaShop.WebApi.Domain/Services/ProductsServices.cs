using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.Entities.Dtos;
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

        public async Task<IEnumerable<ProductsDto>> GetEntities()
        {
            return (await _repository.ProductsRepository.GetAllAsync("dbo.AllProductsView")).ConvertToProductDto();
        }

        public async Task<ProductsDto> GetEntity(int Id)
        {
            return (await _repository.ProductsRepository.GetByIdAsync("dbo.AllProductsView", Id)).ConvertToProductDto().FirstOrDefault();
        }
        public async Task<IEnumerable<ProductsDto>> GetEntitiesByCategory(int categoryId)
        {
            return (await _repository.ProductsRepository.GetByIdAsync("dbo.AllProductsView","CategoryId", categoryId)).ConvertToProductDto();
        }

    }
}
