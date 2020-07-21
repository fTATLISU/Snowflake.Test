using System;
using System.Collections.Generic;
using System.Text;

namespace Snowflake.Test.Services
{
    public class DatabaseService
    {
        public List<int> GetStoreIdsFromDatabase()
        {
            List<int> ids = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // get data from database

            return ids;
        }
    }
}
