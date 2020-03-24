using System;
using System.Collections.Generic;
using System.Text;
using Abp.Runtime.Validation;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace MyHouse.MyProject.Equipment.Dto
{
    public class CreateEquipment
    {
        [Required]
        public long EquipId { get; set; }
        public string EquipName { get; set; }

    }
}
