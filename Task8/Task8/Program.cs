using System;

namespace Task8
{
    class Program
    {
        static void Sqrt(string[] args)
        {
            Console.WriteLine("Введите целое  число n:");
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            double i;
            for (i=1;i<n;i++);
            {
                sum = sum + Math.Sqrt(i);

                Console.WriteLine(sum);
            }
            Console.ReadKey();
            ///Неверный ответ!!!
        }
        static void Gruppa ()
        {
            Console.WriteLine("Введите колличество студентов в 1ой группе ");
            int n = Convert.ToInt32(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var k = Console.ReadLine();
            var i=1;
            for (i = 1; i < n; i++);
            sum1 = sum1 + i;
            sum2 = sum2 + i;

            sum1 = sum1 / n;
            sum2 = sum2 / n;
        }
    }
}
