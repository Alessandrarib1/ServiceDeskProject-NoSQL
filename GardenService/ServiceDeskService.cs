using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenDAL;
using GardenModel;

namespace GardenService
{
    public class ServiceDeskService
    {
        public ServiceDeskDao serviceDeskDao = new ServiceDeskDao();

        public List<Ticket> GetTickets()
        {
            return serviceDeskDao.GetTickets();
        }
    }
}
