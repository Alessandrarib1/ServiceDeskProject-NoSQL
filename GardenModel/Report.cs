using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenModel
{
    public class Report
    {
        [BsonId]
        public ObjectId objectId { get; private set; }

        [BsonElement ("employeeId")]
        public int employeeId { get; private set; }

        [BsonElement ("description")]
        public string description { get; private set; }

        public Report(int employeeId, string description)
        {
            this.employeeId = employeeId;
            this.description = description;
        }
    }
}
