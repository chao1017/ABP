using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roger.Book.Books.Dtos
{
    public class BookListDto : EntityDto, IHasCreationTime
    {
        /// <summary>
        /// 書名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 作者
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