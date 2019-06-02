using NumInWords;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void With0_Returnszero()
        {
            Converter convert = new Converter();
            int number = 0;
            string result = convert.Transform(number);
            Assert.AreEqual("zero", result);
        }

        [Test]
        public void With2_Returnstwo()
        {
            Converter convert = new Converter();
            int number = 2;
            string result = convert.Transform(number);
            Assert.AreEqual("two", result);
        }

        [Test]
        public void With9_Returnsnine()
        {
            Converter convert = new Converter();
            int number = 9;
            string result = convert.Transform(number);
            Assert.AreEqual("nine", result);
        }

        [Test]
        public void With10_Returnsten()
        {
            Converter convert = new Converter();
            int number = 10;
            string result = convert.Transform(number);
            Assert.AreEqual("ten", result);
        }

        [Test]
        public void With15_Returnsfifteen()
        {
            Converter convert = new Converter();
            int number = 15;
            string result = convert.Transform(number);
            Assert.AreEqual("fifteen", result);
        }

        [Test]
        public void With20_Returnstwenty()
        {
            Converter convert = new Converter();
            int number = 20;
            string result = convert.Transform(number);
            Assert.AreEqual("twenty", result);
        }

        [Test]
        public void With30_Returnstthirty()
        {
            Converter convert = new Converter();
            int number = 30;
            string result = convert.Transform(number);
            Assert.AreEqual("thirty", result);
        }

        [Test]
        public void With60_Returnstsixty()
        {
            Converter convert = new Converter();
            int number = 60;
            string result = convert.Transform(number);
            Assert.AreEqual("sixty", result);
        }

        [Test]
        public void With21_Returnstwenty_one()
        {
            Converter convert = new Converter();
            int number = 21;
            string result = convert.Transform(number);
            Assert.AreEqual("twenty one", result);
        }

        [Test]
        public void With85_Returnseighty_five()
        {
            Converter convert = new Converter();
            int number = 85;
            string result = convert.Transform(number);
            Assert.AreEqual("eighty five", result);
        }
        
        [Test]
        public void With100_Returnsonehundred()
        {
            Converter convert = new Converter();
            int number = 100;
            string result = convert.Transform(number);
            Assert.AreEqual("one hundred", result);
        }

        [Test]
        public void With200_Returnsonetwo_hundred()
        {
            Converter convert = new Converter();
            int number = 200;
            string result = convert.Transform(number);
            Assert.AreEqual("two hundred", result);
        }

        [Test]
        public void With205_Returnstwo_hundred_and_five()
        {
            Converter convert = new Converter();
            int number = 205;
            string result = convert.Transform(number);
            Assert.AreEqual("two hundred and five", result);
        }

        [Test]
        public void With999_Returnsnine_hundred_and_ninety_nine()
        {
            Converter convert = new Converter();
            int number = 999;
            string result = convert.Transform(number);
            Assert.AreEqual("nine hundred and ninety nine", result);
        }

        [Test]
        public void With857_Returnseight_hundred_and_fifty_seven()
        {
            Converter convert = new Converter();
            int number = 857;
            string result = convert.Transform(number);
            Assert.AreEqual("eight hundred and fifty seven", result);
        }
    }
}