using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text;
using GardenModel;


namespace GardenDAL
{
    public class BaseDao
    {
        public MongoClient client;
        public IMongoDatabase db;
        

        public BaseDao()
        {
            client = new MongoClient("mongodb+srv://Tudor:RGgOUrcD1s7He4aH@clusterprojectnosql.cxrymcj.mongodb.net/test");
            db = client.GetDatabase("gardenGroup");

        }
   



    }
}
