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
using PedaleaShop.Entities.Extensions;

namespace PedaleaShop.WebApi.Domain.Services
{
    public class ProductsSizesServices: IProductsSizesServices
    {
        public IUnitRepository _repository;


        public ProductsSizesServices(IUnitRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductsSizeDto>> GetEntities()
        {
            return (await _repository.ProductsSizesRepository.GetAllAsync("dbo.AllProductsSizesView")).ConvertToProductSizeDto();
        }
        public async Task<ProductsSizeDto> GetEntity(int Id)
        {
            return (await _repository.ProductsSizesRepository.GetAllAsync("dbo.AllProductsSizesView")).ConvertToProductSizeDto().FirstOrDefault();
        }


    }
}
