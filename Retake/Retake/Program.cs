using System;

namespace Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите посещаемость студента:");
            var p = Console.ReadLine();
            int count = 0;
            int kol = 0;
            var pr = "ННН";

            for (int i = 0; i < p.Length; i++)
            {
                
                if (p[i] == 'О')
                {
                    count++;
                }

            }
            if (count > 1)
            { }
            else
            {
                kol++; /// +СТУДЕНТ С БОНУСОМ
            }
            Console.WriteLine(kol);







        }


    }
}
