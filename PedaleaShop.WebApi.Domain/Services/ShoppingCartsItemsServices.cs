using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
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


    }
}
