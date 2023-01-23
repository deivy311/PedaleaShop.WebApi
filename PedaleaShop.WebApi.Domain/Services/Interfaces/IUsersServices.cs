using PedaleaShop.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace PedaleaShop.WebApi.Domain.Services.Interface
{
    public interface IUsersServices
    {
        Task<IEnumerable<UserDto>> GetEntities();
        Task<UserDto> GetEntity(int id);
        Task<UserDto?> UpdateEntittyQuantity(string userName,UserDto cartItemQuantityUpdateDto);
        Task<IEnumerable<UserDto>> GetEntities(string userId);
    }
}
