using System;
using System.Collections.Generic;

namespace Day2
{
    public class Sort
    {
        public List<int> rack = new List<int>();

        public void Add(int v)
        {
            rack.Add(v);
            for(int i = 0; i < rack.Count; i++)
            {
                for(int j = i + 1; j < rack.Count; j++)
                {
                    if(rack[j] < rack[i])
                    {
                        int tmp = rack[j];
                        rack[j] = rack[i];
                        rack[i] = tmp;
                    }
                }
            }
        }

        public string SortText(string text)
        {
            string result = "";
            text = text.ToLower();

            for(int i = 0; i < 26; i++)
            {
                for(int j = 0; j < text.Length; j++)
                {
                    int value = i + 'a';
                    char c = (char)value;
                    if (c == text[j])
                        result += c;
                }
            }
            return result;
        }
    }
}
