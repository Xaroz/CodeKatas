using NUnit.Framework;
using Day2;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WithEmptyRack_ReturnEmptyList()
        {
            Sort actual = new Sort();

            List<int> expected = new List<int>();

            Assert.AreEqual(expected, actual.rack);
        }

        [Test]
        public void WithOneBall_ReturnListWithOneBall()
        {
            Sort actual = new Sort();
            actual.Add(20);

            List<int> expected = new List<int>();
            expected.Add(20);

            Assert.AreEqual(expected, actual.rack);
        }

        [Test]
        public void WithTwoBall_ReturnOrderedListWithTwoBall()
        {
            Sort actual = new Sort();
            actual.Add(20);
            actual.Add(10);

            List<int> expected = new List<int>();
            expected.Add(10);
            expected.Add(20);

            Assert.AreEqual(expected, actual.rack);
        }

        [Test]
        public void WithThreeBall_ReturnOrderedListWithThreeBall()
        {
            Sort actual = new Sort();
            actual.Add(20);
            actual.Add(10);
            actual.Add(30);

            List<int> expected = new List<int>();
            expected.Add(10);
            expected.Add(20);
            expected.Add(30);

            Assert.AreEqual(expected, actual.rack);
        }

        [Test]
        public void GivenString_ReturnsListSorted()
        {
            Sort sortString = new Sort();
            string text = "When not studying nuclear physics, Bambi likes to play beach volleyball.";


            string actual = sortString.SortText(text);

            string expected = "aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy";

            Assert.AreEqual(expected, actual);
        }
    }
}