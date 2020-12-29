using MyLibraryApi.books;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryApi.LibraryTask.Dto
{
    public class GetAllBooksInput
    {
        public BookState? State { get; set; }
    }
}
