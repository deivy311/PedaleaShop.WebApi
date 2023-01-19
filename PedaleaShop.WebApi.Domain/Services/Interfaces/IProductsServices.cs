using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
namespace PedaleaShop.WebApi.Domain.Services.Interface
{
    public interface IProductsServices
    {
        //Task AddEntity(Product entity);
        //Task AddEntities(IEnumerable<Product> entities);
        //Product GetEntity(int Id);
        Task<DataTable> GetEntities();
        //Task<IEnumerable<Product>> GetEntities(int q);
        //Task UpdateEntity(Product entity);
        //Task UpdateEntity(IEnumerable<Product> entities);
        //Task DeleteEntity(Product entity);
        //Task DeleteEntity(IEnumerable<Product> entities);
    }
}
