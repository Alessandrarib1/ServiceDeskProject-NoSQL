using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenModel
{
    public class User
    {
        private string username { get; set; }
        private string password { get; set; }
        private int employeeNumber { get; set; }
        private Job job { get; set; }

        public User(string username, string password, int employeeNumber, Job job)
        {
            this.username = username;
            this.password = password;
            this.employeeNumber = employeeNumber;
            this.job = job;
        }
    }
}
