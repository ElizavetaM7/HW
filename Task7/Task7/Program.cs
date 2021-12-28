using System;

namespace Task7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(f(x));
            Console.ReadKey();
        }
        static double f(double x)
        {
            double f;
            if (x < -3)
            {
                f = 0;
                return f;
            }
            else
            {
                if (x > -1)
                {
                    f = 2;                    
                }
                else
                {
                    f = 1;
                }
                return f;
            }
        }
    }
}
