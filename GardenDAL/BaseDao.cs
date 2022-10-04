using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace GardenDAL
{
    class BaseDao
    {
        public BaseDao()
        {
            MongoClient client = new MongoClient("mongodb+srv://Tudor:RGgOUrcD1s7He4aH@clusterprojectnosql.cxrymcj.mongodb.net/test");
            IMongoDatabase db = client.GetDatabase("gardenGroup");
        }
    }
}
