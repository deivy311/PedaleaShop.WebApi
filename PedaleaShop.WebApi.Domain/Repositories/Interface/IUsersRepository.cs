﻿using PedaleaShop.Entities.Dtos;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace PedaleaShop.WebApi.Domain.Services.Interface.Repositories
{
    public interface IUsersRepository : IRepository<UserDto>
    {
        Task<DataTable> UpdateEntityQuantityAsync(string userDtoSp, string userName, UserDto cartItemQuantityUpdateDto);

    }
}
