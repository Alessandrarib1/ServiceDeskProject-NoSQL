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
    public class TicketDao : BaseDao
    {
        public IMongoCollection<Ticket> collectionOfTickets;

        public TicketDao()
        {
            collectionOfTickets = db.GetCollection<Ticket>("Tickets");
        }

        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = collectionOfTickets.AsQueryable().ToList<Ticket>();
            return tickets;
        }
        
        public List<Ticket> GetTicketsWithStatus(Status status)
        {
            List<Ticket> tickets = collectionOfTickets.Find(x => x.ticketStatus == status).ToList<Ticket>();
            return tickets;
        }

        public void CreateTicket(Ticket ticket)
        {
            collectionOfTickets.InsertOne(ticket);
            return;
        }
    }
}
