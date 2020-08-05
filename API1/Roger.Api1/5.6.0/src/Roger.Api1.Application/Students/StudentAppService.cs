using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Roger.Api1.Students.Dto;

namespace Roger.Api1.Students
{
    [Produces("application/json")]
    public class StudentAppService
    {
        private readonly StudentsManager _studentsManager;

        public StudentAppService(StudentsManager studentsManager) {
            _studentsManager = studentsManager;
        }

        public void CreateStudent()
        { 
            
        }
    }
}
