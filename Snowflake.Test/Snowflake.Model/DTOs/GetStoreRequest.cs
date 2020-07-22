using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Model.DTOs
{
    public class GetStoreRequest : ISnowflakeData
    {
        [ParameterViaMethod(
            assemblyName: "Snowflake.Test", 
            namespaceName: "Snowflake.Test.Services", 
            className: "DatabaseService",
            methodName: "GetStoreIdsFromDatabase", 
            cache: false)]
        public int Id { get; set; }
    }
}
