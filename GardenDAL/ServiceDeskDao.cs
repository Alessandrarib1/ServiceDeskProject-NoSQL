using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenModel;
using MongoDB.Driver;

namespace GardenDAL
{
    public class ServiceDeskDao : BaseDao
    {
        public IMongoCollection<Ticket> collectionOfTickets;

        public ServiceDeskDao()
        {
            collectionOfTickets = db.GetCollection<Ticket>("Tickets");
        }

        public List<Ticket> GetTickets()
        {
            List<Ticket> tickets = collectionOfTickets.AsQueryable().ToList<Ticket>();
            return tickets;
        }
    }
}
