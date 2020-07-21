using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Model.DTOs
{
    public class CheckoutRequest : ISnowflakeData
    {
        [Always]
        public int Id { get; set; }
    }
}
