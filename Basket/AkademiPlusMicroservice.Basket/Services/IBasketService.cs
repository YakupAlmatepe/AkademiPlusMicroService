using AkademiPlusMicroservice.Basket.DTOs;
using AkademiPlusMicroService.Sharedd.DTOs;

namespace AkademiPlusMicroservice.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> DeleteBasket(string userId);
        
    }
}
