﻿using ShopsRUs.Basket.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketDto> GetBasket(Guid UserId);
        Task<bool> SaveOrUpdate(BasketDto basketDto);
        Task<bool> Delete(Guid UserId);
    }
}
