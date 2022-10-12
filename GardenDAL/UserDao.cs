using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenModel;
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


    }
}
