using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Domain.Entities;

namespace PedaleaShop.WebApi.Infrastructure.Repository
{
    public interface IUnitRepository
    {

        IUsersRepository UsersRepository { get; }
        IProductsRepository ProductsRepository { get; }

        //IEnumerable<Product> GetProductByCompanyId(int id);
        //User GetByName(string Name);

        //void Commit();
        //Task CommitAsync();
    }
}
