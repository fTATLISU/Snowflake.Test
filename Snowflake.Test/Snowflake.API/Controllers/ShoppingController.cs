using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Snowflake.Model.DTOs;

namespace Snowflake.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Checkout([FromBody] CheckoutRequest request)
        {
            // some logic ...
            await Task.Delay(1000);

            return Ok(request);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToBasket([FromBody] AddProductToBasketRequest request)
        {
            // some logic ...
            await Task.Delay(1000);

            return Ok(request);
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket([FromQuery] GetBasketRequest request)
        {
            // some logic ...
            await Task.Delay(1000);

            return Ok(request);
        }

        [HttpGet]
        public async Task<IActionResult> GetStore([FromQuery] GetStoreRequest request)
        {
            // some logic ...
            await Task.Delay(1000);

            return Ok(request);
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderDetail([FromQuery] GetOrderDetailRequest request)
        {
            // some logic ...
            await Task.Delay(1000);

            return Ok(request);
        }
    }
}
