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
        public ObjectId objectId { get; set; }

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




        public User(string username, string name, string password, int employeeId, Job job) //string salt
        {
            this.username = username;
            this.name = name;
            this.password = password;
            this.employeeId = employeeId;
            this.job = (Job)job;
            //this.salt = salt;

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
        public void SetObjectId(ObjectId objectId)
        {
            this.objectId = objectId;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetName()
        {
            return name;
        }
    }
}
