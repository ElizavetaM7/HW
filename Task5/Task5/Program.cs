using System;

namespace СтрокиИСимволы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для транслитерации");
            string str = Console.ReadLine();
            Console.WriteLine(Trans(str));
            Console.WriteLine("Решение 5.2 " + Kinematograf());

        }
        static string Trans(string str)
        {
            str = str.ToUpper();
            str = str.Replace("А", "A");
            str = str.Replace("Б", "B");
            str = str.Replace("В", "V");
            str = str.Replace("Г", "G");
            str = str.Replace("Д", "D");
            str = str.Replace("Е", "E");
            str = str.Replace("Ё", "E");
            str = str.Replace("Ж", "ZH");
            str = str.Replace("З", "Z");
            str = str.Replace("И", "I");
            str = str.Replace("Й", "I*");
            str = str.Replace("К", "K");
            str = str.Replace("Л", "L");
            str = str.Replace("М", "M");
            str = str.Replace("Н", "N");
            str = str.Replace("О", "O");
            str = str.Replace("П", "P");
            str = str.Replace("Р", "R");
            str = str.Replace("С", "S");
            str = str.Replace("Т", "T");
            str = str.Replace("У", "U");
            str = str.Replace("Ф", "F");
            str = str.Replace("Х", "KH");
            str = str.Replace("Ц", "TS");
            str = str.Replace("Ч", "CH");
            str = str.Replace("Ш", "SH");
            str = str.Replace("Щ", "SHCH");
            str = str.Replace("Ъ", "IE");
            str = str.Replace("Ы", "Y");
            str = str.Replace("Ь", "");
            str = str.Replace("Э", "E");
            str = str.Replace("Ю", "IU");
            str = str.Replace("Я", "IA");

            return str;
        }
        static string Kinematograf()
        {
            string str = "кинематограф";
            char[] sRev = str.ToCharArray();
            Array.Reverse(sRev);
            string str2 = new string(sRev);
            return str + " - " + str.Substring(8, 4) + str[7] + str.Substring(4, 2) + str[2] + "  " + str[4] + str[3] + str[6] + str[9] + str[7];
        }
    }
}

