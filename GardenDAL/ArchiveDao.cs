using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GardenDAL
{
    public class ArchiveDao : BaseDao
    {
        public IMongoCollection<Ticket> archiveCollection;

        public ArchiveDao() : base()
        {
            archiveCollection = db.GetCollection<Ticket>("archive");
        }

        public List<Ticket> GetAllArchives()
        {
            return archiveCollection.AsQueryable().ToList<Ticket>();
        }

        public void AddArchive(Ticket ticket)
        {
            archiveCollection.InsertOne(ticket);
        }

        public void DeleteArchive(Ticket ticket)
        {
            archiveCollection.DeleteOne(s => s == ticket);
        }
    }
}
