using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.Entities.Dtos;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PedaleaShop.WebApi.Infrastructure.Repositories
{

    public class ShoppingCartsItemsRepository : Repository<ShoppingCartItemDto>, IShoppingCartsItemsRepository
    {

        public ShoppingCartsItemsRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<DataTable> AddEntityAsync(string shoppingCartItemDtoSp, ShoppingCartItemToAddDto cartItemToAddDto)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@CartProductToAddId",cartItemToAddDto.CartId),
                new SqlParameter("@ProductToAddId",cartItemToAddDto.ProductId),
                new SqlParameter("@QuantityProductToAddId",cartItemToAddDto.Quantity),
                new SqlParameter("@IsSeparatedProductToAddId",cartItemToAddDto.Separated),
                new SqlParameter("@IsPaidProductToAddId",cartItemToAddDto.Paid),
            };
            return await this.SqlConnectionManager(shoppingCartItemDtoSp, sqlParameters);

        }

        public async Task<DataTable> DeleteEntityAsync(string shoppingCartItemDtoSp, int Id)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@CartProductToDeleteId",Id),

            };
            return await this.SqlConnectionManager(shoppingCartItemDtoSp, sqlParameters);
        }

        public async Task<DataTable> UpdateEntityIsSeparatedAsync(string shoppingCartItemDtoSp, ShoppingCartItemIsSeparatedUpdateDto cartItemIsSeparatedUpdateDto)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@CartProductToUpdateId",cartItemIsSeparatedUpdateDto.CartItemId),
                new SqlParameter("@CartProductIsSeparated",cartItemIsSeparatedUpdateDto.Separated),

            };
            return await this.SqlConnectionManager(shoppingCartItemDtoSp, sqlParameters);
        }

        public async Task<DataTable> UpdateEntityQuantityAsync(string shoppingCartItemDtoSp, ShoppingCartItemQuantityUpdateDto cartItemQuantityUpdateDto)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@CartProductToUpdateId",cartItemQuantityUpdateDto.CartItemId),
                new SqlParameter("@CartProductQuantity",cartItemQuantityUpdateDto.Quantity),

            };
            return await this.SqlConnectionManager(shoppingCartItemDtoSp, sqlParameters);
        }
    }

}
