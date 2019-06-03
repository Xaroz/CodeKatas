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

        [Test]
        public void With1000_Returnsone_thousand()
        {
            Converter convert = new Converter();
            int number = 1000;
            string result = convert.Transform(number);
            Assert.AreEqual("one thousand", result);
        }

        [Test]
        public void With3000_Returnsthree_thousand()
        {
            Converter convert = new Converter();
            int number = 3000;
            string result = convert.Transform(number);
            Assert.AreEqual("three thousand", result);
        }

        [Test]
        public void With3562_Returnsthree_thousand_five_hundred_and_sixty_two()
        {
            Converter convert = new Converter();
            int number = 3562;
            string result = convert.Transform(number);
            Assert.AreEqual("three thousand five hundred and sixty two", result);
        }

        [Test]
        public void With9999_Returnsnine_thousand_nine_hundred_and_ninety_nine()
        {
            Converter convert = new Converter();
            int number = 9999;
            string result = convert.Transform(number);
            Assert.AreEqual("nine thousand nine hundred and ninety nine", result);
        }

        [Test]
        public void With9099_Returnsnine_thousand_and_ninety_nine()
        {
            Converter convert = new Converter();
            int number = 9099;
            string result = convert.Transform(number);
            Assert.AreEqual("nine thousand and ninety nine", result);
        }

        [Test]
        public void With9009_Returnsnine_thousand_and_nine()
        {
            Converter convert = new Converter();
            int number = 9009;
            string result = convert.Transform(number);
            Assert.AreEqual("nine thousand and nine", result);
        }

        [Test]
        public void With8709_Returnseight_thousand_seven_hundred_and_nine()
        {
            Converter convert = new Converter();
            int number = 8709;
            string result = convert.Transform(number);
            Assert.AreEqual("eight thousand seven hundred and nine", result);
        }

        [Test]
        public void With8019_Returnseight_thousand_and_nineteen()
        {
            Converter convert = new Converter();
            int number = 8019;
            string result = convert.Transform(number);
            Assert.AreEqual("eight thousand and nineteen", result);
        }

        [Test]
        public void With8009_Returnseight_thousand_and_nine()
        {
            Converter convert = new Converter();
            int number = 8009;
            string result = convert.Transform(number);
            Assert.AreEqual("eight thousand and nine", result);
        }
    }
}