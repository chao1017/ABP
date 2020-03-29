using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using MyHouse.MyProject.Authorization;
using MyHouse.MyProject.Authorization.Roles;
using MyHouse.MyProject.Authorization.Users;
using MyHouse.MyProject.Editions;
using MyHouse.MyProject.Equipment.Dto;
using Microsoft.AspNetCore.Identity;

namespace MyHouse.MyProject.Equipment
{
    public class EquipService : IEquipService
    {
        public void CreateEquipment(CreateEquipmentDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}
