using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            long sum = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                sum += n * n;
            Console.WriteLine("сумма равна", sum);
            Console.ReadKey();
        }
    }
}
