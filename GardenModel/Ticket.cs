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
        private ObjectId objectId { get; set; }

        [BsonElement ("employeeId")]
        private int employeeId { get; set; }

        [BsonElement ("category")]
        private string categoryName { get; set; }
        private Category category { get; set; }

        [BsonElement ("status")]
        private string statusName { get; set; }
        public Status ticketStatus { get; set; }

        [BsonElement ("priority")]
        private string priorityName { get; set; }
        private Priority priority { get; set; }

        [BsonElement ("description")]
        private string description { get; set; }

        public Ticket(ObjectId objectId, int employeeId, Category category, Status status, Priority priority, string description)
        {
            this.objectId = objectId;
            this.employeeId = employeeId;
            this.category = GetCategory();
            this.ticketStatus = GetStatus();
            this.priority = GetPriority();
            this.description = description;
        }

        public ObjectId GetObjectId()
        {
            return objectId;
        }
        public int GetEmployeeId()
        {
            return employeeId;
        }
        public Category GetCategory()
        {
            if (categoryName == "login")
                return Category.Login;
            else if (categoryName == "hardware")
                return Category.Hardware;
            else if (categoryName == "software")
                return Category.Software;
            else
                return Category.Security;
        }
        public Status GetStatus()
        {
            if (statusName == "open")
                return Status.Open;
            else if (statusName == "closed")
                return Status.Closed;
            else
                return Status.Unresolved;
        }

        public Priority GetPriority()
        {
            if (priorityName == "low")
                return Priority.Low;
            else if (priorityName == "medium")
                return Priority.Medium;
            else if (priorityName == "high")
                return Priority.High;
            else
                return Priority.Critical;
        }
        public string GetDescription()
        {
            return description;
        }
    }
}
