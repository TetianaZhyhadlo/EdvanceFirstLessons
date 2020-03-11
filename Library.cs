using System;
using System.Collections.Generic;
using System.Text;

namespace EdvanceC
{
    public abstract class Library
    {
        public abstract void MyLibrary();

        public virtual void ShowLibrary()
        {
            Console.WriteLine("У меня большая библиотека.");
        }

    }
}
