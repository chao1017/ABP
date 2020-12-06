using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibraryApi.Person
{
    [Table("BorrowerInfo")]
    public class Borrower : Entity
    {
        /// <summary>
        /// 借閱證號
        /// </summary>
        [Required]
        public string LibraryCardID { get; set; }

        /// <summary>
        /// 借閱人姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 借閱人地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 借閱人年齡
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 借閱人電話
        /// </summary>
        public string PhoneNo { get; set; }

    }
}
