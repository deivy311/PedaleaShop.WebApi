using System;
using System.Collections.Generic;
using System.Text;

namespace PedaleaShop.WebApi.Infrastructure.Context
{
    public interface IFactoryDb
    {
        ApplicationDbContext GetContext();
    }
}
