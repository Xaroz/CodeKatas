using System;
using System.Collections.Generic;
using System.Text;

namespace NumInWords
{
    public class Converter
    {
        string result = "";
        Dictionary<int, string> words = new Dictionary<int, string>();
        public Converter()
        {
            FillDictionary();
        }

        private void FillDictionary()
        {
            words.Add(0, "zero");
            words.Add(1, "one");
            words.Add(2, "two");
            words.Add(3, "three");
            words.Add(4, "four");
            words.Add(5, "five");
            words.Add(6, "six");
            words.Add(7, "seven");
            words.Add(8, "eight");
            words.Add(9, "nine");

            words.Add(10, "ten");
            words.Add(11, "eleven");
            words.Add(12, "twelve");
            words.Add(13, "thirteen");
            words.Add(14, "fourteen");
            words.Add(15, "fifteen");
            words.Add(16, "sixteen");
            words.Add(17, "seventeen");
            words.Add(18, "eighteen");
            words.Add(19, "nineteen");

            words.Add(20, "twenty");
            words.Add(30, "thirty");
            words.Add(40, "fourty");
            words.Add(50, "fifty");
            words.Add(60, "sixty");          
            words.Add(70, "seventy");
            words.Add(80, "eighty");
            words.Add(90, "ninety");

        }

        private void TwoDigits(int number)
        {
            //example 21
            int remainder = (number % 10);
            int tmp = number - remainder;
            result += words[tmp];
            result += " ";
            number -= tmp;
            Transform(number);
        }

        private void ThreeDigits(int number)
        {
            int front_number = number / 100;
            result += words[front_number];
            result += " hundred";
            int remainder = number - (front_number * 100);
            if (remainder == 0)
            {
                return;
            }
            else
            {
                result += " and ";
                Transform(remainder);
            }
        }

        public string Transform(int number)
        {         
            if (words.ContainsKey(number))
            {
               return result += words[number];
            }
            else
            {
                string x = Convert.ToString(number);
                if (x.Length == 2)
                {
                    TwoDigits(number);
                }
                else if (x.Length == 3)
                {
                    ThreeDigits(number);
                }
                
            }
            return result;
            
        }
    }
}
