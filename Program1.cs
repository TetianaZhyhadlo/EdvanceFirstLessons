using System;

namespace EdvanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book a = new Book();
                a.Name = "Как построить идеальный мир без зависти, лжи, злости и ненависти.";
                
            }
            catch (BookException except)
            {
                Console.WriteLine("Ошибка: " + except.Message);
            }
            Console.Read();
        }
    }
}
