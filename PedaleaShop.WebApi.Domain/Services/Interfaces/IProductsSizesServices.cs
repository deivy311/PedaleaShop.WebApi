using PedaleaShop.Entities.Dtos;
using PedaleaShop.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
namespace PedaleaShop.WebApi.Domain.Services.Interface
{
    public interface IProductsSizesServices
    {
        Task<IEnumerable<ProductsSizeDto>> GetEntities();
        Task<ProductsSizeDto> GetEntity(int Id);
    }
}
