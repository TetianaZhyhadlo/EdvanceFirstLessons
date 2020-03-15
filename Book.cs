using System;
using System.Collections.Generic;
using System.Text;

namespace EdvanceC
{
    sealed class Book : Library, IBookInterest, IEBook1
    {
        int quantity;
        string direction;
        int bookPrice;
        string name;
        string bookAuthor;
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public string Author
        {
            get
            {
                return bookAuthor;
            }
            set 
            {
                Author = bookAuthor;
            }
        }
        public string Type { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name.Length > 50)
                    throw new BookException("Название книги должно содержать менее 50 символов.");
                else
                    Name = name;
            }
        }
        internal int BookCost
        {
            get 
            {
                return bookPrice;
            }
            set
            {
                BookCost = bookPrice;
            }
        }

        public int PageQuantity
        {
            get
            {
                return quantity;
            }
            
        }

        public string InterestType
        {
            get
            {
                return direction;
            }
            set
            {
                InterestType = direction;
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

        public void BookPrice()
        {
            Book a = new Book();
            Console.WriteLine(a.BookCost);

        }
        public static bool Equals(Book a,Book b)
        {
            bool same = false;
            if (a == b)
            {
                same = true;
            }
            return same;
        }
        public static void ToString(int a)
        {
            Console.WriteLine(a);
        }

        void IEBook1.BookPrice()
        {
            
            Console.WriteLine("Сегодня всё бесплатно!");

        }

    }

}
