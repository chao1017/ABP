using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
//using MyLibraryApi.person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibraryApi.books
{
    [Table("BooksInfo")]

    public class Book : Entity, IHasCreationTime
    {
        private const int DEFAULT_PRICE = 100;
        private int _price = DEFAULT_PRICE;

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
        [Required]
        public string LibraryCardID { get; set; }

        public BookState State { get; set; }

        /// <summary>
        /// 借閱人
        /// </summary>
        //[Required]
        //[ForeignKey(nameof(LibraryCardID))]
        //public Borrower BookBorrower { get; set; }

        [DefaultValue(DEFAULT_PRICE)]
        public int? Price { get { return _price; } set { _price = (int)value; } }
                
        public string? Author { get; set; }
        public DateTime CreationTime { get; set; }

        public Book()
        {
            CreationTime = Clock.Now;
        }

        public Book(string title)
        {
            BookTitle = title;
        }
    }
}
