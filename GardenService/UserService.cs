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
        public User ValidateLogin(String username, String password)
        {
            return userDao.VerifyLogin(username, password);
        }
        public User GetUserById(ObjectId objectId)
        {
            return userDao.GetUserByObjectId(objectId);
        }

    }
}
