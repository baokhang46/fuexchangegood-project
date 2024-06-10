﻿using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IReportRepository
    {
        Report GetReportById(int reportId);
        List<Report> GetAllReports();
        void CreateReport(Report report);
        void UpdateReport(Report report);
        void DeactivateReport(int reportId);
        void ActivateReport(int reportId);


    }
}