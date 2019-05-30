using System;
using System.Collections.Generic;

namespace _2019_05_20
{
    public class Day3
    {
        static string add(params string [] list_numbers)
        {
            int N = list_numbers.Length;
  

            List<string> numbers = new List<string>();
            
            for (int i = 0; i < list_numbers.Length; i++)
            {
                int last = list_numbers[i].Length;
                if (last != 0)
                {
                    char x = list_numbers[i][last - 1];
                    if (x == ',' || x == '\n')
                        throw new Exception("Number expected but EOF found");
                }              
                string[] temp = list_numbers[i].Split(new char[] { ',','\n' });
                foreach (string y in temp)
                    numbers.Add(y);
            }
            
            int sum = 0;
            int convert = 0;
            foreach(string x in numbers)
            {
                if (string.IsNullOrEmpty(x))
                    continue;
                else
                {
                    convert = System.Convert.ToInt32(x);
                    sum += convert;
                }
            }
            string res = System.Convert.ToString(sum);
            return res;
        }
        static void Main(string[] args)
        {

            string testing = "";
            string testing1 = "3\n,3,3,";
            string testing2 = "1";
            Console.WriteLine(add(testing,testing1,testing2));
            Console.Read();
        }
    }
}
