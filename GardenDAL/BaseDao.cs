using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace GardenDAL
{
    public class BaseDao
    {
        static MongoClient client = new MongoClient("mongodb+srv://Tudor:RGgOUrcD1s7He4aH@clusterprojectnosql.cxrymcj.mongodb.net/test");
        static IMongoDatabase db = client.GetDatabase("gardenGroup");
    }
}
