using System;

namespace WordWrapDay1
{
    public class Wrapper
    {
        public string Wrap(string word, int column)
        {
            if (column >= word.Length)
                return word;

            string wrappedWord = "";
            int counter = 0;

            foreach(char c in word)
            {
                if(counter == column)
                {
                    wrappedWord += "\n" + c;
                    counter = 1;
                }
                else
                {
                    wrappedWord += c;
                    counter++;
                }
            }
            return wrappedWord;
        }
    }
}
