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
    public class ReportService
    {
        public ReportDao reportDao = new ReportDao();

        public List<Report> GetAllReports()
        {
            return reportDao.GetAllReports();
        }

        public List<Report> GetAllReportsOfUser(User user)
        {
            return reportDao.GetAllReportsOfUser(user);
        }

        public void CreateReport(Report report)
        {
            reportDao.CreateReport(report);
        }

        public void DeleteReport(Report report)
        {
            reportDao.DeleteReport(report);
        }

        public void UpdateReport(Report reportToChange, Report newReport)
        {
            reportDao.UpdateReport(reportToChange, newReport);
        }

        public Report GetReportById(ObjectId objectId)
        {
           return reportDao.GetReportById(objectId);
        }
    }
}
