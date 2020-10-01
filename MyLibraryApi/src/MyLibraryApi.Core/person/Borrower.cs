using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibraryApi.person
{
    [Table("BorrowerInfo")]
    public class Borrower : Entity, IHasCreationTime
    {
        /// <summary>
        /// 借閱證號
        /// </summary>
        [Required]
        public string LibraryCardID { get; set; }

        /// <summary>
        /// 借閱人身份證字號
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 借閱人姓
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 借閱人名
        /// </summary>
        public string FirstName { get; set; }

        public DateTime CreationTime { get; set; }
        
        public Borrower()
        {
            CreationTime = Clock.Now;
        }

        public Borrower(string last_name, string first_name)
        {
            LastName = last_name;
            FirstName = first_name;
        }
    }
}
