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
    public class ProductsCategoriesServices: IProductsCategoriesServices
    {
        public IUnitRepository _repository;


        public ProductsCategoriesServices(IUnitRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductCategoryDto>> GetEntities()
        {
            return (await _repository.ProductsCategoriesRepository.GetAllAsync("dbo.AllProductsCategoriesView")).ConvertToProductCategoryDto();
        }
        public async Task<ProductCategoryDto> GetEntity(int Id)
        {
            return (await _repository.ProductsCategoriesRepository.GetAllAsync("dbo.AllProductsCategoriesView")).ConvertToProductCategoryDto().FirstOrDefault();
        }


    }
}
