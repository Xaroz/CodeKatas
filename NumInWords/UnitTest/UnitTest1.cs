using NumInWords;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void With0_Returnzero()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(0);
            Assert.AreEqual("zero", result);
        }

        [Test]
        public void With4_Returnfour()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(4);
            Assert.AreEqual("four", result);
        }

        [Test]
        public void With9_Returnnine()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(9);
            Assert.AreEqual("nine", result);
        }

        [Test]
        public void With10_Returnten()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(10);
            Assert.AreEqual("ten", result);
        }

        [Test]
        public void With15_Returnfifteen()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(15);
            Assert.AreEqual("fifteen", result);
        }

        [Test]
        public void With20_Returntwenty()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(20);
            Assert.AreEqual("twenty", result);
        }

        [Test]
        public void With22_Returntwentytwo()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(22);
            Assert.AreEqual("twenty two", result);
        }

        [Test]
        public void With300_Returnthreehundrer()
        {
            Converter convert = new Converter();
            string result = convert.ConvertToWords(300);
            Assert.AreEqual("three hundred", result);
        }
    }
}