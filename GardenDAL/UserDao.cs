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
    public class UserDao : BaseDao
    {
        public IMongoCollection<User> collectionOfUsers;

        public UserDao()
        {
            collectionOfUsers = db.GetCollection<User>("employees");
        }
        public List<User> GetUsers()
        {
            List<User> users = collectionOfUsers.AsQueryable().ToList<User>();
            return users;
        }
        public User GetUserByObjectId(ObjectId objectId)
        {
            User user = collectionOfUsers.Find(x => x.objectId == objectId).FirstOrDefault();
            return user;
        }

        public User VerifyLogin(String username, String password)
        {
            List<User> users = GetUsers();
            foreach(User user in users)
            {
                if(user.GetUsername() ==  username && user.GetPassword() == password)
                {
                    return user;
                }   
            }
            return null;
        }

        public void CreateUser(User user)
        {
            collectionOfUsers.InsertOne(user);
        }

        public void DeleteUser(ObjectId tempObjectId)
        {
            collectionOfUsers.DeleteOne(s => s.objectId == tempObjectId);
        }

        public void UpdateUser(ObjectId objectId, User user)
        {
            var updateDef = Builders<User>.Update.Set("name", user.GetName()).Set("password", user.GetPassword()).Set("job", user.GetJob()).Set("employeeId", user.GetEmployeeId());
            collectionOfUsers.UpdateOne(s => s.objectId == objectId, updateDef);
        }
    }
}
