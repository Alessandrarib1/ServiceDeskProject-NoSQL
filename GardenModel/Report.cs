using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenModel
{
    public class Report
    {
        private int employeeNumber { get; set; }
        public string description { get; set; }

        public Report(int employeeNumber, string description)
        {
            this.employeeNumber = employeeNumber;
            this.description = description;
        }
    }
}
