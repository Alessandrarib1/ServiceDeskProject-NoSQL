﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenModel;

namespace Garden_Group
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new ServiceDesk(new User("ignacio", "ignacio", "eusebio", "ignacio.deeusebio.cobo@gmail.com", Location.Amsterdam, "whatever", "000", 6, Job.ServiceDeskEmployee)));
        }
    }
}
