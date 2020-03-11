using System;
using System.Collections.Generic;
using System.Text;

namespace EdvanceC
{
    public class Book : Library
    {
        int quantity;
        public string Type { get; set; }
        public string Name { get; set; }

        internal int PageQuantity
        {
            get
            {
                return quantity;
            }
            set
            {
                PageQuantity = quantity;
            }
        }

        public void BookStorage()
        {
            Console.WriteLine("Наша библиотека");
        }
        public int BookValue(Book a)
        {
            return a.PageQuantity;
        }
        static int count;
        public static void BookCount()
        {
            {
                count++;
            }
            Console.WriteLine("Количество объектов:" + count);
        }
        public override void ShowLibrary()
        {
            base.ShowLibrary();
            Console.WriteLine("У меня большая библиотека.");
        }
        public override void MyLibrary()
        {
            Console.WriteLine("Люблю читать книги");
        }

    }
}
