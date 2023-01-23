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

    public class UsersRepository : Repository<UserDto>, IUsersRepository
    {

        public UsersRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<DataTable> UpdateEntityQuantityAsync(string userDtoSp,string userName, UserDto cartItemQuantityUpdateDto)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@PaidItemsToadd",cartItemQuantityUpdateDto.TotalPaidProducts),
                new SqlParameter("@SeparatedItemsToadd",cartItemQuantityUpdateDto.TotalSeparatedProducts),


            };
            return await this.SqlConnectionManager(userDtoSp, sqlParameters);
        }
    }

}
