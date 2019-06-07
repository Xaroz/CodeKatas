using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeral
{
    public class Transform
    {
        string result = "";
        Dictionary<int,char> dict = new Dictionary<int,char>();
        public Transform()
        {
            this.FillDictionary();
        }

        private void FillDictionary()
        {
            dict.Add(1, 'I');
            dict.Add(5, 'V');
            dict.Add(10, 'X');
            dict.Add(50, 'L');
        }

        private void ConvertWithI(int number)
        {
            for (int i = 0; i < number; i++)
            {
                result += dict[1];
            }
            return;
        }

        private void ConvertWithV(int number)
        {
            if (number == 4)
            {
                result += "IV";
            }
            else
            {
                result += dict[5];
                number -= 5;
                ToRoman(number);
            }
            return;
        }

        private void ConvertWithX(int number)
        {
            if(number == 9)
            {
                result += "IX";
            }
            else
            {
                result += dict[10];
                number -= 10;
                ToRoman(number);
            }
            return;
        }

        private void ConvertWithL(int number)
        {
            if(number >= 40 && number <= 49)
            {
                result += "XL";
                number -= 40;
               
            }
            else
            {
                result += dict[50];
                number -= 50;
            }
            ToRoman(number);
            return;
        }

        public string ToRoman(int number)
        {
            if (number <= 3)
            {
                ConvertWithI(number);
            }
            else if (number > 3 && number < 9)
            {
                ConvertWithV(number);
            }
            else if(number>= 9 && number <= 39)
            {
                ConvertWithX(number);
            }
            else if(number >= 40 && number <= 89)
            {
                ConvertWithL(number);
            }
            return result;
        }       
    }
}
