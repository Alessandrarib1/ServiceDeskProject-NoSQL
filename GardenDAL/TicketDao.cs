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

        public Ticket GetTicket(ObjectId objectId)
        {
            Ticket ticket = collectionOfTickets.Find(x => x.objectId == objectId).FirstOrDefault();

            return ticket;
        }

        /*public Ticket GetTicket(ObjectId objectId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", objectId);
            var documents = collectionOfTickets.Find(filter);
        }*/

        public void CreateTicket(Ticket ticket)
        {
            collectionOfTickets.InsertOne(ticket);
        }

        public void DeleteTicket(ObjectId tempObjectId)
        {
            collectionOfTickets.DeleteOne(s => s.objectId == tempObjectId);
        }

        public void UpdateTicket(ObjectId ObjectId, Ticket Ticket)
        {
            var updateDef = Builders<Ticket>.Update.Set("employeeId", Ticket.employeeId).Set("category", Ticket.ticketCategory).Set("status", Ticket.ticketStatus).Set("priority", Ticket.ticketPriority).Set("description", Ticket.description);
            collectionOfTickets.UpdateOne(s => s.objectId == ObjectId, updateDef);
        }
    }
}
