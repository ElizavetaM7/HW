using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            m++;
            int a = (2 * m - 1) / (2 * m + 1);
            int[] num = new int[n];

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
