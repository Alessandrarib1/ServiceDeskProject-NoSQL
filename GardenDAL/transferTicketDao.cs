using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GardenDAL
{
    //Additional function made by Tudor Matei Nosca (678549)
    public class transferTicketDao : BaseDao
    {
        public IMongoCollection<User> userCollection;

        public transferTicketDao()
        {
            userCollection = db.GetCollection<User>("employees");
        }

        public User GetUserByUsername(string username)
        {
            var filter = Builders<User>.Filter.Eq("username", username);

            return userCollection.Find(filter).FirstOrDefault();
        }
    }
}
