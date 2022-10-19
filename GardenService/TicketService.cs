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
    public class TicketService
    {
        public TicketDao ticketDao = new TicketDao();

        public List<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

        public List<Ticket> GetTicketsWithStatus(Status status)
        {
            return ticketDao.GetTicketsWithStatus(status);
        }

        public void CreateTicket(Ticket ticket)
        {
            ticketDao.CreateTicket(ticket);
        }

        public void DeleteTicket(ObjectId tempObjId)
        {
            ticketDao.DeleteTicket(tempObjId);
        }
    }
}
