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
            if (categoryName == "Login")
                ticketCategory = Category.Login;
            else if (categoryName == "Hardware")
                ticketCategory = Category.Hardware;
            else if (categoryName == "Software")
                ticketCategory = Category.Software;
            else if (categoryName == "Security")
                ticketCategory = Category.Security;
        }

        public void SetStatus()
        {
            if (statusName == "Open")
                ticketStatus = Status.Open;
            else if (statusName == "Closed")
                ticketStatus = Status.Closed;
            else if (statusName == "Unresolved")
                ticketStatus = Status.Unresolved;
        }

        public void SetPriority()
        {
            if (priorityName == "Low")
                ticketPriority = Priority.Low;
            else if (priorityName == "Medium")
                ticketPriority = Priority.Medium;
            else if (priorityName == "High")
                ticketPriority = Priority.High;
            else if (priorityName == "Critical")
                ticketPriority = Priority.Critical;
        }

        public Ticket (int employeeId, string categoryName, string statusName, string priorityName, string description)
        {
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
