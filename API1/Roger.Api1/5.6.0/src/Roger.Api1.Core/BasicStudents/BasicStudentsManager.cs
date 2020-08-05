using Abp.Authorization.Users;
using Abp.Dependency;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roger.Api1.BasicStudents
{
    public class BasicStudentsManager<TUser> : IDomainService, ITransientDependency
        where TUser:AbpUser<TUser>
    { 
    
    }
}
