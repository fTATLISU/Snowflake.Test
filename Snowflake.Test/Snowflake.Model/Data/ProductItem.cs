using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Model.Data
{
    public class ProductItem
    {
        [Always]
        public int Id { get; set; }

        [Always]
        public string Name { get; set; }
    }
}
