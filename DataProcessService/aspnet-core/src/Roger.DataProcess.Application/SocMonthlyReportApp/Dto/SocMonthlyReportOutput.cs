using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Roger.DataProcess.Entities;

namespace Roger.DataProcess.SocMonthlyReportApp.Dto
{
    [AutoMap(typeof(MonthlyReport))]
    public class SocMonthlyReportOutput : EntityDto<Guid>
    { 
        public string DevID { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
    }

    public class GetSocMonthlyReportOutput
    { 
        public List<SocMonthlyReportDto> SocMonthlyReports { get; set; }
    }
}
