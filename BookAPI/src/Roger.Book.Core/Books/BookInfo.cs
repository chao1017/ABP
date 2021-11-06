using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roger.Book.Books
{
    [Table("AppBooks")]
    public class BookInfo : Entity, IHasCreationTime
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