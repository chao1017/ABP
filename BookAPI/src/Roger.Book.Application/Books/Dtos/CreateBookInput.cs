using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roger.Book.Books.Dtos
{
    [AutoMapTo(typeof(BookInfo))]
    public class CreateBookInput : EntityDto
    {
        /// <summary>
        /// 書名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 作者姓名
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}