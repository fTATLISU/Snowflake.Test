using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Model.DTOs
{
    public class GetOrderDetailRequest : ISnowflakeData
    {
        [Never]
        public int OrderId { get; set; }
    }
}
