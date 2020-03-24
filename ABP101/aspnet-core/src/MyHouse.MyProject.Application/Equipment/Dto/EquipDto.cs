using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHouse.MyProject.Equipment.Dto
{
    public class EquipDto : EntityDto<string>
    { 
        public long EquipId { get; set; }
        public string EquipName { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
