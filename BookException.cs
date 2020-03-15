using System;
using System.Collections.Generic;
using System.Text;

namespace EdvanceC
{
    public class BookException:Exception
    {
        public BookException(string message)
            : base (message)
        { }

    }
}
