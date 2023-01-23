using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Repository;


namespace PedaleaShop.WebApi.Domain.Services
{
    public class UsersServices: IUsersServices
    {
        public IUnitRepository _repository;


    }
}
