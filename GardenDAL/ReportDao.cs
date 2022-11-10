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
    public class ReportDao : BaseDao
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
            reportCollection.DeleteOne(s => s.objectId == report.objectId);
        }

        public void UpdateReport(Report reportToChange, Report newReport)
        {
            var updateParams = Builders<Report>.Update.Set("employeeId", newReport.employeeId).Set("description", newReport.description);
            reportCollection.UpdateOne(s => s == reportToChange, updateParams);
        }

        public Report GetReportById(ObjectId objectId) //idec
        {
            Report report = reportCollection.Find(x => x.objectId == objectId).FirstOrDefault();

            return report;
        }
    }
}
