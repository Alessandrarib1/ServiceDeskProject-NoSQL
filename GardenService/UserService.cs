using GardenDAL;
using GardenModel;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenService
{
    public class UserService
    {
        public UserDao userDao = new UserDao();

        public List<User> GetUsers()
        {
            return userDao.GetUsers();
        }

        public User ValidateLogin(String username, String password)
        {
            return userDao.VerifyLogin(username, password);
        }
        public User GetUserByObjectId(ObjectId objectId)
        {
            return userDao.GetUserByObjectId(objectId);
        }

        public void CreateUser(User user)
        {
            userDao.CreateUser(user);
        }

        public void UpdateUser(ObjectId objectId, User user)
        {
            userDao.UpdateUser(objectId, user);
        }

        public void DeleteUser(ObjectId objectId)
        {
            userDao.DeleteUser(objectId);
        }
    }
}
