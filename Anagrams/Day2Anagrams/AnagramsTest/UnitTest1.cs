using Day2Anagrams;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void With_Two_Words_Kinship_Pinkish_Return_Anagram()
        {
            string word1 = "kinship";
            string word2 = "pinkish";

            List<char> sorted_word = new List<char>();
            foreach(char c in word1)
            {
                sorted_word.Add(c);
            }
            sorted_word.Sort();
            string res = "";
            foreach(char c in sorted_word)
            {
                res += c;
            }

            Dictionary<string, SortedSet<string>> anagrams = 
                new Dictionary<string, SortedSet<string>>();
            anagrams.Add(res, new SortedSet<string>());
            anagrams[res].Add(word1);
            anagrams[res].Add(word2);

            Anagram anagram_function = new Anagram();
            Dictionary<string, SortedSet<string>> result =  anagram_function.GetAnagrams(word1, word2);

            Assert.AreEqual(anagrams, result);
            
        }

       [Test]
        public void With_Two_Words_Kinship_Sinks_Return_NoAnagram()
        {
            string word1 = "kinship";
            string word2 = "sinks";
         
            Dictionary<string, SortedSet<string>> anagrams =
                new Dictionary<string, SortedSet<string>>();
 
            Anagram anagram_function = new Anagram();
            Dictionary<string, SortedSet<string>> result = anagram_function.GetAnagrams(word1, word2);

            Assert.AreEqual(anagrams, result);

        }

        [Test]
        public void With_4_Words_That_Are_Anagrams()
        {
            string word1 = "enlist";
            string word2 = "inlets";
            string word3 = "listen";
            string word4 = "silent";

            List<char> sorted_word = new List<char>();
            foreach (char c in word1)
            {
                sorted_word.Add(c);
            }
            sorted_word.Sort();
            string res = "";
            foreach (char c in sorted_word)
            {
                res += c;
            }

            Dictionary<string, SortedSet<string>> anagrams =
                new Dictionary<string, SortedSet<string>>();
            anagrams.Add(res, new SortedSet<string>());
            anagrams[res].Add(word1);
            anagrams[res].Add(word2);
            anagrams[res].Add(word3);
            anagrams[res].Add(word4);

            Anagram anagram_function = new Anagram();
            Dictionary<string, SortedSet<string>> result = anagram_function.GetAnagrams(word1, word2,word3, word4);

            Assert.AreEqual(anagrams, result);

        }
    }
}