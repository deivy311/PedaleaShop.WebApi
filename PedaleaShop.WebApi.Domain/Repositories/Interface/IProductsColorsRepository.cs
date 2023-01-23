using PedaleaShop.Entities.Dtos;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PedaleaShop.WebApi.Domain.Services.Interface.Repositories
{
    public interface IProductsColorsRepository : IRepository<ProductsColorDto>
    {
    }
}
