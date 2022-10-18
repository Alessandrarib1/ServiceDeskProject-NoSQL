using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenModel
{
    public class Ticket
    {
        [BsonId]
        public ObjectId objectId { get; set; }

        [BsonElement ("employeeId")]
        public int employeeId { get; set; }

        [BsonElement ("category")]
        public string categoryName { get; set; }
        public Category ticketCategory { get; set; }

        [BsonElement ("status")]
        public string statusName { get; set; }
        public Status ticketStatus { get; set; }

        [BsonElement ("priority")]
        public string priorityName { get; set; }
        public Priority ticketPriority { get; set; }

        [BsonElement ("description")]
        public string description { get; set; }


        public void SetCategory()
        {
            if (categoryName == "login")
                ticketCategory = Category.Login;
            else if (categoryName == "hardware")
                ticketCategory = Category.Hardware;
            else if (categoryName == "software")
                ticketCategory = Category.Software;
            else if (categoryName == "security")
                ticketCategory = Category.Security;
        }

        public void SetStatus()
        {
            if (statusName == "open")
                ticketStatus = Status.Open;
            else if (statusName == "closed")
                ticketStatus = Status.Closed;
            else if (statusName == "unresolved")
                ticketStatus = Status.Unresolved;
        }

        public void SetPriority()
        {
            if (priorityName == "low")
                ticketPriority = Priority.Low;
            else if (priorityName == "medium")
                ticketPriority = Priority.Medium;
            else if (priorityName == "high")
                ticketPriority = Priority.High;
            else if (priorityName == "critical")
                ticketPriority = Priority.Critical;
        }

        public Ticket (ObjectId objectId, int employeeId, string categoryName, string statusName, string priorityName, string description)
        {
            this.objectId = objectId;
            this.employeeId = employeeId;
            this.categoryName = categoryName;
            this.statusName = statusName;
            this.priorityName = priorityName;
            this.description = description;

            SetCategory();
            SetPriority();
            SetStatus();
        }
    }
}
