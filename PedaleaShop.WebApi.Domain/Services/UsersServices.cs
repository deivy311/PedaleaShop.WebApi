using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;
using System.Data;
using PedaleaShop.Entities.Extensions;

namespace PedaleaShop.WebApi.Domain.Services
{
    public class UsersServices: IUsersServices
    {
        public IUnitRepository _repository;


        public UsersServices(IUnitRepository repository)
        {
            _repository = repository;
        }



        public async Task<IEnumerable<UserDto>> GetEntities()
        {
            return (await _repository.UsersRepository.GetAllAsync("dbo.TotalUsertAcquisitions")).ConvertToUserDto();
        }

        public async Task<IEnumerable<UserDto>> GetEntities(string userId)
        {
            return (await _repository.UsersRepository.GetByIdAsync("dbo.TotalUsertAcquisitions", "UserId",userId)).ConvertToUserDto();
        }

        public async Task<UserDto> GetEntity(int Id)
        {
            return (await _repository.UsersRepository.GetAllAsync("dbo.TotalUsertAcquisitions")).ConvertToUserDto().FirstOrDefault();
        }


        public async Task<UserDto?> UpdateEntittyQuantity(string userName, UserDto cartItemQuantityUpdateDto)
        {
            return (await _repository.UsersRepository.UpdateEntityQuantityAsync("dbo.UserMetricsToAddOrUpdateSp", userName,cartItemQuantityUpdateDto)).ConvertToUserDto()?.FirstOrDefault();
        }
    }
}
