using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace latin_russian_dict
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово:");
            using (StreamReader sr = new StreamReader("dict.txt"));
            //StreamReader.ReadLine("dict.txt");


            //var word = new SortedDictionary<string, int>();
            //using (var file = new StreamReader("dict.txt", Encoding.Default))
            //{
            //    while(!file.EndOfStream)
            //    {
            //        var key = file.ReadLine().Split('\t')[1];

                //        if (word.ContainsKey(key))
                //            word[key]++;
                //        else
                //            word[key] = 1;
                //    }
                //}

                //foreach (var translate in word.Keys)
                //    Console.WriteLine($"{translate} - {word[translate]}");

                //Console.ReadKey();
        }
    }
}
