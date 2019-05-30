using System;
using System.Collections.Generic;
using System.Text;

namespace NumInWords
{
    public class Converter
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
        public Converter()
        {
            this.FillDictionary();
            this.FillDictionary2();
        }
        private void FillDictionary()
        {
            dictionary.Add(0, "zero");
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            dictionary.Add(6, "six");
            dictionary.Add(7, "seven");
            dictionary.Add(8, "eight");
            dictionary.Add(9, "nine");
            dictionary.Add(10, "ten");
            dictionary.Add(11, "eleven");
            dictionary.Add(12, "twelve");
            dictionary.Add(13, "thirteen");
            dictionary.Add(14, "fourteen");
            dictionary.Add(15, "fifteen");
            dictionary.Add(16, "sixteen");
            dictionary.Add(17, "seventeen");
            dictionary.Add(18, "eightteen");
            dictionary.Add(19, "nineteen");
            
        }
        private void FillDictionary2()
        {
            dictionary2.Add(2, "twenty");
            dictionary2.Add(3, "thirty");
            dictionary2.Add(4, "foutyr");
            dictionary2.Add(5, "fifty");
            dictionary2.Add(6, "sixty");
            dictionary2.Add(7, "seventy");
            dictionary2.Add(8, "eighty");
            dictionary2.Add(9, "ninety");
            
        }

        public string ConvertToWords(int number)
        {
            List<string> result_holder = new List<string>();
            string holder = Convert.ToString(number);
            int number_length = holder.Length;
            string result = "";

            if (number < 20)
            {
                result = dictionary[number];
            }
            else
            {
                bool first = true;
                while (number_length > 0 && number != 0)
                {
                    if (number_length == 4)
                    {
                        int x = number / 1000;
                        result += dictionary[x];
                        result += " thousand";
                        number -= (x * 1000);
                        number_length--;
                    }
                    else if (number_length == 3)
                    {
                        int x = number / 100;
                        result += dictionary[x];
                        result += " hundred";
                        number -= (x * 100);
                        number_length--;
                    }
                    else if (number_length == 2 && number >= 20)
                    {
                        int x = number / 10;
                        result += dictionary2[x];                      
                        number -= (x * 10);
                        number_length--;
                    }
                    else if (number_length == 2 && number < 20 && number >= 10)
                    {
                        result += dictionary[number];
                        break;
                    }
                    else
                    {
                        result += " ";
                        result += dictionary[number];
                        break;
                    }
                }
            }
            return result;
            
        }
    }
}
