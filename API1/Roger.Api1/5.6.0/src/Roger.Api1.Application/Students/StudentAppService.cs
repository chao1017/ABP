using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.ObjectMapping;
using Microsoft.AspNetCore.Mvc;
using Roger.Api1.Students.Dto;


namespace Roger.Api1.Students
{
    [Produces("application/json")]
    public class StudentAppService
    {
        private readonly StudentsManager _studentsManager;
        private readonly IObjectMapper _objectMapper;

        public StudentAppService(StudentsManager studentsManager, IObjectMapper objectMapper) {
            _studentsManager = studentsManager;
            _objectMapper = objectMapper;
        }

        public async Task<Student> CreateAsync(CreateStudentDto input)
        {
            var student = _objectMapper.Map<Student>(input);
            return await _studentsManager.CreateAsync(student);
        }
    }
}
