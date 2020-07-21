using Snowflake.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Model.DTOs
{
    public class AddProductToBasketRequest : ISnowflakeData
    {
        [Collection]
        [InnerObject]
        public List<ProductItem> Products { get; set; }

        [RandomGuid]
        public string ProductName { get; set; }

        [OnlyExistParameter(1, 2, 3, 4, 5, 6)]
        public int Quantity { get; set; }
    }
}
