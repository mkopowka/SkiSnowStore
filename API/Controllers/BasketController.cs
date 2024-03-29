using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        public readonly IBasketRepository _basket;
        private readonly IMapper _mapper;
        public BasketController(IBasketRepository basket, IMapper mapper)
        {
            _mapper = mapper;
            _basket = basket;
            
        }
        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
        {
            var basket = await _basket.GetBasketAsync(id);

            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerBasket = _mapper.Map<CustomerBasketDto,CustomerBasket>(basket);
            var updatedBasket = await _basket.UpdateBasketAsynnc(customerBasket);

            return Ok(updatedBasket);
        }

        [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _basket.DeleteBasketAsync(id);
        }
    }
}