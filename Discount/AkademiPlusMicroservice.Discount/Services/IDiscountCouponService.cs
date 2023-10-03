﻿using AkademiPlusMicroservice.Discount.DTOs;
using AkademiPlusMicroService.Shared.Dtos;

namespace AkademiPlusMicroservice.Discount.Services
{
    public interface IDiscountCouponService
    {
        Task<Response<List<ResultDiscountCouponDtos>>> GetListAll();
        Task<Response<NoContent>> CreateDiscountCoupon(CreateDiscountCouponDtos createDiscountCouponDtos);
        Task<Response<NoContent>> UpdateDiscountCoupon(UpdateDiscountCouponDtos updateDiscountCouponDtos);
        Task<Response<NoContent>> DeleteDiscountCoupon(int id);

    }
}