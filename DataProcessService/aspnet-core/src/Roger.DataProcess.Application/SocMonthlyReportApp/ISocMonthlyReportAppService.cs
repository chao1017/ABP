using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Roger.DataProcess.SocMonthlyReportApp.Dto;

namespace Roger.DataProcess.SocMonthlyReportApp
{
    public interface ISocMonthlyReportAppService : IApplicationService
    {
        GetSocMonthlyReportOutput GetSocMonthlyReports(GetSocMonthlyReportInput input);
        void UpdateReport(SocMonthlyReportInput input);
        void CreateReport(SocMonthlyReportInput input);
    }
}
