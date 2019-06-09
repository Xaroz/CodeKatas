using System;
using System.Collections.Generic;
using System.Text;

namespace Roman_Numeral
{
    public class Transform
    {
        // List<int> cardinal_numbers = new List<int>();
        int[] cardinal_numbers = new int[]
        {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        string[] numeral_numbers = new string[] 
        {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX",
            "V", "IV", "I"};

        string roman_numeral = "";

        public string Convert(int number)
        {
            for(int i = 0; i < cardinal_numbers.Length; i++)
            {
                while(number >= cardinal_numbers[i])
                {
                    roman_numeral += numeral_numbers[i];
                    number -= cardinal_numbers[i];
                }
            }
            return roman_numeral;
        }
    }
}
