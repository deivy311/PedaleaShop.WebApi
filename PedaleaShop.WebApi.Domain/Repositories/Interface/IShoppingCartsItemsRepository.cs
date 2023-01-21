﻿using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
using PedaleaShop.WebApi.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PedaleaShop.WebApi.Domain.Services.Interface.Repositories
{
    public interface IShoppingCartsItemsRepository : IRepository<ShoppingCartItemDto>
    {
        Task<DataTable> AddEntityAsync(string shoppingCartItemDtoSp, ShoppingCartItemToAddDto cartItemToAddDto);
        Task<DataTable> DeleteEntityAsync(string shoppingCartItemDtoSp, int Id);
        Task<DataTable> UpdateEntityAsync(string shoppingCartItemDtoSp, ShoppingCartItemQuantityUpdateDto cartItemQuantityUpdateDto);
    }
}
