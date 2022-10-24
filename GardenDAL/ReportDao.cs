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
    class ReportDao : BaseDao
    {
        public IMongoCollection<Report> reportCollection;

        public ReportDao() : base()
        {
            reportCollection = db.GetCollection<Report>("reports");
        }

        public List<Report> GetAllReports()
        {
            return reportCollection.AsQueryable().ToList<Report>();
        }

        public List<Report> GetAllReportsOfUser(User user)
        {
            return reportCollection.Find(x => x.employeeId == user.GetEmployeeId()).ToList<Report>();
        }

        public void CreateReport(Report report)
        {
            reportCollection.InsertOne(report);
        }

        public void DeleteReport(Report report)
        {
            reportCollection.DeleteOne(s => s == report);
        }

        public void UpdateReport(Report report)
        {
            var updateParams = Builders<Report>.Update.Set("employeeId", report.employeeId).Set("description", report.description);
            reportCollection.UpdateOne(s => s == report, updateParams);
        }
    }
}
