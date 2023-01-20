﻿using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Services.Interface.Repositories;
using PedaleaShop.WebApi.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PedaleaShop.WebApi.Infrastructure.Repository;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
using Microsoft.Extensions.Configuration;

namespace PedaleaShop.WebApi.Infrastructure.Repositories
{

    public class ShoppingCartsItemsRepository : Repository<ShoppingCartItemDto>, IShoppingCartsItemsRepository
    {

        public ShoppingCartsItemsRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }

}