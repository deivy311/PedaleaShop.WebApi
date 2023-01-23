using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.Entities.Dtos;
using System.Data;
using PedaleaShop.WebApi.Domain.Extensions;

namespace PedaleaShop.WebApi.Domain.Services
{
    public class ShoppingCartsItemsServices: IShoppingCartsItemsServices
    {
        public IUnitRepository _repository;


        public ShoppingCartsItemsServices(IUnitRepository repository)
        {
            _repository = repository;
        }

        public async Task<ShoppingCartItemDto?> AddEntity(ShoppingCartItemToAddDto cartItemToAddDto)
        {
            return (await _repository.ShoppingCartsItemsRepository.AddEntityAsync("dbo.ShoppingCartItemToAddSp", cartItemToAddDto)).ConvertToShoppingCartItemDto()?.FirstOrDefault();
        }

        public async Task<ShoppingCartItemDto?> DeleteEntity(int Id)
        {
            return (await _repository.ShoppingCartsItemsRepository.DeleteEntityAsync("dbo.ShoppingCartItemToDeleteSp", Id)).ConvertToShoppingCartItemDto()?.FirstOrDefault();
        }

        public async Task<IEnumerable<ShoppingCartItemDto>> GetEntities()
        {
            return (await _repository.ShoppingCartsItemsRepository.GetAllAsync("dbo.AllShoppingCartsItemsView")).ConvertToShoppingCartItemDto();
        }

        public async Task<IEnumerable<ShoppingCartItemDto>> GetEntities(string userId)
        {
            return (await _repository.ShoppingCartsItemsRepository.GetByIdAsync("dbo.AllShoppingCartsItemsView", "UserId",userId)).ConvertToShoppingCartItemDto();
        }

        public async Task<ShoppingCartItemDto> GetEntity(int Id)
        {
            return (await _repository.ShoppingCartsItemsRepository.GetAllAsync("dbo.AllShoppingCartsItemsView")).ConvertToShoppingCartItemDto().FirstOrDefault();
        }

        public async Task<ShoppingCartItemDto?> UpdateEntittyQuantity(int Id, ShoppingCartItemQuantityUpdateDto cartItemQuantityUpdateDto)
        {
            return (await _repository.ShoppingCartsItemsRepository.UpdateEntityAsync("dbo.ShoppingCartItemToUpdateSp", cartItemQuantityUpdateDto)).ConvertToShoppingCartItemDto()?.FirstOrDefault();
        }
    }
}
