using AkademiPlusMicroservice.Discount.DTOs;
using AkademiPlusMicroservice.Discount.Models;
using AutoMapper;
using System.Runtime;

namespace AkademiPlusMicroservice.Discount.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<DiscountCoupon, ResultDiscountCouponDtos>().ReverseMap();
            CreateMap<DiscountCoupon, CreateDiscountCouponDtos>().ReverseMap();
            CreateMap<DiscountCoupon, UpdateDiscountCouponDtos>().ReverseMap();
        }
    }
}