using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.ObjectMapping;
using Microsoft.AspNetCore.Mvc;
using Roger.Api1.Students.Dto;


namespace Roger.Api1.Students
{
    public class StudentAppService : IStudentAppService
    {
        private readonly StudentsManager _studentsManager;
        private readonly IObjectMapper _objectMapper;

        public StudentAppService(StudentsManager studentsManager, IObjectMapper objectMapper) {
            _studentsManager = studentsManager;
            _objectMapper = objectMapper;
        }

        /// <summary>
        /// 建立學生資料
        /// </summary>
        /// <param name="input"></param>
        public void CreateStudent(CreateStudentDto input)
        {
            var student = _objectMapper.Map<Student>(input);
            _studentsManager.CreateAsync(student);
        }
    }
}
