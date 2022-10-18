using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenDAL;
using GardenModel;

namespace GardenService
{
    public class TicketService
    {
        public TicketDao serviceDeskDao = new TicketDao();

        public List<Ticket> GetTickets()
        {
            return serviceDeskDao.GetTickets();
        }
    }
}
