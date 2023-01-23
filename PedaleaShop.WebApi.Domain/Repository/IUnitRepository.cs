using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.Entities.Dtos;

namespace PedaleaShop.WebApi.Infrastructure.Repository
{
    public interface IUnitRepository
    {

        IUsersRepository UsersRepository { get; }
        IProductsRepository ProductsRepository { get; }
        IProductsCategoriesRepository ProductsCategoriesRepository { get; }
        IProductsColorsRepository ProductsColorsRepository { get; }
        IProductsSizesRepository ProductsSizesRepository { get; }
        IShoppingCartsItemsRepository ShoppingCartsItemsRepository { get; }


}
}
