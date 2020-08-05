using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Roger.Api1.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {
        /// <summary>
        /// Student's Name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        public int Age { get; set; }
    }
}
