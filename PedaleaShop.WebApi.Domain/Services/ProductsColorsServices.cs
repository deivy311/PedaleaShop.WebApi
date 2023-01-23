using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.Entities.Dtos;
using System.Data;
using PedaleaShop.WebApi.Domain.Extensions;

namespace PedaleaShop.WebApi.Domain.Services
{
    public class ProductsColorsServices: IProductsColorsServices
    {
        public IUnitRepository _repository;


        public ProductsColorsServices(IUnitRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductsColorDto>> GetEntities()
        {
            return (await _repository.ProductsColorsRepository.GetAllAsync("dbo.AllProductsColorsView")).ConvertToProductColorDto();
        }
        public async Task<ProductsColorDto> GetEntity(int Id)
        {
            return (await _repository.ProductsColorsRepository.GetAllAsync("dbo.AllProductsColorsView")).ConvertToProductColorDto().FirstOrDefault();
        }


    }
}
