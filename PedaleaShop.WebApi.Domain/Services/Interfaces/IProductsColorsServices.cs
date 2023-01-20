﻿using PedaleaShop.WebApi.Domain.Entities;
using PedaleaShop.WebApi.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
namespace PedaleaShop.WebApi.Domain.Services.Interface
{
    public interface IProductsColorsServices
    {
        Task<IEnumerable<ProductColorDto>> GetEntities();
        Task<ProductColorDto> GetEntity(int Id);
    }
}