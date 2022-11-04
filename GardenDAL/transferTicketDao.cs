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
    public class transferTicketDao : BaseDao
    {
        public IMongoCollection<User> userCollection;

        public transferTicketDao()
        {
            userCollection = db.GetCollection<User>("employees");
        }

        public User GetUserByUsername(string username)
        {
            return (User) userCollection.Find(x => x.GetUsername() == username);
        }
    }
}
