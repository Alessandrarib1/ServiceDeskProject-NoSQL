using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenDAL;
using GardenModel;
using MongoDB.Bson;

namespace GardenService
{
    class transferTicketService
    {
        public transferTicketDao transferDao = new transferTicketDao();

        public User GetUserByUsername(string username)
        {
            return transferDao.GetUserByUsername(username);
        }
    }
}
