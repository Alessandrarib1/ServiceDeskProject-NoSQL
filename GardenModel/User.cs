using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenModel
{
    public class User
    {
        [BsonElement("name")]
        private string name { get; set; }

        [BsonId]
        private ObjectId objectId { get; set; }

        [BsonElement("employeeId")]
        private int employeeId { get; set; }

        [BsonElement("username")]
        private string username { get; set; }
        [BsonElement("password")]
        private string password { get; set; }

        [BsonElement("job")]

        private Job job { get; set; }

        [BsonElement("salt")]
        private string salt;




        public User(string username, string password, ObjectId objectId, int employeeId, Job job, string salt)
        {
            this.username = username;
            this.password = password;
            this.employeeId = employeeId;
            this.objectId = objectId;
            this.job = (Job)job;
            this.salt = salt;

        }

        public Job GetJob()
        {

            return job;
        }

        public int GetEmployeeId()
        {
            return employeeId;
        }
        public ObjectId GetObjectId()
        {
            return objectId;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }

    }
}
