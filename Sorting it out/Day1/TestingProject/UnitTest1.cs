using Day1;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WithZeroBalls_ReturnEmptyArray()
        {
            SortingClass rack = new SortingClass();

            int[] expected = new int []{  };
            Assert.AreEqual(expected, rack.balls);
        }

        [Test]
        public void With1Balls_Return1ElementInArray()
        {
            SortingClass rack = new SortingClass();
            rack.Add(20);
            int[] expected = new int[] {20};
            Assert.AreEqual(expected, rack.balls);
        }

        [Test]
        public void With2Balls_Return2SortedElementInArray()
        {
            SortingClass rack = new SortingClass();
            rack.Add(20);
            rack.Add(10);
            int[] expected = new int[] { 10,20 };
            Assert.AreEqual(expected, rack.balls);
        }
        [Test]
        public void With3Balls_Return3SortedElementInArray()
        {
            SortingClass rack = new SortingClass();
            rack.Add(20);
            rack.Add(10);
            rack.Add(30);
            int[] expected = new int[] { 10, 20, 30 };
            Assert.AreEqual(expected, rack.balls);
        }

        [Test]
        public void GivenText_ReturnSortedCharacters()
        {
            SortingClass text = new SortingClass();
            string s = "When not studying nuclear physics, Bambi likes to play beach volleyball.";

            string result = text.SortString(s);

            string expected = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenStringWithNumbers_ReturnSortedCharactersWithoutNumbers()
        {
            SortingClass text = new SortingClass();
            string s = "Life is like 0";

            string result = text.SortString(s);

            string expected = "eefiiiklls";
            Assert.AreEqual(expected, result);
        }
    }
}