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
    //Additional function made by Tudor Matei Nosca (678549)
    public class transferTicketService
    {
        public transferTicketDao transferDao = new transferTicketDao();

        public User GetUserByUsername(string username)
        {
            return transferDao.GetUserByUsername(username);
        }
    }
}
