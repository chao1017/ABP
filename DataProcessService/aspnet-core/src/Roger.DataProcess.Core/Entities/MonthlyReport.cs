using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Roger.DataProcess.Entities
{
    public class MonthlyReport : Entity<int>, IHasCreationTime
    {
        public virtual int EventSN { get; set; }
        public virtual string DevID { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual string SrcIpPort { get; set; }
        public virtual string VirusName { get; set; }
        public virtual string VirusUrl { get; set; }
        public int VirusCount { get; set; }

        public MonthlyReport()
        {
            CreationTime = DateTime.Now;
        }
    }
}
