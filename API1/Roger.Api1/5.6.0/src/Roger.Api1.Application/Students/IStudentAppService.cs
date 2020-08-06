using Abp.Application.Services;
using Roger.Api1.Students.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roger.Api1.Students
{
    public interface IStudentAppService : IApplicationService
    {
        void CreateStudent(CreateStudentDto input);
    }
}
