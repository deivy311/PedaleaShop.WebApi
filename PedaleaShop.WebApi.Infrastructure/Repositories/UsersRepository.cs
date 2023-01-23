using PedaleaShop.Entities.Dtos;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PedaleaShop.WebApi.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;

namespace PedaleaShop.WebApi.Infrastructure.Repositories
{
    public class UsersRepository : Repository<AspNetUsers>, IUsersRepository
    {
        public UsersRepository(IConfiguration configuration): base(configuration)
        {
        }
    }
}
