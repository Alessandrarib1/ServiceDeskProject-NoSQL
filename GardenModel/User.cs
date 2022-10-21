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
        private ObjectId objectId { get; set; }

        [BsonElement("employeeId")]
        private int employeeId { get; set; }

        [BsonElement("username")]
        private string username { get; set; }
        [BsonElement("password")]
        private string password { get; set; }

        [BsonElement("job")]

        private Job job { get; set; }


        public User(string username, string password, ObjectId objectId, int employeeId, Job job)
        {
            this.username = username;
            this.password = password;
            this.employeeId = employeeId;
            this.objectId = objectId;
            this.job = (Job)job;
        }

        public Job GetJob()
        {

            return job;
        }
        /*  [BsonElement("job")]
          private string jobTitle { get; set; }

          private Job job;*/

        /*  public User(string username, string password, ObjectId objectId, int employeeId, Job job)
          {
              this.username = username;
              this.password = password;
              this.employeeId = employeeId;
              this.objectId = objectId;
              this.job = GetJob();
          }*/
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
       /* public Job GetJob()
        {
            if (jobTitle == "Service Desk Employee")
            {
                return Job.ServiceDeskEmployee;
            }
            else 
                return Job.RegularEmployee;
        }*/

    }
}
