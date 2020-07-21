using Snowflake.Model.Data;
using Snowflake.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Test.Tasks
{
    public class SnowflakeTasks
    {
        public static void CreateSnowflakeTasks()
        {
            ISnowflakeTask getBasketTask = new GetSnowflakeTask<GetBasketRequest>
            {
                Url = "http://api/api/Shopping/getbasket",
                RequestParameters = new GetBasketRequest()
            };

            TaskManager.AddTask(getBasketTask);

            ISnowflakeTask getStoreTask = new GetSnowflakeTask<GetStoreRequest>
            {
                Url = "http://api/api/Shopping/getstore",
                RequestParameters = new GetStoreRequest()
            };

            TaskManager.AddTask(getStoreTask);

            //Sequence

            ISnowflakeTask checkoutTask = new PostSnowflakeTask<AddProductToBasketRequest>
            {
                Url = "http://api/api/Shopping/addProductToBasket",
                RequestParameters = new AddProductToBasketRequest
                { 
                    Products = new List<ProductItem> 
                    { 
                        new ProductItem(), 
                        new ProductItem() 
                    }
                }
            };

            checkoutTask.Add((httpResponseMessage) =>
            {
                // httpResponseMessage --> This is response which belong to previous request(addProductToBasket)

                return new PostSnowflakeTask<CheckoutRequest>
                {
                    Url = "http://api/api/Shopping/checkout",
                    RequestParameters = new CheckoutRequest(),
                    Headers = new Dictionary<string, string> { { "Bearer", "111111111111111111111" } }
                };
            });

            checkoutTask.Add((httpResponseMessage) =>
            {
                // httpResponseMessage --> This is response which belong to previous request(addProductToBasket)

                var orderId = 1; // It gets from httpResponseMessage.Content
                return new GetSnowflakeTask<GetOrderDetailRequest>
                {
                    Url = "http://api/api/Shopping/GetOrderDetail",
                    RequestParameters = new GetOrderDetailRequest { OrderId = orderId }
                };
            });

            TaskManager.AddTask(checkoutTask);

            //Sequence
        }
    }
}
