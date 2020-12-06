using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryApi.books
{
    public enum BookState : byte
    { 
        CheckedOut = 0,
        Returned = 1
    }
}
