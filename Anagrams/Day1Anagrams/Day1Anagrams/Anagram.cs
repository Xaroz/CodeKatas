using System;
using System.Collections.Generic;
using System.Text;


//WIP TO REDUCE 
namespace Day1Anagrams
{
    public class Anagram
    {
        public Dictionary<string, SortedSet<string>> IsAnagram(params string [] words)
        {
            List<string> list_words = new List<string>();
            foreach(string w in words)
            {
                list_words.Add(w);
            }
            Dictionary<string, SortedSet<string>> anagrams = new Dictionary<string, SortedSet<string>>();

            for(int i = 0; i < list_words.Count; i++)
            {
                SortedSet<string> this_anagram = new SortedSet<string>();
                this_anagram.Add(list_words[i]);

                char[] sorted_word = list_words[i].ToCharArray();
                Array.Sort(sorted_word);
                string comparison_word = "";
                foreach(char c in sorted_word)
                {
                    comparison_word += c;
                }

                for (int j = i + 1; j < list_words.Count; j++)
                {
                    char[] sorted_word2 = list_words[j].ToCharArray();
                    Array.Sort(sorted_word2);
                    string comparison_word2 = "";
                    foreach (char c in sorted_word2)
                    {
                        comparison_word2 += c;
                    }

                    if (comparison_word == comparison_word2)
                    {
                        this_anagram.Add(list_words[j]);
                        list_words.Remove(list_words[j]);
                        j--;
                    }                       
                }

                if(this_anagram.Count > 1)
                {
                    anagrams.Add(list_words[i], this_anagram);
                }
                
                
            }
            return anagrams;
        }
    }
}
