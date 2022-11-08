using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenModel
{
    public class Ticket //IDEC
    {
        [BsonId]
        public ObjectId objectId { get; set; }

        [BsonElement ("employeeId")]
        public int employeeId { get; set; }

        [BsonElement ("category")]
        public Category ticketCategory { get; set; }

        [BsonElement ("status")]
        public Status ticketStatus { get; set; }

        [BsonElement ("priority")]
        public Priority ticketPriority { get; set; }

        [BsonElement ("description")]
        public string description { get; set; }


        public Ticket (int employeeId, int category, int status, int priority, string description)
        {
            this.employeeId = employeeId;
            this.ticketCategory = (Category)category;
            this.ticketStatus = (Status)status;
            this.ticketPriority = (Priority)priority;
            this.description = description;

        }
    }
}
