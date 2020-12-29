using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using MyLibraryApi.books;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryApi.LibraryTask.Dto
{
    [AutoMapFrom(typeof(Book))]
    public class BooksListDto : EntityDto, IHasCreationTime
    {
        public string BookTitle { get; set; }

        /// <summary>
        /// 借閱日
        /// </summary>
        public string BorrowDate { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// 借閱證號
        /// </summary>
        public string LibraryCardID { get; set; }

        public int? Price { get; set; }

        public string? Author { get; set; }
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 借閱狀態
        /// </summary>
        public BookState State { get; set; }
    }
}
