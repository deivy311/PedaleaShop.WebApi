using PedaleaShop.Entities.Dtos;
using PedaleaShop.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
namespace PedaleaShop.WebApi.Domain.Services.Interface
{
    public interface IProductsServices
    {
        Task<IEnumerable<ProductsDto>> GetEntities();
        Task<ProductsDto> GetEntity(int Id);
        Task<IEnumerable<ProductsDto>> GetEntitiesByCategory(int categoryId);
    }
}
