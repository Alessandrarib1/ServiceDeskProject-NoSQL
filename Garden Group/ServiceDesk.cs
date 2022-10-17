using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenModel;
using GardenService;

namespace Garden_Group
{
    public partial class ServiceDesk : Form
    {
        public ServiceDeskService serviceDeskService = new ServiceDeskService();
        List<Ticket> tickets;

        public ServiceDesk()
        {
            InitializeComponent();
            tickets = serviceDeskService.GetTickets();

        }

        private void ServiceDesk_Load()
        {
            
        }
    }
}
