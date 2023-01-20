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
    public class ProductsSizesServices: IProductsSizesServices
    {
        public IUnitRepository _repository;


        public ProductsSizesServices(IUnitRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductSizeDto>> GetEntities()
        {
            return (await _repository.ProductsSizesRepository.GetAllAsync("dbo.AllProductsSizesView")).ConvertToProductSizeDto();
        }
        public async Task<ProductSizeDto> GetEntity(int Id)
        {
            return (await _repository.ProductsSizesRepository.GetAllAsync("dbo.AllProductsSizesView")).ConvertToProductSizeDto().FirstOrDefault();
        }


    }
}
