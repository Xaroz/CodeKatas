using System;
using System.Collections.Generic;

namespace _2019_05_21
{
    class Program
    {
        static string add(params string [] list)
        {
            int sum = 0;
            foreach(string number in list)
            {
                bool delimited = false;
                string delimiter = "";
                string new_number = "";
                foreach(char x in number)
                {
                    if (!delimited)
                    {
                        if (x == '\n')
                            delimited = true;
                        else
                            delimiter += x;
                    }
                    else
                        new_number += x;                  
                }
                int N = new_number.Length;
                if (N > 0)
                    if (new_number[N - 1] == ',' || new_number[N - 1] == '\n')
                        throw new Exception("Number expected but EOF found.");
                //30 minutes stopped here
                string[] numbers = new_number.Split(new char[] { ',', '\n' });              
                foreach(string x in numbers)
                {
                    if (string.IsNullOrEmpty(x))
                        continue;
                    int temp = Convert.ToInt32(x);
                    sum += temp;
                }
            }          
            string ans = Convert.ToString(sum);
            return ans;
        }

        static void Main(string[] args)
        {
            string test = "//;\n1;2";
            string test2 = "12,3,4,\n4";
            string ans = add(test, test2);
            Console.WriteLine(ans);
            Console.WriteLine("//sep\n");
            Console.Read();
        }
    }
}
