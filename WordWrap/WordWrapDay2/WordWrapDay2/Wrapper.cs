using System;
using System.Collections.Generic;
using System.Text;

namespace WordWrapDay2
{
    public class Wrapper
    {
        public string Wrap(string word, int column)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            string result = "";
            int counter = 0;
            foreach(char c in word)
            {
                if (counter == column)
                {
                    result += "\n";
                    if (c != ' ')
                    {
                        result += c;
                        counter = 1;
                    }
                    else
                        counter = 0;                   
                }
                else if (counter == column - 1)
                {
                    if (c != ' ')
                        result += c;
                    counter++;
                }
                else
                {
                    result += c;
                    counter++;
                }
                                                 
            }
            return result;
        }
    }
}
