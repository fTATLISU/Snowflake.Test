using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Model.DTOs
{
    public class GetBasketRequest : ISnowflakeData
    {
        [Always]
        public int SessionId { get; set; }
    }
}
