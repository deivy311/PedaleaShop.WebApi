﻿using PedaleaShop.Entities.Dtos;
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

namespace PedaleaShop.WebApi.Infrastructure.Repositories
{

    public class ProductsRepository : Repository<ProductsDto>, IProductsRepository
    {

        public ProductsRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }

}
