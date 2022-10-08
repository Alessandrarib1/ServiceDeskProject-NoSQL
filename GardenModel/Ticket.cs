using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenModel
{
    public class Ticket
    {
        private int employeeNumber { get; set; }
        private Category category { get; set; }
        public Status status { get; set; }
        public string description { get; set; }

        public Ticket(int employeeNuber, Category category, Status status, string description)
        {
            this.employeeNumber = employeeNumber;
            this.category = category;
            this.status = status;
            this.description = description;
        }
    }
}
