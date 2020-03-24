using System;
using System.Collections.Generic;
using System.Text;
using MyHouse.MyProject.Equipment.Dto;
using Abp.Application.Services;

namespace MyHouse.MyProject.Equipment
{
    public interface IEquipService : IApplicationService
    {
        void CreateEquipment(CreateEquipment input);
    }
}
