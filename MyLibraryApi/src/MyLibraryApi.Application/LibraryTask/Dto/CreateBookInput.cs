using Abp.AutoMapper;
using MyLibraryApi.books;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyLibraryApi.LibraryTask.Dto
{
    [AutoMapTo(typeof(Book))]
    public class CreateBookInput
    {
        [Required]
        public string BookID { get; set; }
        public string Author { get; set; }
        public string BorrowerID{ get; set; }
        public string BorrowerName { get; set; }
    }
}
