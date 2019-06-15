using Day1Anagrams;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void OneAnagram_With_Kinship_Pinkish()
        {
            string word = "kinship";
            string word2 = "pinkish";
            Anagram anagram = new Anagram();

            Dictionary<string, SortedSet<string>> list_of_anagrams = new Dictionary<string, SortedSet<string>>();
            SortedSet<string> words = new SortedSet<string>();
            words.Add(word);
            words.Add(word2);

            list_of_anagrams.Add(word,words);

            Dictionary<string,SortedSet<string>> result = anagram.IsAnagram(word, word2);

            Assert.AreEqual(list_of_anagrams, result);
        }

        [Test]
        public void NoAnagram_With_Kinship_Dart()
        {
            string word = "kinship";
            string word2 = "dart";
            Anagram anagram = new Anagram();

            Dictionary<string, SortedSet<string>> list_of_anagrams = new Dictionary<string, SortedSet<string>>();
            SortedSet<string> words = new SortedSet<string>();


            Dictionary<string, SortedSet<string>> result = anagram.IsAnagram(word, word2);

            Assert.AreEqual(list_of_anagrams, result);
        }

        [Test]
        public void With4_Anagrams()
        {
            string word1 = "enlist";
            string word2 = "inlets";
            string word3 = "listen";
            string word4 = "silent";

            Anagram anagram = new Anagram();

            Dictionary<string, SortedSet<string>> list_of_anagrams = new Dictionary<string, SortedSet<string>>();
            SortedSet<string> words = new SortedSet<string>();
            words.Add(word1);
            words.Add(word2);
            words.Add(word3);
            words.Add(word4);

            list_of_anagrams.Add(word1, words);

            Dictionary<string, SortedSet<string>> result = anagram.IsAnagram(word1, word2, word3, word4);

            Assert.AreEqual(list_of_anagrams, result);
        }
    }
}