using GardenModel;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenDAL
{
    public class SortTicketDao : BaseDao
    {
        public IMongoCollection<Ticket> collectionOfTickets;
        public SortTicketDao()
        {
            collectionOfTickets = db.GetCollection<Ticket>("Tickets");
        }
        public List<Ticket> SortTicketByPriority()
        {
            var ticketFilter = Builders<Ticket>.Filter.Empty;
            var sortedTicket = collectionOfTickets.Find(ticketFilter).Sort("{priority:-1}").ToList();
            List<Ticket> sortedTicketsList = sortedTicket;
            return sortedTicketsList;
        }



    }
}
