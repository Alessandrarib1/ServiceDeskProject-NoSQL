using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenModel
{
    public class User
    {
        [BsonElement("name")]
        private string name { get; set; }

        [BsonId]
        private ObjectId employeeNumber { get; set; }

        [BsonElement("username")]
        private string username { get; set; }
        [BsonElement("password")]
        private string password { get; set; }
        [BsonElement("job")]
        private string jobTitle { get; set; }

        private Job job;

        public User(string username, string password, ObjectId employeeNumber, Job job)
        {
            this.username = username;
            this.password = password;
            this.employeeNumber = employeeNumber;
            this.job = GetJob();
        }
        public ObjectId GetEmployeeNumber()
        {
            return employeeNumber;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public Job GetJob()
        {
            if (jobTitle == "Service Desk Employee")
            {
                return Job.ServiceDeskEmployee;
            }
            else 
                return Job.RegularEmployee;
        }

    }
}
