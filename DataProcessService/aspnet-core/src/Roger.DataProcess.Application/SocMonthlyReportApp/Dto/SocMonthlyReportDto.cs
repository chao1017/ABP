using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace Roger.DataProcess.SocMonthlyReportApp.Dto
{
    public class SocMonthlyReportDto : EntityDto<int>
    { 
        public int EventSN { get; set; }
        public string DevID { get; set; }
        public DateTime LastUpdDateTime { get; set; } 
        public string SrcIpPort { get; set; }
        public string VirusName { get; set; }
        public string VirusUrl { get; set; }
        public int VirusCount { get; set; }
        public bool SolutionType { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string RptYearMonth { get; set; }
        public string Version { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
        public string CustomerName { get; set; }

    }
}
