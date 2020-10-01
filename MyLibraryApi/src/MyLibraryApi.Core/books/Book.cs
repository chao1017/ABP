using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using MyLibraryApi.person;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibraryApi.books
{

    public class Book : Entity, IHasCreationTime
    {
        /// <summary>
        /// 書名
        /// </summary>
        public string Title { get; set; }

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

        /// <summary>
        /// 借閱人
        /// </summary>
        [Required]
        [ForeignKey(nameof(LibraryCardID))]
        public Borrower BookBorrower { get; set; }
        
        
        public DateTime CreationTime { get; set; }

        public Book()
        {
            CreationTime = Clock.Now;
        }

        public Book(string title)
        {
            Title = title;
        }
    }
}
