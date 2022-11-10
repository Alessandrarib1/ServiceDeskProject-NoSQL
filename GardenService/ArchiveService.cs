using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenDAL;
using GardenModel;
using MongoDB.Bson;
namespace GardenService
{
    public class ArchiveService
    {
        public ArchiveDao archiveDao = new ArchiveDao();

        public List<Ticket> GetAllArchives()
        {
            return archiveDao.GetAllArchives();
        }

        public void AddArchive(Ticket ticket)
        {
            archiveDao.AddArchive(ticket);
        }

        public void DeleteArchive(Ticket ticket)
        {
            archiveDao.DeleteArchive(ticket);
        }
    }
}
