using System;

namespace Day2Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();
            anagram.GetAnagrams("kinship", "sinks");
        }
    }
}
