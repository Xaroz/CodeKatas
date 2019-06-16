using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Anagrams
{
    public class Anagram
    {        
        public Dictionary<string, SortedSet<string>> GetAnagrams(params string [] word_list)
        {
            List<string> words = new List<string>();
            foreach(string word in word_list)
            {
                words.Add(word);
            }
            Dictionary<string, SortedSet<string>> anagrams = FindAnagrams(words);
            return anagrams;
        }

        private Dictionary<string, SortedSet<string>> FindAnagrams(List<string> words)
        {
            Dictionary<string, SortedSet<string>> anagrams = new Dictionary<string, SortedSet<string>>();
            foreach(string w in words)
            {
                List<char> sorted_word = new List<char>();
                foreach (char c in w)
                {
                    sorted_word.Add(c);
                }
                sorted_word.Sort();
                string res = "";
                foreach (char c in sorted_word)
                {
                    res += c;
                }
                if (!anagrams.ContainsKey(res))
                {
                    anagrams.Add(res, new SortedSet<string>());
                    anagrams[res].Add(w);
                }
                else if (anagrams.ContainsKey(res))
                {
                    anagrams[res].Add(w);
                }
            }
            Dictionary<string, SortedSet<string>> result = CheckIfAnagrams(anagrams);
            return result;
        }

        private Dictionary<string, SortedSet<string>> CheckIfAnagrams(Dictionary<string, SortedSet<string>> anagrams)
        {
            Dictionary<string, SortedSet<string>> result = new Dictionary<string, SortedSet<string>>();
            foreach(string key in anagrams.Keys)
            {
                if (anagrams[key].Count > 1)
                    result.Add(key, anagrams[key]);
            }
            return result;
        }
    }
}
