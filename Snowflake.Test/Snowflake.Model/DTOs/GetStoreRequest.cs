using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Model.DTOs
{
    public class GetStoreRequest : ISnowflakeData
    {
        [ParameterViaMethod("Snowflake.Test", "Snowflake.Test.Services", "DatabaseService", "GetStoreIdsFromDatabase", false)]
        public int Id { get; set; }
    }
}
