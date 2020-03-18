using System;

namespace AdvanceSecondLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер масива:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение для масива:");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            int[,,] myarray = new int[a, b, c];
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    for (int n = 0; n < c; n++)
                    {
                        Random rnd = new Random();
                        myarray[i, k, n] = rnd.Next(1, maxNumber + 1);
                    }
                }
            }
            ShowArray(myarray);
            FirstMax(myarray);
            SecondMax(myarray);
            int[,,] sortedArray = BubleSort(myarray);
            ShowArray(sortedArray);

            static void FirstMax(int[,,] z)
            {
                int max = 0;
                for (int i = 0; i < z.GetLength(0); i++)
                {
                    for (int k = 0; k < z.GetLength(1); k++)
                    {
                        for (int n = 0; n < z.GetLength(2); n++)
                        {
                            if (z[i, k, n] > max)
                            {
                                max = z[i, k, n];
                            }
                        }
                    }
                }
                Console.WriteLine("Первое по велечине значение для масива:" + max);
            }
            static void SecondMax(int[,,] z)
            {
                int max1 = 0;
                int max = 0;
                for (int i = 0; i < z.GetLength(0); i++)
                {
                    for (int k = 0; k < z.GetLength(1); k++)
                    {
                        for (int n = 0; n < z.GetLength(2); n++)
                        {
                            if (z[i, k, n] > max)
                            {
                                max1 = max;
                                max = z[i, k, n];
                            }
                            if (z[i, k, n] < max && z[i, k, n] > max1)
                            {
                                max1 = z[i, k, n];
                            }
                        }
                    }
                }
                Console.WriteLine("Второе по велечине значение для масива:" + max1);
            }
            static void ShowArray(int[,,] z)
            {
                for (int i = 0; i < z.GetLength(0); i++)
                {
                    for (int k = 0; k < z.GetLength(1); k++)
                    {
                        for (int n = 0; n < z.GetLength(2); n++)
                        {
                            Console.Write(z[i, k, n] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
            static int[,,] BubleSort(int[,,] a)
            {
                int s;
                for (int i = 0; i < a.GetLength(0) - 1; i++)
                {
                    for (int k = 0; k < a.GetLength(1) - 1; k++)
                    {
                        for (int n = 0; n < a.GetLength(2) - 1; n++)
                        {
                            if (a[i, k, n] > a[i, k, n + 1])
                            {
                                s = a[i, k, n + 1];
                                a[i, k, n + 1] = a[i, k, n];
                                a[i, k, n] = s;
                            }
                        }
                    }
                }
                return a;
            }
        }
              
    }
}
