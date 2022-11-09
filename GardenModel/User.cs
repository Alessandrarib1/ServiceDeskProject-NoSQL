using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenModel
{
    public class User
    {
        [BsonElement("firstname")]
        private string firstname { get; set; }
        [BsonElement("lastname")]
        private string lastname { get; set; }
        [BsonElement("email")]
        private string email { get; set; }
        [BsonElement("location")]
        private Location location { get; set; }

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

        public User(string username, string firstname, string lastname, string email, Location location, string password, string salt,  int employeeId, Job job) 
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.location = location;
            this.email = email;
            this.password = password;
            this.employeeId = employeeId;
            this.job = job;
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
        public string GetFirstName()
        {
            return firstname;
        }
        public string GetLaststName()
        {
            return lastname;
        }
        public string GetEmail()
        {
            return email;
        }
        public Location GetLocation()
        {
            return location;
        }
        public string GetSalt()
        {
            return salt;
        }
       
    }
}
