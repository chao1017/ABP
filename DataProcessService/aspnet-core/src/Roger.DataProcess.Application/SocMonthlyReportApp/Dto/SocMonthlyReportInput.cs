using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System.ComponentModel.DataAnnotations;
using Roger.DataProcess.Entities;


namespace Roger.DataProcess.SocMonthlyReportApp.Dto
{
    [AutoMap(typeof(MonthlyReport))]
    public class SocMonthlyReportInput : EntityDto<Guid>
    {
        public int EventSN { get; set; }
        public string DevID { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string SrcIpPort { get; set; }
        public string VirusName { get; set; }
        public string AddUser { get; set; }
    }

    public class GetSocMonthlyReportInput
    {
        public string DevID { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string AddUser { get; set; }
        public string UpdateUser { get; set; }
    }

    public class CreateSocMonthlyReportInput
    { 
        [Required]
        public string AddUser { get; set; }
        public string DevID { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(DevID))
            {
                DevID = "TestDevID" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            }
        }
    }
}
