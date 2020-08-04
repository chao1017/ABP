using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Roger.Api1.Students
{
    [Table("Students")]
    public class Student : Entity
    { 
        [Required]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Column("Age")]
        public int Age { get; set; }
    }
}
