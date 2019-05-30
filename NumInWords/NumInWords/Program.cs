using System;

namespace NumInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int test = 21 / 10;
            Console.WriteLine(test);
            Console.Read();*/

            Converter convert = new Converter();
            string result = convert.ConvertToWords(20);
            Console.Read();
        }
    }
}
