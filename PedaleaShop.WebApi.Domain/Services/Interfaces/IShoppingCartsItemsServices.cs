using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
namespace PedaleaShop.WebApi.Domain.Services.Interface
{
    public interface IShoppingCartsItemsServices
    {
        Task<IEnumerable<ShoppingCartItemDto>> GetEntities();
        Task<IEnumerable<ShoppingCartItemDto>> GetEntities(string userId);
        Task<ShoppingCartItemDto> GetEntity(int Id);
        Task<ShoppingCartItemDto?> AddEntity(ShoppingCartItemToAddDto cartItemToAddDto);
        Task<ShoppingCartItemDto?> DeleteEntity(int Id);
        Task<ShoppingCartItemDto?> UpdateEntittyQuantity(int Id, ShoppingCartItemQuantityUpdateDto cartItemQuantityUpdateDto);
    }
}
