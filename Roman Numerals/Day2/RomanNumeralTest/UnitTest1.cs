using NUnit.Framework;
using Roman_Numeral;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void With_1_Returns_I()
        {
            Transform transform = new Transform();

            int number = 1;
            string res = transform.Convert(number);

            Assert.AreEqual("I", res);
        }

        [Test]
        public void With_2_Returns_II()
        {
            Transform transform = new Transform();

            int number = 2;
            string res = transform.Convert(number);

            Assert.AreEqual("II", res);
        }

        [Test]
        public void With_3_Returns_III()
        {
            Transform transform = new Transform();

            int number = 3;
            string res = transform.Convert(number);

            Assert.AreEqual("III", res);
        }

        [Test]
        public void With_5_Returns_V()
        {
            Transform transform = new Transform();

            int number = 5;
            string res = transform.Convert(number);

            Assert.AreEqual("V", res);
        }

        [Test]
        public void With_8_Returns_VIII()
        {
            Transform transform = new Transform();

            int number = 8;
            string res = transform.Convert(number);

            Assert.AreEqual("VIII", res);
        }

        [Test]
        public void With_4_Returns_IV()
        {
            Transform transform = new Transform();

            int number = 4;
            string res = transform.Convert(number);

            Assert.AreEqual("IV", res);
        }

        [Test]
        public void With_10_Returns_X()
        {
            Transform transform = new Transform();

            int number = 10;
            string res = transform.Convert(number);

            Assert.AreEqual("X", res);
        }

        [Test]
        public void With_14_Returns_XIV()
        {
            Transform transform = new Transform();

            int number = 14;
            string res = transform.Convert(number);

            Assert.AreEqual("XIV", res);
        }

        [Test]
        public void With_12_Returns_XII()
        {
            Transform transform = new Transform();

            int number = 12;
            string res = transform.Convert(number);

            Assert.AreEqual("XII", res);
        }

        [Test]
        public void With_17_Returns_XVII()
        {
            Transform transform = new Transform();

            int number = 17;
            string res = transform.Convert(number);

            Assert.AreEqual("XVII", res);
        }

        [Test]
        public void With_20_Returns_XX()
        {
            Transform transform = new Transform();

            int number = 20;
            string res = transform.Convert(number);

            Assert.AreEqual("XX", res);
        }

        [Test]
        public void With_34_Returns_XXXIV()
        {
            Transform transform = new Transform();

            int number = 34;
            string res = transform.Convert(number);

            Assert.AreEqual("XXXIV", res);
        }

        [Test]
        public void With_9_Returns_IX()
        {
            Transform transform = new Transform();

            int number = 9;
            string res = transform.Convert(number);

            Assert.AreEqual("IX", res);
        }

        [Test]
        public void With_29_Returns_XXIX()
        {
            Transform transform = new Transform();

            int number = 29;
            string res = transform.Convert(number);

            Assert.AreEqual("XXIX", res);
        }

        [Test]
        public void With_50_Returns_L()
        {
            Transform transform = new Transform();

            int number = 50;
            string res = transform.Convert(number);

            Assert.AreEqual("L", res);
        }

        [Test]
        public void With_88_Returns_LXXXVIII()
        {
            Transform transform = new Transform();

            int number = 88;
            string res = transform.Convert(number);

            Assert.AreEqual("LXXXVIII", res);
        }

        [Test]
        public void With_40_Returns_XL()
        {
            Transform transform = new Transform();

            int number = 40;
            string res = transform.Convert(number);

            Assert.AreEqual("XL", res);
        }

        [Test]
        public void With_100_Returns_C()
        {
            Transform transform = new Transform();

            int number = 100;
            string res = transform.Convert(number);

            Assert.AreEqual("C", res);
        }

        [Test]
        public void With_185_Returns_CLXXXV()
        {
            Transform transform = new Transform();

            int number = 185;
            string res = transform.Convert(number);

            Assert.AreEqual("CLXXXV", res);
        }

        [Test]
        public void With_348_Returns_CCCXLVIII()
        {
            Transform transform = new Transform();

            int number = 348;
            string res = transform.Convert(number);

            Assert.AreEqual("CCCXLVIII", res);
        }

        [Test]
        public void With_90_Returns_XC()
        {
            Transform transform = new Transform();

            int number = 90;
            string res = transform.Convert(number);

            Assert.AreEqual("XC", res);
        }

        [Test]
        public void With_92_Returns_XCII()
        {
            Transform transform = new Transform();

            int number = 92;
            string res = transform.Convert(number);

            Assert.AreEqual("XCII", res);
        }

        [Test]
        public void With_500_Returns_D()
        {
            Transform transform = new Transform();

            int number = 500;
            string res = transform.Convert(number);

            Assert.AreEqual("D", res);
        }

        [Test]
        public void With_857_Returns_DCCCLVII()
        {
            Transform transform = new Transform();

            int number = 857;
            string res = transform.Convert(number);

            Assert.AreEqual("DCCCLVII", res);
        }

        [Test]
        public void With_400_Returns_CD()
        {
            Transform transform = new Transform();

            int number = 400;
            string res = transform.Convert(number);

            Assert.AreEqual("CD", res);
        }

        [Test]
        public void With_448_Returns_CDXLVIII()
        {
            Transform transform = new Transform();

            int number = 448;
            string res = transform.Convert(number);

            Assert.AreEqual("CDXLVIII", res);
        }

        [Test]
        public void With_1000_Returns_M()
        {
            Transform transform = new Transform();

            int number = 1000;
            string res = transform.Convert(number);

            Assert.AreEqual("M", res);
        }

        [Test]
        public void With_1302_Returns_MCCCII()
        {
            Transform transform = new Transform();

            int number = 1302;
            string res = transform.Convert(number);

            Assert.AreEqual("MCCCII", res);
        }

        [Test]
        public void With_900_Returns_CM()
        {
            Transform transform = new Transform();

            int number = 900;
            string res = transform.Convert(number);

            Assert.AreEqual("CM", res);
        }

        [Test]
        public void With_1998_Returns_MCMXCVIII()
        {
            Transform transform = new Transform();

            int number = 1998;
            string res = transform.Convert(number);

            Assert.AreEqual("MCMXCVIII", res);
        }

        [Test]
        public void With_3000_Returns_MMM()
        {
            Transform transform = new Transform();

            int number = 3000;
            string res = transform.Convert(number);

            Assert.AreEqual("MMM", res);
        }

        [Test]
        public void With_2751_Returns_MMDCCLI()
        {
            Transform transform = new Transform();

            int number = 2751;
            string res = transform.Convert(number);

            Assert.AreEqual("MMDCCLI", res);
        }
    }
}