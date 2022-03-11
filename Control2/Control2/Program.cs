using System;

namespace Control2
{
    class Program
    {
        static double Nod(double m, double n)
        {
            if (n < 0)
                n = -n;
            if (m < 0)
                m = -m;
            while (n > 0)
            {
                double t = n;
                n = m % n;
                m = t;
            }
            return m;
        }
        static double Nok(double m, double n)
        {
            return Math.Abs(m * n) / Nod(m, n);
        }
        ///static void Func( double n)
       /// {
         ///   int sum = 0;
         ///   double A = (1 / n) * sum;
      ///  }
        static void Main()
        {
            int m, n;
            Console.Write("Введите первое число:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("НОК={0}", Nok(m, n));
            Console.ReadKey();
        }
    }
    

}

