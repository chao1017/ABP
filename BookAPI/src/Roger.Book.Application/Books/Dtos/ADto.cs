using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roger.Book.Books.Dtos
{
    public class ADto : EntityDto
    {
        public string Name { get; set; }
    }
}