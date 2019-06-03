using System;

namespace NumInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter convert = new Converter();
            string res = convert.Transform(9099);
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
