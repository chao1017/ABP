using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Roger.Api1.Students.Dto
{
    [AutoMapFrom(typeof(Student))]
    public class StudentDto : Entity
    {
        [Required]
        public int id { get; set; }

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
