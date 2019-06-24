using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class SortingClass
    {
        public int[] balls = new int[] { };

        public void Add(int v)
        {
            int[] newArray = new int[balls.Length + 1];
            for(int i = 0; i < balls.Length; i++)
            {
                newArray[i] = balls[i];
            }
            newArray[newArray.Length - 1] = v;
            for (int i = 0; i < newArray.Length; i++)
            {
                for(int j = i + 1; j < newArray.Length; j++)
                {
                    if (newArray[j] < newArray[i])
                    {
                        int temp = newArray[i];
                        newArray[i] = newArray[j];
                        newArray[j] = temp;
                    }                       
                }
            }
            balls = newArray;
        }

        public string SortString(string s)
        {
            s = s.ToLower();
            int[] letters = new int[26];
            foreach(char c in s)
            {
                int value = c - 'a';
                if(value >= 0 && value < letters.Length)
                {
                    letters[value]++;
                }
            }
            string result = "";
            for(int i = 0; i < letters.Length; i++)
            {
                int value = i + 'a';
                char c = (char)value;
                while (letters[i] > 0)
                {
                    result += c;
                    letters[i]--;
                }
            }
            return result;
        }
    }
}
